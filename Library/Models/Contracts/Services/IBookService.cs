using Library.Models.Entities;

namespace Library.Models.Contracts.Services
{
    public interface IBookService
    {
        List<BookDTO> List();
        void Add(BookDTO book);
        BookDTO SearchById(string id);
        void UpdateBook(BookDTO book);
    }
}
