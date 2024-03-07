using System.Collections;

namespace Kotortool_Legacy.API.Graphs;

public interface INode<T> : IEnumerable<INode<T>>
{
    public Dictionary<string, object> MetaData { get; set; }
    
    public INode<T> Parent { get; set; }
    
    public IEnumerable<INode<T>> Children { get; set; }
    
    T Value { get; set; }
}

public interface IGameResourceGraph
{
    INode<T> Root<T>();
}

public class GameResourceGraph : IGameResourceGraph
{
    public INode<T> Root<T>()
    {
        throw new System.NotImplementedException();
    }
}

public class BaseNode<T> : INode<T>
{
    public Dictionary<string, object> MetaData { get; set; }
    public INode<T> Parent { get; set; }
    public IEnumerable<INode<T>> Children { get; set; }
    public T Value { get; set; }

    public BaseNode()
    {
        MetaData = new Dictionary<string, object>();
    }
    
    public IEnumerator<INode<T>> GetEnumerator()
    {
        return Children.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}