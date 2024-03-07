// Decompiled with JetBrains decompiler
// Type: kotor_tool.GFFList
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;

namespace Kotortool_Legacy;

public class GFFList
{
    public int size;
    public ArrayList structIndices;

    public GFFList(int count)
    {
            size = count;
            structIndices = new ArrayList(count);
            if (count <= 0)
                return;
            int num1 = checked(count - 1);
            int num2 = 0;
            while (num2 <= num1)
            {
                structIndices.Add(-1);
                checked
                {
                    ++num2;
                }
            }
        }
}