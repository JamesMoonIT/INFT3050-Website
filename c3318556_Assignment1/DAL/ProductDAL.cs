using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace c3318556_Assignment1.DAL
{
    public class ProductDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public string PullProductName(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pName FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
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

        public string PullProductBrand(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pBrand FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
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

        public string PullProductType(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pType FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
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

        public string PullProductModel(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pModel FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
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

        public string PullProductDescription(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pDesc FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
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

        public string PullProductPrice(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pPrice FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                result = Convert.ToString(rd.GetDecimal(0));
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

        public string PullProductImage(int productID)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT pImage FROM Product WHERE productID = @productID");
            try
            {
                cmd.Parameters.AddWithValue("@productID", productID);
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