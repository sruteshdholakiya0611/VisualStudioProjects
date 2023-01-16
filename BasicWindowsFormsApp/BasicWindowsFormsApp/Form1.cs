using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String address = textBox2.Text;
            
            MessageBox.Show("Name : "+name + "\nAddress : " + address);

            string msg = "";

            if (checkBox1.Checked == true)
            {
                msg = " | Playing";
            }

            if (checkBox2.Checked == true)
            {
                msg = msg + " | Reading";
            }

            if (checkBox3.Checked == true)
            {
                msg = msg + " | Writing";
            }


            if (msg.Length > 0)
            {
                MessageBox.Show("Hobbies : " + msg);
            }
            else
            {
                MessageBox.Show("No checkbox selected");
            }

            checkBox1.ThreeState = true;
            checkBox2.ThreeState = true;
            checkBox3.ThreeState = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                MessageBox.Show(rb.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                MessageBox.Show(rb.Text);
        }
    }
}
