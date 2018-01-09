using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBD.InterfaceHandler
{
    class FieldHandler
    {
        public bool CheckString(string text)
        {
            var isOk = true;
            if (IsEmpty(text))
                isOk = false;
            return isOk;
        }

        private bool IsEmpty(string text)
        {
            return text == "" ? true : false;
        }
    }
}
