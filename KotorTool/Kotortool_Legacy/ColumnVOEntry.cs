// Decompiled with JetBrains decompiler
// Type: kotor_tool.ColumnVOEntry
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class ColumnVOEntry : ColumnEntry
{
    public int DisplayIndex;
    public bool Visible;

    public ColumnVOEntry()
    {
    }

    public ColumnVOEntry(string nativeColumnName, string displayColumnName, bool vis)
        : base(nativeColumnName, displayColumnName)
    {
        Visible = vis;
    }
}