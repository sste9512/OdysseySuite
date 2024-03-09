namespace AuroraParsers.AuroraParsers.Chitin;

public struct KeyTable
{
    public char[] ResRef;
    public ushort ResourceType;
    public uint ResId;

    public override string ToString()
    {
        return $"{nameof(ResRef)}: {ResRef}, {nameof(ResourceType)}: {ResourceType}, {nameof(ResId)}: {ResId}";
    }
}