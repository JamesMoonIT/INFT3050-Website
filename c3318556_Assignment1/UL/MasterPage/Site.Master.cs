/*
    Author: James Moon
    Last Updated: 3:48pm 3/4/2021
    Description: This masterpage acts as the overall style and look of the website fro mthe navigation bar to the footer,
        excluding the body between. There are hidden and visible buttons all over the website dependign on UID. The site
        master also handles on every page user validation and updates accordingly. It also handles validation on
        pages all over the website. The footer contains just the title and year.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL.MasterPage
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == "100000")                                                         // if uid is a user id
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUser.Visible = true;
                btnLogout.Visible = true;
                btnAdmin.Visible = false;
                btnUser.Text = "Welcome back, " + Session["UserName"].ToString();
            }
            else if (Session["UID"] == "100001")                                                    // if uid is an admin id
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUser.Visible = true;
                btnLogout.Visible = true;
                btnAdmin.Visible = true;
                btnUser.Text = "Welcome back, " + Session["UserName"].ToString() + " (Admin)";
            }
            else if (Session["UID"] == null)                                                        // if uid does not exist
            {
                Session["Name"] = "Guest";
                btnUser.Visible = false;
                btnLogin.Visible = true;
                btnLogout.Visible = false;
                btnRegister.Visible = true;
                btnAdmin.Visible = false;
            }
            else                                                                                    // if anything else happens
            {
                btnUser.Visible = false;
                btnLogin.Visible = true;
                btnLogout.Visible = false;
                btnRegister.Visible = true;
                btnAdmin.Visible = false;

            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx");                                                         // redirect to cart
        }   

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");                                                        // redirect to login
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");                                                     // redirect to register
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");                                                       // redirect to logout
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");                                                         // redirect to user
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");                                                        // redirect to admin
        }
    }
}