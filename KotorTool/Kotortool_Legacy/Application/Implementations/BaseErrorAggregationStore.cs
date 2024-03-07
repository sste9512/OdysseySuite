using Kotortool_Legacy.Application.Interfaces;
using ArgumentNullException = System.ArgumentNullException;

namespace Kotortool_Legacy.Application.Implementations;

public class BaseErrorAggregationStore : IErrorAggregationStore
{
    private readonly IEventBus _eventBus;

    List<Tuple<string, Exception, string[]>> errors = new();

    public BaseErrorAggregationStore(IEventBus eventBus)
    {
        _eventBus = eventBus;
    }

    public async void AddError(string error, Exception exception, string[] reasons)
    {
        if (error == null) throw new ArgumentNullException(nameof(error));
        if (exception == null) throw new ArgumentNullException(nameof(exception));

        errors.Add(new Tuple<string, Exception, string[]>(error, exception, reasons));

        await _eventBus.Publish(new ErrorOccurredEvent(error, exception, reasons));
    }

    public void ClearErrors()
    {
        errors.Clear();
    }
}