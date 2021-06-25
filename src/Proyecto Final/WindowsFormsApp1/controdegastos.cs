using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class controdegastos : Form
    {
        public controdegastos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new gastos().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Gasto")
            {
                gastos g = new gastos();
                g.textBox3.Text = row.Cells[0].Value.ToString();
                g.ShowDialog();
            }
        }
    }
}
