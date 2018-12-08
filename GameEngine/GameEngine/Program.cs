using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.DecoratorPattern;
using GameEngine.StatePattern;

namespace GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            //illegal construct
            //PlayerMachine player = new PlayerMachine();

            //games data set
            DataSource data = new DataSource();

            ////get the only PlayerMachine object
            PlayerMachine playerMachine = PlayerMachine.getInstance();

            #region StatePattern
            //DisplayState displayMode = new DisplayState();
            //PlayState playMode = new PlayState();
            //StandbyState standby = new StandbyState();

            //Get_Machine_Current_State(playerMachine);

            //displayMode.DoAction(playerMachine);

            //Get_Machine_Current_State(playerMachine);

            //playMode.DoAction(playerMachine);

            //Get_Machine_Current_State(playerMachine); 
            #endregion

            #region AdapterPattern
            //playerMachine.PlayGame(Game.GameTypes.PS4, data.GetGames().FirstOrDefault(g => g.Title =="Doom") ); 
            #endregion

            #region FilterPattern
            //FilterCriteria adventure = new CriteriaAdventure();
            //FilterCriteria top5 = new CriteriaTop5();
            //FilterCriteria newest = new CriteriaThisYear();
            //FilterCriteria top5andnewest = new AndCriteria(top5, newest);

            //Console.WriteLine("\nAdventure :");
            //PrintResults(adventure.MeetCriteria(data.GetGames()));

            //Console.WriteLine("\nTop 5 :");
            //PrintResults(top5.MeetCriteria(data.GetGames()));

            //Console.WriteLine("\nTop 5 and newest :");
            //PrintResults(top5andnewest.MeetCriteria(data.GetGames()));
            #endregion

            #region DecoratorPattern

            ////get the game for which we want to play a DLC
            //Game originalGame = data.GetGames().FirstOrDefault(g => g.Title == "Fallout");

            ////create the dlc linked to the originalGame
            //Game_DLC fallout_DLC = new Game_DLC(originalGame.Title, "NewVegas");

            ////Make the game playable
            //PlayableDLC playableDLC = new PlayableDLC(fallout_DLC);

            //playableDLC.Play_Dlc();
            #endregion

            Console.ReadLine();
        }

        public static void Get_Machine_Current_State(PlayerMachine playerMachine)
        {
            Console.WriteLine(playerMachine.GetState().ToString());
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
