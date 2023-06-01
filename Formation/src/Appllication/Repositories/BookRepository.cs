using System.Collections.Generic;
using System.Threading.Tasks;

namespace Appllication.Repositories
{
    public interface BookRepository
    {
        Task<int> AddBook(BookDto book);
        Task<IEnumerable<BookDto>> GetAllBooks();
    }
}
