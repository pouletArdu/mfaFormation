using Appllication;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.ValidationTest;

public abstract class Testing
{
    private readonly IServiceScopeFactory _scopeFactory;

    public Testing()
    {
        var services = new ServiceCollection();

        services.AddApplication();
        _scopeFactory = services.BuildServiceProvider().GetRequiredService<IServiceScopeFactory>();
    }
    public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
    {
        using var scope = _scopeFactory.CreateScope();

        var mediator = scope.ServiceProvider.GetRequiredService<ISender>();

        return await mediator.Send(request);
    }
}

