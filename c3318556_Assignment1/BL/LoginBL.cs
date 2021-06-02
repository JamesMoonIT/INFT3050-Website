using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class LoginBL
    {
        LoginDAL logDAL = new LoginDAL();
        AccountDAL accDAL = new AccountDAL();
        public int CheckUserLogin(string email, string password)
        {
            try
            {
                if (!IsEmailValid(email))
                {
                    return 1;
                }
                else if (!IsPasswordSafe(password))
                {
                    return 2;
                }
                else
                {
                    password = MD5Hash(password);
                    return logDAL.VerifyUserLogin(email, password);
                }
            }
            catch
            {
                return 5;
            }
        }

        public bool IsAdmin(string email)
        {
            try
            {
                return logDAL.CheckPriviliges(email);
            }
            catch
            {
                return false;
            }
        }

        public string GetName(int sessionID)
        {
            string name = "";
            try
            {
                name = logDAL.PullName(sessionID);
                return name;
            }
            catch
            {
                throw;
            }
        }

        public string GetName(string email)
        {
            string name = "";
            try
            {
                name = logDAL.PullName(email);
                return name;
            }
            catch
            {
                throw;
            }
        }

        private bool IsEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);              // checks format of email
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsPasswordSafe(string password)
        {
            const int minlength = 6;
            if (password.Length < minlength)
            {
                return false;
            }
            if (!password.Any(c => char.IsUpper(c)))
            {
                return false;
            }
            if (!password.Any(c => char.IsDigit(c)))
            {
                return false;
            }
            return true;
        }

        public int GetUserID(string email)
        {
            try
            {
                return logDAL.GrabUserID(email);
            }
            catch
            {
                throw;
            }
        }
        
        public int CreateSession(int userID, string username)
        {
            try
            {
                return logDAL.BuildUserSession(userID, username);
            }
            catch
            {
                throw;
            }
        }
        
        public int GetSessionID(int userID)
        {
            try
            {
                return logDAL.GrabSessionID(userID);
            }
            catch
            {
                throw;
            }
        }

        // sourced from https://www.godo.dev/tutorials/csharp-md5/ 24/5/2021 10:20am
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}