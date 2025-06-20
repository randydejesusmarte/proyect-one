using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
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
                InitializeDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal int id_empleado;
        private string CONDICION = "Al Contado";
        public static DataTable Dt { get; } = new();

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario(this))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AgregarServicio();
            }
        }

        private bool ValidarFormulario(Form formulario)
        {
            foreach (Control control in formulario.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true; // Si hay un TextBox vacío, retorna true
                }
            }
            return false;
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int y = 5;
                e.Graphics.DrawString(Settings.Default.Namesbusiness, new Font(FamilyName, 14, FontStyle.Bold), Brushes.Black, new Point(65, y += space));
                e.Graphics.DrawString("Llegando a la rotonda", font, Brushes.Black, new Point(40, y += space));
                e.Graphics.DrawString("Santiago, Rep Dom. Tel:849-216-1333", font, Brushes.Black, new Point(0, y += space));

                e.Graphics.DrawLine(Pens.Black, 0, y += 25, 500, y);
                e.Graphics.DrawString("Factura de contado", font, Brushes.Black, new Point(25, y += 5));
                e.Graphics.DrawString($"FACTURA.: B000000043", font, Brushes.Black, new Point(0, y += space));
                e.Graphics.DrawString($"FECHA...: {DateTime.Now}", font, Brushes.Black, new Point(0, y += space));
                e.Graphics.DrawString($"ATENDIDO POR.: {Settings.Default.Idusuario}", font, Brushes.Black, new Point(0, y += space));
                e.Graphics.DrawString($"TÉCNICO.: {txtmecanico.Text}", font, Brushes.Black, new Point(0, y += space));

                CONDICION = radioButton1.Checked ? "Al Contado" : "A Crédito";
                e.Graphics.DrawString($"CONDICIÓN.: {CONDICION}", font, Brushes.Black, new Point(0, y += space));
                e.Graphics.DrawString($"CLIENTE.: {TxtCliente.Text}  #0005", font, Brushes.Black, new Point(0, y += space));
                e.Graphics.DrawLine(Pens.Black, 0, y += 25, 500, y);
                e.Graphics.DrawString("Servicio", font, Brushes.Black, new Point(0, y));
                e.Graphics.DrawLine(Pens.Black, 0, y += 25, 500, y);

                foreach (DataRow row in Dt.Rows)
                {
                    e.Graphics.DrawString(row["Servicio"].ToString(), font, Brushes.Black, new Point(0, y += space));
                }

                e.Graphics.DrawString("Gracias por preferirnos", font, Brushes.Black, new Point(25, y += space));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataTable()
        {
            Dt.Columns.Clear();
            Dt.Columns.Add("Servicio");
            dataGridView1.DataSource = Dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la vista previa de impresión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CONDICION = radioButton1.Checked ? "Al Contado" : "A Crédito";
                foreach (DataRow row in Dt.Rows)
                {
                    Ventrada entrada = new()
                    {
                        num = IDEnt.Text,
                        clinte = TxtCliente.Text,
                        atendido = Settings.Default.Idusuario.ToString(),
                        trabajado = txtmecanico.Text,
                        condicion = CONDICION,
                        Servicio = row["Servicio"].ToString()
                    };
                    entrada.Insetar(
                        entrada.num,
                        entrada.clinte,
                        entrada.atendido,
                        entrada.trabajado,
                        entrada.condicion,
                        row
                    );
                }

                Ventrada finalEntrada = new()
                {
                    num = IDEnt.Text,
                    clinte = TxtCliente.Text,
                    atendido = Settings.Default.Idusuario.ToString(),
                    trabajado = txtmecanico.Text,
                    condicion = CONDICION,
                    Servicio = string.Empty // Asignar un valor predeterminado para cumplir con el requisito
                };
                finalEntrada.cant(IDEnt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la entrada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaderAsync();
        }

        private void AgregarServicio()
        {
            try
            {
                DataRow row = Dt.NewRow();
                row["Servicio"] = textBox3.Text;
                Dt.Rows.Add(row);
                textBox3.Clear();
                dataGridView1.AutoResizeColumn(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el servicio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            LoaderAsync();
        }
        private async Task LoaderAsync()
        {
            try
            {
                IDEnt.Text = await Task.Run(() => new Auto_increment().Cont().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el ID de entrada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarServicio();
            }
        }
        private void uppercaseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convierte el texto a mayúsculas al escribir en el TextBox
            if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
