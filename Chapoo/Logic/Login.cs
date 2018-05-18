using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapoo.Data;

namespace Chapoo.Logic
{
    public class Login
    {
        const string ALPHABET = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.? ";

        public void Login(string username, string password)
        {
            Validate(username);
            string hash = Encrypt(password);
            //UserDAO.Login(username, hash)
        }
        
        bool Validate(string username)
        {
            bool isCorrect = true;

            var unamearray = username.ToCharArray();

            for (int i = 0; i < unamearray.Length; i++)
            {
                if (!ALPHABET.Contains(unamearray[i]))
                {
                    isCorrect = false;
                    return isCorrect;
                }
            }

            if ()
            {

            }
        }

        string Encrypt(string password)
        {
            return "";
        }
    }
}
