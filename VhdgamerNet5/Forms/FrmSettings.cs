﻿using System;
using System.Windows.Forms;

using Vhdgamer.Services;

namespace Vhdgamer.Forms
{
    public partial class FrmSettings : Form
    {
        private readonly SettingsService settingsService;

        public FrmSettings(SettingsService settingsService)
        {
            if (settingsService == null) throw new ArgumentNullException(nameof(settingsService));

            this.InitializeComponent();

            this.settingsService = settingsService;
            this.TxtServerFolder.Text = this.settingsService.Settings.VhdServerPath;
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
            this.settingsService.SetVhdServerPath(this.TxtServerFolder.Text);
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