using System;

namespace _02MaxMethod
{
    public class _02MaxMethod
    {
        public static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            var result =  GetMax(GetMax(numberOne,numberTwo),numberThree);
            Console.WriteLine(result);
        }

        private static int GetMax(int a,int b)
        {
            if (a>b)
            {
                return a; 
            }
            else 
            {
                return b;
            }
        }
    }
}
