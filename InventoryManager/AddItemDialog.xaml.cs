using System.Windows;

using static InventoryManager.MainWindow;

namespace InventoryManager
{
    public partial class AddItemDialog : Window
    {
        // Properties to store item data
        public string ItemName { get; private set; }
        public int ItemQuantity { get; private set; }
        public double ItemPrice { get; private set; }

        // Constructor
        public AddItemDialog(InventoryItem item = null)
        {
            InitializeComponent();

            // If editing an existing item, populate the fields
            if (item != null)
            {
                ItemNameInput.Text = item.Name;
                ItemQuantityInput.Text = item.Quantity.ToString();
                ItemPriceInput.Text = item.Price.ToString();
            }
        }

        // Save button click event
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(ItemNameInput.Text) ||
                !int.TryParse(ItemQuantityInput.Text, out int quantity) ||
                !double.TryParse(ItemPriceInput.Text, out double price))
            {
                MessageBox.Show("Invalid input. Please check your entries.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Save the input data to the properties
            ItemName = ItemNameInput.Text.Trim();
            ItemQuantity = quantity;
            ItemPrice = price;

            // Close the dialog with a success result
            DialogResult = true;
        }

        // Cancel button click event
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the dialog without saving
            DialogResult = false;
        }
    }
}
