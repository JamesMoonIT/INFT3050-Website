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

            string strEmail1 = "inft3050testuser@yopmail.com";
            string strPassword1 = "password";

            string strEmail2 = "inft3050testadmin@yopmail.com";
            string strPassword2 = "password";

            if (strEmailStore == strEmail1 && strPasswordStore == strPassword1)
            {
                Session["UserName"] = "User";
                Session["UID"] = 100001;
                Response.Redirect("home.aspx");
            }
            if (strEmailStore == strEmail2 && strPasswordStore == strPassword2)
            {
                Session["UserName"] = "Admin";
                Session["UID"] = 100000;
                Response.Redirect("home.aspx");
            }
            if (strEmailStore == strEmail1)
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
    }
}