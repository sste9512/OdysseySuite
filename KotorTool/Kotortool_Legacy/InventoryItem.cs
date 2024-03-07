// Decompiled with JetBrains decompiler
// Type: kotor_tool.InventoryItem
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class InventoryItem
{
    public string _Name;
    public string _ResRef;
    public string _EquipableSlots;
    public int _Quantity;
    public bool _Dropable;

    public InventoryItem(
        string Name,
        string ResRef,
        string EquipableSlots = "",
        int Quantity = 1,
        bool Dropable = true)
    {
            _Name = Name;
            _ResRef = ResRef;
            _EquipableSlots = EquipableSlots;
            _Quantity = Quantity;
            _Dropable = Dropable;
        }

    public string Text
    {
        get
        {
                string text = _Name + " (" + _ResRef + ")";
                if (_Quantity > 1)
                    text = text + "\tQty: " + StringType.FromInteger(_Quantity);
                return text;
            }
    }
}