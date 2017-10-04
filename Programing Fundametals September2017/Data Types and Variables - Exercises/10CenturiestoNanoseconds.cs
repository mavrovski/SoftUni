using System;
using System.Numerics;

namespace _10CenturiestoNanoseconds
{
    public class _10CenturiestoNanoseconds
    {
        public static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long miliseconds = seconds * 1000;
            long microseconds = miliseconds * 1000;
            BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);


            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
               centuries, years, days, hours, minutes, seconds, miliseconds, microseconds, nanoseconds);


        }
    }
}
