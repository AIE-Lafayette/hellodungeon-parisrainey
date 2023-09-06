using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {

        //Initializes Game Stats
        string playerName = "Traveler";
        string enemy1 = "Lagoona";
        string enemy2 = "Frostbite";
        string enemy3 = "Gargon";
        string enemy4 = "Large Spider";
        int maxEnemies = 6;
        float enemyHealth = 100.0f;
        float playerHealth = 100.0f;
        bool playerIsAlive = true;
        bool enemyIsAlive = true;
        float damage = 1.1f;
        float strength = 1.0f;
        float defense = 0.0f;
        int dungeonNumber = 0;
        bool gameOver = false;
        float sword1Damage = 8.0f;
        float bow1Damage = 7.0f;
        float mace1Damage = 9.0f;
        float enemyAttack;
        string playerChoice;

        string DisplayMenu(string prompt, string option1 , string option2, string option3)
        {
            string playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                Console.Clear();
                Console.WriteLine(prompt);

                Console.WriteLine("1. " + option1);

                Console.WriteLine("2. " + option2);

                if (option3 != "")
                {
                    Console.WriteLine("3. " + option3);
                }

                Console.Write("-> ");
                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2")
                {
                    if (playerChoice == "3" && option3 != "")
                    {
                        continue;
                    }

                    //error message
                    Console.Clear();
                    Console.WriteLine("Did you type that right?");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);

                    playerChoice = "";
                }

            }
            return playerChoice;
        }
        void WeaponSelect()
        {
            //Weapon Selection Story
            Console.WriteLine("You and Gillian walk into the dark, wet cave");
            Console.WriteLine("You reach a giant silver door");
            Console.WriteLine("Gillian goes to unlock the door then pauses");
            Console.WriteLine("'I almost forgot, you will be needing a weapon for the enemies in this dungeon.'");

            //Second Player Choice: Weapon
            playerChoice = DisplayMenu("Please choose a weapon", "Rusty Sword", "Rusty Mace", "Stiff bow");
            if (playerChoice == "1")
            {
                Console.WriteLine("The sword feels lighter than expected, you also have rust on your hands");
                damage = sword1Damage;
                Console.WriteLine("your damage increases to " + damage);
            }
            else if (playerChoice == "2")
            {
                Console.WriteLine("The Mace feels fairly heavy, the rust rubs off on your hand. ");
                damage = mace1Damage;
                Console.WriteLine("Your damage increases to " + damage);
                
            }
            else if (playerChoice == "3")
            {
                Console.WriteLine("You pull the bow string and find it to be stiff. This will be difficult to shoot with.");
                damage = bow1Damage;
                Console.WriteLine("Your damage increases to " + damage);
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }
        float StartBattle(float playerHealth, float enemyhealth)
        {
            
            return 0;
        }
        

        void DisplayScene0()
        {
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

            //Establish Player Name
            while (playerChoice != "1")
            {
                Console.Clear();
                playerChoice = "";
                Console.WriteLine("'What is your name?'");
                playerName = Console.ReadLine();
                Console.WriteLine(playerName + ", Is that correct?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                playerChoice = Console.ReadLine();
                if (playerChoice == "2")
                {
                    Console.WriteLine("'Oh, my apologies'");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }
                else if (playerChoice == "1")
                {
                    Console.WriteLine("'Great!'");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                    Console.Clear();
                }

            }

            //Introduction to the Game
            Console.WriteLine("'Welcome to the cave of Lusmila on the island of Juda.'");
            Console.WriteLine("'The reason you're here, " + playerName + ", is to excavate the legendary treasure of Juda.'");
            Console.WriteLine("'This treasure has been sought after by many adventurers before you.'");
            Console.WriteLine("'Don't worry though, most of these adventurers did not survive, so the treasure will be yours.'");
            Console.WriteLine("'Knowing this information, would you like to continue?'");

            //First Player Choice to Continue
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("-> ");
            playerChoice = Console.ReadLine();
            Console.Clear();

            while (playerChoice != "1")
            {
                if (playerChoice == "1")
                {
                    Console.WriteLine("'Great!'");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Gillian looks disappointed but bids you farewell.");
                    Console.WriteLine("You go back to Opasus questioning whether you made the right decision.");
                    Console.WriteLine("Press any key");
                    Console.ReadKey(true);
                    return;
                }
            }

        }
        void DisplayScene1()
        {
            //Tutorial Battle Story
            Console.WriteLine("Gillian unlocks the Large Silver door and pushes it open.");
            Console.WriteLine("A silver chest is on the other side of the room.");
            Console.WriteLine("'Oh nice! There's already treasure here'");
            Console.WriteLine("Gillian walks towards the chest and steps on a pressure plate.");
            Console.WriteLine("Two Large spiders drop from the ceiling");
            Console.WriteLine("Press any key to begin battle");
            Console.ReadKey(true);
            Console.Clear();
        }
        
        void EndMenu()
        {
            playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("> ");

                playerChoice = Console.ReadLine();

                if (playerChoice == "2")
                {
                    gameOver = true;
                }
                else if (playerChoice != "1")
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey(true);
                }

            }
        }

        void PrintHealthStatus()
        {
            //Player Health Status
            if (playerHealth == 100)
            {
                Console.WriteLine("Healthy");
            }
            else if (playerHealth >= 75)
            {
                Console.WriteLine("Slightly Damaged");
            }
            else if (playerHealth >= 50)
            {
                Console.WriteLine("Moderate Damage");
            }
            else if (playerHealth >= 26)
            {
                Console.WriteLine("Heavy Damage");
            }
            else if (playerHealth <= 25)
            {
                Console.WriteLine("Near Death");
            }
        }
        public void Run()
        { 

            while (gameOver != true)
            {
                playerChoice = "";

                DisplayScene0();

                WeaponSelect();

                DisplayScene1();

                EndMenu();

            }

        }
    }
}
