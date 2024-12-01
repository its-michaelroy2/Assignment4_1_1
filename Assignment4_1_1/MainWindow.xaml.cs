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

namespace Assignment4_1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Person> persons;
        public MainWindow()
        {
            InitializeComponent();
            persons = MockData.CreateData();
            ContactData.ItemsSource = persons.Values;
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            //TryGet returns boolean and then out = output of value
            string searchText = txtSearch.Text.Trim();
            var searchResults = persons.Values.Where(p =>
                p.FullName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            if (searchResults.Any())
            {
                dataGridResult.ItemsSource = searchResults;
            }
            else
            {
                MessageBox.Show("Contact not found!");
                dataGridResult.ItemsSource = null;
            }
        }
    }
}