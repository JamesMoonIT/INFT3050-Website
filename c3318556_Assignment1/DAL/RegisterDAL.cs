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

        public void InsertUser(string firstName, string lastName, string email, string phone)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Account (email, firstName, lastName, phone) VALUES ('@email', '@firstName', '@lastName', '@email', '@phone')");
        }

        public void InsertLogin(string email, string password)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Login (emailAddress, password) VALUES ('@email', '@password')");
            try
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Connection = con;
                cmd.ExecuteReader();
            }
            catch
            {
                con.Close();
            }
            con.Close();
        }

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }
    }
}