using Microsoft.Win32;
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
    /// Логика взаимодействия для AddHallWindow.xaml
    /// </summary>
    public partial class AddHallWindow : Window
    {
        public AddHallWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetHallErrorMessage(NameTextBox.Text, PathTextBox.Text);

            if (errorMessage == null)
            {
                var NewHall = new Hall
                {
                    Name = NameTextBox.Text,
                    ImagePath = PathTextBox.Text
                };

                FuncHelper.AddOrUpdateItem<Hall>(DbManager.AddHall, NewHall, "Вы успешно добавили зал", this);
            } else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewHelper.ShowDialog(PathTextBox);
        }
    }
}
