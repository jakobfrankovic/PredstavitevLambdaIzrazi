using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericniDelegat
{
    internal class Program
    {
        public delegate bool PrimerjajNiza(string s1, string s2);
        public delegate void IzpisSporocila(string sporocilo);
        static void Main(string[] args)
        {
            // Delegat, ki primerja dva niza
            PrimerjajNiza staEnaka = (s1, s2) => s1 == s2;
            Console.WriteLine(staEnaka("test", "test")); // Izpiše: True

            // Delegat za izpis sporočila
            IzpisSporocila pm = sporocilo => Console.WriteLine(sporocilo);
            pm("Pozdravljen, prilagojeni delegat!"); // Izpiše: Pozdravljen, prilagojeni delegat!
        }
    }
}
