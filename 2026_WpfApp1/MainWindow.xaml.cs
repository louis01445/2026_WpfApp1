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

namespace _2026_WpfApp1
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

        private void okbutton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string phone = phoneTextBox.Text;
            string message = $"Hello, {name}! Your phone number is {phone}.";
            MessageBox.Show(message, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void number_apk_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(number_double.Text);

            string result = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                    result += $"{i}*{j}={i * j}\t\t";
                result += "\n";
            }
            ansnumber.Text = result;
        }
    }
}