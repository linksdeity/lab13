using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{

    class Program
    {


        static void Main(string[] args)
        {
            Validator checker = new Validator();

            Player Gordy = new PlayerGordy();

            Player Schmoopy = new PlayerSchmoopy();


            List<Player> opponents = new List<Player>();

            opponents.Add(Schmoopy);
            opponents.Add(Gordy);

            //------------------------------------------------

            Console.WriteLine("WELCOME TO ROSHAMBO!!!!!\n\n");

            string name = checker.GetString("Please type in a first name in Title Case...", @"^[A-Z][a-z]+$");

            PlayerUser playerOne = new PlayerUser(name);

            Console.Clear();

            int wins = 0;
            int losses = 0;
            int draws = 0;

            while (true)
            {
                int counter = 0;

                Console.WriteLine("Welcome, {0}!\n", playerOne.Name);
                Console.WriteLine("WINS: {0} - LOSSES {1} - DRAWS {2}\n------------------------------\n", wins, losses, draws);

                foreach (Player opponent in opponents)
                {
                    counter++;
                    Console.WriteLine(counter + ") - {0}", opponent.Name);
                }


                int choice = checker.GetNumber("\nPlease select the number for your opponent!", 1, (opponents.Count));

                Console.Clear();

                Console.WriteLine("--- Now playing against: {0}", opponents[choice - 1].Name + "\n");

                RoshamboApp game = new RoshamboApp();

                game.GetChoices((opponents[choice - 1]), playerOne);


                wins += game.Wins;
                losses += game.Losses;
                draws += game.Draws;


                Console.WriteLine("\nWould you like to play again?\n'y' for 'Y'es, anything else for NO!...");

                char answer = Console.ReadKey(true).KeyChar;

                if (answer == 'y' || answer == 'Y')
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("\nGOODBYE!!!");
                    Console.ReadKey(true);
                    break;
                }
            }


        }
    }
}
