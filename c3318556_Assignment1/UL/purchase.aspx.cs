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
    public partial class purchase : System.Web.UI.Page
    {
        PurchaseBL purBL = new PurchaseBL();
        AccountBL accBL = new AccountBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null)                                     // if user is a guest
            {
                lblGuestEmail.Visible = true;                               // show email area
                tblGuestCheckout.Visible = true;                            //      "
                Response.Redirect("home.aspx");
            }
            else                                                            // if user is not a guest
            {
                lblGuestEmail.Visible = false;                              // hide email area
                tblGuestCheckout.Visible = false;                           //      "
            }
            lblTotal.Text = Session["Price"].ToString();                    // Grabs cart total price
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            Session["Email"] = txbxEmail.Text;
            string month = Convert.ToString(txbxExpiryMonth.Text);          // store month
            string year = Convert.ToString(txbxExpiryYear.Text);            // store year
            if (month.Length == 2 && year.Length == 4)                      // validate format of month and year
            {
                string cvv = Convert.ToString(txbxCVV.Text);                                // convert to string value
                string iCardNo = Convert.ToString(Convert.ToDouble(txbxCardNumber.Text));   // convert to string value
                string expiryDate = month + "/" + year;                                     // merge month and year
                if (purBL.IsCreditCardInfoValid(iCardNo, expiryDate, cvv))                        // validates card details
                {
                    success();                                                              // if success
                }
                else
                {
                    fail();                                                                 // if fail
                }

            }
            else
            {
                lblFeedback.Text = "Please check the format of the month and year. E.g. Month = 12 , 05, 09. Year = 2021, 2025, 2030";
            }
        }

        private void fail()
        {
            lblFeedback.Text = "We detected an irregularity with your card details. Please double check your details and try again. If the problem persists, please contact us at the Contact Us page.";
        }

        private void success()
        {
            int userID = accBL.GetUserID(Convert.ToInt32(Session["UID"]));
            int addressID = accBL.GetAddressID(userID);
            int cartID = accBL.GetCartID(userID);
            int cardNo = Convert.ToInt32(txbxCardNumber.Text);
            int cardMonth = Convert.ToInt32(txbxExpiryMonth.Text);
            int cardYear = Convert.ToInt32(txbxExpiryYear.Text);
            int cardCVV = Convert.ToInt32(txbxCVV.Text);
            int transactionID = accBL.CreateTransaction(addressID, cartID, txbxName.Text, cardNo, cardMonth, cardYear, cardCVV);
            lblFeedback.Text = purBL.SendEmail(Session["Email"].ToString(), Convert.ToInt32(Session["Price"]));
            var url = FriendlyUrl.Href("~UL/invoice.aspx", transactionID);
            Response.Redirect(url);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}