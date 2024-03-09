// Decompiled with JetBrains decompiler
// Type: kotor_tool.RowFilterPart
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using Microsoft.VisualBasic.CompilerServices;
using System.Xml.Serialization;

namespace Kotortool_Legacy;

public class RowFilterPart
{
    private string _mNativeColName;
    private string _mDisplayColName;
    private string _mFilterText;
    private string _mMatchOper;
    private string _mConcatOper;
    private string _mDatatype;

    public RowFilterPart()
    {
    }

    public RowFilterPart(
        string nativeColName,
        string displayColName,
        string matchOper,
        string filterText,
        string concatOper,
        string dataType)
    {
        _mNativeColName = nativeColName;
        _mDisplayColName = displayColName;
        _mMatchOper = matchOper;
        _mFilterText = filterText;
        _mConcatOper = concatOper;
        _mDatatype = dataType;
    }

    public string NativeColumnName
    {
        get => _mNativeColName;
        set => _mNativeColName = value;
    }

    public string DisplayColumnName
    {
        get => _mDisplayColName;
        set => _mDisplayColName = value;
    }

    public string MatchOperator
    {
        get => _mMatchOper;
        set => _mMatchOper = value;
    }

    public string FilterText
    {
        get => _mFilterText;
        set => _mFilterText = value;
    }

    public string ConcatOperator
    {
        get => _mConcatOper;
        set => _mConcatOper = value;
    }

    public string Datatype
    {
        get => _mDatatype;
        set => _mDatatype = value;
    }

    [XmlIgnore] public string QuotedFilterText => QuoteFilterText();
    [XmlIgnore]
    public string FilterString => _mNativeColName + " " + _mMatchOper + " " + QuoteFilterText() +
                                  " " + _mConcatOper;

    private string QuoteFilterText()
    {
        string str = string.Empty;
        if (StringType.StrCmp(_mMatchOper, "IN", false) == 0 ||
            StringType.StrCmp(_mMatchOper, "NOT IN", false) == 0 ||
            StringType.StrCmp(_mDatatype, "Int32", false) == 0)
            str = _mFilterText;
        else if (StringType.StrCmp(Datatype, "Date", false) == 0)
            str = "#" + _mFilterText + "#";
        else if (StringType.StrCmp(Datatype, "String", false) == 0)
            str = "'" + _mFilterText + "'";
        return str;
    }
}