using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using Thot_Librery.Entrada;

namespace WindowsFormsApp1
{
    public partial class Entrada : Form
    {
        DataTable dt = new DataTable();
        public Entrada()
        {
            InitializeComponent();
            datatables();
        }

        internal int id_empleado;
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["sas"] = textBox2.Text;
            row["sopa"] = textBox3.Text;
            dt.Rows.Add(row);

        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 5;

            Font font = new Font("Century Gothic", 12, FontStyle.Regular);
            e.Graphics.DrawString("Tecnica 3", new Font("Century Gothic", 16, FontStyle.Bold), Brushes.Black, new Point(0 + 65, y += 25));
            e.Graphics.DrawString("Llegando a la rotonda", font, Brushes.Black, new Point(0 + 40, y += 25));
            e.Graphics.DrawString("Santiago, Rep Dom. Tel:849-216-1333", font, Brushes.Black, new Point(0, y += 25));
           // e.Graphics.DrawString(textBox1.Text, font, Brushes.Black, new Point(x + 80, y += 25));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 500, y += 25, 0, y);
            e.Graphics.DrawString("Factura de contado", font, Brushes.Black, new Point(0 + 25, y += 5));
            e.Graphics.DrawString("FACTURA.: " + "B000000043", font, Brushes.Black, new Point(0, y += 25));
            e.Graphics.DrawString("FECHA...: " + DateTime.Now.ToString(), font, Brushes.Black, new Point(0, y += 25));
            e.Graphics.DrawString("ATENDIDO.: " + "Randy", font, Brushes.Black, new Point(0, y += 25));
            e.Graphics.DrawString("LE TRABAJO.: " + "Moises", font, Brushes.Black, new Point(0, y += 25));
            e.Graphics.DrawString("CONDICION.: " + "Contado", font, Brushes.Black, new Point(0, y += 25));
            e.Graphics.DrawString("CLIENTE.: " + "Inginio", font, Brushes.Black, new Point(0, y += 25));
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 500, y += 25, 0, y);
            
            foreach(DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["sas"].ToString() + " " + row["sopa"].ToString(), font, Brushes.Black, new Point(0, y += 25));
            }
            e.Graphics.Dispose();
            printPreviewDialog1.ClientSize = Screen.PrimaryScreen.WorkingArea.Size;
            printPreviewDialog1.DesktopLocation = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void datatables()
        {
            dt.Columns.Add("sas");
            dt.Columns.Add("sopa");
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Ventrada> entradas = new List<Ventrada>();
            foreach(DataRow row in dt.Rows)
            {
                Ventrada entrada = new Ventrada();
                entrada.Sas = row["sas"].ToString();
                entrada.Sopa = row["sopa"].ToString();
                entradas.Add(entrada);
            }
        }
    }
}
