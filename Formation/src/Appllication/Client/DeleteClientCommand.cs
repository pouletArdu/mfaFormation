namespace Appllication.Client;

public class DeleteClientCommand : IRequest
{
    public int Id { get; set; }
}

public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand>
{
    private readonly ClientRepository _clientRepository;

    public DeleteClientCommandHandler(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {
        await _clientRepository.Delete(request.Id);
    }
}

public class DeleteClientCommandValidator : AbstractValidator<DeleteClientCommand>
{
    public DeleteClientCommandValidator()
    {
        RuleFor(v => v.Id)
            .NotNull().WithMessage("{PropertyName} is required.")
            .GreaterThan(0);
    }
}