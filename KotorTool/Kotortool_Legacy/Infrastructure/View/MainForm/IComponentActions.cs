using Autofac;
using MediatR;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public interface IComponentActions
{
    T Resolve<T>();
    Task DispatchEvents(params BaseEvent[] @events);
    ILifetimeScope ResolveScoped();
    void CaptureError(Exception exception, string[] reasons);
    Task<T> Send<T>(IRequest<T> request);
}