using Library.Models.Contracts.Repositories;
using Library.Models.Contracts.Services;
using Library.Models.Entities;

namespace Library.Models.Services
{
    public class BookService : IBookService
    {
        public readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(BookDTO book)
        {
            _bookRepository.Add(book);
        }

        public void Delete(BookDTO book)
        {
            _bookRepository.Delete(book);
        }

        public List<BookDTO> List()
        {
            return _bookRepository.List();
        }

        public BookDTO SearchById(string id)
        {
            return _bookRepository.SearchById(id);
        }

        public void UpdateBook(BookDTO book)
        {
            _bookRepository.UpdateBook(book);
        }
    }
}
