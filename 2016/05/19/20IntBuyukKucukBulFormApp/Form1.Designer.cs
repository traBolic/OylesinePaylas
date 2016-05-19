namespace _20IntBuyukKucukBulFormApp
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
            this.btnBul = new System.Windows.Forms.Button();
            this.txtKucuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuyuk = new System.Windows.Forms.TextBox();
            this.txtSayilar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBul.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnBul.Location = new System.Drawing.Point(102, 45);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(80, 35);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtKucuk
            // 
            this.txtKucuk.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtKucuk.Location = new System.Drawing.Point(12, 106);
            this.txtKucuk.Name = "txtKucuk";
            this.txtKucuk.ReadOnly = true;
            this.txtKucuk.Size = new System.Drawing.Size(100, 32);
            this.txtKucuk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Küçük";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(172, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Büyük";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuyuk
            // 
            this.txtBuyuk.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtBuyuk.Location = new System.Drawing.Point(172, 106);
            this.txtBuyuk.Name = "txtBuyuk";
            this.txtBuyuk.ReadOnly = true;
            this.txtBuyuk.Size = new System.Drawing.Size(100, 32);
            this.txtBuyuk.TabIndex = 5;
            // 
            // txtSayilar
            // 
            this.txtSayilar.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSayilar.Location = new System.Drawing.Point(12, 12);
            this.txtSayilar.Name = "txtSayilar";
            this.txtSayilar.Size = new System.Drawing.Size(260, 27);
            this.txtSayilar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.txtSayilar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuyuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKucuk);
            this.Controls.Add(this.btnBul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuyuk;
        private System.Windows.Forms.TextBox txtSayilar;

    }
}

