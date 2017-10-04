using System;

namespace _16ComparingFloats
{
    public class _16ComparingFloats
    {
        public static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
           
            double eps = 0.000001;
            bool isTrue = (Math.Abs(numOne - numTwo) < eps);
            Console.WriteLine(isTrue);
           
        }
    }
}
