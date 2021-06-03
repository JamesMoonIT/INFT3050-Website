/*
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This is a very straight forward page. If your have a user id and you click yes, it will wipe the uid from the
        session and send you bck to home. At home, it will look for an id and will default to a regular login. If you click no,
        it just redirects you back to the home screen.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnYes_Click(object sender, EventArgs e)         // if useris sure they want to log out
        {
            Session["UID"] = null;
            Session["UserName"] = null;
            Response.Redirect("home.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)          // if user decides not to log out
        {
            Response.Redirect("home.aspx");
        }
    }
}