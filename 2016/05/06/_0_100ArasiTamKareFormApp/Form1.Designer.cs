namespace _0_100ArasiTamKareFormApp
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
            this.listSayilar = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listSayilar
            // 
            this.listSayilar.Location = new System.Drawing.Point(12, 12);
            this.listSayilar.Name = "listSayilar";
            this.listSayilar.Size = new System.Drawing.Size(260, 75);
            this.listSayilar.TabIndex = 0;
            this.listSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.listSayilar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 137);
            this.MinimumSize = new System.Drawing.Size(300, 137);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listSayilar;

    }
}
