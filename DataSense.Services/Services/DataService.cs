using DataSense.Core.Interfaces;
using DataSense.Core.Models;

namespace DataSense.Services.Services
{
    public class DataService : IDataService
    {
        private IDatabase _dataAccess;

        public DataService(DatabaseConfiguration config)
        {
            // _dataAccess = DataAccessFactory.GetDataAccess(config.DatabaseType);
        }

        public List<Database> GetDatabases()
        {
            return _dataAccess.GetDatabases();
        }

        public List<string> GetSupportedDatabaseTypes()
        {
            return new List<string> { "SQL Server", "MongoDB", "Excel", "MySQL" };
        }

    }


}
