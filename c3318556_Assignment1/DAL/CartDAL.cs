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