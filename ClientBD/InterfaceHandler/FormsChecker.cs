using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientBD.InterfaceHandler
{
    class FormsChecker
    {
        public bool IsWindowOK(Window window)
        {
            return CheckWindow(window);
        }

        bool CheckWindow(Window window)
        {
            var result = true;
            if (window is MainWindow)
                result = CheckWindow((MainWindow)window);
            return result;
        }

        bool CheckWindow(MainWindow form)
        {
            var isWindowOK = true;
            if (form.tb_login.Text == "" || form.pb_password.Password == "")
                isWindowOK = false;
            return isWindowOK;
        }
    }
}
