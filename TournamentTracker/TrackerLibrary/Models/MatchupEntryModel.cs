﻿namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        public TeamModel? TeamCompeting { get; set; }
        public int TeamCompetingId { get; set; }
        public double Score { get; set; }
        public MatchupModel? ParentMatchup { get; set; }
        public int ParentMatchupId { get; set; }
    }
}
