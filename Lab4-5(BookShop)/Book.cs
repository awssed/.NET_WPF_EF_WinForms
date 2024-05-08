using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab4_5_BookShop_
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Mystery,
        Romance,
        Fantasy,
        ScienceFiction,
        Biography,
        Poetry
    }

    public class Book:IDataErrorInfo
    {   
        public string Title { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        public int PageCount { get; set; }
        public string Description { get; set; }
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Author":
                        if(Regex.IsMatch(Author, @"\d"))
                        {
                            error = "Корректное имя требуется";
                        }
                        break;
                    case "Year":
                        if(Year<0 ||Year>2024)
                        {
                            error = "Неккоректный год";
                        }
                        break;
                    case "PageCount":
                        if(PageCount<0)
                        {
                            error = "Только положительные значения";
                        }
                        break;
                    case "Rating":
                        if(Rating<0||Rating>10)
                        {
                            error = "Рэйтинг от 0 и до 10";
                        }
                        break;

                }
                return error;

            }

        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        // Конструктор без параметров
        public Book()
        {
        }

        // Конструктор с параметрами
        public Book(string title, string author, int year, Genre genre, double rating, int pageCount, string image, string description)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            Rating = rating;
            PageCount = pageCount;
            Image = image;
            Description = description;
        }
        
    }
}
