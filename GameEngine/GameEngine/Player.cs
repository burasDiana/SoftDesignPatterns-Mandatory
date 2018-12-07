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

        //instance of adapter class
        ConsolePlayerAdapter consolePlayerAdapter;

        public void PlayGame(Game.GameTypes type ,Game game)
        {
            // built in PC support
            if (type == Game.GameTypes.PC)
            {
                Console.WriteLine("Playing " +  game.Title  + " on PC.");
            }
            // adapter provides support for simulating playing a console game
            else if( type == Game.GameTypes.NintendoSwitch || type == Game.GameTypes.PS4 || type == Game.GameTypes.XBox)
            {
                consolePlayerAdapter = new ConsolePlayerAdapter(type);
                consolePlayerAdapter.Play(type,game);
            }
            else if(type == Game.GameTypes.Undefined)
            {
                Console.WriteLine("Invalid game type not supported.");
            }
        }
    }
}
