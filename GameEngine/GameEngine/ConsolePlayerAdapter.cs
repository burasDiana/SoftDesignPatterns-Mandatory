using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class ConsolePlayerAdapter
    {
        private AdvancedConsolePlayer advancedConsolePlayer;

        //constructor which instantiates the correct type class of advancedconsoleplayer
        public ConsolePlayerAdapter(Game.GameTypes gameType)
        {
            if (gameType == Game.GameTypes.NintendoSwitch)
            {
                advancedConsolePlayer = new NintendoPlayer();
            }
            else if (gameType == Game.GameTypes.PS4)
            {
                advancedConsolePlayer = new PS4Player();
            }
            else if (gameType == Game.GameTypes.XBox)
            {
                advancedConsolePlayer = new XboxPlayer();
            }
        }

        // play method of adapter which calls the playmethod of each type's class
        public void Play(Game.GameTypes type, Game game)
        {
            if (type == Game.GameTypes.NintendoSwitch)
            {
                advancedConsolePlayer.PlayNintendo(game);
            }
            else if (type == Game.GameTypes.PS4)
            {
                advancedConsolePlayer.PlayPS4(game);
            }
            else if (type == Game.GameTypes.XBox)
            {
                advancedConsolePlayer.PlayXbox(game);
            }
        }
    }
}
