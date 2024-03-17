using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("YOUR NAME is: " + TextBox1.Text + "<BR/>" +
           "YOUR Rollno is: " + TextBox2.Text + "<BR/>" +
           "YOUR Address is: " + TextBox3.Text + "<BR/>" +
           "YOUR Email is: " + TextBox4.Text + "<BR/>" +
           "YOUR Telep is: " + TextBox5.Text + "<BR/>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}