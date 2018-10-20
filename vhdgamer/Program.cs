using System;
using System.Windows.Forms;
using System.Threading;

using Vhdgamer.Forms;
using Vhdgamer.Common;

namespace Vhdgamer
{
    public static class Program
    {
        private static Mutex AppMutex = new Mutex(false, "VhdGamerMainApp");

        [STAThread]
        static void Main()
        {
            if (AppMutex.WaitOne(0, false))
            {
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