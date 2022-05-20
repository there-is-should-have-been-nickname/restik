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
    /// Логика взаимодействия для AddCuisineWindow.xaml
    /// </summary>
    public partial class AddCuisineWindow : Window
    {
        public AddCuisineWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var NewCuisine = new Cuisine
            {
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text
            };

            FuncHelper.AddItem<Cuisine>(DbManager.AddCuisine, NewCuisine, "Вы успешно добавили кухню", this);
        }
    }
}
