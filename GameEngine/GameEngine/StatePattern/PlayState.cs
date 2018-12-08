using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.StatePattern
{
    class PlayState : State
    {
        public void DoAction(PlayerMachine machine)
        {
            Console.WriteLine("Player machine is in play mode");
            machine.SetState(this);
        }
    }
}
