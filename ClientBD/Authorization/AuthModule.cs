using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.Authorization
{
    class AuthModule : IAuthModule
    {
        public bool CheckAuthData(string login, string pass)
        {
            var reader = new GetSendDataModule.PostgresModules.Postgres();
            var dbpass = reader.Read("SELECT password FROM \"Users\" WHERE login='" + login +  "';");
            return Encryption.Encryption.BCryptHandler.ValidatePassword(pass, dbpass);
        }
    }
}
