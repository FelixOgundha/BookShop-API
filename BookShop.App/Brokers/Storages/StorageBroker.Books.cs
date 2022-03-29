using BookShop.App.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.App.Brokers.Storages
{
    public partial class StorageBroker : IStorageBroker
    {
        List<Book> Books = new List<Book>();

        public void DeleteBook(Guid id)
        {
            Books.RemoveAll(book => book.Id == id);    
        }

        public Book InsertBook(Book book)
        {
            Books.Add(book);

            return book;
        }

        public List<Book> SelectAllBooks()
        {
            return Books;
        }

        public Book SelectBookById(Guid id)
        {
            var book = Books.Find(book => book.Id == id);

            return book;
        }

        public Book UpdateBook(Book book)
        {

            Books.RemoveAll(book => book.Id == book.Id);

            Books.Add(book);

            return book;
        }
    }
}
