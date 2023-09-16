using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrackerLibrary.AppLogic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB));
            var p = new DynamicParameters();
            p.Add("@FirstName", model.FirstName);
            p.Add("@LastName", model.LastName);
            p.Add("@Email", model.EmailAdress);
            p.Add("@Cellphone", model.CellphoneNumber);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spPeople_insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@Id");
        }

        public void CreatePrize(PrizeModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB));
            var p = new DynamicParameters();
            p.Add("@PlaceNumber", model.PlaceNumber);
            p.Add("@PlaceName", model.PlaceName);
            p.Add("@PrizeAmount", model.PrizeAmount);
            p.Add("@PrizePercentage", model.PrizePercentage);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spPrizes_insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@Id");
        }

        public void CreateTeam(TeamModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB));
            var p = new DynamicParameters();
            p.Add("@TeamName", model.TeamName);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@Id");

            foreach (PersonModel tm in model.TeamMembers)
            {
                p = new DynamicParameters();
                p.Add("@TeamId", model.Id);
                p.Add("@PersonId", tm.Id);

                connection.Execute("spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
            
        public void CreateTournament(TournamentModel model)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB));
            SaveTournament(connection, model);
            SaveTournamentPrizes(connection, model);
            SaveTournamentEntries(connection, model);
            SaveRounds(connection, model);
            TournamentLogic.ByesSetUp(model);
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel match in round)
                {
                    UpdateMatchups(match);
                }
            }
        }
        
        public static void SaveRounds(IDbConnection connection, TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@TournamentRound", matchup.MatchupRound);
                    p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    if (matchup.Winner != null) p.Add("@WinnerId", matchup.Winner.Id);

                    connection.Execute("spMatchups_Insert", p, commandType: CommandType.StoredProcedure);
                    matchup.Id = p.Get<int>("@Id");

                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", matchup.Id);
                        if (entry.ParentMatchup != null) p.Add("@ParentMatchupId", entry.ParentMatchup.Id);

                        p.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                        connection.Execute("spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                        entry.Id = p.Get<int>("@Id");
                    }
                }
            }
        }
        public static void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("spTournament_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@Id");
        }
        public static void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);

                connection.Execute("spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void SaveTournamentEntries(IDbConnection connection, TournamentModel model)
        {
                foreach (TeamModel t in model.EnteredTeams)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@TeamId", t.Id);

                    connection.Execute("spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
                }
        }
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB)))
            {
                output = connection.Query<PersonModel>("spPeople_SelectAll").ToList();
            }
            return output;
        }
        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB));
            output = connection.Query<TeamModel>("spTeams_SelectAll").ToList();

            foreach (TeamModel team in output)
            {
                var p = new DynamicParameters();
                p.Add("@Id", team.Id);
                team.TeamMembers = connection.Query<PersonModel>("spTeamsMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return output;
        }

        public List<TournamentModel> GetTournamentsAll()
        {
            List<TournamentModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB)))
            {
                output = connection.Query<TournamentModel>("spTournaments_SelectAll").ToList();
                foreach (TournamentModel t in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);
                    t.Prizes = connection.Query<PrizeModel>("spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                    
                    t.EnteredTeams = connection.Query<TeamModel>("sbTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    List<MatchupModel> matchups = connection.Query<MatchupModel>("spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();

                    foreach (MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", m.Id);
                        m.Entries = connection.Query<MatchupEntryModel>("spMatchupEntries_GetByMatchupId", p, commandType: CommandType.StoredProcedure).ToList();
                       
                        
                        List<TeamModel> allTeams = GetTeam_All();

                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }

                        foreach (MatchupEntryModel me in m.Entries)
                        {
                            if (me.TeamCompetingId > 0)
                            {
                                me.TeamCompeting = allTeams.Where(x => x.Id == me.TeamCompetingId).First();
                            }
                            if (me.ParentMatchupId > 0)
                            {
                                me.ParentMatchup = matchups.Where(x => x.Id == me.ParentMatchupId).First();
                            }
                        }
                    }

                    List<MatchupModel> currRow = new(); 
                    int currRound = 1;
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.MatchupRound > currRound)
                        {
                            t.Rounds.Add(currRow);
                            currRound++;
                            currRow = new List<MatchupModel>();
                        }
                        currRow.Add(m);
                    }

                    t.Rounds.Add(currRow);

                    foreach (TeamModel team in t.EnteredTeams)
                    {
                        p = new DynamicParameters();
                        p.Add("@Id", team.Id);
                        team.TeamMembers = connection.Query<PersonModel>("spTeamsMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                    }
                }
            }
            return output;
        }

        public void UpdateMatchups(MatchupModel m)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnString(GlobalConfig.DB));
            var p = new DynamicParameters();
            if (m.Winner != null) p.Add("@WinnerId", m.Winner.Id);
            p.Add("@Id", m.Id);

            connection.Execute("spMatchups_Update", p, commandType: CommandType.StoredProcedure);

            foreach (MatchupEntryModel me in m.Entries)
            {
                if (me.TeamCompeting != null)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", me.TeamCompeting.Id);
                    p.Add("@Score", me.Score);
                    p.Add("@Id", me.Id);

                    connection.Execute("spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}

