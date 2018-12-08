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

    public class CriteriaAdventure : FilterCriteria
    {
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
    }

    public class CriteriaAction : FilterCriteria
    {
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
    }

    public class CriteriaRolePlay : FilterCriteria
    {
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
    }

    public class Criteria90S : FilterCriteria
    {
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
    }

    public class CriteriaThisYear : FilterCriteria
    {
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
    }

    public class CriteriaTop5 : FilterCriteria
    {
        public List<Game> MeetCriteria(List<Game> games)
        {

            List<Game> gamesTop5 = new List<Game>();

            int count = 0;
            foreach (var g in games.OrderByDescending(g => g.PopularityPercent)) 
            {
                if (count <= 5 )
                {
                    gamesTop5.Add(g);
                    count++;
                }
            }
            return gamesTop5;
        }
    }

    public class AndCriteria : FilterCriteria
    {
        private FilterCriteria criteria1;
        private FilterCriteria criteria2;

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
    }

    public class OrCriteria : FilterCriteria
    {
        private FilterCriteria criteria1;
        private FilterCriteria criteria2;

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
    }

}
