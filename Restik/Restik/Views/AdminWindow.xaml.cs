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
    }
}
