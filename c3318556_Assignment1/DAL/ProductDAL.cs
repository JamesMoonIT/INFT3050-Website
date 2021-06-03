/*
    Name: James Moon
    Last Updated: 3/6/2021
    Description: This class handles all methods to do with Product and the database.
 
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
    public class ProductDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public string PullProductName(int productID)                                            // Takes productID and returns product name
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

        public string PullProductBrand(int productID)                                           // Takes productID and returns brand
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

        public string PullProductType(int productID)                                            // Takes productID and returns product type
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

        public string PullProductModel(int productID)                                           // Takes productID and returns product model
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

        public string PullProductDescription(int productID)                                     // Takes productID and returns product description
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

        public string PullProductPrice(int productID)                                           // Takes productID and returns product price
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

        public string PullProductImage(int productID)                                           // Takes productID and returns product image url
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