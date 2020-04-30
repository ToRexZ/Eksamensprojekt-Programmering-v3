using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamensprojekt_Programmering_v2
{
    public partial class TeamCreatorForm : Form
    {
        //det her er en liste af spillere. 
        List<Player> lstOfPlayers = new List<Player>();

        List<Player> lstOfTeamMembers = new List<Player>();

        

        public TeamCreatorForm()
        {
            InitializeComponent();
        }
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            if (ValidName())
            {
                Player player = new Player
                {
                    FirstName = FirstToUpper(txtFirstName.Text),
                    LastName = FirstToUpper(txtLastName.Text)
                };

                lstOfPlayers.Add(player);

                txtFirstName.Text = null;
                txtLastName.Text = null;


                string tempName = PrintName(lstOfPlayers[lstOfPlayers.Count - 1]);
                cmbPlayers.Items.Add(tempName);
                
                cmbPlayers.SelectedIndex = cmbPlayers.FindStringExact(tempName);
            } 
        }

        public string FirstToUpper(string input)
        {
            if (input == null)
                return null;

            if (input.Length > 1)
                return char.ToUpper(input[0]) + input.Substring(1);
            return input.ToUpper();
        }

        private bool ValidName()
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Plese fill out the name of the Player.");
                return false;
            }
                

            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("The name may only contain letters.");
                return false;
            }

            if (cmbPlayers.Items.Contains(FirstToUpper(txtFirstName.Text) + " " + FirstToUpper(txtLastName.Text)))
            {
                MessageBox.Show("The Player already excists.");
                return false;
            }
               
            
            return true;
        }

        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            if (ValidAddition())
            {
                lsbTeamMembers.Items.Add(PrintName(lstOfPlayers[cmbPlayers.SelectedIndex]));
                lstOfTeamMembers.Add(lstOfPlayers[cmbPlayers.SelectedIndex]);
            }
            else
                MessageBox.Show("The player is already in the team.");

        }

        private bool ValidAddition()
        {
            if (cmbPlayers.SelectedItem == null)
                return false;
            if (lsbTeamMembers.Items.Contains(cmbPlayers.SelectedItem))
                return false;


            return true;
            
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            if (ValidTeam())
            {
                this.Hide();
                Team team = new Team { TeamName = txtTeamName.Text, TeamMembers = lstOfTeamMembers };
                TournamentCreator tournamentCreator = new TournamentCreator(team);
                tournamentCreator.Show();
                
            }
            else
                MessageBox.Show("Please add players to the team, and give the team a name.");

        }

        private bool ValidTeam()
        {
            if (txtTeamName.Text == "")
                return false;
            if (lstOfTeamMembers.Count == 0)
                return false;
            return true;
        }

        public int clickCount = 0;

        private void btnTest_Click(object sender, EventArgs e)
        {
            switch (clickCount)
            {
                case 0:
                    txtFirstName.Text = "victor";
                    txtLastName.Text = "risager";
                    txtTeamName.Text = "Test";
                    clickCount++;
                    break;
                case 1:
                    txtFirstName.Text = "jonas";
                    txtLastName.Text = "ellesgaard";
                    clickCount++;
                    break;
                case 2:
                    txtFirstName.Text = "michelle";
                    txtLastName.Text = "kristensen";
                    clickCount++;
                    break;
                case 3:
                    txtFirstName.Text = "Hans";
                    txtLastName.Text = "Pilgaard";
                    clickCount++;
                    break;
                default:
                    clickCount = 0;
                    break;
            }

        }

        private string PrintName(Player p)
        {
            return p.FirstName + " " + p.LastName;
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            int i = lsbTeamMembers.SelectedIndex;
            if (i > -1)
            {
                lstOfTeamMembers.RemoveAt(i);
                lsbTeamMembers.Items.RemoveAt(i);
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            int i = cmbPlayers.SelectedIndex;
            if (lstOfPlayers.Count != 0)
            {
                DialogResult dialogResult = new DialogResult();
                if (lstOfTeamMembers.Contains(lstOfPlayers[i]))
                {
                    dialogResult = MessageBox.Show("This player is in the team, delete?", "Validation", MessageBoxButtons.YesNo);
                }
                if(dialogResult == DialogResult.Yes)
                {
                    int j = lsbTeamMembers.FindStringExact(cmbPlayers.Text);
                    lsbTeamMembers.Items.RemoveAt(j);
                    lstOfTeamMembers.RemoveAt(j);
                }

                if (dialogResult == DialogResult.No)
                    return;

                lstOfPlayers.RemoveAt(i);
                cmbPlayers.Text = "";
                cmbPlayers.Items.RemoveAt(i);
                if (lstOfPlayers.Count() > 0)
                    cmbPlayers.SelectedIndex = lstOfPlayers.Count() - 1;
            }
        }
    }
}
