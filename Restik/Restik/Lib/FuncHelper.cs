using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
