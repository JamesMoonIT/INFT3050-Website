using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class MasterBL
    {
        MasterDAL masDAL = new MasterDAL();

        public bool IsCurrentAdmin(int userID)
        {
            try
            {
                return masDAL.CheckPrivlages(userID);
            }
            catch
            {
                return false;
            }
        }
    }
}