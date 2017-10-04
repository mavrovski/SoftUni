using System;

namespace _07ExchangeVariableValues
{
    public class _07ExchangeVariableValues
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int exchange = 0;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}", b);

           
            exchange = a;
            a = b;
            b = exchange;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
