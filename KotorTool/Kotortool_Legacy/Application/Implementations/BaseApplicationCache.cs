namespace Kotortool_Legacy.Application.Implementations;

// ReSharper disable once InconsistentNaming
/*public sealed class IntVector<SIZE> where SIZE : Constant<long>, new()
{
    private static readonly long Size = new SIZE();

    private IntVector()
    {
        if (Vector.IsHardwareAccelerated)
        {
                
        }
        var array = new int[Size];
        var vector = new Vector<int>(array);
    }

    private readonly int[] array = new int[Size];
        
    private Vector<int> _vector = new(new int[Size]);
        
    public int this[int index] => _vector[index];
}*/

/*internal sealed class Ten : Constant<long>
{
    public Ten(): base(10){}
}*/


public class BaseApplicationCache  //: IApplicationCache
{
       
    /*private readonly ConcurrentCache<string, string> _concurrentCache;

    public BaseApplicationCache(ILoggerFactory loggerFactory)
    {
            
        _concurrentCache = new ConcurrentCache<string, string>(100, CacheEvictionPolicy.LRU)
        {
            Eviction = static (string key, string value) =>
                Console.WriteLine($"Evicted entry: key = {key}, value = {value}"),
        };
    }*/
        
        
    /*public bool TryAdd<T>(string key, T value)
    {
        var json = JsonSerializer.Serialize(value);
            
        return _concurrentCache.TryAdd(key, json);
    }

    public bool TryGetValue<T>(string key, out T value)
    {
        if (!_concurrentCache.TryGetValue(key, out var newValue))
            throw new JsonException();
              
        value = JsonSerializer.Deserialize<T>(newValue);
        return true;
    }*/
}