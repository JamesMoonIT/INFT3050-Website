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
                return true;
            }
        }
    }
}