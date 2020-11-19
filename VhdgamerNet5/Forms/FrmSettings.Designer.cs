namespace Vhdgamer.Forms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSelectServerFolder = new System.Windows.Forms.Button();
            this.TxtServerFolder = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.FbdServerPath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSelectLocalPath = new System.Windows.Forms.Button();
            this.TxtLocalFolder = new System.Windows.Forms.TextBox();
            this.FbdLocalPath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnSelectServerFolder);
            this.groupBox1.Controls.Add(this.TxtServerFolder);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(540, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server folder";
            // 
            // BtnSelectServerFolder
            // 
            this.BtnSelectServerFolder.Location = new System.Drawing.Point(493, 20);
            this.BtnSelectServerFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSelectServerFolder.Name = "BtnSelectServerFolder";
            this.BtnSelectServerFolder.Size = new System.Drawing.Size(40, 27);
            this.BtnSelectServerFolder.TabIndex = 4;
            this.BtnSelectServerFolder.Text = "...";
            this.BtnSelectServerFolder.UseVisualStyleBackColor = true;
            this.BtnSelectServerFolder.Click += new System.EventHandler(this.BtnSelectServerFolder_Click);
            // 
            // TxtServerFolder
            // 
            this.TxtServerFolder.Location = new System.Drawing.Point(7, 22);
            this.TxtServerFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtServerFolder.Name = "TxtServerFolder";
            this.TxtServerFolder.Size = new System.Drawing.Size(479, 23);
            this.TxtServerFolder.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(468, 158);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(88, 27);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(373, 158);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(88, 27);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FbdServerPath
            // 
            this.FbdServerPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnSelectLocalPath);
            this.groupBox2.Controls.Add(this.TxtLocalFolder);
            this.groupBox2.Location = new System.Drawing.Point(15, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(540, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local folder";
            // 
            // BtnSelectLocalPath
            // 
            this.BtnSelectLocalPath.Location = new System.Drawing.Point(493, 20);
            this.BtnSelectLocalPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSelectLocalPath.Name = "BtnSelectLocalPath";
            this.BtnSelectLocalPath.Size = new System.Drawing.Size(40, 27);
            this.BtnSelectLocalPath.TabIndex = 4;
            this.BtnSelectLocalPath.Text = "...";
            this.BtnSelectLocalPath.UseVisualStyleBackColor = true;
            this.BtnSelectLocalPath.Click += new System.EventHandler(this.BtnSelectLocalPath_Click);
            // 
            // TxtLocalFolder
            // 
            this.TxtLocalFolder.Location = new System.Drawing.Point(7, 22);
            this.TxtLocalFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtLocalFolder.Name = "TxtLocalFolder";
            this.TxtLocalFolder.Size = new System.Drawing.Size(479, 23);
            this.TxtLocalFolder.TabIndex = 1;
            // 
            // FbdLocalPath
            // 
            this.FbdLocalPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 194);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSelectServerFolder;
        private System.Windows.Forms.TextBox TxtServerFolder;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.FolderBrowserDialog FbdServerPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSelectLocalPath;
        private System.Windows.Forms.TextBox TxtLocalFolder;
        private System.Windows.Forms.FolderBrowserDialog FbdLocalPath;
    }
}