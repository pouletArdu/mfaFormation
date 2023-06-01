using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Appllication.Book
{
    public record GetAllBooksQuery() : IRequest<IEnumerable<BookDto>>
    { }

    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<BookDto>>
    {
        private readonly BookRepository _bookRepository;

        public GetAllBooksQueryHandler(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetAllBooks();
            return books;
        }
    }
}
