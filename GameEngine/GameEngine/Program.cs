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
            int i = 0;
            if (i > 0)
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

                Console.ReadLine();
            }

            int[] depFlights = new[] {1, 2, 3, 4};
            int[] arrFlights = new[] {10, 20, 30};

            Console.WriteLine("The pairs are:" + '\n');

            foreach (var pair in CreatePairs(depFlights,arrFlights))
            {
                Console.WriteLine(pair + '\n');
            }

            Console.ReadLine();
        }

        private static List<string> CreatePairs(int[] depFlights, int[]arrFlights)
        {
            List<string> results = new List<string>();
            int i = 0;
            foreach (var d in depFlights)
            {
                foreach (var a in arrFlights)
                {
                    results.Add(d + "-" + a);
                }
            }
            return results;
        }
    }
}
