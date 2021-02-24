using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Second => 10s = 10 Segundos");
            Console.WriteLine("M = Minute => 1m = 1 minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How long do you want to count");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch complete...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
