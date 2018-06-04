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
        public List<Gerechten> GetGerechten()
        {
            string query = "select id, naam, prijs, catogorie from gerecht";
            
            using(SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
            }
        }
    }
}
