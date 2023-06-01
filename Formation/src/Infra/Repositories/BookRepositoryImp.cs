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
            var author = await _context.Authors.FindAsync(book.AuthorId);
            if (author == null)
            {
                throw new Appllication.Commons.Exceptions.NotFoundException();
            }
            bookEntity.Author = author;
            _context.Books.Add(bookEntity);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
            var books = _context.Books;
            return _mapper.Map<IEnumerable<BookDto>>(books);
        }
    }
}
