namespace Kotortool_Legacy.API.AuroraParsers.Biff;

public struct FResourceHeader
{
    public UInt32 ID;
    public UInt32 Offset;
    public UInt32 PartCount;
    public UInt32 FileSize;
    public UInt32 ResourceType;
}