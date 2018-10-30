using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class PlayerUser : Player
    {

        override public string Name { get; set; }
        override public int Roshambo { get; set; }


        public PlayerUser(string name)
        {

            Name = name;

        }

        public override int generateRoshambo()
        {
            while (true)
            {
                char choice = '0';

                Console.WriteLine("Plese select:      1) Rock      2) Paper     3) Scissors");

                choice = Console.ReadKey(true).KeyChar;

                switch (choice)
                {
                    case '1':
                        Roshambo = 1;
                        return 1;
                    case '2':
                        Roshambo = 2;
                        return 2;
                    case '3':
                        Roshambo = 3;
                        return 3;
                    default:
                        continue;

                }
            }

        }




    }
}
