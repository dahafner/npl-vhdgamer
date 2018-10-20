using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using Gameclub.Apps.Vhdgamer.Common;

namespace Gameclub.Apps.Vhdgamer
{
    public partial class DeleterForm : Form
    {
        private readonly Options options;

        public DeleterForm(Options options)
        {
            this.InitializeComponent();

            this.options = options;
        }

        private void closeDownloaderButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            gameList.Enabled = false;
            foreach (FileInfo filocal in gameList.CheckedItems)
            {
                string localfilename = Application.StartupPath + @"\" + this.options.VhdLocalPath + @"\" + filocal.Name;
                if (File.Exists(localfilename))
                {
                    FileSystem.DeleteFile(localfilename);
                }
            }
            updateGameList();
            gameList.Enabled = true;
        }

        private void deleterForm_Load(object sender, EventArgs e)
        {
            updateGameList();
        }

        private void updateGameList()
        {
            gameList.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            gameList.Sorted = false;
            gameList.Items.Clear();

            var localdir = new DirectoryInfo(Application.StartupPath + @"\" + this.options.VhdLocalPath);
            var finfos = localdir.GetFiles("*.vhd");
            foreach (FileInfo filocal in localdir.GetFiles("*.vhd"))
            {
                gameList.Items.Add(filocal);
            }

            gameList.Sorted = true;
            Cursor.Current = Cursors.Default;
            gameList.Enabled = true;
        }

    }
}
