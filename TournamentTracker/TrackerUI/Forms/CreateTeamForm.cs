using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerUI.Requesters;
using System.Text.RegularExpressions;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> selectedMembers = new List<PersonModel>();
        private List<PersonModel> availableMembers = GlobalConfig.Connection.GetPerson_All();

        ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            callingForm = caller;
            InitializeComponent();
            WireUp();
        }
        public void WireUp()
        {
            TeamMembersComboBox.DataSource = null;

            TeamMembersComboBox.DataSource = availableMembers;
            TeamMembersComboBox.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

            TeamMembersListBox.DataSource = selectedMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidatePersonForm())
            {
                PersonModel model = new(
                    Id: 0,
                    FirstNameTextBox.Text,
                    LastNameTextBox.Text,
                    CellphoneTextBox.Text,
                    EmailTextBox.Text
                );
                selectedMembers.Add(model);
                WireUp();

                GlobalConfig.Connection.CreatePerson(model);

                FirstNameTextBox.Text = "";
                LastNameTextBox.Text = "";
                CellphoneTextBox.Text = "";
                EmailTextBox.Text = "";
            }
        }
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            bool isValid = Regex.IsMatch(email, pattern);

            return isValid;
        }
        public bool ValidatePersonForm()
        {
            string output = "";
            if (FirstNameTextBox.Text.Length == 0)
            {
                output = "Enter the first name!";
            }

            else if (LastNameTextBox.Text.Length == 0)
            {
                output = "Enter the last name!";
            }

            else if (EmailTextBox.Text.Length == 0)
            {
                output = "Enter the Email!";
            }
            else if (!ValidateEmail(EmailTextBox.Text))
            {
                output = "Enter a valid Email!";
            }
            else if (CellphoneTextBox.Text.Length == 0)
            {
                output = "Enter the cellphone number!";
            }

            if (output.Length > 0)
            {
                MessageBox.Show(output);
                return false;
            }
            return true;
        }
        public bool ValidateTeamForm()
        {
            string output = "";
            if (TeamNameTextBox.Text.Length == 0)
            {
                output = "Enter a Team Name!";
            }

            else if (selectedMembers.Count == 0)
            {
                output = "No team Members?";
            }

            if (output.Length > 0)
            {
                MessageBox.Show(output);
                return false;
            }
            return true;
        }
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersComboBox.SelectedItem;

            if (p != null)
            {
                availableMembers.Remove(p);
                selectedMembers.Add(p);
                WireUp();
            }
        }
        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)(TeamMembersListBox.SelectedItem);

            if (p != null)
            {
                availableMembers.Add(p);
                selectedMembers.Remove(p);
                WireUp();
            }
        }
        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            if (ValidateTeamForm())
            {
                TeamModel t = new();
                t.TeamName = TeamNameTextBox.Text;
                t.TeamMembers = selectedMembers;

                GlobalConfig.Connection.CreateTeam(t);
                callingForm.TeamComplete(t);
                Close(); 
            }
        }
    }
}
