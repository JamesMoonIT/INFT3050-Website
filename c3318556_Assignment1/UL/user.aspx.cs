using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFirstName.Text = Session["FirstName"].ToString();
            lblLastName.Text = Session["LastName"].ToString();
            lblEmail.Text = Session["Email"].ToString();
            lblMobile.Text = Session["Phone"].ToString();
            lblAddress.Text = Session["Address"].ToString();
        }
    }
}