using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnectorProcessor
{
    public static class Lookups
    {
        public static TeamModel GetTeamById(string id)
        {
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamsModel();
            if (id.Length != 0 && id != "0")
            {
                return teams.Where(x => x.Id == int.Parse(id)).First();
            }

            return null;
        }
        public static PrizeModel GetPrizeById(string id)
        {
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            if (id.Length != 0)
            {
                return prizes.Where(x => x.Id == int.Parse(id)).First();
            }
            return null;
        }
        public static PersonModel GetPersonById(string id)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            if (id.Length != 0)
            {
                return people.Where(x => x.Id == int.Parse(id)).First();
            }
            return null;
        }
        public static MatchupEntryModel GetMatchupEntryById(string id)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels(new List<MatchupModel>());
            if (id.Length != 0)
            {
                return entries.Where(x => x.Id == int.Parse(id)).First();
            }
            return null;
        }
        internal static MatchupModel GetMatchupById(string id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            if (id.Length != 0)
            {
                return matchups.Where(x => x.Id == int.Parse(id)).First();
            }
            return null;
        }
    }
}
