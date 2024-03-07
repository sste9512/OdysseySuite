// Decompiled with JetBrains decompiler
// Type: kotor_tool.TreeBaseItem
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class TreeBaseItem
{
  public string _itemtype;
  public string _label;
  public string _name;
  public string _slots;
  public int _index;

  public TreeBaseItem(int index, string itemtype, string label, string name, string slots)
  {
      _index = index;
      _itemtype = itemtype;
      _label = label;
      _name = name;
      _slots = slots;
    }
}