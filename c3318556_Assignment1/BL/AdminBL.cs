/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Admin.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class AdminBL
    {
        AdminDAL admDAL = new AdminDAL();                                       // Creates a calling method for refering to methods inside AdminDAL.cs

        public bool IsCurrentAdmin(int sessionID)                               // Takes a session ID and returns bool of adminPrivlages
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