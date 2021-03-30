using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerNow_Click(object sender, EventArgs e)
        {
            string strFirstName = Convert.ToString(firstName.Text);
            string strLastName = Convert.ToString(lastName.Text);
            string strEmailStore = Convert.ToString(emailAddress.Text);
            string strPasswordStore = Convert.ToString(userPassword.Text);
            string intPhoneNo = Convert.ToString(mobile.Text);
            string strAddress = Convert.ToString(postalAddress.Text);

            if (strFirstName == "" || strLastName == "" || strEmailStore == "" || strPasswordStore == "" || strPasswordStore == "" || intPhoneNo == "" || strAddress == "")
            {
                lblFeedback.Text = "Please make sure to fill all fields";
            }
            else
            {
                Session["UID"] = 100002;
                Session["UserName"] = strFirstName;
                Session["FirstName"] = strFirstName;
                Session["LastName"] = strLastName;
                Session["Email"] = strEmailStore;
                Session["Phone"] = intPhoneNo;
                Session["Address"] = strAddress;
                Response.Redirect("home.aspx?UID=100000");
            }
        }

        protected void existingUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}