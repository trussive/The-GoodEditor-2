using System;
using System.Text;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Runtime.InteropServices;

namespace TheGoodEditor2
{
    public static class DiscordRPCController
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public static DiscordRpcClient client;

        public static System.Windows.Forms.Timer timer1;

        internal static void ToggleDiscordRichPresence(bool value)
        {
            if (value)
            {
                Initialize();
            }
            else
            {
                try
                {
                    if (client != null)
                        client.Dispose();
                    if (timer1 != null)
                        timer1.Enabled = false;
                }
                catch { }
            }
        }

        public static void Initialize()
        {
            timer1 = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            timer1.Tick += timer1_Tick;

            // My discord client
            client = new DiscordRpcClient("792873339987034132")
            {
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };
            client.Initialize();
            timer1.Start();
            var activeWindowInit = "a ho file";
            setPresence(activeWindowInit);
        }

        public static void setPresence(string activeWindow)
        {
            try
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Editing a Level",
                    State = "Editing " + activeWindow,
                    Assets = new Assets()
                    {
                        LargeImageKey = "ico_the_goodeditor2",
                        LargeImageText = "The GoodEditor 2 Basic Level Editor"
                    }
                });
            }
            catch
            {

            }
        }

        public static void timer1_Tick(object sender, EventArgs e)
        {
            //timer that elapses every second to check for active window updates and adjust presence if needed
            timer1.Stop();
            GetActiveWindow();
            timer1.Start();
        }

        public static void GetActiveWindow()
        {
            var activeWindowTemp = "null";
            const int nChars = 256;
            IntPtr handle;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                activeWindowTemp = Buff.ToString();
            }
            if (activeWindowTemp != "null")
            {
                // loads ho
                if (activeWindowTemp.EndsWith(".ho") || (activeWindowTemp.EndsWith(".ho")) || (activeWindowTemp.EndsWith(".ho")) || (activeWindowTemp.EndsWith(".ho")))
                {
                    var activeWindow = activeWindowTemp;
                    setPresence(activeWindow);
                }
            }
        }
    }
}