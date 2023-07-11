using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCRUD
{
    public class Book1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string aname { get; set; }
        public double price { get; set; }
    }
    public class BookCRUD1
    {
        List<Book1> books;
        public BookCRUD1()
        {
            books = new List<Book1>();
        }
        public void AddBook(Book1 b)
        {
            books.Add(b);
        }
        public List<Book1> GetBooks()
        {
            return books;
        }
        public void UpdateBook(Book1 b)
        {
            foreach (Book1 book in books)
            {
                if (book.id == b.id)
                    book.name = b.name;
                book.price = b.price;
                break;

            }
        }
        public void DeleteBook(int id)
        {
            foreach (Book1 book in books)
            {
                if (book.id == id)
                {
                    books.Remove(book);
                }
                break;
            }
        }
    }
}
