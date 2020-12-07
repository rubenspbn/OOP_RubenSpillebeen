using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_RubenSpillebeen.Models;

namespace OOP_RubenSpillebeen
{
    class Program
    {
        static void Main(string[] args)
        {
            Reis[] reizen = GenereerReizen();
            Persoon[] personen = GenereerPersonen();
            Reisbureau[] bureaus = GenereerBureaus();
            ReisReservatie[] reservaties = GenereerReservaties(reizen, personen, bureaus);
            foreach (ReisReservatie reservatie in reservaties)
            {
                Console.WriteLine("\n***********************************************************************");
                Console.WriteLine(
                $"De reis kost {reservatie.Reis.BerekenPrijs()}\n" +
                $"De reis duurt: {reservatie.Reis.AantalDagen} dagen\n" +
                $"Gereserveerd door: {reservatie.Persoon.Naam}\n" +
                $"Gereserveerd bij: {reservatie.Reisbureau.Naam}\n" +
                $"Gesitueerd te\n{reservatie.Reisbureau.Adres.Postcode} {reservatie.Reisbureau.Adres.Gemeente}\n" +
                $"{reservatie.Reisbureau.Adres.Straat} {reservatie.Reisbureau.Adres.HuisNr}");
            }
            foreach (var item in LoggerService.Logs)
            {
                Console.WriteLine("\n*****LOGS*****");
                Console.WriteLine("ID " + item.ID);
                Console.WriteLine(item.Boodschap);
            }
            Console.ReadLine();
        }

        private static ReisReservatie[] GenereerReservaties(Reis[] reizen, Persoon[] personen, Reisbureau[] bureaus)
        {
            ReisReservatie[] reservaties = new ReisReservatie[3];
            for (int i = 0; i < reservaties.Length; i++)
            {
                reservaties[i] = new ReisReservatie( personen[i], reizen[i], bureaus[i]);
            }
            return reservaties;
        }

        private static Reisbureau[] GenereerBureaus()
        {
            Reisbureau[] bureaus = new Reisbureau[3];
            bureaus[0] = new Reisbureau()
            {
                Adres = new Adres()
                {
                    Gemeente = "Merchtem",
                    Postcode = 1785,
                    HuisNr = "30",
                    Straat = "Ambachtslaan"
                },
                Naam = "Sunweb"
            };
            bureaus[1] = new Reisbureau()
            {
                Adres = new Adres()
                {
                    Gemeente = "Brussegeù",
                    Postcode = 1785,
                    HuisNr = "15",
                    Straat = "Bakkerstraat"
                },
                Naam = "Neckerman"
            };
            bureaus[2] = new Reisbureau()
            {
                Adres = new Adres()
                {
                    Gemeente = "Wolvertem",
                    Postcode = 1500,
                    HuisNr = "1",
                    Straat = "Beenhouwerlaan"
                },
                Naam = "Sunweb"
            };
            return bureaus;
        }

        private static Reis[] GenereerReizen()
        {
            Reis[] reizen = new Reis[3];
            reizen[0] = new Cruise(new DateTime(2021, 1, 1), new DateTime(2021, 1, 11))
            {
                AantalPersonen = 10,
                //VertrekDatum = new DateTime(2021,2,15),
                //TerugkeerDatum = new DateTime(2021, 4, 20),
                VIP = true
            };
            reizen[1] = new AutoVakantie(false, new DateTime(2021, 1, 1), new DateTime(2021, 4, 20))
            {
                AantalPersonen = 10,
                //VertrekDatum = new DateTime(2021, 1, 1),
                //TerugkeerDatum = new DateTime(2021, 4, 20)
            };
            reizen[2] = new VliegtuigVakantie(400, new DateTime(2021, 1, 1), new DateTime(2021, 4, 20))
            {
                AantalPersonen = 10,
                //VertrekDatum = new DateTime(2021, 1, 1),
                //TerugkeerDatum = new DateTime(2021, 4, 20)
            };
            return reizen;
        }

        private static Persoon[] GenereerPersonen()
        {
            Persoon[] personen = new Persoon[3];
            personen[0] = new Persoon("Kenan", "Kurda")
            {
                //Voornaam = "Kenan",
                //Familienaam = "Kurda",
                Adres = new Adres()
                {
                    Gemeente = "Gent",
                    Postcode = 9000,
                    HuisNr = "4",
                    Straat = "Koniging elizabethlaan"
                }
            };
            personen[1] = new Persoon("Ruben", "Spillebeen")
            {
                //Voornaam = "Ruben",
                //Familienaam = "Spillebeen",
                Adres = new Adres()
                {
                    Gemeente = "Brussegem",
                    Postcode = 1785,
                    HuisNr = "4",
                    Straat = "Muntweide"
                }
            };
            personen[2] = new Persoon("Dirk", "Jan")
            {
                //Voornaam = "Dirk",
                //Familienaam = "Jan",
                Adres = new Adres()
                {
                    Gemeente = "Dendermonde",
                    Postcode = 9200,
                    HuisNr = "15",
                    Straat = "Stationstraat"
                }
            };
            return personen;
        }
    }
}
