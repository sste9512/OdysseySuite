using System.Diagnostics;

namespace Kotortool_Legacy.Application.Extensions;

public static class Exceptions
{
    public static StackTrace FromException(this Exception e)
    {
        var trace = new StackTrace(e, true);
        var frame = trace.GetFrames().Last();
        var lineNumber = frame.GetFileLineNumber();
        var fileName = frame.GetFileName();
        var message = $"Error: {e.Message} at {fileName}:{lineNumber}";
        return new StackTrace(e, true);
    }
}