using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace saving_online_pages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //нажатие
        public const int KEYEVENTF_KEYUP = 0x0002; //отпускание
        public const int VK_LCONTROL = 0xA2; //код ctrl
        public const int S = 0x53; //код S
        public const int ENTER = 0x0D;//код Enter

        public static void PressKeys()
        {
            keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(S, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(S, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
        }
        public static void Enter()
        {
            keybd_event(ENTER, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(ENTER, 0, KEYEVENTF_KEYUP, 0);
        }
        private void save_website_Click(object sender, EventArgs e)
        {
            var website = link.Text;
            System.Diagnostics.Process.Start(website);
            Thread.Sleep(5000);
            PressKeys();
            Thread.Sleep(1000);
            Enter();
        }

    }
}
