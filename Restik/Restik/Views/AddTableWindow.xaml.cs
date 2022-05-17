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
    /// Логика взаимодействия для AddTableWindow.xaml
    /// </summary>
    public partial class AddTableWindow : Window
    {
        public AddTableWindow()
        {
            InitializeComponent();
            FillHallsComboBox();
        }

        private void FillHallsComboBox()
        {
            HallsComboBox.Items.Clear();
            foreach (var Hall in DbManager.GetHalls())
            {
                var NewItem = ViewHelper.GetComboBoxItem(Hall.Name);
                HallsComboBox.Items.Add(NewItem);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var AddedHall = DbManager.GetHall(HallsComboBox.Text);

            var NewTable = new Restik.Models.Table
            {
                Name = NameTextBox.Text,
                HallId = AddedHall.Id,
                Hall = AddedHall
            };

            DbManager.AddTable(NewTable);
            MessageBox.Show("Вы успешно добавили стол");
            ViewHelper.WindowsInteract(this, new AdminWindow());
        }
    }
}
