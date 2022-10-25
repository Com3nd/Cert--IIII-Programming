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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataService dataService = new DataService();
            InitializeComponent();
        }

        //Method that refreshes the list box
        void Refresh()
        {
            DataService dataService = new DataService();
            ListBox_CarsInventory.ItemsSource = dataService.GetCars();
        }


        //Method that contains code that is activiated when a user presses the Add button
        private void ButtonAddCar_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void ButtonRemoveCar_Click(object sender, RoutedEventArgs e)
        {
            DataService dataService = new DataService();
            dataService.SellCar((Car)ListBox_CarsInventory.SelectedItem);
            ListBox_CarsInventory.ItemsSource = dataService.GetCars();
        }

        private void ListBox_CarsInventory_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
