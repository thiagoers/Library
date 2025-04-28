using Library.Models.Contracts.Repositories;
using Library.Models.Entities;

namespace Library.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(BookDTO book)
        {
            ContextDataFake.List.Add(book);
        }

        public List<BookDTO> List()
        {
            var books = ContextDataFake.List.OrderBy(x => x.Name).ToList();
            return books;
        }
    }
}
