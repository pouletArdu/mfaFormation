namespace Application.Client;

public class AddClientCommand : IRequest<int>
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
}

public class AddClientCommandHandler : IRequestHandler<AddClientCommand, int>
{
    private readonly ClientRepository _clientRepository;

    public AddClientCommandHandler(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<int> Handle(AddClientCommand command, CancellationToken cancellationToken)
    {
        var client = new ClientDto
        {
            LastName  = command.LastName,
            FirstName = command.FirstName,
            Email     = command.Email
        };

        return await _clientRepository.Add(client);
    }
}

public class AddClientCommandValidator : AbstractValidator<AddClientCommand>
{
    public AddClientCommandValidator()
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