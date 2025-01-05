using Newtonsoft.Json;

using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace InventoryManager
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<InventoryItem> Inventory = new ObservableCollection<InventoryItem>();

        public MainWindow()
        {
            InitializeComponent();
            InventoryTable.ItemsSource = Inventory;
            LoadInventoryFromJson();
            UpdateTotalValue();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddItemDialog();
            if (dialog.ShowDialog() == true)
            {
                Inventory.Add(new InventoryItem
                {
                    Name = dialog.ItemName,
                    Quantity = dialog.ItemQuantity,
                    Price = dialog.ItemPrice
                });
                UpdateTotalValue();
            }
        }

        private void EditItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (InventoryTable.SelectedItem is InventoryItem selectedItem)
            {
                var dialog = new AddItemDialog(selectedItem);
                if (dialog.ShowDialog() == true)
                {
                    selectedItem.Name = dialog.ItemName;
                    selectedItem.Quantity = dialog.ItemQuantity;
                    selectedItem.Price = dialog.ItemPrice;
                    InventoryTable.Items.Refresh();
                    UpdateTotalValue();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Edit Item", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (InventoryTable.SelectedItem is InventoryItem selectedItem)
            {
                Inventory.Remove(selectedItem);
                UpdateTotalValue();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Delete Item", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void SaveToCsvButton_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "Inventory.csv"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("Name,Quantity,Price");
                    foreach (var item in Inventory)
                    {
                        writer.WriteLine($"{item.Name},{item.Quantity},{item.Price}");
                    }
                }

                MessageBox.Show("Inventory saved to CSV file.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ImportCsvButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                using (var reader = new StreamReader(openFileDialog.FileName))
                {
                    string header = reader.ReadLine(); // Skip the header line
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 3 &&
                            int.TryParse(values[1], out int quantity) &&
                            double.TryParse(values[2], out double price))
                        {
                            Inventory.Add(new InventoryItem
                            {
                                Name = values[0],
                                Quantity = quantity,
                                Price = price
                            });
                        }
                    }
                }

                UpdateTotalValue();
                MessageBox.Show("Inventory imported from CSV file.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateTotalValue()
        {
            double total = Inventory.Sum(item => item.Quantity * item.Price);
            TotalValueText.Text = $"Total Value: ${total:F2}";
        }

        private void SaveInventoryToJson()
        {
            File.WriteAllText("Inventory.json", JsonConvert.SerializeObject(Inventory));
        }

        private void LoadInventoryFromJson()
        {
            if (File.Exists("Inventory.json"))
            {
                var items = JsonConvert.DeserializeObject<List<InventoryItem>>(File.ReadAllText("Inventory.json"));
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        Inventory.Add(item);
                    }
                }
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            SaveInventoryToJson();
        }
    }

    public class InventoryItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
