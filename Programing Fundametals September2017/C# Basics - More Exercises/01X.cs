using System;

namespace _01X
{
    public class _01X
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            int middleSpace = input - 2;
            int leftRightSpace = 0;


            //first part
            for (int i = 0; i < input / 2; i++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ', middleSpace), new string(' ', leftRightSpace));

                middleSpace -= 2;
                leftRightSpace++;
            }


            //mmidd;e
            Console.WriteLine(new string(' ', input / 2) + 'x' + new string(' ', input / 2));
            middleSpace += 2;
            leftRightSpace--;

            //second part
            for (int i = 0; i < input / 2; i++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ', middleSpace), new string(' ', leftRightSpace));
                middleSpace += 2;
                leftRightSpace--;
            }


        }
    }
}
