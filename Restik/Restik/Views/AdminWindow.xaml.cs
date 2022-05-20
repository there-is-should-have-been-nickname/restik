using Restik.Lib;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            ViewHelper.FillUsersComboBox(UsersComboBox);
            ViewHelper.FillHallsComboBox(HallsComboBox);
            ViewHelper.FillTablesComboBox(TablesComboBox);
            ViewHelper.FillPlacesComboBox(PlacesComboBox);
            ViewHelper.FillEventsComboBox(EventsComboBox);
            ViewHelper.FillCuisinesComboBox(CuisinesComboBox);
            ViewHelper.FillDishesComboBox(DishesComboBox);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new MainWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddUserWindow());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DbManager.DeleteUser(UsersComboBox.Text);
            MessageBox.Show("Вы успешно удалили пользователя");
            ViewHelper.FillUsersComboBox(UsersComboBox);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateUserWindow(UsersComboBox.Text));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddHallWindow());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DbManager.DeleteHall(HallsComboBox.Text);
            MessageBox.Show("Вы успешно удалили зал");
            ViewHelper.FillHallsComboBox(HallsComboBox);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateHallWindow(HallsComboBox.Text));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddTableWindow());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateTableWindow(TablesComboBox.Text));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DbManager.DeleteTable(TablesComboBox.Text);
            MessageBox.Show("Вы успешно удалили стол");
            ViewHelper.FillTablesComboBox(TablesComboBox);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddPlaceWindow());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdatePlaceWindow(PlacesComboBox.Text));
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            DbManager.DeletePlace(PlacesComboBox.Text);
            MessageBox.Show("Вы успешно удалили место");
            ViewHelper.FillPlacesComboBox(PlacesComboBox);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddEventWindow());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateEventWindow(EventsComboBox.Text));
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            DbManager.DeleteEvent(EventsComboBox.Text);
            MessageBox.Show("Вы успешно удалили событие");
            ViewHelper.FillEventsComboBox(EventsComboBox);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddCuisineWindow());
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateCuisineWindow(CuisinesComboBox.Text));
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            DbManager.DeleteCuisine(CuisinesComboBox.Text);
            MessageBox.Show("Вы успешно удалили кухню");
            ViewHelper.FillCuisinesComboBox(CuisinesComboBox);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddDishWindow());
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateDIshWindow(DishesComboBox.Text));
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            DbManager.DeleteDish(DishesComboBox.Text);
            MessageBox.Show("Вы успешно удалили блюдо");
            ViewHelper.FillDishesComboBox(DishesComboBox);
        }
    }
}
