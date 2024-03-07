// Decompiled with JetBrains decompiler
// Type: kotor_tool.ColumnSortEntryList
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class ColumnSortEntryList : ColumnEntryList
{
    public void Copy(ColumnSortEntryList theCopy)
    {
            foreach (ColumnSortEntry columnSortEntry in this)
                theCopy.Add(new ColumnSortEntry(columnSortEntry.col_name, columnSortEntry.display_name, columnSortEntry.sort_direction));
        }
}