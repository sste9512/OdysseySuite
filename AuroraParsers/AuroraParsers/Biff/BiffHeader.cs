namespace AuroraParsers.AuroraParsers.Biff;

public struct BiffHeader
{
    public char[] FileType;
    public char[] FileVersion;
    public uint VariableResourceCount;
    public uint FixedResourceCount;
    public uint VariableTableOffset;
}