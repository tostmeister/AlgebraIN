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
    public partial class VietaPage : Page
    {
        public VietaPage()
        {
            InitializeComponent();
        }
        private void Solve_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(aTextBox.Text, out double a) &&
                double.TryParse(bTextBox.Text, out double b) &&
                double.TryParse(cTextBox.Text, out double c))
            {
                try
                {
                    var (root1, root2) = FindRoots(a, b, c);
                    resultTextBlock.Text = $"Корни: {root1} и {root2}";
                }
                catch (Exception ex)
                {
                    resultTextBlock.Text = ex.Message;
                }
            }
            else
            {
                resultTextBlock.Text = "Введите корректные коэфиценты.";
            }
        }

        public static (double root1, double root2) FindRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new Exception("Корней нет.");
            }

            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            return (root1, root2);
        }
    }
}
