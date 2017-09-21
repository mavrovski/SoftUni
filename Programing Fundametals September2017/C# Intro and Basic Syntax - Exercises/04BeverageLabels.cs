using System;

namespace _04BeverageLabels
{
    public class _04BeverageLabels
    {
        public static void Main(string[] args)
        {
            string product = Console.ReadLine();

            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double energyPerVolume = (volume / 100) * energyContent;
            double sugarPerVolume = (volume / 100) * sugar;


            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",volume,product,energyPerVolume,sugarPerVolume);

        }
    }
}
