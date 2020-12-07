using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    public static class LoggerService
    {
        //FIELDS
        private static LogMessage[] logs;
        //PROPERTIES
        public static LogMessage[] Logs
        {
            get
            {
                return logs;
            }
            private set
            { }
        }
        //CONSTRUCTORS
        static LoggerService()
        {
            logs = new LogMessage[0];
        }
        //METHODS
        public static void AddLogMessage(LogMessage logMessage)
        {
            Array.Resize(ref logs, logs.Length + 1);
            logs[logs.Length - 1] = logMessage;
        }
    }
}
