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
    /// Логика взаимодействия для AddPlaceWindow.xaml
    /// </summary>
    public partial class AddPlaceWindow : Window
    {
        public AddPlaceWindow()
        {
            InitializeComponent();
            ViewHelper.FillTablesComboBox(TablesComboBox);
            ViewHelper.FillBookingsComboBox(BookingsComboBox);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var AddedTable = DbManager.GetTable(TablesComboBox.Text);
            var AddedBooking = DbManager.GetBooking(BookingsComboBox.Text);

            var NewPlace = new Place
            {
                Name = NameTextBox.Text,
                Price = Convert.ToInt32(PriceTextBox.Text),
                TableId = AddedTable.Id,
                Table = AddedTable,
            };

            if (AddedBooking != null)
            {
                NewPlace.Booking = AddedBooking;
                NewPlace.BookingId = AddedBooking.Id;
            }


            FuncHelper.AddOrUpdateItem<Place>(DbManager.AddPlace, NewPlace, "Вы успешно добавили место", this);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BookingsComboBox.Text = "";
        }
    }
}
