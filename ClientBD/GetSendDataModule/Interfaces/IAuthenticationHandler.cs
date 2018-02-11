using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.GetSendDataModule.Interfaces
{
    interface IAuthenticationHandler
    {
        bool CheckLoginPass(string login, string password);
    }
}
