using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArcheryTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int points = 0;
            while (command[0] != "Game over")
            {
                if (command[0] == "Shoot Left")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (startIndex < targets.Count && startIndex >= 0)
                    {
                        for (int i = 1; i <= length; i++)
                        {
                            if (i == length)
                            {
                                if (targets[startIndex] - 5 < 0)
                                {
                                    targets[startIndex] -= 5;
                                    points += targets[startIndex] + 5;
                                    targets[startIndex] = 0;
                                }
                                else if (targets[startIndex] - 5 > 0)
                                {
                                    targets[startIndex] -= 5;
                                    points += 5;
                                }
                            }
                            startIndex--;
                            if (startIndex < 0)
                            {
                                startIndex = targets.Count - 1;
                            }
                        }
                    }
                }
                else if (command[0] == "Shoot Right")
                {
                    int startIndex = int.Parse(command[1]);
                    int length = int.Parse(command[2]);
                    if (startIndex < targets.Count && startIndex >= 0)
                    {
                        for (int i = 1; i <= length; i++)
                        {
                            if (i == length)
                            {
                                if (targets[startIndex] - 5 < 0)
                                {
                                    targets[startIndex] -= 5;
                                    points += targets[startIndex] + 5;
                                    targets[startIndex] = 0;
                                }
                                else if (targets[startIndex] - 5 > 0)
                                {
                                    targets[startIndex] -= 5;
                                    points += 5;
                                }
                            }
                            startIndex++;
                            if (startIndex >= targets.Count)
                            {
                                startIndex = 0;
                            }
                        }
                    }
                }
                else if (command[0] == "Reverse")
                {
                    targets.Reverse();
                }
                command = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(" - ", targets));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
