using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnectorProcessor
{
    public static class Savers
    {
        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAdress},{p.CellphoneNumber}");
            }
            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }
        public static void SaveToTeamsFile(this List<TeamModel> models)
        {
            {
                List<string> lines = new List<string>();
                foreach (TeamModel t in models)
                {
                    lines.Add($"{t.Id},{t.TeamName},{t.TeamMembers.TeamMembersFormatter()}");
                }
                File.WriteAllLines(GlobalConfig.TeamsFile.FullFilePath(), lines);
            }
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel t in models)
            {
                lines.Add($"{t.Id}," +
                    $"{t.TournamentName}," +
                    $"{t.EnteredTeams.TeamsFormatter()}," +
                    $"{t.Prizes.PrizesFormatter()}," +
                    $"{t.Rounds.RoundsFormatter()}");
            }
            File.WriteAllLines(GlobalConfig.TournamentsFile.FullFilePath(), lines);
        }
        public static void SaveRounds(this List<List<MatchupModel>> rounds) 
        {
            foreach (List<MatchupModel> round in rounds)
            {
                foreach(MatchupModel matchup in round)
                {
                    matchup.SaveToMatchupFile();
                }
            }
        }
        public static void SaveToMatchupFile(this MatchupModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderBy(x => x.Id).Last().Id + 1;
            }

            model.Id = currentId;

            matchups.Add(model);
           
            foreach (MatchupEntryModel entry in model.Entries)
            {
                entry.SaveToMatchupEntryFile();
            }

            List<string>  lines = new List<string>();

            foreach (MatchupModel matchup in matchups)
            {
                string winnerId = "";
                if (matchup.Winner != null)
                {
                    winnerId = matchup.Winner.Id.ToString();
                }
                lines.Add($"{matchup.Id},{matchup.Entries.MatchupEntryFormatter()},{winnerId},{matchup.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }
        public static void SaveToMatchupEntryFile(this MatchupEntryModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            List<MatchupEntryModel> matchupEntries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels(matchups);


            int currentId = 1;

            if (matchupEntries.Count > 0)
            {
                currentId = matchupEntries.OrderBy(x => x.Id).Last().Id + 1;
            }

            model.Id = currentId;

            matchupEntries.Add(model);

            List<string> lines = new List<string>();
            foreach (MatchupEntryModel entry in matchupEntries)
            {
                string parent = "";
                string competing = "";
                
                if (entry.TeamCompeting != null && entry.TeamCompeting.Id != 0)
                {
                    competing = entry.TeamCompeting.Id.ToString();
                }
                if (entry.ParentMatchup != null)
                {
                    parent = entry.ParentMatchup.Id.ToString();
                }
                lines.Add($"{entry.Id},{competing},{entry.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
    }
}
