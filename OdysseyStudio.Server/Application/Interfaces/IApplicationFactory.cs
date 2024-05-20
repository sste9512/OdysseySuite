namespace OdysseyStudio.Server.Application.Interfaces;

public interface IApplicationFactory
{
    public T Create<T>() where T : class;
    public T? CreateFromKeyed<T>(string key) where T : class;
}
