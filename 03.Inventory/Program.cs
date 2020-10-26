using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> item = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "Craft!")
            {
                if (command[0] == "Collect")
                {
                    if (!item.Contains(command[1]))
                    {
                        item.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (item.Contains(command[1]))
                    {
                        item.Remove(command[1]);
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    string[] items = command[1].Split(":").ToArray();
                    if (item.Contains(items[0]))
                    {
                        int index = item.IndexOf(items[0]);
                        item.Insert(index + 1, items[1]);
                    }
                }
                else if (command[0] == "Renew")
                {
                    string renewItem = command[1];
                    item.Remove(renewItem);
                    item.Add(renewItem);
                }
                command = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(", ", item));
        }
    }
}
