using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            var words = Console.ReadLine()
            .ToLower()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .OrderBy(x => x)
            .Where(x => x.Length < 5)
            .ToList();

            Console.WriteLine(String.Join(", ",words));

        }
    }
}
