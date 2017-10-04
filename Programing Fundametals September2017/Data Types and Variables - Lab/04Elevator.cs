using System;

namespace _04.Elevator
{
    public class _04Elevator
    {
        public static void Main(string[] args)
    {
            int numberOfPeopele = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());


            int courses = (int)(Math.Ceiling((double)numberOfPeopele / capacity));
            

            Console.WriteLine(courses);
          
        }
}
}
