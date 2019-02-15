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
            //illegal construct example 2
            //PlayerMachine player = new PlayerMachine();
            bool flag = true;
            //games data set
            DataSource data = new DataSource();

            //get the only PlayerMachine object
            Console.WriteLine("Performing machine setup...");
            PlayerMachine playerMachine = PlayerMachine.getInstance();

            //state pattern
            DisplayState displayMode = new DisplayState();
            PlayState playMode = new PlayState();
            StandbyState standby = new StandbyState();

            Console.WriteLine("Setup complete. Current mode: ");
            Get_Machine_Current_State(playerMachine);

            while (flag)
            {
                Console.WriteLine("You now have the following options: \n 1 - Display games \n 2 - Display filters");

                //display games
                bool inputValid = true;
                bool canPlayGame = false;
                int input;
                input = GetInput();
                displayMode.DoAction(playerMachine);

                if (input == 1)
                {
                    PrintResults(data.GetGames());
                    canPlayGame = true;
                }
                else if (input == 2)
                {
                    Console.WriteLine("You can chose one of the following filters : \n Filter by game types :\n 1 - Adventure \n 2 - Action \n 3 - RolePlay \n Filter by platform :\n 4 - PS4 \n 5 - Nintendo  \n 6 - Xbox  \n 7 - PC  \n Other filters :  \n 8 - 90's Games \n 9 - This year  \n 10 - Top 5 rated \n \n You can also combine filters by using 'and' and 'or'. \n Examples: 3and10 ; 5or6 ; 2 ");

                    var input2 = Console.ReadLine();
                    FilterCriteria finalCriteria = new CriteriaAdventure();

                    if (IsInputString(input2))
                    {
                        //display games filtered by 2 criteria
                        if (input2.Contains("and"))
                        {
                            var splitinput = input2.Split(new[] { "and" }, StringSplitOptions.None);

                            int id1 = Int32.Parse(splitinput[0]);
                            int id2 = Int32.Parse(splitinput[1]);

                            if (IsIdValid(id1) && IsIdValid(id2))
                            {
                                FilterCriteria criteria1 = GetFilterCriteria(id1);
                                FilterCriteria criteria2 = GetFilterCriteria(id2);
                                finalCriteria = new AndCriteria(criteria1, criteria2);
                            }
                            else
                            {
                                inputValid = false;
                                Console.WriteLine("Input invalid, please retry.");
                            }
                            
                        }
                        else if (input2.Contains("or"))
                        {
                            var splitinput = input2.Split(new[] { "or" }, StringSplitOptions.None);

                            int id1 = Int32.Parse(splitinput[0]);
                            int id2 = Int32.Parse(splitinput[1]);

                            if (IsIdValid(id1) && IsIdValid(id2))
                            {
                                FilterCriteria criteria1 = GetFilterCriteria(id1);
                                FilterCriteria criteria2 = GetFilterCriteria(id2);
                                finalCriteria = new OrCriteria(criteria1, criteria2);
                            }
                            else
                            {
                                inputValid = false;
                                Console.WriteLine("Input invalid, please retry.");
                            }
                        } 
                    }
                    else
                    {
                        //display games filtered by 1 criteria
                        int id = Int32.Parse(input2);

                        if (IsIdValid(id))
                        {
                            finalCriteria = GetFilterCriteria(id);
                        }
                        else
                        {
                            inputValid = false;
                            Console.WriteLine("Input invalid, please retry.");
                        }
                    }

                    if (inputValid) //display filter criterias only if they are valid
                    {
                        Console.WriteLine(finalCriteria + " Games :");
                        PrintResults(finalCriteria.MeetCriteria(data.GetGames()));
                        canPlayGame = true;  
                    }
                }
                else //input was not 2 or 1
                {
                    Console.WriteLine("Input invalid, please retry.");
                }

                if (canPlayGame)
                {
                    //play a game 
                    Console.WriteLine("Write the id of the game you wish to play: ");
                    input = GetInput();
                    if (input <= 0 || input > 11)
                    {
                        Console.WriteLine("Input invalid, please retry.");
                    }
                    else
                    {
                        playMode.DoAction(playerMachine);
                        playerMachine.PlayGame(data.GetGames().FirstOrDefault(g => g.Id == input));

                        if (input == 7) // ask to play a DLC for this game
                        {
                            Console.WriteLine("\n This game has DLC available. Press 1 to play.");
                            var inp = Console.ReadLine();
                            if (!IsInputString(inp) && Int32.Parse(inp) == 1)
                            {
                                // decorator pattern

                                //get the game for which we want to play a DLC
                                Game originalGame = data.GetGames().FirstOrDefault(g => g.Id == input);

                                //create the dlc linked to the originalGame
                                Game_DLC fallout_DLC = new Game_DLC(originalGame.Title, "NewVegas");

                                //Make the DLC for game playable / wrap dlc in playable
                                PlayableDLC playableDLC = new PlayableDLC(fallout_DLC);

                                //play DLC
                                playableDLC.Play_Dlc();
                            }
                            else
                            {
                                Console.WriteLine("Input invalid");
                            }
                        }

                    }
                    Console.ReadKey();
                    Console.WriteLine();

                    standby.DoAction(playerMachine);

                    Console.WriteLine("\n \nPress enter to go back to display mode.");
                    Console.ReadLine();
                }

            }

            Console.WriteLine("\n Press any key to exit.");
            Console.ReadLine();
        }

        //filter pattern
        public static FilterCriteria GetFilterCriteria(int id)
        {
            FilterCriteria newCriteria = new CriteriaAdventure();
            switch (id)
            {
                case 1:
                    newCriteria = new CriteriaAdventure();
                    break;
                case 2:
                    newCriteria = new CriteriaAction();
                    break;
                case 3:
                    newCriteria = new CriteriaRolePlay();
                    break;
                case 4:
                    newCriteria = new CriteriaPS4();
                    break;
                case 5:
                    newCriteria = new CriteriaNintendo();
                    break;
                case 6:
                    newCriteria = new CriteriaXbox();
                    break;
                case 7:
                    newCriteria = new CriteriaPC();
                    break;
                case 8:
                    newCriteria = new Criteria90S();
                    break;
                case 9:
                    newCriteria = new CriteriaThisYear();
                    break;
                case 10:
                    newCriteria = new CriteriaTop5();
                    break;
            }
            return newCriteria;
        }

        // checks if input is a string
        private static bool IsInputString(string input)
        {
            int val;
            if (Int32.TryParse(input, out val))
            {
                return false;
            }
            return true;
        }

        // returns -1  if input is not integer
        public static int GetInput()
        {
            int a;
            if (Int32.TryParse(Console.ReadLine(), out a))
            {
                return a;
            }
            return -1;
        }

        // checks if id is within the game id existent
        public static bool IsIdValid(int id)
        {
            if (id > 0 && id < 12)
            {
                return true;
            }

            return false;
        }

        public static void Get_Machine_Current_State(PlayerMachine playerMachine)
        {
            Console.WriteLine(playerMachine.GetState().ToString());
        }
        public static void PrintResults(List<Game> filteredGames)
        {
            foreach (var game in filteredGames)
            {
                Console.WriteLine("Game : [Id: " + game.Id + ", Title: " + game.Title +  ", Genre: " + game.Get_Genre() + ", Platform: " + game.Get_Type() + ", Released: " + game.ReleaseYear + ", Rating :" + game.PopularityRating + "% ]");
            }
        }
    }
}
