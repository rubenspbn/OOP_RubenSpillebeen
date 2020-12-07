using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    public abstract class Reis
    {
        //FIELDS
        private const double BASISDAGPRIJS = 40;
        //PROPERTIES
        public int AantalDagen { get; set; }
        public int AantalPersonen { get; set; }
        public DateTime VertrekDatum { get; private set; }
        public DateTime TerugkeerDatum { get; private set; }
        //CONSTRUCTORS
        public Reis(DateTime vertrekDatum, DateTime terugkeerDatum)
        {
            if (vertrekDatum.Date < DateTime.Today)
            {
                Console.WriteLine("De vertrekdatum moet in de toekomst zijn");
            }
            else
            {
                VertrekDatum = vertrekDatum;
            }

            if (terugkeerDatum.Date < DateTime.Today)
            {
                Console.WriteLine("De vertrekdatum moet voor de terugkeerdatum zijn");
            }
            else
            {
                TerugkeerDatum = terugkeerDatum;
            }
            if (vertrekDatum.Date > terugkeerDatum.Date)
            {
                Console.WriteLine("De vertrekdatum moet voor de terugkeerdatum zijn");
            }
            AantalDagen = (int)(terugkeerDatum - vertrekDatum).TotalDays;
        }
        //METHODS
        public virtual double BerekenPrijs()
        {
            return 40 * AantalDagen * AantalPersonen;
        }
    }
}
