using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "End")
            {
                if (command[0] == "Shoot")
                {
                    int index = int.Parse(command[1]);
                    int power = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command[0] == "Strike")
                {
                    int index = int.Parse(command[1]);
                    int radius = int.Parse(command[2]);
                    int startRange = index - radius;
                    if (startRange < 0)
                    {
                        startRange = 0;
                    }
                    int count = 1 + (radius * 2);
                    if ((startRange < 0 || startRange >= targets.Count) || (startRange + count >= targets.Count || startRange + count <= 0))
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                    else
                    {
                        targets.RemoveRange(startRange, count);
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
