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
    /// Логика взаимодействия для AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
       public AddBookWindow()
        {
          InitializeComponent();
        }
        public AddBookWindow(ObservableCollection<Book> Books)
        {
            InitializeComponent();
            Book book=new Book();
            DataContext=book;
            
        }
        public AddBookWindow(Book book)
        {
            InitializeComponent();

            // Установка значений полей из объекта Book
            DataContext = book;
        }
       
    }
}
