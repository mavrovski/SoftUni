using System;

namespace _05BPM_Counter
{
    public class _05BPM_Counter
    {
        public static void Main(string[] args)
        {
            var bpm = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            var totalTime = (int)Math.Floor((numberOfBeats / bpm) * 60);
            var bars = Math.Round(numberOfBeats / 4d, 1);

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");

        }
    }
}
