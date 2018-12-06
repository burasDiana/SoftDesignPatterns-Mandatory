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
            //Game game = new Game()
            //{
            //    Title = "Game1",
            //    Genre = "Action-Adventure",
            //};
            ////get the only Player object
            //Player playerMachine = Player.getInstance();
            //playerMachine.PlayGame(game);

            DataSource data = new DataSource();

            FilterCriteria adventure = new CriteriaAdventure();
            FilterCriteria top5 = new CriteriaTop5();
            FilterCriteria newest = new CriteriaThisYear();
            FilterCriteria top5andnewest = new AndCriteria( top5,newest);

            Console.WriteLine("\nAdventure :");
            PrintResults(adventure.MeetCriteria(data.GetGames()));

            Console.WriteLine("\nTop 5 :");
            PrintResults(top5.MeetCriteria(data.GetGames()));

            Console.WriteLine("\nTop 5 and newest :");
            PrintResults(top5andnewest.MeetCriteria(data.GetGames()));

            Console.ReadLine();
        }

        public static void PrintResults(List<Game> filteredGames)
        {
            foreach (var game in filteredGames)
            {
                Console.WriteLine("Game : [Title: " + game.Title + ", Genre: "+ game.Get_Genre() + ", Released: " + game.ReleaseYear + ", Score :" + game.PopularityPercent + "% ]");
            }
        }
    }
}
