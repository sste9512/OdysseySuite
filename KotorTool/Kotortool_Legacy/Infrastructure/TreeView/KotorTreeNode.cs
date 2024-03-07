using System.Collections;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy.Infrastructure.TreeView;

public interface IResourceBridge<T>
{
    T ExtractResource();
}

public enum NodeResourceTypes
{
    Erf,
    Rim,
    Biff
}

public sealed class ErfNode : EnhancedTreeNode, IResourceBridge<ClsErf>
{
    
    private readonly NodeContext _nodeContext;

    public ErfNode(NodeContext nodeContext)
    {
        _nodeContext = nodeContext;
        Text = nodeContext.Filename;
        Tag = NodeContext.ErfResourceTag;
        nodeContext.ResourceType = NodeResourceTypes.Erf;
    }


    public ClsErf ExtractResource()
    {
        try
        {
            using var fileStream = new FileStream(_nodeContext.FilePath, FileMode.Open);
            var erf = new ClsErf(fileStream);
        }
        catch(Exception e)
        {
            _nodeContext.CaptureError(e, new[] { "Error extracting ClsErf from file." });
        }

        return null;
    }
}

public sealed class RimNode : EnhancedTreeNode, IResourceBridge<ClsRim>
{
    private readonly NodeContext _nodeContext;

    public RimNode(NodeContext nodeContext)
    {
        _nodeContext = nodeContext;
        Text = nodeContext.Filename;
        Tag = NodeContext.RimResourceTag;
        nodeContext.ResourceType = NodeResourceTypes.Erf;
    }

    public ClsRim ExtractResource()
    {
        try
        {
            var bytes = File.ReadAllBytes(_nodeContext.FilePath);
            return new ClsRim(bytes);
        }
        catch (Exception e)
        {
            _nodeContext.CaptureError(e, new[] { "Error extracting ClsRim from file." });
        }

        return null;
    }
}

public abstract class EnhancedTreeNode : TreeNode, IEnumerable<EnhancedTreeNode>
{
    
    private Dictionary<string, object> MetaData { get; } = new();
    
    private WeakReference<EnhancedTreeNode> _parent;
    
    public bool IsRoot { get; set; }
    public bool IsLeaf => Nodes.Count == 0;

    protected EnhancedTreeNode()
    {
        /*ContextMenu = new ContextMenu();
        ContextMenu.ToolStripMenuItems.AddRange(new ToolStripMenuItem[]
        {
            new ToolStripMenuItem("Copy"),
            new ToolStripMenuItem("Copy as Json"),
            new ToolStripMenuItem("Open in Explorer"),
            new ToolStripMenuItem("Open in Notepad"),
            new ToolStripMenuItem("Open in Hex Editor"),
            new ToolStripMenuItem("Open in Text Editor"),
        });*/
    }
    
    public EnhancedTreeNode Parent
    {
        get => _parent.TryGetTarget(out var parent) ? parent : null;
        set => _parent = new WeakReference<EnhancedTreeNode>(value);
    }
    /// <summary>
    /// Traverse all the nodes parent down from the current node and execute the action on each node
    /// </summary>
    /// <param name="action"></param>
    public void DispatchCommand(Action<EnhancedTreeNode> action)
    {
        action(this);
        foreach (var item in Nodes.Cast<EnhancedTreeNode>())
        {
            item.DispatchCommand(action);
        }
    }

    /// <summary>
    /// Traverse all the nodes parent down from the current node and execute function that returns the aggregate of each node
    /// </summary>
    /// <param name="action"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IEnumerable<T> DispatchQuery<T>(Func<EnhancedTreeNode, T> action)
    {
        var aggregate = new List<T>();
        aggregate.AddRange(Parent.DispatchQuery<T>(action));
        foreach (var item in Nodes.Cast<EnhancedTreeNode>())
        {
            var result = item.DispatchQuery(action);
            aggregate.AddRange(result);
        }
        return aggregate;
    }
    
    public IEnumerator<EnhancedTreeNode> GetEnumerator()
    {
        return (IEnumerator<EnhancedTreeNode>)Nodes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    
    public void AddRange(params EnhancedTreeNode[] nodes)
    {
        
        foreach (var node in nodes)
        {
            node.Parent = this;
            Nodes.Add(node);
        }
    }


    public bool Contains(string key)
    {
        return MetaData.ContainsKey(key);
    }

    public int Count => MetaData.Count;
    
    public void AddMetaData(params (string, object)[] metaData)
    {
        foreach (var (key, value) in metaData)
        {
            MetaData.Add(key, value);
        }
    }

    public IEnumerable<object> this[string key] => new[] { MetaData[key] };
}

public sealed class GenericNode : EnhancedTreeNode
{
    private readonly NodeContext _nodeContext;
    public GenericNode(NodeContext nodeContext)
    {
        _nodeContext = nodeContext;
    }
}

public sealed class BiffNode: EnhancedTreeNode, IResourceBridge<BIFFArchive>
{
    
    private readonly NodeContext _nodeContext;
    public BiffNode(NodeContext nodeContext)
    {
        _nodeContext = nodeContext;
        Text = nodeContext.Filename;
        Tag = NodeContext.RimResourceTag;
        nodeContext.ResourceType = NodeResourceTypes.Biff;
    }

    public BIFFArchive ExtractResource()
    {
        try
        {
            return new BIFFArchive(new FileStream(_nodeContext.FilePath, FileMode.Open));
        }
        catch (Exception e)
        {
            _nodeContext.CaptureError(e, new[] { "Error extracting BIFFArchive from file." });
        }

        return null;
    }
}




public sealed class KotorTreeNode : TreeNode
{
    public string FilePath { get; set; } 
    public int RiMorErFindex { get; set; }
    public int KotorVerIndex { get; set; }
    private readonly string _resourceReference;
    private readonly int _mResId;
    private string _fileName;
    public string ContainingFileType;
    public override string ToString() => Text;
        
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
    public KotorTreeNode() => KotorVerIndex = -1;
    
    
    public KotorTreeNode(string text)
        : base(text)
    {
        KotorVerIndex = -1;
    }

   
    

    public KotorTreeNode(KeyEntry keyEntry)
    {
        KotorVerIndex = -1;
        _mResId = keyEntry.ResId;
        _resourceReference = keyEntry.ResRef;
        ResType = keyEntry.ResourceType;
        Text = keyEntry.ResRef + "." + ResTypeStr;
    }

    public KotorTreeNode(KeyEntry keyEntry, string sourcePath)
        : this(keyEntry)
    {
        FilePath = sourcePath;
    }

    public KotorTreeNode(RimKeyEntry rimKeyEntry)
    {
        KotorVerIndex = -1;
        _mResId = rimKeyEntry._ResourceID;
        _resourceReference = rimKeyEntry._ResourceName;
        ResType = rimKeyEntry._ResType;
        Text = _resourceReference + "." + ResTypeStr + " (" + StringType.FromInteger(rimKeyEntry._Length) + ")";
        Tag = RimResourceTag;
    }
        
       

    public KotorTreeNode(RimKeyEntry rimKeyEntry, string sourcePath)
        : this(rimKeyEntry)
    {
        FilePath = sourcePath;
    }

    public KotorTreeNode(ERFKeyEntry erfKeyEntry)
    {
        KotorVerIndex = -1;
        _mResId = erfKeyEntry._ResourceID;
        _resourceReference = erfKeyEntry._ResourceName;
        ResType = erfKeyEntry._ResType;
        Text = _resourceReference + "." + ResTypeStr;
        Tag = ErfResourceTag;
    }
     

    public KotorTreeNode(ERFKeyEntry erfKeyEntry, string sourcePath)
        : this(erfKeyEntry)
    {
        FilePath = sourcePath;
    }
}