using Library.Models.Contracts.Repositories;
using Library.Models.Entities;
using Microsoft.CodeAnalysis.Operations;

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

        public BookDTO SearchById(string id)
        {
            var book = ContextDataFake.List.FirstOrDefault(x => x.Id == id);
            return book;
        }

        public void UpdateBook(BookDTO book)
        {
            var bookRemoved = ContextDataFake.List.FirstOrDefault(x => x.Id == book.Id);
            ContextDataFake.List.Remove(bookRemoved);

            var updatedBook = new BookDTO() { Author = $"{book.Author}", Name = $"{book.Name}", Publisher = $"{book.Publisher}" };
            Add(updatedBook);
        }
    }
}
