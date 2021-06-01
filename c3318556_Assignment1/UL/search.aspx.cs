/*
    Author: James Moon
    Last Updated: 3:29pm 3 / 4 / 2021
    Description: This page acts as a stand in for when search works.It currently mentions it shows 5 results, and it redirects to the
        products page with a session variable "search" and the entered text(for later implementation).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            noResult.Visible = false;
            lblSearchResults.Visible = false;
            btnToProducts.Visible = false;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            noResult.Visible = true;
            lblSearchResults.Visible = true;
            btnToProducts.Visible = true;
        }

        protected void btnToProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("productspage.aspx?search=" + searchBox.Text);            // redirects user to products with search key
        }
    }
}