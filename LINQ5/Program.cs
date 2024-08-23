using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Inicializacija seznama številk
            List<int> stevilke = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Uporaba LINQ z izrazom lambda:
            var urejeneSodeStevilkeLINQ = stevilke.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
            Console.WriteLine("Urejene sode številke (LINQ):");
            urejeneSodeStevilkeLINQ.ForEach(n => Console.WriteLine(n));

            // Alternativno, brez uporabe lambda izrazov:
            List<int> urejeneSodeStevilke = new List<int>();
            foreach (int stevilka in stevilke)
            {
                if (stevilka % 2 == 0)
                {
                    urejeneSodeStevilke.Add(stevilka);
                }
            }
            urejeneSodeStevilke.Sort();
            Console.WriteLine("Urejene sode številke (zanka):");
            urejeneSodeStevilke.ForEach(n => Console.WriteLine(n));
        }
    }
}
