using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Text;
using System.Net.Mail;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class PurchaseBL
    {
        PurchaseDAL purDAL = new PurchaseDAL();

        public bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)          // Source https://stackoverflow.com/questions/32959273/c-sharp-validating-user-input-like-a-credit-card-number
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

        public string SendEmail(string email, int price)                                        // sends email about successful purcahse
        {
            string to = email;
            string from = "myuser1245@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Congratulations on your recent purchase on Garage Bay. Here is your invoice on your purchase: " + "<br /><br />" + "Invoice ID: 000001" + "<br /><br />" + "Amount Spent: $" + Convert.ToString(price) + "<br /><br />" + "Let us know if you need help with anything else on our Contact Us page" + "<br /><br />" + "- GarageBay Support Team";
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
                return "An email has been sent to your email. It will provide you with your current password so you can log in.";
            }                                           // ^ updates user that email has been sent

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetTransactionID(int invoiceID)
        {
            try
            {
                return purDAL.PullTransactionID(invoiceID);
            }
            catch
            {
                throw;
            }
        }

        public string GetSuccess(int invoiceID) 
        {
            try
            {
                return purDAL.PullSuccess(invoiceID);
            }
            catch
            {
                throw;
            }
        }

        public string GetDateTime(int invoiceID)
        {
            try
            {
                return purDAL.PullDateTime(invoiceID);
            }
            catch
            {
                throw;
            }
        }
    }
}