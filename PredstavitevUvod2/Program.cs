using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredstavitevUvod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> stevilke = new List<int> { 1, 20, 30, 40, 5, 60, 7, 80, 9, 10 };

            // Preveri, če so številke večje, manjše, večje ali enake, manjše ali enake od 20
            List<int> vecjeOdDvajset = NajdiVecjeOd(stevilke, 20);
            List<int> manjseOdDvajset = NajdiManjseOd(stevilke, 20);
            List<int> vecjeAliEnakoDvajset = NajdiVecjeAliEnakoOd(stevilke, 20);
            List<int> manjseAliEnakoDvajset = NajdiManjseAliEnakoOd(stevilke, 20);

            // Izpis rezultatov
            Console.WriteLine("Številke večje od 20:");
            foreach (int num in vecjeOdDvajset)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Številke manjše od 20:");
            foreach (int num in manjseOdDvajset)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Številke večje ali enake 20:");
            foreach (int num in vecjeAliEnakoDvajset)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Številke manjše ali enake 20:");
            foreach (int num in manjseAliEnakoDvajset)
            {
                Console.WriteLine(num);
            }

        }

        // Metoda za iskanje številk, ki so večje od določene vrednosti
        public static List<int> NajdiVecjeOd(List<int> stevilke, int threshold)
        {
            List<int> rezultat = new List<int>();
            foreach (int stevilka in stevilke)
            {
                if (stevilka > threshold)
                {
                    rezultat.Add(stevilka);
                }
            }
            return rezultat;
        }

        // Metoda za iskanje številk, ki so manjše od določene vrednosti
        public static List<int> NajdiManjseOd(List<int> stevilke, int prag)
        {
            List<int> rezultat = new List<int>();
            foreach (int stevilka in stevilke)
            {
                if (stevilka < prag)
                {
                    rezultat.Add(stevilka);
                }
            }
            return rezultat;
        }

        // Metoda za iskanje številk, ki so večje ali enake določeni vrednosti
        public static List<int> NajdiVecjeAliEnakoOd(List<int> stevilke, int prag)
        {
            List<int> rezultat = new List<int>();
            foreach (int stevilka in stevilke)
            {
                if (stevilka >= prag)
                {
                    rezultat.Add(stevilka);
                }
            }
            return rezultat;
        }

        // Metoda za iskanje številk, ki so manjše ali enake določeni vrednosti
        public static List<int> NajdiManjseAliEnakoOd(List<int> stevilke, int prag)
        {
            List<int> rezultat = new List<int>();
            foreach (int stevilka in stevilke)
            {
                if (stevilka <= prag)
                {
                    rezultat.Add(stevilka);
                }
            }
            return rezultat;
        }
    }
}
