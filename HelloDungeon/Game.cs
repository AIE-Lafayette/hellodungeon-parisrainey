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
            Console.WriteLine("you arrive on the island of Juda and find the city of Opasus.");
            Console.WriteLine("You find a board with job offers and see one mentioning a cave with treasure.");
            Console.WriteLine("You sign up for the job and receive a reply the next day.");
            Console.WriteLine("You wander up to a cave in the jungle.");
            Console.WriteLine("A woman near the entrance with a torch greets you.");
            Console.WriteLine("She introduces herself as Gillian and the writer of the job offer.");
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

            //Player First Choice
            string playerChoice = Console.ReadLine();

            if (playerChoice == "1") ;
            {
                Console.WriteLine();
            }
            


        }
    }
}
