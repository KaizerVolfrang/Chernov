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
using WpfApp1.AppDataFile;
namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public variant3Entities1 _context;
        public RegistrationWindow()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            Show();
        }


        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            var login = loginTextBlock.Text;
            if (string.IsNullOrEmpty(login))
                errors.AppendLine("Введите логин");
            var password = passwordTextBlock.Text;
            if (string.IsNullOrEmpty(password))
            {
                errors.AppendLine("Введите пароль");

                MessageBox.Show(errors.ToString()); 
            }
            else
            {
                return;
            }

            variant3Entities1.GetContext().SaveChanges();

            Hide();
            Product productWindow = new Product();
            productWindow.ShowDialog();
            Show();
            Close();
        }
    }
}
