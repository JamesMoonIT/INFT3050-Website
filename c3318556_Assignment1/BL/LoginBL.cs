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
        public int CheckUserLogin(string email, string password)
        {
            LoginDAL accDAL = new LoginDAL();
            try
            {
                if (!IsEmailValid(email))
                {
                    return 1;
                }
                if (!IsPasswordSafe(password))
                {
                    return 2;
                }
                password = MD5Hash(password);
                return accDAL.VerifyUserLogin(email, password);
            }
            catch
            {
                return 5;
            }
        }

        public bool IsAdmin(string email)
        {
            LoginDAL accDAL = new LoginDAL();
            try
            {
                return accDAL.CheckPriviliges(email);
            }
            catch
            {
                return false;
            }
        }

        public string GetName(string email)
        {
            LoginDAL accDAL = new LoginDAL();
            string name = "";
            try
            {
                name = accDAL.PullName(email);
                return name;
            }
            catch
            {
                return "NameNotFound";
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