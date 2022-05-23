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
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(UsersComboBox.Text, "пользователями");

            if (errorMessage == null) {
                FuncHelper.DeleteItem(DbManager.DeleteUser, ViewHelper.FillUsersComboBox, UsersComboBox, "Вы успешно удалили пользователя");
            } else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(UsersComboBox.Text, "пользователями");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdateUserWindow(UsersComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddHallWindow());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(HallsComboBox.Text, "залами");

            if (errorMessage == null)
            {
                FuncHelper.DeleteItem(DbManager.DeleteHall, ViewHelper.FillHallsComboBox, HallsComboBox, "Вы успешно удалили зал");
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(HallsComboBox.Text, "залами");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdateHallWindow(HallsComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddTableWindow());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(TablesComboBox.Text, "столами");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdateTableWindow(TablesComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(TablesComboBox.Text, "столами");

            if (errorMessage == null)
            {
                FuncHelper.DeleteItem(DbManager.DeleteTable, ViewHelper.FillTablesComboBox, TablesComboBox, "Вы успешно удалили стол");
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddPlaceWindow());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(PlacesComboBox.Text, "местами");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdatePlaceWindow(PlacesComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(PlacesComboBox.Text, "местами");

            if (errorMessage == null)
            {
                FuncHelper.DeleteItem(DbManager.DeletePlace, ViewHelper.FillPlacesComboBox, PlacesComboBox, "Вы успешно удалили место");
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddEventWindow());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(EventsComboBox.Text, "событиями");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdateEventWindow(EventsComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(EventsComboBox.Text, "событиями");

            if (errorMessage == null)
            {
                FuncHelper.DeleteItem(DbManager.DeleteEvent, ViewHelper.FillEventsComboBox, EventsComboBox, "Вы успешно удалили событие");
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddCuisineWindow());
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(CuisinesComboBox.Text, "кухнями");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdateCuisineWindow(CuisinesComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(CuisinesComboBox.Text, "кухнями");

            if (errorMessage == null)
            {
                FuncHelper.DeleteItem(DbManager.DeleteCuisine, ViewHelper.FillCuisinesComboBox, CuisinesComboBox, "Вы успешно удалили кухню");
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddDishWindow());
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(DishesComboBox.Text, "блюдами");

            if (errorMessage == null)
            {
                ViewHelper.WindowsInteract(this, new UpdateDIshWindow(DishesComboBox.Text));
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetComboBoxErrorMessage(DishesComboBox.Text, "блюдами");

            if (errorMessage == null)
            {
                FuncHelper.DeleteItem(DbManager.DeleteDish, ViewHelper.FillDishesComboBox, DishesComboBox, "Вы успешно удалили блюдо");
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }
    }
}
