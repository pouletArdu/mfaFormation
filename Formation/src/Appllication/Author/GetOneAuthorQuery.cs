public record GetOneAuthorQuery(int Id) : IRequest<AuthorDto>
    {
    }

    public class GetOneAuthorCommandHandler : IRequestHandler<GetOneAuthorQuery, AuthorDto>
    {
        private readonly AuthorRepository _authorRepository;
        public GetOneAuthorCommandHandler(AuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<AuthorDto> Handle(GetOneAuthorQuery request, CancellationToken cancellationToken)
        {
            return await _authorRepository.GetOne(request.Id);
        }
    }
    public class GetOneAuthorCommandValidator : AbstractValidator<GetOneAuthorQuery>
    {
        public GetOneAuthorCommandValidator()
        {
            RuleFor(v => v.Id)
                .NotNull().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
    }