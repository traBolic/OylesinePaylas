namespace Nden1e5erAzaltFormApp
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            this.label1 = new System.Windows.Forms.Label();
            this.Sonuc = new System.Windows.Forms.ListView();
            this.nmrSayi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Gir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sonuc
            // 
            this.Sonuc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.Sonuc.Location = new System.Drawing.Point(12, 89);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(260, 251);
            this.Sonuc.TabIndex = 8;
            this.Sonuc.UseCompatibleStateImageBehavior = false;
            this.Sonuc.View = System.Windows.Forms.View.List;
            // 
            // nmrSayi
            // 
            this.nmrSayi.Font = new System.Drawing.Font("Calibri", 15F);
            this.nmrSayi.Location = new System.Drawing.Point(12, 39);
            this.nmrSayi.Maximum = decimal.MaxValue;
            this.nmrSayi.Name = "nmrSayi";
            this.nmrSayi.Size = new System.Drawing.Size(260, 32);
            this.nmrSayi.TabIndex = 9;
            this.nmrSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrSayi.ValueChanged += new System.EventHandler(this.nmrSayi_ValueChanged);
            this.nmrSayi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nmrSayi_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 352);
            this.Controls.Add(this.nmrSayi);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 390);
            this.MinimumSize = new System.Drawing.Size(300, 390);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Sonuc;
        private System.Windows.Forms.NumericUpDown nmrSayi;
    }
}
