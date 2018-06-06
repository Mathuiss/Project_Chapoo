using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Chapoo.Model;

namespace Chapoo.Data
{
    public class OrderDAO
    {
        public int NewOrder(int tableNr, int userId)
        {
            int newId = OrderId() + 1;

            string query = "insert into bestelling (id, gebruiker, tafel status) values (@id, @user, @table, 0)";
            query = query.Replace("@id", newId.ToString());
            query = query.Replace("@user", userId.ToString());
            query = query.Replace("@table", tableNr.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }

            return newId;
        }

        int OrderId()
        {
            string query = "select top(id) from bestelling";

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public Order GetOrder(int orderId)
        {
            string query = "select * from bestelling where id = @id";
            query = query.Replace("@id", orderId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return new Order(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            (BestelStatus)reader.GetInt32(3)
                            );
                    }

                    return new Order();
                }
                else
                {
                    throw new Exception("Order not found");
                }
            }
        }
    }
}
