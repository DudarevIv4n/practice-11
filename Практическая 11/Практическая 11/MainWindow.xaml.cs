using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Практическая_11
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GetInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Дударев И. В. ИСП-34. \nВариант 4.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void FindForSecond_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("2\\+*3");
            MatchCollection matches = regex.Matches(inputsecond.Text);
            string result = "";
            for (int i = 0; i < matches.Count; i++)
            {
                result += matches[i] + " ";
            }
            resultsecond.Text = result;
        }

        private void FindForFirst_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("ab+a");
            MatchCollection matches = regex.Matches(inputfirst.Text);
            string result = "";
            for (int i = 0; i < matches.Count; i++)
            {
                result += matches[i] + " ";
            }
            reuslttextox.Text = result;
        }

    }
}
