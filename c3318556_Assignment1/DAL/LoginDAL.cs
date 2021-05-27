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
            bool approval = false;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE emailaddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    approval = rd.GetBoolean(0);
                    con.Close();
                }
            }
            catch
            {
                con.Close();
            }
            return approval;
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
                }
            }
            catch
            {
                name = "NONAMEFOUND";
            }
            finally
            {
                con.Close();
            }
            return name;
        }

        public int GrabUserID(string email)
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT userID FROM Account WHERE emailAddress = @emailAddress", con);
            try
            {
                cmd.Parameters.AddWithValue("@emailAddress", email);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
                }
            }
            catch
            {
                result = 0;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public void BuildUserSession(int userID)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Session (userID) VALUES ('@userID')");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
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