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
                Title = txtBTitle.Text,
                Genre = genre,
                ISBN = Convert.ToInt32(txtBISBN.Text),
                Price = Convert.ToDouble(txtBPrice.Text)
            };
            books.Add(book);
            MessageBox.Show("New Book Added");
        }

        private void dGridBooksList_Loaded(object sender, RoutedEventArgs e)
        {
            dGridBooksList.ItemsSource = books;
        }

        private void dGridBooksList_Unloaded(object sender, RoutedEventArgs e)
        {
            dGridBooksList.ItemsSource = null;
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            List<Book> tmpBooks = new List<Book>();
            string genre = null;
            if (rBtnCSports.IsChecked == true) genre = rBtnCSports.Content.ToString();
            else if (rBtnCFiction.IsChecked == true) genre = rBtnCFiction.Content.ToString();
            else genre = rBtnCSciFi.Content.ToString();

            foreach (Book b in books)
            {
                if(b.Genre.Equals(genre, StringComparison.CurrentCultureIgnoreCase))
                {
                    tmpBooks.Add(b);
                }
            }
            lstBoxSearchBook.DataContext = tmpBooks;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int eISBN = Convert.ToInt32(txtBoxEnterISBN.Text);
            double ePrice = Convert.ToDouble(txtBoxEnterPrice.Text);

            foreach (Book b in books)
            {
                if(b.ISBN==eISBN)
                {
                    b.Price = ePrice;
                    MessageBox.Show("Price Updated");
                }
                else
                {
                    MessageBox.Show("No Book Found");
                }
            }
        }
    }
}
