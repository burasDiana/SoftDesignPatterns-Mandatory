using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.DecoratorPattern
{
   abstract class DLC
   {    
        public string OriginalGameTitle { get; set; }
        public abstract void Play_Dlc();
    }
}
