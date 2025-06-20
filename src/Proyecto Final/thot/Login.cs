using thot.Properties;
using Thot_Librery.Codigo_del_Login;

namespace thot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Permite iniciar sesión con Enter en ambos campos
            txt_Nombre.KeyPress += TxtFields_KeyPress;
            txt_Contraseña.KeyPress += TxtFields_KeyPress;
        }

        private readonly Login_conect login = new();
        private readonly Id_Login id_Login = new();

        private void bt_Entrar_Click(object sender, EventArgs e)
        {
            _ = HandleLoginAsync();
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

        private void TxtFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite iniciar sesión al presionar Enter en usuario o contraseña
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _ = HandleLoginAsync();
            }
        }

        private async Task HandleLoginAsync()
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
                // Ejecuta el login en un hilo aparte para no bloquear la UI
                int loginResult = await Task.Run(() => login.Logear(username, password));
                if (loginResult == 1)
                {
                    SaveUserSettings();
                    await OpenMenuAsync(username, password);
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

        private async Task OpenMenuAsync(string username, string password)
        {
            try
            {
                // Obtiene los datos del usuario en un hilo aparte
                string userNameDisplay = await Task.Run(() => id_Login.get_name(username, password));
                int userId = await Task.Run(() => id_Login.get_id(username, password));

                WindowsFormsApp1.Menu form = new()
                {
                    id = userId,
                    name_business = userNameDisplay,
                    Text = "SGT: (" + userNameDisplay+")"
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
