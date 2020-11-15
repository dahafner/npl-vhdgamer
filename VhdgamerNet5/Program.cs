using System;
using System.Threading;
using System.Windows.Forms;
using Vhdgamer.Common;
using Vhdgamer.Forms;

namespace VhdgamerNet5
{
    static class Program
    {
        private static Mutex AppMutex = new Mutex(false, "VhdGamerMainApp");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AppMutex.WaitOne(0, false))
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
            else
            {
                MessageBoxHelper.ShowErrorMessageBox("Vhdgamer is already running.");
            }

            Application.Exit();
        }
    }
}
