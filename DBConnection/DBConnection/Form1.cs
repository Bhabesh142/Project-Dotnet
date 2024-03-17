using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=csa;Initial Catalog=NewDB;User ID=sa;password=tiger";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string querry = "select * from  student";
            SqlCommand cmd = new SqlCommand(querry, con);
            var rdr = cmd.ExecuteReader();

            DataTable tbl = new DataTable();
            tbl.Load(rdr);
            dataGridView1.DataSource = tbl;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
