using thot.Properties;
using Thot_Librery.Codigo_del_Login;

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
            Enter();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Nombre.Text = Settings.Default.Uname;
            txt_Contraseña.Text = Settings.Default.Pass;
            checkit.Checked = Settings.Default.checkit;
        }
        private void Save()
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

        private void checkit_CheckedChanged(object sender, EventArgs e)
        {
            txt_Contraseña.Focus();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Enter();
            }
        }
        private new void Enter()
        {
            int result = login.Logear(txt_Nombre.Text, txt_Contraseña.Text);
            switch (result)
            {
                case 1:
                    {
                        Save();
                        WindowsFormsApp1.Menu form = new();
                        int id = id_Login.get_id(txt_Nombre.Text, txt_Contraseña.Text);
                        form.Text = id_Login.get_name(txt_Nombre.Text, txt_Contraseña.Text).ToString();
                        form.id = id;
                        form.name_business = id_Login.get_name(txt_Nombre.Text, txt_Contraseña.Text).ToString();
                        form.Show();
                        Hide();
                        break;
                    }

                case 0:
                    MessageBox.Show("Contraseña o Usuario son incorrecto");
                    break;
            }
        }
    }
}
