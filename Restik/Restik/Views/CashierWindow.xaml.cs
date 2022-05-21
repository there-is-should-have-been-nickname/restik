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
    /// Логика взаимодействия для CashierWindow.xaml
    /// </summary>
    public partial class CashierWindow : Window
    {
        User CurrentUser = new User();
        public CashierWindow(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            ViewHelper.FillBookingsComboBox(BookingsComboBox);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new MainWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AddPaymentWindow(CurrentUser));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new UpdateBookingWindow(BookingsComboBox.Text, CurrentUser));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FuncHelper.DeleteItem(DbManager.DeleteBooking, ViewHelper.FillBookingsComboBox, BookingsComboBox, "Вы успешно удалили бронь");
        }
    }
}
