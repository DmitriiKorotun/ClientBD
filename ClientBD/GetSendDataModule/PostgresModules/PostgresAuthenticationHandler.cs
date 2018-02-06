using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.GetSendDataModule.PostgresModules
{
    class PostgresAuthenticationHandler : Interfaces.IAuthenticationHandler
    {
        public bool CheckLoginPass(string login, string password)
        {
            var connStringHandler = new ConnectionStringsHandler();

            var connectionString = 
                connStringHandler.GetConnectionStringByName("PostgresSSPI");

            return true;
        }
    }
}
