namespace _20intPozNegSayFormApp
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
            this.txtSayilar = new System.Windows.Forms.TextBox();
            this.txtNeg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSay = new System.Windows.Forms.Button();
            this.txtPoz = new System.Windows.Forms.TextBox();
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
            // txtSayilar
            // 
            this.txtSayilar.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtSayilar.Location = new System.Drawing.Point(12, 39);
            this.txtSayilar.Name = "txtSayilar";
            this.txtSayilar.Size = new System.Drawing.Size(260, 40);
            this.txtSayilar.TabIndex = 1;
            this.txtSayilar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNeg
            // 
            this.txtNeg.Enabled = false;
            this.txtNeg.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtNeg.Location = new System.Drawing.Point(12, 210);
            this.txtNeg.Name = "txtNeg";
            this.txtNeg.ReadOnly = true;
            this.txtNeg.Size = new System.Drawing.Size(125, 40);
            this.txtNeg.TabIndex = 8;
            this.txtNeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Negatif";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSay
            // 
            this.btnSay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSay.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnSay.Location = new System.Drawing.Point(91, 96);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(106, 56);
            this.btnSay.TabIndex = 7;
            this.btnSay.Text = "Say";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // txtPoz
            // 
            this.txtPoz.Enabled = false;
            this.txtPoz.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtPoz.Location = new System.Drawing.Point(147, 210);
            this.txtPoz.Name = "txtPoz";
            this.txtPoz.ReadOnly = true;
            this.txtPoz.Size = new System.Drawing.Size(125, 40);
            this.txtPoz.TabIndex = 10;
            this.txtPoz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(147, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pozitif";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPoz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNeg);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.txtSayilar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayilar;
        private System.Windows.Forms.TextBox txtNeg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.TextBox txtPoz;
        private System.Windows.Forms.Label label4;
    }
}
