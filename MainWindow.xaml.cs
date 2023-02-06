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

namespace PlayfulCRM
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

        private void customersButton_Click(object sender, RoutedEventArgs e)
        {
            // This is an uggly solution for changing content depending on selection.
            // Don't memorize it, we will be locking into using different xaml-files instead.
            TextBlock customerViewTextBlock = new TextBlock();
            customerViewTextBlock.Text = "Customer was clicked!";
            contentPanel.Children.Clear();
            contentPanel.Children.Add(customerViewTextBlock);
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            // This is an uggly solution for changing content depending on selection.
            // Don't memorize it, we will be locking into using different xaml-files instead.
            contentPanel.Children.Clear();
            contentPanel.Children.Add(homeViewTextBlock);
            homeViewTextBlock.Text = "Home was clicked!";
        }
    }
}
