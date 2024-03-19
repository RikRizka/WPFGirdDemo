using System.Collections.ObjectModel;
using System.Globalization;
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

namespace WPFGirdDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       ObservableCollection<Person> personList = new ObservableCollection <Person>();
        // List<Person> personList = new List<Person>();
        List<Land> landList = new List<Land>();
        public MainWindow()
        {
            InitializeComponent();
            cmbLand.ItemsSource = landList;
            BindLand();
            BindGrid();
        }

        private void BindGrid()
        {
            personList.Add(new Person("Rik", 25, "Man", "Belgie"));
            personList.Add(new Person("Zkariah", 20, "Man", "Indonesie"));
            personList.Add(new Person("Eveline", 26, "Vrouw", "Spanje"));
            personList.Add(new Person("Salavatore", 29, "Man", "Germany"));
            personList.Add(new Person("Gabriela", 23, "Vrouw", "Indonesie"));
            personList.Add(new Person("Olesiae", 30, "Vrouw", "Spanje"));
            personList.Add(new Person("Alain", 62, "Man", "Belgie"));

            datGrid.ItemsSource = personList;
        }
        //private void BindALand()
        //{
        //    BindLand();
        //}

        private void BindLand()
        {
            landList.Add(new Land("Belgie"));
            landList.Add(new Land("Indonesie"));
            landList.Add(new Land("Spanje"));
            landList.Add(new Land("Germany"));

           cmbLand.ItemsSource = landList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string naam = txtNaam.Text;
            int age = int.Parse(txtLeeftijd.Text);
            string geslacht = txtGeslacht.Text;
            string? land = cmbLand.SelectedValue.ToString();
            //if (cmbLand.SelectedIndex =! null)
            //{
            //    land = cmbLand.SelectedValue.ToString() ;
            //}
            //else
            //{

            //}

            Person person = new (naam, age, geslacht, land);
            personList.Add(person);
           // datGrid.Items.Refresh();


        }
        public void Search(string SearchFor)
        {
            var result = personList.Where(p=>p.Land.Equals(SearchFor)).ToList();
            datGrid.ItemsSource = result;
        }
        private void cmbLand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
          Search(cmbLand.SelectedValue.ToString());           
        }
    }
}