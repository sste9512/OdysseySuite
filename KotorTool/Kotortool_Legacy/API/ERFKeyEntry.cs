

namespace Kotortool_Legacy.API;

public struct ErfKeyEntryData
{
    public string ResourceName;
    public short ResType;
    // Requires identification of the resource type
    public string ResTypeStr;
    public int ResourceId;
    public int Offset;
    public int Length;
    public int Index;
}

public static class StructExtensions
{
    public static void Init(this ErfKeyEntryData erfKeyEntryData)
    {
        erfKeyEntryData.ResourceName = string.Empty;
        erfKeyEntryData.ResType = 0;
        erfKeyEntryData.ResTypeStr = string.Empty;
        erfKeyEntryData.ResourceId = 0;
        erfKeyEntryData.Offset = 0;
        erfKeyEntryData.Length = 0;
        erfKeyEntryData.Index = 0;
    }
}


public class ERFKeyEntry
{
    public string _ResourceName;
    public short _ResType;
    public string _ResTypeStr;
    public int _ResourceID;
    public int _Offset;
    public int _Length;
    public int _Index;

    public ERFKeyEntry()
    {
    }

    public ERFKeyEntry(
        string ResourceName,
        short ResType,
        int ResourceID,
        int Offset,
        int Length,
        int index)
    {
        _ResourceName = ResourceName;
        _ResType = ResType;
        _ResTypeStr = ResourceIdentification.FindResourceTypeForId(ResType);
        _ResourceID = ResourceID;
        _Offset = Offset;
        _Length = Length;
        _Index = index;
    }
}