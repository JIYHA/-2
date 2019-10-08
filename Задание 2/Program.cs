using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            int seconds = (int)now.TotalSeconds;
            int hours = seconds / 3600;
            int minutes = (seconds - (hours * 3600)) / 60;
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Min: " + minutes);
        }
    }
}
