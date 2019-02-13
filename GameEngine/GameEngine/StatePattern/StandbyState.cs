using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.StatePattern
{
    //this class represents the standby state of the machine
    class StandbyState : State
    {
        public void DoAction(PlayerMachine machine)
        {
            Console.WriteLine("Player machine is in standby");
            machine.SetState(this);
        }
    }
}
