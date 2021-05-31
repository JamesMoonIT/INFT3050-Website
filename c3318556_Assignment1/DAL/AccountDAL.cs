﻿using System;
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

        public bool CheckUserID(int userID)
        {
            bool result = true;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT email FROM Account WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetBoolean(0);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }
    }
}