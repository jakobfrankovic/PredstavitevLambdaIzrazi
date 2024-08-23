using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;


namespace Argumenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> addExclamation = ([DisallowNull] string message) => message + "!";
        }
    }
}
