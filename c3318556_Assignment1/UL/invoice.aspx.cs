/*
    Author: James Moon
    Last Updated: 3/6/2021
    Description: Once a payment is completed, this page will show transaction details and a transaction id. This is then shown on user.aspx page.
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
            string absoluteurl = HttpContext.Current.Request.Url.AbsoluteUri;           // takes url
            int lastPart = Convert.ToInt32(absoluteurl.Split('/').Last());              // grabs last part of url before slash
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