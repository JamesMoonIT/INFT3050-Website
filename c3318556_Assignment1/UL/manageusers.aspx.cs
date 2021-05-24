/*
    Author: James Moon
    Last Updated: 3:19pm 3 / 4 / 2021
    Description: An admin only page that manages the users on the website. Until it is linked, it has no purpose apart form
        it current formatting style and buttons for later navigation of records.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class manageusers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["UID"]) != 100001)                                 // if user is not admin
            {
                Response.Redirect("home.aspx");                             // yeet them back home
            }
        }

        protected void btnPreviousFive_Click(object sender, EventArgs e)
        {
                                                                            // unused until assignment 2
        }

        protected void btnNextFive_Click(object sender, EventArgs e)
        {
                                                                            // unused until assignment 2
        }
    }
}