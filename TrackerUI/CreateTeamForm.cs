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
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfigure.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            //CreateSampleData();

            wireUpLists();

            callingForm = caller;

        }



        private void wireUpLists()
        {

            combobox_SelectTeamMember.DataSource = null;
            combobox_SelectTeamMember.DataSource = availableTeamMembers;
            combobox_SelectTeamMember.DisplayMember = "FullName";

            listbox_TeamMembersListBox.DataSource = null;
            listbox_TeamMembersListBox.DataSource = selectedTeamMembers;
            listbox_TeamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateSampleData()
        {
            

            availableTeamMembers.Add(new PersonModel { FirstName = "G", LastName = "A" });
            availableTeamMembers.Add(new PersonModel { FirstName = "T", LastName = "C" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "A", LastName = "B" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "D", LastName = "C" });

        }






        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = txt_FirstName.Text;
                p.LastName = txt_LastName.Text;
                p.EmailAddress = txt_Email.Text;
                p.CellphoneNumber = txt_Cellphone.Text;

                p = GlobalConfigure.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                wireUpLists();


                txt_FirstName.Text = "";
                txt_LastName.Text = "";
                txt_Email.Text = "";
                txt_Cellphone.Text = "";

            }
            else
            {
                MessageBox.Show("You need to fill in all fields");
            }








        }

        private bool ValidateForm()
        {
            if (txt_FirstName.Text.Length == 0)
            {
                return false;
            }

            if (txt_LastName.Text.Length == 0)
            {
                return false;
            }

            if (txt_Email.Text.Length == 0)
            {
                return false;
            }

            if (txt_Cellphone.Text.Length == 0)
            {
                return false;
            }


            return true;
        }

        private void btn_AddTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)combobox_SelectTeamMember.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                wireUpLists();
            }
            
        }


        private void btn_DeleteSelected_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)listbox_TeamMembersListBox.SelectedItem;

            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);

            wireUpLists();

        }



        private void btn_CreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = txt_TeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfigure.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();

            // TODO - If we aren't closing the form after creation, reset the form

        }

    }
}
