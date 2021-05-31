/*
    Author: James Moon
    Last Updated: 3:24pm 3 / 4 / 2021
    Description: This is where the user enters their email (if they are a guest), their card detials and their prefered
        delivery address. The card validation checks to make sure the card details are valid and correctly formatted
        and fails if it is not correct.
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
    public partial class products : System.Web.UI.Page
    {
        AdminBL admBL = new AdminBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!admBL.IsCurrentAdmin(Convert.ToInt32(Session["UID"])))           // checks if user is admin
            {

            }
        }

        protected void cartProduct1_Click(object sender, EventArgs e)           // if user adds item 1 to card
        {
            Session["p1Send"] = "1";                                            // p1Send updated to 1 (used for cart)
            Response.Redirect("cart.aspx");                                     // redirect to cart
        }

        protected void cartProduct2_Click(object sender, EventArgs e)           // if user adds item 2 to card
        {
            Session["p2Send"] = "1";                                            // p2Send updated to 1 (used for cart)
            Response.Redirect("cart.aspx");                                     // redirect to cart
        }

        protected void cartProduct3_Click(object sender, EventArgs e)           // if user adds item 3 to card
        {
            Session["p3Send"] = "1";                                            // p3Send updated to 1 (used for cart)
            Response.Redirect("cart.aspx");                                     // redirect to cart
        }

        protected void cartProduct4_Click(object sender, EventArgs e)           // if user adds item 4 to card
        {
            Session["p4Send"] = "1";                                            // p4Send updated to 1 (used for cart)
            Response.Redirect("cart.aspx");                                     // redirect to cart
        }

        protected void cartProduct5_Click(object sender, EventArgs e)           // if user adds item 5 to card
        {
            Session["p5Send"] = "1";                                            // p5Send updated to 1 (used for cart)
            Response.Redirect("cart.aspx");                                     // redirect to cart
        }
    }
}