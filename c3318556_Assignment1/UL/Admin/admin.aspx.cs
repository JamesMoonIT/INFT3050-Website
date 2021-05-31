/*
   Author: James Moon
   Last Updated: 2:55pm 3/4/2021
   Description: This Admin page allows any admin user to navigate admin-privlaged pages including Edit Product (which is
       just the products page with hidden buttons now visible to admins), Register Admin(login page with extra options),
       which is an admin only page to manage users (security on boot to make sure they are admin)
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
    public partial class admin : System.Web.UI.Page
    {
        AdminBL admBL = new AdminBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!admBL.IsCurrentAdmin(Convert.ToInt32(Session["UID"])))                                 // checks to see if the user is not an admin
            {
                Response.Redirect("~/UL/home.aspx");                             // bounce the non-admin back home
            }
        }

        protected void btnEditProducts_Click(object sender, EventArgs e)    
        {
            Response.Redirect("~/UL/Admin/adminproducts.aspx");                             // redirect the admin to Products
        }

        protected void btnAddAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/Admin/adminregister.aspx");                             // redirect the admin to register
        }

        protected void btnManageUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UL/Admin/adminmanageusers.aspx");                          // redirect the admin to manage users
        }
    }
}