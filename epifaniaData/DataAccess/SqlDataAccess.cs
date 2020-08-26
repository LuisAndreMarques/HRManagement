using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace epifaniaData.DataAccess
{
    
    public class SqlDataAccess 
    {
        
        public static IConfiguration Configurations { get; }
        public static string GetConnectionString(string connectionName = "epifaniaDB")
        {
            return Configurations.GetConnectionString(connectionName);
        }

        public static List<T> LoadData<T>(string sql)
        {
            using(IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}
