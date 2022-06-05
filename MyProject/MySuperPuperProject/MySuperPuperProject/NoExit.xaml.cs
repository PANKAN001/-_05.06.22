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

namespace MySuperPuperProject
{
    /// <summary>
    /// Логика взаимодействия для NoExit.xaml
    /// </summary>
    public partial class NoExit : Page
    {
        public NoExit()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ButPokaz_Click(object sender, RoutedEventArgs e)
        {
            Password2.Text = Password.Password.ToString();
            ButSkryt.Visibility = Visibility.Visible; ButPokaz.Visibility = Visibility.Hidden;
            Password2.Visibility = Visibility.Visible; Password.Visibility = Visibility.Hidden;
        }

        private void ButSkryt_Click(object sender, RoutedEventArgs e)
        {
            ButSkryt.Visibility = Visibility.Hidden; ButPokaz.Visibility = Visibility.Visible;
            Password2.Visibility = Visibility.Hidden; Password.Visibility = Visibility.Visible;
        }
    }
}
