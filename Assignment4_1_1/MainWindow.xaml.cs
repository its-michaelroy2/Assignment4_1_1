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
        // Dictionary to store person objects, with full name as the key
        Dictionary<string, Person> persons;
        public MainWindow()
        {
            InitializeComponent();
            //Initialize persons dict weith mock data
            persons = MockData.CreateData();
            //Set itemSource of contactData Datagrid to display all persons
            ContactData.ItemsSource = persons.Values;
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // Trim the search text to remove leading and trailing whitespace
            string searchText = txtSearch.Text.Trim();
            // Search for persons whose full name contains the search text (case-insensitive)
            var searchResults = persons.Values.Where(p =>
                p.FullName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            //Check if any results found & if found display in the dataGridResults
            //Else msg below it
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