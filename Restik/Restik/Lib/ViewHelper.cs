using Microsoft.Win32;
using Restik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Restik.Lib
{
    public static class ViewHelper
    {
        public static void WindowsInteract(Window window)
        {
            window.Close();
        }

        public static void WindowsInteract(Window windowClose, Window windowShow)
        {
            windowShow.Show();
            windowClose.Close();
        }

        public static ComboBoxItem GetComboBoxItem(string content)
        {
            var NewItem = new ComboBoxItem();
            NewItem.FontFamily = new FontFamily("Consolas");
            NewItem.FontSize = 14;
            NewItem.HorizontalContentAlignment = HorizontalAlignment.Center;
            NewItem.VerticalContentAlignment = VerticalAlignment.Center;
            NewItem.Content = content;
            return NewItem;
        }

        public static Button GetButtonItem(string content, SolidColorBrush color)
        {
            var NewItem = new Button();
            NewItem.FontFamily = new FontFamily("Consolas");
            NewItem.FontSize = 10;
            NewItem.Width = 40;
            NewItem.Height = 40;
            NewItem.Margin = new Thickness(5);
            NewItem.Background = color;

            if (color == Brushes.IndianRed)
            {
                NewItem.IsEnabled = false;
            }

            NewItem.HorizontalContentAlignment = HorizontalAlignment.Center;
            NewItem.VerticalContentAlignment = VerticalAlignment.Center;
            NewItem.Content = content;
            NewItem.Click += new RoutedEventHandler(ButtonClick);
            return NewItem;
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button.IsEnabled)
            {
                button.Background = button.Background == Brushes.Gray ? Brushes.ForestGreen : Brushes.Gray;
            }
        }

        public static void FillUsersComboBox(ComboBox UsersComboBox)
        {
            UsersComboBox.Items.Clear();
            foreach (var User in DbManager.GetUsers())
            {
                var NewItem = GetComboBoxItem(User.FullName);
                UsersComboBox.Items.Add(NewItem);
            }

        }

        public static void FillHallsComboBox(ComboBox HallsComboBox)
        {
            HallsComboBox.Items.Clear();
            foreach (var Hall in DbManager.GetHalls())
            {
                var NewItem = GetComboBoxItem(Hall.Name);
                HallsComboBox.Items.Add(NewItem);
            }

        }

        public static void FillTablesComboBox(ComboBox TablesComboBox)
        {
            TablesComboBox.Items.Clear();
            foreach (var Table in DbManager.GetTables())
            {
                var NewItem = GetComboBoxItem(Table.Name);
                TablesComboBox.Items.Add(NewItem);
            }

        }

        public static void FillTablesComboBox(ComboBox TablesComboBox, List<Models.Table> Tables)
        {
            TablesComboBox.Items.Clear();
            foreach (var Table in Tables)
            {
                var NewItem = GetComboBoxItem(Table.Name);
                TablesComboBox.Items.Add(NewItem);
            }

        }

        public static void FillBookingsComboBox(ComboBox BookingsComboBox)
        {
            BookingsComboBox.Items.Clear();
            foreach (var Book in DbManager.GetBookings())
            {
                var NewItem = GetComboBoxItem(Book.Number);
                BookingsComboBox.Items.Add(NewItem);
            }

        }

        public static void FillPlacesComboBox(ComboBox PlacesComboBox)
        {
            PlacesComboBox.Items.Clear();
            foreach (var Place in DbManager.GetPlaces())
            {
                var NewItem = GetComboBoxItem(Place.Name);
                PlacesComboBox.Items.Add(NewItem);
            }

        }

        public static void FillEventsComboBox(ComboBox EventsComboBox)
        {
            EventsComboBox.Items.Clear();
            foreach (var Event in DbManager.GetEvents())
            {
                var NewItem = GetComboBoxItem(Event.Type);
                EventsComboBox.Items.Add(NewItem);
            }

        }

        public static void FillCuisinesComboBox(ComboBox CuisinesComboBox)
        {
            CuisinesComboBox.Items.Clear();
            foreach (var Cuis in DbManager.GetCuisines())
            {
                var NewItem = GetComboBoxItem(Cuis.Name);
                CuisinesComboBox.Items.Add(NewItem);
            }

        }

        public static void FillDishesComboBox(ComboBox DishesComboBox)
        {
            DishesComboBox.Items.Clear();
            foreach (var Dish in DbManager.GetDishes())
            {
                var NewItem = GetComboBoxItem(Dish.Name);
                DishesComboBox.Items.Add(NewItem);
            }

        }

        public static void FillDishesComboBox(ComboBox DishesComboBox, List<Dish> Dishes)
        {
            DishesComboBox.Items.Clear();
            foreach (var Dish in Dishes)
            {
                var NewItem = GetComboBoxItem(Dish.Name);
                DishesComboBox.Items.Add(NewItem);
            }

        }

        public static void ShowDialog(TextBox textBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }

        public static void ShowMessage(string text)
        {
            MessageBox.Show(text);
        }

        public static void DrawPlaces(WrapPanel WrapPanel, List<Place> Places)
        {
            WrapPanel.Children.Clear();
            foreach (var Place in Places)
            {
                var color = Brushes.Gray;
                if (Place.Booking != null)
                {
                    color = Brushes.IndianRed;
                }

                var button = GetButtonItem("#" + Place.Name.Split(' ')[1] + "\n" + Place.Price.ToString() + " р.", color);
                WrapPanel.Children.Add(button);
            }
        }

        public static void DrawPlaces(WrapPanel WrapPanel, List<Place> Places, int BookingId)
        {
            WrapPanel.Children.Clear();
            foreach (var Place in Places)
            {
                var color = Brushes.Gray;
                if (Place.Booking != null)
                {
                    if (Place.BookingId == BookingId)
                    {
                        color = Brushes.ForestGreen;
                    } else
                    {
                        color = Brushes.IndianRed;
                    }
                    
                }

                var button = GetButtonItem("#" + Place.Name.Split(' ')[1] + "\n" + Place.Price.ToString() + " р.", color);
                WrapPanel.Children.Add(button);
            }
        }

        public static List<string> GetPlaceNames(string str)
        {
            var PlaceNumbers = str.Remove(0, 6).Split(", ").ToList();
            var Result = new List<string>();

            foreach (var Number in PlaceNumbers)
            {
                if (!string.IsNullOrWhiteSpace(Number))
                {
                    Result.Add("Место " + Number);
                }
            }
            return Result;
        }

        public static List<string> GetDishesNames(string str)
        {
            var DishNames = str.Remove(0, 6).Split(", ").ToList();
            var Result = new List<string>();

            foreach (var Name in DishNames)
            {
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    Result.Add(Name);
                }
            }
            return Result;
        }
    }
}
