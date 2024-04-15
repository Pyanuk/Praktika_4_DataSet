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

    public partial class FourPage : Page
    {

        private int tempNameCoffeeId;
        private int tempClientId;
        private int tempOrderCoffeeId;

        CUSTOMER_ORDERTableAdapter CUSTOMER_ORDER = new CUSTOMER_ORDERTableAdapter();
        NAME_COFFEETableAdapter NAME_COFFEE = new NAME_COFFEETableAdapter();
        CLIENTTableAdapter CLIENT = new CLIENTTableAdapter();
        ORDER_COFFEETableAdapter ORDER_COFFEE = new ORDER_COFFEETableAdapter();
        public FourPage()
        {
            InitializeComponent();
            CUSTOMER_ORDERDataGrid.ItemsSource = CUSTOMER_ORDER.GetData();

            CUSTOMER_ORDERComboBox.ItemsSource = NAME_COFFEE.GetData();
            CUSTOMER_ORDERComboBox.DisplayMemberPath = "ID_NAME_COFFEE_HOUSE";

            CUSTOMER_ORDERComboBox1.ItemsSource = CLIENT.GetData();
            CUSTOMER_ORDERComboBox1.DisplayMemberPath = "ID_CLIENT";

            CUSTOMER_ORDERComboBox2.ItemsSource = ORDER_COFFEE.GetData();
            CUSTOMER_ORDERComboBox2.DisplayMemberPath = "ID_ORDER_COFFEE";

            CUSTOMER_ORDERDataGrid.SelectionChanged += CUSTOMER_ORDERDataGrid_SelectionChanged;


        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox.SelectedItem != null &&
                CUSTOMER_ORDERComboBox1.SelectedItem != null &&
                CUSTOMER_ORDERComboBox2.SelectedItem != null)
            {
                DataRowView nameCoffeeRow = CUSTOMER_ORDERComboBox.SelectedItem as DataRowView;
                int NAME_COFFEE_ID = Convert.ToInt32(nameCoffeeRow["ID_NAME_COFFEE_HOUSE"]);

                DataRowView clientRow = CUSTOMER_ORDERComboBox1.SelectedItem as DataRowView;
                int CLIENT_ID = Convert.ToInt32(clientRow["ID_CLIENT"]);

                DataRowView orderCoffeeRow = CUSTOMER_ORDERComboBox2.SelectedItem as DataRowView;
                int ORDER_COFFEE_ID = Convert.ToInt32(orderCoffeeRow["ID_ORDER_COFFEE"]);

                CUSTOMER_ORDER.InsertQuery(NAME_COFFEE_ID, CLIENT_ID, ORDER_COFFEE_ID);
                CUSTOMER_ORDERDataGrid.ItemsSource = CUSTOMER_ORDER.GetData();
            }

        }
        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                DataRowView selectedRow = CUSTOMER_ORDERDataGrid.SelectedItem as DataRowView;
                int ID = Convert.ToInt32(selectedRow["ID_CUSTOMER_ORDER"]);
                CUSTOMER_ORDER.DeleteQuery(ID);
                CUSTOMER_ORDERDataGrid.ItemsSource = CUSTOMER_ORDER.GetData();
            }

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = CUSTOMER_ORDERDataGrid.SelectedItem as DataRowView;


            selectedRow["NAME_COFFEE_ID"] = tempNameCoffeeId;
            selectedRow["CLIENT_ID"] = tempClientId;
            selectedRow["ORDER_COFFEE_ID"] = tempOrderCoffeeId;


            CUSTOMER_ORDER.Update(selectedRow.Row);

            CUSTOMER_ORDERDataGrid.Items.Refresh();
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox.SelectedItem != null)
            {
                DataRowView row = CUSTOMER_ORDERComboBox.SelectedItem as DataRowView;
                tempNameCoffeeId = Convert.ToInt32(row["ID_NAME_COFFEE_HOUSE"]);
            }
        }

        private void CUSTOMER_ORDERComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox1.SelectedItem != null)
            {
                DataRowView row = CUSTOMER_ORDERComboBox1.SelectedItem as DataRowView;
                tempClientId = Convert.ToInt32(row["ID_CLIENT"]);
            }
        }

        private void CUSTOMER_ORDERComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox2.SelectedItem != null)
            {
                DataRowView row = CUSTOMER_ORDERComboBox2.SelectedItem as DataRowView;
                tempOrderCoffeeId = Convert.ToInt32(row["ID_ORDER_COFFEE"]);
            }
        }

        private void CUSTOMER_ORDERDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                DataRowView selectedRow = CUSTOMER_ORDERDataGrid.SelectedItem as DataRowView;

                int nameCoffeeId = Convert.ToInt32(selectedRow["NAME_COFFEE_ID"]);
                int clientId = Convert.ToInt32(selectedRow["CLIENT_ID"]);
                int orderCoffeeId = Convert.ToInt32(selectedRow["ORDER_COFFEE_ID"]);


                foreach (DataRowView item in CUSTOMER_ORDERComboBox.Items)
                {
                    if (Convert.ToInt32(item["ID_NAME_COFFEE_HOUSE"]) == nameCoffeeId)
                    {
                        CUSTOMER_ORDERComboBox.SelectedItem = item;
                        break;
                    }
                }

                foreach (DataRowView item in CUSTOMER_ORDERComboBox1.Items)
                {
                    if (Convert.ToInt32(item["ID_CLIENT"]) == clientId)
                    {
                        CUSTOMER_ORDERComboBox1.SelectedItem = item;
                        break;
                    }
                }

                foreach (DataRowView item in CUSTOMER_ORDERComboBox2.Items)
                {
                    if (Convert.ToInt32(item["ID_ORDER_COFFEE"]) == orderCoffeeId)
                    {
                        CUSTOMER_ORDERComboBox2.SelectedItem = item;
                        break;
                    }
                }
            }
        }
    }
}
