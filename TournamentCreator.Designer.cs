namespace Eksamensprojekt_Programmering_v2
{
    partial class TournamentCreator
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
            this.lsbTestTeam = new System.Windows.Forms.ListBox();
            this.lstRound = new System.Windows.Forms.ListBox();
            this.Round = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.btnSubmitScore = new System.Windows.Forms.Button();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblTeam2Winner = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblTeam1Winner = new System.Windows.Forms.Label();
            this.ScoreTeam1 = new System.Windows.Forms.Label();
            this.ScoreTeam2 = new System.Windows.Forms.Label();
            this.grbMatch = new System.Windows.Forms.GroupBox();
            this.Teams = new System.Windows.Forms.Label();
            this.btnCreateNewTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbTestTeam
            // 
            this.lsbTestTeam.FormattingEnabled = true;
            this.lsbTestTeam.ItemHeight = 20;
            this.lsbTestTeam.Location = new System.Drawing.Point(65, 67);
            this.lsbTestTeam.Name = "lsbTestTeam";
            this.lsbTestTeam.Size = new System.Drawing.Size(180, 484);
            this.lsbTestTeam.TabIndex = 0;
            // 
            // lstRound
            // 
            this.lstRound.FormattingEnabled = true;
            this.lstRound.ItemHeight = 20;
            this.lstRound.Location = new System.Drawing.Point(289, 67);
            this.lstRound.Name = "lstRound";
            this.lstRound.Size = new System.Drawing.Size(193, 484);
            this.lstRound.TabIndex = 1;
            // 
            // Round
            // 
            this.Round.AutoSize = true;
            this.Round.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round.Location = new System.Drawing.Point(285, 35);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(113, 32);
            this.Round.TabIndex = 2;
            this.Round.Text = "Round:";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.Location = new System.Drawing.Point(404, 35);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(30, 32);
            this.lblRoundNumber.TabIndex = 3;
            this.lblRoundNumber.Text = "x";
            // 
            // btnSubmitScore
            // 
            this.btnSubmitScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitScore.Location = new System.Drawing.Point(556, 585);
            this.btnSubmitScore.Name = "btnSubmitScore";
            this.btnSubmitScore.Size = new System.Drawing.Size(435, 86);
            this.btnSubmitScore.TabIndex = 4;
            this.btnSubmitScore.Text = "Submit Score";
            this.btnSubmitScore.UseVisualStyleBackColor = true;
            // 
            // txtScore1
            // 
            this.txtScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.Location = new System.Drawing.Point(820, 278);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(130, 34);
            this.txtScore1.TabIndex = 5;
            // 
            // txtScore2
            // 
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(820, 378);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(130, 34);
            this.txtScore2.TabIndex = 6;
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(552, 378);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(116, 32);
            this.lblTeam2.TabIndex = 7;
            this.lblTeam2.Text = "Team 2";
            // 
            // lblTeam2Winner
            // 
            this.lblTeam2Winner.AutoSize = true;
            this.lblTeam2Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2Winner.Location = new System.Drawing.Point(815, 350);
            this.lblTeam2Winner.Name = "lblTeam2Winner";
            this.lblTeam2Winner.Size = new System.Drawing.Size(81, 25);
            this.lblTeam2Winner.TabIndex = 8;
            this.lblTeam2Winner.Text = "Winner";
            this.lblTeam2Winner.Visible = false;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(552, 278);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(116, 32);
            this.lblTeam1.TabIndex = 9;
            this.lblTeam1.Text = "Team 1";
            // 
            // lblTeam1Winner
            // 
            this.lblTeam1Winner.AutoSize = true;
            this.lblTeam1Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1Winner.Location = new System.Drawing.Point(815, 250);
            this.lblTeam1Winner.Name = "lblTeam1Winner";
            this.lblTeam1Winner.Size = new System.Drawing.Size(81, 25);
            this.lblTeam1Winner.TabIndex = 10;
            this.lblTeam1Winner.Text = "Winner";
            this.lblTeam1Winner.Visible = false;
            // 
            // ScoreTeam1
            // 
            this.ScoreTeam1.AutoSize = true;
            this.ScoreTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeam1.Location = new System.Drawing.Point(743, 284);
            this.ScoreTeam1.Name = "ScoreTeam1";
            this.ScoreTeam1.Size = new System.Drawing.Size(76, 25);
            this.ScoreTeam1.TabIndex = 11;
            this.ScoreTeam1.Text = "Score:";
            // 
            // ScoreTeam2
            // 
            this.ScoreTeam2.AutoSize = true;
            this.ScoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeam2.Location = new System.Drawing.Point(743, 384);
            this.ScoreTeam2.Name = "ScoreTeam2";
            this.ScoreTeam2.Size = new System.Drawing.Size(76, 25);
            this.ScoreTeam2.TabIndex = 12;
            this.ScoreTeam2.Text = "Score:";
            // 
            // grbMatch
            // 
            this.grbMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMatch.Location = new System.Drawing.Point(530, 201);
            this.grbMatch.Name = "grbMatch";
            this.grbMatch.Size = new System.Drawing.Size(461, 272);
            this.grbMatch.TabIndex = 13;
            this.grbMatch.TabStop = false;
            this.grbMatch.Text = "Match";
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teams.Location = new System.Drawing.Point(59, 32);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(106, 32);
            this.Teams.TabIndex = 14;
            this.Teams.Text = "Teams";
            // 
            // btnCreateNewTeam
            // 
            this.btnCreateNewTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTeam.Location = new System.Drawing.Point(65, 585);
            this.btnCreateNewTeam.Name = "btnCreateNewTeam";
            this.btnCreateNewTeam.Size = new System.Drawing.Size(180, 86);
            this.btnCreateNewTeam.TabIndex = 15;
            this.btnCreateNewTeam.Text = "Create New Team";
            this.btnCreateNewTeam.UseVisualStyleBackColor = true;
            this.btnCreateNewTeam.Click += new System.EventHandler(this.btnCreateNewTeam_Click);
            // 
            // TournamentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1025, 736);
            this.Controls.Add(this.btnCreateNewTeam);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.ScoreTeam2);
            this.Controls.Add(this.ScoreTeam1);
            this.Controls.Add(this.lblTeam1Winner);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.lblTeam2Winner);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.btnSubmitScore);
            this.Controls.Add(this.lblRoundNumber);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.lstRound);
            this.Controls.Add(this.lsbTestTeam);
            this.Controls.Add(this.grbMatch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TournamentCreator";
            this.ShowIcon = false;
            this.Text = "Tournament Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTestTeam;
        private System.Windows.Forms.ListBox lstRound;
        private System.Windows.Forms.Label Round;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Button btnSubmitScore;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblTeam2Winner;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblTeam1Winner;
        private System.Windows.Forms.Label ScoreTeam1;
        private System.Windows.Forms.Label ScoreTeam2;
        private System.Windows.Forms.GroupBox grbMatch;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Button btnCreateNewTeam;
    }
}