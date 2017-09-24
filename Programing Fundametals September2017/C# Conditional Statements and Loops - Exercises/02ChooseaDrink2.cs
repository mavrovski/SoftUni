using System;

namespace _02ChooseaDrink2._0
{
    public class _02ChooseaDrink2
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var price = 0.0;
            switch (profession)
            {
                case "Athlete":
                    price = 0.70 * volume;
                    Console.WriteLine($"The Athlete has to pay {price:F2}.");
                    break;
                case "Businessman":
                    price = 1 * volume;
                    Console.WriteLine($"The Businessman has to pay {price:F2}.");
                    break;
                case "Businesswoman":
                    price = 1 * volume;
                    Console.WriteLine($"The Businesswoman has to pay {price:F2}.");
                    break;
                case "SoftUni Student":
                    price = 1.70 * volume;
                    Console.WriteLine($"The SoftUni Student has to pay {price:F2}.");
                    break;
                default:
                    price = 1.20 * volume;
                    Console.WriteLine($"The {profession} has to pay {price:F2}.");
                    break;
            }


        }
    }
}
