using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    interface AdvancedConsolePlayer
    {
        void PlayPS4(Game game);
        void PlayNintendo(Game game);
        void PlayXbox(Game game);
    }

    public class PS4Player : AdvancedConsolePlayer
    {
        public void PlayPS4(Game game)
        {
            Console.WriteLine("Playing " + game.Title + " on PS4.");
        }
        public void PlayNintendo(Game game)
        {
            
        }

        public void PlayXbox(Game game)
        {
            
        }
    }
    public class NintendoPlayer : AdvancedConsolePlayer
    {
        public void PlayPS4(Game game)
        {
            
        }
        public void PlayNintendo(Game game)
        {
            Console.WriteLine("Playing " + game.Title + " on NintendoSwitch.");
        }

        public void PlayXbox(Game game)
        {

        }
    }
    public class XboxPlayer : AdvancedConsolePlayer
    {
        public void PlayPS4(Game game)
        {

        }

        public void PlayNintendo(Game game)
        {

        }

        public void PlayXbox(Game game)
        {
            Console.WriteLine("Playing " + game.Title + " on Xbox.");
        }
    }
}
