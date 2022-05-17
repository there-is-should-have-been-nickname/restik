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
    /// Логика взаимодействия для AddPlaceWindow.xaml
    /// </summary>
    public partial class AddPlaceWindow : Window
    {
        public AddPlaceWindow()
        {
            InitializeComponent();
            FillHallsComboBox();
            FillBookingsComboBox();
        }

        private void FillHallsComboBox()
        {
            TablesComboBox.Items.Clear();
            foreach (var Table in DbManager.GetTables())
            {
                var NewItem = ViewHelper.GetComboBoxItem(Table.Name);
                TablesComboBox.Items.Add(NewItem);
            }

        }

        private void FillBookingsComboBox()
        {
            BookingsComboBox.Items.Clear();
            foreach (var Book in DbManager.GetBookings())
            {
                var NewItem = ViewHelper.GetComboBoxItem(Book.Number);
                BookingsComboBox.Items.Add(NewItem);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var AddedTable = DbManager.GetTable(TablesComboBox.Text);
            var AddedBooking = DbManager.GetBooking(BookingsComboBox.Text);

            var NewPlace = new Restik.Models.Place
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

            

            DbManager.AddPlace(NewPlace);
            MessageBox.Show("Вы успешно добавили место");
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BookingsComboBox.Text = "";
        }
    }
}
