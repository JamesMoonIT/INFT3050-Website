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

namespace c3318556_Assignment1.UL
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)                      // if sent from cart, runs the page load code
        {
            if (Session["p1Send"] == "1")                                         // product 1 adds +1 if p1send = 1
            {
                int i1Quantity = Convert.ToInt32(p1Quantity.Text);
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i1Quantity++;
                total += 25000;
                lblTotalAmount.Text = Convert.ToString(total);
                p1Quantity.Text = Convert.ToString(i1Quantity);
                Session["p1Send"] = "0";
            }
            if (Session["p2Send"] == "1")                                         // product 2 adds +1 if p2send = 1
            {
                int i2Quantity = Convert.ToInt32(p2Quantity.Text);
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i2Quantity++;
                total += 46000;
                lblTotalAmount.Text = Convert.ToString(total);
                p2Quantity.Text = Convert.ToString(i2Quantity);
                Session["p2Send"] = "0";
            }
            if (Session["p3Send"] == "1")                                         // product 3 adds +1 if p3send = 1
            {
                int i3Quantity = Convert.ToInt32(p3Quantity.Text);
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i3Quantity++;
                total += 23000;
                lblTotalAmount.Text = Convert.ToString(total);
                p3Quantity.Text = Convert.ToString(i3Quantity);
                Session["p3Send"] = "0";
            }
            if (Session["p4Send"] == "1")                                       // product 4 adds +1 if p4send = 1
            {
                int i4Quantity = Convert.ToInt32(p4Quantity.Text);
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i4Quantity++;
                total += 34000;
                lblTotalAmount.Text = Convert.ToString(total);
                p4Quantity.Text = Convert.ToString(i4Quantity);
                Session["p4Send"] = "0";
            }
            if (Session["p5Send"] == "1")                                       // product 5 adds +1 if p5senf = 1
            {
                int i5Quantity = Convert.ToInt32(p5Quantity.Text);
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i5Quantity++;
                total += 43000;
                lblTotalAmount.Text = Convert.ToString(total);
                p5Quantity.Text = Convert.ToString(i5Quantity);
                Session["p5Send"] = "0";
            }
        }

        protected void p1Add_Click(object sender, EventArgs e)                  // if user presses the + button for product 1
        {
            int i1Quantity = Convert.ToInt32(p1Quantity.Text);
            int total = Convert.ToInt32(lblTotalAmount.Text);
            i1Quantity++;                                                       // increase quantity on product
            total += 25000;                                                     // total price is updated
            lblTotalAmount.Text = Convert.ToString(total);
            Session["p1Cart"] = Convert.ToString(i1Quantity);
            p1Quantity.Text = Session["p1Cart"].ToString();                     // total quantity is updated
        }

        protected void p2Add_Click(object sender, EventArgs e)                  // if user presses the + button for product 2
        {
            int i2Quantity = Convert.ToInt32(p2Quantity.Text);
            int total = Convert.ToInt32(lblTotalAmount.Text);
            i2Quantity++;                                                       // increase quantity on product
            total += 46000;                                                     // total price is updated
            lblTotalAmount.Text = Convert.ToString(total);
            Session["p2Cart"] = Convert.ToString(i2Quantity);
            p2Quantity.Text = Session["p2Cart"].ToString();                     // total quantity is updated
        }

        protected void p3Add_Click(object sender, EventArgs e)                  // if user presses the + button for product 3
        {
            int i3Quantity = Convert.ToInt32(p3Quantity.Text);
            int total = Convert.ToInt32(lblTotalAmount.Text);
            i3Quantity++;                                                       // increase quantity on product
            total += 23000;                                                     // total price is updated
            lblTotalAmount.Text = Convert.ToString(total);
            Session["p3Cart"] = Convert.ToString(i3Quantity);
            p3Quantity.Text = Session["p3Cart"].ToString();                     // total quantity is updated
        }

        protected void p4Add_Click(object sender, EventArgs e)                  // if user presses the + button for product 4
        {
            int i4Quantity = Convert.ToInt32(p4Quantity.Text);
            int total = Convert.ToInt32(lblTotalAmount.Text);
            i4Quantity++;                                                       // increase quantity on product
            total += 34000;                                                     // total price is updated
            lblTotalAmount.Text = Convert.ToString(total);
            Session["p4Cart"] = Convert.ToString(i4Quantity);
            p4Quantity.Text = Session["p4Cart"].ToString();                     // total quantity is updated
        }

        protected void p5Add_Click(object sender, EventArgs e)                  // if user presses the + button for product 5
        {
            int i5Quantity = Convert.ToInt32(p5Quantity.Text);
            int total = Convert.ToInt32(lblTotalAmount.Text);
            i5Quantity++;                                                       // increase quantity on product
            total += 43000;                                                     // total price is updated
            lblTotalAmount.Text = Convert.ToString(total);
            Session["p5Cart"] = Convert.ToString(i5Quantity);
            p5Quantity.Text = Session["p5Cart"].ToString();                     // total quantity is updated
        }

        protected void p1Subtract_Click(object sender, EventArgs e)             // if user presses the - button for product 1
        {
            int i1Quantity = Convert.ToInt32(p1Quantity.Text);
            if (i1Quantity > 0)                                                 // checks if the quantity is not 0 or higher
            {
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i1Quantity--;                                                   // decreases quantity of product
                total -= 25000;                                                 // updates total
                lblTotalAmount.Text = Convert.ToString(total);
                Session["p1Cart"] = Convert.ToString(i1Quantity);
                p1Quantity.Text = Session["p1Cart"].ToString();
            }
        }

        protected void p2Subtract_Click(object sender, EventArgs e)             // if user presses the - button for product 2
        {
            int i2Quantity = Convert.ToInt32(p2Quantity.Text);
            if (i2Quantity > 0)                                                 // checks if the quantity is not 0 or higher
            {
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i2Quantity--;                                                   // decreases quantity of product
                total -= 46000;                                                 // updates total
                lblTotalAmount.Text = Convert.ToString(total);
                Session["p2Cart"] = Convert.ToString(i2Quantity);
                p2Quantity.Text = Session["p2Cart"].ToString();
            }
        }

        protected void p3Subtract_Click(object sender, EventArgs e)             // if user presses the - button for product 3
        {
            int i3Quantity = Convert.ToInt32(p3Quantity.Text);
            if (i3Quantity > 0)                                                 // checks if the quantity is not 0 or higher
            {
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i3Quantity--;                                                   // decreases quantity of product
                total -= 23000;                                                 // updates total
                lblTotalAmount.Text = Convert.ToString(total);
                Session["p3Cart"] = Convert.ToString(i3Quantity);
                p3Quantity.Text = Session["p3Cart"].ToString();
            }
        }

        protected void p4Subtract_Click(object sender, EventArgs e)             // if user presses the - button for product 4
        {
            int i4Quantity = Convert.ToInt32(p4Quantity.Text);
            if (i4Quantity > 0)                                                 // checks if the quantity is not 0 or higher
            {
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i4Quantity--;                                                   // decreases quantity of product
                total -= 34000;                                                 // updates total
                lblTotalAmount.Text = Convert.ToString(total);
                Session["p4Cart"] = Convert.ToString(i4Quantity);
                p4Quantity.Text = Session["p4Cart"].ToString();
            }
        }

        protected void p5Subtract_Click(object sender, EventArgs e)             // if user presses the - button for product 5
        {
            int i5Quantity = Convert.ToInt32(p5Quantity.Text);
            if (i5Quantity > 0)                                                 // checks if the quantity is not 0 or higher
            {
                int total = Convert.ToInt32(lblTotalAmount.Text);
                i5Quantity--;                                                   // decreases quantity of product
                total -= 43000;                                                 // updates total
                lblTotalAmount.Text = Convert.ToString(total);
                Session["p5Cart"] = Convert.ToString(i5Quantity);
                p5Quantity.Text = Session["p5Cart"].ToString();
            }
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            Session["Price"] = lblTotalAmount.Text;                             // stores total amount in session
            Response.Redirect("purchase.aspx");                                 // redirects to purchase
        }
    }
}