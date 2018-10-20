using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

using Vhdgamer.Common;

namespace Vhdgamer.Forms
{
    public class FrmMain : Form
    {
        private static IntPtr runningGameHandle;

        private readonly NotifyIcon trayIcon;
        private readonly Settings settings;
        private readonly ContextMenu trayMenu;

        private VirtualDisk virtualDisk;

        public FrmMain()
        {
            // Load settings
            try
            {
                this.settings = new Settings();
            }
            catch(Exception ex)
            {
                MessageBoxHelper.ShowErrorMessageBox("Something went wrong while loading the settings:\n\n" + ex);
                Application.Exit();
            }

            // Create vhdpath directory, if it doesnt exist
            if (!Directory.Exists(Application.StartupPath + @"\" + this.settings.VhdLocalPath))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\" + this.settings.VhdLocalPath);
            }

            // Create a tray icon
            trayIcon = new NotifyIcon { Text = "Vhdgamer", Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) };

            // Add menu to tray icon and show it.
            this.trayMenu = new ContextMenu();
            this.trayMenu.Popup += delegate { this.UpdateContextMenu(); };

            trayIcon.ContextMenu = this.trayMenu;
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

            var gameName = (sender as MenuItem).Text;

            var path = Application.StartupPath + @"\" + this.settings.VhdLocalPath + @"\" + gameName + @".vhd";

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
            if (this.virtualDisk != null)
            {
                this.virtualDisk.Close();
            }

            Application.Exit();
        }

        private void MnuShowDownloader_Click(object sender, EventArgs e)
        {
            var downloaderForm = new FrmDownloader(this.settings, this.trayIcon);
            downloaderForm.ShowDialog();
        }

        private void MnuShowDeleter_Click(object sender, EventArgs e)
        {
            var modalForm = new FrmDeleter(this.settings);
            modalForm.ShowDialog();
        }

        private void MnuShowSettings_Click(object sender, EventArgs e)
        {
            var modalForm = new FrmSettings(this.settings);
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
            if (this.virtualDisk != null)
            {
                this.virtualDisk.Close();
            }

            Application.Exit();
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }

        private void UpdateContextMenu()
        {
            this.trayMenu.MenuItems.Clear();

            // get all games and add them to the context menu
            var di = new DirectoryInfo(Application.StartupPath + @"\" + this.settings.VhdLocalPath);
            var files = di.GetFiles("*.vhd");

            foreach (var fi in files)
            {
                this.trayMenu.MenuItems.Add(Path.GetFileNameWithoutExtension(fi.Name), this.TrayMenu_Click); // remove vhd extension
            };

            if (files.Length > 0)
            {
                this.trayMenu.MenuItems.Add("-");
            }

            this.trayMenu.MenuItems.Add("Downloader...", this.MnuShowDownloader_Click);
            this.trayMenu.MenuItems.Add("Clean up...", this.MnuShowDeleter_Click);
            this.trayMenu.MenuItems.Add("-");
            this.trayMenu.MenuItems.Add("Settings...", this.MnuShowSettings_Click);
            this.trayMenu.MenuItems.Add("Create new vhd...", this.MnuCreate_Click);
            this.trayMenu.MenuItems.Add("-");
            this.trayMenu.MenuItems.Add("Exit", OnExit);
        }

        private void Mount(FileInfo fi)
        {
            // open
            if (this.virtualDisk != null)
            {
                this.virtualDisk.Close();
            }

            this.virtualDisk = new VirtualDisk(fi.FullName);
            this.virtualDisk.Open();

            // attach
            if (this.virtualDisk == null)
            {
                return;
            }

            this.virtualDisk.Attach(VirtualDiskAttachOptions.None);
        }

        private void Play()
        {
            var startpath = File.ReadAllText(this.virtualDisk.GetDriveLetter() + @"\" + this.settings.StarterFilename);

            var startInfo = new ProcessStartInfo(this.virtualDisk.GetDriveLetter() + @"\" + startpath);
            startInfo.WorkingDirectory = Path.GetDirectoryName(this.virtualDisk.GetDriveLetter() + @"\" + startpath);
            var process = Process.Start(startInfo);
            runningGameHandle = process.Handle;
            process.WaitForExit();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.SuspendLayout();
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.ResumeLayout(false);

        }
    }
}