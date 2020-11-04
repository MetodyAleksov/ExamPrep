using System;
using System.Runtime.InteropServices;

namespace _01.EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggsPrice = flourPrice * 0.75;
            double milkPrice = (flourPrice * 1.25) / 4;
            double cozonacPrice = flourPrice + eggsPrice + milkPrice;
            int colouredEggs = 0;
            int cozonacs = 0;
            while (true)
            {
                if (budged - cozonacPrice <= 0)
                {
                    break;
                }
                colouredEggs += 3;
                cozonacs += 1;
                budged -= cozonacPrice;
                if (cozonacs % 3 == 0)
                {
                    colouredEggs -= (cozonacs - 2);
                }
            }
            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {colouredEggs} eggs and {budged:f2}BGN left.");
        }
    }
}
