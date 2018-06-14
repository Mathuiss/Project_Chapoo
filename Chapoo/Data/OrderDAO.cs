using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Chapoo.Model;

namespace Chapoo.Data
{
    public class OrderDAO
    {
        public void CompleteOrder(int tableId)
        {
            string query = "update bestelling set status = 1 where id = @id";
            query = query.Replace("@id", GetOrderByTableIdOpen(tableId).ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public int NewOrder(int tableNr, int userId)
        {
            int newId = OrderId() + 1;

            string query = "insert into bestelling (id, gebruiker, tafel, status) values (@id, @user, @table, 0)";
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
        
        public int GetOrderByTableId(int tableId)
        {
            string query = " select id from bestelling where tafel = @tableId order by id desc";
            query = query.Replace("@tableId", tableId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }

        }

        public int GetOrderByTableIdOpen(int tableId)
        {
            string query = "select id from bestelling where tafel = @tableId and dbo.bestelling.status = 0 order by id desc";
            query = query.Replace("@tableId", tableId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }

        public int GetOrderByTableIdFinished(int tableId)
        {
            string query = "select id from bestelling where tafel = @tableId and dbo.bestelling.status = 1 order by id desc";
            query = query.Replace("@tableId", tableId.ToString());

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

        public string GetNotes(int orderId)
        {
            string query = "select aantekening from bestelling where id = @orderId";
            query = query.Replace("@orderId", orderId.ToString());

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var commamd = new SqlCommand(query, connection);

                try
                {
                    return (string)commamd.ExecuteScalar();
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }

        public void SetNotes(int orderId, string note)
        {
            string query = "update bestelling set aantekening = '@note' where id = @orderId";
            query = query.Replace("@note", note);
            query = query.Replace("@orderId", orderId.ToString());
            
            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var commamd = new SqlCommand(query, connection);
                commamd.ExecuteNonQuery();
            }
        }

        int OrderId()
        {
            string query = "select id from bestelling order by id desc";

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();

                var command = new SqlCommand(query, connection);
                return (int)command.ExecuteScalar();
            }
        }
    }
}
