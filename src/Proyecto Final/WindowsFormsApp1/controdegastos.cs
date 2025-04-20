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
            _ = new gastos().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow? row = ((DataGridView)sender).CurrentRow;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Gasto")
            {
                gastos g = new();
                g.textBox3.Text = row.Cells[0].Value.ToString();
                _ = g.ShowDialog();
            }
        }
    }
}
