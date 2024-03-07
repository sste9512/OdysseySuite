// Decompiled with JetBrains decompiler
// Type: kotor_tool.ColumnEntryList
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class ColumnEntryList : ArrayList
{
  public const int NativeColumnName = 1;
  public const int DisplayColumnName = 2;

  public void Copy(ColumnEntryList theCopy)
  {
      try
      {
        foreach (ColumnEntry columnEntry in this)
          theCopy.Add(new ColumnEntry(columnEntry.col_name, columnEntry.display_name));
      }
      finally
      {
        
      }
    }

  public int IndexOf(string searchStr, int column = 1)
  {
      int num = checked (Count - 1);
      int index = 0;
      while (index <= num)
      {
        ColumnEntry columnEntry = (ColumnEntry) this[index];
        switch (column)
        {
          case 1:
            if (StringType.StrCmp(Strings.LCase(columnEntry.col_name), Strings.LCase(searchStr), false) == 0)
              return index;
            break;
          case 2:
            if (StringType.StrCmp(Strings.LCase(columnEntry.display_name), Strings.LCase(searchStr), false) == 0)
              return index;
            break;
        }
        checked { ++index; }
      }
      return -1;
    }

  public bool get_ColumnVisible(string ColumnName) => BooleanType.FromObject(LateBinding.LateGet(this[IndexOf(ColumnName, 1)], null, "visible", new object[0], null, null));

  public void set_ColumnVisible(string ColumnName, bool Value) => LateBinding.LateSetComplex(this[IndexOf(ColumnName, 1)], null, "visible", new object[1]
    {
      Value
    }, null, false, true);
}