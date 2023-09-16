namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TournamentLabel = new Label();
            TournamentNameLabel = new Label();
            RoundLabel = new Label();
            RoundComboBox = new ComboBox();
            UnplayedOnlyCheckBox = new CheckBox();
            MatchupListBox = new ListBox();
            Team1Label = new Label();
            Team1ScoreLabel = new Label();
            Team1ScoreValue = new TextBox();
            Team2ScoreValue = new TextBox();
            Team2ScoreLabel = new Label();
            Team2Label = new Label();
            VS = new Label();
            ScoreButton = new Button();
            Confirm = new Button();
            SuspendLayout();
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.ForeColor = Color.CornflowerBlue;
            TournamentLabel.Location = new Point(18, 9);
            TournamentLabel.Margin = new Padding(9, 0, 9, 0);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(268, 60);
            TournamentLabel.TabIndex = 0;
            TournamentLabel.Text = "Tournament:";
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.ForeColor = Color.CornflowerBlue;
            TournamentNameLabel.Location = new Point(288, 9);
            TournamentNameLabel.Margin = new Padding(9, 0, 9, 0);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(201, 60);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "<Name>";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.BackColor = Color.Transparent;
            RoundLabel.ForeColor = Color.CornflowerBlue;
            RoundLabel.Location = new Point(18, 120);
            RoundLabel.Margin = new Padding(9, 0, 9, 0);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(152, 60);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            // 
            // RoundComboBox
            // 
            RoundComboBox.FormattingEnabled = true;
            RoundComboBox.Location = new Point(182, 113);
            RoundComboBox.Name = "RoundComboBox";
            RoundComboBox.Size = new Size(457, 67);
            RoundComboBox.TabIndex = 3;
            RoundComboBox.SelectedIndexChanged += RoundComboBox_SelectedIndexChanged;
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.AutoSize = true;
            UnplayedOnlyCheckBox.BackColor = Color.Transparent;
            UnplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            UnplayedOnlyCheckBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            UnplayedOnlyCheckBox.ForeColor = Color.CornflowerBlue;
            UnplayedOnlyCheckBox.Location = new Point(29, 186);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(257, 50);
            UnplayedOnlyCheckBox.TabIndex = 4;
            UnplayedOnlyCheckBox.Text = "Unplayed Only";
            UnplayedOnlyCheckBox.UseVisualStyleBackColor = false;
            UnplayedOnlyCheckBox.CheckedChanged += UnplayedOnlyCheckBox_CheckedChanged;
            // 
            // MatchupListBox
            // 
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 59;
            MatchupListBox.Location = new Point(18, 264);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(654, 417);
            MatchupListBox.TabIndex = 5;
            MatchupListBox.SelectedIndexChanged += MatchupListBox_SelectedIndexChanged;
            // 
            // Team1Label
            // 
            Team1Label.AutoSize = true;
            Team1Label.BackColor = Color.Transparent;
            Team1Label.ForeColor = Color.CornflowerBlue;
            Team1Label.Location = new Point(684, 261);
            Team1Label.Margin = new Padding(9, 0, 9, 0);
            Team1Label.Name = "Team1Label";
            Team1Label.Size = new Size(223, 60);
            Team1Label.TabIndex = 6;
            Team1Label.Text = "<Team 1>";
            // 
            // Team1ScoreLabel
            // 
            Team1ScoreLabel.AutoSize = true;
            Team1ScoreLabel.BackColor = Color.Transparent;
            Team1ScoreLabel.ForeColor = Color.CornflowerBlue;
            Team1ScoreLabel.Location = new Point(684, 338);
            Team1ScoreLabel.Margin = new Padding(9, 0, 9, 0);
            Team1ScoreLabel.Name = "Team1ScoreLabel";
            Team1ScoreLabel.Size = new Size(132, 60);
            Team1ScoreLabel.TabIndex = 7;
            Team1ScoreLabel.Text = "Score";
            // 
            // Team1ScoreValue
            // 
            Team1ScoreValue.BorderStyle = BorderStyle.FixedSingle;
            Team1ScoreValue.Location = new Point(828, 336);
            Team1ScoreValue.Name = "Team1ScoreValue";
            Team1ScoreValue.Size = new Size(125, 65);
            Team1ScoreValue.TabIndex = 8;
            // 
            // Team2ScoreValue
            // 
            Team2ScoreValue.BorderStyle = BorderStyle.FixedSingle;
            Team2ScoreValue.Location = new Point(828, 613);
            Team2ScoreValue.Name = "Team2ScoreValue";
            Team2ScoreValue.Size = new Size(125, 65);
            Team2ScoreValue.TabIndex = 11;
            // 
            // Team2ScoreLabel
            // 
            Team2ScoreLabel.AutoSize = true;
            Team2ScoreLabel.BackColor = Color.Transparent;
            Team2ScoreLabel.ForeColor = Color.CornflowerBlue;
            Team2ScoreLabel.Location = new Point(684, 615);
            Team2ScoreLabel.Margin = new Padding(9, 0, 9, 0);
            Team2ScoreLabel.Name = "Team2ScoreLabel";
            Team2ScoreLabel.Size = new Size(132, 60);
            Team2ScoreLabel.TabIndex = 10;
            Team2ScoreLabel.Text = "Score";
            // 
            // Team2Label
            // 
            Team2Label.AutoSize = true;
            Team2Label.BackColor = Color.Transparent;
            Team2Label.ForeColor = Color.CornflowerBlue;
            Team2Label.Location = new Point(684, 538);
            Team2Label.Margin = new Padding(9, 0, 9, 0);
            Team2Label.Name = "Team2Label";
            Team2Label.Size = new Size(223, 60);
            Team2Label.TabIndex = 9;
            Team2Label.Text = "<Team 2>";
            // 
            // VS
            // 
            VS.AutoSize = true;
            VS.BackColor = Color.Transparent;
            VS.ForeColor = Color.CornflowerBlue;
            VS.Location = new Point(769, 440);
            VS.Margin = new Padding(9, 0, 9, 0);
            VS.Name = "VS";
            VS.Size = new Size(111, 60);
            VS.TabIndex = 12;
            VS.Text = "-VS-";
            // 
            // ScoreButton
            // 
            ScoreButton.FlatAppearance.BorderColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.ForeColor = Color.CornflowerBlue;
            ScoreButton.Location = new Point(955, 440);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(174, 81);
            ScoreButton.TabIndex = 13;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = true;
            ScoreButton.Click += ScoreButton_Click;
            // 
            // Confirm
            // 
            Confirm.FlatAppearance.BorderColor = Color.Silver;
            Confirm.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            Confirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            Confirm.FlatStyle = FlatStyle.Flat;
            Confirm.ForeColor = Color.CornflowerBlue;
            Confirm.Location = new Point(699, 105);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(410, 81);
            Confirm.TabIndex = 14;
            Confirm.Text = "Confirm Round";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 1055);
            Controls.Add(Confirm);
            Controls.Add(ScoreButton);
            Controls.Add(VS);
            Controls.Add(Team2ScoreValue);
            Controls.Add(Team2ScoreLabel);
            Controls.Add(Team2Label);
            Controls.Add(Team1ScoreValue);
            Controls.Add(Team1ScoreLabel);
            Controls.Add(Team1Label);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(RoundComboBox);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentNameLabel);
            Controls.Add(TournamentLabel);
            Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(9);
            Name = "TournamentViewerForm";
            Text = "Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLabel;
        private Label TournamentNameLabel;
        private Label RoundLabel;
        private ComboBox RoundComboBox;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox MatchupListBox;
        private Label Team1Label;
        private Label Team1ScoreLabel;
        private TextBox Team1ScoreValue;
        private TextBox Team2ScoreValue;
        private Label Team2ScoreLabel;
        private Label Team2Label;
        private Label VS;
        private Button ScoreButton;
        private Button Confirm;
    }
}