using System;
using System.Windows.Forms;

using Vhdgamer.Common;

namespace Vhdgamer.Forms
{
    public partial class FrmSettings : Form
    {
        private readonly Settings settings;

        public FrmSettings(Settings settings)
        {
            if (settings == null) throw new ArgumentNullException(nameof(settings));

            this.InitializeComponent();

            this.settings = settings;
            this.TxtServerFolder.Text = this.settings.VhdServerPath;
        }

        private void BtnSelectServerFolder_Click(object sender, EventArgs e)
        {
            if (this.FbdServerpath.ShowDialog() == DialogResult.OK)
            {
                this.TxtServerFolder.Text = this.FbdServerpath.SelectedPath;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.settings.VhdServerPath = this.TxtServerFolder.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}