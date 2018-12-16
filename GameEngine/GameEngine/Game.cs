using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } //generates auto-property
        public enum GenreTypes { Undefined, Adventure, Action, RolePlay, Simulation, Strategy };
        public enum GameTypes { Undefined , PC, NintendoSwitch, PS4, XBox};
        private GenreTypes Genre { get; }
        private GameTypes Type { get; }
        public int ReleaseYear { get; set; }
        public double PopularityRating { get; set; }

        public GenreTypes Get_Genre()
        {
            return Genre;
        }
        public GameTypes Get_Type()
        {
            return Type;
        }
        
        public Game(int id, string title, GenreTypes genre, GameTypes type, int releaseYear, double popularity)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Type = type;
            ReleaseYear = releaseYear;
            PopularityRating = popularity;
        }
    }
}
