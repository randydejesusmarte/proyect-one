namespace WindowsFormsApp1
{
    partial class Facturar
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
            idfactura = new TextBox();
            nomcli = new TextBox();
            producto = new TextBox();
            precio = new TextBox();
            cantidad = new TextBox();
            monto = new TextBox();
            Add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // idfactura
            // 
            idfactura.Location = new Point(171, 32);
            idfactura.Margin = new Padding(4);
            idfactura.Name = "idfactura";
            idfactura.ReadOnly = true;
            idfactura.Size = new Size(85, 26);
            idfactura.TabIndex = 10;
            // 
            // nomcli
            // 
            nomcli.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nomcli.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nomcli.AutoCompleteSource = AutoCompleteSource.CustomSource;
            nomcli.Location = new Point(171, 76);
            nomcli.Margin = new Padding(4);
            nomcli.Name = "nomcli";
            nomcli.Size = new Size(376, 26);
            nomcli.TabIndex = 0;
            // 
            // producto
            // 
            producto.AutoCompleteCustomSource.AddRange(new string[] { "CHEQUEO GENERAL", "REPARACION DE CREALLERA", "REPARACION DE BOMBA (COROLLA)", "REPARACION DE BOMBA (HONDA)", "REPARACION DE BOMBA (KIA)" });
            producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            producto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            producto.Location = new Point(99, 120);
            producto.Margin = new Padding(4);
            producto.Name = "producto";
            producto.Size = new Size(322, 26);
            producto.TabIndex = 2;
            // 
            // precio
            // 
            precio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            precio.Location = new Point(679, 32);
            precio.Margin = new Padding(4);
            precio.Name = "precio";
            precio.Size = new Size(103, 26);
            precio.TabIndex = 3;
            precio.TextChanged += actualizarMonto_TextChanged;
            precio.KeyPress += precio_KeyPress;
            // 
            // cantidad
            // 
            cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cantidad.Location = new Point(679, 76);
            cantidad.Margin = new Padding(4);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(103, 26);
            cantidad.TabIndex = 4;
            cantidad.Text = "1";
            cantidad.TextChanged += actualizarMonto_TextChanged;
            cantidad.KeyPress += precio_KeyPress;
            // 
            // monto
            // 
            monto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monto.Location = new Point(679, 120);
            monto.Margin = new Padding(4);
            monto.Name = "monto";
            monto.ReadOnly = true;
            monto.Size = new Size(103, 26);
            monto.TabIndex = 5;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Image = Resources.icons8_receipt_50px;
            Add.Location = new Point(812, 92);
            Add.Margin = new Padding(4);
            Add.Name = "Add";
            Add.Size = new Size(50, 50);
            Add.TabIndex = 7;
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 8;
            label1.Text = "ID factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 8;
            label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 8;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(585, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(585, 80);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 8;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(585, 124);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 8;
            label6.Text = "Total";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Resources.icons8_add_user_male_50px;
            button1.Location = new Point(812, 32);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(704, 417);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(850, 257);
            dataGridView1.TabIndex = 10;
            // 
            // Facturar
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 442);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Add);
            Controls.Add(button1);
            Controls.Add(monto);
            Controls.Add(cantidad);
            Controls.Add(precio);
            Controls.Add(producto);
            Controls.Add(nomcli);
            Controls.Add(idfactura);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Facturar";
            Text = "Facturar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idfactura;
        private System.Windows.Forms.TextBox nomcli;
        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}