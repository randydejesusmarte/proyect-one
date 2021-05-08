using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thot_Librery;
using WindowsFormsApp1;
using Thot_Librery.Codigo_del_Login;
using thot.Properties;

namespace thot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly Login_conect login = new Login_conect();
        private readonly Id_Login id_Login = new Id_Login();
        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            enter();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Nombre.Text = Settings.Default.Uname;
            txt_Contraseña.Text = Settings.Default.Pass;
            checkit.Checked = Settings.Default.checkit;
        }
        private void guardar()
        {
            Settings.Default.Uname = txt_Nombre.Text;
            Settings.Default.checkit = checkit.Checked;
            if (checkit.Checked)
            {
                Settings.Default.Pass = txt_Contraseña.Text;
            }
            else
            {
                Settings.Default.Pass = "";
            }
            Settings.Default.Save();
        }

        private void checkit_CheckedChanged(object sender, EventArgs e) => txt_Contraseña.Focus();

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                enter();
            }
        }
        private void enter()
        {
            int result = login.Logear(txt_Nombre.Text, txt_Contraseña.Text);
            if (result == 1)
            {
                guardar();
                WindowsFormsApp1.Menu form = new WindowsFormsApp1.Menu();
                int id = id_Login.get_id(txt_Nombre.Text, txt_Contraseña.Text);
                form.id = id;
                form.Show();
                Hide();
            }
            else if (result == 0)
            {
                MessageBox.Show("Contraseña o Usuario son incorrecto");
            }
        }
    }
}
