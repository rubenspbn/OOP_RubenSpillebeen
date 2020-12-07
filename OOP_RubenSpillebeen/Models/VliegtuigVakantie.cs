using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    class VliegtuigVakantie:Reis
    {
        //PROPERTIES
        private double VliegtuigTicket { get; set; }
        //CONSTRUCTORS
        public VliegtuigVakantie(double vliegtuigTicket, DateTime vertrekDatum, DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum)
        {
            VliegtuigTicket = vliegtuigTicket;
        }
        //METHODS
        public override double BerekenPrijs()
        {
            return base.BerekenPrijs()+VliegtuigTicket;
        }
    }
}
