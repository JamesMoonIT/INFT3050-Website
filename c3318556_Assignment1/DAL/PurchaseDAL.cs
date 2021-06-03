using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace c3318556_Assignment1.DAL
{
    public class PurchaseDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public string PullTransactionID(int invoiceID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT transactionID FROM Invoice WHERE invoiceID = @invoiceID");
            try
            {
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = Convert.ToString(rd.GetInt32(0));
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

        public string PullSuccess(int invoiceID)
        {
            string result = "False";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT success FROM Invoice WHERE invoiceID = @invoiceID");
            try
            {
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.GetBoolean(0) == true)
                    result = "True";
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

        public string PullDateTime(int invoiceID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT dateTime FROM Invoice WHERE invoiceID = @invoiceID");
            try
            {
                cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = Convert.ToString(rd.GetDateTime(0));
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