using System;

namespace _04Hotel
{
    public class _04Hotel
    {
        public static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var @double = 0.0;
            var suite = 0.0;
            var result = 0.0;
            var discount = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nightsCount;
                @double = 65 * nightsCount;
                suite = 75 * nightsCount;
                if (nightsCount > 7)
                {
                    discount = 0.05;
                    studioPrice = 50 * nightsCount - ((50 * nightsCount) * discount);
                   
                }
                if (month == "October" && nightsCount>7)
                {
                    discount = 0.05;
                    studioPrice = 50 * (nightsCount - 1);
                    studioPrice = studioPrice - (studioPrice * discount);
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60 * nightsCount;
                @double = 72 * nightsCount;
                suite = 82 * nightsCount;

                if (month == "September" && nightsCount > 7)
                {
                    studioPrice = 60 * (nightsCount - 1);
                }
                if (nightsCount>14)
                {
                    discount = 0.10;
                    @double = @double - (@double * discount);
                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightsCount;
                @double = 77 * nightsCount;
                suite = 89 * nightsCount;
                if (nightsCount > 14)
                {
                    discount = 0.15;
                    suite = suite - (suite * discount);
                }
            }
          
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {@double:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}
