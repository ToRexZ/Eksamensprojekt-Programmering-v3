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

        //Opretter en ny instans af en liste, med datatypen Player.
        List<Player> lstOfTeamMembers = new List<Player>();
        //ny instans af teamCreator Formen. 
        TournamentCreator tournamentCreator = new TournamentCreator();

        //constructoren for klassen TeamCreatorForm
        public TeamCreatorForm()
        {
            InitializeComponent();
            tournamentCreator.Hid += OnHide; //tilføjer funktionen onhide til hid eventet. 
        }

        //event for at klikke på create player.
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            //hvis navnet er godkendt
            if (ValidName())
            {
                //opret et nyt objekt af typen player.
                Player player = new Player
                {
                    //setter proportiesne for objektet til brugerens input
                    FirstName = FirstToUpper(txtFirstName.Text),
                    LastName = FirstToUpper(txtLastName.Text)
                };

                //tilføjer spilleren til listen
                lstOfPlayers.Add(player);

                //resetter textboxene.
                txtFirstName.Text = null;
                txtLastName.Text = null;


                //lagrer navnet det sammenlagte navn for spilleren i en midleritidig variabel.
                string tempName = PrintName(lstOfPlayers[lstOfPlayers.Count - 1]);

                //tilføjer navnet til comboboxen
                cmbPlayers.Items.Add(tempName);
                
                //selecter den spiller der lige er tilføjet i comboxen. 
                cmbPlayers.SelectedIndex = cmbPlayers.FindStringExact(tempName);
            } 
        }

        //En funktion til stort forbogstav. har et parameter, at typen string.
        public string FirstToUpper(string input)
        {
            //Hvis der ikke står noget, retuner
            if (input == null)
                return null;

            //hvis længden er større end en, ret forbogstavet.
            if (input.Length > 1)
                return char.ToUpper(input[0]) + input.Substring(1);
            //hvis det bare er et bogstav, returner det respektive store bogstav.
            return input.ToUpper();
        }

        
        /// <summary>
        ///Funktion til tjek af kvalitet af navn. 
        /// </summary>
        /// <returns>bool</returns>
        private bool ValidName()
        {
            //hvis brugeren ikke har skrevet et navn, giv fejlmeddelelse, og returner false.
            if (txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Plese fill out the name of the Player.");
                return false;
            }
                
            //hvis en char i inputtet ikke findes i alfabetet, fejlmeddelelse og returner false.
            if (!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$") || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("The name may only contain letters.");
                return false;
            }


            //Hvis spilleren allerede eksisterer, fejlmeddelse og retuner false.
            if (cmbPlayers.Items.Contains(FirstToUpper(txtFirstName.Text) + " " + FirstToUpper(txtLastName.Text)))
            {
                MessageBox.Show("The Player already excists.");
                return false;
            }
               
            //ellers returner true
            return true;
        }

        //event for tryk på Select Player.
        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            //tjek om tilføjelsen til holdet er godkendt.
            if (ValidAddition())
            {
                //tilføjer den markerede spiller til holdet, og listen af holdmedlemmer.
                lsbTeamMembers.Items.Add(PrintName(lstOfPlayers[cmbPlayers.SelectedIndex]));
                lstOfTeamMembers.Add(lstOfPlayers[cmbPlayers.SelectedIndex]);
            }
            //ikke sandt - fejlmeddelse.
            else
                MessageBox.Show("The player is already in the team.");

        }

        //funktion til tjek om tilføjelsen til holdet er godkendt.
        private bool ValidAddition()
        {
            //tjek om null - retuner false.
            if (cmbPlayers.SelectedItem == null)
                return false;
            //hvis spilleren allerede eksisterer i holdet, retuner false.
            if (lsbTeamMembers.Items.Contains(cmbPlayers.SelectedItem))
                return false;

            //ellers retuner true.
            return true;
            
        }
        
        //event for oprettelse af hold.
        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            //hvis kriterierne for et hold er godkendt.
            if (ValidTeam())
            {
                //skjul team creator formen.
                Hide();
                //opret et nyt objekt af Team, med referencen team. 
                Team team = new Team { TeamName = txtTeamName.Text, TeamMembers = lstOfTeamMembers };
                
                //Viser turneringsformen, samt giver holdet som argument til. 
                tournamentCreator.Show(team);
                //ryder holdoprettelsesformen, dog ryder den ikke spillerene.
                lstOfTeamMembers.Clear();
                lsbTeamMembers.Items.Clear();
            }
            //hvis ikke, fejlmeddelelse
            else
                MessageBox.Show("Please add players to the team, and give the team a name.");

        }

        //dette er en eventhandler, der bliver kørt når tournamentCreator formen skjules.
        private void OnHide(object sender, EventArgs e)
        {
            //her viser den så denne form.
            Show();
        }

        //funktion til tjek om holdet er godkendt.
        private bool ValidTeam()
        {
            //hvis null, false
            if (txtTeamName.Text == "")
                return false;
            //hvis tom, false
            if (lstOfTeamMembers.Count == 0)
                return false;
            //ellers true
            return true;
        }

        //opretter en public int.
        public int clickCount = 0;

        //eventhandler til btnTest.
        private void btnTest_Click(object sender, EventArgs e)
        {
            //udfylder 4 forskellige navne
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

        //returnerer navnet på en spiller som string.
        private string PrintName(Player p)
        {
            return p.FirstName + " " + p.LastName;
        }

        //knap til at fjerne en spiller på holdet.
        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            //hvis indexet for den valgte spiller er større end -1.
            int i = lsbTeamMembers.SelectedIndex;
            if (i > -1)
            {
                //fjern spilleren fra holdet
                lstOfTeamMembers.RemoveAt(i);
                lsbTeamMembers.Items.RemoveAt(i);
            }
        }

        //eventhanbdler på knap til slet spiller.
        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            
            int i = cmbPlayers.SelectedIndex;
            //hvis der er en spiller i listen
            if (lstOfPlayers.Count != 0)
            {
                //Opretter en ny dialogbox.
                DialogResult dialogResult = new DialogResult();
                //hvis holdet indeholder spilleren.
                if (lstOfTeamMembers.Contains(lstOfPlayers[i]))
                {
                    //spørg om brugeren er sikker på om de vil slette denne player.
                    dialogResult = MessageBox.Show("This player is in the team, delete?", "Validation", MessageBoxButtons.YesNo);
                }
                //hvis ja, fjern spilleren fra holdet
                if(dialogResult == DialogResult.Yes)
                {
                    int j = lsbTeamMembers.FindStringExact(cmbPlayers.Text);
                    lsbTeamMembers.Items.RemoveAt(j);
                    lstOfTeamMembers.RemoveAt(j);
                }

                //hvis nej, return.
                if (dialogResult == DialogResult.No)
                    return;

                //fjerner spilleren fra comboboxen, listen og sørger for at vise en tom combobox, hvis der ikke er flere spillere tilbage.
                lstOfPlayers.RemoveAt(i);
                cmbPlayers.Text = "";
                cmbPlayers.Items.RemoveAt(i);
                if (lstOfPlayers.Count() > 0)
                    cmbPlayers.SelectedIndex = lstOfPlayers.Count() - 1;
            }
        }
    }
}
