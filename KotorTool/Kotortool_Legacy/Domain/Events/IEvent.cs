namespace Kotortool_Legacy.Domain.Events;

public interface IEvent
{
    public Guid EventId { get; set; }
}