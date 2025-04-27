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

        public List<BookDTO> List()
        {
            return _bookRepository.List();
        }
    }
}
