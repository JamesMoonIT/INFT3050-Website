using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Text;
using c3318556_Assignment1.DAL;

namespace c3318556_Assignment1.BL
{
    public class RegisterBL
    {
        RegisterDAL regDAL = new RegisterDAL();

        public bool IsValidEmail(string email)                                         // validates key
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

        public string makeKey()                                                // creates a randomly generated key
        {
            var rand = new Random();                                            // declare random class
            string key = Convert.ToString(rand.Next(10000, 99999));             // generates a random number between 10000 and 99999
            return key;                                                         // returns randomly generated key
        }

        public void sendConfirmation(string key, string email)                                               // sends confirmation email with session key
        {
            string to = email; //To address    
            string from = "myuser1245@gmail.com"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = "Thank you for registering with GarageBay. In order to complete the Registration, please use this key to complete your sign up with our website" + "<br /><br />" + "Verification Key: " + key + "<br /><br />" + "Be sure to use our contact us page if there are any issues" + "<br /><br />" + "From, " + "<br /><br />" + "GarageBay Support Team";
            message.Subject = "GarageBay | Verification Key: " + key;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("myuser1245@gmail.com", "Pas5word");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }
            catch
            {
                throw;
            }
        }

        public int AddUser(string firstName, string lastName, string email, string phone, bool adminPriv, int addressID)
        {
            int result = 0;
            try
            {
                result = regDAL.InsertUser(firstName, lastName, email, phone, adminPriv, addressID);
            }
            catch
            {
                throw;
            }
            return result;
        }

        public string AddLogin(string email, string password)
        {
            string result = "";
            password = MD5Hash(password);
            try
            {
                result = regDAL.InsertLogin(email, password);
            }
            catch
            {
                throw;
            }
            return result;
        }

        public bool MakeAdmin(int sessionID)
        {
            try
            {
                regDAL.GiveAdminPriv(sessionID);
            }
            catch
            {
                throw;
            }
            return true;
        }

        public bool CheckUserAdmin(int sessionID)
        {
            try
            {
                if (!regDAL.CheckAdminPriv(sessionID))
                {
                    return false;
                }
            }
            catch
            {
                throw;
            }
            return true;
        }

        public int CreateSession(int userID, string firstname)
        {
            return regDAL.BuildUserSession(userID, firstname);
        }

        public int AddAddress(int streetNo, string streetName, string suburb, string state, int postcode)
        {
            try
            {
                return regDAL.CreateAddress(streetNo, streetName, suburb, state, postcode);
            }
            catch
            {
                throw;
            }
        }

        public bool DoesEmailExist(string email)
        {
            try
            {
                return regDAL.CheckEmailAddress(email);
            }
            catch
            {
                return true;
            }
        }

        public bool ValidateKey(int storedKey, int enteredKey)
        {
            if (enteredKey == storedKey)                                 // checks if key emailed matches session
            {
                return true;
            }
            return false;
        }

        public bool IsAddressValid(string streetNo, string streetName, string suburb, string state, string postcode)
        {
            if (!IsAllDigits(streetNo))
            {
                return false;
            }
            else if (!IsAllLetters(suburb))
            {
                return false;
            }
            else if (!IsAllLetters(state))
            {
                return false;
            }
            else if (!IsAllDigits(postcode))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public string GetUserName(int sessionID)
        {
            string name = "";
            try
            {
                name = regDAL.PullName(sessionID);
                return name;
            }
            catch
            {
                return "NameNotFound";
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