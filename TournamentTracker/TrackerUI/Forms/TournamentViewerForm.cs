using System.ComponentModel;
using System.Data;
using TrackerLibrary;
using TrackerLibrary.AppLogic;
using TrackerLibrary.Models;
using static TrackerLibrary.AppLogic.TournamentLogic;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        int currRound = 1;
        private TournamentModel Tournament { get; set; }
        private readonly List<int> rounds = new();
        private List<MatchupModel> unplayedMatches = new();
        private List<MatchupModel> matches = new();
        private bool suppressMatchupEvent = false;

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            Tournament = tournamentModel;

            LoadRounds();
            LoadForm();
            SaveByes();
        }
        private void SaveByes()
        {
            foreach (MatchupModel m in matches)
            {
                if (m.Winner != null)
                {
                    GlobalConfig.Connection.UpdateMatchups(m);
                }
            }
        }
        private void LoadForm()
        {
            TournamentNameLabel.Text = Tournament.TournamentName;

            WireUpRoundsLists();
            WireUpMatchupLists();
            LoadMatchups();
            LoadMatchup();
        }
        private void LoadRounds()
        {
            int currRound = 1;
            rounds.Add(currRound);

            foreach (List<MatchupModel> round in Tournament.Rounds)
            {
                if (round.First().MatchupRound > currRound)
                {
                    currRound = round.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
        }
        private void WireUpRoundsLists()
        {
            RoundComboBox.DataSource = null;
            RoundComboBox.DataSource = rounds;
        }
        private void WireUpMatchupLists()
        {
            suppressMatchupEvent = true;
            if (UnplayedOnlyCheckBox.Checked)
            {
                MatchupListBox.DataSource = null;
                MatchupListBox.DataSource = unplayedMatches;
            }
            else
            {
                MatchupListBox.DataSource = null;
                MatchupListBox.DataSource = matches;
            }

            MatchupListBox.DisplayMember = "MatchupName";

            suppressMatchupEvent = false;
        }
        private void RoundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)RoundComboBox.SelectedItem == currRound)
            {
                Confirm.Visible = true; 
            }
            else
            {
                Confirm.Visible = false;
            }
            LoadMatchups();
            LoadMatchup();
        }
        private void LoadMatchups()
        {
            int roundCount = (int)RoundComboBox.SelectedItem;
            foreach (List<MatchupModel> round in Tournament.Rounds)
            {
                if (round.First().MatchupRound == roundCount)
                {
                    matches = round;
                }
            }

            unplayedMatches = matches.Where(x => x.Winner == null).ToList();

            WireUpMatchupLists();
        }
        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            if (m == null) return;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        Team1Label.Text = m.Entries[0].TeamCompeting.TeamName;
                        Team1ScoreValue.Text = m.Entries[0].Score.ToString();

                        Team2Label.Text = "<Bye>";
                        Team2ScoreValue.Text = "";
                    }
                    else
                    {
                        Team1Label.Text = "Not Set";
                        Team1ScoreValue.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        Team2Label.Text = m.Entries[1].TeamCompeting.TeamName;
                        Team2ScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        Team2Label.Text = "Not Set";
                        Team2ScoreValue.Text = "";
                    }
                }
            }
        }
        private bool ValidateForm()
        {
            string output = "";

            bool scoreValid = double.TryParse(Team1ScoreValue.Text, out double ScoreVal1);
            if (!scoreValid)
            {
                output = $"Enter a Valid Numeral for {Team1Label.Text} Score!";
            }

            scoreValid = double.TryParse(Team2ScoreValue.Text, out double ScoreVal2);
            if (!scoreValid)
            {
                output = $"Enter a Valid Numeral for {Team2Label.Text} Score!";
            }

            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;

            if (currRound < m.MatchupRound)
            {
                output = "Match TBA";
            }

            else if (m.Entries.Count == 1)
            {
                output = "Can't Score Against A Bye.";
            }

            int selectedRound = (int)RoundComboBox.SelectedItem;

            if (selectedRound < currRound)
            {
                output = "Round is over, can't apply changes";
            }

            if (output.Length > 0)
            {
                MessageBox.Show(output);
                return false;
            }

            return true;
        }
        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!suppressMatchupEvent)
            {
                LoadMatchup();
            }
        }
        private void ScoreButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;

                m.Entries[0].Score = double.Parse(Team1ScoreValue.Text);
                m.Entries[1].Score = double.Parse(Team2ScoreValue.Text);

                if (Score(m) == "Tie")
                {
                    MessageBox.Show("Application doesnt support ties yet.");
                    return;
                }

                GlobalConfig.Connection.UpdateMatchups(m);

                AdvanceWinner(m, Tournament);

                LoadMatchups();
            }
        }

        private void UnplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
            LoadMatchup();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (GetCurrRound(Tournament) <= currRound)
            {
                MessageBox.Show("Round isn't over yet!");
                return;
            }
            Confirm.Visible= false;
            currRound++;
            if (currRound < Tournament.Rounds.Count())
            {
                AlertPlayersNewRound(Tournament, currRound); 
            }
            else if (currRound == Tournament.Rounds.Count() + 1)
            {
                AlertWinner(Tournament, currRound);
            }
        }
    }
}
