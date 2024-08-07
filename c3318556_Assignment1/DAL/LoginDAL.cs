﻿/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Login and the database.
 
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
    public class LoginDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public int VerifyUserLogin(string strEmail, string strPassword)                         // Takes an email and password and verifies them, then returns value based on verification
        {
            try
            {
                if (!CheckEmail(strEmail))
                {
                    return 5;
                }
                if (!CheckEmailAndPassword(strEmail, strPassword))
                {
                    return 4;
                }
                return 7;
            }
            catch
            {
                return 3;
            }
        }

        public bool CheckEmailAndPassword(string strEmail, string strPassword)                  // Takes an email and password and sees if they exist in the database
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT emailAddress, password FROM Login WHERE emailAddress = @emailAddress AND password = @password", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", strEmail);
                cmd.Parameters.AddWithValue("@password", strPassword);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    CloseConnection();
                    return true;
                }
            }
            catch
            {
                CloseConnection();
                return false;
            }
            CloseConnection();
            return false;
        }

        public bool CheckEmail(string email)                                                    // Takes an email and sees if they exist in the database
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT emailAddress FROM Login WHERE emailAddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    CloseConnection();
                    return true;
                }
            }
            catch
            {
                CloseConnection();
                return false;
            }
            CloseConnection();
            return false;
        }

        public bool CheckPriviliges(string email)                                               // Takes an email and checks if user is admin
        {
            bool approval = false;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE emailaddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    approval = rd.GetBoolean(0);
                    con.Close();
                }
            }
            catch
            {
                CloseConnection();
            }
            return approval;
        }

        public string PullName(int sessionID)                                                   // Takes a sessionID and returns first name
        {
            int userID = GrabUserID(sessionID);
            string name = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT firstName FROM Account WHERE userID = @userID", con);
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    name = rd.GetString(0);
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
            return name;
        }

        public string PullName(string email)                                                    // Tales an email and returns first name
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT firstName FROM Account WHERE emailAddress = @emailAddress");
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetString(0);
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
            return result;
        }

        public int GrabUserID(string email)                                                     // Takes an email and returns userID
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT userID FROM Account WHERE emailAddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
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
            return result;
        }

        public int GrabUserID(int sessionID)                                                    // Takes a sessionID and returns userID
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

        public int BuildUserSession(int userID, string username)                                // Takes userID and username and returns sessionID
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Session (userID, username) VALUES (@userID, @username)");
            SqlCommand cmd2 = new SqlCommand("SELECT sessionID FROM Session WHERE userID = @userID");
            try
            {
                cmd1.Parameters.AddWithValue("@userID", userID);
                cmd1.Parameters.AddWithValue("@username", username);
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@userID", userID);
                cmd2.Connection = con;
                SqlDataReader rd = cmd2.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
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
            return result;
        }

        public int GrabSessionID(int userID)                                                    // Takes userID and returns sessionID
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT sessionID FROM Session WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = rd.GetInt32(0);
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        public bool DoesEmailExist(string email)                                                // Takes email and returns if it exists in database
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT emailAddress from Login where emailAddress = @emailAddress");
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (!rd.HasRows)
                {
                    rd.Read();
                    return false;
                }
            }
            catch
            {
                return true;
            }
            finally
            {
                CloseConnection();
            }
            return true;
        }

        public bool IsAccountDeactivated(string email)                                          // Takes email and checks if the account is deactivated
        {
            bool result = true;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT isActive FROM Account WHERE emailAddress = @emailAddress");
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = rd.GetBoolean(0);
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        private void OpenConnection()                                                           // Opens the connection
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }

        private void CloseConnection()                                                          // Closes the connection
        {
            if (ConnectionState.Open == con.State)
                con.Close();
        }
    }
}