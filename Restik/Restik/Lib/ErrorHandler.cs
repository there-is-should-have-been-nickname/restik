using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Restik.Lib
{
    public static class ErrorHandler
    {
        public static string? GetSignInErrorMessage(string mail, string password, CheckBox checkbox)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                return "Поле почты не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return "Поле пароля не должно быть пустым";
            }

            if (!mail.Contains('@'))
            {
                return "Поле почты неверного формата";
            }

            if (checkbox.IsChecked == null || !(bool)checkbox.IsChecked)
            {
                return "Капча не пройдена";
            }
            return null;

        }

        public static string? GetSignUpErrorMessage(string mail, string password, string phone, string name, CheckBox checkbox)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                return "Поле почты не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return "Поле пароля не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                return "Поле телефона не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле имени не должно быть пустым";
            }

            if (!mail.Contains('@'))
            {
                return "Поле почты неверного формата";
            }

            if (checkbox.IsChecked == null || !(bool)checkbox.IsChecked)
            {
                return "Капча не пройдена";
            }
            return null;

        }

        public static string? GetComboBoxErrorMessage(string text, string entity)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return $"В выпадающем списке с {entity} не выбран элемент";
            } 
            return null;

        }

        public static string? GetUserErrorMessage(string mail, string password, string phone, string name, string type)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                return "Поле почты не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return "Поле пароля не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                return "Поле телефона не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле имени не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                return "В выпадающем списке с типами не выбран элемент";
            }

            if (!mail.Contains('@'))
            {
                return "Поле почты неверного формата";
            }

            return null;
        }

        public static string? GetHallErrorMessage(string name, string path)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле названия не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                return "Поле пути к файлу не должно быть пустым";
            }

            return null;
        }

        public static string? GetTableErrorMessage(string name, string hallName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле названия не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(hallName))
            {
                return "В выпадающем списке с залами не выбран элемент";
            }

            return null;
        }

        public static string? GetPlaceErrorMessage(string name, string price, string tableName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле названия не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(price))
            {
                return "Поле цены не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(tableName))
            {
                return "В выпадающем списке со столами не выбран элемент";
            }

            int value = 0;
            bool IsParsed = int.TryParse(price, out value);
            if (!IsParsed)
            {
                return "Цена не является числом";
            }

            return null;
        }

        public static string? GetEventErrorMessage(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                return "Поле типа не должно быть пустым";
            }

            return null;
        }

        public static string? GetCuisineErrorMessage(string name, string desc)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле названия не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(desc))
            {
                return "Поле описания не должно быть пустым";
            }

            return null;
        }

        public static string? GetDishErrorMessage(string name, string path, string cuisineName)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "Поле названия не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(path))
            {
                return "Поле пути к файлу не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(cuisineName))
            {
                return "В выпадающем списке с кухнями не выбран элемент";
            }

            return null;
        }

        public static string? GetPaymentErrorMessage(string bookingNumber)
        {
            if (string.IsNullOrWhiteSpace(bookingNumber))
            {
                return "Поле с номером брони не должно быть пустым";
            }

            long value = 0;
            bool IsParsed = long.TryParse(bookingNumber, out value);
            if (!IsParsed)
            {
                return "Бронь не является числом";
            }

            return null;
        }

        public static string? GetBookingErrorMessage(string dateStart, string longBooking, string placeLabel, string dishLabel)
        {
            if (string.IsNullOrWhiteSpace(dateStart))
            {
                return "Поле с датой не должно быть пустым";
            }

            if (string.IsNullOrWhiteSpace(longBooking))
            {
                return "Поле с продолжительностью не должно быть пустым";
            }

            if (placeLabel.Trim() == "Места:")
            {
                return "Поле с выбранными местами не должно быть пустым";
            }

            if (dishLabel.Trim() == "Блюда:")
            {
                return "Поле с выбранными блюдами не должно быть пустым";
            }

            DateTime outTime;
            bool IsParsed = DateTime.TryParse(dateStart, out outTime);
            if (!IsParsed)
            {
                return "Дата начала не является датой";
            }

            long value = 0;
            bool IsParsed2 = long.TryParse(longBooking, out value);
            if (!IsParsed2)
            {
                return "Продолжительность не является числом";
            }

            return null;
        }
    }
}
