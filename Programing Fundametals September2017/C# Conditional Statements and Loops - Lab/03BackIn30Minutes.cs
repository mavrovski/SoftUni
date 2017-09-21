using System;

namespace _03BackIn30Minutes
{
    public class _03BackIn30Minutes
    {
        public static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            
            var minutesAfter30Minutes = minutes+30;
            var minutesAfterHour=0;
            if (minutesAfter30Minutes>60)
            {
                 minutesAfterHour = minutesAfter30Minutes - 60;
            }
            else
            {
                 minutesAfterHour = minutesAfter30Minutes;
            }
            

            if (minutesAfter30Minutes > 59)
            {
                hour++;
            }
            if (hour>23)
            {
                hour = 0;    
            }
            if (minutesAfterHour<10)
            {
                Console.WriteLine($"{hour}:{minutesAfterHour:D2}");
            }
            else
            {

                Console.WriteLine($"{hour}:{minutesAfterHour}");
            }
        }

    }
}
