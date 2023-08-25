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
            float sword1Damage = 8.0f;
            float bow1Damage = 7.0f;
            float mace1Damage = 9.0f;

            //Introduction to Player
            Console.WriteLine("You arrive on the island of Juda and find the city of Opasus.");
            Console.WriteLine("You find a board with job offers and see one mentioning a cave with treasure.");
            Console.WriteLine("You sign up for the job and receive a reply the next day.");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("You wander up to a cave in the jungle.");
            Console.WriteLine("A woman near the entrance with a torch greets you.");
            Console.WriteLine("She introduces herself as Gillian and the writer of the job offer.");
            Console.WriteLine("'What shall I call you " + playerName + "?'");
            Console.Write("-> ");

            //Establish Player Name
            string firstName = Console.ReadLine();
            playerName = firstName;
            Console.Clear();
            Console.WriteLine("'Oh, " + playerName + "? I believe that was on the board back in town.'");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();

            //Introduction to the Game
            Console.WriteLine("'Regardless, Welcome to the cave of Lusmila on the island of Juda.'");
            Console.WriteLine("'The reason you're here, " + playerName + " is to excavate the legendary treasure of Juda.'");
            Console.WriteLine("'This treasure has been sought after by many adventurers before you.'");
            Console.WriteLine("'Don't worry though, most of these adventurers did not survive, so the treasure will be yours.'");
            Console.WriteLine("'Knowing this information, would you like to continue?'");

            //Player First Choice
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("-> ");
            string playerChoice = Console.ReadLine();
            Console.Clear();

            if (playerChoice == "1" || playerChoice == "Yes")
            {
                Console.WriteLine("'Great! let's move on through the cave entrance.'");
            }
            else if (playerChoice == "2" || playerChoice == "No")
            {
                Console.WriteLine("Gillian looks slightly upset with your decision but understands.");
                Console.WriteLine("You head back down to Opasus and enjoy the rest of your trip, questioning whether you made the right decision.");

            }
            else
            {
                Console.WriteLine("Gillian looks at you confused, not understanding what you mean.");
            }
            
            //Player Health Status
            if (health == 100)
            {
                Console.WriteLine("Healthy");
            }
            else if (health >= 75)
            {
                Console.WriteLine("Slightly Damaged");
            }
            else if (health >= 50)
            {
                Console.WriteLine("Moderate Damage");
            }
            else if (health < 50)
            {
                Console.WriteLine("Heavy Damage");
            }

            //Weapon Selection Story
            Console.WriteLine("You and Gillian walk into the dark, wet cave");
            Console.WriteLine("You reach a giant silver door");
            Console.WriteLine("Gillian goes to unlock the door then pauses");
            Console.WriteLine("'I almost forgot, you will be needing a weapon for the enemies in this dungeon.'");
            Console.WriteLine("'These are the only two weapons I can spare, please choose wisely.'");

            //Second Player Choice: Weapon
            Console.WriteLine("1. Rusty Sword");
            Console.WriteLine("2. Rusty Mace");
            Console.WriteLine("3. Rusty Bow");
            Console.Write("-> ");
            playerChoice = Console.ReadLine();

            if (playerChoice == "1" || playerChoice == "Rusty Sword")
            {
                Console.WriteLine("You pick up the rusty sword, it feels light in your hand");
                damage = sword1Damage;
                Console.WriteLine("Your damage increases to " + damage);
            }
            else if (playerChoice == "2" || playerChoice == "Rusty Mace")
            {
                Console.WriteLine("You pick up the rusty mace, it is fairly heavy");
                damage = mace1Damage;
                Console.WriteLine("Your damage increases to " + damage);
            }
            else if (playerChoice == "3" || playerChoice == "Rusty Bow")
            {
                Console.WriteLine("You pick up the rusty bow, it is really light");
                damage = bow1Damage;
                Console.WriteLine("Your damage increases to " + damage);
            }







        }
    }
}
