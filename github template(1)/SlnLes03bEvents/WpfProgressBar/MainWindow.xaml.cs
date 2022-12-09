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
using System.Windows.Threading;

namespace WpfProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            count++;
            rctTimer.Width = (count * 4) * 5;
            rctTimer.Fill = new SolidColorBrush(Colors.Green);

            lblPercentage.Content = (rctTimer.Width / 4) + " %";


            if (rctTimer.Width == 400)
            {
                MessageBox.Show("Voortgang voltooid!");
                timer.Stop();
                rctTimer.Width = 0;
                lblPercentage.Content = "0 %";
            }

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();

            if (btnHerstel.IsEnabled == true)
            {
                rctTimer.Width = 0;
                timer.Start();
                count = 0;
            }
        }

        private void btnHerstel_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            rctTimer.Width = 0;
            lblPercentage.Content = "0 %";
        }
    }
}
