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

        public int InsertUser(string firstName, string lastName, string email, string phone, int addressID)
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Account (emailAddress, firstName, lastName, phone, addressID) VALUES ('@email', '@firstName', '@lastName', '@email', '@phone', '@addressID')");
            SqlCommand cmd2 = new SqlCommand("SELECT userID FROM Account WHERE emailAddress = @email");
            try
            {
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@firstName", firstName);
                cmd1.Parameters.AddWithValue("@lastName", lastName);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@addressID", addressID);
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Connection = con;
                SqlDataReader rd = cmd2.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
                }

            }
            catch
            {
                con.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public string InsertLogin(string email, string password)
        {
            string result = "";
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Login (emailAddress, password) VALUES ('@email', '@password')");
            SqlCommand cmd2 = new SqlCommand("SELECT emailAddress FROM Login WHERE emailAddress = @emailAddress");
            try
            {
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@password", password);
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@emailAddress", email);
                cmd2.Connection = con;
                SqlDataReader rd = cmd2.ExecuteReader();
                rd.Read();
                result = rd.GetString(0);
            }
            catch
            {
                con.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
            return result;
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
                cmd.ExecuteNonQuery();
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

        public bool GiveAdminPriv(int sessionID)
        {
            OpenConnection();
            int userID = GrabUserID(sessionID);
            SqlCommand cmd = new SqlCommand("UPDATE Account SET adminPrivlages = true WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
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

        public int GrabUserID(int sessionID)
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
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return userID;
        }

        public bool CheckAdminPriv(int sessionID)
        {
            OpenConnection();
            int userID = GrabUserID(sessionID);
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE userID = @userID");
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Connection = con;
                SqlDataReader rd = cmd.ExecuteReader();
                bool result;
                rd.Read();
                result = rd.GetBoolean(0);
                con.Close();
                if (result)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public int CreateAddress(int streetNo, string streetName, string suburb, string state, int postcode)
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Address (streetNumber, streetName, suburb, state, postcode) VALUES ('@streetNo','@streetName','@suburb','@state','@postcode'");
            SqlCommand cmd2 = new SqlCommand("SELECT addressID FROM Address WHERE streetNumber = @streetNo AND streetName = @streetName AND suburb = @suburb AND state = @state AND postcode = @postcode");
            try
            {
                cmd1.Parameters.AddWithValue("@streetNo", streetNo);
                cmd1.Parameters.AddWithValue("@streetName", streetName);
                cmd1.Parameters.AddWithValue("@suburb", suburb);
                cmd1.Parameters.AddWithValue("@state", state);
                cmd1.Parameters.AddWithValue("@postcode", postcode);
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@streetNo", streetNo);
                cmd2.Parameters.AddWithValue("@streetName", streetName);
                cmd2.Parameters.AddWithValue("@suburb", suburb);
                cmd2.Parameters.AddWithValue("@state", state);
                cmd2.Parameters.AddWithValue("@postcode", postcode);
                cmd2.Connection = con;
                SqlDataReader rd = cmd2.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
                }
            }
            catch
            {
                con.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int BuildUserSession(int userID)
        {
            int result = 0;
            OpenConnection();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Session (userID) VALUES @userID");
            SqlCommand cmd2 = new SqlCommand("SELECT sessionID FROM Session WHERE userID = @userID");
            try
            {
                cmd1.Parameters.AddWithValue("@userID", userID);
                cmd1.Connection = con;
                cmd1.ExecuteNonQuery();
                cmd2.Parameters.AddWithValue("@userID", userID);
                cmd2.Connection = con;
                SqlDataReader rd = cmd2.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    result = rd.GetInt32(0);
                }
            }
            catch
            {
                con.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool CheckEmailAddress(string email)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT emailAddress FROM Account WHERE emailAddress = @email");
            try
            {
                cmd.Parameters.AddWithValue("@email", email);
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
            finally
            {
                con.Close();
            }
            return false;
        }

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }
    }
}