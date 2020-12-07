using OOP_RubenSpillebeen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    public class ReisReservatie : ILoggable
    {
        //PROPERTIES
        public LogMessage LogMessage { get; private set; }
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }
        //CONSTRUCTORS
        public ReisReservatie(Persoon persoon, Reis reis, Reisbureau reisbureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
            LogMessage = new LogMessage($"gereserveerd door: {persoon.Naam} bij {reisbureau.Naam}")
            LoggerService.AddLogMessage(LogMessage);
        }
    }
}
