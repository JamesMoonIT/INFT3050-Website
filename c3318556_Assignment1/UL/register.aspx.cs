/*
    Author: James Moon
    Last Updated: 3:25pm 3 / 4 / 2021
    Description: This page is used for registering a new user.It doubles as an admin register if the current user is also an
        admin.User's enter their details and upon submitting, are sent an email with a randomly generated verification number.
        Upon successfully entering the correct verification number, they are redirected home. Admins are redirected home with
        the admin privileges and navigation differences to users.
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
    public partial class register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UID"] == "100001")                             // checks if current user is admin (allows creation of admin)
            {
                lblAdminMaker.Visible = true;
            }
            lblVerification.Visible = false;
            txbxVerificationKey.Visible = false;
            btnVerify.Visible = false;
        }

        protected void registerNow_Click(object sender, EventArgs e)
        {
            string strFirstName = Convert.ToString(firstName.Text);
            string strLastName = Convert.ToString(lastName.Text);
            string strEmailStore = Convert.ToString(emailAddress.Text);
            string strPasswordStore = Convert.ToString(userPassword.Text);
            string strPhoneNo = Convert.ToString(mobile.Text);
            string strAddress = Convert.ToString(postalAddress.Text);

            if (strFirstName == "" || strLastName == "" || strEmailStore == "" || strPasswordStore == "" || strPasswordStore == "" || strPhoneNo == "" || strAddress == "")
            {                                                                                   // ^ makes sure no areas are empty
                lblFeedback.Text = "Please make sure to fill all fields";
            }
            else if (!IsValidEmail(strEmailStore))                                              // validates if email is in bad format
            {
                lblFeedback.Text = "Please enter a valid email address";
            }
            else
            {
                string validationKeyGen = makeKey();                                            // call to make a verification key
                sendConfirmation(validationKeyGen);                                             // sends email with verification key
                lblVerification.Visible = true;                                                 // updates table with verification options
                txbxVerificationKey.Visible = true;                                             //              "
                btnVerify.Visible = true;                                                       //              "
                registerNow.Visible = false;                                                    //              "
                lblFeedback.Text = "Email has been sent, please check your inbox for the confirmation code.";
                Session["Key"] = validationKeyGen;                                              // stores key in Session
            }
        }

        protected void existingUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");                                                    // redirects to login
        }

        private bool validateKey(string key)
        {
            if (key == txbxVerificationKey.Text)                                                // checks if key emailed matches session
            {
                return true;
            }
            return false;
        }

        private void sendConfirmation(string key)                                               // sends confirmation email with session key
        {
            string to = emailAddress.Text; //To address    
            string from = "myuser1245@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Thank you for registering with GarageBay. In order to complete the Registration, please use this key to complete your sign up with our website" + "<br /><br />" + "Verification Key: " + key + "<br /><br />" + "Be sure to use our contact us page if there are any issues" + "<br /><br />" + "From, " + "<br /><br />" + "GarageBay Support Team";
            message.Subject = "GarageBay | Verification Key: " + key;
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

            }

            catch
            {
                lblFeedback.Text = "We could not verify your email, please use the correct format. E.g. xx@xx.xx";
            }
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            string key = Session["Key"].ToString();                             // stores session key
            if (validateKey(key))                                               // checks key is valid
            {   
                Session["UserName"] = Convert.ToString(firstName.Text);         // stores Username in session
                Session["FirstName"] = Convert.ToString(firstName.Text);        // stores First Name in session
                Session["LastName"] = Convert.ToString(lastName.Text);          // stores Last Name in session
                Session["Email"] = Convert.ToString(emailAddress.Text);         // stores Email in session
                Session["Phone"] = Convert.ToString(mobile.Text);               // stores phone in session
                Session["Key"] = null;                                          // key is wiped as its not needed anymore
                if (Session["UID"] == "100001")                                 // if the existing user is an admin
                {
                    Session["UID"] = "100001";                                  // new registered user becomes admin
                }
                else                                                            // if existing user is also user or guest
                {
                    Session["UID"] = "100000";                                  // new registered user becomes user
                }
                Response.Redirect("home.aspx");                                 // redirect user to home
            }
            else
            {
                lblFeedback.Text = "We could not verify your account. Please double check your emails for the right code. If the problem persists, use the Contact Us page for assistance";
                btnVerify.Visible = true;                                       // user is given another chance to enter key
                txbxVerificationKey.Visible = true;                             //                  "
                lblVerification.Visible = true;                                 //                  "
            }
        }

        private string makeKey()                                                // creates a randomly generated key
        {
            var rand = new Random();                                            // declare random class
            string key = Convert.ToString(rand.Next(10000, 99999));             // generates a random number between 10000 and 99999
            return key;                                                         // returns randomly generated key
        }

        bool IsValidEmail(string email)                                         // validates key
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);              // checks format of email
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}