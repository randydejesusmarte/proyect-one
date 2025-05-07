namespace WindowsFormsApp1
{
    public partial class Controdegastos : Form
    {
        public Controdegastos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el formulario Gastos como un cuadro de diálogo
            using (Gastos gastosForm = new())
            {
                _ = gastosForm.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                // Evita procesar clics en encabezados o celdas inválidas
                return;
            }

            DataGridView? grid = sender as DataGridView;
            if (grid == null)
            {
                return;
            }

            DataGridViewRow? row = grid.CurrentRow;
            if (row == null)
            {
                return;
            }

            // Verifica si la columna clickeada es "Gasto"
            if (grid.Columns[e.ColumnIndex].Name == "Gasto")
            {
                using (Gastos g = new())
                {
                    // Asigna el valor de la celda a textBox3 si no es nulo
                    g.textBox3.Text = row.Cells[0]?.Value?.ToString() ?? string.Empty;
                    _ = g.ShowDialog();
                }
            }
        }
    }
}
