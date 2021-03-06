﻿using System;
using Chapoo.Data;

namespace Chapoo.Logic
{
    //Mathijs Geerlings, 2018
    //This class handles all the login logic
    public class User
    {
        public bool TryLogin(string username, string password)
        {
            if (!Validator.CheckCredentials(username))
            {
                return false;
            }

            if (!Validator.CheckCredentials(password))
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
        
        public bool IsLoggedIn(string username)
        {
            var user = new UsersDAO();
            return user.IsLoggedIn(username);
        }

        public void Logout(string username)
        {
            var user = new UsersDAO();
            user.LogOut(username);
        }

        public int GetUserId(string username)
        {
            var user = new UsersDAO();
            return user.GetUserId(username);
        }
    }
}
