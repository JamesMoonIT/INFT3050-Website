/*
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This is the products page where all current cars are listed for sale. You can buy as many as you
        want (apparently..) so there you go. The items are in a table that can be expanded with more products. kept it
        at 5 for coding purposes and lack of time.
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

        protected void name_Command(object sender, CommandEventArgs e)                          // adds productid to url and redirects
        {
            string productID = Convert.ToString(e.CommandArgument);
            var url = FriendlyUrl.Href("~/UL/product", productID);
            Response.Redirect(url);
        }

        protected void addtocart_Command(object sender, CommandEventArgs e)                     // adds product selected to cart
        {
            if (Session["UID"] != null)
            {
                int productID = Convert.ToInt32(e.CommandArgument);
                int userID = cartBL.GetUserID(Convert.ToInt32(Session["UID"]));
                if (cartBL.CartExists(userID, productID))
                {
                    cartBL.IncreaseProductInCart(userID, productID);
                }
                else
                {
                    cartBL.CreateCart(userID, productID);
                }
            }
            else
            {
                // lblFeedback.Text = "Please login before adding items to cart";
            }
        }

        protected void removefromcart_Command(object sender, CommandEventArgs e)                // removes product from user cart
        {
            if (Session["UID"] != null)
            {
                int productID = Convert.ToInt32(e.CommandArgument);
                int userID = cartBL.GetUserID(Convert.ToInt32(Session["UID"]));
                cartBL.RemoveProductInCart(userID, productID);
            }
            else
            {
                // lblFeedback.Text = "Please login before adding items to cart";
            }
        }
    }
}