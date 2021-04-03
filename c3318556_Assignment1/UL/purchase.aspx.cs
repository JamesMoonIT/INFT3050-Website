using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Text;
using System.Net.Mail;

namespace c3318556_Assignment1.UL
{
    public partial class purchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == null)                                     // if user is a guest
            {
                lblGuestEmail.Visible = true;                               // show email area
                tblGuestCheckout.Visible = true;                            //      "
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
                if (IsCreditCardInfoValid(iCardNo, expiryDate, cvv))                        // validates card details
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

        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)          // Source https://stackoverflow.com/questions/32959273/c-sharp-validating-user-input-like-a-credit-card-number
        {
            var cardCheck = new Regex(@"^(1298|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");        // checks format and first 4 digits
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }

        private void fail()
        {
            lblFeedback.Text = "We detected an irregularity with your card details. Please double check your details and try again. If the problem persists, please contact us at the Contact Us page.";
        }

        private void success()
        {
            sendEmail();
            Response.Redirect("invoice.aspx");
        }

        private void sendEmail()                                        // sends email about successful purcahse
        {
            string to = Session["Email"].ToString();
            string from = "myuser1245@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Congratulations on your recent purchase on Garage Bay. Here is your invoice on your purchase: " + "<br /><br />" + "Invoice ID: 000001" + "<br /><br />" + "Amount Spent: $" + Session["Price"].ToString() + "<br /><br />" + "Let us know if you need help with anything else on our Contact Us page" + "<br /><br />" + "- GarageBay Support Team";
            message.Subject = "GarageBay | Successful Purchase";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("myuser1245@gmail.com", "Pas5word");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
                lblFeedback.Visible = true;
                lblFeedback.Text = "An email has been sent to your email. It will provide you with your current password so you can log in.";
            }                                           // ^ updates user that email has been sent

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}