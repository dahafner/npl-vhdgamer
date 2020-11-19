using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

using Vhdgamer.Common;
using Vhdgamer.Services;

namespace Vhdgamer.Forms
{
    public partial class FrmDownloader : Form
    {
        private readonly SettingsService settingsService;
        private readonly NotifyIcon trayIcon;

        public FrmDownloader(SettingsService settingsService, NotifyIcon trayIcon)
        {
            this.InitializeComponent();

            this.settingsService = settingsService;
            this.trayIcon = trayIcon;

            this.LblGamelist.Text += " (Server: " + this.settingsService.Settings.VhdServerPath + ")";
        }

        private void DownloaderForm_Load(object sender, EventArgs e)
        {
            this.UpdateGamelist();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            this.LbxGames.Enabled = false;
            foreach (FileInfo fiserver in this.LbxGames.CheckedItems)
            {
                string localfilename = Application.StartupPath + @"\" + this.settingsService.Settings.VhdLocalPath + @"\" + fiserver.Name;
                if (!File.Exists(localfilename))
                {
                    try
                    {
                        FileSystem.CopyFile(fiserver.FullName, localfilename, UIOption.AllDialogs);
                    }
                    catch (OperationCanceledException)
                    {
                        UpdateGamelist();
                        this.LbxGames.Enabled = true;
                        return;
                    }
                }
            }

            // notification indicating finished download
            this.trayIcon.ShowBalloonTip(1000, "Vhdgamer", "Downloads finished", ToolTipIcon.Info);
            this.LbxGames.Enabled = true;
        }

        private void UpdateGamelist()
        {
            this.LbxGames.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            this.LbxGames.Sorted = false;
            this.LbxGames.Items.Clear();

            var localdir = new DirectoryInfo(Application.StartupPath + @"\" + this.settingsService.Settings.VhdLocalPath);
            var serverdir = new DirectoryInfo(this.settingsService.Settings.VhdServerPath);

            // if the server directory doesn't exists or isn't reachable
            if (!serverdir.Exists)
            {
                MessageBoxHelper.ShowErrorMessageBox("Server path \"" + serverdir.FullName + "\" not accessible");
                this.Cursor = Cursors.Default;
                this.Close();
                return;
            }

            var localFiles = localdir.GetFiles("*.vhd");
            foreach (var serverFile in serverdir.GetFiles("*.vhd"))
            {
                this.LbxGames.Items.Add(serverFile);
                foreach (FileInfo localFile in localFiles)
                {
                    // check if a vhd is already on the users hd (if yes, check it)
                    if (localFile.Name == serverFile.Name)
                    {
                        // mark last inserted element
                        this.LbxGames.SetItemChecked(this.LbxGames.Items.Count - 1, true);
                    }
                }
            }

            this.LbxGames.Sorted = true;
            Cursor.Current = Cursors.Default;
            this.LbxGames.Enabled = true;
        }
    }
}