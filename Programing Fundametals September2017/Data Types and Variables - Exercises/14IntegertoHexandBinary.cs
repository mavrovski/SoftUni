using System;

namespace _14IntegertoHexandBinary
{
    public class _14IntegertoHexandBinary
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}\n{1}",Convert.ToString(input,16).ToUpper(),Convert.ToString(input, 2).ToUpper());

        }
    }
}
