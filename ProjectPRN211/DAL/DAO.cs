using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.DAL
{
    internal class DAO
    {
        public static SqlConnection GetConnection()
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration["ConnectionStrings:ProjectDB"];
            return new SqlConnection(connectionString);
        }

        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters != null || parameters.Length == 0) command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static bool ChangeData(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = DAO.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, connection);
                if (parameters != null || parameters.Length == 0) 
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0; 
            }
        }
    }
}
