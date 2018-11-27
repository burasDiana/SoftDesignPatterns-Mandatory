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
            Game game = new Game()
            {
                Title = "Game1",
                Genre = "Action-Adventure",
                ReleaseDate = new DateTime(2013, 04, 28),
            };
            //get the only Player object
            Player player = Player.getInstance();
            player.DoStuff(game);

            //Console.WriteLine(student.getState().ToString());
            Console.ReadLine();
        }

    }
}
