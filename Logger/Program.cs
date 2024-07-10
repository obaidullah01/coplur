using Logger.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Program
    {
        public static ILogger getLog()
        {
            string Log = "File";

            if(Log == "File")
            {
                return new FileLogger();
            }
            else {
                return new CloudLogger();
            }
        }
        static void Main(string[] args)
        {
            ILogger log = getLog();

            LogManager logManager = new LogManager(log);

            logManager.WriteLog("Finally Creating Log after 999+ exceptions");

            Console.ReadLine();
        }
    }
}
