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
    /// Логика взаимодействия для UpdateHallWindow.xaml
    /// </summary>
    public partial class UpdateHallWindow : Window
    {
        Hall CurrentHall = new Hall();
        public UpdateHallWindow(string Name)
        {
            InitializeComponent();
            CurrentHall = DbManager.GetHall(Name);
            FillHallFields(CurrentHall);
        }

        private void FillHallFields(Hall hall)
        {
            NameTextBox.Text = hall.Name;
            PathTextBox.Text = hall.ImagePath;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                PathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var NewHall = new Hall
            {
                Id = CurrentHall.Id,
                Name = NameTextBox.Text,
                ImagePath = PathTextBox.Text
            };

            DbManager.UpdateHall(NewHall);
            MessageBox.Show("Вы успешно изменили зал");
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }
    }
}
