using DataSense.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Core.Interfaces
{
    public interface IDatabaseConnectionService
    {
        Task<(bool isConnected, string message)> Connect(DatabaseConfiguration config);
    }
}
