using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

using Vhdgamer.Common;
using Vhdgamer.Services;

namespace Vhdgamer.Forms
{
    public partial class FrmMain : Form
    {
        private static IntPtr runningGameHandle;

        private readonly NotifyIcon trayIcon;
        private readonly SettingsService settingsService;
        private readonly ContextMenuStrip trayMenu;

        //private VirtualDisk virtualDisk;

        public FrmMain()
        {
            // Load settings
            try
            {
                this.settingsService = new SettingsService();
            }
            catch(Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox("Something went wrong while loading the settings:\n\n" + ex);
                Application.Exit();
            }

            // Create vhdpath directory, if it doesnt exist
            if (!Directory.Exists(Application.StartupPath + @"\" + this.settingsService.Settings.VhdLocalPath))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\" + this.settingsService.Settings.VhdLocalPath);
            }

            // Create a tray icon
            trayIcon = new NotifyIcon { Text = "Vhdgamer", Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) };

            // Add menu to tray icon and show it.
            this.trayMenu = new ContextMenuStrip();
            //this.trayMenu.Popup += delegate { this.UpdateContextMenu(); };

            trayIcon.ContextMenuStrip = this.trayMenu;
            trayIcon.MouseClick += new MouseEventHandler(TrayIcon_Click);
            trayIcon.Visible = true;

            this.UpdateContextMenu();

            // Show info for user (if click on tooltop -> show menu)
            ////trayIcon.ShowBalloonTip(1000, "Vhdgamer", "Click here to start or download games...", ToolTipIcon.Info);
            ////trayIcon.BalloonTipClicked += delegate { trayIcon.GetType().InvokeMember("ShowContextMenu", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null, trayIcon, null); };
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
            base.OnLoad(e);
        }
        
        private void TrayMenu_Click(object sender, EventArgs e)
        {
            ////if (runningGameHandle.ToInt32() != 0)
            ////{
            ////    MessageboxHelper.ShowErrorMessageBox("It's not recommenced to start more than one game at a time!");
            ////}

            var gameName = (sender as ToolStripMenuItem).Text;

            var path = Application.StartupPath + @"\" + this.settingsService.Settings.VhdLocalPath + @"\" + gameName + @".vhd";

            Cursor.Current = Cursors.WaitCursor;
            this.trayIcon.ShowBalloonTip(1000, "vhdgamer", "Starting \"" + gameName + "\"...", ToolTipIcon.Info);
            this.Mount(new FileInfo(path));
            this.Play();
            Cursor.Current = Cursors.Default;
        }
                
        private void TrayIcon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                trayIcon.GetType().InvokeMember("ShowContextMenu", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, null, trayIcon, null);
            }
        }

        private void SysTrayApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.virtualDisk != null)
            //{
            //    this.virtualDisk.Close();
            //}

            Application.Exit();
        }

        private void MnuShowDownloader_Click(object sender, EventArgs e)
        {
            var downloaderForm = new FrmDownloader(this.settingsService, this.trayIcon);
            downloaderForm.ShowDialog();
        }

        private void MnuShowDeleter_Click(object sender, EventArgs e)
        {
            var modalForm = new FrmDeleter(this.settingsService);
            modalForm.ShowDialog();
        }

        private void MnuShowSettings_Click(object sender, EventArgs e)
        {
            var modalForm = new FrmSettings(this.settingsService);
            if (modalForm.ShowDialog() == DialogResult.OK)
            {
                this.UpdateContextMenu();
            }
        }

        private void MnuCreate_Click(object sender, EventArgs e)
        {
            var creator = new FrmCreator();
            creator.ShowDialog();
        }

        private void OnExit(object sender, EventArgs e)
        {
            //if (this.virtualDisk != null)
            //{
            //    this.virtualDisk.Close();
            //}

            Application.Exit();
        }

        private void UpdateContextMenu()
        {
            this.trayMenu.Items.Clear();

            // get all games and add them to the context menu
            var di = new DirectoryInfo(Path.Combine(Application.StartupPath, this.settingsService.Settings.VhdLocalPath));
            var files = di.GetFiles("*.vhd");

            foreach (var fi in files)
            {
                this.trayMenu.Items.Add(Path.GetFileNameWithoutExtension(fi.Name), null, this.TrayMenu_Click); // remove vhd extension
            };

            if (files.Length > 0)
            {
                this.trayMenu.Items.Add("-");
            }

            this.trayMenu.Items.Add("Downloader...", null, this.MnuShowDownloader_Click);
            this.trayMenu.Items.Add("Clean up...", null, this.MnuShowDeleter_Click);
            this.trayMenu.Items.Add("-");
            this.trayMenu.Items.Add("Settings...", null, this.MnuShowSettings_Click);
            this.trayMenu.Items.Add("Create new vhd...", null, this.MnuCreate_Click);
            this.trayMenu.Items.Add("-");
            this.trayMenu.Items.Add("Exit", null, this.OnExit);
        }

        private void Mount(FileInfo fi)
        {
            //// open
            //if (this.virtualDisk != null)
            //{
            //    this.virtualDisk.Close();
            //}

            //this.virtualDisk = new VirtualDisk(fi.FullName);
            //this.virtualDisk.Open();

            //// attach
            //if (this.virtualDisk == null)
            //{
            //    return;
            //}

            //this.virtualDisk.Attach(VirtualDiskAttachOptions.None);
        }

        private void Play()
        {
            //var startpath = File.ReadAllText(this.virtualDisk.GetDriveLetter() + @"\" + this.settings.StarterFilename);

            //var startInfo = new ProcessStartInfo(this.virtualDisk.GetDriveLetter() + @"\" + startpath);
            //startInfo.WorkingDirectory = Path.GetDirectoryName(this.virtualDisk.GetDriveLetter() + @"\" + startpath);
            //var process = Process.Start(startInfo);
            //runningGameHandle = process.Handle;
            //process.WaitForExit();
        }

        
    }
}