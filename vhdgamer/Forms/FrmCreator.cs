using System;
using System.IO;
using System.Windows.Forms;

using Vhdgamer.Common;

namespace Vhdgamer.Forms
{
    public partial class FrmCreator : Form
    {
        public FrmCreator()
        {
            this.InitializeComponent();
        }

        private void BtnSelectGameFolder_Click(object sender, EventArgs e)
        {
            if (this.FbdGameFolder.ShowDialog() == DialogResult.OK)
            {
                this.TxtGameFolder.Text = this.FbdGameFolder.SelectedPath;

                var folderSize = FileHelper.CalculateFolderSize(this.TxtGameFolder.Text);
                this.LblFolderSize.Text = folderSize + " MB";

                var directoryInfo = new DirectoryInfo(this.TxtGameFolder.Text);
                this.TxtName.Text = directoryInfo.Name;

                this.NudSize.Value = Convert.ToDecimal(folderSize * 1.1);
            }
        }

        private void BtnSelectSaveFileName_Click(object sender, EventArgs e)
        {
            if (this.SfdSaveFileName.ShowDialog() == DialogResult.OK)
            {
                this.TxtSaveFileName.Text = this.SfdSaveFileName.FileName;                
            }            
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtGameFolder.Text))
            {
                MessageBoxHelper.ShowErrorMessageBox("Please select a folder containing the desired game.");
                return;
            }

            if (string.IsNullOrEmpty(this.TxtName.Text))
            {
                MessageBoxHelper.ShowErrorMessageBox("Please enter a game name.");
                return;
            }

            if (this.NudSize.Value <= 0)
            {
                MessageBoxHelper.ShowErrorMessageBox("Size must be bigger than 0.");
                return;
            }

            if (string.IsNullOrEmpty(this.TxtSaveFileName.Text))
            {
                MessageBoxHelper.ShowErrorMessageBox("Please select a save filepath.");
                return;
            }

            var size = Convert.ToInt64(this.NudSize.Value) * 1024 * 1024;            

            var vgc = new VhdGameCreator();
            vgc.Create(size, this.TxtGameFolder.Text, this.TxtSaveFileName.Text, this.TxtName.Text, string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
