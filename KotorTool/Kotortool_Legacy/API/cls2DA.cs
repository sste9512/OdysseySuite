// Decompiled with JetBrains decompiler
// Type: kotor_tool.cls2DA
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.API;

public class Cls2Da
{
    protected byte[] Ary2da;
    protected Array Ary2daStrings;
    public string[] RowLabels;
    public string[] ColNames;
    protected int NumRows;
    protected int NumColumns;

    public int RowCount => NumRows;

    public int RowsUpperBound => checked(NumRows - 1);

    public int ColumnCount => NumColumns;

    public int ColumnUpperBound => checked(NumColumns - 1);

    public Cls2Da(byte[] raw2daData)
    {
        Ary2da = raw2daData;
        CreateDataTable();
    }

    public void CreateDataTable()
    {
        var asciiEncoding = new ASCIIEncoding();
        var num1 = checked(Ary2da.Length - 1);
        var index1 = 9;
        while (index1 <= num1 && Ary2da[index1] != 0)
            checked
            {
                ++index1;
            }

        var index2 = checked(index1 + 1);
        NumRows = checked((int)Math.Round(Ary2da[index2] + Ary2da[checked(index2 + 1)] * 256.0 +
                                          Ary2da[checked(index2 + 2)] * 65536.0 +
                                          Ary2da[checked(index2 + 3)] * 16777216.0));

        ColNames = Strings.Split(asciiEncoding.GetString(Ary2da, 9, checked(index1 - 10)), "\t");
        NumColumns = ColNames.Length;
        Ary2daStrings = new string[NumRows, checked(NumColumns + 1)];


        var num2 = 0;
        var num3 = checked(index2 + 4);
        var num4 = checked(Ary2da.Length - 1);
        var index3 = num3;
        while (index3 <= num4)
        {
            if (Ary2da[index3] == 9)
            {
                checked
                {
                    ++num2;
                }

                if (num2 == NumRows)
                    break;
            }

            checked
            {
                ++index3;
            }
        }

        var num5 = checked(index3 + 1);
        var num6 = num5;
        RowLabels = Strings.Split(asciiEncoding.GetString(Ary2da, checked(index2 + 4), checked(num5 - index2 - 5)),
            "\t");
        var num7 = checked(num5 + (NumRows * NumColumns + 1) * 2);
        var num8 = checked(NumRows - 1);
        var index4 = 0;
        while (index4 <= num8)
        {
            LateBinding.LateIndexSet(Ary2daStrings, new object[3]
            {
                index4,
                0,
                RowLabels[index4]
            }, null);
            var num9 = checked(ColNames.Length - 1);
            var num10 = 0;
            while (num10 <= num9)
            {
                var index5 = checked((num10 + index4 * NumColumns) * 2 + num6);
                var byteIndex = checked(num7 + Ary2da[index5] + 256 * Ary2da[index5 + 1]);
                var num11 = byteIndex;
                var num12 = checked(Ary2da.Length - 1);
                var index6 = num11;
                while (index6 <= num12 && Ary2da[index6] != 0)
                    checked
                    {
                        ++index6;
                    }

                var str = index6 <= byteIndex
                    ? "****"
                    : asciiEncoding.GetString(Ary2da, byteIndex, checked(index6 - byteIndex));
                LateBinding.LateIndexSet(Ary2daStrings, new object[3]
                {
                    index4,
                    checked(num10 + 1),
                    str
                }, null);
                checked
                {
                    ++num10;
                }
            }

            checked
            {
                ++index4;
            }
        }
    }

    public Array GetRow(object rowNumber)
    {
        if (Ary2daStrings == null)
        {
            Array row = null;
            return row;
        }

        var row1 = new string[checked(NumColumns + 1)];
        var num = checked(NumColumns - 1);
        var index = 0;
        while (index <= num)
        {
            row1[index] = StringType.FromObject(LateBinding.LateIndexGet(Ary2daStrings, new object[2]
            {
                RuntimeHelpers.GetObjectValue(rowNumber),
                index
            }, null));
            checked
            {
                ++index;
            }
        }

        return row1;
    }

    public string GetIndiceData(int rowNumber, int colNumber)
    {
        if (Ary2daStrings == null)
        {
            string indiceData = null;
            return indiceData;
        }

        return StringType.FromObject(LateBinding.LateIndexGet(Ary2daStrings, new object[2]
        {
            rowNumber,
            colNumber
        }, null));
    }

    public string GetIndiceData(int rowNumber, string colName)
    {
        var num = Array.IndexOf((Array)ColNames, colName);
        string indiceData = null;
        try
        {
            if (Ary2daStrings != null)
            {
                if (num != -1)
                    indiceData = StringType.FromObject(LateBinding.LateIndexGet(Ary2daStrings, new object[2]
                    {
                        rowNumber,
                        checked(num + 1)
                    }, null));
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            indiceData = "ERROR";
            ProjectData.ClearProjectError();
        }

        return indiceData;
    }

    public string GetIndiceData(string rowName, int colNumber)
    {
        var num = Array.IndexOf((Array)RowLabels, rowName);
        if (Ary2daStrings != null && num != -1)
            return StringType.FromObject(LateBinding.LateIndexGet(Ary2daStrings, new object[2]
            {
                checked(num + 1),
                colNumber
            }, null));

        string indiceData = null;
        return null;
    }

    public string GetIndiceData(string rowName, string colName)
    {
        var num1 = Array.IndexOf((Array)ColNames, colName);
        var num2 = Array.IndexOf((Array)RowLabels, rowName);

        if (Ary2daStrings == null || num1 == -1 || num2 == -1)
        {
            string indiceData = null;
            return null;
        }

        return StringType.FromObject(LateBinding.LateIndexGet(Ary2daStrings, new object[2]
        {
            checked(num2 + 1),
            checked(num1 + 1)
        }, null));
    }
}