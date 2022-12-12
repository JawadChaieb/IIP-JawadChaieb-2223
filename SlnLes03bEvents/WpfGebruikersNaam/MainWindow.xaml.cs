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

namespace WpfGebruikersNaam
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
        private void txtBxGebruikersnaam_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBxGebruikersnaam.Text.Contains(" ") || txtBxGebruikersnaam.Text.Contains("@") ||
                  txtBxGebruikersnaam.Text.Contains("_") || txtBxGebruikersnaam.Text.Contains(".") ||
                  txtBxGebruikersnaam.Text.Contains("-") || txtBxGebruikersnaam.Text.Contains("1") ||
                  txtBxGebruikersnaam.Text.Contains("2") || txtBxGebruikersnaam.Text.Contains("3") ||
                  txtBxGebruikersnaam.Text.Contains("4") || txtBxGebruikersnaam.Text.Contains("5") ||
                  txtBxGebruikersnaam.Text.Contains("6") || txtBxGebruikersnaam.Text.Contains("7") ||
                  txtBxGebruikersnaam.Text.Contains("8") || txtBxGebruikersnaam.Text.Contains("9") ||
                  txtBxGebruikersnaam.Text.Contains("0"))
            {
                txtBxGebruikersnaam.Background = Brushes.Red;
                lblFoutmelding.Content = "Mag geen spaties bevatten";
                lblFoutmelding.Foreground = Brushes.Red;
            }

            else if (txtBxGebruikersnaam.Text == "")
            {
                lblFoutmelding.Content = "";
            }

            else
            {
                txtBxGebruikersnaam.Background = Brushes.Green;
                lblFoutmelding.Content = "";
            }

            if (txtBxGebruikersnaam.Text.Contains(" ") || txtBxGebruikersnaam.Text.Contains("@") ||
               txtBxGebruikersnaam.Text.Contains("_") || txtBxGebruikersnaam.Text.Contains(".") ||
               txtBxGebruikersnaam.Text.Contains("-") || txtBxGebruikersnaam.Text.Contains("1") ||
               txtBxGebruikersnaam.Text.Contains("2") || txtBxGebruikersnaam.Text.Contains("3") ||
               txtBxGebruikersnaam.Text.Contains("4") || txtBxGebruikersnaam.Text.Contains("5") ||
               txtBxGebruikersnaam.Text.Contains("6") || txtBxGebruikersnaam.Text.Contains("7") ||
               txtBxGebruikersnaam.Text.Contains("8") || txtBxGebruikersnaam.Text.Contains("9") ||
               txtBxGebruikersnaam.Text.Contains("0"))
            {
                txtBxGebruikersnaam.Background = Brushes.Red;
                lblFoutmelding.Content = "Mag geen spaties bevatten, cijfers of symbolen bevatten";
                lblFoutmelding.Foreground = Brushes.Red;
            }

        }
    }
}
