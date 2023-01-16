using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripProject
{
    public partial class Form1 : Form
    {
        public string var = ""; public Form1()
        {
            InitializeComponent();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (var.Length > 0)
            {
                richTextBox1.Text += var;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You"); this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                var = richTextBox1.SelectedText;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                var = richTextBox1.SelectedText; richTextBox1.SelectedText = "";
            }
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.White;
            }
        }
    }
}
