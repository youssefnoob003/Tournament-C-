using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnectorProcessor
{
    public static class Updaters
    {
        public static void UpdateMatchupFile(this MatchupModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            MatchupModel old = new MatchupModel();

            foreach (MatchupModel matchup in matchups)
            {
                if (matchup.Id == model.Id)
                {
                    old = matchup;
                }
            }

            matchups.Remove(old);
            
            matchups.Add(model);

            foreach (MatchupEntryModel entry in model.Entries)
            {
                entry.UpdateMatchupEntryFile();
            }

            List<string> lines = new List<string>();

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
        public static void UpdateMatchupEntryFile(this MatchupEntryModel model)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            List<MatchupEntryModel> matchupEntries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels(matchups);

            MatchupEntryModel old = new MatchupEntryModel();

            foreach (MatchupEntryModel matchup in matchupEntries)
            {
                if (matchup.Id == model.Id)
                {
                    old = matchup;
                }
            }

            matchupEntries.Remove(old);

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
