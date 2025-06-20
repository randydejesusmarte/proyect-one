namespace WindowsFormsApp1
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            IDEnt = new TextBox();
            button1 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            label1 = new Label();
            label2 = new Label();
            txtmecanico = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            TxtCliente = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // IDEnt
            // 
            IDEnt.Location = new Point(99, 29);
            IDEnt.Margin = new Padding(4);
            IDEnt.Name = "IDEnt";
            IDEnt.ReadOnly = true;
            IDEnt.Size = new Size(106, 26);
            IDEnt.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(18, 363);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Factura :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 77);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Mecanico:";
            // 
            // txtmecanico
            // 
            txtmecanico.Location = new Point(99, 74);
            txtmecanico.Margin = new Padding(4);
            txtmecanico.Name = "txtmecanico";
            txtmecanico.Size = new Size(266, 26);
            txtmecanico.TabIndex = 1;
            txtmecanico.KeyPress += uppercaseTextBox_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 144);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(266, 26);
            textBox3.TabIndex = 3;
            textBox3.KeyDown += textBox3_KeyDown;
            textBox3.KeyPress += uppercaseTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 147);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 5;
            label3.Text = "Servicio:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 80);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Condicion";
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(102, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "A Credito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(113, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Al contado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(99, 109);
            TxtCliente.Margin = new Padding(4);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(266, 26);
            TxtCliente.TabIndex = 2;
            TxtCliente.KeyPress += uppercaseTextBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 112);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "Cliente:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(372, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(386, 348);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(154, 362);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Dar Entrada";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 320);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 11;
            button3.Text = "Dar Entrada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 328);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 12;
            label5.Text = "DB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 371);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 13;
            label6.Text = "Print test";
            // 
            // Entrada
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 409);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(TxtCliente);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(txtmecanico);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(IDEnt);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Entrada";
            Text = "Entrada";
            Load += Entrada_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox IDEnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtmecanico;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}