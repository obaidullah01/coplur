using Logger.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger { 
    public class LogManager
    {
        ILogger _iLogger = null;

        public LogManager(ILogger logger) {
        _iLogger = logger; 
        }

        public bool WriteLog(string message)
        {

            return _iLogger.WriteLog(message);
        }
    }
}
