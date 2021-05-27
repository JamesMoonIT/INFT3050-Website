using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace c3318556_Assignment1.DAL
{
    public class MasterDAL
    {
        private string conString = ConfigurationManager.ConnectionStrings["c3318556_SQLDatabaseConnectionString"].ToString();
        SqlConnection con = new SqlConnection();

        public bool CheckPrivlages(int userID)
        {
            bool approval = false;
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT adminPrivlages FROM Account WHERE userID = @userID", con);
            try
            {
                cmd.Parameters.AddWithValue("@userID", userID);
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

        private void OpenConnection()
        {
            con.ConnectionString = conString;
            if (ConnectionState.Closed == con.State)
                con.Open();
        }
    }
}