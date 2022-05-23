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
    /// Логика взаимодействия для UpdatePlaceWindow.xaml
    /// </summary>
    public partial class UpdatePlaceWindow : Window
    {
        Place CurrentPlace = new Place();
        public UpdatePlaceWindow(string name)
        {
            InitializeComponent();
            CurrentPlace = DbManager.GetPlace(name);
            ViewHelper.FillTablesComboBox(TablesComboBox);
            ViewHelper.FillBookingsComboBox(BookingsComboBox);
            FillPlaceFields(CurrentPlace);
        }
        private void FillPlaceFields(Place place)
        {
            NameTextBox.Text = place.Name;
            PriceTextBox.Text = place.Price.ToString();
            TablesComboBox.Text = place.Table.Name;
            if (place.Booking != null)
            {
                BookingsComboBox.Text = place.Booking.Number;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errorMessage = ErrorHandler.GetPlaceErrorMessage(NameTextBox.Text, PriceTextBox.Text, TablesComboBox.Text);
            if (errorMessage == null)
            {
                var NewTable = DbManager.GetTable(TablesComboBox.Text);

                var UpdatedPlace = new Place
                {
                    Id = CurrentPlace.Id,
                    Name = NameTextBox.Text,
                    Price = Convert.ToInt32(PriceTextBox.Text),
                    TableId = NewTable.Id,
                    Table = NewTable
                };

                if (!string.IsNullOrWhiteSpace(BookingsComboBox.Text))
                {
                    var NewBooking = DbManager.GetBooking(BookingsComboBox.Text);
                    UpdatedPlace.Booking = NewBooking;
                    UpdatedPlace.BookingId = NewBooking.Id;
                }
                else
                {
                    UpdatedPlace.Booking = null;
                }

                FuncHelper.AddOrUpdateItem<Place>(DbManager.UpdatePlace, UpdatedPlace, "Вы успешно обновили место", this);
            }
            else
            {
                ViewHelper.ShowMessage(errorMessage);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BookingsComboBox.Text = "";
        }
    }
}
