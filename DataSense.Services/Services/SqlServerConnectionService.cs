using DataSense.Core.Interfaces;
using DataSense.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Services.Services
{
    public class SqlServerConnectionService : IDatabaseConnectionService
    {       
        public async Task<bool> Connect(DatabaseConfiguration config)
        {
            try
            {
                string connectionString = $"Server={config.ServerName};Database={config.DatabaseName};User Id={config.UserId};Password={config.Password};";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    return true;
                }
            }
            catch (SqlException ex)
            {
                return false;
            }
        }
    }
}
