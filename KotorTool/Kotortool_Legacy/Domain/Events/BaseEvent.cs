using MediatR;

namespace Kotortool_Legacy.Domain.Events;

public class BaseEvent : INotification
{
    public Guid Id { get; } = Guid.NewGuid();
}