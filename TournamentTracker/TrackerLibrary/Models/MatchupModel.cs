namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel? Winner { get; set; }
        public int WinnerId { get; set; }
        public int MatchupRound { get; set; }
        public string MatchupName 
        { 
            get 
            {
                string output = "";
                foreach (MatchupEntryModel entry in Entries)
                {
                    if (entry.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output += entry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += " Vs " + entry.TeamCompeting.TeamName;
                        } 
                    }
                    else
                    {
                        return "TBA";
                    }
                }

                if (Entries.Count > 1)
                {
                    if (Winner != null)
                    {
                        output += " Winner: " + Winner.TeamName;
                    }
                    else
                    {
                        output += " Winner: TBA";
                    }
                }

                else
                {
                    output += " Automatic Win";
                }

                return output;
            }
        }
    }
}