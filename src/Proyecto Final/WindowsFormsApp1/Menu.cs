﻿global using WindowsFormsApp1.Properties;
using Thot_Librery.Menu;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        // Instancia única de Menus para reutilizar y reducir consumo de memoria
        private readonly Menus menus = new();
        // Referencias a formularios secundarios para reutilización y liberación de recursos
        private Facturar? facturarForm;
        private Entrada? entradaForm;
        private Controdegastos? controdegastosForm;
        private ctlservicios? ctlserviciosForm;

        public Menu()
        {
            InitializeComponent();
            // Suscribirse al evento FormClosed para liberar recursos
            FormClosed += Form1_FormClosed;
        }

        public int id;
        public string name_business;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Detiene el temporizador y cierra la aplicación al cerrar el formulario principal
            fecha.Stop();
            fecha.Dispose();
            // Liberar formularios secundarios
            facturarForm?.Dispose();
            entradaForm?.Dispose();
            controdegastosForm?.Dispose();
            ctlserviciosForm?.Dispose();
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje con el ID de usuario y el nombre del negocio
            MessageBox.Show(Settings.Default.Namesbusiness.ToString(), Settings.Default.Idusuario.ToString());
        }

        private void BtFactura_Click(object sender, EventArgs e)
        {
            // Reutiliza el formulario si ya existe, si no lo crea
            if (facturarForm == null || facturarForm.IsDisposed)
                facturarForm = new Facturar { _id = id };
            menus.Form_Heredado(facturarForm, splitContainer1.Panel2);
        }

        private void fecha_Tick(object sender, EventArgs e)
        {
            // Actualiza la etiqueta con la fecha y hora actual
            L_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Reutiliza el formulario si ya existe, si no lo crea
            if (entradaForm == null || entradaForm.IsDisposed)
                entradaForm = new Entrada { id_empleado = id };
            menus.Form_Heredado(entradaForm, splitContainer1.Panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Limpia el contenido del panel y libera recursos de formularios secundarios
            foreach (Control ctrl in splitContainer1.Panel2.Controls)
            {
                ctrl.Dispose();
            }
            splitContainer1.Panel2.Controls.Clear();
            facturarForm?.Dispose(); facturarForm = null;
            entradaForm?.Dispose(); entradaForm = null;
            controdegastosForm?.Dispose(); controdegastosForm = null;
            ctlserviciosForm?.Dispose(); ctlserviciosForm = null;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Guarda las configuraciones del usuario al cargar el formulario
            Settings.Default.Idusuario = id;
            Settings.Default.Namesbusiness = name_business;
            Settings.Default.Save();

            // Inicia el temporizador para actualizar la fecha y hora
            fecha.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reutiliza el formulario si ya existe, si no lo crea
            if (controdegastosForm == null || controdegastosForm.IsDisposed)
                controdegastosForm = new Controdegastos();
            menus.Form_Heredado(controdegastosForm, splitContainer1.Panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Reutiliza el formulario si ya existe, si no lo crea
            if (ctlserviciosForm == null || ctlserviciosForm.IsDisposed)
                ctlserviciosForm = new ctlservicios();
            menus.Form_Heredado(ctlserviciosForm, splitContainer1.Panel2);
        }
    }
}
