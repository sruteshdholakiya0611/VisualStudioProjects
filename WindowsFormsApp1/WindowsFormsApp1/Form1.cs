using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox3.Text);
            double sum = txt1 + txt2;
            textBox2.Text = sum.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox3.Text);
            double sum = txt1 - txt2;
            textBox2.Text = sum.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox3.Text);
            double sum = txt1 * txt2;
            textBox2.Text = sum.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox3.Text);
            double sum = txt1 / txt2;
            textBox2.Text = sum.ToString();
        }
    }
}
