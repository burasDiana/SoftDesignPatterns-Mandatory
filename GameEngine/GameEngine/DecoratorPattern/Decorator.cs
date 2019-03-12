using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.DecoratorPattern
{
    //this class represents the decorator object used to add additional functionality to an object
    abstract class Decorator : DLC
    {
        protected DLC dlc;

        public Decorator(DLC dlc)
        {
            this.dlc = dlc;
        }

        public override void Play_Dlc()
        {
            dlc.Play_Dlc();
        }
    }
}
