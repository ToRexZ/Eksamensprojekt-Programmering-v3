using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Eksamensprojekt_Programmering_v2
{
    public partial class TournamentCreator : Form
    {
        //Opretter en event som instans af klassen Eventhandler, og navngiver den Hid.
        public event EventHandler Hid;

        //private Team t = new Team();
        private List<Team> tournamentTeams = new List<Team>();


        //constructoren for tournamentcreator klassen.
        public TournamentCreator()
        {
            InitializeComponent();
        }

        public void Show(Team t)
        {
            lsbTestTeam.Items.Clear();
            tournamentTeams.Add(t);
            Show();
            foreach (var team in tournamentTeams)
            {
                lsbTestTeam.Items.Add(team.TeamName);
            }

            if ((tournamentTeams.Count & 1) == 0)
            {
                //create match.
            }

        }
        
        /// <summary>
        /// public override function der overrider Hide. Dog kan en override ikke bruges, så vi laver en new.
        /// </summary>
        public new void Hide()
        {
            base.Hide(); //refererer til denne forms hide funktion. 
            Hid.Invoke(this, null); //påberåber hid eventhandleren med denne instans, og null. 
        }

        //event på knapklik.
        private void btnCreateNewTeam_Click(object sender, EventArgs e)
        {
            Hide(); //kalder hide funktionen.
        }
    }
}
