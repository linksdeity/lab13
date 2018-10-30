using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab13
{
    abstract class Player
    {

        virtual public string Name { get; set; }
        virtual public int Roshambo { get; set; }




        public abstract int generateRoshambo();



    }
}
