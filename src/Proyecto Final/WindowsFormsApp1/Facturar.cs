using Thot_Librery.Codigo_Factura;

namespace WindowsFormsApp1
{
    public partial class Facturar : Form
    {
        public Facturar()
        {
            InitializeComponent();
            new textrefresh().Textrefresh(nomcli);
            autoid();
        }

        private int idcliente;
        internal int id_empleado;
        private void Add_Click(object sender, EventArgs e)
        {
            idcliente = Convert.ToInt32(idfactura.Text);
            id_empleado = Convert.ToInt32(idfactura.Text);
            new Agregar_Factura().Agregar(Convert.ToInt32(idfactura.Text), idcliente, producto.Text, precio.Text, cantidad.Text, monto.Text, monto.Text, id_empleado, DateTime.Now.ToString());

            dataGridView1.DataSource = new FillData().Datos(idfactura.Text);
            dataGridView1.AutoResizeColumns();
        }

        private void autoid()
        {
            idfactura.Text = new Auto_increment().Cont().ToString();
        }
    }
}
