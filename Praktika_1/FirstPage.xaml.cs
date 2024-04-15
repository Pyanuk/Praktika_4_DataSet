using System;
using System.Collections.Generic;
using System.Data;
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
using Praktika_1.COFFEE_HOUSEDataSetTableAdapters;

namespace Praktika_1
{

    public partial class FirstPage : Page
    {
        NAME_COFFEETableAdapter NAME_COFFEE = new NAME_COFFEETableAdapter();
        public FirstPage()
        {
            InitializeComponent();
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.GetData();
            filter_dan.DisplayMemberPath = "ADDRESS_COFFEE_HOUSE";
            filter_dan.ItemsSource = NAME_COFFEE.GetData();
        }


        private void insert_Click(object sender, RoutedEventArgs e)
        {
            string coffeeName = text.Text;
            string coffeeAddress = addressTextBox.Text;

            NAME_COFFEE.InsertQuery(coffeeName, coffeeAddress);
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.GetData();


        }


        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            object ID_NAME_COFFEE_HOUSE = (NAME_COFFEEDataGrid.SelectedItem as DataRowView).Row[0];
            NAME_COFFEE.DeleteQuery(Convert.ToInt32(ID_NAME_COFFEE_HOUSE));
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.GetData();
        }

 

        private void update_Click(object sender, RoutedEventArgs e)
        {
            string coffeeName = text.Text;
            string coffeeAddress = addressTextBox.Text;

            object ID_NAME_COFFEE_HOUSE = (NAME_COFFEEDataGrid.SelectedItem as DataRowView).Row[2];
            NAME_COFFEE.UpdateQuery1(coffeeName, coffeeAddress, Convert.ToInt32(ID_NAME_COFFEE_HOUSE));
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.GetData();
        }

        private void poick_dan_Click(object sender, RoutedEventArgs e)
        {
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.SearchByName(poick.Text);

        }
        

        private void filter_dan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(filter_dan.SelectedItem != null)
            {
                var ADDRESS = (string)(filter_dan.SelectedItem as DataRowView).Row[2];
                NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.FilterByAddress(ADDRESS);

            }
        }

        private void filter_dani_Click(object sender, RoutedEventArgs e)
        {
            filter_dan.SelectedItem = null;
            poick.Text = "";
            NAME_COFFEEDataGrid.ItemsSource = NAME_COFFEE.GetData();
        }
    }
}


