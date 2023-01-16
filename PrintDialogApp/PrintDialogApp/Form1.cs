using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Pen selPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(selPen, 125, 125, 550, 150);
            e.Graphics.DrawString("ID : " + textBox1.Text, new Font("Consolas", 25), Brushes.Black, 150, 150);
            e.Graphics.DrawString("Name : " + textBox2.Text, new Font("Consolas", 25), Brushes.Black, 150, 200);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            printDialog1.Document = printDocument1;
            printDialog1.AllowSomePages = true;
            printDialog1.AllowSelection = true;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            pageSetupDialog1.ShowDialog();

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
