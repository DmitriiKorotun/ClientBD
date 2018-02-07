using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClientBD.GetSendDataModule
{
    class ConnectionStringsHandler : Interfaces.IConnectionStringsHandler
    {
        public string GetConnectionStringByName(string name)
        {
            string returnValue = null;

            var connectionString =
                GetConnectionStringByNameFromConfig(name);

            returnValue = connectionString ?? throw new Exception();

            return returnValue;
        }

        ConnectionStringSettingsCollection GetConnectionStringsCollection()
        {
            ConnectionStringSettingsCollection collection = null;

            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
                collection = settings;

            return collection;
        }

        string GetConnectionStringByNameFromConfig(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
