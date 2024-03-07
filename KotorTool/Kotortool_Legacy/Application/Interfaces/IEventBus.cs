namespace Kotortool_Legacy.Application.Interfaces;

public interface IEventBus
{
    public Task<T> Publish<T>(T @event, CancellationToken cancellationToken = default) where T : class;

    public Task<T> Subscribe<T>(T @event);
}