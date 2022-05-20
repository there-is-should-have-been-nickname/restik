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
    /// Логика взаимодействия для SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CapchaCheckbox.IsChecked)
            {
                var NewUser = new User
                {
                    Type = "user",
                    FullName = FullNameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Mail = MailTextBox.Text,
                    Password = PasswordTextBox.Text
                };

                FuncHelper.AddOrUpdateItem<User>(DbManager.AddUser, NewUser, "Вы успешно зарегистрировались", this, new MainWindow());

            } else
            {
                ViewHelper.ShowMessage("Не пройдена капча");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new MainWindow());
        }
    }
}
