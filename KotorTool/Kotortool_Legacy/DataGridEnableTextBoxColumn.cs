// Decompiled with JetBrains decompiler
// Type: kotor_tool.DataGridEnableTextBoxColumn
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class DataGridEnableTextBoxColumn //: DataGridTextBoxColumn
{
  private int _col;

  public DataGridEnableTextBoxColumn()
  {
    }

  public DataGridEnableTextBoxColumn(int column) => _col = column;

  /*protected override void Edit(
    CurrencyManager source,
    int rowNum,
    Rectangle bounds,
    bool readOnly,
    string instantText,
    bool cellIsVisible)
  {
    }*/
}