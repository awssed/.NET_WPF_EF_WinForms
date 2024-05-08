using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4_5_BookShop_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Book> Books { get; set; }
        private void Book_Click(object sender, EventArgs e)
        {
            BookWindow bookWindow = new BookWindow((Book)((StackPanel)sender).DataContext, Books);
            bookWindow.Owner = this;
            bookWindow.Show();
        }
        private void Add_Book_Click(object sender, EventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow(Books);
            addBookWindow.Owner = this;
            addBookWindow.Show();
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Books = new ObservableCollection<Book>()
            {
                new Book { Title = "Book 1", Author = "Author 1", Year = 2020, Genre = Genre.Fiction, Rating = 4.5, PageCount = 300, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                new Book { Title = "Book 2", Author = "Author 2", Year = 2021, Genre = Genre.NonFiction, Rating = 3.8, PageCount = 250, Image = "D:\\Учёба\\4сем\\ОПП\\Lab4-5(BookShop)\\Image\\images.jpg" },
                // Добавьте остальные книги
            };
        }
    }
}