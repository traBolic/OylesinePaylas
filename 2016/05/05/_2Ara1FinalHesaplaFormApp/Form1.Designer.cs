namespace _2Ara1FinalHesaplaFormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt1Ara = new System.Windows.Forms.TextBox();
            this.txt2Ara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Ara Sınav";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1Ara
            // 
            this.txt1Ara.Font = new System.Drawing.Font("Calibri", 15F);
            this.txt1Ara.Location = new System.Drawing.Point(12, 39);
            this.txt1Ara.MaxLength = 3;
            this.txt1Ara.Name = "txt1Ara";
            this.txt1Ara.Size = new System.Drawing.Size(260, 32);
            this.txt1Ara.TabIndex = 1;
            this.txt1Ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2Ara
            // 
            this.txt2Ara.Font = new System.Drawing.Font("Calibri", 15F);
            this.txt2Ara.Location = new System.Drawing.Point(12, 113);
            this.txt2Ara.MaxLength = 3;
            this.txt2Ara.Name = "txt2Ara";
            this.txt2Ara.Size = new System.Drawing.Size(260, 32);
            this.txt2Ara.TabIndex = 3;
            this.txt2Ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Ara Sınav";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtSonuc.Location = new System.Drawing.Point(12, 371);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(260, 40);
            this.txtSonuc.TabIndex = 8;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sonuç";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHesapla
            // 
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHesapla.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnHesapla.Location = new System.Drawing.Point(81, 260);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(125, 56);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtFinal.Location = new System.Drawing.Point(12, 185);
            this.txtFinal.MaxLength = 3;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(260, 32);
            this.txtFinal.TabIndex = 13;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Final Sınavı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 423);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txt2Ara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt1Ara);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1Ara;
        private System.Windows.Forms.TextBox txt2Ara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label5;
    }
}
