using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Core.Models
{
    public static class DatabaseType
    {
        public static List<string> SupportedTypes => new List<string> { "SQL Server", "MongoDB", "Excel", "MySQL" };
    }

}
