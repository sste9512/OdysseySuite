// Decompiled with JetBrains decompiler
// Type: kotor_tool.DialogTlkStrDataElement
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public class DialogTlkStrDataElement
{
  public int Flags;
  public string Text;
  public string SoundResRef;
  public float SoundLength;

  public DialogTlkStrDataElement()
  {
      Text = "";
      SoundResRef = "";
      SoundLength = 0.0f;
    }

  public DialogTlkStrDataElement(
    int EntryFlags,
    string EntryText,
    string EntrySoundResRef,
    float EntrySoundLength = 0.0f)
  {
      Text = "";
      SoundResRef = "";
      SoundLength = 0.0f;
      Flags = EntryFlags;
      Text = EntryText;
      SoundResRef = EntrySoundResRef;
      SoundLength = EntrySoundLength;
    }
}