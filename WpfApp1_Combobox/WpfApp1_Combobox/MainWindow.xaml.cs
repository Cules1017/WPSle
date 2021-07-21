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

namespace WpfApp1_Combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List <Team>Item;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Item = new List<Team> {
                new Team(){Name="FC Bacelona",Price="9999999" },
                new Team(){Name="FC Asenal",Price="23456" },
                new Team(){Name="FC Real Marid",Price="36575" },
                new Team(){Name="FC Chelsea",Price="90463" },
                new Team(){Name="FC PSG",Price="48559" } };
            ItemSource.ItemsSource = Item;
           ItemSource.SelectedValuePath ="Price";
            ItemSource.DisplayMemberPath = "Name";
            ColorCB.ItemsSource = typeof(Colors).GetProperties();
            
        }

        private void ItemSource_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemSourcePrice.Text = ItemSource.SelectedValue.ToString();
        }
    }
    public class Team
    {
        private string name;
        private string price;

        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
    }
}
