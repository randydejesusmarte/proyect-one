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
using Proecto_Final;

namespace thot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly Login_conect login = new Login_conect();
        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            int result = login.Logear(txt_Nombre.Text, txt_Contraseña.Text);
            if (result == 1)
            {
                guardar();
                new Participante().Show();
                Hide();
            }
            else if (result == 0)
            {
                MessageBox.Show("Contraseña o Usuario son incorrecto");
            }
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

    }
}
