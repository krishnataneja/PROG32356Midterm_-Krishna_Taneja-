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

namespace Krishna_991590578_Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ABCBookstoreKrishna : Window
    {
        public ABCBookstoreKrishna()
        {
            InitializeComponent();
        }
        private void btnFunctionPage_Click(object sender, RoutedEventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
            this.Close();
        }

        private void btnLandingExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
