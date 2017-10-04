using System;

namespace _01DayofWeek
{
    public class _01DayofWeek
    {
        public static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (day>=1&&day<=7)
            {
                Console.WriteLine(daysOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
        }
    }
}
