using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string DB = "Tournaments";
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PeopleModels.csv";
        public const string TeamsFile = "TeamsModels.csv";
        public const string TournamentsFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";
        public static IDataConnection Connection { get; set; }
        public static void InitializeConnections(DataBaseType db)
        {
            switch (db) 
            {
                case DataBaseType.Sql:
                    SqlConnector sql = new();
                    Connection = sql;
                    break;
                case DataBaseType.Text:
                    TextConnector text = new();
                    Connection = text;
                    break;
            }
        }
        public static string AppKeyLookup(string key)
        {
            return $"{ConfigurationManager.AppSettings[key]}";
        }
        public static string ConnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
