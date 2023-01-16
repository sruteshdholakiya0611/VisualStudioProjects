using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace aspDotNetDatabase
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\srute\OneDrive\Documents\lenovo.mdf;Integrated Security=True;Connect Timeout=30");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Employee(Id, Password) values('"+field1.Text+ "', '" + field2.Text + "')";
            cmd.Connection = conn;
            conn.Open();

            field1.Text = "";
            field2.Text = "";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}