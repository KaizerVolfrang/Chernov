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
using System.Windows.Shapes;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            Show();
            Close();
        }

        private void autButton_Click(object sender, RoutedEventArgs e)
        {
            var login = loginTextBlock.Text;
            var password = passwordTextBlock.Text;
            Hide();
            Product productWindow = new Product();
            productWindow.ShowDialog();
            Show();
            Close();
        }
    }
}
