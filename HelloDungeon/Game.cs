using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //Initializes Game Stats
            string playerName = "Traveler";
            string enemy1 = "Lagoona";
            string enemy2 = "Frostbite";
            string enemy3 = "Gargon";
            int maxEnemies = 0;
            float health = 100;
            bool playerIsAlive = true;
            float damage = 1.1f;
            float strength = 1.0f;
            float defense = 0.0f; 
            int dungeonNumber = 0;
            playerIsAlive = health > 0;
            bool gameOver = health < 0;

            //Introduction to Player
            Console.WriteLine("Gillian Welcomes You");
            Console.WriteLine("What shall I call you " + playerName + "?");

            //Establish Player Name
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + lastName;
            Console.WriteLine("Oh, " + playerName + "? I believe that was on the board back in town.");

            //Introduction to the Game
            Console.WriteLine("Regardless, Welcome to the cave of Lusmila on the island of Juda.");
            Console.WriteLine("The reason you're here," + playerName + "is to excavate the legendary treasure of Juda.");
            Console.WriteLine("This treasure has been sought after by many adventurers before you.");

            
            


        }
    }
}
