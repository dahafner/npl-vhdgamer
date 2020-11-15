namespace Vhdgamer.Forms
{
    partial class FrmCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblFolderSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtGameFolder = new System.Windows.Forms.TextBox();
            this.BtnSelectGameFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSelectSaveFileName = new System.Windows.Forms.Button();
            this.TxtSaveFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NudSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.FbdGameFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SfdSaveFileName = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LblFolderSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtGameFolder);
            this.groupBox1.Controls.Add(this.BtnSelectGameFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select game folder";
            // 
            // LblFolderSize
            // 
            this.LblFolderSize.AutoSize = true;
            this.LblFolderSize.Location = new System.Drawing.Point(145, 48);
            this.LblFolderSize.Name = "LblFolderSize";
            this.LblFolderSize.Size = new System.Drawing.Size(42, 13);
            this.LblFolderSize.TabIndex = 3;
            this.LblFolderSize.Text = "0 Bytes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size of the selected folder:";
            // 
            // TxtGameFolder
            // 
            this.TxtGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGameFolder.Location = new System.Drawing.Point(6, 21);
            this.TxtGameFolder.Name = "TxtGameFolder";
            this.TxtGameFolder.Size = new System.Drawing.Size(445, 20);
            this.TxtGameFolder.TabIndex = 1;
            // 
            // BtnSelectGameFolder
            // 
            this.BtnSelectGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectGameFolder.Location = new System.Drawing.Point(457, 19);
            this.BtnSelectGameFolder.Name = "BtnSelectGameFolder";
            this.BtnSelectGameFolder.Size = new System.Drawing.Size(27, 23);
            this.BtnSelectGameFolder.TabIndex = 0;
            this.BtnSelectGameFolder.Text = "...";
            this.BtnSelectGameFolder.UseVisualStyleBackColor = true;
            this.BtnSelectGameFolder.Click += new System.EventHandler(this.BtnSelectGameFolder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnSelectSaveFileName);
            this.groupBox2.Controls.Add(this.TxtSaveFileName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NudSize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MB";
            // 
            // BtnSelectSaveFileName
            // 
            this.BtnSelectSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectSaveFileName.Location = new System.Drawing.Point(456, 66);
            this.BtnSelectSaveFileName.Name = "BtnSelectSaveFileName";
            this.BtnSelectSaveFileName.Size = new System.Drawing.Size(27, 23);
            this.BtnSelectSaveFileName.TabIndex = 7;
            this.BtnSelectSaveFileName.Text = "...";
            this.BtnSelectSaveFileName.UseVisualStyleBackColor = true;
            this.BtnSelectSaveFileName.Click += new System.EventHandler(this.BtnSelectSaveFileName_Click);
            // 
            // TxtSaveFileName
            // 
            this.TxtSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSaveFileName.Location = new System.Drawing.Point(58, 69);
            this.TxtSaveFileName.Name = "TxtSaveFileName";
            this.TxtSaveFileName.Size = new System.Drawing.Size(392, 20);
            this.TxtSaveFileName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Save to:";
            // 
            // NudSize
            // 
            this.NudSize.Location = new System.Drawing.Point(58, 43);
            this.NudSize.Maximum = new decimal(new int[] {
            2097152,
            0,
            0,
            0});
            this.NudSize.Name = "NudSize";
            this.NudSize.Size = new System.Drawing.Size(89, 20);
            this.NudSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(58, 17);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(425, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(427, 199);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(346, 199);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // FbdGameFolder
            // 
            this.FbdGameFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SfdSaveFileName
            // 
            this.SfdSaveFileName.Filter = "VHD files|*.vhd";
            this.SfdSaveFileName.RestoreDirectory = true;
            // 
            // FrmCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 231);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new vhd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblFolderSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGameFolder;
        private System.Windows.Forms.Button BtnSelectGameFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSelectSaveFileName;
        private System.Windows.Forms.TextBox TxtSaveFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.FolderBrowserDialog FbdGameFolder;
        private System.Windows.Forms.SaveFileDialog SfdSaveFileName;
        private System.Windows.Forms.Label label5;
    }
}