using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    //Robbin 
    public class TafelDAO
    {
        public bool TafelBezet(int tafelnummer)
        {
            string query = "Select isBezet from tafel where id = '@tafelId'";
            query = query.Replace("@tafelId", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);

                return (bool)command.ExecuteScalar();
            }
        } 
        
        public void Tafelbezetten(int tafelnummer)
        {
            string query = "update tafel set isBezet = 1 where id = '@nummer'";
            query = query.Replace("@nummer", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void TafelVrijGeven(int tafelnummer)
        {
            string query = "update tafel set isBezet = 0 where id = '@nummer'";
            query = query.Replace("@nummer", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetBestelStatus(int tafelnummer)
        {
            string query = "select status from bestelling where tafel = @nummer order by id desc";
            query = query.Replace("@nummer", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public int GetOrder(int tafelnummer)
        {
            string query = "select id from bestelling where tafel = @nummer";
            query = query.Replace("@nummer", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }
    }
}
