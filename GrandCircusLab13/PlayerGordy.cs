using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class PlayerGordy : Player
    {

        override public string Name { get; set; } = "Gordy";
        override public int Roshambo { get; set; }

        public override int generateRoshambo()
        {
            Random roll = new Random();

            int move = roll.Next(1, 4);

            Roshambo = move;
            return move;
        }

    }
}
