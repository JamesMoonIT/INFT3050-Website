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

        public int VerifyUserLogin(string strEmail, string strPassword)
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
                return 6;
            }
            catch
            {
                return 3;
            }
        }

        public bool CheckEmailAndPassword(string strEmail, string strPassword)
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
                    con.Close();
                    return true;
                }
            }
            catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return false;
        }

        public bool CheckEmail(string email)
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
                    con.Close();
                    return true;
                }
            }
            catch
            {
                con.Close();
                return false;
            }
            con.Close();
            return false;
        }

        public bool CheckPriviliges(string email)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE emailaddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    bool approval;
                    rd.Read();
                    approval = rd.GetBoolean(0);
                    con.Close();
                    if (approval == true)
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

        public string PullName(string email)
        {
            string name = "";
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT firstName FROM Account WHERE emailaddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    name = rd.GetString(0);
                    return name;
                }
            }
            catch
            {
                name = "NONAMEFOUND";
            }
            con.Close();
            return name;
        }

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }
    }
}