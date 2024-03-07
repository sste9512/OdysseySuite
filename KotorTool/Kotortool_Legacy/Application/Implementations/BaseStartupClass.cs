using Kotortool_Legacy.Application.Interfaces;

namespace Kotortool_Legacy.Application.Implementations;

public class BaseStartup : IStartup
{
    private readonly IApplicationStore _applicationStore;

    public BaseStartup(IApplicationStore applicationStore)
    {
        _applicationStore = applicationStore;
    }

    public async Task Initialise(CancellationToken cancellationToken = default)
    {



    }
}
