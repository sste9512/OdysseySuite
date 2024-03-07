using System.Text;

namespace Kotortool_Legacy.API;

public static class MemoryStreamExtensions
{
    public static MemoryStream JumpTo(this MemoryStream memoryStream, long position)
    {
        memoryStream.Seek(position, SeekOrigin.Begin);
        return memoryStream;
    }

    public static BinaryReader BuidBinaryReader(this byte[] buffer)
    {
        var memoryStream = new MemoryStream(buffer);
        var binaryReader = new BinaryReader(memoryStream, Encoding.ASCII);
        return new BinaryReader(memoryStream);
    }
}