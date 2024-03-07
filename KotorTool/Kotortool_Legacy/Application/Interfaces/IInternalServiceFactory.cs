namespace Kotortool_Legacy.Application.Interfaces;

public interface IInternalServiceFactory
{
    public Task<T> CreateAsync<T>();
    
    public T Create<T>(string name = default);
}