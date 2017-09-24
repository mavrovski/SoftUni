using System;

namespace _01ChooseADrink
{
    public class _01ChooseADrink
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();
            switch (profession)
            {
                case "athlete":
                    Console.WriteLine("Water");
                    break;
                case "businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "softuni student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }

        }
    }
}
