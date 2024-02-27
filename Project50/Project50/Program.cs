using System;

namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dungeon Adventure!");
            Console.WriteLine("You are in a dark room. Try to find your way out.");

            int playerX = 0; // Player's current X-coordinate
            int playerY = 0; // Player's current Y-coordinate

            Random random = new Random();

            while (true)
            {
                Console.Write("Enter a direction (north/south/east/west): ");
                string direction = Console.ReadLine().ToLower();

                int chance = random.Next(1, 11); // Random number between 1 and 10 for event probability

                ProcessDirection(direction, ref playerX, ref playerY);

                ProcessEvent(chance, ref playerX, ref playerY);

                // Check if player is close to the end of the dungeon
                if (playerX >= 1 && playerY >= 1)
                {
                    Console.WriteLine("Congratulations! You've reached the end of the dungeon.");
                    break;
                }
            }

            Console.WriteLine("Thank you for playing!");
        }

        static void ProcessDirection(string direction, ref int playerX, ref int playerY)
        {
            switch (direction)
            {
                case "north":
                    playerY++;
                    break;
                case "south":
                    playerY--;
                    break;
                case "east":
                    playerX++;
                    break;
                case "west":
                    playerX--;
                    break;
                default:
                    Console.WriteLine("Invalid direction. Try again.");
                    break;
            }
        }

        static void ProcessEvent(int chance, ref int playerX, ref int playerY)
        {
            if (chance <= 3) // 30% chance of an event
            {
                Console.WriteLine("You found a treasure!");
            }
            else if (chance <= 6) // 30% chance of a monster encounter
            {
                Console.WriteLine("A monster appears!");

                Console.Write("Do you want to fight or flee? ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "fight")
                {
                    Console.WriteLine("You defeat the monster!");
                }
                else if (choice == "flee")
                {
                    Console.WriteLine("You flee from the monster and return to the starting room.");
                    playerX = 0;
                    playerY = 0;
                }
            }
        }
    }
}
