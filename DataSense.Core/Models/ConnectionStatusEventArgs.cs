using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Core.Models
{
    public class ConnectionStatusEventArgs : EventArgs
    {
        public bool IsConnected { get; }
        public string Message { get; }


        public ConnectionStatusEventArgs(bool isConnected, string message)
        {
            Message = message;
        }
    }
}
