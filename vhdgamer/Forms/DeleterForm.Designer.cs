﻿namespace Gameclub.Apps.Vhdgamer
{
    partial class DeleterForm
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
            this.closeDownloaderButton = new System.Windows.Forms.Button();
            this.vhdList = new System.Windows.Forms.Label();
            this.gameList = new System.Windows.Forms.CheckedListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeDownloaderButton
            // 
            this.closeDownloaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeDownloaderButton.Location = new System.Drawing.Point(244, 329);
            this.closeDownloaderButton.Name = "closeDownloaderButton";
            this.closeDownloaderButton.Size = new System.Drawing.Size(80, 23);
            this.closeDownloaderButton.TabIndex = 2;
            this.closeDownloaderButton.Text = "Close";
            this.closeDownloaderButton.UseVisualStyleBackColor = true;
            this.closeDownloaderButton.Click += new System.EventHandler(this.closeDownloaderButton_Click);
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
            // gameList
            // 
            this.gameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gameList.CheckOnClick = true;
            this.gameList.FormattingEnabled = true;
            this.gameList.Location = new System.Drawing.Point(12, 25);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(312, 289);
            this.gameList.TabIndex = 6;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(12, 329);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 23);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(335, 364);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.gameList);
            this.Controls.Add(this.vhdList);
            this.Controls.Add(this.closeDownloaderButton);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "deleterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleter";
            this.Load += new System.EventHandler(this.deleterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeDownloaderButton;
        private System.Windows.Forms.Label vhdList;
        private System.Windows.Forms.CheckedListBox gameList;
        private System.Windows.Forms.Button deleteButton;
    }
}