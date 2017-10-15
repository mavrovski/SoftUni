using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = Console.ReadLine();
            var collector = new Dictionary<string, int>();
            while (resource != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (collector.ContainsKey(resource))
                {
                    collector[resource] += quantity;
                }
                else
                {
                    collector.Add(resource, quantity);
                }


                resource = Console.ReadLine();
                
            }
            foreach (var item in collector)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
