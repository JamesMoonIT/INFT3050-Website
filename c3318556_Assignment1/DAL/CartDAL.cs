using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace c3318556_Assignment1.DAL
{
    public class CartDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public int PullUserID(int sessionID)
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

        public void BuildCart(int userID, int productID)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO ShoppingCart (userID, productID) VALUES (@userID, @productID)");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool CheckForCart(int userID, int productID)
        {
            bool result = true;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT cartID FROM ShoppingCart WHERE userID = @userID AND productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    result = true;
                }
                else
                {
                    result = false;
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

        public void IncreaseQuantity(int userID, int productID)
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("SELECT productQuantity FROM ShoppingCart WHERE userID = @userID AND productID = @productID");
            SqlCommand cmd2 = new SqlCommand("UPDATE ShoppingCart SET productQuantity = @newQuantity WHERE userID = @userID AND productID = @productID");
            try
            {
                cmd1.Parameters.AddWithValue("@userID", userID);
                cmd1.Parameters.AddWithValue("@productID", productID);
                cmd1.Connection = con;
                SqlDataReader rd = cmd1.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
                    result++;
                }
                cmd2.Parameters.AddWithValue("@newQuantity", result);
                cmd2.Parameters.AddWithValue("@userID", userID);
                cmd2.Parameters.AddWithValue("@productID", productID);
                cmd2.Connection = con;
                cmd2.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }

        private void CloseConnection()
        {
            if (ConnectionState.Open == con.State)
                con.Close();
        }
    }
}