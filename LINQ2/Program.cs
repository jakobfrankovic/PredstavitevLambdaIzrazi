using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "alice", "bob", "charlie" };

            // Uporaba LINQ z izrazom lambda:
            List<string> upperCaseNamesLINQ = names.Select(name => name.ToUpper()).ToList();

            upperCaseNamesLINQ.ForEach(name => Console.WriteLine(name));

            // Alternativno, brez uporabe lambda izrazov:
            List<string> upperCaseNamesLoop = new List<string>();
            foreach (string name in names)
            {
                upperCaseNamesLoop.Add(name.ToUpper());
            }

            // Izpis:
            // upperCaseNamesLoop.ForEach(name => Console.WriteLine(name));
        }
    }
}


