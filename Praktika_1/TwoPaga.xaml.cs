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
    
    public partial class TwoPaga : Page
    {
        CLIENTTableAdapter CLIENT = new CLIENTTableAdapter();
        public TwoPaga()
        {
            InitializeComponent();
            ClientDataGrid.ItemsSource = CLIENT.GetData();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            string sur = surname.Text;
            string nam = name.Text;
            string midl = midle.Text;

            CLIENT.InsertQuery(sur, nam, midl);
            ClientDataGrid.ItemsSource = CLIENT.GetData();

        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            object id = (ClientDataGrid.SelectedItem as DataRowView).Row[0];
            CLIENT.DeleteQuery(Convert.ToInt32(id));
            ClientDataGrid.ItemsSource = CLIENT.GetData();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            string sur = surname.Text;
            string nam = name.Text;
            string midl = midle.Text;

            object id = (ClientDataGrid.SelectedItem as DataRowView).Row[0];
            CLIENT.UpdateQuery(sur, nam, midl, Convert.ToInt32(id));
            ClientDataGrid.ItemsSource = CLIENT.GetData();
        }
    }
}
