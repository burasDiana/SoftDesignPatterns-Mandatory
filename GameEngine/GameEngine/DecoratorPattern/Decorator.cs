using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.DecoratorPattern
{
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
