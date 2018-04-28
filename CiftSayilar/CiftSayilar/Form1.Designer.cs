namespace CiftSayilar
{
    partial class Form1
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
            this.listBoxYaz = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxYaz
            // 
            this.listBoxYaz.FormattingEnabled = true;
            this.listBoxYaz.Location = new System.Drawing.Point(217, 7);
            this.listBoxYaz.Name = "listBoxYaz";
            this.listBoxYaz.Size = new System.Drawing.Size(333, 433);
            this.listBoxYaz.TabIndex = 6;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(57, 88);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 5;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(82, 135);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 23);
            this.btnYaz.TabIndex = 4;
            this.btnYaz.Text = "YAZDIR";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 447);
            this.Controls.Add(this.listBoxYaz);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxYaz;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnYaz;
    }
}

