using DataSense.Core.Interfaces;
using DataSense.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace DataSense.Services.Factories
{
    public static class ConnectionServiceFactory
    {
        public static IDatabaseConnectionService GetConnectionService(string selectedDatabaseType, IServiceProvider services)
        {
            switch (selectedDatabaseType)
            {
                case "SQL Server":
                    return services.GetRequiredService<SqlServerConnectionService>();
                // Add more cases for other types of databases
                default:
                    throw new ArgumentException($"Unsupported database type: {selectedDatabaseType}");
            }
        }
    }
}
