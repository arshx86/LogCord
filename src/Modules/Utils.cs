#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LogCord.Modules.Models;
using Newtonsoft.Json;

#endregion

namespace LogCord.Modules;

internal static class Utils
{
    public static void SendToast(string title, string desc)
    {
        NotifyIcon ni = new NotifyIcon
        {
            BalloonTipIcon = ToolTipIcon.Info,
            Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly()?.Location),
            BalloonTipTitle = title,
            BalloonTipText = desc
        };
        ni.Visible = true;
        ni.ShowBalloonTip(3000);
    }

    public static void AnimateControl(Control ctl, Effect effect, int msec, int angle)
    {
        int flags = effmap[(int)effect];
        if (ctl.Visible)
        {
            flags |= 0x10000;
            angle += 180;
        }
        else
        {
            if (ctl.TopLevelControl == ctl) flags |= 0x20000;
            else if (effect == Effect.Blend) throw new ArgumentException();
        }

        flags |= dirmap[angle % 360 / 45];
        bool ok = AnimateWindow(ctl.Handle, msec, flags);
        if (!ok) throw new Exception("Animation failed");
        ctl.Visible = !ctl.Visible;
    }

    public static DiscordAccount? GetAccount(string token)
    {
        using (var wr = new WebClient())
        {
            wr.Headers.Add("Authorization", token);
            try
            {
                return JsonConvert.DeserializeObject<DiscordAccount>(wr.DownloadString("https://discord.com/api/v9/users/@me"));
            }
            catch
            {
                return null;
            }
        }
    }

    #region Helpers

    public static string ToCencoredString(this string str, int length = 10)
    {
        if (string.IsNullOrEmpty(str)) return str;
        string censored = new string('*', length);
        if (str.Length <= length) return censored;
        return censored + str.Substring(length);
    }


    private static readonly int[] dirmap =
    {
        1,
        5,
        4,
        6,
        2,
        10,
        8,
        9
    };

    private static readonly int[] effmap =
    {
        0,
        0x400000,
        0x10,
        0x80000
    };

    [DllImport("user32.dll")]
    private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

    public enum Effect
    {
        Roll,
        Slide,
        Center,
        Blend
    }

    #endregion
}