namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateTournamentLabel = new Label();
            TournamentNameLabel = new Label();
            TournamentNameTextBox = new TextBox();
            FeeLabel = new Label();
            FeeValue = new TextBox();
            SelectTeamLabel = new Label();
            TeamsComboBox = new ComboBox();
            CreateNewLabel = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            TeamsLabel = new Label();
            TeamsListBox = new ListBox();
            DeleteTeamButton = new Button();
            DeletePrizeButton = new Button();
            PrizesListBox = new ListBox();
            PrizesLabel = new Label();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            CreateTournamentLabel.AutoSize = true;
            CreateTournamentLabel.ForeColor = Color.CornflowerBlue;
            CreateTournamentLabel.Location = new Point(18, 9);
            CreateTournamentLabel.Margin = new Padding(9, 0, 9, 0);
            CreateTournamentLabel.Name = "CreateTournamentLabel";
            CreateTournamentLabel.Size = new Size(395, 60);
            CreateTournamentLabel.TabIndex = 2;
            CreateTournamentLabel.Text = "Create Tournament";
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.ForeColor = Color.CornflowerBlue;
            TournamentNameLabel.Location = new Point(18, 135);
            TournamentNameLabel.Margin = new Padding(9, 0, 9, 0);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(386, 60);
            TournamentNameLabel.TabIndex = 3;
            TournamentNameLabel.Text = "Tournament Name";
            // 
            // TournamentNameTextBox
            // 
            TournamentNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentNameTextBox.Location = new Point(35, 210);
            TournamentNameTextBox.Name = "TournamentNameTextBox";
            TournamentNameTextBox.Size = new Size(530, 65);
            TournamentNameTextBox.TabIndex = 4;
            // 
            // FeeLabel
            // 
            FeeLabel.AutoSize = true;
            FeeLabel.ForeColor = Color.CornflowerBlue;
            FeeLabel.Location = new Point(35, 311);
            FeeLabel.Margin = new Padding(9, 0, 9, 0);
            FeeLabel.Name = "FeeLabel";
            FeeLabel.Size = new Size(202, 60);
            FeeLabel.TabIndex = 5;
            FeeLabel.Text = "Entry Fee";
            // 
            // FeeValue
            // 
            FeeValue.BorderStyle = BorderStyle.FixedSingle;
            FeeValue.Location = new Point(249, 309);
            FeeValue.Name = "FeeValue";
            FeeValue.Size = new Size(185, 65);
            FeeValue.TabIndex = 6;
            FeeValue.Text = "0";
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.ForeColor = Color.CornflowerBlue;
            SelectTeamLabel.Location = new Point(35, 419);
            SelectTeamLabel.Margin = new Padding(9, 0, 9, 0);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(254, 60);
            SelectTeamLabel.TabIndex = 7;
            SelectTeamLabel.Text = "Select Team";
            // 
            // TeamsComboBox
            // 
            TeamsComboBox.FormattingEnabled = true;
            TeamsComboBox.Location = new Point(35, 500);
            TeamsComboBox.Name = "TeamsComboBox";
            TeamsComboBox.Size = new Size(530, 67);
            TeamsComboBox.TabIndex = 8;
            // 
            // CreateNewLabel
            // 
            CreateNewLabel.AutoSize = true;
            CreateNewLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateNewLabel.Location = new Point(393, 438);
            CreateNewLabel.Name = "CreateNewLabel";
            CreateNewLabel.Size = new Size(172, 41);
            CreateNewLabel.TabIndex = 9;
            CreateNewLabel.TabStop = true;
            CreateNewLabel.Text = "Create New";
            CreateNewLabel.LinkClicked += CreateNewLabel_LinkClicked;
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.ForeColor = Color.CornflowerBlue;
            AddTeamButton.Location = new Point(118, 611);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(316, 81);
            AddTeamButton.TabIndex = 14;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += AddTeamButton_Click;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.ForeColor = Color.CornflowerBlue;
            CreatePrizeButton.Location = new Point(118, 722);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(316, 81);
            CreatePrizeButton.TabIndex = 15;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // TeamsLabel
            // 
            TeamsLabel.AutoSize = true;
            TeamsLabel.ForeColor = Color.CornflowerBlue;
            TeamsLabel.Location = new Point(886, 57);
            TeamsLabel.Margin = new Padding(9, 0, 9, 0);
            TeamsLabel.Name = "TeamsLabel";
            TeamsLabel.Size = new Size(299, 60);
            TeamsLabel.TabIndex = 16;
            TeamsLabel.Text = "Teams/Players";
            // 
            // TeamsListBox
            // 
            TeamsListBox.FormattingEnabled = true;
            TeamsListBox.ItemHeight = 59;
            TeamsListBox.Location = new Point(886, 151);
            TeamsListBox.Name = "TeamsListBox";
            TeamsListBox.Size = new Size(458, 299);
            TeamsListBox.TabIndex = 17;
            // 
            // DeleteTeamButton
            // 
            DeleteTeamButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            DeleteTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteTeamButton.FlatStyle = FlatStyle.Flat;
            DeleteTeamButton.ForeColor = Color.CornflowerBlue;
            DeleteTeamButton.Location = new Point(1408, 151);
            DeleteTeamButton.Name = "DeleteTeamButton";
            DeleteTeamButton.Size = new Size(166, 93);
            DeleteTeamButton.TabIndex = 18;
            DeleteTeamButton.Text = "Delete";
            DeleteTeamButton.UseVisualStyleBackColor = true;
            DeleteTeamButton.Click += DeleteTeamButton_Click;
            // 
            // DeletePrizeButton
            // 
            DeletePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            DeletePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            DeletePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeletePrizeButton.FlatStyle = FlatStyle.Flat;
            DeletePrizeButton.ForeColor = Color.CornflowerBlue;
            DeletePrizeButton.Location = new Point(1408, 599);
            DeletePrizeButton.Name = "DeletePrizeButton";
            DeletePrizeButton.Size = new Size(166, 93);
            DeletePrizeButton.TabIndex = 21;
            DeletePrizeButton.Text = "Delete";
            DeletePrizeButton.UseVisualStyleBackColor = true;
            DeletePrizeButton.Click += DeletePrizeButton_Click;
            // 
            // PrizesListBox
            // 
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 59;
            PrizesListBox.Location = new Point(886, 599);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(458, 299);
            PrizesListBox.TabIndex = 20;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.ForeColor = Color.CornflowerBlue;
            PrizesLabel.Location = new Point(886, 505);
            PrizesLabel.Margin = new Padding(9, 0, 9, 0);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(138, 60);
            PrizesLabel.TabIndex = 19;
            PrizesLabel.Text = "Prizes";
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.ForeColor = Color.CornflowerBlue;
            CreateTournamentButton.Location = new Point(487, 611);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(316, 192);
            CreateTournamentButton.TabIndex = 22;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            CreateTournamentButton.Click += CreateTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeletePrizeButton);
            Controls.Add(PrizesListBox);
            Controls.Add(PrizesLabel);
            Controls.Add(DeleteTeamButton);
            Controls.Add(TeamsListBox);
            Controls.Add(TeamsLabel);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewLabel);
            Controls.Add(TeamsComboBox);
            Controls.Add(SelectTeamLabel);
            Controls.Add(FeeValue);
            Controls.Add(FeeLabel);
            Controls.Add(TournamentNameTextBox);
            Controls.Add(TournamentNameLabel);
            Controls.Add(CreateTournamentLabel);
            Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(9);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTournamentLabel;
        private Label TournamentNameLabel;
        private TextBox TournamentNameTextBox;
        private Label FeeLabel;
        private TextBox FeeValue;
        private Label SelectTeamLabel;
        private ComboBox TeamsComboBox;
        private LinkLabel CreateNewLabel;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private Label TeamsLabel;
        private ListBox TeamsListBox;
        private Button DeleteTeamButton;
        private Button DeletePrizeButton;
        private ListBox PrizesListBox;
        private Label PrizesLabel;
        private Button CreateTournamentButton;
    }
}