using Restik.Data;
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
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CapchaCheckbox.IsChecked)
            {
                var RequiredUser = DbManager.GetUser(MailTextBox.Text, PasswordTextBox.Text);

                if (RequiredUser == null)
                {
                    ViewHelper.ShowMessage("Пользователя с такими данными нет");
                }
                else if (RequiredUser.Type == "user")
                {
                    ViewHelper.WindowsInteract(this, new AddBookingWindow(RequiredUser));
                }
                else if (RequiredUser.Type == "cashier")
                {
                    ViewHelper.WindowsInteract(this, new CashierWindow(RequiredUser));
                }
                else if (RequiredUser.Type == "admin")
                {
                    ViewHelper.WindowsInteract(this, new AdminWindow());
                }
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
