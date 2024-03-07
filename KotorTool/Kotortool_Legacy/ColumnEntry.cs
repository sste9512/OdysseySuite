// Decompiled with JetBrains decompiler
// Type: kotor_tool.ColumnEntry
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class ColumnEntry
{
    public string col_name;
    public string display_name;
    public Type data_type;

    public string nativeColName => col_name;

    public string displayColName => display_name;

    public ColumnEntry()
    {
        }

    public ColumnEntry(string NativeColumnName, string DisplayColumnName)
    {
            col_name = NativeColumnName;
            display_name = DisplayColumnName;
        }

    public ColumnEntry(string NativeColumnName, string DisplayColumnName, Type DataType)
        : this(NativeColumnName, DisplayColumnName)
    {
            data_type = DataType;
        }
}