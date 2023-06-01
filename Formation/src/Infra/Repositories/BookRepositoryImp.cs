using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class BookRepositoryImp :AbstractRepositoryImp, BookRepository
    {
        public BookRepositoryImp(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<int> AddBook(BookDto book)
        {
            var bookEntity = _mapper.Map<Book>(book);
            _context.Books.Add(bookEntity);
            return await _context.SaveChangesAsync();
        }
    }
}
