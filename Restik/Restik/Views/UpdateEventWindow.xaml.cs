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
    /// Логика взаимодействия для UpdateEventWindow.xaml
    /// </summary>
    public partial class UpdateEventWindow : Window
    {
        Event CurrentEvent = new Event();
        public UpdateEventWindow(string Type)
        {
            InitializeComponent();
            CurrentEvent = DbManager.GetEvent(Type);
            FillEventFields(CurrentEvent);
        }

        private void FillEventFields(Event event_)
        {
            TypeTextBox.Text = event_.Type;
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
                    Id = CurrentEvent.Id,
                    Type = TypeTextBox.Text
                };

                FuncHelper.AddOrUpdateItem<Event>(DbManager.UpdateEvent, NewEvent, "Вы успешно обновили событие", this);
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }
    }
}
