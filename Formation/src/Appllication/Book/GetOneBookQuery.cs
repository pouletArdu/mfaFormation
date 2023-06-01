namespace Appllication.Book
{
    public record GetOneBookQuery(int Id) : IRequest<BookDto>
    {
    }

    public class GetOneBookCommandHandler : IRequestHandler<GetOneBookQuery, BookDto>
    {
        private readonly BookRepository _bookRepository;
        public GetOneBookCommandHandler(BookRepository BookRepository)
        {
            _bookRepository = BookRepository;
        }
        public async Task<BookDto> Handle(GetOneBookQuery request, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetOne(request.Id);
        }
    }
    public class GetOneBookCommandValidator : AbstractValidator<GetOneBookQuery>
    {
        public GetOneBookCommandValidator()
        {
            RuleFor(v => v.Id)
                .NotNull().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
    }
}
