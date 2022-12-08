using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace listy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<string> StringCollection { get; set; }
        public ObservableCollection<Film> WszystkieFilmy { get; set; }
        public Film ZaznaczonyFilm { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            StringCollection = "Ala ma kota a kot ma ale Ala ma kota a kot ma ale Ala ma kota a kot ma ale".Split(' ').ToList();
            DataContext = this;
            przygotujFilmy();
            ZaznaczonyFilm = WszystkieFilmy[0];
        }
  
    private void przygotujFilmy()
    {
        WszystkieFilmy = new ObservableCollection<Film>();
        WszystkieFilmy.Add(new Film("Vaiana", 6, "Ciekawy film o szukaniu celu w życiu", "Animacja"));
        WszystkieFilmy.Add(new Film("Kraina Lodu", 4, "Dużo śpiewu", "Animacja"));
        WszystkieFilmy.Add(new Film("Toys Story", 4, "Nie wyrzucaj starych zabawek, oddaj komus zaufanemy", "Animacja"));
        WszystkieFilmy.Add(new Film("Avatar", 4, "Nikt nie widział", "Sensacja"));
    }

        private void Pokaz(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zaznaczono "+ZaznaczonyFilm.Nazwa);
        }
    }
  }