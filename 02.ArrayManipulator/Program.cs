using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split()
                .ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "swap")
                {
                    int el1 = numbers[int.Parse(command[1])];
                    int el2 = numbers[int.Parse(command[2])];
                    numbers[int.Parse(command[2])] = el1;
                    numbers[int.Parse(command[1])] = el2;
                }
                else if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    numbers[index1] = numbers[index1] * numbers[index2];

                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                command = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
