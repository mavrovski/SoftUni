using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers =  int.Parse(Console.ReadLine());
            var arrayNumbers = new double[numbers];
      
            for (int i = 0; i < numbers; i++)
            {
                arrayNumbers[i] = double.Parse(Console.ReadLine());
            }
            var sum = arrayNumbers.Sum();
            var min = arrayNumbers.Min();
            var max = arrayNumbers.Max();
            var average = arrayNumbers.Average();
            Console.WriteLine($"Sum = {sum}{Environment.NewLine}Min = {min}{Environment.NewLine}Max = {max}{Environment.NewLine}Average = {average}");
        }
    }
}
