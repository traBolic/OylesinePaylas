namespace OrtasiniBulFormApp
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
            this.btnBul = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numSayi1 = new System.Windows.Forms.NumericUpDown();
            this.numSayi2 = new System.Windows.Forms.NumericUpDown();
            this.numSayi3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi3)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 83);
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
            // btnBul
            // 
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBul.Font = new System.Drawing.Font("Calibri", 20F);
            this.btnBul.Location = new System.Drawing.Point(81, 260);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(125, 56);
            this.btnBul.TabIndex = 7;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "3. Sayı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSayi1
            // 
            this.numSayi1.Font = new System.Drawing.Font("Calibri", 15F);
            this.numSayi1.Location = new System.Drawing.Point(12, 39);
            this.numSayi1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSayi1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSayi1.Name = "numSayi1";
            this.numSayi1.Size = new System.Drawing.Size(260, 32);
            this.numSayi1.TabIndex = 14;
            this.numSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSayi2
            // 
            this.numSayi2.Font = new System.Drawing.Font("Calibri", 15F);
            this.numSayi2.Location = new System.Drawing.Point(12, 113);
            this.numSayi2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSayi2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSayi2.Name = "numSayi2";
            this.numSayi2.Size = new System.Drawing.Size(260, 32);
            this.numSayi2.TabIndex = 15;
            this.numSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numSayi3
            // 
            this.numSayi3.Font = new System.Drawing.Font("Calibri", 15F);
            this.numSayi3.Location = new System.Drawing.Point(12, 185);
            this.numSayi3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSayi3.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSayi3.Name = "numSayi3";
            this.numSayi3.Size = new System.Drawing.Size(260, 32);
            this.numSayi3.TabIndex = 16;
            this.numSayi3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 423);
            this.Controls.Add(this.numSayi3);
            this.Controls.Add(this.numSayi2);
            this.Controls.Add(this.numSayi1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSayi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSayi1;
        private System.Windows.Forms.NumericUpDown numSayi2;
        private System.Windows.Forms.NumericUpDown numSayi3;
    }
}
