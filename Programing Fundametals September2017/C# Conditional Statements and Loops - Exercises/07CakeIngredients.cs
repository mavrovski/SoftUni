using System;

namespace _07CakeIngredients
{
    public class _07CakeIngredients
    {
        public static void Main(string[] args)
        {
            var ingredients = "";
            var counter = 0;

            do
            {
                ingredients = Console.ReadLine();
                if (ingredients != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredients);
                    counter++;

                }

            } while (ingredients != "Bake!");
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);

        }
    }
}
