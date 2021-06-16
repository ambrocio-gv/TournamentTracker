using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.model
{
    public class TeamModel
    {

        public TeamModel()
        {

        }

        public int Id { get; set; }

        public string TeamName { get; set; }


        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();





    }
}
