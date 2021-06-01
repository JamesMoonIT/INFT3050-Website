/*
    Author: James Moon
    Last Updated: 3:24pm 3 / 4 / 2021
    Description: This is where the user enters their email (if they are a guest), their card detials and their prefered
        delivery address. The card validation checks to make sure the card details are valid and correctly formatted
        and fails if it is not correct.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c3318556_Assignment1.BL;

namespace c3318556_Assignment1.UL
{
    public partial class products : System.Web.UI.Page
    {
        AdminBL admBL = new AdminBL();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //RepeterData();
            }
        }

        protected void name_Click(object sender, EventArgs e)
        {
            Response.Redirect("product.aspx");
        }
    }
}