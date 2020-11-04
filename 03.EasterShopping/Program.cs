using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _03.EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Include")
                {
                    shops.Add(command[1]);
                }
                else if (command[0] == "Visit")
                {
                    if (command[1] == "first")
                    {
                        int index = int.Parse(command[2]);
                        if(0 + index < shops.Count)
                        {
                            shops.RemoveRange(0, index);
                        }
                    }
                    else
                    {
                        int index = shops.Count - int.Parse(command[2]);
                        if (index >= 0 && index < shops.Count)
                        {
                            shops.RemoveRange(index, int.Parse(command[2]));
                        }
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    if ((index1 >= 0 && index1 < shops.Count) && (index2 >= 0 && index2 < shops.Count))
                    {
                        string item1 = shops[index1];
                        string item2 = shops[index2];
                        shops[index1] = item2;
                        shops[index2] = item1;
                    }
                }
                else if (command[0] == "Place")
                {
                    int index = int.Parse(command[2]);
                    if (index >= 0 && index < shops.Count)
                    {
                        shops.Insert(index + 1, command[1]);
                    }
                }
            }
            Console.WriteLine($"Shops left:\n{string.Join(" ", shops)}");
        }
    }
}
