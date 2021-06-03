/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Account and the database.
 
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
    public class AccountDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public bool CheckUserID(int userID)                                                             // Takes a userID and returns if it exists
        {
            bool result = false;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT sessionID FROM Session WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    result =  true;
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

        public int GrabUserID(int sessionID)                                                            // Takes a sessionID and returns UserID
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT userID from Session WHERE sessionID = @sessionID");
            try
            {
                cmd.Parameters.AddWithValue("@sessionID", sessionID);
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

        public int GrabAddressID(int userID)                                                            // Takes a userID and returns addressID
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT addressID FROM Account WHERE userID = @userID");
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

        public int GrabCartID(int userID)                                                               // Takes a userID and returns cartID
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT cartID FROM ShoppingCart WHERE userID = @userID");
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

        public int BuildTransaction(int addressID, int cartID, string nameOnCard, int cardNo, int cardMonth, int cardYear, int cardCVV)
        {                                                                                               // ^ Takes card details and returns a transactionID
            int result = 0;
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Transaction (addressID, cartID, cardName, cardNo, cardExpiryMonth, cardExpiryYear, cardCVV) VALUES (@addressID, @cartID, @cardName, @cardNo, @cardExpiryMonth, @cardExpiryYear, @cardCVV)");
            SqlCommand cmd2 = new SqlCommand("SELECT transactionID FROM Transaction WHERE addressID = @addressID AND cartID = @cartID AND cardName = @cardName AND cardNo = @cardNo AND cardExpiryMonth = @cardExpiryMonth AND cardExpiryYear = @cardExpiryYear AND cardCVV = @cardCVV");
            try
            {
                cmd1.Parameters.AddWithValue("@addressID", addressID);
                cmd1.Parameters.AddWithValue("@cartID", cartID);
                cmd1.Parameters.AddWithValue("@cardName", nameOnCard);
                cmd1.Parameters.AddWithValue("@cardNo", cardNo);
                cmd1.Parameters.AddWithValue("@cardMonthExpiry", cardMonth);
                cmd1.Parameters.AddWithValue("@cardExpiryYear", cardYear);
                cmd1.Parameters.AddWithValue("@cardCVV", cardCVV);
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@addressID", addressID);
                cmd2.Parameters.AddWithValue("@cartID", cartID);
                cmd2.Parameters.AddWithValue("@cardName", nameOnCard);
                cmd2.Parameters.AddWithValue("@cardNo", cardNo);
                cmd2.Parameters.AddWithValue("@cardMonthExpiry", cardMonth);
                cmd2.Parameters.AddWithValue("@cardExpiryYear", cardYear);
                cmd2.Parameters.AddWithValue("@cardCVV", cardCVV);
                cmd2.Connection = con;
                SqlDataReader rd = cmd2.ExecuteReader();
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

        public string PullFirstName(int userID)                                                         // Takes userID and returns first name
        {
            string result = "NONAMEFOUND";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT firstName FROM Account WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = rd.GetString(0);
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

        public string PullLastName(int userID)                                                          // Takes userID and returns last name
        {
            string result = "NONAMEFOUND";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT lastName FROM Account WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = rd.GetString(0);
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

        public string PullEmail(int userID)                                                             // Takes userID and returns email
        {
            string result = "NOEMAILFOUND";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT emailAddress FROM Account WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = rd.GetString(0);
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

        public int PullMobile(int userID)                                                               // Takes userID and returns mobile
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT mobile FROM Account WHERE userID = @userID");
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


        private void OpenConnection()                                                               // Opens the connection
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }

        private void CloseConnection()                                                              // Closes the connection
        {
            if (ConnectionState.Open == con.State)
                con.Close();
        }
    }
}