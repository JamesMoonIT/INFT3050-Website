using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class AdminBL
    {
        AdminDAL admDAL = new AdminDAL();

        public bool IsCurrentAdmin(int sessionID)
        {
            try
            {
                return admDAL.CheckPrivlages(sessionID);
            }
            catch
            {
                return false;
            }
        }
    }
}