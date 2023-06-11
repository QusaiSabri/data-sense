using DataSense.Core.Interfaces;
using DataSense.Core.Models;
using Microsoft.Data.SqlClient;

namespace DataSense.Services.Services
{
    public class SqlServerConnectionService : IDatabaseConnectionService
    {
        public async Task<(bool isConnected, string message)> Connect(DatabaseConfiguration config)
        {
            try
            {
                string connectionString = $"Server={config.ServerName};Database={config.DatabaseName};Trusted_Connection=true;Trusted_Connection=true;TrustServerCertificate=true";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    return (isConnected: true, message: "");
                }
            }
            catch (SqlException ex)
            {
                return (isConnected: false, message: ex.Message);

            }
        }
    }
}
