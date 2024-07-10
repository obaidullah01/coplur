using Logger.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class CloudLogger : ILogger
    {
        public CloudLogger() {
            Console.WriteLine("Using Cloud Logger ");
        }
        public bool WriteLog(string message)
        {
            Console.WriteLine("Successfully uploaded : "+ message);
            return true;
        }
    }
}
