using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    class PlayerSchmoopy : Player
    {


        override public string Name { get; set; } = "Schmoopy";
        override public int Roshambo { get; set; }

        public override int generateRoshambo()
        {
            Roshambo = 1;
            return 1;
        }


    }
}
