using System;

namespace _01.DisneyLandx
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            double moneyCollected = 0;
            int months = int.Parse(Console.ReadLine());
            bool PastFirstMonth = false;
            for (int i = 1; i <= months; i++)
            {
                if (PastFirstMonth == false)
                {
                    PastFirstMonth = true;
                }
                else if (i % 2 != 0)
                {
                    moneyCollected -= moneyCollected * 0.16;
                }
                if (i % 4 == 0)
                {
                    moneyCollected += moneyCollected * 0.25;
                }
                moneyCollected += budged * 0.25;
            }
            if (moneyCollected >= budged)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(moneyCollected - budged):f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(budged - moneyCollected):f2}lv. more.");
            }
        }
    }
}
