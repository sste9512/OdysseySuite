using System.Text;

namespace Kotortool_Legacy.Application;

public static class StreamExtensions
{
     public static BinaryReader AsAsciiBinaryReader(this string filePath)
     { 
          var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
          return new BinaryReader(fileStream, Encoding.ASCII);
     }
     
     public static BinaryReader AsAsciiBinaryReaderWithOffset(this string filePath, long offset)
     { 
          var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
          fileStream.Seek(offset, SeekOrigin.Begin);
          return new BinaryReader(fileStream, Encoding.ASCII);
     }

     public static MemoryStream ProduceMemoryStream(this BinaryReader binaryReader)
     {
          var bytes = new byte[checked((int)(binaryReader.BaseStream.Length - 1L) + 1)];
          bytes = binaryReader.ReadBytes(checked((int)binaryReader.BaseStream.Length));
          return new MemoryStream(bytes, false);
     }
}