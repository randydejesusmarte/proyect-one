using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proecto_Final
{
    public partial class facilitador : Form
    {
        public facilitador()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void formatematicas(object matematica)
        {
            if (this.panelbase.Controls.Count > 0)
                this.panelbase.Controls.RemoveAt(0);
            Form cristian = matematica as Form;
            cristian.TopLevel = false;
            cristian.Dock = DockStyle.Fill;
            this.panelbase.Controls.Add(cristian);
            this.panelbase.Tag = cristian;
            cristian.Show();
        }

        private void btnmatematicas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnasigaturasim_Click(object sender, EventArgs e)
        {
           
            formatematicas(new Matematica());
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bntrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnaumento.Visible = true;
            bntrestaurar.Visible = false;
        }

        private void btnaumento_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnaumento.Visible = false;
            bntrestaurar.Visible = true;
        }

        private void btnrestar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
