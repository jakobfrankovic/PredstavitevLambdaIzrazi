using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Seznam:
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Uporaba LINQ z izrazom lambda:
            //Func<int, bool> funkcijaZaLINQ = n => n % 2 == 0;
            List<int> evenNumbersLINQ = numbers.Where(n => n % 2 == 0).ToList();

            evenNumbersLINQ.ForEach(n => Console.WriteLine(n));

            // Alternativno, brez uporabe lambda izrazov:
            List<int> evenNumbersLoop = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbersLoop.Add(number);
                }
            }

            // Če želimo izpisati rezultate :
            evenNumbersLoop.ForEach(n => Console.WriteLine(n));
        }
    }
}
