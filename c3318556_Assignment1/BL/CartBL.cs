using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class CartBL
    {
        CartDAL cartDAL = new CartDAL();

        public int GetUserID(int sessionID)
        {
            try
            {
                    return cartDAL.PullUserID(sessionID);
            }
            catch
            {
                throw;
            }
        }

        public void CreateCart(int userID, int productID)
        {
            try
            {
                cartDAL.BuildCart(userID, productID);
            }
            catch
            {
                throw;
            }
        }

        public bool CartExists(int userID, int productID)
        {
            try
            {
                return cartDAL.CheckForCart(userID, productID);
            }
            catch
            {
                throw;
            }
        }

        public void IncreaseProductInCart(int useriD, int productID)
        {
            try
            {
                cartDAL.IncreaseQuantity(useriD, productID);
            }
            catch
            {
                throw;
            }
        }
    }
}