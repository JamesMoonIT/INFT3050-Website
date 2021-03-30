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
            if (Session["UID"] == "100000")
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUser.Visible = true;
                btnLogout.Visible = true;
                btnUser.Text = "Welcome back, " + Session["UserName"].ToString();
            }
            if (Session["UID"] == "100001")
            {
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                btnUser.Visible = true;
                btnLogout.Visible = true;
                btnUser.Text = "Welcome back, " + Session["UserName"].ToString();
            }
            if (Session["UID"] == null)
            {
                btnUser.Visible = false;
                btnLogin.Visible = true;
                btnLogout.Visible = false;
                btnRegister.Visible = true;
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("cart.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["UID"] = null;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }
    }
}