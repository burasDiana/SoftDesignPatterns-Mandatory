using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.DecoratorPattern
{
    class PlayableDLC : Decorator
    {
        //Constructor
        public PlayableDLC(DLC dlc) : base(dlc)
        {

        }

        public override void Play_Dlc()
        {
            Console.WriteLine("Making DLC Playable: ");
            base.Play_Dlc();
        }
    }
}
