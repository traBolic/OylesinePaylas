namespace DataGridViewClickFormApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grid1_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid1_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid1_id,
            this.grid1_ad,
            this.grid1_soyad,
            this.grid1_adres});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 111);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid2_id,
            this.grid2_ad,
            this.grid2_soyad,
            this.grid2_adres});
            this.dataGridView2.Location = new System.Drawing.Point(12, 137);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(446, 111);
            this.dataGridView2.TabIndex = 1;
            // 
            // grid1_id
            // 
            this.grid1_id.HeaderText = "id";
            this.grid1_id.Name = "grid1_id";
            this.grid1_id.ReadOnly = true;
            // 
            // grid1_ad
            // 
            this.grid1_ad.HeaderText = "Ad";
            this.grid1_ad.Name = "grid1_ad";
            // 
            // grid1_soyad
            // 
            this.grid1_soyad.HeaderText = "Soyad";
            this.grid1_soyad.Name = "grid1_soyad";
            // 
            // grid1_adres
            // 
            this.grid1_adres.HeaderText = "Adres";
            this.grid1_adres.Name = "grid1_adres";
            // 
            // grid2_id
            // 
            this.grid2_id.HeaderText = "id";
            this.grid2_id.Name = "grid2_id";
            this.grid2_id.ReadOnly = true;
            // 
            // grid2_ad
            // 
            this.grid2_ad.HeaderText = "Ad";
            this.grid2_ad.Name = "grid2_ad";
            this.grid2_ad.ReadOnly = true;
            // 
            // grid2_soyad
            // 
            this.grid2_soyad.HeaderText = "Soyad";
            this.grid2_soyad.Name = "grid2_soyad";
            this.grid2_soyad.ReadOnly = true;
            // 
            // grid2_adres
            // 
            this.grid2_adres.HeaderText = "Adres";
            this.grid2_adres.Name = "grid2_adres";
            this.grid2_adres.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 262);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid1_adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid2_adres;
    }
}
