using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var results = new List<string>();
            foreach (var word in counts)
            {
                if (word.Value % 2 != 0)
                {
                    results.Add(word.Key);
                }
               
            }
            Console.Write(String.Join(", ", results));
        }
    }
}
