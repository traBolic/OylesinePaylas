namespace OBEBBulFormApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOBEB = new System.Windows.Forms.Button();
            this.nmrSayi1 = new System.Windows.Forms.NumericUpDown();
            this.nmrSayi2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi2)).BeginInit();
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
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Font = new System.Drawing.Font("Calibri", 20F);
            this.txtSonuc.Location = new System.Drawing.Point(12, 320);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(260, 40);
            this.txtSonuc.TabIndex = 8;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sonuç";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOBEB
            // 
            this.btnOBEB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOBEB.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnOBEB.Location = new System.Drawing.Point(91, 202);
            this.btnOBEB.Name = "btnOBEB";
            this.btnOBEB.Size = new System.Drawing.Size(106, 56);
            this.btnOBEB.TabIndex = 7;
            this.btnOBEB.Text = "OBEB";
            this.btnOBEB.UseVisualStyleBackColor = true;
            this.btnOBEB.Click += new System.EventHandler(this.btnOBEB_Click);
            // 
            // nmrSayi1
            // 
            this.nmrSayi1.Font = new System.Drawing.Font("Calibri", 20F);
            this.nmrSayi1.Location = new System.Drawing.Point(12, 39);
            this.nmrSayi1.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nmrSayi1.Name = "nmrSayi1";
            this.nmrSayi1.Size = new System.Drawing.Size(260, 40);
            this.nmrSayi1.TabIndex = 10;
            this.nmrSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrSayi2
            // 
            this.nmrSayi2.Font = new System.Drawing.Font("Calibri", 20F);
            this.nmrSayi2.Location = new System.Drawing.Point(12, 126);
            this.nmrSayi2.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nmrSayi2.Name = "nmrSayi2";
            this.nmrSayi2.Size = new System.Drawing.Size(260, 40);
            this.nmrSayi2.TabIndex = 11;
            this.nmrSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 372);
            this.Controls.Add(this.nmrSayi2);
            this.Controls.Add(this.nmrSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnOBEB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 410);
            this.MinimumSize = new System.Drawing.Size(300, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOBEB;
        private System.Windows.Forms.NumericUpDown nmrSayi1;
        private System.Windows.Forms.NumericUpDown nmrSayi2;
    }
}
