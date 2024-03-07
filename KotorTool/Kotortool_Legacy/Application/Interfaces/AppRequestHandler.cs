using Kotortool_Legacy.Infrastructure.View.MainForm;
using MediatR;

namespace Kotortool_Legacy.Application.Interfaces;

public abstract class AppRequestHandler<T, TU> : ComponentActions, IRequestHandler<T, TU> where T : IRequest<TU>
{
    
    
    public new async Task<TU> Handle(T request, CancellationToken cancellationToken)
    {
        return await HandleNext(request, cancellationToken);
    }

    protected abstract Task<TU> HandleNext(T request, CancellationToken cancellationToken);
}

