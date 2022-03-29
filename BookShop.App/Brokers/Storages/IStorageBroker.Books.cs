using BookShop.App.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.App.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        Book InsertBook(Book book);

        List<Book> SelectAllBooks();

        Book SelectBookById(Guid id);

        Book UpdateBook(Book book);

        void DeleteBook(Guid id);

    }
}
