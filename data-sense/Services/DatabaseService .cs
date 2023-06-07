using data_sense.Models;

namespace data_sense.Services
{
    public class DatabaseService
    {
        public async Task<List<DatabaseType>> GetDatabaseTypes()
        {

            var dbsTypes = new List<DatabaseType>();
            dbsTypes.Add(new DatabaseType() { Name = "SQL Server" });
            dbsTypes.Add(new DatabaseType() { Name = "MongoDB" });

            return dbsTypes;
        }
    }
}
