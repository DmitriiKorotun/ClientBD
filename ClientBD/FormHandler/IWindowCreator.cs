using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientBD.FormHandler
{
    public enum WindowType : int
    {
        COUNTRY = 0,
        FIELD = 1,
        PRODUCTION = 2,
        PRODUCTION_DATA = 3,
        PRODUCTION_TYPE = 4,
        PROPERTY_TYPE = 5,
        ROCK = 6,
        ROCK_TYPE = 7
    };

    interface IWindowCreator
    {
        Window CreateWindow(WindowType windowType);
    }
}
