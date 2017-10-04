using System;

namespace _05TemperatConversion
{
    public class _05TemperatConversion
    {
        public static void Main(string[] args)
        {
            double temp = double.Parse((Console.ReadLine()));
            var celsius = FahrenheittoCelsius(temp);
            Console.WriteLine("{0:F2}",celsius);

        }

        private static double FahrenheittoCelsius(double farenheit)
        {
            double toCelsius = (farenheit - 32) * 5 / 9;
            return toCelsius;
        }
    }
}
