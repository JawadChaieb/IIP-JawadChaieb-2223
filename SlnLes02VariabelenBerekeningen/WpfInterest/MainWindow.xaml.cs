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

namespace WpfInterest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            //Berekening van het intrest
            double interest = Convert.ToDouble(txtBxInterest.Text) / 100;

            //Inhoud van txtBedrag omzetten in double en de double noemen voor de berekening van waarde 
            double bedrag = Convert.ToDouble(txtBxBedrag.Text);

            //Inhoud van de sldJaar omzetten in int en de Int noemen voor de berekening van waard
            int jaar = Convert.ToInt32(sldJaar.Value);

            //Berekening van de interest met de component en in een double zetten voor de berekening van waarde
            double interestPeriode = Math.Pow((1 + interest), jaar);

            //Berekening van waarde
            lblWaarde.Content = bedrag * interestPeriode;

            //De inhoud van lblWaarde met de uitkomst van de berekening en het jaar
            lblWaarde.Content = $"De waarde na {sldJaar.Value}" +
                $" jaar bedraagt €{lblWaarde.Content = Math.Round(Convert.ToDouble(lblWaarde.Content), 2)}";
        }

        private void sldJaar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //De waarde van de slider
            lblJaar.Content = sldJaar.Value + " jaar";
        }
    }
}
