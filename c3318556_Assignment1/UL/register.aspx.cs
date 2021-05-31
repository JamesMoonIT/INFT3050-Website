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
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using c3318556_Assignment1.BL;

namespace c3318556_Assignment1.UL
{
    public partial class register : System.Web.UI.Page
    {
        RegisterBL regBL = new RegisterBL();

        protected void Page_Load(object sender, EventArgs e)
        {
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
            string strStreetNo = Convert.ToString(streetNumber.Text);
            string strStreetName = Convert.ToString(streetName.Text);
            string strSuburb = Convert.ToString(suburb.Text);
            string strState = Convert.ToString(suburb.Text);
            string strPostcode = Convert.ToString(postcode.Text);

            if (strFirstName == "" || strLastName == "" || strEmailStore == "" || strPasswordStore == "" || strPasswordStore == "" || strPhoneNo == "" || strStreetNo == "" || strStreetName == "" || strSuburb == "" || strState == "" || strPostcode == "")
            {                                                                     // ^ makes sure no areas are empty
                lblFeedback.Text = "Please make sure to fill all fields";
            }
            else if (!regBL.IsValidEmail(strEmailStore))                          // validates if email is in bad format
            {
                lblFeedback.Text = "Please enter a valid email address";
            }
            else if (regBL.DoesEmailExist(strEmailStore))
            {
                lblFeedback.Text = "Email already exists. Please register with a new email address or login";
            }
            else if (!regBL.IsAddressValid(strStreetNo, strStreetName, strSuburb, strState, strPostcode))
            {
                lblFeedback.Text = "Address is not formatted correctly. Please check your address and try again";
            }

            else
            {
                string validationKeyGen = regBL.makeKey();                        // call to make a verification key
                try
                {
                    regBL.sendConfirmation(validationKeyGen, strEmailStore);
                    lblVerification.Visible = true;                               // updates table with verification options
                    txbxVerificationKey.Visible = true;                           //              "
                    btnVerify.Visible = true;                                     //              "
                    registerNow.Visible = false;                                  //              "
                    lblFeedback.Text = "Email has been sent, please check your inbox for the confirmation code.";
                    Session["Key"] = validationKeyGen;                            // stores key in Session
                }
                catch
                {
                    lblFeedback.Text = "We could not send a confirmation email. Please use the Contact Us page and let us know";
                }
            }
        }

        protected void existingUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");                                     // redirects to login
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            int sessionID = 0;
            int storedKey = Convert.ToInt32(Session["Key"]);                             // stores session key
            string strFirstName = Convert.ToString(firstName.Text);
            string strLastName = Convert.ToString(lastName.Text);
            string strEmailStore = Convert.ToString(emailAddress.Text);
            string strPasswordStore = Convert.ToString(userPassword.Text);
            string strPhoneNo = Convert.ToString(mobile.Text);
            int intStreetNo = Convert.ToInt32(streetNumber.Text);
            string strStreetName = Convert.ToString(streetName.Text);
            string strSuburb = Convert.ToString(suburb.Text);
            string strState = Convert.ToString(state.Text);
            int intPostcode = Convert.ToInt32(postcode.Text);
            if (regBL.ValidateKey(storedKey, Convert.ToInt32(txbxVerificationKey.Text)))                                               // checks key is valid
            {
                try
                {
                    int addressID = regBL.AddAddress(intStreetNo, strStreetName, strSuburb, strState, intPostcode);
                    string email = regBL.AddLogin(strEmailStore, strPasswordStore);
                    int userID = regBL.AddUser(strFirstName, strLastName, email, strPhoneNo, false, addressID);
                    sessionID = regBL.CreateSession(userID);
                    Session["UID"] = sessionID;
                    Session["UserName"] = regBL.GetUserName(Convert.ToInt32(Session["UID"]));
                    Session["Key"] = null;
                    Response.Redirect("home.aspx");                                 // redirect user to home
                }
                catch
                {
                    lblFeedback.Text = "There was an issue registering you. Please check your details and try again, or use our Contact Us page and let us know about the issue";
                }
            }
            else
            {
                lblFeedback.Text = "We could not verify your account. Please double check your emails for the right code. If the problem persists, use the Contact Us page for assistance";
                btnVerify.Visible = true;                                       // user is given another chance to enter key
                txbxVerificationKey.Visible = true;                             //                  "
                lblVerification.Visible = true;                                 //                  "
            }
        }
    }
}