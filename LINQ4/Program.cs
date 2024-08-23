using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ4
{
    internal class Program
    {
        internal class Zival
        {
            public string Ime { get; set; }
            public string Vrsta { get; set; }
        }

        static void Main(string[] args)
        {
            // Inicializacija
            List<Zival> zivali = new List<Zival> {
            new Zival { Ime = "Buddy", Vrsta = "Pes" },
            new Zival { Ime = "Charlie", Vrsta = "Mačka" },
            new Zival { Ime = "Fishy", Vrsta = "Riba" },
            new Zival { Ime = "Doggo", Vrsta = "Pes" }
        };

            // Lambda z LINQ:
            Dictionary<string, List<Zival>> zdruzenoPoVrstiLINQ = zivali.GroupBy(zival => zival.Vrsta)
                                                                       .ToDictionary(g => g.Key, g => g.ToList());

            // Rezultati:
            foreach (KeyValuePair<string, List<Zival>> skupina in zdruzenoPoVrstiLINQ)
            {
                Console.WriteLine("Vrsta: " + skupina.Key);
                foreach (Zival zival in skupina.Value)
                {
                    Console.WriteLine(" - " + zival.Ime);
                }
            }

            // Brez lambda izraza:
            Dictionary<string, List<Zival>> zdruzenoPoVrsti = new Dictionary<string, List<Zival>>();
            foreach (Zival zival in zivali)
            {
                if (!zdruzenoPoVrsti.ContainsKey(zival.Vrsta))
                {
                    zdruzenoPoVrsti[zival.Vrsta] = new List<Zival>();
                }
                zdruzenoPoVrsti[zival.Vrsta].Add(zival);
            }

            // Rezultati:
            foreach (KeyValuePair<string, List<Zival>> skupina in zdruzenoPoVrsti)
            {
                Console.WriteLine("Vrsta: " + skupina.Key);
                foreach (Zival zival in skupina.Value)
                {
                    Console.WriteLine(" - " + zival.Ime);
                }
            }
        }
    }



}