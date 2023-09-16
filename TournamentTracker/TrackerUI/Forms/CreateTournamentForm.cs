using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.AppLogic;
using TrackerLibrary.Models;
using TrackerUI.Requesters;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        readonly List<TeamModel> SelectedTeams = new();
        readonly List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        readonly List<PrizeModel> prizes = new();
        readonly ICreateTournamentRequester caller;
        public CreateTournamentForm(ICreateTournamentRequester caller)
        {
            this.caller = caller;
            InitializeComponent();
            WireUp();
        }
        public void PrizeComplete(PrizeModel prize)
        {
            prizes.Add(prize);
            WireUp();
        }
        public void WireUp()
        {
            TeamsComboBox.DataSource = null;

            TeamsComboBox.DataSource = availableTeams;
            TeamsComboBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;

            PrizesListBox.DataSource = prizes;
            PrizesListBox.DisplayMember = "PrizeName";

            TeamsListBox.DataSource = null;

            TeamsListBox.DataSource = SelectedTeams;
            TeamsListBox.DisplayMember = "TeamName";

        }
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = (TeamModel)TeamsComboBox.SelectedItem;

            if (model != null)
            {
                SelectedTeams.Add(model);
                availableTeams.Remove(model);
                WireUp();
            }
        }
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm fm = new(this);
            fm.ShowDialog();
        }
        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel model = (TeamModel)TeamsListBox.SelectedItem;

            if (model != null)
            {
                SelectedTeams.Remove(model);
                availableTeams.Add(model);
                WireUp();
            }

        }
        private void DeletePrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel model = (PrizeModel)PrizesListBox.SelectedItem;

            if (model != null)
            {
                prizes.Remove(model);
                WireUp();
            }
        }
        public void TeamComplete(TeamModel team)
        {
            availableTeams.Add(team);
            WireUp();
        }
        private void CreateNewLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm fm = new(this);
            fm.ShowDialog();
        }
        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TournamentModel tournament = new()
                {
                    EntryFee = decimal.Parse(FeeValue.Text),
                    TournamentName = TournamentNameTextBox.Text,

                    EnteredTeams = SelectedTeams,
                    Prizes = prizes
                };

                TournamentLogic.CreateRound(tournament);
                caller.TournamentComplete(tournament);

                GlobalConfig.Connection.CreateTournament(tournament);
                Close();
                TournamentViewerForm fm = new(tournament);
                fm.ShowDialog(); 
            }
        }
        private bool ValidateForm()
        {
            string output = "";
            
            if (TournamentNameTextBox.Text.Length == 0)
            {
                output = "Enter a Tournament Name";
            }
            decimal fees = 0;
            if (!decimal.TryParse(FeeValue.Text, out fees))
            {
                output = "Enter a valid entry fee";
            }

            else if (fees < 0)
            {
                output = "Can't assign negative value to the fee!";
            }
            
            else if (SelectedTeams.Count < 2)
            {
                output = "You should enter at least two teams.";
            }

            if (output.Length > 0)
            {
                MessageBox.Show(output);
                return false;
            }

            return true;
        }
    }
}
