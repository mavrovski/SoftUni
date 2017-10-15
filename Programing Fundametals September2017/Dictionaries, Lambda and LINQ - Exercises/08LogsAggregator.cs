using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var personData = new SortedDictionary<string, SortedDictionary<string, decimal>>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var ip = line[0];
                var name = line[1];
                var seconds = int.Parse(line[2]);
                if (!personData.ContainsKey(name))
                {
                    personData[name] = new SortedDictionary<string, decimal>();
                }
                if (!personData[name].ContainsKey(ip))
                {
                    personData[name][ip] = 0;
                }

                personData[name][ip] += seconds;

            }
            foreach (var person in personData)
            {
                var name = person.Key;
                var ipAdresses = string.Join(", ", person.Value.Keys);
                var seconds = person.Value.Values.Sum();
                Console.WriteLine($"{name}: {seconds} [{ipAdresses}]");
            }
        }
    }
}
