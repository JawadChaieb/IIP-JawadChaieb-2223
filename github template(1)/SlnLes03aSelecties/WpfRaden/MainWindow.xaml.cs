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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int raad;
        int pogingenOver = 3;
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
