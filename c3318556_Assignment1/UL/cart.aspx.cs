using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace c3318556_Assignment1.UL
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void p1Add_Click(object sender, EventArgs e)
        {
            int i1Quantity = Convert.ToInt32(p1Quantity.Text);
            i1Quantity++;
            p1Quantity.Text = Convert.ToString(i1Quantity);
        }

        protected void p2Add_Click(object sender, EventArgs e)
        {
            int i2Quantity = Convert.ToInt32(p2Quantity.Text);
            i2Quantity++;
            p2Quantity.Text = Convert.ToString(i2Quantity);
        }

        protected void p3Add_Click(object sender, EventArgs e)
        {
            int i3Quantity = Convert.ToInt32(p3Quantity.Text);
            i3Quantity++;
            p3Quantity.Text = Convert.ToString(i3Quantity);
        }

        protected void p4Add_Click(object sender, EventArgs e)
        {
            int i4Quantity = Convert.ToInt32(p4Quantity.Text);
            i4Quantity++;
            p4Quantity.Text = Convert.ToString(i4Quantity);
        }

        protected void p5Add_Click(object sender, EventArgs e)
        {
            int i5Quantity = Convert.ToInt32(p5Quantity.Text);
            i5Quantity++;
            p5Quantity.Text = Convert.ToString(i5Quantity);
        }

        protected void p1Subtract_Click(object sender, EventArgs e)
        {
            int i1Quantity = Convert.ToInt32(p1Quantity.Text);
            i1Quantity--;
            p1Quantity.Text = Convert.ToString(i1Quantity);
        }

        protected void p2Subtract_Click(object sender, EventArgs e)
        {
            int i2Quantity = Convert.ToInt32(p2Quantity.Text);
            i2Quantity--;
            p2Quantity.Text = Convert.ToString(i2Quantity);
        }

        protected void p3Subtract_Click(object sender, EventArgs e)
        {
            int i3Quantity = Convert.ToInt32(p3Quantity.Text);
            i3Quantity--;
            p3Quantity.Text = Convert.ToString(i3Quantity);
        }

        protected void p4Subtract_Click(object sender, EventArgs e)
        {
            int i4Quantity = Convert.ToInt32(p4Quantity.Text);
            i4Quantity--;
            p4Quantity.Text = Convert.ToString(i4Quantity);
        }

        protected void p5Subtract_Click(object sender, EventArgs e)
        {
            int i5Quantity = Convert.ToInt32(p5Quantity.Text);
            i5Quantity--;
            p5Quantity.Text = Convert.ToString(i5Quantity);
        }
    }
}