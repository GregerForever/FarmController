using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmController
{
    public partial class Form1 : Form
    {
        Thread thread = new Thread(() => 
        {
            while (true) 
            {
                if (status == true)
                {
                    keybd_event(0x44, 0, 0, 0);
                    Thread.Sleep(duration * 1000);
                    keybd_event(0x44, 0, 0x2, 0);
                    keybd_event(0x41, 0, 0, 0);
                    Thread.Sleep(duration * 1000);
                    keybd_event(0x41, 0, 0x2, 0);
                }
            }
        });

        static int duration;
        static bool status;
        static bool keyStatus;
        Keys hotkey;
        int WMhotkey = 0x312;


        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WMhotkey)
            {
                ThreadSwitch();
                m.Result = (IntPtr)0;
                return;
            }

            base.WndProc(ref m);
        }

        void ThreadSwitch()
        {
            switch (status)
            {
                case true:
                    status = false;
                    BeginButton.Text = "Старт";
                    break;
                case false:
                    status = true;
                    BeginButton.Text = "Стоп";
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            hotkey = Keys.F1;
            bool res = RegisterHotKey(this.Handle, 1, 0, (uint)hotkey);
            HotkeyButton.Text = hotkey.ToString();

            thread.Start();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            ThreadSwitch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status = false;
            duration = 1;
        }

        private void NumericDuration_ValueChanged(object sender, EventArgs e)
        {
            duration = (int)NumericDuration.Value;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }

        private void HotkeyButton_Click(object sender, EventArgs e)
        {
            switch (keyStatus)
            {
                case true:
                    keyStatus = false;
                    HotkeyButton.Text = hotkey.ToString();
                    break;
                case false:
                    keyStatus = true;
                    HotkeyButton.Text = "Выбрать...";
                    break;
            }
        }

        private void HotkeyButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyStatus == true) 
            {
                hotkey = e.KeyData;
                HotkeyButton.Text = hotkey.ToString();
                RegisterHotKey(this.Handle, 1, 0, (uint)hotkey);
                keyStatus = false;
            }
        }
    }
}
