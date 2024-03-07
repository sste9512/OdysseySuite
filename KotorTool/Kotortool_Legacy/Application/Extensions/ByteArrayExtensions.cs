namespace Kotortool_Legacy.Application.Extensions;

public static class ByteArrayExtensions
{
    public static void WriteByteArray(this byte[] byteArray , string outputPath)
    {
        using var binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create));
        binaryWriter.Write(byteArray);
    }
}