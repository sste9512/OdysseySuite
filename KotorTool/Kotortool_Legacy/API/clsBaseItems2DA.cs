// Decompiled with JetBrains decompiler
// Type: kotor_tool.clsBaseItems2DA
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class ClsBaseItems2Da : Cls2Da
{
    public ClsBaseItems2Da(byte[] raw2daData)
        : base(raw2daData)
    {
    }

    public void PrintItemNamesAndTypes(clsDialogTlk dialogtlk)
    {
        int rowsUpperBound = RowsUpperBound;
        int rowNumber = 0;
        while (rowNumber <= rowsUpperBound)
        {
            object indiceData = GetIndiceData(rowNumber, "name");
            object vRight = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) ? "****" : (object)dialogtlk.GetString(IntegerType.FromObject(indiceData));
            Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(GetIndiceData(rowNumber, "itemtype") + "," + GetIndiceData(rowNumber, "label") + ",", vRight), ","),
                GetIndiceData(rowNumber, "equipableslots")));
            checked
            {
                ++rowNumber;
            }
        }
    }

    public ArrayList GetItemNamesAndTypesList(clsDialogTlk dialogtlk)
    {
        var namesAndTypesList = new ArrayList();
        var rowsUpperBound = RowsUpperBound;
        var num = 0;
        while (num <= rowsUpperBound)
        {
            object indiceData = GetIndiceData(num, "name");
            object obj = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) ? "(" + GetIndiceData(num, "label") + ")" : (object)dialogtlk.GetString(IntegerType.FromObject(indiceData));
            namesAndTypesList.Add(new TreeBaseItem(num, GetIndiceData(num, "itemtype"), GetIndiceData(num, "label"), StringType.FromObject(obj), GetIndiceData(num, "equipableslots")));
            checked
            {
                ++num;
            }
        }

        return namesAndTypesList;
    }
}