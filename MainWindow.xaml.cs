using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace C_AppTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                
            }
        }

        public void Calculate(object sender, RoutedEventArgs e)
        {
            int num1;
            int num2;
            int num3;
            int num4;
            string Operator = OperatorInput.Text;

            bool FirstFractionValidNum1 = int.TryParse(FirstFractionNum1.Text, out num1);
            bool FirstFractionValidNum2 = int.TryParse(FirstFractionNum2.Text, out num2);

            bool SecondFractionValidNum1 = int.TryParse(SecondFractionNum1.Text, out num3);
            bool SecondFractionValidNum2 = int.TryParse(SecondFractionNum2.Text, out num4);

            if (Operator == "+")
            {
                int solve1 = num2 * num4;
                int solve2 = num1 * num2;
                int solve3 = num3 * num4;
                int answer = solve2 + solve3;
                MessageBox.Show("The result is: " + answer + "/" + solve1);
            }
            else if (Operator == "-")
            {
                int solve1 = num2 * num4;
                int solve2 = num1 * num2;
                int solve3 = num3 * num4;
                int answer = solve2 - solve3;
                MessageBox.Show("The result is: " + answer + "/" + solve1);
            }
            else if(Operator == "*")
            {
                int solve1 = num1 * num2;
                int solve2 = num3 * num4;
                MessageBox.Show("The result is: " + solve1 + "/" + solve2);
            }
            else if(Operator == "/")
            {
                int solve1 = num1 * num4;
                int solve2 = num2 * num3;
                MessageBox.Show("The result is: " + solve1 + "/" + solve2);
            }
            else
            {
                MessageBox.Show("Invalid Operator Try Again :(");
            }
        }
    }
}