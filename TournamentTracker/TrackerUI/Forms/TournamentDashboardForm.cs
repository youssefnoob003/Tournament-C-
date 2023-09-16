using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerUI.Requesters;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form, ICreateTournamentRequester
    {
        readonly List<TournamentModel> tournamentModels = GlobalConfig.Connection.GetTournamentsAll();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUp();
        }

        private void WireUp()
        {
            TournamentsComboBox.DataSource = null;
            TournamentsComboBox.DataSource = tournamentModels;
            TournamentsComboBox.DisplayMember = "TournamentName";
        }

        private void TournamentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm fm = new(this);
            fm.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)TournamentsComboBox.SelectedItem;
            TournamentViewerForm fm = new(tm);
            fm.Show();
            
        }

        public void TournamentComplete(TournamentModel tournament)
        {
            tournamentModels.Add(tournament);
            WireUp();
        }
    }
}
