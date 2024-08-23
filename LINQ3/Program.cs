using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ3
{
    internal class Program
    {
        internal class Oseba
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public static List<Oseba> UrediPoPriimku(List<Oseba> seznamOseb)
        {
            seznamOseb.Sort(PrimerjajPoPriimku);
            return seznamOseb;
        }

        public static int PrimerjajPoPriimku(Oseba x, Oseba y)
        {
            return x.LastName.CompareTo(y.LastName);
        }

        static void Main(string[] args)
        {
            // Inicializacija seznama oseb
            List<Oseba> osebe = new List<Oseba> {
            new Oseba { FirstName = "John", LastName = "Doe" },
            new Oseba { FirstName = "Jane", LastName = "Smith" },
            new Oseba { FirstName = "Alice", LastName = "Johnson" }
        };

            // Uporaba LINQ z izrazom lambda:
            List<Oseba> urejeneOsebeLINQ = osebe.OrderBy(p => p.LastName).ToList();
            urejeneOsebeLINQ.ForEach(p => Console.WriteLine(p.LastName));

            // Alternativno, brez uporabe lambda izrazov (skupaj z metodami izven main):
            List<Oseba> urejeneOsebe = UrediPoPriimku(new List<Oseba>(osebe)); // Ustvari kopijo, da originalni seznam ostane nespremenjen
            urejeneOsebe.ForEach(p => Console.WriteLine(p.LastName));
        }
    }

    // Predpostavka, da je razred Oseba definiran kot sledi:

}
