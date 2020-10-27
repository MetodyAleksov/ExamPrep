using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int totalAmountOfPeoplePerHour = n1 + n2 + n3;
            int hours = 0;
            int counter = 0;
            while (people > 0)
            {
                hours++;
                counter++;
                if (counter == 4)
                {
                    counter = 0;
                }
                else
                {
                    people -= totalAmountOfPeoplePerHour;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
