using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Chapoo.Model;


namespace Chapoo.Data
{
    public class GerechtenDAO
    {
        public List<Gerechten> GetLunch()
        {
            string query = "select * from gerecht where categorie < 4";

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    var menu = new List<Gerechten>();

                    while (reader.Read())
                    {
                        menu.Add(new Gerechten(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            (float)reader.GetDouble(2),
                            (Gerecht)reader.GetInt32(3),
                            reader.GetInt32(4)
                            ));
                    }

                    return menu;
                }
                else
                {
                    throw new Exception("No items in stock");
                }
            }
        }

        public List<Gerechten> GetDiner()
        {
            string query = "select * from gerecht where categorie >= 10";

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    var menu = new List<Gerechten>();

                    while (reader.Read())
                    {
                        menu.Add(new Gerechten(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            (float)reader.GetDouble(2),
                            (Gerecht)reader.GetInt32(3),
                            reader.GetInt32(4)
                            ));
                    }

                    return menu;
                }
                else
                {
                    throw new Exception("No items in stock");
                }
            }
        }

        public List<Gerechten> GetDrinks()
        {
            string query = "select * from gerecht where categorie > 3 and categorie < 10";

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    var menu = new List<Gerechten>();

                    while (reader.Read())
                    {
                        menu.Add(new Gerechten(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            (float)reader.GetDouble(2),
                            (Gerecht)reader.GetInt32(3),
                            reader.GetInt32(4)
                            ));
                    }

                    return menu;
                }
                else
                {
                    throw new Exception("No items in stock");
                }
            }
        }

        public List<Gerechten> BesteldeGerechten(int bestellingId)
        {
            var bestelling = new List<Gerechten>();

            string query = "select gerecht.id, naam, prijs, categorie, voorraad from gerecht inner join inhoudBestelling on gerecht.id = inhoudBestelling.idGerecht where idBestelling = @id";
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

        public int GetAmountPresent(int orderId, int gerechtId)
        {
            string query = "select count(id) from inhoudBestelling where idBestelling = @orderId and idGerecht = @gerechtId";
            query = query.Replace("@orderId", orderId.ToString());
            query = query.Replace("@gerechtId", gerechtId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public void RemoveFromOrder(int orderId, int gerechtId)
        {
            string query = "delete from inhoudBestelling where idBestelling = @orderId and idGerecht = @gerechtId";
            query = query.Replace("@orderId", orderId.ToString());
            query = query.Replace("@gerechtId", gerechtId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public void AddGerechtToOrder(int orderId, int gerechtId)
        {
            string query = "insert into inhoudBestelling (id, idBestelling, idGerecht) values (@id, @orderId, @productId)";
            query = query.Replace("@id", GetNewProductToOrderId().ToString());
            query = query.Replace("@orderId", orderId.ToString());
            query = query.Replace("@productId", gerechtId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
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
            string query = "update gerecht set voorraad = @inStock where id = @gerechtId";
            query = query.Replace("@inStock", inStock.ToString());
            query = query.Replace("@gerechtId", gerechtId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        int GetNewProductToOrderId()
        {
            string query = "select id from inhoudBestelling order by id desc";

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                try
                {
                    return (int)command.ExecuteScalar() + 1;
                }
                catch (Exception)
                {
                    return 1;
                }
            }
        }
    }
}
