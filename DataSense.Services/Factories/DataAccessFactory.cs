using DataSense.Core.Interfaces;
using DataSense.Services.DataAccess;

namespace DataSense.Services.Factories
{
    public static class DataAccessFactory
    {
        public static IDatabase GetDataAccess(string databaseType)
        {
            switch (databaseType)
            {
                case "SQL":
                    return new SqlDataAccess();
                //case "MongoDB":
                //    return new MongoDataAccess();
                default:
                    throw new ArgumentException("Invalid database type.");
            }
        }
    }

}
