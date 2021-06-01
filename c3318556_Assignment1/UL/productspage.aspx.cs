/*
    Author: James Moon
    Last Updated: 3:24pm 3 / 4 / 2021
    Description: This is where the user enters their email (if they are a guest), their card detials and their prefered
        delivery address. The card validation checks to make sure the card details are valid and correctly formatted
        and fails if it is not correct.
*/

using System;
using System.Collections.Generic;
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

        protected void Gridview1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void Gridview1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void Gridview1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}