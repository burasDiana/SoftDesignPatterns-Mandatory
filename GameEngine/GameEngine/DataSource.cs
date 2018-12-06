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
                new Game("Minecraft",Game.GenreTypes.Adventure,1997,87),
                new Game("GrandTheftAuto",Game.GenreTypes.Action,1997,68),
                new Game("MarioBros",Game.GenreTypes.Adventure,1996,87),
                new Game("Battlefield",Game.GenreTypes.Strategy,1987,91),
                new Game("LegendofZelda",Game.GenreTypes.Adventure,1999,32),
                new Game("Doom",Game.GenreTypes.Action,2018,80),
                new Game("Fallout",Game.GenreTypes.Adventure,2003,79),
                new Game("ToTheMoon",Game.GenreTypes.RolePlay,2007,99),
                new Game("Borderlands",Game.GenreTypes.Simulation,2018,87),
                new Game("Portal",Game.GenreTypes.Strategy,2018,93),
                new Game("AssasinsCreed",Game.GenreTypes.Adventure,2018,91)
            };
        }

        public List<Game> GetGames()
        {
            return games;
        }
    }
}
