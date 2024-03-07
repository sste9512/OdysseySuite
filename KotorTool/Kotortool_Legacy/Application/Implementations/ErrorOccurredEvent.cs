using Kotortool_Legacy.Domain.Events;

namespace Kotortool_Legacy.Application.Implementations;

public class ErrorOccurredEvent : IEvent
{
    public Guid EventId { get; set; }
    
    private readonly string _error;
    private readonly Exception _exception;
    private readonly string[] _reasons;

    public ErrorOccurredEvent(string error, Exception exception, string[] reasons)
    {
        _error = error;
        _exception = exception;
        _reasons = reasons;
    }

    

    public override string ToString()
    {
        return $"{nameof(_error)}: {_error}, {nameof(_exception)}: {_exception}, {nameof(_reasons)}: {_reasons}, {nameof(EventId)}: {EventId}";
    }
}