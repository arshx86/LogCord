#region

#nullable enable
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Discord.Gateway;
using Guna.UI2.WinForms;
using LogCord.Modules;
using LogCord.Modules.Models;
using LogCord.Properties;
using Microsoft.VisualBasic;

#endregion

namespace LogCord.Forms;

public partial class Setup : Form
{
    private static DiscordSocketClient client;

    public Setup()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        Fader.FadeIn(this, 60);
        base.OnLoad(e);
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        if (m.Msg == 0x84)
            m.Result = (IntPtr)0x2;
    }

    private void Setup_Load(object sender, EventArgs e)
    {
        if (Settings.Default.Token != "")
        {
            Hide();
            Menu mfrom = new Menu();
            mfrom.ShowDialog();
            Close();
        }
    }

    private void auto_Click(object sender, EventArgs e)
    {
        // todo
    }

    /* Manual option */
    private void man_Click(object sender, EventArgs e)
    {
        string token = Interaction.InputBox("Enter your token", "Token");
        if (token != "")
        {
            DiscordAccount? acc = Utils.GetAccount(token);
            if (acc is null)
            {
                msgdialog.Show("Token is incorrect, Please try again.", "Invalid token");
                return;
            }

            msgdialog.Buttons = MessageDialogButtons.YesNo;
            var dresult = msgdialog.Show("Would you like to continue that account?", $"{acc.Username}#{acc.Discriminator}");
            if (dresult == DialogResult.Yes)
            {
                Settings.Default.Token = token;
                Settings.Default.Save();
                Hide();
                Menu mfrom = new Menu();
                mfrom.ShowDialog();
                Close();
            }
        }
        else
        {
            msgdialog.Show("Unkown error.", "Sorry!");
        }
    }

    private void t_github_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", "https://github.com/arshx86");
    }
}