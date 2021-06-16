using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
#pragma warning disable CS1526 // A new expression requires (), [], or {} after type
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
#pragma warning restore CS1526 // A new expression requires (), [], or {} after type

        public string TeamName { get; set; }




    }
}
