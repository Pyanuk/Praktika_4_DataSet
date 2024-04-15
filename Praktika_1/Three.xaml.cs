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

    public partial class Three : Page
    {
        ORDER_COFFEETableAdapter ORDER_COFFEE = new ORDER_COFFEETableAdapter();
        public Three()
        {

            InitializeComponent();
            ORDER_COFFEEDataGrid.ItemsSource = ORDER_COFFEE.GetData();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            string nam = cofee.Text;
            int COFFEE_PRICE = int.Parse(price.Text);

            ORDER_COFFEE.InsertQuery(nam, COFFEE_PRICE);
            ORDER_COFFEEDataGrid.ItemsSource = ORDER_COFFEE.GetData();
        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            object ID_ORDER_COFFEE = (ORDER_COFFEEDataGrid.SelectedItem as DataRowView).Row[0];
            ORDER_COFFEE.DeleteQuery(Convert.ToInt32(ID_ORDER_COFFEE));
            ORDER_COFFEEDataGrid.ItemsSource = ORDER_COFFEE.GetData();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            string nam = cofee.Text;
            int COFFEE_PRICE = int.Parse(price.Text);

            object ID_ORDER_COFFEE = (ORDER_COFFEEDataGrid.SelectedItem as DataRowView).Row[0];
            ORDER_COFFEE.UpdateQuery(nam, COFFEE_PRICE, Convert.ToInt32(ID_ORDER_COFFEE));
            ORDER_COFFEEDataGrid.ItemsSource = ORDER_COFFEE.GetData();
        }
    }
}
