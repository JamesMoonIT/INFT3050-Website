using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class ProductBL
    {
        ProductDAL proDAL = new ProductDAL();

        public string GetProductName(int productID)
        {
            try
            {
                return proDAL.PullProductName(productID);
            }
            catch
            {
                throw;
            }
        }

        public string GetProductBrand(int productID)
        {
            try
            {
                return proDAL.PullProductBrand(productID);
            }
            catch
            {
                throw;
            }
        }

        public string GetProductType(int productID)
        {
            try
            {
                return proDAL.PullProductType(productID);
            }
            catch
            {
                throw;
            }
        }

        public string GetProductModel(int productID)
        {
            try
            {
                return proDAL.PullProductModel(productID);
            }
            catch
            {
                throw;
            }
        }

        public string GetProductDescription(int productID)
        {
            try
            {
                return proDAL.PullProductDescription(productID);
            }
            catch
            {
                throw;
            }
        }

        public string GetProductPrice(int productID)
        {
            try
            {
                return proDAL.PullProductPrice(productID);
            }
            catch
            {
                throw;
            }
        }

        public string GetProductImage(int productID)
        {
            try
            {
                return proDAL.PullProductImage(productID);
            }
            catch
            {
                throw;
            }
        }
    }
}