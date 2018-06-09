﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Chapoo.Model;


namespace Chapoo.Data
{
    public class GerechtenDAO
    {
        public List<Gerechten> BesteldeGerechten(int bestellingId)
        {
            var bestelling = new List<Gerechten>();

            string query = "select gerecht.id, naam, prijs, categorie," +
                " voorraad from inhoudBestelling inner join gerecht on" +
                " inhoudBestelling.idGerecht = gerecht.id where" +
                " idBestelling = @id";
            query = query.Replace("@id", bestellingId.ToString());

            using(SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        bestelling.Add(new Gerechten(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            (float)reader.GetDouble(2),
                            (Gerecht)reader.GetInt32(3),
                            reader.GetInt32(4)
                            ));
                    }
                }
                else
                {
                    throw new OrderEmptyException("No items found");
                }

                return bestelling;
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
            string query = "update tafel set voorraad = '@instock' where id = '@id'";
            query = query.Replace("@instock", inStock.ToString());
            query = query.Replace("@id", gerechtId.ToString());

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
