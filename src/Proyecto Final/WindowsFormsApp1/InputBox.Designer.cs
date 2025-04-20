namespace HttpNamespaceManager.UI
{
    partial class InputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrompt = new Label();
            textInput = new TextBox();
            buttonCancel = new Button();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelPrompt
            // 
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(15, 10);
            labelPrompt.Margin = new Padding(4, 0, 4, 0);
            labelPrompt.Name = "labelPrompt";
            labelPrompt.Size = new Size(50, 15);
            labelPrompt.TabIndex = 0;
            labelPrompt.Text = "Prompt:";
            labelPrompt.MaximumSize = new Size(300, 0); // Permite que el texto se ajuste automáticamente
            // 
            // textInput
            // 
            textInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textInput.Location = new Point(14, 50);
            textInput.Margin = new Padding(4, 3, 4, 3);
            textInput.Name = "textInput";
            textInput.Size = new Size(303, 23);
            textInput.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(230, 85);
            buttonCancel.Margin = new Padding(4, 3, 4, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(88, 27);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(135, 85);
            buttonOK.Margin = new Padding(4, 3, 4, 3);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(88, 27);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Aceptar";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // InputBox
            // 
            AcceptButton = buttonOK;
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = buttonCancel;
            ClientSize = new Size(350, 130);
            Controls.Add(buttonOK);
            Controls.Add(buttonCancel);
            Controls.Add(textInput);
            Controls.Add(labelPrompt);
            FormBorderStyle = FormBorderStyle.FixedDialog; // Cambiado para evitar redimensionamiento
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(360, 150);
            Name = "InputBox";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Título";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}