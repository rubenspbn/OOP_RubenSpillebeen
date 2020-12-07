using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_RubenSpillebeen.Models;

namespace OOP_RubenSpillebeen.Interfaces
{
    interface ILoggable
    {
        LogMessage LogMessage { get; }
    }
}
