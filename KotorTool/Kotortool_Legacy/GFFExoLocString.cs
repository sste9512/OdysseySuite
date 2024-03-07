// Decompiled with JetBrains decompiler
// Type: kotor_tool.GFFExoLocString
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

namespace Kotortool_Legacy;

public sealed class GFFExoLocString
{
    public int size;
    public int StringRef;
    public int StringCount;
    public object[] subStringArr;

    public GFFExoLocString()
    {
        }

    public GFFExoLocString(string Text, int LanguageID = 0)
    {
            switch (Text)
            {
                case "":
                case null:
                    StringCount = 0;
                    StringRef = -1;
                    break;
                default:
                    StringCount = 1;
                    StringRef = -1;
                    subStringArr = (object[])Array.CreateInstance(typeof(object), 1);
                    subStringArr[0] = new GFFExoLocSubString()
                    {
                        StringID = LanguageID,
                        StringLength = Text.Length,
                        value = Text
                    };
                    size = checked(16 + Text.Length);
                    break;
            }
        }
}