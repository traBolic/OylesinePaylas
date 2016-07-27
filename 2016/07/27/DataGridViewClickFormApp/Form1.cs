using System;
using System.Windows.Forms;

namespace DataGridViewClickFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("1", "Mehmet", "Kaya", "Büyükçekmece İstanbul");
            dataGridView1.Rows.Add("2", "Ali", "Bal", "Fatih İstanbul");
            dataGridView1.Rows.Add("3", "Yeşim", "Bal", "Başakşehir İstanbul");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (Convert.ToString(row.Cells[0].Value) != "")
                    {
                        int g2Yeni = dataGridView2.Rows.Add();
                        for (int i = 0; i < dataGridView2.Rows[g2Yeni].Cells.Count; i++)
                        {
                            dataGridView2.Rows[g2Yeni].Cells[i].Value = row.Cells[i].Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
