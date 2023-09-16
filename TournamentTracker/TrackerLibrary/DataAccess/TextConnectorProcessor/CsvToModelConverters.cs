using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnectorProcessor
{
    public static class CsvToModelConverters
    {
        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new();
            foreach (string line in lines)
            {
                string[] col = line.Split(',');
                PrizeModel p = new(
                    int.Parse(col[0]),
                    int.Parse(col[1]),
                    col[2],
                    decimal.Parse(col[3]),
                    double.Parse(col[4])
                );

                output.Add(p);
            }

            return output;
        }
        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new();
            foreach (string line in lines)
            {
                string[] col = line.Split(',');
                PersonModel p = new(
                    int.Parse(col[0]),
                    col[1],
                    col[2],
                    col[4],
                    col[3]
                );

                output.Add(p);
            }

            return output;
        }
        public static List<TeamModel> ConvertToTeamsModel(this List<string> lines)
        {
            List<TeamModel> output = new();
            foreach (string line in lines)
            {
                string[] col = line.Split(',');
                TeamModel t = new()
                {
                    TeamName = col[1],
                    Id = int.Parse(col[0])
                };

                string[] TeamMembersIds = col[2].Split('|');

                foreach (string id in TeamMembersIds)
                {
                    t.TeamMembers.Add(Lookups.GetPersonById(id));
                }

                output.Add(t);
            }

            return output;
        }
        public static List<TournamentModel> ConvertToTournamentModel(this List<string> lines)
        {
            List<TournamentModel> output = new();

            foreach (string line in lines)
            {
                string[] col = line.Split(',');
                TournamentModel t = new()
                {
                    Id = int.Parse(col[0]),
                    TournamentName = col[1]
                };

                string[] TeamIds = col[2].Split('|');
                string[] PrizeIds = col[3].Split('|');
                string[] Rounds = col[4].Split('|');

                t.EnteredTeams = new List<TeamModel>();
                t.Prizes = new List<PrizeModel>();
                t.Rounds = new List<List<MatchupModel>>();

                foreach (string id in TeamIds)
                {
                    t.EnteredTeams.Add(Lookups.GetTeamById(id));
                }

                foreach (string id in PrizeIds)
                {                 
                    t.Prizes.Add(Lookups.GetPrizeById(id));
                }

                foreach (string round in Rounds)
                {
                    List<MatchupModel> ms = new();
                    string[] matchupText = round.Split('-');

                    foreach (string id in matchupText)
                    {
                        ms.Add(Lookups.GetMatchupById(id));
                    }

                    t.Rounds.Add(ms);
                }

                output.Add(t);
            }

            return output;
        }
        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {
            List<MatchupModel> output = new();
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels(new List<MatchupModel>());

            foreach (string line in lines)
            {
                string[] col = line.Split(',');

                MatchupModel matchup = new()
                {
                    Id = int.Parse(col[0]),
                    MatchupRound = int.Parse(col[3]),
                    Winner = Lookups.GetTeamById(col[2])
                };

                string[] entryIds = col[1].Split('|');
                foreach (string entryId in entryIds)
                {
                    if (int.TryParse(entryId, out int id))
                    {
                        MatchupEntryModel entry = entries.First(e => e.Id == id);
                        matchup.Entries.Add(entry);
                    }
                }

                output.Add(matchup);
            }

            entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels(output);
            output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] col = line.Split(',');

                MatchupModel matchup = new()
                {
                    Id = int.Parse(col[0]),
                    MatchupRound = int.Parse(col[3]),
                    Winner = Lookups.GetTeamById(col[2])
                };

                string[] entryIds = col[1].Split('|');
                foreach (string entryId in entryIds)
                {
                    if (int.TryParse(entryId, out int id))
                    {
                        MatchupEntryModel entry = entries.First(e => e.Id == id);
                        matchup.Entries.Add(entry);
                    }
                }

                output.Add(matchup);
            }

            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines, List<MatchupModel> matchups)
        {
            List<MatchupEntryModel> output = new();
            foreach (string line in lines)
            {
                string[] col = line.Split(',');

                MatchupEntryModel matchupEntry = new()
                {
                    Id = int.Parse(col[0]),
                    TeamCompeting = Lookups.GetTeamById(col[1]),
                    Score = double.Parse(col[2])
                };

                if (!string.IsNullOrEmpty(col[3]))
                {
                    int parentId = int.Parse(col[3]);
                    MatchupModel parentMatchup = matchups.FirstOrDefault(m => m.Id == parentId);
                    matchupEntry.ParentMatchup = parentMatchup;
                }

                output.Add(matchupEntry);
            }

            return output;
        }

    }
}
