// Decompiled with JetBrains decompiler
// Type: kotor_tool.ComboBoxListItem
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy.Application;

public class ComboBoxListItem
{
  private int m_TwoDAIndex;
  private string m_Text;
  private string m_ListBoxName;

  public ComboBoxListItem()
  {
    }

  public ComboBoxListItem(int TwoDAIndex, string Text, string ListBoxName = "")
  {
      m_TwoDAIndex = TwoDAIndex;
      m_Text = Text;
      m_ListBoxName = ListBoxName;
    }

  public string Text => m_Text;

  public int TwoDAIndex => m_TwoDAIndex;

  public string ListBoxName => m_ListBoxName;
}