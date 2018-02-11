using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.Authorization
{
    class AuthModule : IAuthModule
    {
        public bool CheckAuthData(string login, string password)
        {
            var authHandler =
                new GetSendDataModule.PostgresModules.PostgresAuthenticationHandler();

            var result =
                authHandler.CheckLoginPass(login, password);

            return result;
        }
    }
}
