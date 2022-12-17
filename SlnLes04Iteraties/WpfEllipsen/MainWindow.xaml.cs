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

namespace WpfEllipsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int MAX_AANTAL_ELLIPSEN = 50;
        int aantalEllipsen = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            do
            {
                aantalEllipsen++;
                if (aantalEllipsen <= MAX_AANTAL_ELLIPSEN)
                {
                    Random random = new Random();
                    
                    Ellipse newEllipse = new Ellipse();
                    newEllipse.Width = random.Next(20, 150);
                    newEllipse.Height = random.Next(20, 150);
                    newEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 255),
                    (byte)random.Next(1, 255), (byte)random.Next(1, 255)));
                    double xPos = random.Next(0, 711);
                    double yPos = random.Next(0, 255);
                    newEllipse.SetValue(Canvas.LeftProperty, xPos);
                    newEllipse.SetValue(Canvas.TopProperty, yPos);
                    
                    canvas1.Children.Add(newEllipse);
                    
                    lblGetekendeEllipsen.Content = aantalEllipsen;
                }
                else
                {
                    MessageBox.Show("Je kan niet meer ellipsen tekenen.");
                }
            }
            while (MAX_AANTAL_ELLIPSEN == aantalEllipsen);
        }
    }
}
