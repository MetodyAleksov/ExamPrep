using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gifts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "No" && command[1] != "Money")
            {
                if (command[0] == "OutOfStock")
                {
                    string item = command[1];
                    for (int i = 0; i < gifts.Count; i++)
                    {
                        if (gifts[i] == item)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command[0] == "Required")
                {
                    string gift = command[1];
                    int index = int.Parse(command[2]);
                    if (index >= 0 && index < gifts.Count)
                    {
                        gifts[index] = gift;
                    }
                }
                else if (command[0] == "JustInCase")
                {
                    gifts[gifts.Count - 1] = command[1];
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            gifts.RemoveAll(x => x == "None");
            Console.WriteLine(string.Join(" ", gifts));
        }
    }
}
