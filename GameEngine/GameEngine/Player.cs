using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Player
    {
        //create a Player object
        private static Player _instance = new Player();

        //private constructor so class cannot be instantiated
        private Player() { }

        //get the only Player object
        public static Player getInstance()
        {
            return _instance;
        }

        public void DoStuff()
        {
            Console.WriteLine("Doing stuff...");
        }
    }
}
