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

namespace WpfOxo
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
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.IsEnabled)
            {
                clickedButton.Content = "X";
                clickedButton.IsEnabled = false;
            }

            if (btn.Content == "X" && btn2.Content == "X" && btn3.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn4.Content == "X" && btn5.Content == "X" && btn6.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn7.Content == "X" && btn8.Content == "X" && btn9.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn.Content == "X" && btn5.Content == "X" && btn9.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn3.Content == "X" && btn5.Content == "X" && btn7.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn.Content == "X" && btn4.Content == "X" && btn7.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn2.Content == "X" && btn5.Content == "X" && btn8.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
            if (btn3.Content == "X" && btn6.Content == "X" && btn9.Content == "X")
            {
                lblResultaat.Content = "Speler X heeft gewonnen!";
            }
        }
        private void btn_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.IsEnabled)
            {
                clickedButton.Content = "O";
                clickedButton.IsEnabled = false;
            }

            if (btn.Content == "O" && btn2.Content == "O" && btn3.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn4.Content == "O" && btn5.Content == "O" && btn6.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn7.Content == "O" && btn8.Content == "O" && btn9.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn.Content == "O" && btn5.Content == "O" && btn9.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn3.Content == "O" && btn5.Content == "O" && btn7.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn.Content == "O" && btn4.Content == "O" && btn7.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn2.Content == "O" && btn5.Content == "O" && btn8.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
            if (btn3.Content == "O" && btn6.Content == "O" && btn9.Content == "O")
            {
                lblResultaat.Content = "Speler O heeft gewonnen!";
            }
        }
    }
}
