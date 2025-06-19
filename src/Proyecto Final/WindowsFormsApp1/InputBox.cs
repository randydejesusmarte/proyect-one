namespace HttpNamespaceManager.UI
{
    public partial class InputBox : Form
    {
        public InputBox(string title = "", string prompt = "", string defaultValue = "")
        {
            InitializeComponent();
            Text = title;
            labelPrompt.Text = prompt;
            textInput.Text = defaultValue;

            // Calcula el tamaño dinámico basado en el texto del prompt
            Size textSize = TextRenderer.MeasureText(prompt, labelPrompt.Font);
            int width = Math.Max(textSize.Width + 50, 290);
            int height = Math.Max(textSize.Height + 128, 150);
            Size = new Size(width, height);

            // Centra el formulario en la pantalla
            StartPosition = FormStartPosition.CenterScreen;

            // Selecciona el texto por defecto y enfoca el TextBox
            Shown += (s, e) =>
            {
                textInput.Focus();
                textInput.SelectAll();
            };

            // Permite cerrar con Enter (Aceptar) y Escape (Cancelar)
            textInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            };
        }

        public static DialogResult Show(string title, string prompt, out string result, string defaultValue = "")
        {
            using InputBox input = new(title, prompt, defaultValue);
            DialogResult retval = input.ShowDialog();
            result = input.textInput.Text ?? string.Empty;
            return retval;
        }
    }
}