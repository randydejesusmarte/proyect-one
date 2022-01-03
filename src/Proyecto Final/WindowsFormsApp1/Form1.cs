using Thot_Librery.Menu;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Desabilitado
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fecha.Start();
        }
        public int id;
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtFactura_Click(object sender, EventArgs e)
        {
            using Facturar form = new() { _id = id };
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            L_Fecha.Text = DateTime.Now.ToString();
        }
    }
}
