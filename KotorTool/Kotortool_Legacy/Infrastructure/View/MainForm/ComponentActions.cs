using System.Diagnostics;
using Autofac;
using Kotortool_Legacy.Application.Implementations;
using Kotortool_Legacy.Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public class ComponentActions : IComponentActions
{
    private IList<BaseEvent> _baseEvents = new List<BaseEvent>();
    public Guid Id { get; } = Guid.NewGuid();

    /// <summary>
    /// 
    /// </summary>
    private AutofacInternalFactory AutofacInternalFactory => Singleton<AutofacInternalFactory>.GetInstance();

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T Resolve<T>()
    {
        try
        {
            return AutofacInternalFactory.Create<T>();
        }
        catch (Exception e)
        {
            return default; 
        }
    }

    public async Task DispatchEvents(params BaseEvent[] @events)
    {
        var mediator = AutofacInternalFactory.Create<IMediator>();
        foreach (var @event in @events)
        {
            Console.WriteLine(@event.GetType().ToString());
            _baseEvents.Add(@event);
            await mediator.Publish(@event);
        }
    }

    public ILifetimeScope ResolveScoped()
    {
        try
        {
            return AutofacInternalFactory.ResolveScoped();
        }
        catch (Exception e)
        {
            return default;
        }
    }

    public void CaptureError(Exception exception, string[] reasons)
    {
        var store = Resolve<IErrorAggregationStore>();
        store.AddError(exception.Message, exception, reasons);
        var trace = new StackTrace(exception, true);
        var frame = trace.GetFrames().Last();
        var lineNumber = frame.GetFileLineNumber();
        var fileName = frame.GetFileName();
        var message = $"Error: {exception.Message} at {fileName}:{lineNumber}";
        var logger = Resolve<ILogger<AppForm>>();
        logger.LogError(message);
    }

    public async Task<T> Send<T>(IRequest<T> request)
    {
        var sender = AutofacInternalFactory.Create<ISender>();
        return await sender.Send(request);
    }
}