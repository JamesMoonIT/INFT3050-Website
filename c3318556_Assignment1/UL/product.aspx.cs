/* 
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This page displays product details on the selected product from the productpage. 
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
    public partial class product : System.Web.UI.Page
    {
        ProductBL proBL = new ProductBL();
        CartBL cartBL = new CartBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string absoluteurl = HttpContext.Current.Request.Url.AbsoluteUri;               // grabs url
            int lastPart = Convert.ToInt32(absoluteurl.Split('/').Last());                  // pulls last part of url
            Session["PID"] = lastPart;                                                      // stores product id
            productName.Text = proBL.GetProductName(lastPart);
            productID.Text = Convert.ToString(lastPart);
            productBrand.Text = proBL.GetProductBrand(lastPart);
            productType.Text = proBL.GetProductType(lastPart);
            productModel.Text = proBL.GetProductModel(lastPart);
            productDescription.Text = proBL.GetProductDescription(lastPart);
            productPrice.Text = proBL.GetProductPrice(lastPart);
            pImage.ImageUrl = proBL.GetProductImage(lastPart);
        }

        protected void addtocart_Click(object sender, EventArgs e)                          // adds product to cart
        {
            if (Session["UID"] != null)
            {
                int productID = Convert.ToInt32(Session["PID"]);
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

        protected void removefromcart_Click(object sender, EventArgs e)                     // removes product to cart
        {
            if (Session["UID"] != null)
            {
                int productID = Convert.ToInt32(Session["PID"]);
                int userID = cartBL.GetUserID(Convert.ToInt32(Session["UID"]));
                cartBL.RemoveProductInCart(userID, productID);
            }
        }
    }
}