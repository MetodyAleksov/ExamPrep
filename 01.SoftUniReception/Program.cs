using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battles = 0;
            int wins = 0;
            string input = Console.ReadLine();
            while (input.ToLower() != "end of battle")
            {
                battles++;
                int distance = int.Parse(input);
                if (energy >= distance)
                {
                    energy -= distance;
                    wins++;
                    if (wins % 3 == 0)
                    {
                        energy += wins;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    break;
                }
                input = Console.ReadLine();
                if (input.ToLower() == "end of battle")
                {
                    Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
                }
            }
        }
    }
}
