using Kotortool_Legacy.Infrastructure.View.MainForm;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.Infrastructure.TreeView;

public sealed class NodeContext : ComponentActions
{
    public string ContainingFileType;
    public NodeResourceTypes ResourceType { get; set; }
    public string FilePath { get; set; }
    public int RiMorErFindex { get; set; }
    public int KotorVerIndex { get; set; }


    private readonly string _resourceReference;
    private readonly int _mResId;
    private string _fileName;

    //private ComponentActions ComponentActions { get; } = new();
    

    //public override string ToString() => Text;

    public const string ErfResourceTag = "ERF_Res";

    public const string RimResourceTag = "RIM_Res";

    public string Filename
    {
        get => StringType.StrCmp(_fileName, string.Empty, false) != 0
            ? _fileName
            : _resourceReference + "." + ResourceIdentification.FindResourceTypeForId(ResType);
        set => _fileName = value;
    }

    public string ResTypeStr => ResourceIdentification.FindResourceTypeForId(ResType);
    public int ResType { get; set; }
    public string ResRef => _resourceReference;
    public int LocalResId => _mResId & 1048575;
    public int ResId => _mResId;
    public int BiffFileNum => _mResId >> 20;
}