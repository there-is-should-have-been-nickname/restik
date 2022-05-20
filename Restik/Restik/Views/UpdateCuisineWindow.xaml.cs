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
    /// Логика взаимодействия для UpdateCuisineWindow.xaml
    /// </summary>
    public partial class UpdateCuisineWindow : Window
    {
        Cuisine CurrentCuisine = new Cuisine();
        public UpdateCuisineWindow(string Name)
        {
            InitializeComponent();
            CurrentCuisine = DbManager.GetCuisine(Name);
            FillCuisineFields(CurrentCuisine);
        }

        private void FillCuisineFields(Cuisine cuisine)
        {
            NameTextBox.Text = cuisine.Name;
            DescriptionTextBox.Text = cuisine.Description;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var UpdatedCuisine = new Cuisine
            {
                Id = CurrentCuisine.Id,
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text
            };
            FuncHelper.AddOrUpdateItem<Cuisine>(DbManager.UpdateCuisine, UpdatedCuisine, "Вы успешно обновили кухню", this);
        }
    }
}
