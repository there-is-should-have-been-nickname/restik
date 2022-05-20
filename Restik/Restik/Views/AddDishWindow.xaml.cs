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
    /// Логика взаимодействия для AddDishWindow.xaml
    /// </summary>
    public partial class AddDishWindow : Window
    {
        public AddDishWindow()
        {
            InitializeComponent();
            ViewHelper.FillCuisinesComboBox(CuisinesComboBox);
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
            var AddedCuisine = DbManager.GetCuisine(CuisinesComboBox.Text);

            var NewDish = new Dish
            {
                Name = NameTextBox.Text,
                ImagePath = PathTextBox.Text,
                CuisineId = AddedCuisine.Id,
                Cuisine = AddedCuisine
            };

            FuncHelper.AddItem<Dish>(DbManager.AddDish, NewDish, "Вы успешно добавили блюдо", this);
        }
    }
}
