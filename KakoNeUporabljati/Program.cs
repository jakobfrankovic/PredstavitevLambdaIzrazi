using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KakoNeUporabljati
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ni dobro, da je kompleksna logika v lambda izrazu. Tako naj se ne bi uporabljalo. 
            List<int> data = new List<int> { 1, 2, 3, 4, 5 };
            data.ForEach(item => {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"{item} is even.");
                }
                else
                {
                    Console.WriteLine($"{item} is odd.");
                }
                // Simulating more complex logic
                try
                {
                    int result = 10 / item;
                    Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by zero occurred!");
                }
            });
        }
    }
}


