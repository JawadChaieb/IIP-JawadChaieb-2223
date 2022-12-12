using System;
using System.Windows;
using System.Windows.Media;

namespace WpfSliderKleur
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

        private void sldKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ///value slider
            txtblkWaarde.Text = Convert.ToString(sldKleur.Value);

            ///Value kleiner en gelijk aan 25 dan groen
            if (Math.Round(sldKleur.Value) <= 25)
            {
                ///kleur aan txtblkWaarde
                txtblkWaarde.Foreground = Brushes.Green;
            }
            ///Value groter dan 25 of kleiner en gelijk aan 50 dan tekstkleur geel
            else if ((Math.Round(sldKleur.Value) > 25) && (sldKleur.Value <= 50))
            {
                txtblkWaarde.Foreground = Brushes.Yellow;
            }
            ///Value groter is dan 50 of kleiner en gelijk aan 75 dan oranje
            else if ((Math.Round(sldKleur.Value) > 50) && (sldKleur.Value <= 75))
            {
                txtblkWaarde.Foreground = Brushes.Orange;
            }
            ///niet een van de vorige is dan wordt het rood
            else
            {
                txtblkWaarde.Foreground = Brushes.Red;
            }
        }
    }
}