using System.Data;
using System.Drawing.Printing;
using Thot_Librery.Entrada;

namespace WindowsFormsApp1
{
    public partial class Entrada : Form
    {
        private const string FamilyName = "Century Gothic";
        private static readonly Font font = new(FamilyName, 10, FontStyle.Regular);
        private const int space = 25;

        public Entrada()
        {
            InitializeComponent();
            try
            {
                Datatables();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        internal int id_empleado;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                //si esta vacio
                MessageBox.Show("Favor llenar todo", "Advertencia");
            }
            else
            {
                //si esta lleno
                agregar();
            }
        }
        public bool lleno; // Variable utilizada para saber si hay algún TextBox vacio.
        private bool validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == string.Empty) // Verificamos que no este vacio.
                {
                    lleno = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            return lleno;
        }

        private string CONDICION = "Al Contado";
        public static DataTable Dt { get; } = new();

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 5;
            e.Graphics.DrawString(Settings.Default.Namesbusiness, new(FamilyName, 14, FontStyle.Bold), Brushes.Black, new Point(0 + 65, y += space));
            e.Graphics.DrawString("Llegando a la rotonda", font, Brushes.Black, new Point(0 + 40, y += space));
            e.Graphics.DrawString("Santiago, Rep Dom. Tel:849-216-1333", font, Brushes.Black, new Point(0, y += space));

            e.Graphics.DrawLine(new Pen(Color.Black, 2), 500, y += 25, 0, y);
            e.Graphics.DrawString("Factura de contado", font, Brushes.Black, new Point(0 + 25, y += 5));
            //contar los servisios a entrados + 1 
            e.Graphics.DrawString("FACTURA.: " + "B000000043", font, Brushes.Black, new Point(0, y += space));
            e.Graphics.DrawString("FECHA...: " + DateTime.Now.ToString(), font, Brushes.Black, new Point(0, y += space));
            //optener nombre del usuario
            e.Graphics.DrawString("ATENDIDO POR.: " + Settings.Default.Idusuario, font, Brushes.Black, new Point(0, y += space));
            e.Graphics.DrawString("Tecnico.: " + txtmecanico.Text, font, Brushes.Black, new Point(0, y += space));

            CONDICION = radioButton1.Checked == true ? "Al Contado" : "A Credito";


            /*
              if (radioButton1.Checked == true)
            { 
                CONDICION = "Al Contado"; 
            }
              else 
            {
                CONDICION = "A Credito";
            }
            */


            e.Graphics.DrawString("CONDICION.: " + CONDICION, font, Brushes.Black, new Point(0, y += space));
            e.Graphics.DrawString("CLIENTE.: " + TxtCliente.Text + "  #0005", font, Brushes.Black, new Point(0, y += space));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 500, y += 25, 0, y);
            e.Graphics.DrawString("Servicio", font, Brushes.Black, new Point(0, y));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 500, y += 25, 0, y);


            foreach (DataRow row in Dt.Rows)
            {
                e.Graphics.DrawString(row["Servicio"].ToString(), font, Brushes.Black, new Point(0, y += space));
                //e.Graphics.DrawString(textBox4.Text, font, Brushes.Black, new Point(0, y += space));
            }

            e.Graphics.DrawString("Gracias por preferirnos", font, Brushes.Black, new Point(25, y += space));
            e.Graphics.Dispose();
            printPreviewDialog1.ClientSize = Screen.PrimaryScreen.WorkingArea.Size;
            printPreviewDialog1.DesktopLocation = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void Datatables()
        {
            Dt.Columns.Clear();
            Dt.Columns.Add("Servicio");
            dataGridView1.DataSource = Dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { CONDICION = "Al Contado"; }
            else { CONDICION = "A Credito"; }
            Ventrada entrada = new Ventrada();
            foreach (DataRow row in Dt.Rows)
            {
                entrada.Insetar(
                    IDEnt.Text,
                    TxtCliente.Text,
                    Settings.Default.Idusuario.ToString(),
                    txtmecanico.Text,
                    CONDICION,
                    row
                    );
            }
            entrada.cant(IDEnt.Text);
        }
        private void agregar()
        {
            DataRow? row = Dt.NewRow();
            row["Servicio"] = textBox3.Text;
            Dt.Rows.Add(row);
            textBox3.Text = "";
            dataGridView1.AutoResizeColumn(0);
        }
        private void Entrada_Load(object sender, EventArgs e)
        {
            IDEnt.Text = new Auto_increment().Cont().ToString();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregar();
            }
        }
    }
}
