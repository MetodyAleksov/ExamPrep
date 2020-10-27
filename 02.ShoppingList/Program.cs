using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "Go")
            { 
                if (command[0] == "Urgent")
                {
                    if (!shoppingList.Contains(command[1]))
                    {
                        shoppingList.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Unnecessary")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        shoppingList.Remove(command[1]);
                    }
                }
                else if (command[0] == "Correct")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        shoppingList[shoppingList.IndexOf(command[1])] = command[2];
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        shoppingList.Remove(command[1]);
                        shoppingList.Add(command[1]);
                    }
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
