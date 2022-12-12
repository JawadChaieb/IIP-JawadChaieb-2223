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

namespace WpfWinkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double PRIJS_BANAAN = 2.25;
        const double PRIJS_BOTER = 3.00;
        const double PRIJS_EIEREN = 2.90;



        string prijsboter = PRIJS_BOTER.ToString("0.00");
        string prijsbanaan = PRIJS_BANAAN.ToString("0.00");
        string prijseieren = PRIJS_EIEREN.ToString("0.00");

        double totaalPrijs;

        public MainWindow()
        {
            InitializeComponent();
            Random voorraad = new Random();


            lblVoorraadBanaan.Content = voorraad.Next(5, 40);

            lblVoorraadBoter.Content = voorraad.Next(5, 40);

            lblVoorraadEieren.Content = voorraad.Next(5, 40);

            txtPrijsBanaan.Text = PRIJS_BANAAN.ToString("0.00");

            txtPrijsBoter.Text = PRIJS_BOTER.ToString("0.00");

            txtPrijsEieren.Text = PRIJS_EIEREN.ToString("0.00");
        }
        private void btnBanaan_Click(object sender, RoutedEventArgs e)
        {

            int voorraadBanaan = Convert.ToInt32(lblVoorraadBanaan.Content);



            lblVoorraadBanaan.Content = voorraadBanaan - 1;
            lstBxVerkocht.Items.Add($"{prijsbanaan} - 1 tros banaan");
            totaalPrijs += PRIJS_BANAAN;

        }

        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {

            int voorraadBoter = Convert.ToInt32(lblVoorraadBanaan.Content);



            lblVoorraadBoter.Content = voorraadBoter - 1;
            lstBxVerkocht.Items.Add($"{prijsboter} - 1 pak boter");
            totaalPrijs += PRIJS_BOTER;


        }

        private void btnEieren_Click(object sender, RoutedEventArgs e)
        {

            int voorraadEieren = Convert.ToInt32(lblVoorraadEieren.Content);

            lblVoorraadEieren.Content = voorraadEieren - 1;
            lstBxVerkocht.Items.Add($"{prijseieren} - 1 pak boter");
            totaalPrijs += PRIJS_EIEREN;
        }

        private void btnHerstel_Click(object sender, RoutedEventArgs e)
        {
            lstBxVerkocht.Items.Clear();
            lblVoorraadBanaan.Content = "";
            lblVoorraadBoter.Content = "";
            lblVoorraadEieren.Content = "";
            lblAfrekenen.Content = "";

            Random voorraad = new Random();

            lblVoorraadBanaan.Content = voorraad.Next(5, 40);
            lblVoorraadBoter.Content = voorraad.Next(5, 40);
            lblVoorraadEieren.Content = voorraad.Next(5, 40);
        }

        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            double som = totaalPrijs;
            lblAfrekenen.Content = $"{Math.Round(som, 2)} euro";

            lstBxVerkocht.Items.Clear();
            totaalPrijs = 0;

        }
    }
}
