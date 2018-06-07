using System;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    //Robbin Kragtwijk
    public class UsersDAO
    {
        public int GetUserId(string username)
        {
            string query = "select id from gebruiker where gebruikersnaam = '@naam'";
            query = query.Replace("@naam", username);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public bool Login(string username, string password)
        {
            if (password.Equals(GetPwd(username)))
            {
                string query = "update gebruiker set isIngelogd = 1 where gebruikersnaam = '@username'";
                query = query.Replace("@username", username);

                using (SqlConnection connection = Utils.GetConenction())
                {
                    connection.Open();

                    var command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            else
            {
                throw new Exception("Password incorrect!");
            }
        }

        public bool UserExists(string username)
        {
            string query = "select gebruikersnaam from gebruiker where gebruikersnaam = '@x'";
            query = query.Replace("@x", username);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();


                var command = new SqlCommand(query, connection);
                string o = (string)command.ExecuteScalar();

                connection.Close();
                if (o != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsLoggedIn(string username)
        {
            string query = "select isIngelogd from gebruiker where gebruikersnaam = '@username'";
            query = query.Replace("@username", username);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);

                try
                {
                    return (bool)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public void LogOut(string username)
        {
            string query = "update gebruiker set isIngelogd = 0 where gebruikersnaam = '@username'";
            query = query.Replace("@username", username);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private string GetPwd(string username)
        {
            string query = "select wachtwoord from gebruiker where gebruikersnaam = '@username'";
            query = query.Replace("@username", username);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                string password = (string)result;
                return password;
            }
        }
    }
}
