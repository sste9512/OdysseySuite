using Kotortool_Legacy.Application.Interfaces;
using Kotortool_Legacy.Infrastructure.View.MainForm;
using Microsoft.Extensions.DependencyInjection;

namespace Kotortool_Legacy.Application.Implementations;

public sealed class InternalServiceFactory(IServiceProvider serviceProvider) : IInternalServiceFactory
{
    public async Task<T> CreateAsync<T>()
    {
        return serviceProvider.GetRequiredService<T>();
    }

    public T Create<T>(string name = default)
    {
        var service = serviceProvider.GetRequiredService<T>();

        if (service.HasProperty("InternalServiceFactory"))
        {
            service.SetPrivateProperty<IInternalServiceFactory>("InternalServiceFactory", this);
        }

        return service;
    }

    public async Task<T> CreateKeyed<T>(string key)
    {
        return serviceProvider.GetRequiredKeyedService<T>(key);
    }
}