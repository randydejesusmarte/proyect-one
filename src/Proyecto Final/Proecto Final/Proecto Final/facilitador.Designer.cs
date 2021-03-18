namespace Proecto_Final
{
    partial class facilitador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facilitador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntrestaurar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnaumento = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnregistro = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnprogramaclase = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.btnasigaturasim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panelbase = new System.Windows.Forms.Panel();
            this.btnrestar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaumento)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.bntrestaurar);
            this.panel1.Controls.Add(this.btnrestar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnaumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bntrestaurar
            // 
            this.bntrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("bntrestaurar.Image")));
            this.bntrestaurar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntrestaurar.Location = new System.Drawing.Point(741, 0);
            this.bntrestaurar.Name = "bntrestaurar";
            this.bntrestaurar.Size = new System.Drawing.Size(25, 30);
            this.bntrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntrestaurar.TabIndex = 9;
            this.bntrestaurar.TabStop = false;
            this.bntrestaurar.Visible = false;
            this.bntrestaurar.Click += new System.EventHandler(this.bntrestaurar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btncerrar.Location = new System.Drawing.Point(772, -1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 30);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 8;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnaumento
            // 
            this.btnaumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaumento.Image = ((System.Drawing.Image)(resources.GetObject("btnaumento.Image")));
            this.btnaumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnaumento.Location = new System.Drawing.Point(741, -1);
            this.btnaumento.Name = "btnaumento";
            this.btnaumento.Size = new System.Drawing.Size(25, 30);
            this.btnaumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnaumento.TabIndex = 7;
            this.btnaumento.TabStop = false;
            this.btnaumento.Click += new System.EventHandler(this.btnaumento_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblhora);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnregistro);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnprogramaclase);
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnasigaturasim);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 570);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bienvenido Facilitador";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Black;
            this.lblhora.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblhora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblhora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblhora.Location = new System.Drawing.Point(148, 537);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(41, 16);
            this.lblhora.TabIndex = 36;
            this.lblhora.Text = "Hora";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Black;
            this.lblfecha.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblfecha.ForeColor = System.Drawing.Color.White;
            this.lblfecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblfecha.Location = new System.Drawing.Point(126, 512);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(51, 16);
            this.lblfecha.TabIndex = 35;
            this.lblfecha.Text = "Fecha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(44, 308);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // btnregistro
            // 
            this.btnregistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnregistro.BackColor = System.Drawing.Color.Turquoise;
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnregistro.FlatAppearance.BorderSize = 0;
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistro.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
            this.btnregistro.ForeColor = System.Drawing.Color.Black;
            this.btnregistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnregistro.Location = new System.Drawing.Point(67, 308);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(96, 30);
            this.btnregistro.TabIndex = 22;
            this.btnregistro.Text = "   Registro";
            this.btnregistro.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(13, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(5, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnprogramaclase
            // 
            this.btnprogramaclase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprogramaclase.BackColor = System.Drawing.Color.Turquoise;
            this.btnprogramaclase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprogramaclase.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnprogramaclase.FlatAppearance.BorderSize = 0;
            this.btnprogramaclase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprogramaclase.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
            this.btnprogramaclase.ForeColor = System.Drawing.Color.Black;
            this.btnprogramaclase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnprogramaclase.Location = new System.Drawing.Point(53, 253);
            this.btnprogramaclase.Name = "btnprogramaclase";
            this.btnprogramaclase.Size = new System.Drawing.Size(139, 30);
            this.btnprogramaclase.TabIndex = 16;
            this.btnprogramaclase.Text = "Programa De Clase";
            this.btnprogramaclase.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsalir.Location = new System.Drawing.Point(5, 512);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(68, 46);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 21;
            this.btnsalir.TabStop = false;
            // 
            // btnasigaturasim
            // 
            this.btnasigaturasim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnasigaturasim.BackColor = System.Drawing.Color.Turquoise;
            this.btnasigaturasim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnasigaturasim.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnasigaturasim.FlatAppearance.BorderSize = 0;
            this.btnasigaturasim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasigaturasim.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
            this.btnasigaturasim.ForeColor = System.Drawing.Color.Black;
            this.btnasigaturasim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnasigaturasim.Location = new System.Drawing.Point(24, 193);
            this.btnasigaturasim.Name = "btnasigaturasim";
            this.btnasigaturasim.Size = new System.Drawing.Size(183, 33);
            this.btnasigaturasim.TabIndex = 8;
            this.btnasigaturasim.Text = "   Asiganturas Impartidas";
            this.btnasigaturasim.UseVisualStyleBackColor = false;
            this.btnasigaturasim.Click += new System.EventHandler(this.btnasigaturasim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // panelbase
            // 
            this.panelbase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbase.Location = new System.Drawing.Point(210, 30);
            this.panelbase.Name = "panelbase";
            this.panelbase.Size = new System.Drawing.Size(587, 570);
            this.panelbase.TabIndex = 2;
            // 
            // btnrestar
            // 
            this.btnrestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestar.Image")));
            this.btnrestar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnrestar.Location = new System.Drawing.Point(705, 0);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(25, 30);
            this.btnrestar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestar.TabIndex = 16;
            this.btnrestar.TabStop = false;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click_1);
            // 
            // facilitador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 600);
            this.Controls.Add(this.panelbase);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facilitador";
            this.Text = "facilitador";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bntrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaumento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnasigaturasim;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnprogramaclase;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox bntrestaurar;
        private System.Windows.Forms.PictureBox btnaumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelbase;
        private System.Windows.Forms.PictureBox btnrestar;
    }
}