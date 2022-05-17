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
            FillUsersComboBox();
            FillHallsComboBox();
            FillTablesComboBox();
        }

        private void FillUsersComboBox()
        {
            UsersComboBox.Items.Clear();
            foreach (var User in DbManager.GetUsers())
            {
                var NewItem = new ComboBoxItem();
                NewItem.FontFamily = new FontFamily("Consolas");
                NewItem.FontSize = 14;
                NewItem.HorizontalContentAlignment = HorizontalAlignment.Center;
                NewItem.VerticalContentAlignment = VerticalAlignment.Center;
                NewItem.Content = User.FullName;

                UsersComboBox.Items.Add(NewItem);
            }
            
        }

        private void FillHallsComboBox()
        {
            HallsComboBox.Items.Clear();
            foreach (var Hall in DbManager.GetHalls())
            {
                var NewItem = new ComboBoxItem();
                NewItem.FontFamily = new FontFamily("Consolas");
                NewItem.FontSize = 14;
                NewItem.HorizontalContentAlignment = HorizontalAlignment.Center;
                NewItem.VerticalContentAlignment = VerticalAlignment.Center;
                NewItem.Content = Hall.Name;

                HallsComboBox.Items.Add(NewItem);
            }

        }

        private void FillTablesComboBox()
        {
            TablesComboBox.Items.Clear();
            foreach (var Table in DbManager.GetTables())
            {
                var NewItem = new ComboBoxItem();
                NewItem.FontFamily = new FontFamily("Consolas");
                NewItem.FontSize = 14;
                NewItem.HorizontalContentAlignment = HorizontalAlignment.Center;
                NewItem.VerticalContentAlignment = VerticalAlignment.Center;
                NewItem.Content = Table.Name;

                TablesComboBox.Items.Add(NewItem);
            }

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
            FillUsersComboBox();
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
            FillHallsComboBox();
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
            FillTablesComboBox();
        }
    }
}
