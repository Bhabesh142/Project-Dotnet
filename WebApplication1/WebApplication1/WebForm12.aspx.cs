using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Creation of cookie

            // Creating HttpCookie instance by specifying name = "student"
            HttpCookie cookie = new HttpCookie("Student");

            //Assigning value to the created cookie
            cookie.Value = "Bhabesh Chandra Dutta";

            Response.Cookies.Add(cookie);

            Label3.Text = Response.Cookies["Student"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";

            if(apple.Checked)
                Response.Cookies["computer"]["apple"] = "apple";

            if (dell.Checked)
                Response.Cookies["computer"]["Dell"] = "dell";

            if (lenovo.Checked)
                Response.Cookies["computer"]["Lenovo"] = "lenovo";

            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["apple"] + "";

                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["dell"] + "";

                if (Request.Cookies["computer"]["apple"] != null)
                    Label2.Text += Request.Cookies["computer"]["lenovo"] + "";
            }
            else
            {
                Label2.Text = "Please select your choices: ";
                Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
            }

        }
    }
}