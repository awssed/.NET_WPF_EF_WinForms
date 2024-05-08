using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab4_5_BookShop_
{
    /// <summary>
    /// Логика взаимодействия для BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {        
        private ObservableCollection<Book> books;


        public BookWindow(Book book, ObservableCollection<Book> Books)
        {
            InitializeComponent();
            DataContext = book;
            books = Books;
        }
        private void Change_Book(object sender, EventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow((Book)this.DataContext);
            addBookWindow.Show();
        }
        private void BookDelete(object sender, EventArgs e)
        {
            books.Remove((Book)DataContext);
        }
        
    }
}
