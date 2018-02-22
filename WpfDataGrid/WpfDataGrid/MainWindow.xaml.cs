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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customers> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Customers>()
            {
                new Customers() {AD="Ahmet", SOYAD="CAN" },
                new Customers() {AD="Ahmet", SOYAD="CAN" },
                new Customers() {AD="Ahmet", SOYAD="CAN" },
                new Customers() {AD="Ahmet", SOYAD="CAN" },
            };
            Customers lst = new Customers();
            lst.AD = "Ali";
            lst.SOYAD = "KALABA";
            list.Add(lst);
        }
        
        private void btntikla_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butona Tıklandı.");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cmbBoxListe.SelectedItem.ToString());

            MessageBox.Show(((ComboBoxItem)(cmbBoxListe.SelectedItem)).Content.ToString());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //tb1.ItemsSource = list;

        }
        public class Customers
        {
            public string AD { get; set; }
            public string SOYAD { get; set; }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tb1.ItemsSource = list;
        }
    }
}
