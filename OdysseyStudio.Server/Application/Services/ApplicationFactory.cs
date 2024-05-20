using OdysseyStudio.Server.Application.Interfaces;

namespace OdysseyStudio.Server.Application.Services;

public class ApplicationFactory(IServiceProvider serviceProvider) : IApplicationFactory
{
    public T Create<T>() where T : class
    {
        return serviceProvider.GetRequiredService<T>();
    }

    public T? CreateFromKeyed<T>(string key) where T : class
    {
        return serviceProvider.GetKeyedService<T>(key);
    }
}
