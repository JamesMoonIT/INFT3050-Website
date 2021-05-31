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
using c3318556_Assignment1.BL;

namespace c3318556_Assignment1.UL.MasterPage
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterBL masBL = new MasterBL();
            if (masBL.IsCurrentAdmin(Convert.ToInt32(Session["UID"])))                                         // if uid is an admin id
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUser.Visible = true;
                btnLogout.Visible = true;
                btnAdmin.Visible = true;
                btnUser.Text = "Welcome back, " + Session["UserName"].ToString() + " (Admin)";
            }
            else if (Convert.ToInt32(Session["UID"]) >= 1)                                                         // if uid is a user id
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUser.Visible = true;
                btnLogout.Visible = true;
                btnAdmin.Visible = false;
                btnUser.Text = "Welcome back, " + Session["UserName"].ToString();
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
            Response.Redirect("~/UL/cart.aspx");                                                         // redirect to cart
        }   

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/login.aspx");                                                        // redirect to login
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/register.aspx");                                                     // redirect to register
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/logout.aspx");                                                       // redirect to logout
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/user.aspx");                                                         // redirect to user
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/Admin/admin.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/home.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/about.aspx");
        }

        protected void btnProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/productspage.aspx");
        }

        protected void btnContactUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/contact.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/search.aspx");
        }
    }
}