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
    /// Логика взаимодействия для AddBookingWindow.xaml
    /// </summary>
    public partial class AddBookingWindow : Window
    {
        User CurrentUser = new User();
        public AddBookingWindow(User user)
        {
            InitializeComponent();
            CurrentUser = user;
            ViewHelper.FillHallsComboBox(HallsComboBox);
            ViewHelper.FillEventsComboBox(EventsComboBox);
            ViewHelper.FillCuisinesComboBox(CuisinesComboBox);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EventsComboBox.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new MainWindow());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Num = FuncHelper.GenerateNumber();
            var newBooking = new Booking()
            {
                Number = Num,
                DateStart = DateTime.Parse(DateStartTextBox.Text),
                DateEnd = DateTime.Parse(DateStartTextBox.Text).AddHours(Convert.ToDouble(LongTextBox.Text)),
                UserId = CurrentUser.Id,
                User = CurrentUser
            };

            var AddedEvent = DbManager.GetEvent(EventsComboBox.Text);

            if (AddedEvent != null)
            {
                newBooking.EventId = AddedEvent.Id;
                newBooking.Event = AddedEvent;
            }

            var ListPlaceNames = ViewHelper.GetPlaceNames(PlacesLabel.Text);
            newBooking.Places = DbManager.GetPlaces(ListPlaceNames);

            newBooking.NumberPlaces = newBooking.Places.Count;

            var ListDishesNames = ViewHelper.GetDishesNames(DishesLabel.Text);
            newBooking.Dishes = DbManager.GetDishes(ListDishesNames);

            FuncHelper.AddOrUpdateItem(DbManager.AddBooking, newBooking, "Вы успешно добавили бронь. Ваш номер: " + Num, this, new MainWindow());
        }

        private void HallsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Item = (sender as ComboBox).SelectedItem as ComboBoxItem;
            var HallName = Item.Content as string;

            var Tables = DbManager.GetTables(HallName);
            ViewHelper.FillTablesComboBox(TablesComboBox, Tables);
            PlacesWrapPanel.Children.Clear();
        }

        private void TablesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Item = (sender as ComboBox).SelectedItem as ComboBoxItem;

            if (Item != null)
            {
                var TableName = Item.Content as string;

                var Places = DbManager.GetPlaces(TableName);
                ViewHelper.DrawPlaces(PlacesWrapPanel, Places);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            foreach (var Child in PlacesWrapPanel.Children)
            {
                var button = Child as Button;

                if (button.IsEnabled)
                {
                    var PlaceName = (button.Content as string).Split('\n')[0];
                    var PlaceNumber = PlaceName.Remove(0, 1);

                    var Content = PlacesLabel.Text;
                    var index = Content.IndexOf(PlaceNumber);

                    if (button.Background == Brushes.ForestGreen)
                    {
                        if (index < 0)
                        {
                            PlacesLabel.Text += PlaceNumber + ", ";
                        }
                        
                    } else
                    {
                        if (index > 0)
                        {
                            Content = Content.Remove(index, PlaceNumber.Length + 2);
                            PlacesLabel.Text = Content;
                        }

                        
                    }
                }
                
                
            }
        }

        private void CuisinesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Item = (sender as ComboBox).SelectedItem as ComboBoxItem;
            var CuisineName = Item.Content as string;

            var Dishes = DbManager.GetDishes(CuisineName);
            ViewHelper.FillDishesComboBox(DishesComboBox, Dishes);
        }

        private void DishesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Item = (sender as ComboBox).SelectedItem as ComboBoxItem;

            if (Item != null)
            {
                var DishName = Item.Content as string;

                var Content = DishesLabel.Text;
                var index = Content.IndexOf(DishName);


                if (index < 0)
                {
                    DishesLabel.Text += DishName + ", ";
                } else
                {
                    Content = Content.Remove(index, DishName.Length + 2);
                    DishesLabel.Text = Content;
                }
            }
        }
    }
}
