using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restik.Lib
{
    public static class ViewHelper
    {
        public static void WindowsInteract(Window window)
        {
            window.Close();
        }

        public static void WindowsInteract(Window windowClose, Window windowShow)
        {
            windowShow.Show();
            windowClose.Close();
        }
    }
}
