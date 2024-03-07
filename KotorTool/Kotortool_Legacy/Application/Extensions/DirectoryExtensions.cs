namespace Kotortool_Legacy.Application.Extensions;

public static class DirectoryExtensions
{
     public static bool IsDirectory(this string filePath)
     {
         return (File.GetAttributes(filePath) & FileAttributes.Directory)== FileAttributes.Directory;
     }
}
