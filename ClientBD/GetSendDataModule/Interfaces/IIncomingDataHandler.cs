﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.GetSendDataModule
{
    interface IIncomingDataHandler
    {
        OutcomeData ParseInfo(IncomingData data);
    }
}
