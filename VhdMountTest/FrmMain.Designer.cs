
namespace VhdMountTest
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnMount = new System.Windows.Forms.Button();
            this.BtnUnmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "C:\\repos\\minecraft.vhd";
            // 
            // BtnMount
            // 
            this.BtnMount.Location = new System.Drawing.Point(12, 41);
            this.BtnMount.Name = "BtnMount";
            this.BtnMount.Size = new System.Drawing.Size(75, 23);
            this.BtnMount.TabIndex = 1;
            this.BtnMount.Text = "Mount";
            this.BtnMount.UseVisualStyleBackColor = true;
            this.BtnMount.Click += new System.EventHandler(this.BtnMount_Click);
            // 
            // BtnUnmount
            // 
            this.BtnUnmount.Enabled = false;
            this.BtnUnmount.Location = new System.Drawing.Point(93, 41);
            this.BtnUnmount.Name = "BtnUnmount";
            this.BtnUnmount.Size = new System.Drawing.Size(75, 23);
            this.BtnUnmount.TabIndex = 1;
            this.BtnUnmount.Text = "Unmount";
            this.BtnUnmount.UseVisualStyleBackColor = true;
            this.BtnUnmount.Click += new System.EventHandler(this.BtnUnmount_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 86);
            this.Controls.Add(this.BtnUnmount);
            this.Controls.Add(this.BtnMount);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnMount;
        private System.Windows.Forms.Button BtnUnmount;
    }
}

