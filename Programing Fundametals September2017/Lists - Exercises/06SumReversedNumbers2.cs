﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumReversedNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                     .Split(' ')
                     .Select(int.Parse)
                     .ToList();
            
           
        }
    }
}
