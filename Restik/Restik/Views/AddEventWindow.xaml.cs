using Restik.Lib;
using Restik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restik.Views
{
    /// <summary>
    /// Логика взаимодействия для AddEventWindow.xaml
    /// </summary>
    public partial class AddEventWindow : Window
    {
        public AddEventWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetEventErrorMessage(TypeTextBox.Text);
            if (errorMessage == null)
            {
                var NewEvent = new Event
                {
                    Type = TypeTextBox.Text
                };

                FuncHelper.AddOrUpdateItem<Event>(DbManager.AddEvent, NewEvent, "Вы успешно добавили событие", this);
            } else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }
    }
}
