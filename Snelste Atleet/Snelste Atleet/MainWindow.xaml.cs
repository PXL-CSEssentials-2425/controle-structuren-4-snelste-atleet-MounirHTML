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

namespace Snelste_Atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string nameFastest;
        int secondFastest = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {

            int secondsCurrent;
            bool isValidNumber = int.TryParse(textBoxSec.Text, out secondsCurrent);

            if (isValidNumber == true)
            {
                if (secondsCurrent < secondFastest)
                {
                    secondFastest = secondsCurrent;
                    nameFastest = textBoxNaam.Text;
                }

            }
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Resultaat.Clear();
            textBoxNaam.Clear();
            textBoxSec.Clear();

            textBoxNaam.Focus();
        }

        private void atleetButton_Click(object sender, RoutedEventArgs e)
        {
            Resultaat.Text = $"De snelste atleet is {nameFastest} met een tijd van {secondFastest} seconden.";
        }

    }
}

            
        
                

               
            
        