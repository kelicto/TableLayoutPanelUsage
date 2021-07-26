using System;
using System.Windows.Forms;

using KeLi.HelloTableLayoutPanel.App.Forms;

namespace KeLi.HelloTableLayoutPanel.App
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}