// Decompiled with JetBrains decompiler
// Type: kotor_tool.AnimListEntry
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public sealed class AnimListEntry
{
    private string m_Participant;
    private int m_Animation;

    public AnimListEntry()
    {
    }

    public AnimListEntry(string Participant, int Animation)
    {
        m_Participant = Participant;
        m_Animation = Animation;
    }

    public object Participant
    {
        get => m_Participant;
        set => m_Participant = StringType.FromObject(value);
    }

    public object Animation
    {
        get => m_Animation;
        set => m_Animation = IntegerType.FromObject(value);
    }
}