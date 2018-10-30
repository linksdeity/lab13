using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GrandCircusLab13
{

    enum Roshambo
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    };


    class RoshamboApp
    {
        public int Wins = 0;
        public int Losses = 0;
        public int Draws = 0;


        public void GetChoices(Player opponent, Player playerOne)
        {
            int playerChoice = playerOne.generateRoshambo();

            int opponentChoice = opponent.generateRoshambo();

            RenderGame(playerChoice, opponentChoice, opponent, playerOne);
        }


        public void RenderGame(int playerChoice, int enemyChoice, Player opponent, Player playerOne)
        {



            string results = "";
            string playerThrow = "";
            string enemyThrow = "";

            Console.Clear();

            Thread.Sleep(400);
            Console.WriteLine("Player throws...");
            Thread.Sleep(600);
            Console.WriteLine(Enum.GetName(typeof(Roshambo), playerChoice) );
            #region playerhands

            switch (playerChoice)
            {
                case 1:
                    playerThrow =
                               "    _______\n" +
                               "---'   ____)\n" +
                               "      (_____)\n" +
                               "      (_____)\n" +
                               "      (____)\n" +
                               "---.__(___)";
                    break;


                case 2:
                    playerThrow =
                              "      ______\n" +
                              "-- - '  ____)____\n" +
                              "           ______)\n" +
                              "          _______)\n" +
                              "         _______)\n" +
                              "---.__________)";
                    break;


                case 3:
                    playerThrow =
                             "      _______\n" +
                             "-- - '   ____)__\n" +
                             "          ______)\n" +
                             "       __________)\n" +
                             "      (____)\n" +
                             "-- -.__(___)";
                    break;
            }
            #endregion
            Console.WriteLine("\n=========================\n" + playerThrow + "\n=========================\n");


            Thread.Sleep(400);
            Console.WriteLine("{0} throws...", opponent.Name);
            Thread.Sleep(600);
            Console.WriteLine(Enum.GetName(typeof(Roshambo), enemyChoice));
            #region enemyhands
            switch (enemyChoice)
            {
                case 1:
                    enemyThrow =
                               "    _______\n" +
                               "---'   ____)\n" +
                               "      (_____)\n" +
                               "      (_____)\n" +
                               "      (____)\n" +
                               "---.__(___)";
                    break;


                case 2:
                    enemyThrow =
                              "      ______\n" +
                              "-- - '  ____)____\n" +
                              "           ______)\n" +
                              "          _______)\n" +
                              "         _______)\n" +
                              "---.__________)";
                    break;


                case 3:
                    enemyThrow =
                             "      _______\n" +
                             "-- - '   ____)__\n" +
                             "          ______)\n" +
                             "       __________)\n" +
                             "      (____)\n" +
                             "-- -.__(___)";
                    break;
            }
            #endregion
            Console.WriteLine("\n=========================\n" + enemyThrow + "\n=========================\n");

            if (playerChoice == 1)
            {
                switch (enemyChoice)
                {
                    case 1:
                        results = "DRAW!!";
                        Draws++;
                        break;
                    case 2:
                        results = "YOU LOSE!!";
                        Losses++;
                        break;
                    case 3:
                        results = "YOU WIN!!";
                        Wins++;
                        break;
                }

            }
            else if (playerChoice == 2)
            {
                switch (enemyChoice)
                {
                    case 1:
                        results = "YOU WIN!!";
                        Wins++;
                        break;
                    case 2:
                        results = "DRAW!!";
                        Draws++;
                        break;
                    case 3:
                        results = "YOU LOSE!!";
                        Losses++;
                        break;
                }
            }
            else if(playerChoice == 3)
            {
                switch (enemyChoice)
                {
                    case 1:
                        results = "YOU LOSE!!";
                        Losses++;
                        break;
                    case 2:
                        results = "YOU WIN!!";
                        Wins++;
                        break;
                    case 3:
                        results = "DRAW!!";
                        Draws++;
                        break;
                }
            }

            Thread.Sleep(600);
            Console.WriteLine("\n" + results);

        }

    }
}
