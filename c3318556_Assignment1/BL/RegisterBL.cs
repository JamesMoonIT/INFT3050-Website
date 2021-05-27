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
                // return broken, caught by catch in register.aspx
            }
        }

        public bool AddUser(string firstName, string lastName, string email, string phone)
        {
            RegisterDAL regDAL = new RegisterDAL();
            try
            {
                regDAL.InsertUser(firstName, lastName, email, phone);
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public bool AddLogin(string email, string password)
        {
            RegisterDAL regDAL = new RegisterDAL();
            password = MD5Hash(password);
            try
            {
                regDAL.InsertLogin(email, password);
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public bool MakeAdmin(string email)
        {
            RegisterDAL regDL = new RegisterDAL();
            try
            {
                regDL.GiveAdminPriv(email);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool CheckUserAdmin(string userID)
        {
            RegisterDAL regDL = new RegisterDAL();
            try
            {
                if(!regDL.CheckAdminPriv(userID))
                {
                    return false;
                }
            }
            catch
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