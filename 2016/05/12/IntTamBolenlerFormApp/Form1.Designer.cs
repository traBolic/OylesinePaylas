namespace IntTamBolenlerFormApp
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
            this.numSayi = new System.Windows.Forms.NumericUpDown();
            this.btnListele = new System.Windows.Forms.Button();
            this.listSayilar = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // numSayi
            // 
            this.numSayi.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numSayi.Location = new System.Drawing.Point(12, 12);
            this.numSayi.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numSayi.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numSayi.Name = "numSayi";
            this.numSayi.Size = new System.Drawing.Size(174, 32);
            this.numSayi.TabIndex = 0;
            this.numSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnListele
            // 
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListele.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnListele.Location = new System.Drawing.Point(192, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(80, 31);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // listSayilar
            // 
            this.listSayilar.Location = new System.Drawing.Point(12, 50);
            this.listSayilar.Name = "listSayilar";
            this.listSayilar.Size = new System.Drawing.Size(260, 200);
            this.listSayilar.TabIndex = 2;
            this.listSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listSayilar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.numSayi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSayi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSayi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListView listSayilar;
    }
}
