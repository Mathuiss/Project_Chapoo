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

            if (user.UserExists(username))
            {
                if (user.Login(username, password))
                {
                    return true;
                }
                else
                {
                    //If you cannot login but the user exists
                    throw new Exception("Password incorrect!");
                }
            }
            else
            {
                //If the user doesn't exist
                throw new Exception("User does not exist");
            }
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
            var user = new UsersDAO();
            return user.IsLoggedIn(username);
        }

        public void Logout(string username)
        {
            var user = new UsersDAO();

        }
    }
}
