using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public interface FilterCriteria
    {
        List<Game> MeetCriteria(List<Game> games);
    }

    //filter by genre
    public class CriteriaAdventure : FilterCriteria
    {
        public override string ToString()
        {
            return "Adventure";
        }

        public List<Game> MeetCriteria(List<Game> games)
        {
             
            List<Game> adventureGames = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Genre() == Game.GenreTypes.Adventure)
                {
                    adventureGames.Add(g);
                }
            }
            return adventureGames;
        }
    } // 1

    public class CriteriaAction : FilterCriteria
    {
        public override string ToString()
        {
            return "Action";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> actionGames = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Genre() == Game.GenreTypes.Action)
                {
                    actionGames.Add(g);
                }
            }
            return actionGames;
        }
    } //2

    public class CriteriaRolePlay : FilterCriteria
    {
        public override string ToString()
        {
            return "RolePlay";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> rolePlayGames = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Genre() == Game.GenreTypes.RolePlay)
                {
                    rolePlayGames.Add(g);
                }
            }
            return rolePlayGames;
        }
    } //3

    //filter by game type
    public class CriteriaPS4 : FilterCriteria
    {
        public override string ToString()
        {
            return "PS4";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> PS4Games = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Type() == Game.GameTypes.PS4)
                {
                    PS4Games.Add(g);
                }
            }
            return PS4Games;
        }
    } //4

    public class CriteriaNintendo : FilterCriteria
    {
        public override string ToString()
        {
            return "Nintendo";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> NintendoGames = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Type() == Game.GameTypes.NintendoSwitch)
                {
                    NintendoGames.Add(g);
                }
            }
            return NintendoGames;
        }
    } //5

    public class CriteriaXbox : FilterCriteria
    {
        public override string ToString()
        {
            return "Xbox";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> XboxGames = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Type() == Game.GameTypes.XBox)
                {
                    XboxGames.Add(g);
                }
            }

            return XboxGames;
        }
    } //6

    public class CriteriaPC : FilterCriteria
    {
        public override string ToString()
        {
            return "PC";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> PCGames = new List<Game>();

            foreach (var g in games)
            {
                if (g.Get_Type() == Game.GameTypes.PC)
                {
                    PCGames.Add(g);
                }
            }
            return PCGames;
        }
    } //7

    public class Criteria90S : FilterCriteria
    {
        public override string ToString()
        {
            return "90's";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> games90s = new List<Game>();

            foreach (var g in games)
            {
                if (g.ReleaseYear < 2000 && g.ReleaseYear >1989)
                {
                    games90s.Add(g);
                }
            }
            return games90s;
        }
    } //8

    //filter by other
    public class CriteriaThisYear : FilterCriteria
    {
        public override string ToString()
        {
            return "This year";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> gamesThisYear = new List<Game>();

            foreach (var g in games)
            {
                if (g.ReleaseYear == DateTime.Now.Year)
                {
                    gamesThisYear.Add(g);
                }
            }
            return gamesThisYear;
        }
    } //9

    public class CriteriaTop5 : FilterCriteria
    {
        public override string ToString()
        {
            return "Top 5 Rated";
        }
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> gamesTop5 = new List<Game>();

            int count = 0;
            foreach (var g in games.OrderByDescending(g => g.PopularityRating)) 
            {
                if (count <= 5 )
                {
                    gamesTop5.Add(g);
                    count++;
                }
            }
            return gamesTop5;
        }
    } //10

    //combine filters
    public class AndCriteria : FilterCriteria
    {
        private FilterCriteria criteria1;
        private FilterCriteria criteria2;

        public override string ToString()
        {
            return criteria1 + " and " + criteria2;
        }
        public AndCriteria (FilterCriteria criteria1, FilterCriteria criteria2)
        {
            this.criteria1 = criteria1;
            this.criteria2 = criteria2;
        }

        public List<Game> MeetCriteria(List<Game> games)
        {
            List<Game> firstCriteriaGames = criteria1.MeetCriteria(games);
            return criteria2.MeetCriteria(firstCriteriaGames);
        }
    }//and

    public class OrCriteria : FilterCriteria
    {
        private FilterCriteria criteria1;
        private FilterCriteria criteria2;
        public override string ToString()
        {
            return criteria1 + " or " + criteria2;
        }
        public OrCriteria(FilterCriteria criteria1, FilterCriteria criteria2)
        {
            this.criteria1 = criteria1;
            this.criteria2 = criteria2;
        }

        public List<Game> MeetCriteria(List<Game> games)
        {
            List<Game> firstCriteriaGames = criteria1.MeetCriteria(games);
            List<Game> secondCriteriaGames = criteria2.MeetCriteria(games);

            foreach (var game in secondCriteriaGames)
            {
                if (!firstCriteriaGames.Contains(game))
                {
                    firstCriteriaGames.Add(game);
                }
            }
            return firstCriteriaGames;
        }
    }//or

}
