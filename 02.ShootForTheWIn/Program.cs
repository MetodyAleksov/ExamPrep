using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShootForTheWIn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            int shottargets = 0;
            while (input != "End")
            {
                int index = int.Parse(input);
                if (index < numbers.Count)
                {
                    shottargets++;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] != -1 && i != index)
                        {
                            if (numbers[i] > numbers[index])
                            {
                                numbers[i] -= numbers[index];
                            }
                            else if (numbers[i] <= numbers[index])
                            {
                                numbers[i] += numbers[index];
                            }
                        }
                    }
                    numbers[index] = -1;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shottargets} -> {string.Join(" ", numbers)}");
        }
    }
}
