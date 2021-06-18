using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfigure
    {
        public const string PrizesFile = "PrizesModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentsFile = "TorunamentsModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";




        public static IDataConnection Connection { get; private set; }
        //public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                //TODO - Create SQL Connection properly
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            else if (db == DatabaseType.TextFile )
            {
                //TODO - Create Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }

        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


    }
}
