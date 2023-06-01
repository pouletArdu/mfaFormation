namespace Appllication.Author
{
    public class AddAuthorCommand : IRequest<int>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, int>
    {
        private readonly AuthorRepository _repository;

        public AddAuthorCommandHandler(AuthorRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = new AuthorDto
            {
                LastName = request.LastName,
                FirstName = request.FirstName,
                BirthDate = request.BirthDate
            };

            return await _repository.AddAuthor(author);
        }
    }

    public class AddAuthorCommandValidator : AbstractValidator<AddAuthorCommand>
    {
        public AddAuthorCommandValidator()
        {
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.BirthDate).NotEmpty();
        }
    }
}
