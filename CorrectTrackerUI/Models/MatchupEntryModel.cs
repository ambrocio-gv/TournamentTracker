using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.model
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        /// 
        public int TeamCompetingId { get; set; }

        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from the winner.
        /// </summary>`
        public MatchupModel ParentMatchup { get; set; }
    }
}
