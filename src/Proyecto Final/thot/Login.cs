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
            // Carga las configuraciones guardadas del usuario
            txt_Nombre.Text = Settings.Default.Uname;
            txt_Contraseña.Text = Settings.Default.Pass;
            checkit.Checked = Settings.Default.checkit;
        }

        private void SaveUserSettings()
        {
            // Guarda las configuraciones del usuario
            Settings.Default.Uname = txt_Nombre.Text;
            Settings.Default.checkit = checkit.Checked;
            Settings.Default.Pass = checkit.Checked ? txt_Contraseña.Text : string.Empty;
            Settings.Default.Save();
        }

        private void Checkit_CheckedChanged(object sender, EventArgs e)
        {
            // Enfoca el campo de contraseña cuando se cambia el estado del checkbox
            txt_Contraseña.Focus();
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite iniciar sesión al presionar Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                HandleLogin();
            }
        }

        private void HandleLogin()
        {
            string username = txt_Nombre.Text.Trim();
            string password = txt_Contraseña.Text.Trim();

            // Validación de entradas
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                _ = MessageBox.Show("Por favor, ingrese un nombre de usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
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
            catch (Exception ex)
            {
                // Manejo de excepciones
                _ = MessageBox.Show($"Ocurrió un error durante el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLoginError()
        {
            // Muestra un mensaje de error si las credenciales son incorrectas
            _ = MessageBox.Show("Contraseña o Usuario son incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenMenu(string username, string password)
        {
            try
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
            catch (Exception ex)
            {
                // Manejo de excepciones al abrir el menú
                _ = MessageBox.Show($"Ocurrió un error al abrir el menú: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
