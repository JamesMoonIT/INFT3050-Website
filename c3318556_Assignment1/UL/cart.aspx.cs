/*
    Author: James Moon
    Last Updated: 3:01pm 3/4/2021
    Description: This page shows the shopping cart information the user sends to payment. Addmitedly, due to limited time,
        I could not make it adaptive and has hard coded products in the cart. It features interactive buttons to add item
        to the cart. I also could not get it working where if you left cart, it would store the items (proven hard to code).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c3318556_Assignment1.BL;
using Microsoft.AspNet.FriendlyUrls;

namespace c3318556_Assignment1.UL
{
    public partial class cart : System.Web.UI.Page
    {
        CartBL cartBL = new CartBL();

        protected void Page_Load(object sender, EventArgs e)                      // if sent from cart, runs the page load code
        {

        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            Session["Price"] = 100000;                             // stores total amount in session
            Response.Redirect("purchase.aspx");                                 // redirects to purchase
        }
    }
}