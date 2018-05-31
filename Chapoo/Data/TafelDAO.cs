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
            string tafelId = tafelnummer.ToString();

            string query = "Select status from bestelling where id = '@tafelId'";
            query = query.Replace("@tafelId", tafelId);

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
        
        public void Tafelbezetten(int nummer)
        {
            string tafelnummer = nummer.ToString();
            string query = "update tafel set isBezet = 1 where isBezet = '@nummer'";
            query = query.Replace("@nummer", tafelnummer);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void TafelVrijGeven(int tNummer)
        {
            string tafelnummer = tNummer.ToString();
            string query = "update tafel set isBezet = 0 where isBezet = '@nummer'";
            query = query.Replace("@nummer", tafelnummer);

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
