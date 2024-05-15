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
    /// Логика взаимодействия для DiscrPage.xaml
    /// </summary>
    public partial class DiscrPage : Page
    {
        public DiscrPage()
        {
            InitializeComponent();
        }

        private void Solve_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) &&
                double.TryParse(bTextBox.Text, out double b) &&
                double.TryParse(cTextBox.Text, out double c))
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    resultTextBlock.Text = $"Корни: {root1} и {root2}";
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    resultTextBlock.Text = $"Корень: {root}";
                }
                else
                {
                    resultTextBlock.Text = "Корней нет.";
                }
            }
            else
            {
                resultTextBlock.Text = "Введите корректные коэфиценты.";
            }
        }
    }
}
