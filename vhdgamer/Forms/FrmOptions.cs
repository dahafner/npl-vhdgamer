using System;
using System.Windows.Forms;

using Vhdgamer.Common;

namespace Vhdgamer.Forms
{
    public partial class FrmOptions : Form
    {
        private readonly Options options;

        public FrmOptions(Options options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            this.InitializeComponent();

            this.options = options;
            this.TxtServerFolder.Text = this.options.VhdServerPath;
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
            this.options.VhdServerPath = this.TxtServerFolder.Text;
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