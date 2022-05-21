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
    /// Логика взаимодействия для AddPaymentWindow.xaml
    /// </summary>
    public partial class AddPaymentWindow : Window
    {
        User CurrentUser = new User();
        Payment CurrentPayment = new Payment();
        public AddPaymentWindow(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new CashierWindow(CurrentUser));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var Booking = DbManager.GetBooking(BookingNumberTextBox.Text);
            CurrentPayment = DbManager.GetPayment(Booking.Id);
            CostLabel.Content = "С вас " + CurrentPayment.Cost + " руб.";
            PayButton.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CurrentPayment.UserId = CurrentUser.Id;
            CurrentPayment.User = CurrentUser;
            CurrentPayment.IsPaid = true;

            FuncHelper.AddOrUpdateItem(DbManager.UpdatePayment, CurrentPayment, "Вы успешно оплатили бронь", this, new CashierWindow(CurrentUser));
        }
    }
}
