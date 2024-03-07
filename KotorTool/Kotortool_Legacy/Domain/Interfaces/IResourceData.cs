using System.Buffers;

namespace Kotortool_Legacy.Domain.Interfaces;

public interface IResourceData
{
    IMemoryOwner<byte> Data { get; set; }
}