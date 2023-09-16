using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;
using TrackerLibrary.Models;


namespace TrackerLibrary.AppLogic
{
    public static class TournamentLogic
    {
        public static void CreateRound(TournamentModel model)
        {
            model.EnteredTeams.RandomizeTeams();

            int roundsCount = CalculateNumberOfRounds(model.EnteredTeams.Count());

            int byes = CalculateNumberOfByes(model.EnteredTeams.Count, roundsCount);

            model.Rounds.Add(GenFirstRound(byes, model.EnteredTeams));
            CreateOtherRound(model, roundsCount);

        }
        public static void ByesSetUp(TournamentModel model)
        {
            foreach (MatchupModel firstMatchup in model.Rounds[0])
            {
                if (firstMatchup.Entries.Count == 1)
                {
                    firstMatchup.Winner = firstMatchup.Entries[0].TeamCompeting;

                    foreach (MatchupModel matchup in model.Rounds[1])
                    {
                        foreach (MatchupEntryModel entry in matchup.Entries)
                        {
                            if (entry.ParentMatchup != null)
                            {
                                if (entry.ParentMatchup.Id == firstMatchup.Id)
                                {
                                    entry.TeamCompeting = firstMatchup.Winner;
                                }
                            }
                        }
                    }
                }
            }
        }
        public static void CreateOtherRound(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[round - 2];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel matchup in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = matchup, TeamCompeting = new TeamModel() });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                round++;
                previousRound = currRound;
                currRound = new List<MatchupModel>();
            }

        }
        public static List<MatchupModel> GenFirstRound(int byes, List<TeamModel> teams)
        {
            MatchupModel curr = new MatchupModel();
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (TeamModel team in teams)
            {
                MatchupEntryModel entry = new MatchupEntryModel();
                entry.TeamCompeting = team;

                curr.Entries.Add(entry);

                if (byes > 0 || curr.Entries.Count == 2)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();
                    if (byes > 0) { byes--; }
                }
            }
            return output;
        }
        public static int GetCurrRound(TournamentModel tournament)
        {
            int output = 1;

            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output++;
                }
            }
            return output;
        }
        public static int CalculateNumberOfByes(int numberOfTeams, int numberOfRounds)
        {
            return (int)Math.Pow(2, numberOfRounds) - numberOfTeams;
        }
        private static void RandomizeTeams(this List<TeamModel> teams)
        {
            Random random = new Random();

            for (int i = teams.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                TeamModel tmp = teams[j];
                teams[j] = teams[i];
                teams[i] = tmp;
            }
        }
        private static int CalculateNumberOfRounds(int numberOfTeams)
        {
            int numberOfRounds = 0;

            if (numberOfTeams > 1)
            {
                numberOfRounds = (int)Math.Ceiling(Math.Log(numberOfTeams, 2));
            }

            return numberOfRounds;
        }
        public static void AdvanceWinner(MatchupModel m, TournamentModel tournament)
        {
            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        if (entry.ParentMatchup != null)
                        {
                            if (entry.ParentMatchup.Id == m.Id)
                            {
                                entry.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.UpdateMatchups(matchup);
                            }
                        }
                    }
                }
            }
        }
        public static string Score(MatchupModel m)
        {
            double ScoreVal1 = m.Entries[0].Score;
            double ScoreVal2 = m.Entries[1].Score;

            string winnerSystem = GlobalConfig.AppKeyLookup("GreaterScoreWins");

            if (ScoreVal1 != ScoreVal2)
            {
                if (winnerSystem == "1")
                {
                    m.Winner = (ScoreVal1 > ScoreVal2) ? m.Entries[0].TeamCompeting : m.Entries[1].TeamCompeting;
                }

                else if (winnerSystem == "0")
                {
                    m.Winner = (ScoreVal1 < ScoreVal2) ? m.Entries[0].TeamCompeting : m.Entries[1].TeamCompeting;
                }
                return "";
            }

            else
            {
                return "Tie";
            }
        }
        public static void AlertPlayersNewRound(TournamentModel tournament, int currRound)
        {
            string header = "";
            StringBuilder body = new StringBuilder();

            foreach (MatchupModel m in tournament.Rounds[currRound - 1])
            {
                if (m.Entries.Count == 1)
                {
                    header = "You Get an Automatic Win!";
                    foreach (PersonModel p in m.Entries[0].TeamCompeting.TeamMembers)
                    {
                        body = new StringBuilder();
                        body.Append($"Enjoy you bye week {p.FirstName}");
                        EmailLogic.SendMail(p.EmailAdress, header, body.ToString());
                    }
                }
                else
                {
                    foreach (MatchupEntryModel e in m.Entries)
                    {
                        string opponent = m.Entries.Where(x => x.TeamCompeting.Id != e.TeamCompeting.Id).First().TeamCompeting.TeamName;
                        header = "You're up for the next round!";
                        foreach (PersonModel p in m.Entries[0].TeamCompeting.TeamMembers)
                        {
                            body = new StringBuilder();
                            body.Append($"Get ready to face {opponent}");
                            EmailLogic.SendMail(p.EmailAdress, header, body.ToString());
                        }
                    }
                }
            }
        }
        public static void AlertWinner(TournamentModel tournament, int currRound)
        {
            MatchupModel last = tournament.Rounds[currRound - 2].First();

            TeamModel winner = last.Winner;

            double prize = 0;

            PrizeModel prizeModel = tournament.Prizes.FirstOrDefault(x => x.PlaceNumber == 1);

            if (prizeModel != null)
            {
                if (prizeModel.PrizeAmount != 0)
                {
                    prize = (double)prizeModel.PrizeAmount;
                }

                else
                {
                    int teamsCount = tournament.EnteredTeams.Count;
                    double fee = (double)tournament.EntryFee;
                    prize = teamsCount * fee * prizeModel.PrizePercentage / 100;
                }
            }

            foreach (PersonModel p in winner.TeamMembers)
            {
                string header = $"Congrats on your win {p.FirstName} with your team {winner.TeamName} in the tournament {tournament.TournamentName}";
                StringBuilder body = new StringBuilder();

                body.Append($"By winning this tournament your team gets a prize of {prize}$");
                EmailLogic.SendMail(p.EmailAdress, header, body.ToString());
            }
        }
    }
}
