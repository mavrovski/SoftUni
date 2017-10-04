using System;

namespace _04PhotoGallery
{
    public class _04PhotoGallery
    {
        public static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            int dateDay = int.Parse(Console.ReadLine());
            int dateMonth = int.Parse(Console.ReadLine());
            int dateYear = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double bytes = double.Parse(Console.ReadLine());
            int resolutionWidth = int.Parse(Console.ReadLine());
            int resolutionHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:D4}.jpg",name);
            Console.WriteLine($"Date Taken: {dateDay:D2}/{dateMonth:D2}/{dateYear} {hours:D2}:{minutes:D2}");
            if (bytes > 0 && bytes < 1024)
            {
                Console.WriteLine("Size: {0}B", bytes);
            }
            else if (bytes > 1024 && bytes < 1024000)
            {
                Console.WriteLine("Size: {0}KB", bytes/1000);
            }
            else if (bytes > 1024*1000 && bytes < 1024000*1000)
            {
                Console.WriteLine("Size: {0}MB",Math.Round((bytes / (1000 * 1000)),1) );
            }
            if (resolutionWidth > resolutionHeight)
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (landscape)");
            }
            else if(resolutionWidth < resolutionHeight)
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (portrait)");
            }
            else if (resolutionWidth == resolutionHeight)
            {
                Console.WriteLine($"Resolution: {resolutionHeight}x{resolutionWidth} (square)");
            }
        }
    }
}
