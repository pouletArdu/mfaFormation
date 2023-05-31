namespace Application.Client;

public class GetOneClientCommand : IRequest<ClientDto>
{
    public int Id { get; set; }
}

public class GetOneClientCommandHandler : IRequestHandler<GetOneClientCommand, ClientDto>
{
    private readonly ClientRepository _clientRepository;

    public GetOneClientCommandHandler(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<ClientDto> Handle(GetOneClientCommand command, CancellationToken cancellationToken)
    {
        return await _clientRepository.GetOne(command.Id);
    }
}

public class GetOneClientCommandValidator : AbstractValidator<GetOneClientCommand>
{
    public GetOneClientCommandValidator()
    {
        RuleFor(v => v.Id)
            .NotNull().WithMessage("{PropertyName} is required.")
            .GreaterThan(0);
    }
}