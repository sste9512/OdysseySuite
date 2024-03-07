// Decompiled with JetBrains decompiler
// Type: kotor_tool.RIMKeyEntry
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public struct RimKeyEntry
{
    public string _ResourceName;
    public short _ResType;
    public string _ResTypeStr;
    public short _ResourceID;
    public int _Offset;
    public int _Length;
    public int _Index;

    public RimKeyEntry()
    {
        }

    public RimKeyEntry(
        string ResourceName,
        short ResType,
        short resourceId,
        int Offset,
        int Length,
        int index)
    {
            _ResourceName = ResourceName;
            _ResType = ResType;
            _ResTypeStr = ResourceIdentification.FindResourceTypeForId(ResType);
            _ResourceID = resourceId;
            _Offset = Offset;
            _Length = Length;
            _Index = index;
        }
}