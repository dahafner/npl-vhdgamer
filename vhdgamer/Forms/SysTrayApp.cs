using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using Gameclub.Apps.Vhdgamer.Common;

namespace Gameclub.Apps.Vhdgamer
{
    public class SysTrayApp : Form
    {
        public static NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private readonly Options options;

        VirtualDisk _disk;
        public static IntPtr runningGameHandle;

        public SysTrayApp()
        {
            // Load settings
            try
            {
                this.options = new Options();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong while loading the settings:\n\n" + ex, "VhdGamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // create vhdpath directory, if it doesnt exist
            if (!Directory.Exists(Application.StartupPath + @"\" + this.options.VhdLocalPath))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\" + this.options.VhdLocalPath);
            }

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "vhdgamer";
            trayIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Add menu to tray icon and show it.
            trayMenu = new ContextMenu();
            trayMenu.Popup += delegate { updateContextMenu(); };

            trayIcon.ContextMenu = trayMenu;
            trayIcon.MouseClick += new MouseEventHandler(trayIcon_Click);
            trayIcon.Visible = true;

            updateContextMenu();

            // info for user (if click on tooltop -> show menu)
            trayIcon.ShowBalloonTip(1000, "vhdgamer", "Click here to start or download games...", ToolTipIcon.Info);
            trayIcon.BalloonTipClicked += delegate { trayIcon.GetType().InvokeMember("ShowContextMenu", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null, trayIcon, null); };
        }

        public void updateContextMenu()
        {
            trayMenu.MenuItems.Clear();

            // get all games and add them to the context menu
            DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\" + this.options.VhdLocalPath);
            foreach (FileInfo fi in di.GetFiles("*.vhd"))
            {
                trayMenu.MenuItems.Add(Path.GetFileNameWithoutExtension(fi.Name), trayMenu_Click); // remove vhd extension
            };

            // Downloader
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Downloader...", OnShowDownloader);
            // Deleter
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Clean Up...", OnShowDeleter);
            // Exit button
            trayMenu.MenuItems.Add("-");
            trayMenu.MenuItems.Add("Exit", OnExit);
        }

        // handles a click on a game entry (then mounts and starts)
        private void trayMenu_Click(object sender, EventArgs e)
        {
            if (runningGameHandle.ToInt32() != 0)
            {
                MessageBox.Show("It's not recommenced to start more than one game at a time!");
            }

            String path = Application.StartupPath + @"\" + this.options.VhdLocalPath + @"\" + (sender as MenuItem).Text + @".vhd"; // add vhd extension

            Cursor.Current = Cursors.WaitCursor;
            trayIcon.ShowBalloonTip(1000, "vhdgamer", "Mounting \"" + (sender as MenuItem).Text + "\"...", ToolTipIcon.Info);
            mount(new FileInfo(path));
            trayIcon.ShowBalloonTip(1000, "vhdgamer", "Starting \"" + (sender as MenuItem).Text + "\"...", ToolTipIcon.Info);
            play();
            Cursor.Current = Cursors.Default;
        }

        // hide form and task bar entry
        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
            base.OnLoad(e);
        }

        // handles click on tray icon
        private void trayIcon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                trayIcon.GetType().InvokeMember("ShowContextMenu", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null, trayIcon, null);
            }
        }

        private void SysTrayApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._disk != null) { this._disk.Close(); }
            Application.Exit();
        }

        private void OnShowDownloader(object sender, EventArgs e)
        {
            DownloaderForm modalForm = new DownloaderForm(this.options);
            modalForm.ShowDialog(this);
        }

        private void OnShowDeleter(object sender, EventArgs e)
        {
            var modalForm = new DeleterForm(this.options);
            modalForm.ShowDialog(this);
        }

        private void OnExit(object sender, EventArgs e)
        {
            if (this._disk != null) { this._disk.Close(); }
            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing) { trayIcon.Dispose(); }
            base.Dispose(isDisposing);
        }

        public void mount(FileInfo fi)
        {
            // open
            if (this._disk != null) { this._disk.Close(); }
            this._disk = new VirtualDisk(fi.FullName);
            this._disk.Open();

            // attach
            if (this._disk == null) { return; }
            this._disk.Attach(VirtualDiskAttachOptions.None);
        }

        public void umount(FileInfo fi)
        {
            // detach
            if (this._disk == null) { return; }
            this._disk.Detach();
        }

        public void play()
        {
            string startpath = File.ReadAllText(this._disk.GetDriveLetter() + @"\" + this.options.StarterFilename);

            ProcessStartInfo startInfo = new ProcessStartInfo(this._disk.GetDriveLetter() + @"\" + startpath);
            startInfo.WorkingDirectory = Path.GetDirectoryName(this._disk.GetDriveLetter() + @"\" + startpath);
            Process P = Process.Start(startInfo);
            runningGameHandle = P.Handle;
            P.WaitForExit();
        }

    }
}
