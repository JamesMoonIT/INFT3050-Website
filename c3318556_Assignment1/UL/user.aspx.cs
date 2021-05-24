/*
    Author: James Moon
    Last Updated: 3:40pm 3 / 4 / 2021
    Description: This page acts as a stand in for when search works.It currently mentions it shows 5 results, and it redirects to the
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


        protected void Page_Load(object sender, EventArgs e)
        {
            //lblFirstName.Text = GetName(lblEmail.Text);
        }
    }
}