namespace Kotortool_Legacy.API.AuroraParsers.Chitin;

public struct KeyHeader
{
    public char[] FileType;
    public char[] FileVersion;
    public uint BifCount;
    public uint KeyCount;
    public uint OffsetToFileTable;
    public uint OffsetToKeyTable;
    public uint BuildYear;
    public uint BuildDay;
    public byte[] Reserved;

    public override string ToString()
    {
        return $"{nameof(FileType)}: {FileType}, {nameof(FileVersion)}: {FileVersion}, {nameof(BifCount)}: {BifCount}, {nameof(KeyCount)}: {KeyCount}, {nameof(OffsetToFileTable)}: {OffsetToFileTable}, {nameof(OffsetToKeyTable)}: {OffsetToKeyTable}, {nameof(BuildYear)}: {BuildYear}, {nameof(BuildDay)}: {BuildDay}, {nameof(Reserved)}: {Reserved}";
    }
}