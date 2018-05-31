using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    class InhoudBestellingDAO
    {
        public bool Tafelbezet(int tafelnummer)
        {
            string tafelId = tafelnummer.ToString();

            string query = "Select status from bestelling where id = '@tafelId'";
            query = query.Replace("@tafelId", tafelId);

            using (SqlConnection connection = Utils.GetConenction())
            {
                connection.Open();
                var command = new SqlCommand(query, connection);

                try
                {
                    return (bool)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }            
    }
}
