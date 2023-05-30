namespace Appllication.Client;

public class DeleteClientCommand : IRequest<bool>
{
    public int Id { get; set; }
}

public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, bool>
{
    private readonly ClientRepository _clientRepository;

    public DeleteClientCommandHandler(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {
        return await _clientRepository.Delete(request.Id);
    }

    public class DeleteClientCommandValidator : AbstractValidator<DeleteClientCommand>
    {
        public DeleteClientCommandValidator()
        {
            RuleFor(v => v.Id).GreaterThan(0).WithMessage("{PropertyName} should be greater than zero.");
        }
    }
}
