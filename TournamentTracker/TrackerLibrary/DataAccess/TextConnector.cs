using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextConnectorProcessor;
using TrackerLibrary.AppLogic;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> People = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            int currentId = 1;
            if (People.Count > 0)
            {
                currentId = People.OrderBy(x => x.Id).Last().Id + 1;
            }
            model.Id = currentId;
            People.Add(model);
            People.SaveToPeopleFile();
        }
        public void CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderBy(x => x.Id).Last().Id + 1;
            }
            model.Id = currentId;
            prizes.Add(model);
            prizes.SaveToPrizeFile();
        }
        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamsModel();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderBy(x => x.Id).Last().Id + 1;
            }
            model.Id = currentId;
            teams.Add(model);
            teams.SaveToTeamsFile();
        }
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentsFile
                                                .FullFilePath()
                                                .LoadFile()
                                                .ConvertToTournamentModel();
            int currentId = 1;

            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderBy(x => x.Id).Last().Id + 1;
            }

            model.Id = currentId;

            model.Rounds.SaveRounds();

            tournaments.Add(model);
            tournaments.SaveToTournamentFile();
            TournamentLogic.ByesSetUp(model);
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel match in round)
                {
                    UpdateMatchups(match);
                }
            }
        }
        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }
        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamsFile.FullFilePath().LoadFile().ConvertToTeamsModel();
        }
        public List<TournamentModel> GetTournamentsAll()
        {
            return GlobalConfig.TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModel();
        }
        public void UpdateMatchups(MatchupModel m)
        {
            m.UpdateMatchupFile();
        }
    }
}
