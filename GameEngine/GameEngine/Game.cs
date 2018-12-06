using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Game
    {
        public string Title { get; set; } //generates auto-property
        public enum GenreTypes { Adventure, Action, RolePlay, Simulation, Strategy };
        private GenreTypes Genre { get; set; }

        public GenreTypes Get_Genre()
        {
            return Genre;
        }
        public int ReleaseYear { get; set; }
        public double PopularityPercent { get; set; }

        public Game(string title, GenreTypes genre, int releaseYear, double popularity)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            PopularityPercent = popularity;
        }

    }
}
