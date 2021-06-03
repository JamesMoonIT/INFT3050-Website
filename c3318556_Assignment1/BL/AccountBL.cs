/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Account.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class AccountBL
    {
        AccountDAL accDAL = new AccountDAL();                       // Creates a calling method for refering to methods inside AccountDAL.cs

        public bool SessionAlreadyExists(int userID)                // Takes a userID and returns a bool if session exists
        {
            try
            {
                return accDAL.CheckUserID(userID);
            }
            catch
            {
                return false;
            }
        }

        public int GetUserID(int sessionID)                         // Takes a sessionID and returns a userID
        {
            try
            {
                return accDAL.GrabUserID(sessionID);
            }
            catch
            {
                throw;
            }
        }

        public int GetAddressID(int userID)                         // Takes a userID and returns an addressID
        {
            try
            {
                return accDAL.GrabAddressID(userID);
            }
            catch
            {
                throw;
            }
        }

        public int GetCartID(int userID)                            // Takes a userID and returns a cartID
        {
            try
            {
                return accDAL.GrabCartID(userID);
            }
            catch
            {
                throw;
            }
        }

        public string GetFirstName(int userID)                      // Takes a userID and returns a First Name
        {
            try
            {
                return accDAL.PullFirstName(userID);
            }
            catch
            {
                throw;
            }
        }

        public string GetLastName(int userID)                       // Takes a userID and returns a Last Name
        {
            try
            {
                return accDAL.PullLastName(userID);
            }
            catch
            {
                throw;
            }
        }

        public string GetEmail(int userID)                          // Takes a userID and returns an email
        {
            try
            {
                return accDAL.PullEmail(userID);
            }
            catch
            {
                throw;
            }
        }

        public int GetMobile(int userID)                            // Takes a userID and returns a mobile
        {
            try
            {
                return accDAL.PullMobile(userID);
            }
            catch
            {
                throw;
            }
        }

        public int CreateTransaction(int addressID, int cartID, string nameOnCard, int cardNo, int cardMonth, int cardYear, int cardCVV)
        {                                                           // ^ Takes transaction information and returns a transactionID
            try
            {
                return accDAL.BuildTransaction(addressID, cartID, nameOnCard, cardNo, cardMonth, cardYear, cardCVV);
            }
            catch
            {
                throw;
            }
        }
    }
}