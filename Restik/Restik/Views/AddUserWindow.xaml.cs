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
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetUserErrorMessage(MailTextBox.Text,
                PasswordTextBox.Text, PhoneTextBox.Text, FullNameTextBox.Text, TypeComboBox.Text);

            if (errorMessage == null)
            {
                var NewUser = new User
                {
                    Type = TypeComboBox.Text,
                    FullName = FullNameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Mail = MailTextBox.Text,
                    Password = PasswordTextBox.Text
                };

                FuncHelper.AddOrUpdateItem<User>(DbManager.AddUser, NewUser, "Вы успешно добавили пользователя", this);
            } else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
            
        }
    }
}
