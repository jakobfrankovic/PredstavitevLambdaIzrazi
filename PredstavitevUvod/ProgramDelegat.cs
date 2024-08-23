using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredstavitevUvod
{
    internal class Program
    {
        public static int Vsota(int x, int y) { return x + y; }
        public static int Razlika(int x, int y) { return x - y; }

        static void Main2(string[] args)
        {
            int result = Vsota(2, 3);
            Console.WriteLine("Rezultat z dirketnim klicom vsote: " + result);

            result = Razlika(2, 3);
            Console.WriteLine("Rezultat z direktnim klicom razlike: " + result);



        }
    }

    internal class ProgramDelegat
    {
        public static int Vsota(int x, int y) {  return x + y; }
        public static int Razlika(int x, int y) { return x - y; }

        // definiramo delegat
        // V tem primeru mora metoda ustrezati naslednjemu podpisu
        // (dva int parametra in vrne int):
        delegate int Operacija(int x, int y); 

        static void Main(string[] args)
        {
            Operacija vsotaOperacija = Vsota;
            int result = vsotaOperacija(2, 3);
            Console.WriteLine("Rezultat vsote: " + result);

            Operacija razlikaOperacija = Razlika;
            result = razlikaOperacija(2, 3);
            Console.WriteLine("Rezultat razlike: " + result);



        }
    }
}
