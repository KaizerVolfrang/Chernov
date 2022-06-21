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
        private variant3Entities1 _context;
        private User user;
        private string UserLogin;
        private string UserPassword;
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
            // StringBuilder errors = new StringBuilder();
            // if (string.IsNullOrEmpty(UserLogin))
            //     errors.AppendLine("Введите логин");
            // if (string.IsNullOrEmpty(UserPassword))
            //     rrors.AppendLine("Введите пароль");
            //     MessageBox.Show(errors.ToString()); 
            if (string.IsNullOrEmpty(loginTextBlock.Text) || (string.IsNullOrEmpty(passwordTextBlock.Text))) 
            {
                MessageBox.Show("Введите корректные данные");
                return;
            }
            
            

            user = new User()
            {
                UserLogin = this.loginTextBlock.Text,
                UserPassword = this.passwordTextBlock.Text
            };
            variant3Entities1.GetContext().User.Add(user);
           // variant3Entities1.GetContext().SaveChanges();

            Product productWindow = new Product();
            productWindow.Show();
            Close();
        }
    }
}
