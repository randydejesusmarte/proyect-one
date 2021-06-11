using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Timers;
using System.Windows.Forms;
using Thot_Librery.Menu;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
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
            MessageBox.Show(id.ToString());
        }

        private void BtFactura_Click(object sender, EventArgs e)
        {
            Facturar form = new Facturar();
            form.id_empleado = id;
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }

        private void fecha_Tick(object sender, EventArgs e) => L_Fecha.Text = DateTime.Now.ToString();

        private void button3_Click(object sender, EventArgs e)
        {
            Entrada form = new Entrada();
            form.id_empleado = id;
            new Menus().Form_Heredado(form, splitContainer1.Panel2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Menus().Limpiar(splitContainer1.Panel2);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Settings.Default.Idusuario = id;
        }
    }
}
