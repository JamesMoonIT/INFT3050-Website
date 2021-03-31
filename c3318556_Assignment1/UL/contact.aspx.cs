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

        protected void btnSubmit_Click(object sender, EventArgs e)
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