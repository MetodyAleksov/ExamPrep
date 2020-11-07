using System;

namespace _01.TheHuntingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int player = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            bool ranOut = true;
            int foodCounter = 0;
            int waterCounter = 0;
            for (int i = 0; i < days; i++)
            {
                double energyloss = double.Parse(Console.ReadLine());
                if (energy - energyloss < 0)
                {
                    ranOut = false;
                    Console.WriteLine($"You will run out of energy. You will be left with {food} food and {water} water.");
                }
                energy -= energyloss;
                if (waterCounter == 2)
                {
                    waterCounter = 0;
                    water -= (water * 0.30);
                    energy += (energy * 0.05);
                }
                if (foodCounter == 3)
                {
                    foodCounter = 0;
                    food -= (food / player);
                    energy += (energy * 0.1);
                }
            }
            if (ranOut == true)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy} energy!");
            }
        }
    }
}
