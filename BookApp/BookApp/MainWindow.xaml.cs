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

namespace BookApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> mybook = new List<Book>();
        Book bk = new Book();
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear()
        {

            txtAuthor.Text = "";
            txtPrice.Text = "";
            txtTitle.Text = "";
            lblStatus.Content = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtTitle.Text != "" && txtAuthor.Text != "" && txtPrice.Text != "")
                {
                    Book bookdetails = new Book();
                    bookdetails.Title = txtTitle.Text;
                    bookdetails.Author = txtAuthor.Text;
                    bookdetails.Price = Convert.ToInt32(txtPrice.Text);
                    mybook.Add(bookdetails);
                    MessageBox.Show("BookDetails added Successfully", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please fill the details", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

                // lblStatus.Content = "1 of " + mybook.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bk != null)
                {
                    mybook.Remove(bk);
                    MessageBox.Show("BookDetails Deleted Successfully", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please select the BookDetails", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            if(mybook.Count>0)
            {
                i = 0;
                bk = mybook[i];
                txtTitle.Text = bk.Title.ToString();
                txtAuthor.Text = bk.Author.ToString();
                txtPrice.Text = bk.Price.ToString();
                lblStatus.Content = (i + 1).ToString() + " of " + mybook.Count.ToString();
            }
        }
        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            if (mybook.Count > 0)
            {
                i = mybook.Count - 1;
                bk = mybook[i];
                txtTitle.Text = bk.Title.ToString();
                txtAuthor.Text = bk.Author.ToString();
                txtPrice.Text = bk.Price.ToString();
                lblStatus.Content = (i + 1).ToString() + " of " + mybook.Count.ToString();
            }

        }
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (mybook.Count > 0)
            {
                if(i==mybook.Count-1 || i!=0)
                {
                    i--;
                    bk = mybook[i];
                    txtTitle.Text = bk.Title.ToString();
                    txtAuthor.Text = bk.Author.ToString();
                    txtPrice.Text = bk.Price.ToString();
                    lblStatus.Content = (i + 1).ToString() + " of " + mybook.Count.ToString();

                }
            }
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (mybook.Count > 0)
            {
                if (i <mybook.Count-1)
                {
                    i++;
                    bk = mybook[i];
                    txtTitle.Text = bk.Title.ToString();
                    txtAuthor.Text = bk.Author.ToString();
                    txtPrice.Text = bk.Price.ToString();
                    
                    lblStatus.Content = (i+1).ToString() + " of " + mybook.Count.ToString();

                }
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

            Clear();
        }
    }
}
