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

namespace WpfBMI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string lengteCm = txtBxLengte.Text;
            double lengteM = Convert.ToDouble(lengteCm) / 100;
            string gewicht = txtBxGewicht.Text;
            double BMI = Convert.ToDouble(gewicht) / (Convert.ToDouble(lengteM) * Convert.ToDouble(lengteM));

            lblBMI.Content = $"BMI: " + (BMI = Math.Round(BMI, 2));
        }
    }
}