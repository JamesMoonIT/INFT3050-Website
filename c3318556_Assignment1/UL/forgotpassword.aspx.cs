/*
    Author: James Moon
    Last Updated: 3:07pm 3/4/2021
    Description: This page will send an email to your desired email address. At the moment, it is hardcoded to send you
        the message: "Your password is: password".It makes sense with the hard-coded account, but you can also jsut put
        any email in and it will tell you your password is password. Email validation works though.
*/

using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace c3318556_Assignment1.UL
{
    public partial class forgotpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFeedback.Visible = false;                                    // Feeback label hidden until required
        }

        protected void btnRecover_Click(object sender, EventArgs e)         // Source: https://www.c-sharpcorner.com/UploadFile/2a6dc5/how-to-send-a-email-using-Asp-Net-C-Sharp/
        {
            string to = txbxEmail.Text; //To address
            if (IsValidEmail(to))
            {
                string from = "myuser1245@gmail.com"; //From address    
                MailMessage message = new MailMessage(from, to);

                string mailbody = "You request for a forgotten password was sent today." + "<br /><br />" + "You password is: password" + "<br /><br />" + "Let us know if you need help with anything else on our Contact Us page" + "<br /><br />" + "- GarageBay Support Team";
                message.Subject = "GarageBay | Forgot you Password";
                message.Body = mailbody;
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("myuser1245@gmail.com", "Pas5word");           // email sender details
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                    lblFeedback.Visible = true;
                    lblFeedback.Text = "An email has been sent to your email. It will provide you with your current password so you can log in.";

                }

                catch
                {
                    lblFeedback.Text = "Please contact support. It would seem there was an issue with sending your email.";
                }
            }
            else
            {
                lblFeedback.Visible = true;
                lblFeedback.Text = "Please enter a valid email address";
            }

        }

        bool IsValidEmail(string email)   // Source: https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
        {
            try                                                         // Checks to make sure email format is valid
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch                                                       // if the email format is not valid
            {
                return false;
            }
        }
    }
}