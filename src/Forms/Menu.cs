#region

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Gateway;
using LogCord.Modules;
using LogCord.Properties;

#endregion

namespace LogCord.Forms;

public partial class Menu : Form
{
    /// <summary>
    ///     Holds the sessions of client with their times.
    /// </summary>
    private static readonly List<Tuple<DiscordSession, DateTime>> Sessions = new();

    /// <summary>
    ///     Holds the sessions of client with their times.
    /// </summary>
    private static readonly List<Tuple<DiscordSession, DateTime>> BotSessions = new();

    /// <summary>
    ///     Socket client to listen events and login into account.
    /// </summary>
    private static DiscordSocketClient client;

    public Menu()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        Fader.FadeIn(this, 60);
        base.OnLoad(e);
    }

    private void accountbtn_Click(object sender, EventArgs e)
    {
        // view some client info
        if (client?.LoggedIn == false || string.IsNullOrEmpty(client?.User.Username) || client?.State != GatewayConnectionState.Connected) return;
        var sp = client.Config.SuperProperties;
        MessageBox.Show($"Client logged in to {client.User.Username}#{client.User.Discriminator}." +
                        $"\nYour account ID is {client.User.Id}.\n" +
                        $"Connection established with user agent {sp.UserAgent} and browser" +
                        $" {sp.Browser}/{sp.BrowserVersion} with device {sp.Device}.", "Account Info", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void guna2Button1_Click_1(object sender, EventArgs e)
    {
        // create messagedialog with msgdialog component
        var dialog = MessageBox.Show("Do you want to clear all devices and sessions?", "Clear devices", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (dialog == DialogResult.Yes)
        {
            Sessions.Clear();
            select.Items.Clear();
            select.Text = "";
            sessid.Text = "Session ID";
            platform.Text = "Platform";
            version.Text = "Version";
            loggedin.Text = "Logged In";
            counter.Text = "0";
        }
    }

    #region CheckBoxes

    private void chk_gateway_spoof_Click(object sender, EventArgs e)
    {
        Settings.Default.GatewaySpoof = chk_gateway_spoof.Checked;
        Settings.Default.Save();
        msgdialog.Show("Gateway spoofing is now " + (chk_gateway_spoof.Checked ? "enabled" : "disabled") + ". Restart logcord to take effects.", "Gateway Spoof");
    }

    private void chk_hide_sessions_Click(object sender, EventArgs e)
    {
        if (chk_hide_sessions.Checked)
        {
            sessid.TextChanged += SSModeSelectBox;
            // hide now
            sessid.Text = sessid.Text.ToCencoredString(sessid.Text.Length);
            select.SelectedIndex = select.SelectedIndex;
        }
        else
        {
            sessid.TextChanged -= SSModeSelectBox;
        }

        Settings.Default.HideSessions = chk_hide_sessions.Checked;
    }

    private void clearData_Click(object sender, EventArgs e)
    {
        // create messagedialog 
        var dialog = new DialogResult();
        dialog = msgdialog.Show("Restore settings to default?", "Revert to default");
        if (dialog == DialogResult.Yes)
        {
            chk_gateway_spoof.Checked = true;
            chk_hide_sessions.Checked = false;
        }
    }

    #endregion

    #region Other Events

    /// <summary>
    ///     To load the selected session to the boxes.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void select_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (select.Text.StartsWith("[Bot]"))
        {
            var sess = BotSessions[select.SelectedIndex].Item1;
            platform.Text = $"{sess.ClientInfo.OS} ({sess.ClientInfo.ClientType})";
            version.Text = $"{sess.ClientInfo.Version}";
            sessid.Text = sess.Id;
            loggedin.Text = BotSessions[select.SelectedIndex].Item2.ToLocalTime().ToString("HH:mm:ss");
        }
        else
        {
            var sess = Sessions[select.SelectedIndex].Item1;
            platform.Text = $"{sess.ClientInfo.OS} ({sess.ClientInfo.ClientType})";
            version.Text = $"{sess.ClientInfo.Version}";
            sessid.Text = sess.Id;
            loggedin.Text = Sessions[select.SelectedIndex].Item2.ToLocalTime().ToString("HH:mm:ss");
        }
    }

    /// <summary>
    ///     To switch between bots/real device sessions.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void includeBots_Click(object sender, EventArgs e)
    {
        if (includeBots.Checked)
        {
            tooltip.SetToolTip(includeBots, "Switch to devices");
            foreach (var sess in Sessions) // delete other sessions, include only bot sessions
                select.Items.Remove($"{sess.Item1.ClientInfo.OS} ({sess.Item1.ClientInfo.ClientType})");

            foreach (var bot in BotSessions) // add bot sessions
                select.Items.Add($"[Bot] {bot.Item1.Activities?.First()?.Name ?? "Unkown"}");
        }
        else
        {
            tooltip.SetToolTip(includeBots, "Switch to bots");
            foreach (var sess in Sessions) // add sessions
                select.Items.Add($"{sess.Item1.ClientInfo.OS} ({sess.Item1.ClientInfo.ClientType})");
            foreach (var bot in BotSessions) // delete bot sessions, include only real sessions
                select.Items.Remove($"[Bot] {bot.Item1.Activities?.First()?.Name ?? "Unkown"}");
        }
    }


    #region Events

    #region Protected Events

    private async void OnLoad(object sender, EventArgs e)
    {
        TopMost = true;
        TopMost = false;
        Fader.FadeIn(this, 60);
        panelMain.Location = new Point(157, 33);
        settingsPanel.Location = new Point(73, 47);
        CheckForIllegalCrossThreadCalls = false;
        // select.Animated = true;
        chk_gateway_spoof.Checked = Settings.Default.GatewaySpoof;

        await Task.Run(() =>
        {
            // Anarchy will fuck up the threads if we don't use with the async threads.
            DiscordSocketConfig cfg = null;
            if (Settings.Default.GatewaySpoof)
                cfg = new DiscordSocketConfig
                {
                    SuperProperties = new SuperProperties
                    {
                        /*
   * Hey! if you reading this please change the user agent below, as this should be constant
   * it should be replaced for every account too. But don't randomize, discord may sus from it.
   * Just keep it constant or don't replace.
   */
                        UserAgent = "Mozilla/5.0 (Linux; Android 9; AFTSS) AppleWebKit/537.36 (KHTML, like Gecko) Silk/102.1.178 like Chrome/102.0.5005.125 Safari/537.36",
                        Browser = "Firefox",
                        BrowserVersion = "1337",
                        Device = "Samsung Galaxy M22",
                        OS = "android",
                        OSVersion = "9"
                    }
                };

            client = new DiscordSocketClient(cfg);
            try
            {
                client.Login(Settings.Default.Token);
                _ = client.User; // verify connection
            }
            catch
            {
                MessageBox.Show(
                    "Failed to login, looks like your token has reset. We will clear the login data, please re-setup the app" +
                    " and continue. You will be asked for token in next launch.", "Ups!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Settings.Default.Token = "";
                Settings.Default.Save();
                Application.Restart();
            }
        });

        accountbtn.Image = client.User.Avatar.Download().Image;
        accountbtn.Text = client.User.ToString();

        client.OnSessionsUpdated += OnSessionsUpdated;
        client.OnLoggedIn += Client_OnLoggedIn;
    }

    #endregion

    /// <summary>
    ///     Fired when new device is logged in/out to account.
    /// </summary>
    /// <param name="clientx"></param>
    /// <param name="args"></param>
    private async void OnSessionsUpdated(DiscordSocketClient clientx, DiscordSessionsEventArgs args)
    {
        await Task.Run(() =>
        {
            foreach (var ss in args.Sessions)
                // add if isn't in sessions
                if (Sessions.All(x => x.Item1.Id != ss.Id) && BotSessions.All(x => x.Item1.Id != ss.Id))
                {
                    // the session is owned by clientx which we use to gather sessions. Don't care.
                    if (ss.Id == client.SessionId) continue;
                    bool isBot = ss.ClientInfo.OS.Contains("unknown") && ss.ClientInfo.Version == 0;
                    if (!isBot && Sessions.All(x => x.Item1.Id != ss.Id))
                    {
                        Sessions.Add(new Tuple<DiscordSession, DateTime>(ss, DateTime.Now));
                        select.Items.Add($"{ss.ClientInfo.OS} ({ss.ClientInfo.ClientType})");
                        counter.Text = $"{Sessions.Count}";
                        Utils.SendToast("New Device", $"{ss.ClientInfo.OS} on {ss.ClientInfo.ClientType} found on your account.");
                    }
                    else if (isBot && BotSessions.All(x => x.Item1.Id != ss.Id))
                    {
                        BotSessions.Add(new Tuple<DiscordSession, DateTime>(ss, DateTime.Now));
                    }
                }
        });
    }

    /// <summary>
    ///     Fired when login success.
    /// </summary>
    /// <param name="clients"></param>
    /// <param name="args"></param>
    private void Client_OnLoggedIn(DiscordSocketClient clients, LoginEventArgs args)
    {
        desc.Text = "connected to account " + clients.User;
        desc.ForeColor = Color.FromKnownColor(KnownColor.PaleGreen);
    }


    private async void SaveSessions_Click(object sender, EventArgs e)
    {
        await Task.Delay(250);
        if (Sessions.Count <= 0)
        {
            if (client.LoggedIn)
                MessageBox.Show(
                    "Looks like there are no device in your account. Give us some time to scrape devices.",
                    "No Device", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(
                    "We're trying to login to your account right now. Please try again in few seconds.",
                    "Not Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = "Text File | *.txt";
        sfd.Title = "Save Logs";
        sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        sfd.DefaultExt = $"log-{DateTime.Now:yyyy-MM-dd}.txt";
        sfd.ShowDialog();
        if (sfd.FileName != "")
        {
            int device = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var sess in Sessions)
            {
                var session = sess.Item1;
                sb.AppendLine($"Device {device} >\n" +
                              $" - OS Info: {session.ClientInfo.ClientType} {session.ClientInfo.OS} ({session.ClientInfo.Version})\n" +
                              $" - Session ID: {session.Id}\n" +
                              $" - Added to list in: {sess.Item2:HH:mm:ss}\n");
                device++;
            }

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false))
            {
                await sw.WriteAsync(sb.ToString());
            }

            await Task.Run(() => { b3.Image = Resources.ok; }).ContinueWith(async t => { await Task.Delay(550); })
                .ContinueWith(a => { b3.Image = Resources.save; });
        }
    }


    private async void CloseBtn_Click(object sender, EventArgs e)
    {
        // exit
        try
        {
            client.Logout();
            client.Dispose();
        }
        catch
        {
        }

        Settings.Default.Save();
        Fader.FadeOut(this, 70);
        await Task.Delay(250);
        Environment.Exit(0);
    }

    #endregion

    private void counter_Click(object sender, EventArgs e)
    {
        MessageBox.Show("This is list of the all logged in devices to your account. " +
                        "If you don't know any of these devices, you should change your password." +
                        " This will replace your token and make logged out all devices.", "Problems?",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    /// <summary>
    ///     To copy current session ID when button double clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void sessid_DoubleClick(object sender, EventArgs e)
    {
        if (sessid.Text != "Session ID")
        {
            string sesssid = sessid.Text;
            Clipboard.SetText(sessid.Text);
            sessid.Text = "Copied!";
            await Task.Delay(1250);
            sessid.Text = sesssid;
        }
    }

    private void b2_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", "https://github.com/arshx86");
    }


    /// <summary>
    ///     Auto-censorship the session ID from the box.
    /// </summary>
    private void SSModeSelectBox(object sender, EventArgs e)
    {
        sessid.Text = sessid.Text.ToCencoredString(sessid.Text.Length);
    }

    #region Panel Switchers

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        settingsPanel.Visible = false;
        Utils.AnimateControl(panelMain, Utils.Effect.Roll, 200, 360);
    }

    private void guna2Button3_Click(object sender, EventArgs e)
    {
        panelMain.Visible = false;
        Utils.AnimateControl(settingsPanel, Utils.Effect.Roll, 200, 360);
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        Settings.Default.Reset();
        Settings.Default.Save();
        Application.Restart();
    }

    #endregion

    private void FormOnShown(object sender, EventArgs e)
    {
        // force refresh
        Activate();
        Focus();
    }

    #endregion
}