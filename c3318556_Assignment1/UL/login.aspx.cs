using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string strEmailStore = Convert.ToString(emailAddress.Text);
            string strPasswordStore = Convert.ToString(userPassword.Text);

            string strEmail = "james@moon.com";
            string strPassword = "password";

            if (strEmailStore == strEmail && strPasswordStore == strPassword)
            {
                Session["UID"] = 100000;
                Response.Redirect("home.aspx?UID=100000");
            }
            else if (strEmailStore == strEmail)
            {
                lblFeedback.Text = "Password is incorrect. Plase try again";
            }

        }
    }
}