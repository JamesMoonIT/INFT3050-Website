/*
    Author: James Moon
    Last Updated: 3:24pm 3 / 4 / 2021
    Description: This is where the user enters their email (if they are a guest), their card detials and their prefered
        delivery address. The card validation checks to make sure the card details are valid and correctly formatted
        and fails if it is not correct.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c3318556_Assignment1.BL;
using Microsoft.AspNet.FriendlyUrls;

namespace c3318556_Assignment1.UL
{
    public partial class products : System.Web.UI.Page
    {
        CartBL cartBL = new CartBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void name_Command(object sender, CommandEventArgs e)
        {
            string productID = Convert.ToString(e.CommandArgument);
            var url = FriendlyUrl.Href("~/UL/product", productID);
            Response.Redirect(url);
        }

        protected void addtocart_Command(object sender, CommandEventArgs e)
        {
            if (Session["UID"] != null)
            {
                int productID = Convert.ToInt32(e.CommandArgument);
                int userID = cartBL.GetUserID(Convert.ToInt32(Session["UID"]));
                cartBL.CreateCart(userID, productID);
            }
            else
            {
                // lblFeedback.Text = "Please login before adding items to cart";
            }
        }
    }
}