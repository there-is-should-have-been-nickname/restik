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
    /// Логика взаимодействия для UpdateUserWindow.xaml
    /// </summary>
    public partial class UpdateUserWindow : Window
    {
        User CurrentUser = new User();
        public UpdateUserWindow(string FullName)
        {
            InitializeComponent();
            CurrentUser = DbManager.GetUser(FullName);
            FillUserFields(CurrentUser);
        }

        private void FillUserFields(User user)
        {
            FullNameTextBox.Text = user.FullName;
            TypeComboBox.Text = user.Type;
            PhoneTextBox.Text = user.Phone;
            MailTextBox.Text = user.Mail;
            PasswordTextBox.Text = user.Password;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var UpdatedUser = new User
            {
                Id = CurrentUser.Id,
                Type = TypeComboBox.Text,
                FullName = FullNameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Mail = MailTextBox.Text,
                Password = PasswordTextBox.Text
            };

            DbManager.UpdateUser(UpdatedUser);
            MessageBox.Show("Вы успешно обновили пользователя");
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }
    }
}
