using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.DecoratorPattern
{
    // object to decorate 
    class Game_DLC : DLC
    {
        private string _title;

        public Game_DLC(string originalTitle, string _title)
        {
            this.OriginalGameTitle = originalTitle;
            this._title = _title;
        }

        public override void Play_Dlc()
        {
            Console.WriteLine("Playing DLC " + _title + " from " + OriginalGameTitle +  " on PC.");
        }
    }
}
