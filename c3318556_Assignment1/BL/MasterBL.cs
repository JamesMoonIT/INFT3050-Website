/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Master.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class MasterBL                                                       
    {
        MasterDAL masDAL = new MasterDAL();                                     // Creates a calling method for refering to methods inside LoginDAL.cs

        public bool IsCurrentAdmin(int sessionID)                               // Takes a sessionID and returns in the user is admin
        {
            try
            {
                return masDAL.CheckPrivlages(sessionID);
            }
            catch
            {
                return false;
            }
        }
    }
}