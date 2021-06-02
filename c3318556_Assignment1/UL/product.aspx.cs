using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c3318556_Assignment1.BL;

namespace c3318556_Assignment1.UL
{
    public partial class product : System.Web.UI.Page
    {
        ProductBL proBL = new ProductBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string absoluteurl = HttpContext.Current.Request.Url.AbsoluteUri;
            int lastPart = Convert.ToInt32(absoluteurl.Split('/').Last());
            productName.Text = proBL.GetProductName(lastPart);
            productID.Text = Convert.ToString(lastPart);
            productBrand.Text = proBL.GetProductBrand(lastPart);
            productType.Text = proBL.GetProductType(lastPart);
            productModel.Text = proBL.GetProductModel(lastPart);
            productDescription.Text = proBL.GetProductDescription(lastPart);
            productPrice.Text = proBL.GetProductPrice(lastPart);
            pImage.ImageUrl = proBL.GetProductImage(lastPart);
        }
    }
}