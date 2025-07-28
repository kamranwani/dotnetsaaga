using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Book
    {
        public string title;
        public string author;
        public int year;
        public static int bookCount = 0;


        public Book()
        {
            title = "Unknown";
            author = "Anonymous";
            year = 0;
            bookCount++;
        }
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            bookCount++;

        }
        public Book(Book copyBook)
        {
            title = copyBook.title;
            author = copyBook.author;
            year = copyBook.year;
            bookCount++;

        }

        public void DisplayBook()
        {
            Console.WriteLine($"{title} is written by {author} in {year}");
        }

        public void updateField(string field, string value)
        {
            if (field == "title")
            {
                this.title = value;
            }
            else if (field == "author")
            {
                this.author = value;
            }
            else if (field == "year")
            {
                bool isParsed = int.TryParse(value, out int updatedValue);
                if (isParsed)
                {
                    this.year = updatedValue;
                }
            }
        }

        public bool IsSameBook(Book otherBook)
        {
            return this.title == otherBook.title &&
                   this.author == otherBook.author &&
                   this.year == otherBook.year;
        }
        public static void ShowTotalbooks() {
            Console.WriteLine(bookCount);
        }
        public static void ShowLatestBook(int year, Book[] library)
        {
            foreach(Book book in library)
            {
                if (year == book.year)
                {
                    Console.WriteLine(book.title);
                }
            }  
        }
    }
}
