using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.StatePattern
{
    //this class represents the display state of the machine
    class DisplayState : State
    {
        public void DoAction(PlayerMachine machine)
        {
            Console.WriteLine("Player machine is in display mode");
            machine.SetState(this);
        }
    }
}
