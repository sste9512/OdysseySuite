using Kotortool_Legacy.Application.Interfaces;
using MediatR;

namespace Kotortool_Legacy.Application.Implementations;

public sealed class BaseEventBus : IEventBus
{
    
    private readonly IMediator _bus;

    public BaseEventBus(IMediator bus)
    {
        _bus = bus;
    }

 
    public async Task<T> Publish<T>(T @event, CancellationToken cancellationToken = default) where T : class
    {
        await _bus.Publish(@event, cancellationToken: default);
        return default;
    }

    public Task<T> Subscribe<T>(T @event)
    {
        return default;
    }

  
}