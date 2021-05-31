/*
    Author: James Moon
    Last Updated: 3:13pm 3 / 4 / 2021
    Description: A reltively straight forward login screen including email and password. The emails and passwords are hard
        coded into the website until databases are linked. If you didnt read the README.txt, the logins are:

            Admin:
                Email: admin @yopmail.com
                Password: Pas5word

            User: 
                Email: user @yopmail.com
                Password: Pas5word

             Deactivated:
                Email: deactivated @yopmail.com
                Password: Pas5word

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c3318556_Assignment1.BL;

namespace c3318556_Assignment1.UL
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int result = 0;
            string strEmailStore = Convert.ToString(emailAddress.Text);                 // stores email
            string strPasswordStore = Convert.ToString(userPassword.Text);              // stores password

            LoginBL logBL = new LoginBL();
            AccountBL accBL = new AccountBL();

            result = logBL.CheckUserLogin(strEmailStore, strPasswordStore);
            if (result == 1)
            {
                lblFeedback.Text = "Email is not valid. Please check the format of your email address";
            }
            if (result == 2)
            {
                lblFeedback.Text = "Password is not valid. Make sure it has atleast one capital letter and one numerical character";
            }
            if (result == 3)
            {
                lblFeedback.Text = "There was an issue conencting to the database";
            }
            if (result == 4)
            {
                lblFeedback.Text = "Password is incorrect";
            }
            if (result == 5)
            {
                lblFeedback.Text = "Email does not exist. Please consider registering!";
            }
            if (result == 6)
            {
                lblFeedback.Text = "Success, logging you in now...";
                if (accBL.SessionAlreadyExists(logBL.GetUserID(strEmailStore)))
                {
                    Session["UID"] = logBL.GetSessionID(logBL.GetUserID(strEmailStore));
                }
                else
                {
                    Session["UID"] = logBL.CreateSession(logBL.GetUserID(strEmailStore), logBL.GetName(strEmailStore));
                }
                Session["UserName"] = logBL.GetName(Convert.ToInt32(Session["UID"]));
                Response.Redirect("home.aspx");
            }
        }

        protected void newUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");                                         // redirect to register
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgotpassword.aspx");                                   // redirect to forgot password
        }
    }
}