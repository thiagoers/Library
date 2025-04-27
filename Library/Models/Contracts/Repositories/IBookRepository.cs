using Library.Models.Entities;

namespace Library.Models.Contracts.Repositories
{
    public interface IBookRepository
    {
        List<BookDTO> List();
    }
}
