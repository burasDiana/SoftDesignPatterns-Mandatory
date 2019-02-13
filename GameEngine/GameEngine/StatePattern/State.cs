using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.StatePattern
{
    //this class represents the interface implemented by the different state objects
    interface State
    {
        void DoAction(PlayerMachine machine);
    }
}
