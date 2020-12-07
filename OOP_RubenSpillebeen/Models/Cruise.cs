using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    class Cruise:Reis
    {
        //FIELDS
        private const double CRUISEPRIJSEXTRADAGKOST = 10;
        //PROPRERTIES
        public bool VIP { get; set; }
        //COSNTRUCTORS
        public Cruise(DateTime vertrekDatum, DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum)
        {

        }
        //METHODS
        public override double BerekenPrijs()
        {
            if (VIP)
            {
                return (base.BerekenPrijs() + AantalDagen * AantalPersonen * CRUISEPRIJSEXTRADAGKOST) * 1.5;
            }
            else
            {
                return base.BerekenPrijs() + AantalDagen * AantalPersonen * CRUISEPRIJSEXTRADAGKOST;
            }
        }
    }
}
