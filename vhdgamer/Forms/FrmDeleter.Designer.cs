namespace Vhdgamer.Forms
{
    partial class FrmDeleter
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.vhdList = new System.Windows.Forms.Label();
            this.LbxGames = new System.Windows.Forms.CheckedListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(255, 369);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(80, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // vhdList
            // 
            this.vhdList.AutoSize = true;
            this.vhdList.Location = new System.Drawing.Point(12, 9);
            this.vhdList.Name = "vhdList";
            this.vhdList.Size = new System.Drawing.Size(54, 13);
            this.vhdList.TabIndex = 4;
            this.vhdList.Text = "Game List";
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
            this.LbxGames.Size = new System.Drawing.Size(324, 334);
            this.LbxGames.TabIndex = 6;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(91, 369);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(158, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete selected games";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmDeleter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(347, 404);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LbxGames);
            this.Controls.Add(this.vhdList);
            this.Controls.Add(this.BtnClose);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FrmDeleter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleter";
            this.Load += new System.EventHandler(this.FrmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label vhdList;
        private System.Windows.Forms.CheckedListBox LbxGames;
        private System.Windows.Forms.Button BtnDelete;
    }
}