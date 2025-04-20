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

        private readonly Login_conect login = new();
        private readonly Id_Login id_Login = new();

        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadUserSettings();
        }

        private void LoadUserSettings()
        {
            txt_Nombre.Text = Settings.Default.Uname;
            txt_Contraseña.Text = Settings.Default.Pass;
            checkit.Checked = Settings.Default.checkit;
        }

        private void SaveUserSettings()
        {
            Settings.Default.Uname = txt_Nombre.Text;
            Settings.Default.checkit = checkit.Checked;
            Settings.Default.Pass = checkit.Checked ? txt_Contraseña.Text : string.Empty;
            Settings.Default.Save();
        }

        private void Checkit_CheckedChanged(object sender, EventArgs e)
        {
            txt_Contraseña.Focus();
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                HandleLogin();
            }
        }

        private void HandleLogin()
        {
            string username = txt_Nombre.Text;
            string password = txt_Contraseña.Text;

            int loginResult = login.Logear(username, password);
            if (loginResult == 1)
            {
                SaveUserSettings();
                OpenMenu(username, password);
            }
            else
            {
                ShowLoginError();
            }
        }

        private void ShowLoginError()
        {
            MessageBox.Show("Contraseña o Usuario son incorrecto", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenMenu(string username, string password)
        {
            string userNameDisplay = id_Login.get_name(username, password);

            WindowsFormsApp1.Menu form = new()
            {
                id = id_Login.get_id(username, password),
                name_business = userNameDisplay,
                Text = userNameDisplay
            };

            form.Show();
            Hide();
        }
    }
}
