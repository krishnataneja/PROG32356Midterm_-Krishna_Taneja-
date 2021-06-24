using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Krishna_991590578_Midterm
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class BookManagement : Window
    {
        List<Book> books = new List<Book>();
        public BookManagement()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            string genre = null;
            if (rBtnSports.IsChecked == true) genre = rBtnSports.Content.ToString();
            else  if (rBtnFiction.IsChecked == true) genre = rBtnFiction.Content.ToString();
            else genre = rBtnSciFi.Content.ToString();

            Book book = new Book()
            {
                BTitle = txtBTitle.Text,
                BGenre = genre,
                BISBN = Convert.ToInt32(txtBISBN.Text),
                BPrice = Convert.ToDouble(txtBPrice.Text)
            };
            books.Add(book);
        }
    }
}
