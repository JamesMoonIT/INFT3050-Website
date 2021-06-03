/*
    Author: James Moon
    Last Updated: 3/6/2021
    Description: The Contact page was my first try at getting emails working (which it does). You are able to enter all your
        and it will actually send you an email to your inbox (from the email myuser1245@gmail.com).
*/

using System;
using System.Net.Mail;
using System.Text;

namespace c3318556_Assignment1.UL
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)          // Source: https://www.c-sharpcorner.com/UploadFile/2a6dc5/how-to-send-a-email-using-Asp-Net-C-Sharp/
        {
            string to = "myuser1245@gmail.com"; //To address    
            string from = "myuser1245@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            message.IsBodyHtml = false;
            string mailbody = "Email:" + emailAddress.Text + "<br /><br />" + Environment.NewLine + "Name: " + name.Text + "<br /><br />" + Environment.NewLine + "Description: " + question.Text;
            message.Subject = Convert.ToString("GarageBay | " + emailSubject.Text);
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
                lblSuccess.Text = "You email has been sent successfully. We will attempt to get back to you in 24 hours.";

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}