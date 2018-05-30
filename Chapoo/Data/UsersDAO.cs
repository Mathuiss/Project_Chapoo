using System;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    public class UsersDAO
    {
        public bool Login(string username, string password)
        {
            string query = "select wachtwoord from gebruiker where gebruikersnaam = '@username'";
            query.Replace("@username", username);

            SqlConnection connection = Utils.GetConenction();
            connection.Open();

            var command = new SqlCommand(query, connection);

            object passwdactal = command.ExecuteReader();
            connection.Close();

            if (password.Equals(passwdactal))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UserExists(string username)
        {
            string query = "select gebruikersnaam from gebruiker where gebruikersnaam = '@x'";
            query.Replace("@x", username);

            SqlConnection connection = Utils.GetConenction();
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

        private void GetPwd(string username)
        {
            string query = "select password from gebruiker where username = '@username'";
            query.Replace("@username", username);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                string password = (string)result;
            }
        }
    }
}
