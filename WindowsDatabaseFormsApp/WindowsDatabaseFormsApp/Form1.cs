using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDatabaseFormsApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\srute\OneDrive\Documents\lenovo.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into StudentTable(firstname, lastname, id) values('"+textBox1.Text+ "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            cmd.Connection = conn;
            conn.Open();

            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Records Inserted Successfully");
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lenovoDataSet.StudentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.lenovoDataSet.StudentTable);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete from StudentTable where id='" + textBox3.Text + "'";
            cmd.Connection = conn;
            conn.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Records Deleted Successfully");
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update StudentTable set firstname='" + textBox1.Text + "', lastname='" + textBox2.Text + "' where id='" + textBox3.Text + "'";
            cmd.Connection = conn;
            conn.Open();

            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Records Updated Successfully");
            conn.Close();
        }
    }
}
