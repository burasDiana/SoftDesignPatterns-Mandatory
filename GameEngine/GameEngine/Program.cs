using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //illegal construct
            //Player player = new Player();

            //get the only Player object
            Player player = Player.getInstance();
            player.DoStuff();
            Console.ReadLine();
        }
    }
}
