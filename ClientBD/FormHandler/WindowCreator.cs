using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientBD.FormHandler
{
class WindowCreator : IWindowCreator
    {
        public Window CreateWindow(WindowType windowType)
        {
            return GetWindow(windowType);
        }

        Window GetWindow(WindowType windowType)
        {
            var window = new Window();
            switch (windowType)
            {
                case WindowType.COUNTRY:
                    window = GenerateCountry();
                    break;
                case WindowType.FIELD:
                    window = GenerateField();
                    break;
                case WindowType.PRODUCTION:
                    window = GenerateProduction();
                    break;
                case WindowType.PRODUCTION_DATA:
                    window = GenerateProductionData();
                    break;
                case WindowType.PRODUCTION_TYPE:
                    window = GenerateProductionType();
                    break;
                case WindowType.PROPERTY_TYPE:
                    window = GeneratePropertyType();
                    break;
                case WindowType.ROCK:
                    window = GenerateRock();
                    break;
                case WindowType.ROCK_TYPE:
                    window = GenerateRockType();
                    break;
                default:
                    throw new Exception();
            }
            return window;
        }

        Window GenerateCountry()
        {
            var window = new Window();
            return window;
        }

        Window GenerateField()
        {
            var window = new Window();
            return window;
        }

        Window GenerateProduction()
        {
            var window = new Window();
            return window;
        }

        Window GenerateProductionData()
        {
            var window = new Window();
            return window;
        }

        Window GenerateProductionType()
        {
            var window = new Window();
            return window;
        }

        Window GeneratePropertyType()
        {
            var window = new Window();
            return window;
        }

        Window GenerateRock()
        {
            var window = new Window();
            return window;
        }

        Window GenerateRockType()
        {
            var window = new Window();
            return window;
        }
    }
}
