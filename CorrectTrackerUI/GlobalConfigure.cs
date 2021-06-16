using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfigure
    {
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
