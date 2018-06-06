using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Chapoo.Model;


namespace Chapoo.Data
{
    public class GerechtenDAO
    {
        public string BesteldeGerechten(int tNummer)
        {
            string tafelnummer = tNummer.ToString();

            string query = "select all from bestellingen where tafel = '@tafelnummer'";
            query = query.Replace("@tafelnummer", tafelnummer);

            using(SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return result.ToString();
            }
        }
        public Gerechten GetGerechten()
        {
            string query = "select * from gerecht";
            
            using(SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    return new Gerechten(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetFloat(2),
                        (Gerecht)reader.GetInt32(3),
                        reader.GetInt32(4)
                        );
                }
                else
                {
                    throw new Exception("Gerechten not found, reader is empty");
                }
            }
        }
        public int Voorraad(int gerechtId)
        {
            string query = "select voorraad from gerecht where id = '@id'";
            query = query.Replace("@id", gerechtId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();

                return (int)result;
            }
        }

        public void UpdateVoorraad(int gerechtId, int inStock)
        {
            string query = "update ";
        }
    }
}
