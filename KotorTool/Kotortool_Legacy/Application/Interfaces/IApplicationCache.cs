namespace Kotortool_Legacy.Application.Interfaces;

public interface IApplicationCache
{
    bool TryAdd<T>(string key, T value);
    bool TryGetValue<T>(string key, out T value);
}