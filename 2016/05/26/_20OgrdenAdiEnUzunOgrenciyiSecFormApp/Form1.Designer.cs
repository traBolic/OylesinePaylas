namespace _20OgrdenAdiEnUzunOgrenciyiSecFormApp
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
            this.txtOgrenciler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOgrenciler
            // 
            this.txtOgrenciler.Location = new System.Drawing.Point(12, 35);
            this.txtOgrenciler.Multiline = true;
            this.txtOgrenciler.Name = "txtOgrenciler";
            this.txtOgrenciler.Size = new System.Drawing.Size(150, 145);
            this.txtOgrenciler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenciler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBul
            // 
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBul.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnBul.Location = new System.Drawing.Point(55, 207);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(70, 36);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtSonuc.Location = new System.Drawing.Point(12, 283);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(150, 32);
            this.txtSonuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F);
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "En uzun isimli öğrenci";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOgrenciler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label2;

    }
}

