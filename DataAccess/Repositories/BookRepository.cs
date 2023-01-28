using DataAccess.Context;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public interface IBookRepository
    {
        Book CreateBook(Book book);
        List<Book> GetAllBooks();
        Book GetBook();
    }

    public class BookRepository : IBookRepository
    {
        private readonly DatabaseContext _dbContext;

        public BookRepository(DatabaseContext context)
        {
            _dbContext = context;
        }

        public Book CreateBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return book;
        }

        public List<Book> GetAllBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBook()
        {
            throw new NotImplementedException();
        }
    }
}
