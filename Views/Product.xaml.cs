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
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();
            //ConnectOdb.conObj = new variant3Entities1();
            RefreshData();
        }

        private void RefreshData()
        {
            DGridProduct.ItemsSource = variant3Entities1.GetContext().Product.ToList();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            StartWindow startWindow = new StartWindow();
            startWindow.ShowDialog();
            Show();
            Close();
        }
    }
}
