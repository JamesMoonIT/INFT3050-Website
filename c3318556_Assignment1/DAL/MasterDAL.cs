/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Master and the database.
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace c3318556_Assignment1.DAL
{
    public class MasterDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public bool CheckPrivlages(int sessionID)                                       // Takes a sessionID and returns if user is admin
        {
            int userID = GrabUserID(sessionID);
            bool approval = false;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE userID = @userID", con);
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    approval = rd.GetBoolean(0);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return approval;
        }

        public int GrabUserID(int sessionID)                                            // Takes a sessionID and returns userID
        {
            int userID = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT userID FROM Session WHERE sessionID = @sessionID");
            try
            {
                cmd.Parameters.AddWithValue("@sessionID", sessionID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                userID = rd.GetInt32(0);
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return userID;
        }

        private void OpenConnection()                                                   // Opens the connection
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }

        private void CloseConnection()                                                  // Closes the connection
        {
            if (ConnectionState.Open == con.State)
                con.Close();
        }
    }
}