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
            return true;
        }


    }
}
