using ScreenParser.DAO;
using ScreenParser.DAO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenParser
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Accessor a = new Accessor();
            HotKeyManager.RegisterHotKey(Keys.D1, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.Escape, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.D2, KeyModifiers.Alt);
            //HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_StartCapture);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_KillProgram);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_OpenImage);
            Application.EnableVisualStyles();
            Application.Run(new Viewer());
        }

        private static void HotKeyManager_StartCapture(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.D1 && e.Modifiers == KeyModifiers.Alt)
            {
                Form f = new FormRect();
                f.Bounds = Screen.PrimaryScreen.Bounds;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.TopMost = true;
                f.BackColor = Color.White;
                f.Opacity = .25;
                f.FormBorderStyle = FormBorderStyle.None;
                f.ShowDialog();
            }
        }

        private static void HotKeyManager_KillProgram(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.Escape && e.Modifiers == KeyModifiers.Alt)
            {
                Application.Exit();
            }
        }

        private static void HotKeyManager_OpenImage(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.D2 && e.Modifiers == KeyModifiers.Alt)
            {
                Process.Start("explorer.exe", ScreenParser.Capture.imagePath);
            }
        }

    }
}
