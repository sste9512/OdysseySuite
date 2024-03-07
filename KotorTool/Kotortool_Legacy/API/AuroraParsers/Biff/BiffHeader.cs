namespace Kotortool_Legacy.API.AuroraParsers.Biff;

public struct BiffHeader
{
    public char[] FileType;
    public char[] FileVersion;
    public UInt32 VariableResourceCount;
    public UInt32 FixedResourceCount;
    public UInt32 VariableTableOffset;
}