using DataSense.Core.Interfaces;
using DataSense.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Services.Factories
{
    public static class ConnectionServiceFactory
    {
        public static IDatabaseConnectionService GetConnectionService(string selectedDatabaseType)
        {
            switch (selectedDatabaseType)
            {
                case "SQL Server":
                    return new SqlServerConnectionService();
                case "MongoDB":
                //    return new MongoDBConnectionService();
                //case "Excel":
                //    return new ExcelConnectionService();
                //case "MySQL":
                //    return new MySQLConnectionService();
                default:
                    throw new ArgumentException($"Unsupported database type: {selectedDatabaseType}");
            }
        }
    }
}
