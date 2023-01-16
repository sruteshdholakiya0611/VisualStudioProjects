using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(comboBox1.Text);
            listView1.Items.Add(listBox1.Text);

            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Male");
                listView1.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Female");
                listView1.Items.Add(radioButton2.Text);
            }

            string msg = "";

            if (checkBox1.Checked == true)
            {
                msg = "Reading";
                listView1.Items.Add(checkBox1.Text);
            }

            if (checkBox2.Checked == true)
            {
                msg = msg + " Writing\n";
                listView1.Items.Add(checkBox2.Text);
            }

            if (checkBox3.Checked == true)
            {
                msg = msg + " Speaking\n";
                listView1.Items.Add(checkBox3.Text);
            }

            if (checkBox4.Checked == true)
            {
                msg = msg + " Listening\n";
                listView1.Items.Add(checkBox4.Text);
            }


            if (msg.Length > 0)
            {
                MessageBox.Show(" Selected : " + msg);
            }
            else
            {
                MessageBox.Show("No checkbox selected");
            }
            
        }
    }
}
