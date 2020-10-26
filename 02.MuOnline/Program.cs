using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Transactions;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeon = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Player currrentPlayer = new Player(100, 0);
            int roomCounter = 0;
            bool isDead = false;
            foreach (var item in dungeon)
            {
                string[] room = item
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                roomCounter++;
                if (room[0] == "potion")
                {
                    int healedAmount = int.Parse(room[1]);
                    if (currrentPlayer.Health + healedAmount > 100)
                    {
                        for (int i = 1; i < healedAmount; i++)
                        {
                            if (currrentPlayer.Health + i >= 100)
                            {
                                Console.WriteLine($"You healed for {i} hp.");
                                break;
                            }
                        }
                        currrentPlayer.Health = 100;
                    }
                    else
                    {
                        currrentPlayer.Health += healedAmount;
                        Console.WriteLine($"You healed for {healedAmount} hp.");
                    }
                    Console.WriteLine($"Current health: {currrentPlayer.Health} hp.");
                }
                else if (room[0] == "chest")
                {
                    int bitcount = int.Parse(room[1]);
                    currrentPlayer.BitCoin += bitcount;
                    Console.WriteLine($"You found {bitcount} bitcoins.");
                }
                else
                {
                    int damage = int.Parse(room[1]);
                    if (currrentPlayer.Health - damage <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {room[0]}.");
                        Console.WriteLine($"Best room: {roomCounter}");
                        isDead = true;
                    }
                    else
                    {
                        currrentPlayer.Health -= damage;
                        Console.WriteLine($"You slayed {room[0]}.");
                    }
                }
            }
            if (!isDead)
            {
                Console.WriteLine("You made it!");
                Console.WriteLine(currrentPlayer.ToString());
            }
        }
    }
    class Player
    {
        public Player(int health, int bitCoin)
        {
            Health = health;
            BitCoin = bitCoin;
        }

        public int Health { get; set; }
        public int BitCoin { get; set; }

        public override string ToString()
        {
            return $"Bitcoins: {BitCoin}\nHealth: {Health}";
        }
    }
}
