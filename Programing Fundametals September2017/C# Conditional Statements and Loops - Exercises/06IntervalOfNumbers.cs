using System;

namespace _06IntervalOfNumbers
{
    public class _06IntervalOfNumbers
    {
        public static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberMiddle = 0;

            if (numberOne > numberTwo)    
                                                   
            {
                numberMiddle = numberOne;   
                numberOne = numberTwo;
                numberTwo = numberMiddle;                      
            }

            for (int i = numberOne; i <= numberTwo; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
