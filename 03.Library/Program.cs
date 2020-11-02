using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;

namespace _03.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> library = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "Done")
            {
                if (command[0] == "Add Book")
                {
                    if (!library.Contains(command[1]))
                    {
                        library.Insert(0, command[1]);
                    }
                }
                else if (command[0] == "Take Book")
                {
                    if (library.Contains(command[1]))
                    {
                        library.Remove(command[1]);
                    }
                }
                else if (command[0] == "Swap Books")
                {
                    if (library.Contains(command[1]) && library.Contains(command[2]))
                    {
                        string book1 = command[1];
                        string book2 = command[2];
                        int indexOf1 = library.IndexOf(book1);
                        int indexof2 = library.IndexOf(book2);
                        library[indexOf1] = book2;
                        library[indexof2] = book1;
                    }    
                }
                else if (command[0] == "Insert Book")
                {
                    library.Add(command[1]);
                }
                else if (command[0] == "Check Book")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < library.Count)
                    {
                        Console.WriteLine(library[int.Parse(command[1])]);
                    }
                }
                command = Console.ReadLine()
                .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine(string.Join(", ", library));
        }
    }
}
