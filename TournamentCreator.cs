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
        private Team t = new Team();
        

        public TournamentCreator(Team tempTeam)
        {
            InitializeComponent();
            t = tempTeam;
        }

        

        private void TournamentCreator_Shown(object sender, EventArgs e)
        {
            lsbTestTeam.Items.Add("Team: " + t.TeamName);
            foreach (var item in t.TeamMembers)
            {
                lsbTestTeam.Items.Add(item.FirstName + " " + item.LastName);
            }
        }
    }
}
