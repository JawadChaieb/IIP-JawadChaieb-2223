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

namespace WpfFormChecking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            comboBxProfiel.Items.Insert(0, "Gehuwd");
            comboBxProfiel.Items.Insert(1, "Ongehuwd");
        }
        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtbxNaam.Text = "";
            txtBxEmail.Text = "";
            datePicker.SelectedDate = null;
            comboBxProfiel.Items.Clear();
            pwBxPasswoord.Clear();
            rbtnMan.IsChecked = false;
            rbtnVrouw.IsChecked = false;
            chkBxProgrammeren.IsChecked = false;
            chkBxNetwerk.IsChecked = false;
            chkBxBusiness.IsChecked = false;
            lblResultaat.Content = "";
        }

        private void rbtnMan_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnMan.IsChecked == true)
            {
                rbtnVrouw.IsChecked = false;
            }

        }

        private void rbtnVrouw_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnVrouw.IsChecked == true)
            {
                rbtnMan.IsChecked = false;
            }

        }

        private void btnRegistreren_Click(object sender, RoutedEventArgs e)
        {
            int aantalFouten = 0;

            if (txtbxNaam.Text == "")
            {
                lblNaam.Content = "Naam moet ingevuld zijn!";
                lblNaam.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (txtBxEmail.Text == "")
            {
                lblEmail.Content = "Email moet ingevuld zijn!";
                lblEmail.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (datePicker.SelectedDate == null)
            {
                lblGeboortedatum.Content = "Datum moet ingevuld zijn";
                lblGeboortedatum.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (comboBxProfiel.SelectedItem == null)
            {
                lblProfiel.Content = "Profiel moet geselecteerd zijn";
                lblProfiel.Foreground = Brushes.Red;
                aantalFouten++;

            }

            if (pwBxPasswoord.Password.ToString() == "")
            {
                lblPasswoord.Content = "kies een paswoord";
                lblPasswoord.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (rbtnMan.IsChecked == false && rbtnVrouw.IsChecked == false)
            {
                lblGeslacht.Content = "kies een geslacht";
                lblGeslacht.Foreground = Brushes.Red;
                aantalFouten++;

            }

            if (chkBxProgrammeren.IsChecked == false && chkBxNetwerk.IsChecked == false && chkBxBusiness.IsChecked == false)
            {
                lblInteresse.Content = "Interesse moet geselecteerd zijn";
                lblInteresse.Foreground = Brushes.Red;
                aantalFouten++;

            }

            lblResultaat.Content = $"Dit formulier bevat {aantalFouten} fouten";
            lblResultaat.Foreground = Brushes.Red;

            ///Als alles ingevuld is
            if (txtbxNaam.Text != "" && txtBxEmail.Text != "" && datePicker.SelectedDate != null &&
                comboBxProfiel.SelectedItem != null && pwBxPasswoord.Password.ToString() != "" &&
                (rbtnMan.IsChecked != false || rbtnVrouw.IsChecked != false) &&
                (chkBxProgrammeren.IsChecked != false || chkBxNetwerk.IsChecked != false || chkBxBusiness.IsChecked != false))
            {
                lblResultaat.Content = "bedankt voor de registratie!";
                lblResultaat.Foreground = Brushes.Black;

                ///Alles wissen
                txtbxNaam.Text = "";
                txtBxEmail.Text = "";
                datePicker.SelectedDate = null;
                comboBxProfiel.Items.Clear();
                pwBxPasswoord.Clear();
                rbtnMan.IsChecked = false;
                rbtnVrouw.IsChecked = false;
                chkBxProgrammeren.IsChecked = false;
                chkBxNetwerk.IsChecked = false;
                chkBxBusiness.IsChecked = false;

                lblNaam.Content = "";
                lblEmail.Content = "";
                lblGeboortedatum.Content = "";
                lblProfiel.Content = "";
                lblPasswoord.Content = "";
                lblGeslacht.Content = "";
                lblInteresse.Content = "";

            }
        }

        private void chkBxProgrammeren_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBxProgrammeren.IsChecked == true)
            {
                chkBxBusiness.IsChecked = false;
                chkBxNetwerk.IsChecked = false;
            }
        }

        private void chkBxNetwerk_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBxNetwerk.IsChecked == true)
            {
                chkBxBusiness.IsChecked = false;
                chkBxProgrammeren.IsChecked = false;
            }
        }

        private void chkBxBusiness_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBxBusiness.IsChecked == true)
            {
                chkBxNetwerk.IsChecked = false;
                chkBxProgrammeren.IsChecked = false;
            }
        }   
    }
}
