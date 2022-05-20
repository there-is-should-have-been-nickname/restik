using Restik.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Restik.Lib
{
    public static class FuncHelper
    {
        public static void DeleteItem(Action<string> DbDeleteMethod, Action<ComboBox> ViewMethod, ComboBox ViewComboBox, string MessageText)
        {
            DbDeleteMethod.Invoke(ViewComboBox.Text);
            ViewHelper.ShowMessage(MessageText);
            ViewMethod.Invoke(ViewComboBox);
        }

        public static void AddOrUpdateItem<T>(Action<T> DbAddMethod, T Item, string MessageText, Window WindowClose)
        {
            DbAddMethod.Invoke(Item);
            ViewHelper.ShowMessage(MessageText);
            ViewHelper.WindowsInteract(WindowClose, new AdminWindow());
        }

        public static void AddOrUpdateItem<T>(Action<T> DbAddMethod, T Item, string MessageText, Window WindowClose, Window WindowOpen)
        {
            DbAddMethod.Invoke(Item);
            ViewHelper.ShowMessage(MessageText);
            ViewHelper.WindowsInteract(WindowClose, WindowOpen);
        }

        public static string GenerateNumber()
        {
            var rand = new Random();
            var number = "";

            for (int i = 0; i < 9; ++i)
            {
                number += rand.Next(0, 9).ToString();
            }

            return number;
        }
    }
}
