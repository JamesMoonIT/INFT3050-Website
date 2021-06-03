using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class AccountBL
    {
        AccountDAL accDAL = new AccountDAL();

        public bool SessionAlreadyExists(int userID)
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

        public int GetUserID(int sessionID)
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

        public int GetAddressID(int userID)
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

        public int GetCartID(int userID)
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

        public string GetFirstName(int userID)
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

        public string GetLastName(int userID)
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

        public string GetEmail(int userID)
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

        public int GetMobile(int userID)
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
        {
            return accDAL.BuildTransaction(addressID, cartID, nameOnCard, cardNo, cardMonth, cardYear, cardCVV);
        }
    }
}