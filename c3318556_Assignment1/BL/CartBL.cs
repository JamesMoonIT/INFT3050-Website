/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Cart.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class CartBL
    {
        CartDAL cartDAL = new CartDAL();                                                        // Creates a calling method for refering to methods inside CartDAL.cs

        public int GetUserID(int sessionID)                                                     // Takes a sessionID and returns a userID
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

        public void CreateCart(int userID, int productID)                                       // Takes a userID and productID and builds a Cart
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

        public bool CartExists(int userID, int productID)                                       // Takes a userID and productID and checks if card exists
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

        public void IncreaseProductInCart(int useriD, int productID)                            // Takes a userID and productID and increases product quantity
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

        public void RemoveProductInCart(int userID, int productID)                              // Takes a userID and productID and removes the item from cart
        {
            try
            {
                cartDAL.RemoveCart(userID, productID);
            }
            catch
            {
                throw;
            }
        }
    }
}