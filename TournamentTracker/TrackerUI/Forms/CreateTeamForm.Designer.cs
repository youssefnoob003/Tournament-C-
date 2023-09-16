namespace TrackerUI
{
    partial class CreateTeamForm
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
            TeamNameTextBox = new TextBox();
            TeamNameLabel = new Label();
            CreateTeamLabel = new Label();
            SelectMemberLabel = new Label();
            TeamMembersComboBox = new ComboBox();
            AddMemberButton = new Button();
            AddNewMemberLabel = new Label();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastnameLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            CellphoneTextBox = new TextBox();
            CellphoneLabel = new Label();
            CreateMemberButton = new Button();
            TeamMembersListBox = new ListBox();
            DeleteMemberButton = new Button();
            CreateTeamButton = new Button();
            SuspendLayout();
            // 
            // TeamNameTextBox
            // 
            TeamNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            TeamNameTextBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameTextBox.Location = new Point(27, 141);
            TeamNameTextBox.Name = "TeamNameTextBox";
            TeamNameTextBox.Size = new Size(530, 51);
            TeamNameTextBox.TabIndex = 7;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameLabel.ForeColor = Color.CornflowerBlue;
            TeamNameLabel.Location = new Point(18, 75);
            TeamNameLabel.Margin = new Padding(9, 0, 9, 0);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(197, 46);
            TeamNameLabel.TabIndex = 6;
            TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTeamLabel.ForeColor = Color.CornflowerBlue;
            CreateTeamLabel.Location = new Point(18, 9);
            CreateTeamLabel.Margin = new Padding(9, 0, 9, 0);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(206, 46);
            CreateTeamLabel.TabIndex = 5;
            CreateTeamLabel.Text = "Create Team";
            // 
            // SelectMemberLabel
            // 
            SelectMemberLabel.AutoSize = true;
            SelectMemberLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            SelectMemberLabel.ForeColor = Color.CornflowerBlue;
            SelectMemberLabel.Location = new Point(27, 223);
            SelectMemberLabel.Margin = new Padding(9, 0, 9, 0);
            SelectMemberLabel.Name = "SelectMemberLabel";
            SelectMemberLabel.Size = new Size(333, 46);
            SelectMemberLabel.TabIndex = 8;
            SelectMemberLabel.Text = "Select Team member";
            // 
            // TeamMembersComboBox
            // 
            TeamMembersComboBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TeamMembersComboBox.FormattingEnabled = true;
            TeamMembersComboBox.Location = new Point(27, 294);
            TeamMembersComboBox.Name = "TeamMembersComboBox";
            TeamMembersComboBox.Size = new Size(530, 53);
            TeamMembersComboBox.TabIndex = 9;
            // 
            // AddMemberButton
            // 
            AddMemberButton.FlatAppearance.BorderColor = Color.Silver;
            AddMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            AddMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddMemberButton.FlatStyle = FlatStyle.Flat;
            AddMemberButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            AddMemberButton.ForeColor = Color.CornflowerBlue;
            AddMemberButton.Location = new Point(134, 380);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(316, 80);
            AddMemberButton.TabIndex = 15;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // AddNewMemberLabel
            // 
            AddNewMemberLabel.AutoSize = true;
            AddNewMemberLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewMemberLabel.ForeColor = Color.CornflowerBlue;
            AddNewMemberLabel.Location = new Point(48, 495);
            AddNewMemberLabel.Margin = new Padding(9, 0, 9, 0);
            AddNewMemberLabel.Name = "AddNewMemberLabel";
            AddNewMemberLabel.Size = new Size(262, 41);
            AddNewMemberLabel.TabIndex = 16;
            AddNewMemberLabel.Text = "Add New Member";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = Color.CornflowerBlue;
            FirstNameLabel.Location = new Point(69, 572);
            FirstNameLabel.Margin = new Padding(9, 0, 9, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(152, 41);
            FirstNameLabel.TabIndex = 17;
            FirstNameLabel.Text = "FirstName";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTextBox.Location = new Point(368, 572);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(339, 47);
            FirstNameTextBox.TabIndex = 18;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            LastNameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTextBox.Location = new Point(368, 622);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(339, 47);
            LastNameTextBox.TabIndex = 20;
            // 
            // LastnameLabel
            // 
            LastnameLabel.AutoSize = true;
            LastnameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LastnameLabel.ForeColor = Color.CornflowerBlue;
            LastnameLabel.Location = new Point(69, 622);
            LastnameLabel.Margin = new Padding(9, 0, 9, 0);
            LastnameLabel.Name = "LastnameLabel";
            LastnameLabel.Size = new Size(149, 41);
            LastnameLabel.TabIndex = 19;
            LastnameLabel.Text = "LastName";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTextBox.Location = new Point(368, 676);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(339, 47);
            EmailTextBox.TabIndex = 22;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.ForeColor = Color.CornflowerBlue;
            EmailLabel.Location = new Point(69, 676);
            EmailLabel.Margin = new Padding(9, 0, 9, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(177, 41);
            EmailLabel.TabIndex = 21;
            EmailLabel.Text = "EmailAdress";
            // 
            // CellphoneTextBox
            // 
            CellphoneTextBox.BorderStyle = BorderStyle.FixedSingle;
            CellphoneTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CellphoneTextBox.Location = new Point(368, 730);
            CellphoneTextBox.Name = "CellphoneTextBox";
            CellphoneTextBox.Size = new Size(339, 47);
            CellphoneTextBox.TabIndex = 24;
            // 
            // CellphoneLabel
            // 
            CellphoneLabel.AutoSize = true;
            CellphoneLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CellphoneLabel.ForeColor = Color.CornflowerBlue;
            CellphoneLabel.Location = new Point(69, 730);
            CellphoneLabel.Margin = new Padding(9, 0, 9, 0);
            CellphoneLabel.Name = "CellphoneLabel";
            CellphoneLabel.Size = new Size(262, 41);
            CellphoneLabel.TabIndex = 23;
            CellphoneLabel.Text = "CellphoneNumber";
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.FlatAppearance.BorderColor = Color.Silver;
            CreateMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            CreateMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateMemberButton.FlatStyle = FlatStyle.Flat;
            CreateMemberButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CreateMemberButton.ForeColor = Color.CornflowerBlue;
            CreateMemberButton.Location = new Point(134, 825);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(316, 80);
            CreateMemberButton.TabIndex = 25;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            CreateMemberButton.Click += CreateMemberButton_Click;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 59;
            TeamMembersListBox.Location = new Point(908, 141);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(688, 594);
            TeamMembersListBox.TabIndex = 27;
            // 
            // DeleteMemberButton
            // 
            DeleteMemberButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            DeleteMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteMemberButton.FlatStyle = FlatStyle.Flat;
            DeleteMemberButton.ForeColor = Color.CornflowerBlue;
            DeleteMemberButton.Location = new Point(1682, 141);
            DeleteMemberButton.Name = "DeleteMemberButton";
            DeleteMemberButton.Size = new Size(166, 93);
            DeleteMemberButton.TabIndex = 28;
            DeleteMemberButton.Text = "Delete";
            DeleteMemberButton.UseVisualStyleBackColor = true;
            DeleteMemberButton.Click += DeleteMemberButton_Click;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTeamButton.ForeColor = Color.CornflowerBlue;
            CreateTeamButton.Location = new Point(1082, 834);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(316, 71);
            CreateTeamButton.TabIndex = 29;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            CreateTeamButton.Click += CreateTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(CreateTeamButton);
            Controls.Add(DeleteMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(CreateMemberButton);
            Controls.Add(CellphoneTextBox);
            Controls.Add(CellphoneLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastnameLabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(AddNewMemberLabel);
            Controls.Add(AddMemberButton);
            Controls.Add(TeamMembersComboBox);
            Controls.Add(SelectMemberLabel);
            Controls.Add(TeamNameTextBox);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateTeamLabel);
            Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(9);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNameTextBox;
        private Label TeamNameLabel;
        private Label CreateTeamLabel;
        private Label SelectMemberLabel;
        private ComboBox TeamMembersComboBox;
        private Button AddMemberButton;
        private Label AddNewMemberLabel;
        private Label FirstNameLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private Label LastnameLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox CellphoneTextBox;
        private Label CellphoneLabel;
        private Button CreateMemberButton;
        private ListBox TeamMembersListBox;
        private Button DeleteMemberButton;
        private Button CreateTeamButton;
    }
}