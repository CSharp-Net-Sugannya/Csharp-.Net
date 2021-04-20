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

namespace DisplayDataInGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr;

            // for the connection to 
            // sql server database
            SqlConnection con;
            constr = @"Data Source=DESKTOP-3Q66R40\SQLEXPRESS;Initial Catalog=collegedb;Integrated Security=True";
            con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_College", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
