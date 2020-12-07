using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RubenSpillebeen.Models
{
    public class Persoon
    {
        //PROPERTIES
        public Adres Adres { get; set; }
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; private set; }
        //CONSTRUCTOR
        public Persoon(string voornaam, string familienaam)
        {
            Naam = $"{voornaam} {familienaam}";
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
    }
}
