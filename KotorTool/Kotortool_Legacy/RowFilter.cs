// Decompiled with JetBrains decompiler
// Type: kotor_tool.RowFilter
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Xml.Serialization;

namespace Kotortool_Legacy;

[Serializable]
public class RowFilter
{
  public string GD_type;
  public bool active;
  private ArrayList m_FilterParts;

  public RowFilter()
  {
      active = false;
      m_FilterParts = new ArrayList();
    }

  [XmlArray]
  [XmlArrayItem(typeof (RowFilterPart))]
  public ArrayList FilterParts
  {
    get => m_FilterParts;
    set => m_FilterParts = value;
  }

  public object FilterString()
  {
      string str = null;
      try
      {
        foreach (RowFilterPart filterPart in m_FilterParts)
          str = str + filterPart.FilterString + " ";
      }
      finally
      {
       
      }
      return str;
    }
}