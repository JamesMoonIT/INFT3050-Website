/*
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This page acts as a stand in for when search works. It currently mentions it shows 5 results, and it redirects to the
        products page with a session variable "search" and the entered text(for later implementation).
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
    public partial class user : System.Web.UI.Page
    {
        AccountBL accBL = new AccountBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            int userID = accBL.GetUserID(Convert.ToInt32(Session["UID"]));                  // stores userid
            lblFirstName.Text = accBL.GetFirstName(userID);
            lblLastName.Text = accBL.GetLastName(userID);
            lblEmail.Text = accBL.GetEmail(userID);
            lblMobile.Text = Convert.ToString(accBL.GetMobile(userID));
        }
    }
}