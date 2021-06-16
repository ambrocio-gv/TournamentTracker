using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.model;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {

        private List<TeamModel> availableTeams = GlobalConfigure.Connection.GetTeam_All();
        private List<TeamModel> selectedTeams = new List<TeamModel>();
        
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();



        public CreateTournamentForm()
        {
            InitializeComponent();

            WireupLists();

        }

        private void WireupLists()
        {
            combobox_SelectTeam.DataSource = null;
            combobox_SelectTeam.DataSource = availableTeams;
            combobox_SelectTeam.DisplayMember = "TeamName";

            listbox_PlayerList.DataSource = null;
            listbox_PlayerList.DataSource = selectedTeams;
            listbox_PlayerList.DisplayMember = "TeamName";

            listbox_PrizeList.DataSource = null;
            listbox_PrizeList.DataSource = selectedPrizes;
            listbox_PrizeList.DisplayMember = "PlaceName";


        }

        private void btn_AddTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = ((TeamModel)combobox_SelectTeam.SelectedItem);

            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireupLists();
            }
        }

        private void btn_CreatePrize_Click(object sender, EventArgs e)
        {
            // Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();

        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form the prize models

            // Take the PrizeModel and put it into our list of selected prizes

            selectedPrizes.Add(model);
            WireupLists();
        }

        private void linklabel_CreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }
        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireupLists();
        }

        private void btn_DeleteSelectedPlayer_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)listbox_PlayerList.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                WireupLists();
            }
        }

        private void btn_DeleteSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)listbox_PrizeList.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireupLists();
            }


        }

        private void btn_CreateTournament_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(txt_EntryFee.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to tenter a valid Entry Fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Create tournament model

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = txt_TournamentName.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - Wire our Matchups

            TournamentLogic.CreateRounds(tm);


            // Create Tournament Entry
            // Create all of the prizes entries
            // Create all of team entries
            GlobalConfigure.Connection.CreateTournament(tm);


            





        }
    }
}
