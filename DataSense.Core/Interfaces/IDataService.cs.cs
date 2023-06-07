using DataSense.Core.Models;

namespace DataSense.Core.Interfaces
{
    public interface IDataService
    {
        List<Database> GetDatabases();
        List<string> GetSupportedDatabaseTypes();

    }

}
