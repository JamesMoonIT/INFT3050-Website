/*
    Author: James Moon
    Last Updated: 3:11pm 3 / 4 / 2021
    Description: There isnt too much to this page apart from if every form of validation on purchase.aspx is verified, it
        sends you here to say "Good job, you spent money on something you could never possibly get. How on earth do you
        expect us to ship this?". Wasnt really sure what else to put here.
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
    public partial class invoice : System.Web.UI.Page
    {
        PurchaseBL purBL = new PurchaseBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string absoluteurl = HttpContext.Current.Request.Url.AbsoluteUri;
            int lastPart = Convert.ToInt32(absoluteurl.Split('/').Last());
            lblInvoiceID.Text = Convert.ToString("lastPart");
            lblTransactionID.Text = purBL.GetTransactionID(lastPart);
            lblSuccess.Text = purBL.GetSuccess(lastPart);
            lblDateTime.Text = purBL.GetDateTime(lastPart);
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");                         // Redirects the user home
        }
    }
}