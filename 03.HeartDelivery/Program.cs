using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] jump = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int previousJump = 0;
            while(jump[0] != "Love!")
            {
                int jumpAmount = int.Parse(jump[1]) + previousJump;
                while (true)
                {
                    if (jumpAmount < neighborhood.Count)
                    {
                        neighborhood[jumpAmount] -= 2;
                        if (neighborhood[jumpAmount] == 0)
                        {
                            Console.WriteLine($"Place {jumpAmount} has Valentine's day.");
                        }
                        else if (neighborhood[jumpAmount] < 0)
                        {
                            Console.WriteLine($"Place {jumpAmount} already had Valentine's day.");
                        }
                        previousJump = jumpAmount;
                        break;
                    }
                    else
                    {
                        jumpAmount -= neighborhood.Count;
                    }
                }
                jump = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine($"Cupid's last position was {previousJump}.");
            if (neighborhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                neighborhood.RemoveAll(x => x <= 0);
                Console.WriteLine($"Cupid has failed {neighborhood.Count} places.");
            }
        }
    }
}
