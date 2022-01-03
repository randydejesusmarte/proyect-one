using HttpNamespaceManager.UI;
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

        private readonly int idcliente;
        internal int _id;
        private void Add_Click(object sender, EventArgs e)
        {
            //idcliente = Convert.ToInt32(idfactura.Text);
            //_id = Convert.ToInt32(idfactura.Text);
            new Agregar_Factura().Agregar(Convert.ToInt32(idfactura.Text), idcliente, producto.Text, precio.Text, cantidad.Text, monto.Text, monto.Text, _id, DateTime.Now.ToString());

            dataGridView1.DataSource = new FillData().Datos(idfactura.Text);
            dataGridView1.AutoResizeColumns();
        }

        private void autoid()
        {
            idfactura.Text = new Auto_increment().Cont().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // precio.Text = Microsoft.VisualBasic.Interaction.InputBox("Texto de la pregunta","Titulo del diálogo", "Respuesta por defecto");
            InputBox.Show("Buscar Entrada", "Numero de Entrada", out string texto);
            idfactura.Text = texto;
        }
    }
}
