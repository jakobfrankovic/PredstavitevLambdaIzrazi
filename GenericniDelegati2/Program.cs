using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericniDelegati2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> staEnaka = (s1, s2) => s1 == s2;
            Console.WriteLine(staEnaka("test", "test")); // Izpiše: True

            Action<string> izpisSporocila = sporocilo => Console.WriteLine(sporocilo);
            izpisSporocila("Živjo!"); // Izpiše: Pozdravljen, Action delegat!

            Func<int, int> kvadrat = x => x * x;
            Console.WriteLine(kvadrat(5)); // Izpiše: 25

            Func<string, string, string> zdruzi = (a, b) => a + b;
            Console.WriteLine(zdruzi("Pozdravljen, ", "svet!")); // Izpiše: Pozdravljen, svet!

            Action pozdravi = () => Console.WriteLine("Živjo!");
            pozdravi(); // Izpiše: Pozdravljen!

            Action<string> logiraj = sporocilo => {
                Console.WriteLine("Vnos v dnevnik:");
                Console.WriteLine(sporocilo);
            };
            logiraj("To je testno sporočilo."); // Izpiše dnevniška sporočila

            List<Func<int>> funkcije = new List<Func<int>>();
            for (int i = 0; i < 3; i++)
            {
                int loopVar = i;
                funkcije.Add(() => loopVar * 2);
            }
            foreach (var funkcija in funkcije)
            {
                Console.WriteLine(funkcija()); // Izpiše: 0, 2, 4
            }
        }
    }
}
