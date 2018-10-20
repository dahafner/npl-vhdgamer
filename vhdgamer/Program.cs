using System;
using System.Windows.Forms;
using System.Threading;

namespace Gameclub.Apps.Vhdgamer
{
    public static class Program
    {
        // for checking if application already started
        private static Mutex AppMutex = new Mutex(false, "MainApp");

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AppMutex.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SysTrayApp());
            }
            else
            {
                MessageBox.Show("Vhdgamer is already running. Check your SysTray for a black dice symbol.");
            }

            Application.Exit();
        }
    }
}
