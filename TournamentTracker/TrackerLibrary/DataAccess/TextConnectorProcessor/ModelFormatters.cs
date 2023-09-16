using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnectorProcessor
{
    public static class ModelFormatters
    {
        public static string TeamsFormatter(this List<TeamModel> teams)
        {
            if (teams.Count == 0) return "";

            string output = "";

            foreach (TeamModel team in teams)
            {
                output += $"{team.Id}|";
            }

            return output.Substring(0, output.Length - 1);
        }
        public static string PrizesFormatter(this List<PrizeModel> prizes)
        {
            if (prizes.Count == 0) return "";

            string output = "";

            foreach (PrizeModel prize in prizes)
            {
                if (prize !=  null) { output += $"{prize.Id}|"; }                
            }

            if (output.Length > 0) return output.Substring(0, output.Length - 1);
            else return "";
        }
        public static string TeamMembersFormatter(this List<PersonModel> people)
        {
            if (people.Count == 0) return "";

            string output = "";

            foreach (PersonModel person in people)
            {
                output += $"{person.Id}|";
            }

            return output.Substring(0, output.Length - 1);
        }
        public static string RoundsFormatter(this List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> round in rounds)
            {
                output += $"{round.MatchupListFormatter()}|";
            }

            return output.Substring(0, output.Length - 1);
        }
        public static string MatchupListFormatter(this List<MatchupModel> round)
        {
            string output = "";

            if (round.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel match in round)
            {
                if (match != null) output += $"{match.Id}-";
            }

            if (output.Length > 0) return output.Substring(0, output.Length - 1);
            else return "";
        }
        public static string MatchupEntryFormatter(this List<MatchupEntryModel> matchupEntries)
        {
            string output = "";

            if (matchupEntries.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel match in matchupEntries)
            {
                output += $"{match.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
