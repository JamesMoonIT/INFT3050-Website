using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace c3318556_Assignment1.DAL
{
    public class RegisterDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public bool InsertUser(string firstName, string lastName, string email, string phone)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Account (email, firstName, lastName, phone) VALUES ('@email', '@firstName', '@lastName', '@email', '@phone')");
            try
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Connection = con;
                cmd.ExecuteScalar();
            }
            catch
            {
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool InsertLogin(string email, string password)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Login (emailAddress, password) VALUES ('@email', '@password')");
            try
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Connection = con;
                cmd.ExecuteScalar();
            }
            catch
            {
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool InsertAddress(string streetNumber, string streetName, string suburb, string state, string postcode)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Address (streetNumber, streetName, suburb, state, postcode) VALUES ('@streetnumber','@streetName','@suburb','@state','@postcode')");
            try
            {
                cmd.Parameters.AddWithValue("@streetNumber", streetNumber);
                cmd.Parameters.AddWithValue("@streetName", streetName);
                cmd.Parameters.AddWithValue("@suburb", suburb);
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@postcode", postcode);
                cmd.Connection = con;
                cmd.ExecuteScalar();
            }
            catch
            {
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool GiveAdminPriv(string email) 
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Account SET adminPrivlages = true WHERE email = @email");
            try
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Connection = con;
                cmd.ExecuteScalar();
            }
            catch
            {
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool CheckAdminPriv(string userID)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    bool result;
                    rd.Read();
                    result = rd.GetBoolean(0);
                    con.Close();
                    if (result)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }
    }
}