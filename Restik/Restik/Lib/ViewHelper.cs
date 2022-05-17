using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        public static ComboBoxItem GetComboBoxItem(string content)
        {
            var NewItem = new ComboBoxItem();
            NewItem.FontFamily = new FontFamily("Consolas");
            NewItem.FontSize = 14;
            NewItem.HorizontalContentAlignment = HorizontalAlignment.Center;
            NewItem.VerticalContentAlignment = VerticalAlignment.Center;
            NewItem.Content = content;
            return NewItem;
        }
    }
}
