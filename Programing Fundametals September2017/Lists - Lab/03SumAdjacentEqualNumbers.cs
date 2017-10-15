using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SumAdjacentEqualNumbers
{
    public class _03SumAdjacentEqualNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 1; i < numbers.Count-1; i++)
            {

                
                    if (numbers[i] == numbers[i+1])
                    {
                       
                        
                    }
                
                  

            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
