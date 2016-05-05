namespace BolmeKullanmadanBolmeFormApp
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBol = new System.Windows.Forms.Button();
            this.txtKalan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtSayi1.Location = new System.Drawing.Point(12, 39);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(260, 40);
            this.txtSayi1.TabIndex = 1;
            this.txtSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtSayi2.Location = new System.Drawing.Point(12, 126);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(260, 40);
            this.txtSayi2.TabIndex = 3;
            this.txtSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Sayı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBolum
            // 
            this.txtBolum.Enabled = false;
            this.txtBolum.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtBolum.Location = new System.Drawing.Point(12, 320);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.ReadOnly = true;
            this.txtBolum.Size = new System.Drawing.Size(125, 40);
            this.txtBolum.TabIndex = 8;
            this.txtBolum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bölüm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBol
            // 
            this.btnBol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBol.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnBol.Location = new System.Drawing.Point(91, 205);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(106, 56);
            this.btnBol.TabIndex = 7;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // txtKalan
            // 
            this.txtKalan.Enabled = false;
            this.txtKalan.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtKalan.Location = new System.Drawing.Point(147, 320);
            this.txtKalan.Name = "txtKalan";
            this.txtKalan.ReadOnly = true;
            this.txtKalan.Size = new System.Drawing.Size(125, 40);
            this.txtKalan.TabIndex = 10;
            this.txtKalan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(147, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kalan";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 372);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKalan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBolum);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 410);
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
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.TextBox txtKalan;
        private System.Windows.Forms.Label label4;
    }
}
