namespace Appllication.Book
{
    public record AddBookCommand(
        string Title,
        int AuthorId,
        string Description,
        DateTime PublicationDate) : IRequest<int>
    { }

    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, int>
    {
        private readonly BookRepository _bookRepository;
        public AddBookCommandHandler(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<int> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = new BookDto
            {
                Title = request.Title,
                AuthorId = request.AuthorId,
                Description = request.Description,
                PublicationDate = request.PublicationDate
            };
            int bookId = await _bookRepository.AddBook(book);
            return bookId;
        }

        public class AddBookCommandValidator : AbstractValidator<AddBookCommand>
        {
            public AddBookCommandValidator()
            {
                RuleFor(x => x.Title).NotEmpty();
                RuleFor(x => x.AuthorId).NotEmpty();
                RuleFor(x => x.Description).NotEmpty();
                RuleFor(x => x.PublicationDate).NotEmpty()
                    .GreaterThan(DateTime.Now);
            }
        }
    }
}
