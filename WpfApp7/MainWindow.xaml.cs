using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<IProduct> _products = new List<IProduct>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Name = NameTextBox.Text;
            if (decimal.TryParse(PriceTextBox.Text, out decimal price))
            {
                product.Price = price;
            }
            else
            {
                MessageBox.Show("Введите число");
                return;
            }
            _products.Add(product);
            ProductListBox.ItemsSource = null;
            ProductListBox.ItemsSource = _products;
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ProductListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}