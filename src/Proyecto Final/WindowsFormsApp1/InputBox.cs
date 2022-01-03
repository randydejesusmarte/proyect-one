namespace HttpNamespaceManager.UI
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        public InputBox(string title, string prompt)
        {
            InitializeComponent();
            Text = title;
            labelPrompt.Text = prompt;
            Size = new Size(Math.Max(labelPrompt.Width + 31, 290), labelPrompt.Height + 128);

        }

        public static DialogResult Show(string title, string prompt, out string result)
        {
            InputBox input = new(title, prompt);
            DialogResult retval = input.ShowDialog();
            result = input.textInput.Text;
            return retval;
        }
    }
}