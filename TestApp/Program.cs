using System;

namespace TestApp
{
    using System.Threading;

    using BerlinClock.Classes.Clock;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var clock = new Clock(DateTime.Now.ToString("T"));
            var clock2 = new Clock2(DateTime.Now.ToString("T"));
            while (true)
            {
                Console.Clear();
                Console.Write(clock.Display());
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(clock2.Display());
                Thread.Sleep(100);
                clock.SetTime(DateTime.Now.ToString("T"));
                clock2.SetTime(DateTime.Now.ToString("T"));
            }
        }
    }
}
