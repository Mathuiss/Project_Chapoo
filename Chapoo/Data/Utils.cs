using System;
using System.Data.SqlClient;

namespace Chapoo.Data
{
    public static class Utils
    {
        public static SqlConnection GetConenction()
        {
            return new SqlConnection("Data Source=194.171.20.101;Initial Catalog=RBS_1718_DB03;Persist Security Info=True;User ID=RBS_1718_grp03;Password=L57nHs3uHn");
        }
    }
}
