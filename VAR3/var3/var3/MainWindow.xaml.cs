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

namespace var3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RotateToSquareTable(object sender, RoutedEventArgs e)
        {
            SquareTable squareTable = new SquareTable();
            squareTable.Show();
        }

        private void RotateToVietaPage(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("VietaPage.xaml", UriKind.Relative));
        }

        private void RotateToDiscrPage(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("Pages/DiscrPage.xaml", UriKind.Relative));
        }

        private void RotateToInfoOfDivisionPage(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("Pages/InfoOfDivisionPage.xaml", UriKind.Relative));
        }

        private void RotateToInfoOfSimplificationPage(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("Pages/InfoOfSimplificationPage.xaml", UriKind.Relative));
        }

        private void RotateToInfoOfSquareRootPage(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Uri("Pages/InfoOfSquareRootPage.xaml", UriKind.Relative));
        }
    }
}
