using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                       .Split(' ')
                       .Select(double.Parse)
                       .OrderByDescending(x => x)
                       .Take(3)
                       .ToList();
            Console.WriteLine(String.Join(" ",numbers));

        }
    }
}
