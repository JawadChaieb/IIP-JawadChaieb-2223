using System;
using System.Windows;
using System.Windows.Media;

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int raad;
        private int pogingenOver = 3;

        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();
            raad = rnd.Next(1, 10);

            lblResultaat.Foreground = Brushes.BlueViolet;
        }

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            int gok = Convert.ToInt32(txtbxGok.Text);

            pogingenOver--;

            if (gok > raad)
            {
                lblResultaat.Content = ($"Te hoog ! Je beht nog {pogingenOver} pogingen over");
            }
            else if (gok < raad)
            {
                lblResultaat.Content = ($"Te laag ! Je beht nog {pogingenOver} pogingen over");
            }
            else
            {
                lblResultaat.Content = ("Je hebt gewonnen !!!");

                btnControleer.IsEnabled = false;
            }

            if (gok == raad && pogingenOver == 0)
            {
                lblResultaat.Content = ("Je hebt gewonnen !!!");
                btnControleer.IsEnabled = false;
            }
            else if (pogingenOver == 0)
            {
                lblResultaat.Content = ("Je hebt geen pogingen meer ! Herstart het programma om te spelen");

                btnControleer.IsEnabled = false;
            }
        }
    }
}