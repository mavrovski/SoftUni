using System;

namespace _03RestaurantDiscount
{
    public class _03RestaurantDiscount
    {
        public static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            string discountsPackage = Console.ReadLine();

            var price = 0.0;
            var discount = 0.0;
            var disconutPrice = 0.0;
            string typeHall = "";

            if (peopleCount >= 0 && peopleCount <= 50)
            {
                price = 2500;
                typeHall = "Small Hall";
                Console.WriteLine("We can offer you the {0}", typeHall);
            }
            else if (peopleCount > 50 && peopleCount <= 100)
            {
                price = 5000;
                typeHall = "Terrace";
                Console.WriteLine("We can offer you the {0}", typeHall);
            }
            else if (peopleCount > 100 && peopleCount <=120)
            {

                price = 7500;
                typeHall = "Great Hall";
                Console.WriteLine("We can offer you the {0}",typeHall);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
           

            switch (discountsPackage)
            {
                case "Normal":
                    disconutPrice = 500;
                    discount = 0.05;
                    price += disconutPrice - (price + disconutPrice) * discount;
                    Console.WriteLine("The price per person is {0:F2}$", price / peopleCount);
                    break;
                case "Gold":
                    disconutPrice = 750;
                    discount = 0.10;
                    price += disconutPrice - (price + disconutPrice) * discount;
                    Console.WriteLine("The price per person is {0:F2}$",price / peopleCount);
                    break;
                case "Platinum":
                    disconutPrice = 1000;
                    discount = 0.15;
                    price += disconutPrice - (price + disconutPrice) * discount;
                    Console.WriteLine("The price per person is {0:F2}$", price / peopleCount);
                    break;
                default:
                    break;
                  
            }

        }
    }
}
