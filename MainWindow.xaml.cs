// 8809972
// Rutvik Gandhi
// Section: 1/3

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
using System.IO;
using Newtonsoft.Json;

namespace _8809972_FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // a list of the things I'm storing here

        List<Parts> items = new List<Parts>();
        public MainWindow()
        {
            InitializeComponent();
        }

        // Create Add button
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Using try & catch to handle errors
            try
            {
                var Parts = new Parts();

                Parts.name = TxtName.Text;

                Parts.number = int.Parse(TxtNumber.Text);

                Parts.cost = Double.Parse(TxtCost.Text);

                Parts.quantity = int.Parse(TxtQuantity.Text);

                items.Add(Parts);

                loadGrid(items);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Your field is Empty!!");
            }

        }

        // Refresh the table's data
        public void loadGrid (List<Parts> _items)
        {
            dgOutPut.ItemsSource= _items;
            dgOutPut.Items.Refresh();
        }

        // Create Save Button
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string itemJson = JsonConvert.SerializeObject(items);
            saveData(itemJson);
        }
        
        // Store a save Data
        public void saveData(string data)
        {
            File.WriteAllText("finalData.json", data);

            MessageBox.Show("Your Data is Save");
        }

        // Load Data
        public List<Parts> loadData()
        {
            string itemJson = File.ReadAllText("finalData.json");
            return JsonConvert.DeserializeObject<List<Parts>>(itemJson);
        }

        // Create Load Button
        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            items = loadData();
            loadGrid(items);

            MessageBox.Show("Your Data has been loaded successfully");
        }

        // Create Remove Button
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            //only delete if the item text field is not empty
            if (TxtNumber.Text != null)
            {
                //To determine whether the item is in inventory, loop
                for (int i = 0; i < items.Count; i++)
                {
                    //if you discovered the item in inventory
                    if (TxtNumber.Text.ToString() == items[i].number.ToString())
                    {
                        items.Remove(items[i]);
                        MessageBox.Show("Are you sure to remove Data?");
                        loadGrid(items);
                    }
                }
            }
            else
            {
                MessageBox.Show("no Item found in Inventory");
            }

        }
    }
}
