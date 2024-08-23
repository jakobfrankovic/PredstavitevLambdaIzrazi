using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PredstavitevUvod3Lambda
{
    internal class Program
    {
        public delegate bool Comparison(int x, int threshold);
        public static List<int> FindbyDelegate(List<int> numbers, int threshold, Comparison primerjavaDelegat)
        {
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (primerjavaDelegat(number, threshold))
                {
                    result.Add(number);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 1, 20, 30, 40, 5, 60, 7, 80, 9, 10 };

            //Comparison greaterThan = (num, threshold) => num > threshold;
            //Comparison lessThan = (num, threshold) => num < threshold;
            //Comparison greaterThanOrEqual = (num, threshold) => num >= threshold;
            //Comparison lessThanOrEqual = (num, threshold) => num <= threshold;

            var greaterThanTwenty = FindbyDelegate(numbers, 20, (num, threshold) => {
                num += 1;
                return num > threshold;
            });
            var lessThanTwenty = FindbyDelegate(numbers, 20, (num, threshold) => num < threshold);
            var greaterThanOrEqualToTwenty = FindbyDelegate(numbers, 20, (num, threshold) => num >= threshold);
            var lessThanOrEqualToTwenty = FindbyDelegate(numbers, 20, (num, threshold) => num <= threshold);

            // Output the results
            Console.WriteLine("Numbers greater than 20:");
            foreach (var num in greaterThanTwenty)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Numbers less than 20:");
            foreach (var num in lessThanTwenty)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Numbers greater than or equal to 20:");
            foreach (var num in greaterThanOrEqualToTwenty)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Numbers less than or equal to 20:");
            foreach (var num in lessThanOrEqualToTwenty)
            {
                Console.WriteLine(num);
            }

        }


    }
}
