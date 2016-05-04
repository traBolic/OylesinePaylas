namespace _20IntCiftOrtalaFormsApp
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
            this.sonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar (boşlukla ayırın):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSayilar
            // 
            this.txtSayilar.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayilar.Location = new System.Drawing.Point(12, 39);
            this.txtSayilar.Name = "txtSayilar";
            this.txtSayilar.Size = new System.Drawing.Size(260, 48);
            this.txtSayilar.TabIndex = 1;
            this.txtSayilar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sonuc
            // 
            this.sonuc.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.Location = new System.Drawing.Point(12, 140);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(260, 44);
            this.sonuc.TabIndex = 2;
            this.sonuc.Text = "Sonuç";
            this.sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13F);
            this.button1.Location = new System.Drawing.Point(97, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.txtSayilar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayilar;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button button1;
    }
}
