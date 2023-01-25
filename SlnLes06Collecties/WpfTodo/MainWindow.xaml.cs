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

namespace WpfTodo
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
        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = txtTodo.Text;
            ltbTodo.Items.Add(item);
            txtTodo.Text = "";

            ComboBoxItem selected = (ComboBoxItem)cbxPrioriteit.SelectedItem;
            string selection = Convert.ToString(selected.Content);
            if (selection == "hoog")
            {
                item.Foreground = Brushes.Green;
            }
            else if (selection == "middelmatig")
            {
                item.Foreground = Brushes.Orange;
            }
            else
            {
                item.Foreground = Brushes.Red;
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            ltbTodo.Items.Clear();
        }
    }
}
