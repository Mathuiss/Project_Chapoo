using System;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    public class UsersDAO
    {
        public void Login()
        {
            
        }
        public bool UserExists(string username)
        {
            string query = "select username from gebruikers where username = '@username'";
            query.Replace("@username", username);
            var command = new SqlCommand(query, Utils.GetConenction());
            object o = command.ExecuteScalar();

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
            string query = "select password from gebruikers where username = '@username'";
            query.Replace("@username", username);
            var command = new SqlCommand(query, Utils.GetConenction());
            object result = command.ExecuteScalar();
            string password = (string)result;
        }
    }
}
