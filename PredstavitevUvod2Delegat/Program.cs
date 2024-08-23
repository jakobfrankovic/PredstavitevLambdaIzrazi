﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredstavitevUvod2Delegat
{
    internal class Program
    {
        public delegate bool Primerjava(int x, int prag);

        public static List<int> NajdiSPrimerjavoDelegatom(List<int> stevilke, int prag, Primerjava primerjavaDelegat)
        {
            List<int> rezultat = new List<int>();
            foreach (int stevilka in stevilke)
            {
                if (primerjavaDelegat(stevilka, prag))
                {
                    rezultat.Add(stevilka);
                }
            }
            return rezultat;
        }

        static bool VecjeOd(int x, int prag) { return x > prag; }
        static bool ManjseOd(int x, int prag) { return x < prag; }
        static bool ManjseAliEnako(int x, int prag) { return x <= prag; }
        static bool VecjeAliEnako(int x, int prag) { return x >= prag; }

        static void Main(string[] args)
        {
            Primerjava referencaVecjeOd = VecjeOd;
            Primerjava referencaManjseOd = ManjseOd;
            Primerjava referencaVecjeAliEnako = ManjseAliEnako;
            Primerjava referencaManjseAliEnako = VecjeAliEnako;

            List<int> stevilke = new List<int> { 1, 20, 30, 40, 5, 60, 7, 80, 9, 10 };

            List<int> vecjeOdDvajset = NajdiSPrimerjavoDelegatom(stevilke, 20, referencaVecjeOd);
            List<int> manjseOdDvajset = NajdiSPrimerjavoDelegatom(stevilke, 20, referencaManjseOd);
            List<int> vecjeAliEnakoDvajset = NajdiSPrimerjavoDelegatom(stevilke, 20, referencaVecjeAliEnako);
            List<int> manjseAliEnakoDvajset = NajdiSPrimerjavoDelegatom(stevilke, 20, referencaManjseAliEnako);

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
    }
}
