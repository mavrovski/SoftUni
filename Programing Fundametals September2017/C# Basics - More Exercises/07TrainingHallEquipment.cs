using System;

namespace _07TrainingHallEquipment
{
    public class _07TrainingHallEquipment
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numbersOfItems = int.Parse(Console.ReadLine());
            

            double subtotal = 0;
            

            for (int i = 0; i < numbersOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1)
                {
                    itemName += "s";
                }
                subtotal += itemPrice * itemCount;
               
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

            }

            
            if (subtotal>budget)
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Not enough. We need ${ subtotal - budget:F2} more.");
                
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Money left: ${budget-subtotal:F2}");
            }
        }
    }
}
