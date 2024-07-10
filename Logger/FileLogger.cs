using Logger.Contract;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLogger : ILogger
    {
        public FileLogger() {
            Console.WriteLine("Using File Logger");
        }
        public bool WriteLog(string message)
        {
            try
            {
                File.WriteAllText("filelogger.txt" , message);
                Console.WriteLine("Log written Successfully");
            }
            catch(Exception ex) 
            { 
                Console.WriteLine("File not found : " + ex.Message );
                return false;
            }
            return true;
        }
    }
}
