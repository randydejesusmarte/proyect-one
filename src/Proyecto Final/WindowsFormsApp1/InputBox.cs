namespace HttpNamespaceManager.UI
{
    public partial class InputBox : Form
    {
        public InputBox(string title = "", string prompt = "")
        {
            InitializeComponent();
            Text = title;
            labelPrompt.Text = prompt;

            // Calcula el tamaño dinámico basado en el texto del prompt
            Size textSize = TextRenderer.MeasureText(prompt, labelPrompt.Font);
            Size = new Size(Math.Max(textSize.Width + 50, 290), textSize.Height + 128);
        }

        public static DialogResult Show(string title, string prompt, out string result)
        {
            using InputBox input = new(title, prompt);
            DialogResult retval = input.ShowDialog();
            result = input.textInput.Text;
            return retval;
        }
    }
}