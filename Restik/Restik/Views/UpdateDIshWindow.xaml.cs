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
    /// Логика взаимодействия для UpdateDIshWindow.xaml
    /// </summary>
    public partial class UpdateDIshWindow : Window
    {
        Dish CurrentDish = new Dish();
        public UpdateDIshWindow(string name)
        {
            InitializeComponent();
            CurrentDish = DbManager.GetDish(name);
            ViewHelper.FillCuisinesComboBox(CuisinesComboBox);
            FillDishFields(CurrentDish);
        }

        private void FillDishFields(Dish dish)
        {
            NameTextBox.Text = dish.Name;
            PathTextBox.Text = dish.ImagePath;
            CuisinesComboBox.Text = dish.Cuisine.Name;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewHelper.ShowDialog(PathTextBox);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetDishErrorMessage(NameTextBox.Text, PathTextBox.Text, CuisinesComboBox.Text);
            if (errorMessage == null)
            {
                var NewCuisine = DbManager.GetCuisine(CuisinesComboBox.Text);

                var UpdatedDish = new Dish
                {
                    Id = CurrentDish.Id,
                    Name = NameTextBox.Text,
                    ImagePath = PathTextBox.Text,
                    CuisineId = NewCuisine.Id,
                    Cuisine = NewCuisine
                };
                FuncHelper.AddOrUpdateItem<Dish>(DbManager.UpdateDish, UpdatedDish, "Вы успешно обновили блюдо", this);
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }
    }
}
