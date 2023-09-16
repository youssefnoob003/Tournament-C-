namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            TournamentDashboardLabel = new Label();
            LoadLabel = new Label();
            TournamentsComboBox = new ComboBox();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentDashboardLabel.ForeColor = Color.CornflowerBlue;
            TournamentDashboardLabel.Location = new Point(169, 48);
            TournamentDashboardLabel.Margin = new Padding(9, 0, 9, 0);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(482, 60);
            TournamentDashboardLabel.TabIndex = 7;
            TournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadLabel
            // 
            LoadLabel.AutoSize = true;
            LoadLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LoadLabel.ForeColor = Color.CornflowerBlue;
            LoadLabel.Location = new Point(211, 150);
            LoadLabel.Margin = new Padding(9, 0, 9, 0);
            LoadLabel.Name = "LoadLabel";
            LoadLabel.Size = new Size(405, 46);
            LoadLabel.TabIndex = 8;
            LoadLabel.Text = "Load Existing Tournament";
            // 
            // TournamentsComboBox
            // 
            TournamentsComboBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentsComboBox.FormattingEnabled = true;
            TournamentsComboBox.Location = new Point(94, 218);
            TournamentsComboBox.Name = "TournamentsComboBox";
            TournamentsComboBox.Size = new Size(610, 53);
            TournamentsComboBox.TabIndex = 9;
            TournamentsComboBox.SelectedIndexChanged += TournamentsComboBox_SelectedIndexChanged;
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LoadTournamentButton.ForeColor = Color.CornflowerBlue;
            LoadTournamentButton.Location = new Point(194, 315);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(408, 80);
            LoadTournamentButton.TabIndex = 26;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            LoadTournamentButton.Click += LoadTournamentButton_Click;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(142, 142, 142);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentButton.ForeColor = Color.CornflowerBlue;
            CreateTournamentButton.Location = new Point(194, 422);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(408, 80);
            CreateTournamentButton.TabIndex = 27;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            CreateTournamentButton.Click += CreateTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(TournamentsComboBox);
            Controls.Add(LoadLabel);
            Controls.Add(TournamentDashboardLabel);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLabel;
        private Label LoadLabel;
        private ComboBox TournamentsComboBox;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}