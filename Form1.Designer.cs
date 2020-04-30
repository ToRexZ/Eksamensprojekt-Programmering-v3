namespace Eksamensprojekt_Programmering_v2
{
    partial class TeamCreatorForm
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
            this.Title = new System.Windows.Forms.Label();
            this.lsbTeamMembers = new System.Windows.Forms.ListBox();
            this.TeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.CreatePlayer = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.btnSelectPlayer = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.ChoosePlayer = new System.Windows.Forms.Label();
            this.TeamMembers = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(72, 28);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(193, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Team Creator";
            // 
            // lsbTeamMembers
            // 
            this.lsbTeamMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTeamMembers.FormattingEnabled = true;
            this.lsbTeamMembers.ItemHeight = 16;
            this.lsbTeamMembers.Location = new System.Drawing.Point(81, 133);
            this.lsbTeamMembers.Margin = new System.Windows.Forms.Padding(4);
            this.lsbTeamMembers.Name = "lsbTeamMembers";
            this.lsbTeamMembers.Size = new System.Drawing.Size(296, 516);
            this.lsbTeamMembers.TabIndex = 6;
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(491, 89);
            this.TeamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(141, 26);
            this.TeamName.TabIndex = 2;
            this.TeamName.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(431, 119);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(255, 22);
            this.txtTeamName.TabIndex = 0;
            // 
            // CreatePlayer
            // 
            this.CreatePlayer.AutoSize = true;
            this.CreatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayer.Location = new System.Drawing.Point(474, 218);
            this.CreatePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreatePlayer.Name = "CreatePlayer";
            this.CreatePlayer.Size = new System.Drawing.Size(158, 26);
            this.CreatePlayer.TabIndex = 4;
            this.CreatePlayer.Text = "Create Player";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(427, 261);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(96, 20);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(427, 324);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(95, 20);
            this.LastName.TabIndex = 7;
            this.LastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(431, 348);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(255, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.Location = new System.Drawing.Point(431, 378);
            this.btnCreatePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(255, 58);
            this.btnCreatePlayer.TabIndex = 3;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // cmbPlayers
            // 
            this.cmbPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayers.Location = new System.Drawing.Point(431, 594);
            this.cmbPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlayers.Name = "cmbPlayers";
            this.cmbPlayers.Size = new System.Drawing.Size(255, 24);
            this.cmbPlayers.TabIndex = 4;
            // 
            // btnSelectPlayer
            // 
            this.btnSelectPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPlayer.Location = new System.Drawing.Point(431, 631);
            this.btnSelectPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectPlayer.Name = "btnSelectPlayer";
            this.btnSelectPlayer.Size = new System.Drawing.Size(255, 79);
            this.btnSelectPlayer.TabIndex = 5;
            this.btnSelectPlayer.Text = "Add Player";
            this.btnSelectPlayer.UseVisualStyleBackColor = true;
            this.btnSelectPlayer.Click += new System.EventHandler(this.btnSelectPlayer_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.Location = new System.Drawing.Point(755, 496);
            this.btnCreateTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(180, 214);
            this.btnCreateTeam.TabIndex = 7;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // ChoosePlayer
            // 
            this.ChoosePlayer.AutoSize = true;
            this.ChoosePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePlayer.Location = new System.Drawing.Point(427, 551);
            this.ChoosePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChoosePlayer.Name = "ChoosePlayer";
            this.ChoosePlayer.Size = new System.Drawing.Size(168, 26);
            this.ChoosePlayer.TabIndex = 12;
            this.ChoosePlayer.Text = "Choose Player";
            // 
            // TeamMembers
            // 
            this.TeamMembers.AutoSize = true;
            this.TeamMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMembers.Location = new System.Drawing.Point(75, 98);
            this.TeamMembers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeamMembers.Name = "TeamMembers";
            this.TeamMembers.Size = new System.Drawing.Size(131, 20);
            this.TeamMembers.TabIndex = 13;
            this.TeamMembers.Text = "Team Members";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(431, 285);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(255, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(755, 218);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(180, 185);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Test - fill out names";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlayer.Location = new System.Drawing.Point(81, 657);
            this.btnRemovePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(297, 53);
            this.btnRemovePlayer.TabIndex = 15;
            this.btnRemovePlayer.Text = "Remove Selected Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayer.Location = new System.Drawing.Point(616, 544);
            this.btnDeletePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(70, 46);
            this.btnDeletePlayer.TabIndex = 16;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // TeamCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(967, 748);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.TeamMembers);
            this.Controls.Add(this.ChoosePlayer);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnSelectPlayer);
            this.Controls.Add(this.cmbPlayers);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.CreatePlayer);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.lsbTeamMembers);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamCreatorForm";
            this.ShowIcon = false;
            this.Text = "Team Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox lsbTeamMembers;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label CreatePlayer;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.Button btnSelectPlayer;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Label ChoosePlayer;
        private System.Windows.Forms.Label TeamMembers;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
    }
}

