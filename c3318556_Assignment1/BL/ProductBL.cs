/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Product.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class ProductBL
    {
        ProductDAL proDAL = new ProductDAL();                                           // Creates a calling method for refering to methods inside LoginDAL.cs

        public string GetProductName(int productID)                                     // Takes a productID and returns product name
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

        public string GetProductBrand(int productID)                                    // Takes a productID and returns product brand
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

        public string GetProductType(int productID)                                     // Takes a productID and returns product type
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

        public string GetProductModel(int productID)                                    // Takes a productID and returns product model
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

        public string GetProductDescription(int productID)                              // Takes a productID and returns a product description
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

        public string GetProductPrice(int productID)                                    // Takes a productID and returns a product price
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

        public string GetProductImage(int productID)                                    // Takes a productID and returns product image url
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