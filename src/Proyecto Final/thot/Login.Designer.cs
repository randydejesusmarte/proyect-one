﻿namespace thot
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_Nombre = new TextBox();
            txt_Contraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bt_Entrar = new Button();
            checkit = new CheckBox();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.AllowDrop = true;
            txt_Nombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Nombre.Location = new Point(123, 14);
            txt_Nombre.Margin = new Padding(4);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.PlaceholderText = "Usuario";
            txt_Nombre.Size = new Size(367, 26);
            txt_Nombre.TabIndex = 0;
            txt_Nombre.KeyPress += TxtFields_KeyPress;
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.AllowDrop = true;
            txt_Contraseña.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Contraseña.Location = new Point(123, 62);
            txt_Contraseña.Margin = new Padding(4);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.PlaceholderText = "Contraseña";
            txt_Contraseña.Size = new Size(367, 26);
            txt_Contraseña.TabIndex = 1;
            txt_Contraseña.UseSystemPasswordChar = true;
            txt_Contraseña.KeyPress += TxtFields_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(8, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // bt_Entrar
            // 
            bt_Entrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bt_Entrar.AutoSize = true;
            bt_Entrar.FlatStyle = FlatStyle.Flat;
            bt_Entrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            bt_Entrar.Location = new Point(13, 141);
            bt_Entrar.Margin = new Padding(4);
            bt_Entrar.Name = "bt_Entrar";
            bt_Entrar.Size = new Size(477, 60);
            bt_Entrar.TabIndex = 3;
            bt_Entrar.Text = "Entrar";
            bt_Entrar.UseVisualStyleBackColor = true;
            bt_Entrar.Click += bt_Entrar_Click;
            // 
            // checkit
            // 
            checkit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            checkit.AutoSize = true;
            checkit.Location = new Point(13, 110);
            checkit.Name = "checkit";
            checkit.Size = new Size(200, 24);
            checkit.TabIndex = 2;
            checkit.Text = "Recordar Contraseña";
            checkit.UseVisualStyleBackColor = true;
            checkit.CheckedChanged += Checkit_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(503, 214);
            Controls.Add(checkit);
            Controls.Add(bt_Entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Contraseña);
            Controls.Add(txt_Nombre);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected internal TextBox txt_Nombre;
        protected internal TextBox txt_Contraseña;
        protected internal Button bt_Entrar;
        protected internal CheckBox checkit;
    }
}

