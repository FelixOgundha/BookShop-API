
using Moq;
using BookShop.App.Brokers.Storages;
using BookShop.App.Services.Foundations.Books;
using Xunit;
using BookShop.App.Models.Books;

namespace BookShop.App.Tests.Unit.Services.Foundations
{
    public class BookServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokermock;
        private readonly IBookService bookService;

        public BookServiceTests()
        {
            this.storageBrokermock = new Mock<IStorageBroker>();
            this.bookService = new BookService(storageBroker: this.storageBrokermock.Object);
        }

        [Fact]
        public void ShouldAbbBook()
        {
            //given
            var randomBook = new Book();
            Book inputBook = randomBook;
            Book storageBook = inputBook;
            Book expectedBook = storageBook;

            this.storageBrokermock.Setup(Brokers => Brokers.InsertBook(inputBook)).Returns(storageBook);

            //when


            //then

        }

    }
}
