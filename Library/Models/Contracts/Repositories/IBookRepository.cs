using Library.Models.Entities;

namespace Library.Models.Contracts.Repositories
{
    public interface IBookRepository
    {
        List<BookDTO> List();
        void Add(BookDTO book);
        BookDTO SearchById(string id);
        void UpdateBook(BookDTO book);
        void Delete(BookDTO book);
    }
}
