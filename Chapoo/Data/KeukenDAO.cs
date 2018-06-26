using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapoo.Model;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    public class KeukenDAO
    {
        public List<BestellingOverzicht> GetBestellingen()
        {
            //query maken 
            
            string query = "SELECT b.id, g.naam, b.tafel, b.aantekening From bestelling as b,inhoudbestelling as inhoud, gerecht as g where b.id = inhoud.idBestelling and inhoud.idGerecht = g.id and status = 0 and (g.categorie = 0 or g.categorie = 1 or  g.categorie = 2 or g.categorie = 10 or  g.categorie = 13 or g.categorie = 11 or g.categorie = 12)";

            //verbinding maken en openen met database
            using (SqlConnection connection = Utils.GetConenction())
            {
                var bestelling = new List<BestellingOverzicht>();

                connection.Open();
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                //kijkenof er iets uit de database komt, zoniet zijn er geen bestellingen
                if (reader.HasRows)
                {

                    //zolang er nog regels (die voldoen) zijn worden die toegevoegd
                    while (reader.Read())
                    {
                        bestelling.Add(new BestellingOverzicht(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3)
                            ));
                    }
                    return bestelling;
                }
                else
                {
                    throw new Exception("Nog geen bestellingen gedaan");
                }
            }
        }

        public List<BestellingOverzicht> GetDrinken()
        {
            //query maken 
            string query = "SELECT b.id, g.naam, b.tafel, b.aantekening From bestelling as b,inhoudbestelling as inhoud, gerecht as g where b.id = inhoud.idBestelling and inhoud.idGerecht = g.id and status = 0 and (g.categorie = 4 or g.categorie = 5 or  g.categorie = 6 or g.categorie = 7 or  g.categorie = 8) ";

            //verbinding maken en openen met database
            using (SqlConnection connection = Utils.GetConenction())
            {
                var bestelling = new List<BestellingOverzicht>();

                connection.Open();
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                //kijkenof er iets uit de database komt, zoniet zijn er geen bestellingen
                if (reader.HasRows)
                {
                    //alle data overzetten naar bestellingsoverzicht
                    while (reader.Read())
                    {
                        bestelling.Add(new BestellingOverzicht(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3)
                            ));
                    }
                    return bestelling;
                }
                else
                {
                    throw new Exception("Nog geen bestellingen gedaan");
                }
            }
        }
    }    
}
