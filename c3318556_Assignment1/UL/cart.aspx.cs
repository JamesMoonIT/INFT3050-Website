/*
    Author: James Moon
    Last Updated: 3/6/2021
    Description: This page shows the shopping cart information the user sends to payment. Addmitedly, due to limited time, 
        I could not make it adaptive and has hard coded total purchase price in the cart.
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
        AccountBL accBL = new AccountBL();

        protected void Page_Load(object sender, EventArgs e)                      // if sent from cart, runs the page load code
        {
            if (Session["UID"] != null)
            {
                Session["UserID"] = accBL.GetUserID(Convert.ToInt32(Session["UID"]));
                
            }
            else
            {
                Session["UserID"] = null;
                lblGuest.Visible = true;
            }
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            Session["Price"] = 100000;                             // stores total amount in session
            Response.Redirect("purchase.aspx");                                 // redirects to purchase
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string name = ((Label)((GridView)sender).Rows[e.RowIndex].FindControl("lblName")).Text;
            e.NewValues["pName"] = name;
            e.Cancel = false;
        }
    }
}