using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.Authorization
{
    interface IAuthModule
    {
        bool CheckAuthData(string login, string pass);
    }
}
