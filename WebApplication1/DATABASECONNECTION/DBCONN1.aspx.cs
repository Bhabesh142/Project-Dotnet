using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DATABASECONNECTION
{
    public partial class DBCONN1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            ////string cs = "data source=.; database=MYDB; uid=sa; password=tiger";
            //SqlConnection con = new SqlConnection(cs);

            //////SqlConnection con = new SqlConnection("data source=.; database=MYDB; uid=sa; password=tiger");

            //SqlCommand cmd = new SqlCommand("Select * from STUDENT", con);
            //con.Open();

            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr;
            //GridView1.DataBind();
            //con.Close();

            //using (SqlConnection conn = new SqlConnection(cs))
            //{
            //    //SqlCommand cmd = new SqlCommand();
            //    //cmd.CommandText = "Select * from STUDENT";
            //    //cmd.Connection = conn;

            //    //conn.Open();
            //    //GridView1.DataSource = cmd.ExecuteReader();
            //    //GridView1.DataBind();

            //    SqlCommand cmd = new SqlCommand("Select * from STUDENT", conn);
            //    conn.Open();
            //    GridView1.DataSource = cmd.ExecuteReader();
            //    GridView1.DataBind();
            //}


            //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            //using (SqlConnection conn = new SqlConnection(cs))
            //{
            //    SqlCommand cmd = new SqlCommand("select COUNT(*) from STUDENT where FIRSTNAME like 'aaaa%'", conn);
            //    conn.Open();
            //    //GridView1.DataSource = cmd.ExecuteReader();
            //    //GridView1.DataBind();

            //    int TotalRows = (int)cmd.ExecuteScalar();
            //    Response.Write("Total Rows = " + TotalRows.ToString());
            //}

            ////*****DATA UPDATION*****////
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update STUDENT set FIRSTNAME = Bhabesh where ID like '1%'";
                cmd.Connection = conn;

                conn.Open();
                int rowsAffected = (int)cmd.ExecuteNonQuery();
                Response.Write("Updated Rows = " + rowsAffected.ToString() + "<br />");
            }
        }
    }
}