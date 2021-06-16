using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        ///TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database.
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns></returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.ID = 1;

            return model;
        }
    }
}
