using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 5;

            e.Graphics.DrawString("     Tecnica Tres", new Font("arial", 16, FontStyle.Bold), Brushes.Black, new Point(x, y += 25));
            e.Graphics.DrawString("    Llegando a la rotonda", new Font("arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y += 25));
            e.Graphics.DrawString("Santiago, Rep Dom. Tel:849-216-1333", new Font("arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y += 25));
            e.Graphics.DrawString("     RNC 1-02-61807-2", new Font("arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y += 25));
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 500, 125, 0, 125);
            e.Graphics.DrawString("     Factura de contado", new Font("arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y += 25));
            e.Graphics.DrawString("Factura..: " + "B000000043", new Font("arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y += 25));
            e.Graphics.DrawString("Fecha....: " + DateTime.Today.ToString(), new Font("arial", 12, FontStyle.Regular), Brushes.Black, new Point(x, y += 25));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ClientSize = Screen.PrimaryScreen.WorkingArea.Size;

            printPreviewDialog1.DesktopLocation = Screen.PrimaryScreen.WorkingArea.Location;
            printPreviewDialog1.ShowDialog();
        }
    }
}
