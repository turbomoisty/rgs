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

namespace _106._2
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

        private void tbMultiLine_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BTNCLICK(object sender, RoutedEventArgs e)
        {
            User_login objuser_Login = new User_login();
            this.Visibility = Visibility.Hidden;
            objuser_Login.Show();
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AdminPage(object sender, RoutedEventArgs e)
        {
            Admin_Login objAdmin_Login = new Admin_Login();
            this.Visibility = Visibility.Hidden;
            objAdmin_Login.Show();
        }
    }

}
