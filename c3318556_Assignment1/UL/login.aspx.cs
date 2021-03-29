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

            string strEmail1 = "user@yopmail.com";
            string strPassword1 = "password";

            string strEmail2 = "admin@yopmail.com";
            string strPassword2 = "password";

            string strEmailDeactivated = "deactivated@yopmail.com";

            if (strEmailStore == strEmailDeactivated)
            {
                lblFeedback.Text = "Account has been deactivated. Please contact administrator" + " <a href=\"contact.aspx\">here</a>";
            }
            else if (strEmailStore == strEmail1 && strPasswordStore == strPassword1)
            {
                Session["UserName"] = "User";
                Session["UID"] = 100001;
                Response.Redirect("home.aspx");
            }
            else if (strEmailStore == strEmail2 && strPasswordStore == strPassword2)
            {
                Session["UserName"] = "Admin";
                Session["UID"] = 100000;
                Response.Redirect("home.aspx");
            }
            else if (strEmailStore == strEmail1)
            {
                lblFeedback.Text = "Password is incorrect. Plase try again";
            }
            else
            {
                lblFeedback.Text = "Please enter a valid email address and password";
            }
        }

        protected void newUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {

        }
    }
}