namespace Vhdgamer.Forms
{
    partial class FrmDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownloader));
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblGamelist = new System.Windows.Forms.Label();
            this.LbxGames = new System.Windows.Forms.CheckedListBox();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(244, 329);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(80, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblGamelist
            // 
            this.LblGamelist.AutoSize = true;
            this.LblGamelist.Location = new System.Drawing.Point(12, 9);
            this.LblGamelist.Name = "LblGamelist";
            this.LblGamelist.Size = new System.Drawing.Size(54, 13);
            this.LblGamelist.TabIndex = 4;
            this.LblGamelist.Text = "Game List";
            // 
            // LbxGames
            // 
            this.LbxGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbxGames.CheckOnClick = true;
            this.LbxGames.FormattingEnabled = true;
            this.LbxGames.Location = new System.Drawing.Point(12, 25);
            this.LbxGames.Name = "LbxGames";
            this.LbxGames.Size = new System.Drawing.Size(312, 289);
            this.LbxGames.TabIndex = 6;
            // 
            // BtnDownload
            // 
            this.BtnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDownload.Location = new System.Drawing.Point(146, 329);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(92, 23);
            this.BtnDownload.TabIndex = 7;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = true;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // FrmDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 364);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.LbxGames);
            this.Controls.Add(this.LblGamelist);
            this.Controls.Add(this.BtnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FrmDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.Load += new System.EventHandler(this.DownloaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblGamelist;
        private System.Windows.Forms.CheckedListBox LbxGames;
        private System.Windows.Forms.Button BtnDownload;
    }
}