using System;

namespace _08CaloriesCounter
{
    public class _08CaloriesCounter
    {
        public static void Main(string[] args)
        {
            int numberIngredients = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            var totalCaloriesAmount = 0;
            var typeIngredients = "";
            for (int i = 0; i < numberIngredients; i++)
            {
                typeIngredients = Console.ReadLine().ToLower();
                if (typeIngredients == "cheese")
                {
                    totalCaloriesAmount += cheese;
                }
                else if (typeIngredients == "salami")
                {
                    totalCaloriesAmount += salami;
                }
                else if (typeIngredients == "tomato sauce")
                {
                    totalCaloriesAmount += tomatoSauce;
                }
                else if (typeIngredients == "pepper")
                {
                    totalCaloriesAmount += pepper;
                }
            }
            Console.WriteLine("Total calories: {0}",totalCaloriesAmount);
        }
    }
}
