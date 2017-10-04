using System;

namespace _07MathPower
{
    public class _07MathPower
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            var result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
