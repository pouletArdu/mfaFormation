namespace Appllication.Author;

public class AddAuthorCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public string Gender { get; set; }
}

public class AddAuthorCommandHandler : IRequestHandler<AddAuthorCommand, int>
{
    private readonly AuthorRepository _AuthorRepository;

    public AddAuthorCommandHandler(AuthorRepository AuthorRepository)
    {
        _AuthorRepository = AuthorRepository;
    }

    public async Task<int> Handle(AddAuthorCommand request, CancellationToken cancellationToken)
    {
        var Author = new AuthorDto
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Gender = request.Gender,
        };

        return await _AuthorRepository.Add(Author);
    }

    public class AddAuthorCommandValidator : AbstractValidator<AddAuthorCommand>
    {
        public AddAuthorCommandValidator()
        {
            RuleFor(v => v.FirstName)
                .MaximumLength(50)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
            RuleFor(v => v.LastName)
                .MaximumLength(50)
                .NotEmpty();
            RuleFor(v => v.Email)
                .MaximumLength(150)
                .Must(IsValidEmail)
                .NotEmpty();
        }


        private bool IsValidEmail(string arg)
        {
            return arg.Contains("@");
        }
    }
}
