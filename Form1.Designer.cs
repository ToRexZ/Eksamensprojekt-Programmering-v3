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
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(56, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(230, 38);
            this.Title.TabIndex = 0;
            this.Title.Text = "Team Creator";
            // 
            // lsbTeamMembers
            // 
            this.lsbTeamMembers.FormattingEnabled = true;
            this.lsbTeamMembers.ItemHeight = 16;
            this.lsbTeamMembers.Location = new System.Drawing.Point(63, 108);
            this.lsbTeamMembers.Name = "lsbTeamMembers";
            this.lsbTeamMembers.Size = new System.Drawing.Size(231, 420);
            this.lsbTeamMembers.TabIndex = 6;
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(346, 62);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(178, 32);
            this.TeamName.TabIndex = 2;
            this.TeamName.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(338, 97);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(199, 22);
            this.txtTeamName.TabIndex = 0;
            // 
            // CreatePlayer
            // 
            this.CreatePlayer.AutoSize = true;
            this.CreatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePlayer.Location = new System.Drawing.Point(332, 177);
            this.CreatePlayer.Name = "CreatePlayer";
            this.CreatePlayer.Size = new System.Drawing.Size(201, 32);
            this.CreatePlayer.TabIndex = 4;
            this.CreatePlayer.Text = "Create Player";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(333, 227);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(116, 25);
            this.FirstName.TabIndex = 6;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(333, 292);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(115, 25);
            this.LastName.TabIndex = 7;
            this.LastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(338, 320);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.Location = new System.Drawing.Point(338, 348);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(199, 47);
            this.btnCreatePlayer.TabIndex = 3;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // cmbPlayers
            // 
            this.cmbPlayers.Location = new System.Drawing.Point(338, 483);
            this.cmbPlayers.Name = "cmbPlayers";
            this.cmbPlayers.Size = new System.Drawing.Size(199, 24);
            this.cmbPlayers.TabIndex = 4;
            // 
            // btnSelectPlayer
            // 
            this.btnSelectPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPlayer.Location = new System.Drawing.Point(338, 513);
            this.btnSelectPlayer.Name = "btnSelectPlayer";
            this.btnSelectPlayer.Size = new System.Drawing.Size(199, 64);
            this.btnSelectPlayer.TabIndex = 5;
            this.btnSelectPlayer.Text = "Add Player";
            this.btnSelectPlayer.UseVisualStyleBackColor = true;
            this.btnSelectPlayer.Click += new System.EventHandler(this.btnSelectPlayer_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.Location = new System.Drawing.Point(587, 403);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(140, 174);
            this.btnCreateTeam.TabIndex = 7;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // ChoosePlayer
            // 
            this.ChoosePlayer.AutoSize = true;
            this.ChoosePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePlayer.Location = new System.Drawing.Point(332, 448);
            this.ChoosePlayer.Name = "ChoosePlayer";
            this.ChoosePlayer.Size = new System.Drawing.Size(214, 32);
            this.ChoosePlayer.TabIndex = 12;
            this.ChoosePlayer.Text = "Choose Player";
            // 
            // TeamMembers
            // 
            this.TeamMembers.AutoSize = true;
            this.TeamMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMembers.Location = new System.Drawing.Point(58, 80);
            this.TeamMembers.Name = "TeamMembers";
            this.TeamMembers.Size = new System.Drawing.Size(162, 25);
            this.TeamMembers.TabIndex = 13;
            this.TeamMembers.Text = "Team Members";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(338, 255);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(587, 177);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 150);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Test - fill out names";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlayer.Location = new System.Drawing.Point(63, 534);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(231, 43);
            this.btnRemovePlayer.TabIndex = 15;
            this.btnRemovePlayer.Text = "Remove Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // TeamCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(752, 608);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
    }
}

