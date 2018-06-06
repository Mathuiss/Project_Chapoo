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
        public bool TafelVrij(int tafelnummer)
        {
            string query = "Select status from bestelling where id = '@tafelId'";
            query = query.Replace("@tafelId", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);

                string o = (string)command.ExecuteScalar();

                connection.Close();
                if (o != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        } 
        
        public void Tafelbezetten(int tafelnummer)
        {
            string query = "update tafel set isBezet = 1 where isBezet = '@nummer'";
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
            string query = "update tafel set isBezet = 0 where isBezet = '@nummer'";
            query = query.Replace("@nummer", tafelnummer.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
