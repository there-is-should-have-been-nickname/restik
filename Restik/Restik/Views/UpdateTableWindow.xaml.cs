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
    /// Логика взаимодействия для UpdateTableWindow.xaml
    /// </summary>
    public partial class UpdateTableWindow : Window
    {
        Models.Table CurrentTable = new Models.Table();
        public UpdateTableWindow(string name)
        {
            InitializeComponent();
            CurrentTable = DbManager.GetTable(name);
            ViewHelper.FillHallsComboBox(HallsComboBox);
            FillTableFields(CurrentTable);
        }
        private void FillTableFields(Models.Table table)
        {
            NameTextBox.Text = table.Name;
            HallsComboBox.Text = table.Hall.Name;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var NewHall = DbManager.GetHall(HallsComboBox.Text);

            var UpdatedTable = new Restik.Models.Table
            {
                Id = CurrentTable.Id,
                Name = NameTextBox.Text,
                HallId = NewHall.Id,
                Hall = NewHall
            };

            FuncHelper.AddOrUpdateItem<Restik.Models.Table>(DbManager.UpdateTable, UpdatedTable, "Вы успешно обновили стол", this);
        }
    }
}
