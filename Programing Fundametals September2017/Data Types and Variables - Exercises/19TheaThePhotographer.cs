using System;

namespace _19TheaThePhotographer
{
    public class _19TheaThePhotographer
    {
        public static void Main(string[] args)
        {
            int picturesCounts = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long filtredPictures = (long)Math.Ceiling((double)picturesCounts * filterFactor/100);
            long totalTime = filtredPictures * uploadTime + (long)picturesCounts * filterTime;

         



            TimeSpan timeSpan = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                timeSpan.Days,
                timeSpan.Hours,
                timeSpan.Minutes,
                timeSpan.Seconds

                );

        }
    }
}
