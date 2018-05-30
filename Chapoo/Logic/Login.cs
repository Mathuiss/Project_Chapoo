using System;
using Chapoo.Data;

namespace Chapoo.Logic
{
    //Mathijs Geerlings, 2018
    //This class handles all the login logic
    public class Login
    {
        public bool TryLogin(string username, string password)
        {
            if (!CheckCredentials(username))
            {
                return false;
            }

            if (!CheckCredentials(password))
            {
                return false;
            }

            //Calling UserDAO
            var user = new UsersDAO();
            user.Login(username, password);
        }
        
        //Checks the input for invalid things
        private bool CheckCredentials(string text)
        {
            char[] letters = text.ToCharArray();
            string AllowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890.?!@#$%^&*()_";

            for (int i = 0; i < letters.Length; i++)
            {
                if (!AllowedChars.Contains(letters[i].ToString()))
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsLoggedIn(string username)
        {

        }
    }
}
