using System.Buffers;

namespace Kotortool_Legacy.Domain.Interfaces;

public interface IOwnsMany<T>
{
    IMemoryOwner<T> MemoryOwner { get; set; }
}