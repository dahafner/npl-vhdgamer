using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VhdMountTest
{
    public partial class FrmMain : Form
    {
        private ImageMounter imageMounter;

        public FrmMain()
        {
            this.InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnMount_Click(object sender, EventArgs e)
        {
            this.imageMounter = new ImageMounter(this.textBox1.Text);
            this.imageMounter.Mount();
            this.BtnUnmount.Enabled = true;
            this.BtnMount.Enabled = false;
        }

        private void BtnUnmount_Click(object sender, EventArgs e)
        {
            this.imageMounter.Unmount();
            this.BtnUnmount.Enabled = false;
            this.BtnMount.Enabled = true;
        }
    }
}
