using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.StatePattern;

namespace GameEngine
{
    class PlayerMachine
    {
        //create a PlayerMachine object
        private static PlayerMachine _instance = new PlayerMachine();

        private State _state;

        //private constructor so class cannot be instantiated
        private PlayerMachine()
        {
            this._state = null;
        }

        //get the only PlayerMachine object
        public static PlayerMachine getInstance()
        {
            return _instance;
        }

        public void SetState(State state)
        {
            this._state = state;
        }

        public State GetState()
        {
            return _state;
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
