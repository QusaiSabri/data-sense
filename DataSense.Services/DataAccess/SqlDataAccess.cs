using DataSense.Core.Interfaces;
using DataSense.Core.Models;

namespace DataSense.Services.DataAccess
{
    public class SqlDataAccess : IDatabase
    {
        public List<Database> GetDatabases()
        {
            // Implement logic to retrieve databases from SQL.

            var dbs = new List<Database>();
            dbs.Add(new Database() { Name = "SalesDb" });
            dbs.Add(new Database() { Name = "OrdersDb" });

            return dbs;
        }

    }

}
