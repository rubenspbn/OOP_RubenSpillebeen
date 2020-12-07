using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    public class LogMessage
    {
        //PROPERTIES
        public int ID { get; set; }
        public string Boodschap { get; set; }
        //CONSTRUCTORS
        public LogMessage(string boodschap)
        {
            Boodschap = boodschap;
            ID = GenereerID();
        }
        //METHODS
        public int GenereerID()
        {
            return LoggerService.Logs.Length;
        }
    }
}
