using HttpNamespaceManager.UI;
using System.Runtime.Versioning;
using Thot_Librery.Codigo_Factura;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Formulario principal para la gestión de facturación.
    /// </summary>
    public partial class Facturar : Form
    {
        // Identificador del cliente (readonly, debe asignarse en el constructor o por inyección)
        private readonly int idcliente;
        // Identificador interno de la factura
        internal int _id;

        /// <summary>
        /// Constructor principal. Inicializa el formulario y sus datos de forma asíncrona.
        /// </summary>
        public Facturar()
        {
            InitializeComponent();
            // Llama a la inicialización asíncrona sin bloquear la UI
            _ = InitializeFormAsync();
        }

        /// <summary>
        /// Inicializa los datos del formulario, refresca el campo de cliente y genera el ID de factura de forma asíncrona.
        /// </summary>
        private async Task InitializeFormAsync()
        {
            try
            {
                await RefreshNomcliTextAsync(); // Refresca el campo de texto con datos del cliente
                await SetNewFacturaIdAsync();   // Genera automáticamente el ID de la factura
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Refresca el campo de texto del cliente con autocompletado desde la base de datos de forma asíncrona.
        /// </summary>
        [SupportedOSPlatform("windows6.1")]
        private async Task RefreshNomcliTextAsync()
        {
            try
            {
                // Ejecuta la operación de base de datos en un hilo aparte
                await Task.Run(() => new TextrefreshAttribute().RefreshText(nomcli));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al refrescar el texto del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento para agregar una nueva factura. Valida los campos y actualiza la vista.
        /// </summary>
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de entradas
                if (string.IsNullOrWhiteSpace(idfactura.Text) ||
                    string.IsNullOrWhiteSpace(producto.Text) ||
                    string.IsNullOrWhiteSpace(precio.Text) ||
                    string.IsNullOrWhiteSpace(cantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Conversión segura de datos
                if (!int.TryParse(idfactura.Text, out int idFactura) ||
                    !decimal.TryParse(precio.Text, out decimal precioDecimal) ||
                    !int.TryParse(cantidad.Text, out int cantidadInt))
                {
                    MessageBox.Show("Por favor, ingrese valores válidos en los campos de ID, precio y cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Agregar factura a la base de datos
                new Agregar_Factura().Agregar(
                    idFactura,
                    idcliente,
                    producto.Text,
                    precioDecimal.ToString(),
                    cantidadInt.ToString(),
                    monto.Text,
                    monto.Text,
                    _id,
                    DateTime.Now.ToString()
                );

                // Actualizar DataGridView con los datos más recientes
                dataGridView1.DataSource = new FillData().Datos(idfactura.Text);
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Genera automáticamente el ID de la factura usando la lógica de auto-incremento de forma asíncrona.
        /// </summary>
        private async Task SetNewFacturaIdAsync()
        {
            try
            {
                // Ejecuta la obtención del ID en un hilo aparte
                int id = await Task.Run(() => new Auto_increment().Cont());
                idfactura.Invoke((Action)(() => idfactura.Text = id.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el ID de la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento para buscar una entrada y asignar su número al campo de ID de factura.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputBox.Show("Buscar Entrada", "Número de Entrada", out string texto) == DialogResult.OK)
                {
                    idfactura.Text = texto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar la entrada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
