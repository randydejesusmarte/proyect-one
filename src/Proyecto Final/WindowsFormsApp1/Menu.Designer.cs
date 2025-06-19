namespace WindowsFormsApp1
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            button5 = new Button();
            button2 = new Button();
            L_Fecha = new Label();
            button4 = new Button();
            button3 = new Button();
            Bt_factura = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            fecha = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            splitContainer1.Size = new Size(930, 519);
            splitContainer1.SplitterDistance = 118;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(L_Fecha);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Bt_factura);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 86);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 431);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 229);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(116, 49);
            button5.TabIndex = 6;
            button5.Text = "control de\r\nServicios";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 180);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(116, 49);
            button2.TabIndex = 5;
            button2.Text = "control de\r\ngastos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // L_Fecha
            // 
            L_Fecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            L_Fecha.AutoSize = true;
            L_Fecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            L_Fecha.Location = new Point(-1, 412);
            L_Fecha.Name = "L_Fecha";
            L_Fecha.Size = new Size(50, 16);
            L_Fecha.TabIndex = 4;
            L_Fecha.Text = "label1";
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Enabled = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 135);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(116, 45);
            button4.TabIndex = 3;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 90);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(116, 45);
            button3.TabIndex = 2;
            button3.Text = "Entrada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Bt_factura
            // 
            Bt_factura.Dock = DockStyle.Top;
            Bt_factura.FlatStyle = FlatStyle.Flat;
            Bt_factura.Location = new Point(0, 45);
            Bt_factura.Margin = new Padding(4);
            Bt_factura.Name = "Bt_factura";
            Bt_factura.Size = new Size(116, 45);
            Bt_factura.TabIndex = 1;
            Bt_factura.Text = "Facturar";
            Bt_factura.UseVisualStyleBackColor = true;
            Bt_factura.Click += BtFactura_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(116, 45);
            button1.TabIndex = 0;
            button1.Text = "Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Resources.icons8_user_96px;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fecha
            // 
            fecha.Tick += fecha_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 519);
            Controls.Add(splitContainer1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tecnica 3";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form1_FormClosed;
            Load += Menu_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Bt_factura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_Fecha;
        private System.Windows.Forms.Timer fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}