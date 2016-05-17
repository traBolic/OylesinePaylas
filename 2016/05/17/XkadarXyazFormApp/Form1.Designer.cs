namespace XkadarXyazFormApp
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
            this.nmrSayi = new System.Windows.Forms.NumericUpDown();
            this.listSonuc = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrSayi
            // 
            this.nmrSayi.Font = new System.Drawing.Font("Calibri", 15F);
            this.nmrSayi.Location = new System.Drawing.Point(13, 13);
            this.nmrSayi.Name = "nmrSayi";
            this.nmrSayi.Size = new System.Drawing.Size(259, 32);
            this.nmrSayi.TabIndex = 0;
            this.nmrSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrSayi.ValueChanged += new System.EventHandler(this.nmrSayi_ValueChanged);
            this.nmrSayi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nmrSayi_ValueChanged);
            // 
            // listSonuc
            // 
            this.listSonuc.Location = new System.Drawing.Point(13, 52);
            this.listSonuc.Name = "listSonuc";
            this.listSonuc.Size = new System.Drawing.Size(259, 198);
            this.listSonuc.TabIndex = 1;
            this.listSonuc.UseCompatibleStateImageBehavior = false;
            this.listSonuc.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listSonuc);
            this.Controls.Add(this.nmrSayi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrSayi;
        private System.Windows.Forms.ListView listSonuc;
    }
}
