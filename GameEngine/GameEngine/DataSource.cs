using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class DataSource
    {
        private List<Game> games;

        public DataSource()
        {
            games = new List<Game>()
            {
                new Game(1,"Minecraft",Game.GenreTypes.Adventure,Game.GameTypes.PC, 1997,87),
                new Game(2,"GrandTheftAuto",Game.GenreTypes.Action,Game.GameTypes.PC,1997,68),
                new Game(3,"MarioBros",Game.GenreTypes.Adventure,Game.GameTypes.NintendoSwitch,1996,87),
                new Game(4,"Battlefield",Game.GenreTypes.Strategy,Game.GameTypes.PS4,1987,91),
                new Game(5,"LegendofZelda",Game.GenreTypes.Adventure,Game.GameTypes.NintendoSwitch,1999,32),
                new Game(6,"Doom",Game.GenreTypes.Action,Game.GameTypes.PS4,2018,80),
                new Game(7,"Fallout",Game.GenreTypes.Adventure,Game.GameTypes.PC,2003,79),
                new Game(8,"ToTheMoon",Game.GenreTypes.RolePlay,Game.GameTypes.PC,2007,99),
                new Game(9,"Borderlands",Game.GenreTypes.Simulation,Game.GameTypes.PS4,2018,87),
                new Game(10,"Portal",Game.GenreTypes.Strategy,Game.GameTypes.PC,2018,93),
                new Game(11,"AssasinsCreed",Game.GenreTypes.Adventure,Game.GameTypes.PS4,2018,91),
                new Game(11,"Inside",Game.GenreTypes.Adventure,Game.GameTypes.PC,2014,92)
            };
        }

        public List<Game> GetGames()
        {
            return games;
        }
    }
}
