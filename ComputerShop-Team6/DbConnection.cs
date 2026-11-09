using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop_Team6
{
    internal class DbConnection
    {
        //static field
        private static SqlConnection conn;
        //static method
        public static SqlConnection GetSqlConnection()
        {
            string machineName = Environment.MachineName;
            string ConnectionString;

            
            if (machineName.Equals("MSI", StringComparison.OrdinalIgnoreCase))
            {
                ConnectionString = "Server=MSI; Database=ComputerShopTeam6; User Id=sa; Password=123; TrustServerCertificate=True;";
            }
            else
            {
                
                ConnectionString = "Server=100.118.213.113,1433; Database=ComputerShopTeam6; User Id=sa; Password=123; TrustServerCertificate=True;";
            }

            conn = new SqlConnection(ConnectionString);
            return conn;
        }
    }
}
