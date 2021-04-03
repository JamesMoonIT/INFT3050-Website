/*
    Author: James Moon
    Last Updated: 3:13pm 3 / 4 / 2021
    Description: A reltively straight forward login screen including email and password. The emails and passwords are hard
        coded into the website until databases are linked. If you didnt read the README.txt, the logins are:

            Admin:
                Email: admin @yopmail.com
                Password: password

            User: 
                Email: user @yopmail.com
                Password: password

             Deactivated:
                Email: deactivated @yopmail.com(no password as it will detect the email)

*/

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
            string strEmailStore = Convert.ToString(emailAddress.Text);                 // stores email
            string strPasswordStore = Convert.ToString(userPassword.Text);              // stores password

            string strEmail1 = "user@yopmail.com";                                      // hard coded user
            string strPassword1 = "password";

            string strEmail2 = "admin@yopmail.com";                                     // hard coded admin
            string strPassword2 = "password";

            string strEmailDeactivated = "deactivated@yopmail.com";                     // hard coded deactivated user

            if (strEmailStore == strEmailDeactivated)                                   // first check: is the account deactivated?
            {
                lblFeedback.Text = "Account has been deactivated. Please contact administrator" + " <a href=\"contact.aspx\">here</a>";
            }
            else if (strEmailStore == strEmail1 && strPasswordStore == strPassword1)    // second check: does the user match an admin?
            {
                Session["UserName"] = "Bob";
                Session["FirstName"] = "Bob";
                Session["LastName"] = "Parr";
                Session["Email"] = "user@yopmail.com";
                Session["Phone"] = "1800 DONT CARE";
                Session["Address"] = "123 Fake St, Fakevile NSW 1234";
                Session["UID"] = "100000";                                              // session id set to user
                Response.Redirect("home.aspx");
            }
            else if (strEmailStore == strEmail2 && strPasswordStore == strPassword2)    // third check: does the user match an existing user?
            {
                Session["UserName"] = "Helen";
                Session["FirstName"] = "Helen";
                Session["LastName"] = "Parr";
                Session["Email"] = "admin@yopmail.com";
                Session["Phone"] = "1800 NOT REAL";
                Session["Address"] = "123 Fake St, Fakevile NSW 1234";
                Session["UID"] = "100001";                                              // session id set to admin
                Response.Redirect("home.aspx");
            }
            else if (strEmailStore == strEmail1)                                        // fourth check: is the email correct but password wrong?
            {
                lblFeedback.Text = "Password is incorrect. Plase try again";
            }
            else                                                                        // fifth check: any other issues?
            {
                lblFeedback.Text = "Please enter a valid email address and password";
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