using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    class AutoVakantie : Reis
    {
        //FIELDS
        private const double EXTRAPRIJSHUURAUTO = 10;
        //PROPERTIES
        public bool EigenWagen { get; private set; }
        //CONSTRUCTORS
        public AutoVakantie(bool eigenWagen,DateTime vertrekDatum,DateTime terugkeerDatum) : base(vertrekDatum, terugkeerDatum)
        {
            EigenWagen = eigenWagen;
        }
        //METHODS
        public override double BerekenPrijs()
        {
            if (EigenWagen)
            {
                return base.BerekenPrijs();
            }
            else
            {
                return base.BerekenPrijs() + AantalDagen * EXTRAPRIJSHUURAUTO * (int)(AantalPersonen / 5);
            }
        }
    }
}
