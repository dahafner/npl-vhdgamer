using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

using Vhdgamer.Common;

namespace Vhdgamer.Forms
{
    public partial class FrmDeleter : Form
    {
        private readonly Options options;

        public FrmDeleter(Options options)
        {
            this.InitializeComponent();

            this.options = options;
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {
            this.UpdateGameList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete " + this.LbxGames.CheckedItems.Count + " games?", "Vhdgamer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                return;
            }

            try
            {
                this.LbxGames.Enabled = false;
                foreach (FileInfo filocal in this.LbxGames.CheckedItems)
                {
                    string localfilename = Application.StartupPath + @"\" + this.options.VhdLocalPath + @"\" + filocal.Name;
                    if (File.Exists(localfilename))
                    {
                        FileSystem.DeleteFile(localfilename);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong while deleting the games:\r\n\r\n" + ex, "Vhdgamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.UpdateGameList();
            this.LbxGames.Enabled = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateGameList()
        {
            this.LbxGames.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            this.LbxGames.Sorted = false;
            this.LbxGames.Items.Clear();

            var localdir = new DirectoryInfo(Application.StartupPath + @"\" + this.options.VhdLocalPath);
            var finfos = localdir.GetFiles("*.vhd");
            foreach (FileInfo filocal in localdir.GetFiles("*.vhd"))
            {
                this.LbxGames.Items.Add(filocal);
            }

            this.LbxGames.Sorted = true;
            Cursor.Current = Cursors.Default;
            this.LbxGames.Enabled = true;
        }
    }
}