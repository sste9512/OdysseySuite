// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmMain
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using Kotortool_Legacy.API;
using Kotortool_Legacy.Application.Interfaces;
using Kotortool_Legacy.Infrastructure.TreeView;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Kotortool_Legacy;

public class FrmMain : Form
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly IErrorAggregationStore _errorAggregationStore;
    private readonly IApplicationInfo _applicationInfo;
    private readonly IInternalServiceFactory _internalServiceFactory;
    private readonly IApplicationCache _applicationCache;


    private IContainer components;
    public static string GRootPath;
    public static frmImageViewer GImageViewer;
    public static ChitinKey GK1ChitinKey;
    public static ChitinKey GK2ChitinKey;
    public static BIFFArchive GK1TemplatesBif;
    public static BIFFArchive GK2TemplatesBif;
    public static Form Mainform;
    private ArrayList[,] _biffEntryListArray;
    private ArrayList[] _biffEntries;
    private KotorTreeNode _lastClickedTvNode;
    private KotorTreeNode _secondToLastClickedTvNode;
    private byte[] _buffer;
    public static UserSettings Usetting = new();
    public static Options CurrentSettings;
    private string[] _cmdArgs;
    private bool _hasK1; 
    private bool _hasK2;
    private Form _gCmdLineOpenedForm;
    private int _gAbbbIndex;

    public FrmMain(string[] CmdArgs)
    {
        Load += Form1_Load;
        Closing += frmMain_Closing;
        Move += frmMain_Move;
        Activated += frmMain_Activated;
        _biffEntryListArray = new ArrayList[2, 31];
        _biffEntries = new ArrayList[3];
        _hasK1 = false;
        _hasK2 = false;
        _gAbbbIndex = 0;
        InitializeComponent();
        _cmdArgs = CmdArgs;
    }

    public FrmMain()
    {
        Load += Form1_Load;
        Closing += frmMain_Closing;
        Move += frmMain_Move;
        Activated += frmMain_Activated;
        _biffEntryListArray = new ArrayList[2, 31];
        _biffEntries = new ArrayList[3];
        _hasK1 = false;
        _hasK2 = false;
        _gAbbbIndex = 0;
        InitializeComponent();
    }

    public FrmMain(
        ILoggerFactory loggerFactory,
        IErrorAggregationStore errorAggregationStore,
        IApplicationInfo applicationInfo, 
        IInternalServiceFactory internalServiceFactory,
        IApplicationCache applicationCache)
    {
        _loggerFactory = loggerFactory;
        _errorAggregationStore = errorAggregationStore;
        _applicationInfo = applicationInfo;
        _internalServiceFactory = internalServiceFactory;
        _applicationCache = applicationCache;
        Load += Form1_Load;
        Closing += frmMain_Closing;
        Move += frmMain_Move;
        Activated += frmMain_Activated;
        _biffEntryListArray = new ArrayList[2, 31];
        _biffEntries = new ArrayList[3];
        _hasK1 = false;
        _hasK2 = false;
        _gAbbbIndex = 0;
        InitializeComponent();
        _applicationCache.TryAdd("CmdArgs", _cmdArgs);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }


    [DebuggerStepThrough]
    private void InitializeComponent()
    {
        components = new Container();
    }

    public static ChitinKey K1ChitinKey()
    {
        return GK1ChitinKey ??= new ChitinKey(UserSettings.GetSettings().KeyFileLocation(0));
    }

    public static ChitinKey K2ChitinKey()
    {
        return GK2ChitinKey ??= new ChitinKey(UserSettings.GetSettings().KeyFileLocation(1));
    }

    public static ChitinKey KxChitinKey(int KotorVerIndex)
    {
        if (KotorVerIndex == 0)
            return K1ChitinKey();
        ChitinKey chitinKey = null;
        return KotorVerIndex == 1 ? K2ChitinKey() : chitinKey;
    }

    public static BIFFArchive K1TemplatesBif()
    {
        return GK1TemplatesBif ??= new BIFFArchive(new FileStream(
            UserSettings.GetSettings().KotorLocation(0) + @"\data\templates.bif", FileMode.Open,
            FileAccess.Read, FileShare.ReadWrite, 200000));
    }

    private static BIFFArchive K2TemplatesBif()
    {
        return GK2TemplatesBif ??= new BIFFArchive(new FileStream(
            UserSettings.GetSettings().KotorLocation(1) + @"\data\templates.bif", FileMode.Open,
            FileAccess.Read, FileShare.ReadWrite, 200000));
    }

    private static BIFFArchive KxTemplatesBif(int KotorVerIndex)
    {
        if (KotorVerIndex == 0)
            return K1TemplatesBif();
        BIFFArchive biffArchive = null;
        return KotorVerIndex == 1 ? K2TemplatesBif() : biffArchive;
    }


    // Move to Extensions
    private void SetupTreeRoots()
    {
        var node1 = new KotorTreeNode("Kotor I")
        {
            Tag = "Kotor1",
            FilePath = CurrentSettings.defaultKotORLocation
        };
        //TreeView.Nodes.Add(node1);

        var node2 = new KotorTreeNode("Kotor II")
        {
            Tag = "Kotor2",
            FilePath = CurrentSettings.defaultKotORLocation2
        };
        //TreeView.Nodes.Add(node2);
    }

    private void SetupRootChildren(KotorTreeNode Root)
    {
        var node1 = new KotorTreeNode("BIFs")
        {
            Tag = "BIFF_Root",
            FilePath = ""
            //FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\data"
        };
        var node2 = new KotorTreeNode("")
        {
            Tag = "dummy"
        };
        node1.Nodes.Add(node2);
        Root.Nodes.Add(node1);
        var node3 = new KotorTreeNode("RIMs")
        {
            Tag = "RIM_Root",
            FilePath = ""
            //FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\Modules"
        };
        var node4 = new KotorTreeNode("Modules")
        {
            Tag = "RIM_Modules"
        };
        var node5 = new KotorTreeNode(string.Empty)
        {
            Tag = "dummy"
        };
        node4.Nodes.Add(node5);
        node3.Nodes.Add(node4);
        var node6 = new KotorTreeNode("Rims")
        {
            Tag = "RIM_Rims"
        };
        var node7 = new KotorTreeNode(string.Empty)
        {
            Tag = "dummy"
        };
        node6.Nodes.Add(node7);
        node3.Nodes.Add(node6);
        Root.Nodes.Add(node3);
        var node8 = new KotorTreeNode("ERFs")
        {
            Tag = "ERF_Root",
            FilePath = ""
            //FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\texturePacks"
        };
        var node9 = new KotorTreeNode("TexturePacks")
        {
            Tag = "ERF_TexturePacks"
        };
        var node10 = new KotorTreeNode("")
        {
            Tag = "dummy"
        };
        node9.Nodes.Add(node10);
        node8.Nodes.Add(node9);
        Root.Nodes.Add(node8);
        var node11 = new KotorTreeNode("Modules")
        {
            Tag = "ERF_Modules"
        };
        var node12 = new KotorTreeNode(string.Empty)
        {
            Tag = "dummy"
        };
        node11.Nodes.Add(node12);
        node8.Nodes.Add(node11);
        var node13 = new KotorTreeNode("Saves")
        {
            Tag = "Saves_Root",
            FilePath = ""
            //FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\Saves"
        };
        var node14 = new KotorTreeNode(string.Empty)
        {
            Tag = "dummy"
        };
        node13.Nodes.Add(node14);
        Root.Nodes.Add(node13);
    }

    private async Task BuildTreeView(KotorTreeNode Root, bool noProgressIndication = false)
    {
        var childForm = await _internalServiceFactory.CreateAsync<FrmProgressMeter>();
        var relativePositioner = await _internalServiceFactory.CreateAsync<utilWindowRelativePositioner>();
        //var relativePositioner = new utilWindowRelativePositioner(this, childForm);
        var filePath = Root.FilePath;
        var index1 = NodeTreeRootIndex(Root);
        var fileStream = new FileStream(CurrentSettings.KeyFileLocation(index1), FileMode.Open, FileAccess.Read,
            FileShare.ReadWrite, 600000);
        var binaryReader = new BinaryReader(fileStream);
        childForm.Message = "Preparing Resource List";
        childForm.Status = "Reading key file";
        ((Control)childForm).Location = relativePositioner.GetConcentric();
        childForm.StepAmount = 5;
        Root.Nodes[0].Nodes.Clear();
        //TreeView.BeginUpdate();
        var now = DateAndTime.Now;
        fileStream.Seek(8L, SeekOrigin.Begin);
        var capacity = binaryReader.ReadInt32();
        var num1 = binaryReader.ReadInt32();
        var num2 = binaryReader.ReadInt32();
        var offset = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        
        _biffEntries[index1] = new ArrayList(capacity);
        var num3 = checked(capacity - 1);
        var index2 = 0;
        while (index2 <= num3)
        {
            _biffEntries[index1].Add(new BiffEntry(index2, fileStream, checked(num2 + 12 * index2)));
            _biffEntryListArray[index1, index2] = new ArrayList();
            checked
            {
                ++index2;
            }
        }

        try
        {
            foreach (BiffEntry biffEntry in _biffEntries[index1])
            {
                var node = new KotorTreeNode(Strings.Mid(biffEntry.Filename,
                    checked(biffEntry.Filename.LastIndexOf("\\") + 2)))
                {
                    Tag = "BIFF",
                    Filename = Strings.Mid(biffEntry.Filename, checked(biffEntry.Filename.LastIndexOf("\\") + 2)),
                    FilePath = filePath + "\\" +
                               Strings.Mid(biffEntry.Filename, 1, biffEntry.Filename.LastIndexOf("\\")),
                    ContainingFileType = "BIF"
                };
                Root.Nodes[0].Nodes.Add(node);
                Console.WriteLine("Bif name: " + biffEntry.Filename + "  Length: " +
                                  StringType.FromInteger(biffEntry.FileLength));
            }
        }
        finally
        {
        }

        fileStream.Seek(offset, SeekOrigin.Begin);
        now = DateAndTime.Now;
        var numArray = new byte[checked((int)fileStream.Length + 1)];
        fileStream.Position = 0L;
        fileStream.Read(numArray, 0, checked((int)(fileStream.Length - 1L)));
        if (!noProgressIndication)
            childForm.Show();
        var num4 = num1 / 20;
        var num5 = checked(num1 - 1);
        var index3 = 0;
        while (index3 <= num5)
        {
            var keyEntry = new KeyEntry(index3, numArray, checked(offset + 22 * index3));
            _biffEntryListArray[index1, keyEntry.ResId >> 20].Add(keyEntry);
            if (index3 / num4 == index3 / (double)num4)
                childForm.StepUp();
            checked
            {
                ++index3;
            }
        }

        childForm.Progress = 0;
        var buildModelsBifNode = CurrentSettings.bBuildModelsBifNode;
        var num6 = 0;
        var num7 = checked(capacity - 1);
        var index4 = 0;
        while (index4 <= num7)
        {
            childForm.Status = "Building tree for " + ((BiffEntry)_biffEntries[index1][index4]).Filename;
            if (index4 != 18 || buildModelsBifNode)
            {
                var treeNode = (TreeNode)new KotorTreeNode();
                var num8 = checked(_biffEntryListArray[index1, index4].Count - 1);
                var index5 = 0;
                while (index5 <= num8)
                {
                    var node = new KotorTreeNode((KeyEntry)_biffEntryListArray[index1, index4][index5])
                    {
                        Tag = "BIFF_Res",
                        ContainingFileType = "BIF",
                        FilePath = filePath + "\\" + ((BiffEntry)_biffEntries[index1][index4]).Filename
                    };
                    OrganizeNodesByResType((KotorTreeNode)treeNode, node);
                    if (num6 / num4 == num6 / (double)num4)
                        childForm.StepUp();
                    checked
                    {
                        ++num6;
                    }

                    checked
                    {
                        ++index5;
                    }
                }

                AttachNodeParentsSortedByDesc((KotorTreeNode)Root.Nodes[0].Nodes[index4], (KotorTreeNode)treeNode);
            }

            checked
            {
                ++index4;
            }
        }

        //TreeView.EndUpdate();
        childForm.Hide();
    }

    private void OrganizeNodesByResType(KotorTreeNode Collection, KotorTreeNode node)
    {
        try
        {
            foreach (KotorTreeNode node1 in Collection.Nodes)
            {
                if (node.ResType == node1.ResType)
                {
                    node1.Nodes.Add(node);
                    return;
                }
            }
        }
        finally
        {
        }

        var node2 = new KotorTreeNode(ParentDescForResType(node.ResType))
        {
            ResType = node.ResType,
            Tag = "NodeCategory"
        };
        node2.Nodes.Add(node);
        Collection.Nodes.Add(node2);
    }

    private void AttachNodeParentsSortedByDesc(
        KotorTreeNode ContainerNode,
        KotorTreeNode UnsortedNodeCollection)
    {
        var index1 = 0;
        var strArray1 = new string[checked(UnsortedNodeCollection.Nodes.Count - 1 + 1)];
        KotorTreeNode node1 = null;
        try
        {
            foreach (KotorTreeNode node2 in UnsortedNodeCollection.Nodes)
            {
                node1 = node2;
                strArray1[index1] = node1.Text;
                checked
                {
                    ++index1;
                }
            }
        }
        finally
        {
        }

        Array.Sort((Array)strArray1);
           
            
        var strArray2 = strArray1;
        var index2 = 0;
        while (index2 < strArray2.Length)
        {
            var sLeft = strArray2[index2];
            try
            {
                foreach (KotorTreeNode node3 in UnsortedNodeCollection.Nodes)
                {
                    node1 = node3;
                    if (StringType.StrCmp(sLeft, node1.Text, false) == 0)
                        break;
                }
            }
            finally
            {
            }

            ContainerNode.Nodes.Add(node1);
            checked
            {
                ++index2;
            }
        }
    }

    //TODO:Move to extensions
    private void ScanForRimSandBuildTree(KotorTreeNode ktn, string directory)
    {
        var moduleDescriptions = CurrentSettings.bShowModuleDescriptions;
        var showModuleLocations = CurrentSettings.bShowModuleLocations;
        var files = new DirectoryInfo(((KotorTreeNode)ktn.Parent.Parent).FilePath + "\\" + directory).GetFiles();
        var index = 0;
        while (index < files.Length)
        {
            var fileInfo = files[index];
            if (StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".rim", false) == 0)
            {
                var name = fileInfo.Name;
                if (moduleDescriptions | showModuleLocations)
                    name += " - ";
                if (moduleDescriptions)
                    name += GetModuleDescForRimName(fileInfo.Name);
                if (showModuleLocations)
                    name += GetLocNameForRimName(fileInfo.Name);
                var node1 = new KotorTreeNode(name)
                {
                    Tag = "RIM",
                    FilePath = fileInfo.DirectoryName,
                    Filename = fileInfo.Name,
                    ContainingFileType = "rim"
                };
                var node2 = new KotorTreeNode("")
                {
                    Tag = "dummy"
                };
                node1.Nodes.Add(node2);
                ktn.Nodes.Add(node1);
            }

            checked
            {
                ++index;
            }
        }
    }

        
    //TODO: Move to Extensions
    private void ScanForErFsAndBuildTree(KotorTreeNode ktn, string directory)
    {
        var files = new DirectoryInfo(CurrentSettings.KotorLocation(NodeTreeRootIndex(ktn)) + "\\" + directory)
            .GetFiles();
        var index = 0;
        while (index < files.Length)
        {
            var fileInfo = files[index];
            if (StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".erf", false) == 0 |
                StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".mod", false) == 0)
            {
                var node1 = new KotorTreeNode(fileInfo.Name)
                {
                    Tag = "ERF",
                    FilePath = fileInfo.DirectoryName,
                    Filename = fileInfo.Name,
                    ContainingFileType = "ERF"
                };
                var node2 = new KotorTreeNode("")
                {
                    Tag = "dummy"
                };
                node1.Nodes.Add(node2);
                ktn.Nodes.Add(node1);
            }

            checked
            {
                ++index;
            }
        }
    }

    private void ScanForSavesAndBuildTree(string path, KotorTreeNode node)
    {
        var directories = new DirectoryInfo(path).GetDirectories();
        var index = 0;
        while (index < directories.Length)
        {
            var directoryInfo = directories[index];
            var node1 = new KotorTreeNode(directoryInfo.Name)
            {
                FilePath = directoryInfo.FullName
            };
            var node2 = new KotorTreeNode("GLOBALVARS.res")
            {
                Tag = "globalvar",
                FilePath = node1.FilePath,
                Filename = "GLOBALVARS.res"
            };
            node1.Nodes.Add(node2);
            node.Nodes.Add(node1);
            checked
            {
                ++index;
            }
        }
    }

    // Move to export functions
    public static void ExportBiffResource(string biffPath, string outputPath, int resourceId)
    {
        var fsin = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var biffResource = new BIFFArchive(fsin).GetBiffResource(resourceId);
        var binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create));
        binaryWriter.Write(biffResource.Data);
        binaryWriter.Close();
        fsin.Close();
    }


    public struct ExportDirectives
    {
        public int Index { get; set; }
        public string OutputPath { get; set; }
        public int FileResourceType { get; set; }
        public string FileNameToExport { get; set; }
    }

    public class ExportBuilder
    {
        public static ExportBuilder CreateBuilder()
        {
            return new ExportBuilder();
        }

        public ExportBuilder SetIndex()
        {
            return this;
        }

        public ExportBuilder SetOutputPath()
        {
            return this;
        }

        public ExportBuilder SetFileResourceType()
        {
            return this;
        }

        public ExportBuilder SetFileNameToExport()
        {
            return this;
        }
    }

    public static void ExportBiffResource(
        int KotorVerIndex,
        string FileNameToExport,
        int FileResType,
        string outputPath)
    {
        var route = ExportBuilder.CreateBuilder()
            .SetFileNameToExport()
            .SetFileNameToExport()
            .SetIndex()
            .SetFileResourceType();

        var settings = UserSettings.GetSettings();
        var resIdForResRef = KxChitinKey(KotorVerIndex).FindResIdForResRef(FileNameToExport, FileResType);
        if (resIdForResRef == -1)
            throw new NotSupportedException();
        ExportBiffResource(
            settings.KotorLocation(KotorVerIndex) + "\\" +
            KxChitinKey(KotorVerIndex).BiffList[resIdForResRef >> 20].Filename, outputPath,
            checked(resIdForResRef - resIdForResRef >> 20 << 20));
    }

    public BiffVarRsrcEntry GetBiffResource(string biffPath, int resourceId)
    {
        var fsin = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var biffResource = new BIFFArchive(fsin).GetBiffResource(resourceId);
        fsin.Close();
        return biffResource;
    }

    public static byte[] GetBiffResourceData(int KotorVerIndex, string FileName, int FileResType)
    {
        var settings = UserSettings.GetSettings();
        var clsChitinKey = KxChitinKey(KotorVerIndex);
        var resIdForResRef = clsChitinKey.FindResIdForResRef(FileName, FileResType);
        if (resIdForResRef == -1)
            return null;
        var fsin = new FileStream(
            settings.KotorLocation(KotorVerIndex) + "\\" + clsChitinKey.BiffList[resIdForResRef >> 20].Filename,
            FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var data = new BIFFArchive(fsin).GetBiffResource(checked(resIdForResRef - resIdForResRef >> 20 << 20)).Data;
        fsin.Close();
        return data;
    }

    public static byte[] GetTemplateBifResourceData(
        int kotorVerIndex,
        string FileName,
        int FileResType)
    {
        var resIdForResRef = KxChitinKey(kotorVerIndex).FindResIdForResRef(FileName, FileResType);
        return resIdForResRef == -1
            ? null
            : KxTemplatesBif(kotorVerIndex).GetBiffResource(checked(resIdForResRef - resIdForResRef >> 20 << 20))
                .Data;
    }

    private void PerformStringSearch()
    {
        var refSearchResults = new frmRefSearchResults(Mainform);
        var refSearchCriteria = new frmRefSearchCriteria();
        if (_hasK1 ^ _hasK2)
        {
            refSearchCriteria.rbSearchKotor1.Checked = _hasK1;
            refSearchCriteria.rbSearchKotor1.Enabled = _hasK1;
            refSearchCriteria.rbSearchKotor2.Checked = _hasK2;
            refSearchCriteria.rbSearchKotor2.Enabled = _hasK2;
            refSearchCriteria.tbSearchString.Focus();
        }

        var num1 = (int)refSearchCriteria.ShowDialog(this);
        if (refSearchCriteria.DialogResult != DialogResult.OK)
            return;
        var current = Cursor.Current;
        var num2 = !refSearchCriteria.rbSearchKotor1.Checked ? 1 : 0;
        /*if (refSearchCriteria.chkbAllBifs.Checked | refSearchCriteria.chkbScripts.Checked |
            refSearchCriteria.chkbTemplates.Checked &&
            ObjectType.ObjTst(TreeView.Nodes[num2].Nodes[0].Nodes[0].Tag, "dummy", false) == 0)
        {
            Cursor.Current = Cursors.WaitCursor;
            BuildTreeView((KotorTreeNode)TreeView.Nodes[num2], true);
        }*/

        if (refSearchCriteria.chkbAllBifs.Checked)
        {
            // var num3 = checked(TreeView.Nodes[num2].Nodes[0].Nodes.Count - 1);
            var num3 = 1;
            var bifToSearchId = 0;
            while (bifToSearchId <= num3)
            {
                SearchBifsForText(num2, refSearchCriteria.tbSearchString.Text,
                    refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, refSearchResults,
                    bifToSearchId);
                checked
                {
                    ++bifToSearchId;
                }
            }
        }
        else
        {
            if (refSearchCriteria.chkbScripts.Checked)
            {
                /*var num4 = checked(TreeView.Nodes[num2].Nodes[0].Nodes.Count - 1);
                var num5 = 0;
                while (num5 <= num4 && !TreeView.Nodes[num2].Nodes[0].Nodes[num5].Text.ToLower()
                           .EndsWith("scripts.bif"))
                    checked
                    {
                        ++num5;
                    }

                SearchBifsForText(num2, refSearchCriteria.tbSearchString.Text,
                    refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, refSearchResults, num5);*/
            }

            if (refSearchCriteria.chkbTemplates.Checked)
            {
                /*var num6 = checked(TreeView.Nodes[num2].Nodes[0].Nodes.Count - 1);
                var num7 = 0;
                while (num7 <= num6 && !TreeView.Nodes[num2].Nodes[0].Nodes[num7].Text.ToLower()
                           .EndsWith("templates.bif"))
                    checked
                    {
                        ++num7;
                    }

                SearchBifsForText(num2, refSearchCriteria.tbSearchString.Text,
                    refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, refSearchResults, num7);*/
            }
        }

        if (refSearchCriteria.chkbRIMs.Checked)
            SearchAllModuleRimsForText(num2, refSearchCriteria.tbSearchString.Text,
                refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, refSearchResults);
        if (refSearchResults.lbMatches.Items.Count == 0)
        {
            refSearchResults.lblNoMatchesFound.Visible = true;
            refSearchResults.lbMatches.Visible = false;
            refSearchResults.lblDesc.Visible = false;
            refSearchResults.Size = refSearchResults.MinimumSize;
            refSearchResults.lbMatches.Enabled = false;
        }

        Cursor.Current = current;
        var relativePositioner = new utilWindowRelativePositioner(this, refSearchResults);
        ((Control)refSearchResults).Location = relativePositioner.GetConcentric();
        refSearchResults.Show();
    }

    private void SearchBifsForText(
        int kotorVerIndex,
        string SearchText,
        bool CaseSensitive,
        Hashtable FileTypes,
        frmRefSearchResults ResultsForm,
        int bifToSearchId)
    {
        var htFileTypeIDs = new Hashtable();
        foreach (var fileType in FileTypes)
        {
            var dictionaryEntry = (DictionaryEntry)(fileType ?? Activator.CreateInstance(typeof(DictionaryEntry)));
            htFileTypeIDs.Add(GetIdForRsrcType(StringType.FromObject(dictionaryEntry.Key)),
                RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
        }

        var oRegex = !CaseSensitive ? new Regex(SearchText, RegexOptions.IgnoreCase) : new Regex(SearchText);
        ScanBifForText(kotorVerIndex, bifToSearchId, htFileTypeIDs, oRegex, ResultsForm.lbMatches.Items);
    }

    private void ScanBifForText(
        int KotorVerIndex,
        int BiffListIndex,
        Hashtable htFileTypeIDs,
        Regex oRegex,
        ListBox.ObjectCollection lBoc)
    {
        var asciiEncoding = new ASCIIEncoding();
        var path = CurrentSettings.KotorLocation(KotorVerIndex) + "\\" +
                   ((BiffEntry)_biffEntries[KotorVerIndex][BiffListIndex]).Filename;
        var fsin = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var biffArchive = new BIFFArchive(fsin);
        try
        {
            foreach (KeyEntry ke in _biffEntryListArray[KotorVerIndex, BiffListIndex])
            {
                var num = 0;
                switch (num)
                {
                    case 0:
                        Cursor.Current = Cursors.PanNorth;
                        break;
                    case 1:
                        Cursor.Current = Cursors.PanNW;
                        break;
                    case 2:
                        Cursor.Current = Cursors.PanWest;
                        break;
                    case 3:
                        Cursor.Current = Cursors.PanSW;
                        break;
                    case 4:
                        Cursor.Current = Cursors.PanSouth;
                        break;
                    case 5:
                        Cursor.Current = Cursors.PanSE;
                        break;
                    case 6:
                        Cursor.Current = Cursors.PanEast;
                        break;
                    case 7:
                        Cursor.Current = Cursors.PanNE;
                        num = -1;
                        break;
                }

                checked
                {
                    ++num;
                }

                if (!htFileTypeIDs.ContainsKey(ke.ResourceType)) continue;
                var input = asciiEncoding.GetString(biffArchive
                    .GetBiffResource(checked(ke.ResId - ke.ResId >> 20 << 20)).Data);
                if (!oRegex.Match(input).Success) continue;
                var kotorTreeNode = new KotorTreeNode(ke)
                {
                    FilePath = path,
                    Tag = "BIFF_Res",
                    KotorVerIndex = KotorVerIndex
                };
                lBoc.Add(kotorTreeNode);
            }
        }
        finally
        {
        }

        fsin.Close();
    }

    private static string GetModuleDescForRimName(string RimName)
    {
        var sLeft = RimName.Replace(".rim", string.Empty).Replace("_s", string.Empty);
            
        if (StringType.StrCmp(sLeft, "end_m01aa", false) == 0)
            return "Command Module";
        if (StringType.StrCmp(sLeft, "end_m01ab", false) == 0)
            return "Starboard Section";
        if (StringType.StrCmp(sLeft, "tar_m02aa", false) == 0)
            return "South Apartments";
        if (StringType.StrCmp(sLeft, "tar_m02ab", false) == 0)
            return "Upper City North";
        if (StringType.StrCmp(sLeft, "tar_m02ac", false) == 0)
            return "Upper City South";
        if (StringType.StrCmp(sLeft, "tar_m02ad", false) == 0)
            return "North Apartments";
        if (StringType.StrCmp(sLeft, "tar_m02ae", false) == 0)
            return "Upper City Cantina";
        if (StringType.StrCmp(sLeft, "tar_m02af", false) == 0)
            return "Hideout";
        if (StringType.StrCmp(sLeft, "tar_m03aa", false) == 0)
            return "Lower City";
        if (StringType.StrCmp(sLeft, "tar_m03ab", false) == 0 || StringType.StrCmp(sLeft, "tar_m03ad", false) == 0)
            return "Lower City Apartments";
        if (StringType.StrCmp(sLeft, "tar_m03ae", false) == 0)
            return "Javyar's Cantina";
        if (StringType.StrCmp(sLeft, "tar_m03af", false) == 0)
            return "Swoop Platform";
        if (StringType.StrCmp(sLeft, "tar_m04aa", false) == 0)
            return "Undercity";
        if (StringType.StrCmp(sLeft, "tar_m05aa", false) == 0)
            return "Lower Sewers";
        if (StringType.StrCmp(sLeft, "tar_m05ab", false) == 0)
            return "Upper Sewers";
        if (StringType.StrCmp(sLeft, "tar_m08aa", false) == 0)
            return "Davik's Estate";
        if (StringType.StrCmp(sLeft, "tar_m09aa", false) == 0 || StringType.StrCmp(sLeft, "tar_m09ab", false) == 0)
            return "Sith Base";
        if (StringType.StrCmp(sLeft, "tar_m10aa", false) == 0 ||
            StringType.StrCmp(sLeft, "tar_m10ab", false) == 0 || StringType.StrCmp(sLeft, "tar_m10ac", false) == 0)
            return "Black Vulkar Base";
        if (StringType.StrCmp(sLeft, "tar_m11aa", false) == 0 || StringType.StrCmp(sLeft, "tar_m11ab", false) == 0)
            return "Hidden Bek Base";
        if (StringType.StrCmp(sLeft, "ebo_m12aa", false) == 0)
            return "Bridge";
        if (StringType.StrCmp(sLeft, "ebo_m46ab", false) == 0)
            return "Mystery Box";
        if (StringType.StrCmp(sLeft, "danm13", false) == 0)
            return "Jedi Enclave";
        if (StringType.StrCmp(sLeft, "danm14aa", false) == 0)
            return "Courtyard";
        if (StringType.StrCmp(sLeft, "danm14ab", false) == 0)
            return "Matale Grounds";
        if (StringType.StrCmp(sLeft, "danm14ac", false) == 0)
            return "Grove";
        if (StringType.StrCmp(sLeft, "danm14ad", false) == 0)
            return "Sandral Grounds";
        if (StringType.StrCmp(sLeft, "danm14ae", false) == 0)
            return "Crystal Caves";
        if (StringType.StrCmp(sLeft, "danm15", false) == 0)
            return "Ruins";
        if (StringType.StrCmp(sLeft, "danm16", false) == 0)
            return "Sandral Estate";
        if (StringType.StrCmp(sLeft, "tat_m17aa", false) == 0)
            return "Anchorhead";
        if (StringType.StrCmp(sLeft, "tat_m17ab", false) == 0)
            return "Docking Bay";
        if (StringType.StrCmp(sLeft, "tat_m17ac", false) == 0)
            return "Droid Shop";
        if (StringType.StrCmp(sLeft, "tat_m17ad", false) == 0)
            return "Hunting Lodge";
        if (StringType.StrCmp(sLeft, "tat_m17ae", false) == 0)
            return "Swoop Registration";
        if (StringType.StrCmp(sLeft, "tat_m17af", false) == 0)
            return "Cantina";
        if (StringType.StrCmp(sLeft, "tat_m17ag", false) == 0)
            return "Czerka Office";
        if (StringType.StrCmp(sLeft, "tat_m18aa", false) == 0)
            return "Dune Sea";
        if (StringType.StrCmp(sLeft, "tat_m18ab", false) == 0)
            return "Sand People Territory";
        if (StringType.StrCmp(sLeft, "tat_m18ac", false) == 0)
            return "Eastern Dune Sea";
        if (StringType.StrCmp(sLeft, "tat_m20aa", false) == 0)
            return "Sand People Enclave";
        if (StringType.StrCmp(sLeft, "kas_m22aa", false) == 0)
            return "Czerka Landing Port";
        if (StringType.StrCmp(sLeft, "kas_m22ab", false) == 0)
            return "The Great Walkway";
        if (StringType.StrCmp(sLeft, "kas_m23aa", false) == 0)
            return "Village of Rwookrrorro";
        if (StringType.StrCmp(sLeft, "kas_m23ab", false) == 0)
            return "Worrwill's Home";
        if (StringType.StrCmp(sLeft, "kas_m23ac", false) == 0)
            return "Worrroznor's Home";
        if (StringType.StrCmp(sLeft, "kas_m23ad", false) == 0)
            return "Chieftain's Hall";
        if (StringType.StrCmp(sLeft, "kas_m24aa", false) == 0)
            return "Upper Shadowlands";
        if (StringType.StrCmp(sLeft, "kas_m25aa", false) == 0)
            return "Lower Shadowlands";
        if (StringType.StrCmp(sLeft, "manm26aa", false) == 0)
            return "Ahto West";
        if (StringType.StrCmp(sLeft, "manm26ab", false) == 0)
            return "Ahto East";
        if (StringType.StrCmp(sLeft, "manm26ac", false) == 0)
            return "West Central";
        if (StringType.StrCmp(sLeft, "manm26ad", false) == 0)
            return "Docking Bay";
        if (StringType.StrCmp(sLeft, "manm26ae", false) == 0)
            return "East Central";
        if (StringType.StrCmp(sLeft, "manm27aa", false) == 0)
            return "Sith Base";
        if (StringType.StrCmp(sLeft, "manm28aa", false) == 0)
            return "Hrakert Station";
        if (StringType.StrCmp(sLeft, "manm28ab", false) == 0)
            return "Sea Floor";
        if (StringType.StrCmp(sLeft, "manm28ac", false) == 0)
            return "Kolto Control";
        if (StringType.StrCmp(sLeft, "manm28ad", false) == 0)
            return "Hrakert Rift";
        if (StringType.StrCmp(sLeft, "korr_m33aa", false) == 0)
            return "Dreshdae";
        if (StringType.StrCmp(sLeft, "korr_m33ab", false) == 0)
            return "Sith Academy Entrance ";
        if (StringType.StrCmp(sLeft, "korr_m34aa", false) == 0)
            return "Shyrack Caves";
        if (StringType.StrCmp(sLeft, "korr_m35aa", false) == 0)
            return "Sith Academy Entrance";
        if (StringType.StrCmp(sLeft, "korr_m36aa", false) == 0)
            return "Valley of Dark Lords";
        if (StringType.StrCmp(sLeft, "korr_m37aa", false) == 0)
            return "Tomb of Ajunta Pall";
        if (StringType.StrCmp(sLeft, "korr_m38aa", false) == 0)
            return "Tomb of Marka Ragnos";
        if (StringType.StrCmp(sLeft, "korr_m38ab", false) == 0)
            return "Tomb of Tulak Hord";
        if (StringType.StrCmp(sLeft, "korr_m39aa", false) == 0)
            return "Tomb of Naga Sadow";
        if (StringType.StrCmp(sLeft, "liv_m99aa", false) == 0)
            return "Yavin Station";
        if (StringType.StrCmp(sLeft, "lev_m40aa", false) == 0)
            return "Prison Block";
        if (StringType.StrCmp(sLeft, "lev_m40ab", false) == 0)
            return "Command Deck";
        if (StringType.StrCmp(sLeft, "lev_m40ac", false) == 0)
            return "Hangar";
        if (StringType.StrCmp(sLeft, "lev_m40ad", false) == 0)
            return "Bridge";
        if (StringType.StrCmp(sLeft, "unk_m41aa", false) == 0)
            return "Central Beach";
        if (StringType.StrCmp(sLeft, "unk_m41ab", false) == 0)
            return "South Beach";
        if (StringType.StrCmp(sLeft, "unk_m41ac", false) == 0)
            return "North Beach";
        if (StringType.StrCmp(sLeft, "unk_m41ad", false) == 0)
            return "Temple Exterior";
        if (StringType.StrCmp(sLeft, "unk_m42aa", false) == 0)
            return "Elder Settlement";
        if (StringType.StrCmp(sLeft, "unk_m43aa", false) == 0)
            return "Rakatan Settlement";
        if (StringType.StrCmp(sLeft, "unk_m44aa", false) == 0)
            return "Temple Main Floor";
        if (StringType.StrCmp(sLeft, "unk_m44ab", false) == 0)
            return "Temple Catacombs";
        if (StringType.StrCmp(sLeft, "sta_m45aa", false) == 0)
            return "Deck 1";
        if (StringType.StrCmp(sLeft, "sta_m45ab", false) == 0)
            return "Deck 2";
        if (StringType.StrCmp(sLeft, "sta_m45ac", false) == 0)
            return "Deck 3";
        if (StringType.StrCmp(sLeft, "sta_m45ad", false) == 0)
            return "Deck 4";
        if (StringType.StrCmp(sLeft, "001EBO", false) == 0)
            return "Interior";
        if (StringType.StrCmp(sLeft, "002EBO", false) == 0)
            return "Exterior Hull";
        if (StringType.StrCmp(sLeft, "003EBO", false) == 0 || StringType.StrCmp(sLeft, "004EBO", false) == 0 ||
            StringType.StrCmp(sLeft, "005EBO", false) == 0 || StringType.StrCmp(sLeft, "006EBO", false) == 0 ||
            StringType.StrCmp(sLeft, "007EBO", false) == 0)
            return "Interior";
        if (StringType.StrCmp(sLeft, "101PER", false) == 0)
            return "kolto cutscene - Administration Level";
        if (StringType.StrCmp(sLeft, "102PER", false) == 0)
            return "Mining Tunnels";
        if (StringType.StrCmp(sLeft, "103PER", false) == 0)
            return "Fuel Depot";
        if (StringType.StrCmp(sLeft, "104PER", false) == 0)
            return "Asteroid Exterior";
        if (StringType.StrCmp(sLeft, "105PER", false) == 0)
            return "Dormitories";
        if (StringType.StrCmp(sLeft, "106PER", false) == 0)
            return "Hangar Bay";
        if (StringType.StrCmp(sLeft, "107PER", false) == 0)
            return "final cutscene a.k.a. leaving Peragus";
        if (StringType.StrCmp(sLeft, "151HAR", false) == 0)
            return "Command Deck";
        if (StringType.StrCmp(sLeft, "152HAR", false) == 0)
            return "Crew Quarters";
        if (StringType.StrCmp(sLeft, "153HAR", false) == 0)
            return "Engine Deck";
        if (StringType.StrCmp(sLeft, "154HAR", false) == 0)
            return "cutscene - Command Deck";
        if (StringType.StrCmp(sLeft, "201TEL", false) == 0)
            return "Citadel Station Docking Module";
        if (StringType.StrCmp(sLeft, "202TEL", false) == 0)
            return "Citadel Station Entertainment Module 081";
        if (StringType.StrCmp(sLeft, "203TEL", false) == 0)
            return "Citadel Station Residential 082 East";
        if (StringType.StrCmp(sLeft, "204TEL", false) == 0)
            return "Citadel Station Residential 082 West";
        if (StringType.StrCmp(sLeft, "205TEL", false) == 0)
            return "Citadel Station Residential 082 West - leads to cutscene to Malachor V";
        if (StringType.StrCmp(sLeft, "207TEL", false) == 0)
            return "Citadel Station Cantina";
        if (StringType.StrCmp(sLeft, "208TEL", false) == 0)
            return "Bumani Exchange Corp.";
        if (StringType.StrCmp(sLeft, "209TEL", false) == 0)
            return "Czerka Offices";
        if (StringType.StrCmp(sLeft, "211TEL", false) == 0)
            return "Citadel Station Swoop Track - not official name";
        if (StringType.StrCmp(sLeft, "220TEL", false) == 0)
            return "Citadel Station Suburban - Sith Assault";
        if (StringType.StrCmp(sLeft, "221TEL", false) == 0)
            return "Citadel Station Suburban - Sith Assault - cutscene w/Grenn";
        if (StringType.StrCmp(sLeft, "222TEL", false) == 0)
            return "Citadel Station Entertainment Module 081 - Sith Assault";
        if (StringType.StrCmp(sLeft, "231TEL", false) == 0)
            return "Restoration Zone";
        if (StringType.StrCmp(sLeft, "232TEL", false) == 0)
            return "Underground Base";
        if (StringType.StrCmp(sLeft, "233TEL", false) == 0)
            return "Czerka Site";
        if (StringType.StrCmp(sLeft, "261TEL", false) == 0)
            return "Polar Plateau";
        if (StringType.StrCmp(sLeft, "262TEL", false) == 0)
            return "Secret Academy";
        if (StringType.StrCmp(sLeft, "301NAR", false) == 0)
            return "Refugee Landing Pad";
        if (StringType.StrCmp(sLeft, "302NAR", false) == 0)
            return "Refugee Quad";
        if (StringType.StrCmp(sLeft, "303NAR", false) == 0)
            return "Docks";
        if (StringType.StrCmp(sLeft, "304NAR", false) == 0)
            return "Jekk'Jekk Tarr";
        if (StringType.StrCmp(sLeft, "305NAR", false) == 0)
            return "Jekk'Jekk Tunnels";
        if (StringType.StrCmp(sLeft, "306NAR", false) == 0)
            return "Entertainment Promenade";
        if (StringType.StrCmp(sLeft, "351NAR", false) == 0)
            return "Goto's Yacht";
        if (StringType.StrCmp(sLeft, "352NAR", false) == 0)
            return "Goto's Yacht (cutscene)";
        if (StringType.StrCmp(sLeft, "371NAR", false) == 0)
            return "Nar Shaddaa Swoop Track";
        if (StringType.StrCmp(sLeft, "401DXN", false) == 0)
            return "Jungle Landing";
        if (StringType.StrCmp(sLeft, "402DXN", false) == 0)
            return "Jungle";
        if (StringType.StrCmp(sLeft, "403DXN", false) == 0)
            return "Mandalorian Ruins";
        if (StringType.StrCmp(sLeft, "404DXN", false) == 0)
            return "Mandalorian Cache";
        if (StringType.StrCmp(sLeft, "410DXN", false) == 0)
            return "Jungle Tomb";
        if (StringType.StrCmp(sLeft, "411DXN", false) == 0)
            return "Sith Tomb";
        if (StringType.StrCmp(sLeft, "421DXN", false) == 0)
            return "Dxun Turret Game";
        if (StringType.StrCmp(sLeft, "501OND", false) == 0)
            return "Iziz Spaceport";
        if (StringType.StrCmp(sLeft, "502OND", false) == 0)
            return "Merchant Quarter";
        if (StringType.StrCmp(sLeft, "503OND", false) == 0)
            return "Iziz Cantina";
        if (StringType.StrCmp(sLeft, "504OND", false) == 0)
            return "Sky Ramp";
        if (StringType.StrCmp(sLeft, "505OND", false) == 0)
            return "Turret";
        if (StringType.StrCmp(sLeft, "506OND", false) == 0)
            return "Royal Palace";
        if (StringType.StrCmp(sLeft, "510OND", false) == 0)
            return "Swoop Race Track";
        if (StringType.StrCmp(sLeft, "511OND", false) == 0)
            return "Merchant Quarter";
        if (StringType.StrCmp(sLeft, "512OND", false) == 0)
            return "Iziz - Western Square";
        if (StringType.StrCmp(sLeft, "601DAN", false) == 0)
            return "Khoonda";
        if (StringType.StrCmp(sLeft, "602DAN", false) == 0)
            return "Khoonda Plains";
        if (StringType.StrCmp(sLeft, "603DAN", false) == 0)
            return "Movie Terminal on Khoonda Plains";
        if (StringType.StrCmp(sLeft, "604DAN", false) == 0)
            return "Crystal Cave";
        if (StringType.StrCmp(sLeft, "605DAN", false) == 0)
            return "Enclave Courtyard";
        if (StringType.StrCmp(sLeft, "610DAN", false) == 0)
            return "Enclave Sublevel";
        if (StringType.StrCmp(sLeft, "650DAN", false) == 0)
            return "Rebuilt Jedi Enclave";
        if (StringType.StrCmp(sLeft, "701KOR", false) == 0)
            return "Valley of Dark Lords";
        if (StringType.StrCmp(sLeft, "702KOR", false) == 0)
            return "Sith Academy";
        if (StringType.StrCmp(sLeft, "710KOR", false) == 0)
            return "Shyrack Cave";
        if (StringType.StrCmp(sLeft, "711KOR", false) == 0)
            return "Secret Tomb";
        if (StringType.StrCmp(sLeft, "851NIH", false) == 0)
            return "Ravager Command Deck";
        if (StringType.StrCmp(sLeft, "852NIH", false) == 0)
            return "Ravager Bridge";
        if (StringType.StrCmp(sLeft, "853NIH", false) == 0)
            return "Ravager - cutscene Visas Nihilus convo.";
        if (StringType.StrCmp(sLeft, "901MAL", false) == 0)
            return "Surface";
        if (StringType.StrCmp(sLeft, "902MAL", false) == 0)
            return "Depths";
        if (StringType.StrCmp(sLeft, "903MAL", false) == 0)
            return "Trayus Academy";
        if (StringType.StrCmp(sLeft, "904MAL", false) == 0)
            return "Trayus Core";
        if (StringType.StrCmp(sLeft, "905MAL", false) == 0)
            return "Trayus Crescent";
        if (StringType.StrCmp(sLeft, "906MAL", false) == 0)
            return "Trayus Proving Grounds";
        string str = null;
        return StringType.StrCmp(sLeft, "907MAL", false) == 0 ? "Trayus Core" : str;
    }

    private static string GetLocNameForRimName(string RimName)
    {
        var sLeft1 = RimName.Substring(0, 3);
        if (StringType.StrCmp(sLeft1, "end", false) == 0)
            return " (Endar Spire)";
        if (StringType.StrCmp(sLeft1, "tar", false) == 0)
            return " (Taris)";
        if (StringType.StrCmp(sLeft1, "ebo", false) == 0)
            return " (Ebon Hawk)";
        if (StringType.StrCmp(sLeft1, "dan", false) == 0)
            return " (Dantooine)";
        if (StringType.StrCmp(sLeft1, "tat", false) == 0)
            return " (Tatooine)";
        if (StringType.StrCmp(sLeft1, "kas", false) == 0)
            return " (Kashyyyk)";
        if (StringType.StrCmp(sLeft1, "man", false) == 0)
            return " (Manaan)";
        if (StringType.StrCmp(sLeft1, "kor", false) == 0)
            return " (Korriban)";
        if (StringType.StrCmp(sLeft1, "liv", false) == 0)
            return " (Yavin Station)";
        if (StringType.StrCmp(sLeft1, "lev", false) == 0)
            return " (Leviathan)";
        if (StringType.StrCmp(sLeft1, "unk", false) == 0)
            return " (Unknown World)";
        if (StringType.StrCmp(sLeft1, "sta", false) == 0)
            return " (Star Forge)";
        if (StringType.StrCmp(sLeft1, "STU", false) == 0)
            return " (cut scene)";
        var sLeft2 = RimName.Substring(3, 3);
        if (StringType.StrCmp(sLeft2, "EBO", false) == 0)
            return " (Ebon Hawk)";
        if (StringType.StrCmp(sLeft2, "KOR", false) == 0)
            return " (Korriban)";
        if (StringType.StrCmp(sLeft2, "DAN", false) == 0)
            return " (Dantooine)";
        if (StringType.StrCmp(sLeft2, "PER", false) == 0)
            return " (Peragus)";
        if (StringType.StrCmp(sLeft2, "HAR", false) == 0)
            return " (Harbinger)";
        if (StringType.StrCmp(sLeft2, "TEL", false) == 0)
            return " (Telos)";
        if (StringType.StrCmp(sLeft2, "NAR", false) == 0)
            return " (Nar Shaddaa)";
        if (StringType.StrCmp(sLeft2, "DXN", false) == 0)
            return " (Dxun)";
        if (StringType.StrCmp(sLeft2, "OND", false) == 0)
            return " (Onderon)";
        if (StringType.StrCmp(sLeft2, "NIH", false) == 0)
            return " (Ravager)";
        if (StringType.StrCmp(sLeft2, "MAL", false) == 0)
            return " (Malachor V)";
        string str = null;
        return StringType.StrCmp(sLeft2, "COR", false) == 0 ? " (Ebon Hawk)" : str;
    }

    private async void ReadRimEntries(string rimFilePath, KotorTreeNode referenceTreeNode)
    {
            
        await using var rim = ClsRim.CreateInstance(rimFilePath);

        var num = 0;
        var kotorTreeNode = new KotorTreeNode();
        try
        {

            foreach (RimKeyEntry keyEntry in rim.KeyEntryList)
            {
                   
                var node = new KotorTreeNode(keyEntry, rimFilePath)
                {
                    ContainingFileType = "RIM",
                    RiMorErFindex = num
                };
                   
                checked
                {
                    ++num;
                }

                   
                OrganizeNodesByResType(kotorTreeNode, node);
                   
                    
                if (StringType.StrCmp(keyEntry._ResTypeStr, "pth", false) == 0)
                    Console.WriteLine(kotorTreeNode.Filename + "\\" + keyEntry._ResourceName + " " +
                                      StringType.FromInteger(keyEntry._Length));
            }
        }
        finally
        {
        }

        AttachNodeParentsSortedByDesc(kotorTreeNode, kotorTreeNode);
    }

    private byte[] GetRimResource(string RimFilePath, KotorTreeNode ktn)
    {
        var input = new FileStream(RimFilePath, FileMode.Open, FileAccess.Read);
        using var binaryReader = new BinaryReader(input, Encoding.ASCII);
        var indata = binaryReader.ReadBytes(checked((int)input.Length));
        return ClsRim.CreateInstance(indata).GetRimResource(ktn.RiMorErFindex);
    }

    private void SearchAllModuleRimsForText(
        int KotorVerIndex,
        string searchText,
        bool CaseSensitive,
        Hashtable FileTypes,
        frmRefSearchResults ResultsForm)
    {
        var current = Cursor.Current;
        var files = new DirectoryInfo(CurrentSettings.KotorLocation(KotorVerIndex) + "\\Modules").GetFiles("*.rim");
        var regex = !CaseSensitive ? new Regex(searchText, RegexOptions.IgnoreCase) : new Regex(searchText.Trim());
        var fileInfoArray = files;
        var index1 = 0;
        while (index1 < fileInfoArray.Length)
        {
            var fileInfo = fileInfoArray[index1];
            int num1 = 0;
            switch (num1)
            {
                case 0:
                    Cursor.Current = Cursors.PanNorth;
                    break;
                case 1:
                    Cursor.Current = Cursors.PanNE;
                    break;
                case 2:
                    Cursor.Current = Cursors.PanEast;
                    break;
                case 3:
                    Cursor.Current = Cursors.PanSE;
                    break;
                case 4:
                    Cursor.Current = Cursors.PanSouth;
                    break;
                case 5:
                    Cursor.Current = Cursors.PanSW;
                    break;
                case 6:
                    Cursor.Current = Cursors.PanWest;
                    break;
                case 7:
                    Cursor.Current = Cursors.PanNW;
                    num1 = -1;
                    break;
            }

            checked
            {
                ++num1;
            }

            var input1 = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
            var binaryReader = new BinaryReader(input1, Encoding.ASCII);
            var indata = binaryReader.ReadBytes(checked((int)input1.Length));
            binaryReader.Close();
            var clsRim = ClsRim.CreateInstance(indata);
            var num2 = checked(clsRim.EntryCount - 1);
            var index2 = 0;
            while (index2 <= num2)
            {
                if (FileTypes.ContainsKey(((RimKeyEntry)clsRim.KeyEntryList[index2])._ResTypeStr))
                {
                    var input2 = new ASCIIEncoding().GetString(clsRim.GetRimResource(index2));
                    if (regex.Match(input2).Success)
                        ResultsForm.lbMatches.Items.Add(new KotorTreeNode((RimKeyEntry)clsRim.KeyEntryList[index2])
                        {
                            FilePath = fileInfo.FullName,
                            RiMorErFindex = index2,
                            KotorVerIndex = KotorVerIndex
                        });
                }

                checked
                {
                    ++index2;
                }
            }

            checked
            {
                ++index1;
            }
        }

        Cursor.Current = current;
    }

    private void ReadErFentries(string erfFilePath, KotorTreeNode ktn)
    {
        var charCode1 = 48;
        do
        {
            ktn.Nodes.Add(new KotorTreeNode(StringType.FromChar(Strings.Chr(charCode1))));
            checked
            {
                ++charCode1;
            }
        } while (charCode1 <= 57);

        var charCode2 = 65;
        do
        {
            ktn.Nodes.Add(new KotorTreeNode(StringType.FromChar(Strings.Chr(charCode2))));
            checked
            {
                ++charCode2;
            }
        } while (charCode2 <= 90);

        var clsErf = new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read));
        var num = 0;
        try
        {
            foreach (ERFKeyEntry keyEntry in clsErf.KeyEntryList)
            {
                var node1 = new KotorTreeNode(keyEntry, erfFilePath)
                {
                    ContainingFileType = "ERF",
                    RiMorErFindex = num
                };
                try
                {
                    foreach (KotorTreeNode node2 in ktn.Nodes)
                    {
                        if (StringType.StrCmp(node2.Text, StringType.FromChar(Strings.UCase(node1.Text[0])),
                                false) == 0)
                        {
                            node2.Nodes.Add(node1);
                            break;
                        }
                    }
                }
                finally
                {
                }

                checked
                {
                    ++num;
                }
            }
        }
        finally
        {
        }

        var index = checked(ktn.Nodes.Count - 1);
        while (index >= 1)
        {
            if (ktn.Nodes[index].Nodes.Count == 0)
                ktn.Nodes.RemoveAt(index);
            checked
            {
                index += -1;
            }
        }
    }


    // Query
    private byte[] GetErfResource(string erfFilePath, KotorTreeNode ktn) =>
        new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(ktn.RiMorErFindex);


    private byte[] GetErfResource(string erfFilePath, string ResRef, int ResType) =>
        new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read))
            .GetErfResource(ResRef, ResType);

    public static void WriteByteArray(string outputPath, byte[] byteArray)
    {
        using var binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create));
        binaryWriter.Write(byteArray);
    }

        
    public byte[] ReadByteArray(string Path)
    {
        var input = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var binaryReader = new BinaryReader(input);
        var array = new byte[checked((int)(input.Length - 1L) + 1)];
        input.Read(array, 0, checked((int)input.Length));
        input.Close();
        return array;
    }

    public static void SaveSettings()
    {
        CurrentSettings = UserSettings.GetSettings();
        if (Mainform.WindowState is FormWindowState.Maximized or FormWindowState.Minimized)
            Mainform.WindowState = FormWindowState.Normal;
        var width1 = Mainform.Size.Width;
        var size1 = Mainform.Size;
        var height1 = size1.Height;
        if (height1 >= Screen.PrimaryScreen.WorkingArea.Height)
            height1 = checked(Screen.PrimaryScreen.WorkingArea.Height - 20);
        if (width1 >= Screen.PrimaryScreen.WorkingArea.Width)
            width1 = checked(Screen.PrimaryScreen.WorkingArea.Width - 20);
        var mainform = Mainform;
        size1 = new Size(width1, height1);
        var size2 = size1;
        mainform.Size = size2;
        var point = new Point(((Control)Mainform).Location.X, ((Control)Mainform).Location.Y);
        if (((Control)Mainform).Location.X < 0)
            point.X = 0;
        var x = ((Control)Mainform).Location.X;
        size1 = Mainform.Size;
        var width2 = size1.Width;
        Size size3;
        if (checked(x + width2) > Screen.PrimaryScreen.WorkingArea.Width)
        {
            ref var local = ref point;
            var width3 = Screen.PrimaryScreen.WorkingArea.Width;
            size3 = Mainform.Size;
            var width4 = size3.Width;
            var num = checked(width3 - width4 - 30);
            local.X = num;
        }

        if (((Control)Mainform).Location.Y < 0)
            point.Y = 0;
        var y = ((Control)Mainform).Location.Y;
        size3 = Mainform.Size;
        var height2 = size3.Height;
        if (checked(y + height2) > Screen.PrimaryScreen.WorkingArea.Height)
        {
            ref var local = ref point;
            var height3 = Screen.PrimaryScreen.WorkingArea.Height;
            size1 = Mainform.Size;
            var height4 = size1.Height;
            var num = checked(height3 - height4 - 30);
            local.Y = num;
        }

        ((Control)Mainform).Location = point;
        CurrentSettings = UserSettings.GetSettings();
        CurrentSettings.MainWindowLoc = ((Control)Mainform).Location;
        CurrentSettings.MainWindowSize = Mainform.Size;
        UserSettings.SaveSettings(CurrentSettings);
    }

    public void SetDefaultSettings()
    {
        CurrentSettings = UserSettings.GetSettings();
        CurrentSettings.bBuildModelsBifNode = true;
        UserSettings.SaveSettings(CurrentSettings);
    }

    private string ParentDescForResType(int ResType)
    {
        return ResType switch
        {
            3 => "TGA Images",
            4 => "WAV Files",
            2002 => "Aurora Model",
            2009 => "Script, Source",
            2010 => "Script, Compiled",
            2011 => "Module",
            2012 => "Static Area Info",
            2014 => "Module Info File",
            2016 => "Walkmesh",
            2017 => "2D Array",
            2022 => "Extra Texture info",
            2023 => "Dynamic Area Info",
            2025 => "Blueprint, Item",
            2027 => "Blueprint, Character",
            2029 => "Dialog",
            2030 => "Blueprint Palette File",
            2032 => "Blueprint, Triggers",
            2035 => "Blueprint, Sound",
            2036 => "Letter-combo Probability File",
            2038 => "Faction File",
            2040 => "Blueprint, Encounter",
            2042 => "Blueprint, Doors",
            2044 => "Blueprint, Placeables",
            2047 => "GUI Elements",
            2051 => "Blueprint, Merchant",
            2052 => "Door Walkmesh",
            2053 => "Placeable Object Walkmesh",
            2055 => "Blueprint, ",
            2056 => "Journal File",
            2058 => "Blueprint, Waypoint",
            2060 => "Sound Sets",
            3000 => "Layouts",
            3003 => "Paths",
            3007 => "PC Textures",
            3008 => "Aurora Model Extension",
            _ => ResourceIdentification.FindResourceTypeForId(ResType)
        };
    }

    public static short GetIdForRsrcType(string type)
    {
        var sLeft = type;
        if (StringType.StrCmp(sLeft, "res", false) == 0)
            return 0;
        if (StringType.StrCmp(sLeft, "bmp", false) == 0)
            return 1;
        if (StringType.StrCmp(sLeft, "mve", false) == 0)
            return 2;
        if (StringType.StrCmp(sLeft, "tga", false) == 0)
            return 3;
        if (StringType.StrCmp(sLeft, "wav", false) == 0)
            return 4;
        if (StringType.StrCmp(sLeft, "plt", false) == 0)
            return 6;
        if (StringType.StrCmp(sLeft, "ini", false) == 0)
            return 7;
        if (StringType.StrCmp(sLeft, "mp3", false) == 0)
            return 8;
        if (StringType.StrCmp(sLeft, "mpg", false) == 0)
            return 9;
        if (StringType.StrCmp(sLeft, "txt", false) == 0)
            return 10;
        if (StringType.StrCmp(sLeft, "wma", false) == 0)
            return 11;
        if (StringType.StrCmp(sLeft, "wmv", false) == 0)
            return 12;
        if (StringType.StrCmp(sLeft, "xmv", false) == 0)
            return 13;
        if (StringType.StrCmp(sLeft, "plh", false) == 0)
            return 2000;
        if (StringType.StrCmp(sLeft, "tex", false) == 0)
            return 2001;
        if (StringType.StrCmp(sLeft, "mdl", false) == 0)
            return 2002;
        if (StringType.StrCmp(sLeft, "thg", false) == 0)
            return 2003;
        if (StringType.StrCmp(sLeft, "fnt", false) == 0)
            return 2005;
        if (StringType.StrCmp(sLeft, "lua", false) == 0)
            return 2007;
        if (StringType.StrCmp(sLeft, "slt", false) == 0)
            return 2008;
        if (StringType.StrCmp(sLeft, "nss", false) == 0)
            return 2009;
        if (StringType.StrCmp(sLeft, "ncs", false) == 0)
            return 2010;
        if (StringType.StrCmp(sLeft, "mod", false) == 0)
            return 2011;
        if (StringType.StrCmp(sLeft, "are", false) == 0)
            return 2012;
        if (StringType.StrCmp(sLeft, "set", false) == 0)
            return 2013;
        if (StringType.StrCmp(sLeft, "ifo", false) == 0)
            return 2014;
        if (StringType.StrCmp(sLeft, "bic", false) == 0)
            return 2015;
        if (StringType.StrCmp(sLeft, "wok", false) == 0)
            return 2016;
        if (StringType.StrCmp(sLeft, "2da", false) == 0)
            return 2017;
        if (StringType.StrCmp(sLeft, "tlk", false) == 0)
            return 2018;
        if (StringType.StrCmp(sLeft, "txi", false) == 0)
            return 2022;
        if (StringType.StrCmp(sLeft, "git", false) == 0)
            return 2023;
        if (StringType.StrCmp(sLeft, "bti", false) == 0)
            return 2024;
        if (StringType.StrCmp(sLeft, "uti", false) == 0)
            return 2025;
        if (StringType.StrCmp(sLeft, "btc", false) == 0)
            return 2026;
        if (StringType.StrCmp(sLeft, "utc", false) == 0)
            return 2027;
        if (StringType.StrCmp(sLeft, "dlg", false) == 0)
            return 2029;
        if (StringType.StrCmp(sLeft, "itp", false) == 0)
            return 2030;
        if (StringType.StrCmp(sLeft, "btt", false) == 0)
            return 2031;
        if (StringType.StrCmp(sLeft, "utt", false) == 0)
            return 2032;
        if (StringType.StrCmp(sLeft, "dds", false) == 0)
            return 2033;
        if (StringType.StrCmp(sLeft, "bts", false) == 0)
            return 2034;
        if (StringType.StrCmp(sLeft, "uts", false) == 0)
            return 2035;
        if (StringType.StrCmp(sLeft, "ltr", false) == 0)
            return 2036;
        if (StringType.StrCmp(sLeft, "gff", false) == 0)
            return 2037;
        if (StringType.StrCmp(sLeft, "fac", false) == 0)
            return 2038;
        if (StringType.StrCmp(sLeft, "bts", false) == 0)
            return 2039;
        if (StringType.StrCmp(sLeft, "ute", false) == 0)
            return 2040;
        if (StringType.StrCmp(sLeft, "btd", false) == 0)
            return 2041;
        if (StringType.StrCmp(sLeft, "utd", false) == 0)
            return 2042;
        if (StringType.StrCmp(sLeft, "btp", false) == 0)
            return 2043;
        if (StringType.StrCmp(sLeft, "utp", false) == 0)
            return 2044;
        if (StringType.StrCmp(sLeft, "dft", false) == 0)
            return 2045;
        if (StringType.StrCmp(sLeft, "gic", false) == 0)
            return 2046;
        if (StringType.StrCmp(sLeft, "gui", false) == 0)
            return 2047;
        if (StringType.StrCmp(sLeft, "css", false) == 0)
            return 2048;
        if (StringType.StrCmp(sLeft, "ccs", false) == 0)
            return 2049;
        if (StringType.StrCmp(sLeft, "btm", false) == 0)
            return 2050;
        if (StringType.StrCmp(sLeft, "utm", false) == 0)
            return 2051;
        if (StringType.StrCmp(sLeft, "dwk", false) == 0)
            return 2052;
        if (StringType.StrCmp(sLeft, "pwk", false) == 0)
            return 2053;
        if (StringType.StrCmp(sLeft, "btg", false) == 0)
            return 2054;
        if (StringType.StrCmp(sLeft, "utg", false) == 0)
            return 2055;
        if (StringType.StrCmp(sLeft, "jrl", false) == 0)
            return 2056;
        if (StringType.StrCmp(sLeft, "sav", false) == 0)
            return 2057;
        if (StringType.StrCmp(sLeft, "utw", false) == 0)
            return 2058;
        if (StringType.StrCmp(sLeft, "4pc", false) == 0)
            return 2059;
        if (StringType.StrCmp(sLeft, "ssf", false) == 0)
            return 2060;
        if (StringType.StrCmp(sLeft, "hak", false) == 0)
            return 2061;
        if (StringType.StrCmp(sLeft, "nwm", false) == 0)
            return 2062;
        if (StringType.StrCmp(sLeft, "bik", false) == 0)
            return 2063;
        if (StringType.StrCmp(sLeft, "ndb", false) == 0)
            return 2064;
        if (StringType.StrCmp(sLeft, "ptm", false) == 0)
            return 2065;
        if (StringType.StrCmp(sLeft, "ptt", false) == 0)
            return 2066;
        if (StringType.StrCmp(sLeft, "lyt", false) == 0)
            return 3000;
        if (StringType.StrCmp(sLeft, "vis", false) == 0)
            return 3001;
        if (StringType.StrCmp(sLeft, "rim", false) == 0)
            return 3002;
        if (StringType.StrCmp(sLeft, "pth", false) == 0)
            return 3003;
        if (StringType.StrCmp(sLeft, "lip", false) == 0)
            return 3004;
        if (StringType.StrCmp(sLeft, "bwm", false) == 0)
            return 3005;
        if (StringType.StrCmp(sLeft, "txb", false) == 0)
            return 3006;
        if (StringType.StrCmp(sLeft, "tpc", false) == 0)
            return 3007;
        if (StringType.StrCmp(sLeft, "mdx", false) == 0)
            return 3008;
        if (StringType.StrCmp(sLeft, "rsv", false) == 0)
            return 3009;
        if (StringType.StrCmp(sLeft, "sig", false) == 0)
            return 3010;
        if (StringType.StrCmp(sLeft, "xbx", false) == 0)
            return 3011;
        if (StringType.StrCmp(sLeft, "erf", false) == 0)
            return 9997;
        if (StringType.StrCmp(sLeft, "bif", false) == 0)
            return 9998;
        return StringType.StrCmp(sLeft, "key", false) == 0 ? (short)9999 : (short)-1;
    }

    // TODO: Move to Identification

    public static object GetFilePath(
        string action,
        string startPath,
        string suggFilename,
        string msg,
        string filtertype,
        bool multiselect = false,
        bool updateSavePath = true)
    {
        if (StringType.StrCmp(action, "load", false) == 0)
        {
            var openFileDialog = new OpenFileDialog();
            var sLeft = filtertype;
            if (StringType.StrCmp(sLeft, "key", false) == 0)
            {
                openFileDialog.Title = "Select Chitin.key file...";
                openFileDialog.Filter = "Chitin files (*.key)|*.key";
            }
            else if (StringType.StrCmp(sLeft, "2da", false) == 0)
            {
                openFileDialog.Title = "Select 2DA file...";
                openFileDialog.Filter = "2D Array files (*.2da)|*.2da";
            }
            else if (StringType.StrCmp(sLeft, "tpc", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "TPC Files (*.tpc)|*.tpc";
            }
            else if (StringType.StrCmp(sLeft, "tga", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "TGA files (*.tga)|*.tga";
            }
            else if (StringType.StrCmp(sLeft, "xml", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
            }
            else if (StringType.StrCmp(sLeft, "dlg", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "DLG (Conversation) files (*.dlg)|*.dlg";
            }
            else if (StringType.StrCmp(sLeft, "tlk", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "Talk files (*.tlk)|*.tlk";
            }
            else if (StringType.StrCmp(sLeft, "pwk", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter =
                    "All Walkmesh files (*.pwk,*.dwk,*.wok)|*.pwk;*.dwk;*.wok|PWK files (*.pwk)|*.pwk|DWK files (*.dwk)|*.dwk|WOK files (*.wok)|*.wok";
            }
            else if (StringType.StrCmp(sLeft, "ssf", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "SSF files (*.ssf)|*.ssf";
            }
            else if (StringType.StrCmp(sLeft, "gffsupported", false) == 0)
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter =
                    "Supported GFF format files (*.dlg;*.utc;*.utd;*.uti;*.utm;*.utp;*.uts;*.utt;*.utw)|*.dlg;*.utc;*.utd;*.uti;*.utm;*.utp;*.uts;*.utt;*.utw";
                openFileDialog.Filter += "|Dialog files (*.dlg)|*.dlg";
                openFileDialog.Filter += "|Creature files (*.utc)|*.utc";
                openFileDialog.Filter += "|Door files (*.utd)|*.utd";
                openFileDialog.Filter += "|Item files (*.uti)|*.uti";
                openFileDialog.Filter += "|Merchant files (*.utm)|*.utm";
                openFileDialog.Filter += "|Placeable files (*.utp)|*.utp";
                openFileDialog.Filter += "|Sound files (*.uts)|*.uts";
                openFileDialog.Filter += "|Trigger files (*.utt)|*.utt";
                openFileDialog.Filter += "|Waypoint files (*.utw)|*.utw";
            }
            else
            {
                openFileDialog.Title = msg;
                openFileDialog.Filter = "All files (*.*)|*.*";
            }

            openFileDialog.InitialDirectory = startPath;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = multiselect;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = suggFilename;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return "";
            if (StringType.StrCmp(startPath, "", false) != 0)
            {
                CurrentSettings = UserSettings.GetSettings();
                CurrentSettings.defaultImportLocation = Strings.Mid(openFileDialog.FileName, 1,
                    openFileDialog.FileName.LastIndexOf("\\"));
                UserSettings.SaveSettings(CurrentSettings);
            }

            return !multiselect ? openFileDialog.FileName : (object)openFileDialog.FileNames;
        }

        if (StringType.StrCmp(action, "save", false) == 0)
        {
            var saveFileDialog = new SaveFileDialog();
            var sLeft = filtertype;
            if (StringType.StrCmp(sLeft, "2da", false) == 0)
            {
                saveFileDialog.Title = "Select 2DA file...";
                saveFileDialog.Filter = "2D Array files (*.2da)|*.2da";
            }
            else if (StringType.StrCmp(sLeft, "tpc", false) == 0)
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter = "TPC Files (*.tpc)|*.tpc";
            }
            else if (StringType.StrCmp(sLeft, "tga", false) == 0)
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter = "TGA files (*.tga)|*.tga";
            }
            else if (StringType.StrCmp(sLeft, "xml", false) == 0)
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            }
            else if (StringType.StrCmp(sLeft, "pwk", false) == 0)
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter =
                    "All Walkmesh files (*.pwk,*.dwk,*.wok)|*.pwk;*.dwk;*.wok|PWK files (*.pwk)|*.pwk|DWK files (*.dwk)|*.dwk|WOK files (*.wok)|*.wok";
            }
            else if (StringType.StrCmp(sLeft, "mod", false) == 0)
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter = "MOD files (*.mod)|*.mod";
            }
            else if (StringType.StrCmp(sLeft, "mod", false) == 0)
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter = "SSF files (*.ssf)|*.ssf";
            }
            else
            {
                saveFileDialog.Title = msg;
                saveFileDialog.Filter = "All files (*.*)|*.*";
            }

            saveFileDialog.InitialDirectory = startPath;
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = suggFilename;
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return "";
            if (updateSavePath)
            {
                CurrentSettings = UserSettings.GetSettings();
                CurrentSettings.defaultSaveLocation = Strings.Mid(saveFileDialog.FileName, 1,
                    saveFileDialog.FileName.LastIndexOf("\\"));
                UserSettings.SaveSettings(CurrentSettings);
            }

            return saveFileDialog.FileName;
        }

        var folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.Description = msg;
        folderBrowserDialog.SelectedPath = startPath;
        folderBrowserDialog.ShowNewFolderButton = true;
        if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
            return "";
        if (updateSavePath)
        {
            CurrentSettings = UserSettings.GetSettings();
            CurrentSettings.defaultSaveLocation = folderBrowserDialog.SelectedPath;
            UserSettings.SaveSettings(CurrentSettings);
        }

        return folderBrowserDialog.SelectedPath;
    }

    private void EditGffResource(string filename, byte[] data)
    {
        EnsureWorkingDirectoryExists();
        if (File.Exists(GRootPath + "working\\" + filename))
            File.Delete(GRootPath + "working\\" + filename);
        WriteByteArray(GRootPath + "working\\" + filename, data);
        LaunchGffEditor(GRootPath + "working\\" + filename);
    }

    private void LaunchGffEditor(string filename)
    {
        var fileName = GRootPath + "gffeditor.exe";
        try
        {
            Process.Start(fileName, filename);
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            if (StringType.StrCmp(ex.Message, "", false) != 0)
            {
                var num = (int)Interaction.MsgBox(
                    "                      Error launching GFFEditor\r\rIs it installed in the same directory as this program?");
            }

            ProjectData.ClearProjectError();
        }
    }

    private void EditTpcResource(string filename, byte[] data)
    {
        var frmImageViewer = new frmImageViewer();
        if (File.Exists(GRootPath + "tpc2tga.exe"))
        {
            var num1 = (int)Interaction.MsgBox(
                "tpc2tga is installed in the same directory as Kotor Tool, but is no longer needed",
                MsgBoxStyle.Critical, "TPC2TGA not needed");
        }

        if (!File.Exists(CurrentSettings.ImageViewerLocation))
        {
            var num2 = (int)Interaction.MsgBox(
                "The image viewer you have configured was not found in the location you specified",
                MsgBoxStyle.Critical, "Helper app missing");
        }
        else
        {
            EnsureWorkingDirectoryExists();
            frmImageViewer.SetupTPCData(data, "foo");
            frmImageViewer.DecodeImage();
            frmImageViewer.WriteTGAFile(GRootPath + "working\\" + Path.GetFileNameWithoutExtension(filename) +
                                        ".tga");
            var imageViewerLocation = CurrentSettings.ImageViewerLocation;
            try
            {
                Process.Start(imageViewerLocation,
                    "\"" + GRootPath + "working\\" + Path.GetFileNameWithoutExtension(filename) + ".tga" + "\"");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (StringType.StrCmp(ex.Message, "", false) != 0)
                {
                    var num3 = (int)Interaction.MsgBox(
                        "                      Error launching image viewer\r\rIs it installed where you specified it to be?");
                }

                ProjectData.ClearProjectError();
            }
        }
    }

    private void OpenTgaInExternalViewer(string filename, byte[] data)
    {
        var imageViewerLocation = CurrentSettings.ImageViewerLocation;
        if (!File.Exists(imageViewerLocation))
        {
            var num1 = (int)Interaction.MsgBox(
                "The image viewer you have configured was not found in the location you specified",
                MsgBoxStyle.Critical, "Helper app missing");
        }
        else
        {
            EnsureWorkingDirectoryExists();
            WriteByteArray(GRootPath + "working\\" + filename, data);
            try
            {
                Process.Start(imageViewerLocation, "\"" + GRootPath + "working\\" + filename + "\"");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (StringType.StrCmp(ex.Message, "", false) != 0)
                {
                    var num2 = (int)Interaction.MsgBox(
                        "                      Error launching image viewer\r\rIs it installed where you specified it to be?");
                }

                ProjectData.ClearProjectError();
            }
        }
    }

    private void ShowImage(KotorTreeNode node)
    {
        Array data;
        if (StringType.StrCmp(node.ContainingFileType, "ERF", false) == 0)
        {
            data = GetErfResource(node.FilePath, node);
        }
        else
        {
            if (StringType.StrCmp(node.ContainingFileType, "BIF", false) != 0)
                return;
            data = GetBiffResource(node.FilePath, node.LocalResId).Data;
        }

        if (GImageViewer == null || !GImageViewer.Created)
        {
            GImageViewer = new frmImageViewer();
            ((Control)GImageViewer).Location = new Point(checked(((Control)this).Location.X + Size.Width),
                ((Control)this).Location.Y);
        }

        GImageViewer.SetupTPCData(data, node.Filename);
        GImageViewer.DecodeImage();
        GImageViewer.Show();
    }

    public void EnsureWorkingDirectoryExists()
    {
        if (Directory.Exists(GRootPath + "working"))
            return;
        Directory.CreateDirectory(GRootPath + "working");
    }

    public static bool HasKotor1()
    {
        var registryKey = Registry.LocalMachine.OpenSubKey("software\\Bioware\\SW\\KOTOR");
        bool flag = false;
        if (registryKey != null)
            flag = registryKey.GetValue("path") != null;
        return flag;
    }

    public static bool HasKotor2()
    {
        var registryKey = Registry.LocalMachine.OpenSubKey("software\\LucasArts\\KotOR2");
        bool flag = false;
        if (registryKey != null)
            flag = registryKey.GetValue("path") != null;
        return flag;
    }

    public static bool IsOnly1KotORInstalled() => HasKotor1() ^ HasKotor2();

    public static int GetUniqueKotorInstalledVersion()
    {
        if (!IsOnly1KotORInstalled())
            return -1;
        if (HasKotor1())
            return 0;
        int num = 0;
        return HasKotor2() ? 1 : num;
    }

    private Form OpenFileFromCmdLine()
    {
        var num = checked(_cmdArgs.Length - 1);
        var index = 0;
        while (index <= num)
        {
            if (StringType.StrCmp(_cmdArgs[index], "-mapinfo", false) == 0)
            {
                CreateMapInfoBFD_Click(null, null);
                Environment.Exit(0);
            }

            checked
            {
                ++index;
            }
        }

        if (StringType.StrCmp(Path.GetExtension(_cmdArgs[0]).ToLower(), ".2da", false) != 0 &
            StringType.StrCmp(Path.GetExtension(_cmdArgs[0]).ToLower(), ".tlk", false) != 0)
            return OpenGffFileInEditor(_cmdArgs[0]);
        if (StringType.StrCmp(Path.GetExtension(_cmdArgs[0]).ToLower(), ".2da", false) == 0)
        {
            Cursor.Current = Cursors.WaitCursor;
            var input = new FileStream(_cmdArgs[0], FileMode.Open, FileAccess.Read);
            var binaryReader = new BinaryReader(input, Encoding.ASCII);
            var a2da = binaryReader.ReadBytes(checked((int)input.Length));
            binaryReader.Close();
            var frm2DaEditor = new frm2DAEditor(Path.GetFileName(_cmdArgs[0]), a2da);
            ((Control)frm2DaEditor).Location = new Point(checked(((Control)this).Location.X + Size.Width),
                ((Control)this).Location.Y);
            frm2DaEditor.Show();
            return frm2DaEditor;
        }

        if (StringType.StrCmp(Path.GetExtension(_cmdArgs[0]).ToLower(), ".tlk", false) != 0)
        {
            Form form = null;
            return form;
        }

        var frmDialogTlk = new frmDialogTlk(_cmdArgs[0]);
        frmDialogTlk.Show();
        return frmDialogTlk;
    }

    public static int GetGffFileKotorVersionIndex(string filepath)
    {
        FileStream fs;
        try
        {
            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
        }
        catch (FileNotFoundException ex)
        {
            ProjectData.SetProjectError(ex);
            throw new FileNotFoundException();
        }
        catch (DirectoryNotFoundException ex)
        {
            ProjectData.SetProjectError(ex);
            throw new DirectoryNotFoundException();
        }

        var kotorVersionIndex = new ClsGff(fs, -1).KotorVersIndex();
        if (kotorVersionIndex > -1)
            return kotorVersionIndex;
        if (kotorVersionIndex == -1 && IsOnly1KotORInstalled())
        {
            var str = GetUniqueKotorInstalledVersion() != 0 ? "KotOR II:TSL" : "KotOR I";
            return Interaction.MsgBox(
                "The file '" + Path.GetFileName(filepath) +
                "' has no embedded version info. Do you want to open in using " + str + "'s data?",
                MsgBoxStyle.YesNo, "") == MsgBoxResult.Yes
                ? GetUniqueKotorInstalledVersion()
                : -1;
        }

        var specifyKotorVersion = new frmSpecifyKotorVersion();
        specifyKotorVersion.FileName = Path.GetFileName(filepath);
        return specifyKotorVersion.ShowDialog(Mainform) == DialogResult.OK
            ? specifyKotorVersion.KotorVerIndexSelected
            : -1;
    }

    public Form OpenGffFileInEditor(string filepath, int formLocationOffset = -1)
    {
        int kotorVersionIndex;
        try
        {
            kotorVersionIndex = GetGffFileKotorVersionIndex(filepath);
        }
        catch (FileNotFoundException ex)
        {
            ProjectData.SetProjectError(ex);
            ManageMruMainFileList(filepath, true);
            var num = (int)Interaction.MsgBox("Could not find file: " + filepath, MsgBoxStyle.Critical, "");
            ProjectData.ClearProjectError();
            goto label_26;
        }
        catch (DirectoryNotFoundException ex)
        {
            ProjectData.SetProjectError(ex);
            ManageMruMainFileList(filepath, true);
            var num = (int)Interaction.MsgBox("Could not directory in path to: " + filepath, MsgBoxStyle.Critical,
                "");
            ProjectData.ClearProjectError();
            goto label_26;
        }

        if (kotorVersionIndex != -1)
        {
            var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            var sLeft = Strings.LCase(Path.GetExtension(filepath));
            object o;
            if (StringType.StrCmp(sLeft, ".utc", false) == 0)
                o = new frmUTC_Editor(new clsUTC(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".uti", false) == 0)
                o = new frmUTI_Editor(new clsUTI(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".utd", false) == 0)
                o = new frmUTD_Editor(new clsUTD(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".utm", false) == 0)
                o = new frmUTM_Editor(new clsUTM(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".utp", false) == 0)
                o = new frmUTP_Editor(new clsUTP(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".uts", false) == 0)
                o = new frmUTS_Editor(new clsUTS(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".utt", false) == 0)
                o = new frmUTT_Editor(new clsUTT(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".utw", false) == 0)
                o = new frmUTW_Editor(new clsUTW(fs, kotorVersionIndex), kotorVersionIndex);
            else if (StringType.StrCmp(sLeft, ".dlg", false) == 0)
            {
                o = new frmDialogEditor(fs, kotorVersionIndex);
            }
            else
            {
                var num = (int)Interaction.MsgBox("There is no editor available for that file type",
                    MsgBoxStyle.Exclamation, "Unsupported File Type");
                goto label_26;
            }

            ManageMruMainFileList(filepath);
            ((frmParent)o).EditingFilePath = filepath;
            LateBinding.LateCall(o, null, "Show", new object[0], null, null);
            if (formLocationOffset != -1)
                ((Control)o).Location = new Point(checked(((Control)o).Location.X + formLocationOffset),
                    checked(((Control)o).Location.Y + formLocationOffset));
            return (Form)o;
        }

        label_26:
        Form form = null;
        return form;
    }

    private void Open2DaFileEditor() => new frm2DAEditor().Show();

    private void OpenTextEditor() => new frmTextEditor().Show();

    private void OpenErfBuilder() => new frmERFManager().Show();

    private void OpenConversationEditor()
    {
        var frmDialogEditor = new frmDialogEditor();
        frmDialogEditor.SetupForNewDialog();
        frmDialogEditor.Show();
    }

    private void ManageMruMainFileList(string filepath, bool delete = false)
    {
        CurrentSettings = UserSettings.GetSettings();
        var index = CurrentSettings.MRUMainFiles.IndexOf(filepath);
        if (!delete)
        {
            if (index == -1)
            {
                CurrentSettings.MRUMainFiles.Insert(0, filepath);
                if (CurrentSettings.MRUMainFiles.Count > 10)
                {
                    while (CurrentSettings.MRUMainFiles.Count > 10)
                        CurrentSettings.MRUMainFiles.RemoveAt(checked(CurrentSettings.MRUMainFiles.Count - 1));
                }
            }
            else
            {
                CurrentSettings.MRUMainFiles.RemoveAt(index);
                CurrentSettings.MRUMainFiles.Insert(0, filepath);
            }
        }
        else if (index != -1)
            CurrentSettings.MRUMainFiles.RemoveAt(index);

        ManageMruMainFileMenu();
        UserSettings.SaveSettings(CurrentSettings);
    }

    private void ManageMruMainFileMenu()
    {
        /*var miRecentFiles = this.MiRecentFiles;
        miRecentFiles.ToolStripMenuItems.Clear();
        try
        {
            foreach (var mruMainFile in CurrentSettings.MRUMainFiles)
            {
                var ToolStripMenuItem = new ToolStripMenuItem(Path.GetFileName(StringType.FromObject(mruMainFile)),
                    new EventHandler(miRecentFiles_Click));
                miRecentFiles.ToolStripMenuItems.Add(ToolStripMenuItem);
            }
        }
        finally
        {
        }*/
    }

    public static void CleanDirectory(string dirname)
    {
        var directoryInfo1 = new DirectoryInfo(dirname);
        int num = 0;
        try
        {
            var directories = (FileSystemInfo[])directoryInfo1.GetDirectories();
            Console.WriteLine("Number of directories: {0}", directories.Length);
            var fileSystemInfoArray = directories;
            var index1 = 0;
            while (index1 < fileSystemInfoArray.Length)
            {
                var directoryInfo2 = (DirectoryInfo)fileSystemInfoArray[index1];
                var fileSystemInfos = directoryInfo2.GetFileSystemInfos();
                var index2 = 0;
                while (index2 < fileSystemInfos.Length)
                {
                    var fileSystemInfo = fileSystemInfos[index2];
                    switch (num)
                    {
                        case 0:
                            Cursor.Current = Cursors.PanNorth;
                            break;
                        case 1:
                            Cursor.Current = Cursors.PanNE;
                            break;
                        case 2:
                            Cursor.Current = Cursors.PanEast;
                            break;
                        case 3:
                            Cursor.Current = Cursors.PanSE;
                            break;
                        case 4:
                            Cursor.Current = Cursors.PanSouth;
                            break;
                        case 5:
                            Cursor.Current = Cursors.PanSW;
                            break;
                        case 6:
                            Cursor.Current = Cursors.PanWest;
                            break;
                        case 7:
                            Cursor.Current = Cursors.PanNW;
                            num = -1;
                            break;
                    }

                    checked
                    {
                        ++num;
                    }

                    File.Delete(fileSystemInfo.FullName);
                    checked
                    {
                        ++index2;
                    }
                }

                Directory.Delete(directoryInfo2.FullName);
                checked
                {
                    ++index1;
                }
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Console.WriteLine("The process failed: {0}", ex.ToString());
            ProjectData.ClearProjectError();
        }

        try
        {
            var files = directoryInfo1.GetFiles();
            var index = 0;
            while (index < files.Length)
            {
                var fileInfo = files[index];
                switch (num)
                {
                    case 0:
                        Cursor.Current = Cursors.PanNorth;
                        break;
                    case 1:
                        Cursor.Current = Cursors.PanNE;
                        break;
                    case 2:
                        Cursor.Current = Cursors.PanEast;
                        break;
                    case 3:
                        Cursor.Current = Cursors.PanSE;
                        break;
                    case 4:
                        Cursor.Current = Cursors.PanSouth;
                        break;
                    case 5:
                        Cursor.Current = Cursors.PanSW;
                        break;
                    case 6:
                        Cursor.Current = Cursors.PanWest;
                        break;
                    case 7:
                        Cursor.Current = Cursors.PanNW;
                        num = -1;
                        break;
                }

                checked
                {
                    ++num;
                }

                File.Delete(fileInfo.FullName);
                checked
                {
                    ++index;
                }
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Console.WriteLine("The process failed: {0}", ex.ToString());
            ProjectData.ClearProjectError();
        }
    }

    public static void OpenTreeViewToPath(
        string treepath,
        TreeNode currNode,
        int currLevel,
        bool SelectAfterExpand = true)
    {
        var strArray = treepath.Split('\\');
        if (currLevel == strArray.Length)
            return;
        if (currLevel == 0)
        {
            try
            {
                foreach (TreeNode node in currNode.TreeView.Nodes)
                {
                    if (StringType.StrCmp(node.Text, strArray[currLevel], false) == 0)
                    {
                        node.Expand();
                        if (SelectAfterExpand)
                            node.TreeView.SelectedNode = node;
                        OpenTreeViewToPath(treepath, node, checked(currLevel + 1), SelectAfterExpand);
                    }
                }
            }
            finally
            {
            }
        }
        else
        {
            try
            {
                foreach (TreeNode node in currNode.Nodes)
                {
                    if (StringType.StrCmp(TrimAfterDash(node.Text), TrimAfterDash(strArray[currLevel]), false) == 0)
                    {
                        node.Expand();
                        node.TreeView.SelectedNode = node;
                        OpenTreeViewToPath(treepath, node, checked(currLevel + 1), SelectAfterExpand);
                    }
                }
            }
            finally
            {
            }
        }
    }

    public static string TrimAfterDash(string s) =>
        s.IndexOf("-") == -1 ? s : s.Substring(0, checked(s.IndexOf("-") - 1));

    private void CheckForUpdateA()
    {
        /*var requestUriString = _gDownloadUrl + "version.htm";
        try
        {
            ((HttpWebRequest)WebRequest.Create(_gDownloadUrl + "busy.htm")).GetResponse();
            Console.WriteLine("Busy.htm file found; exiting.");
            return;
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Console.WriteLine(ex.ToString());
            ProjectData.ClearProjectError();
        }

        string end;
        try
        {
            var response = ((HttpWebRequest)WebRequest.Create(requestUriString)).GetResponse();
            Console.WriteLine("Response received.");
            var streamReader = new StreamReader(response.GetResponseStream());
            end = streamReader.ReadToEnd();
            streamReader.Close();
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            var exception = ex;
            Console.WriteLine(exception.ToString());
            var num = (int)Interaction.MsgBox(
                "Could not retrieve information on the latest version of Kotor Tool.\nError: " + exception.Message,
                MsgBoxStyle.Critical, "Error");
            ProjectData.ClearProjectError();
            return;
        }

        var match1 = new Regex("<title>(?<match>.*?)</title>", RegexOptions.IgnoreCase | RegexOptions.Singleline)
            .Match(end);
        var match2 =
            new Regex("<version>(?<match>.*?)</version>", RegexOptions.IgnoreCase | RegexOptions.Singleline)
                .Match(end);
        var match3 = new Regex("<filename>(?<match>.*?)</filename>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(end);
        var match4 = new Regex("<comments>(?<match>.*?)</comments>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(end);
        if (match1.Success)
            Console.WriteLine("Found title: " + match1.Groups["match"].Value);
        string str1 = null;
        if (match2.Success)
        {
            str1 = match2.Groups["match"].Value;
            Console.WriteLine("Found version: " + str1);
        }

        string url = null;
        string str2 = null;
        if (match3.Success)
        {
            Console.WriteLine("Found file name: " + match3.Groups["match"].Value);
            url = match3.Groups["match"].Value;
            str2 = url.Split('/')[url.Split('/').GetUpperBound(0)];
        }

        var regex = new Regex("<signature>(?<match>.*?)</signature>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline);
        var sLeft = match4.Groups["match"].Value;
        if (StringType.StrCmp(sLeft, "", false) != 0)
            sLeft = "\nNotes:\n" + sLeft;
        var match5 = regex.Match(end);
        if (StringType.StrCmp(Application.ProductVersion.ToString(), str1, false) < 0)
        {
            if (!CurrentSettings.bDownloadUpdatesAutomatically &&
                Interaction.MsgBox(
                    "A newer version of Kotor Tool is available. Would you like to download it?" + sLeft,
                    MsgBoxStyle.YesNo, "Update Available") != MsgBoxResult.Yes)
                return;
            _gDownloadfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _gDownloadfile = _gDownloadfile + "\\" + str2;
            var downloadUpdate = new DownloadUpdate(DownloadUpdateA);
            Console.WriteLine("Update found, starting download thread");
            downloadUpdate.BeginInvoke(url, _gDownloadfile, match5.Groups["match"].Value, str1, null, null);
        }
        else
        {
            if (!_gCheckForUpdatesSilently)
            {
                var num = (int)Interaction.MsgBox("No newer version of Kotor Tool is available",
                    MsgBoxStyle.Information, "Info");
            }

            Console.WriteLine("No update found, exiting version check thread");
        }*/
    }

    private void DownloadUpdateA(
        string url,
        string filePath,
        string signature,
        string onlineVersion)
    {
        try
        {
            var webClient = new WebClient();
            webClient.DownloadFile(url, filePath);
            webClient.Dispose();
            Console.WriteLine("Downloading complete. Validating...");
            if (ValidateFile(filePath, signature))
            {
                try
                {
                    if (File.Exists(Path.GetDirectoryName(filePath) + "\\Kotor Tool Setup v" + onlineVersion +
                                    ".exe"))
                        File.Delete(Path.GetDirectoryName(filePath) + "\\Kotor Tool Setup v" + onlineVersion +
                                    ".exe");
                    File.Move(filePath,
                        Path.GetDirectoryName(filePath) + "\\Kotor Tool Setup v" + onlineVersion + ".exe");
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Console.WriteLine(ex.ToString());
                    ProjectData.ClearProjectError();
                }

                if (Interaction.MsgBox(
                        "A new version of Kotor Tool has been downloaded. Would you like to install it now?",
                        MsgBoxStyle.YesNo, "Install now?") == MsgBoxResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(Path.GetDirectoryName(filePath) + "\\Kotor Tool Setup v" +
                                                       onlineVersion + ".exe"));
                    Environment.Exit(0);
                }
                else
                {
                    var num = (int)Interaction.MsgBox(
                        "You can install the update later by running the setup program at:\n" + filePath,
                        MsgBoxStyle.Information, "Info");
                }
            }
            else
            {
                var num1 = (int)Interaction.MsgBox(
                    "Downloaded file did not validate against online version. You may want to try downloading manually.",
                    MsgBoxStyle.Exclamation, "Download Validation Error");
            }
        }
        catch (WebException ex)
        {
            ProjectData.SetProjectError(ex);
            Console.WriteLine(ex.ToString());
            ProjectData.ClearProjectError();
        }
    }

    private bool ValidateFile(string filePath, string signature)
    {
        var utilFileValidator = new FileValidator();
        utilFileValidator.Init(utilFileValidator.GenerateBase64Key("Test String"));
        return utilFileValidator.Validate(filePath, signature);
    }

    // TODO : Move to new Form
    private void Form1_Load(object sender, EventArgs e)
    {
        Mainform = this;
        GRootPath = "Thomas A. Luetz II";
        var registryKey = Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool");
        if (registryKey == null)
        {
            var num = (int)Interaction.MsgBox(
                "Kotor Tool cannot find its key in the registry at HKLM\\software\\SCM\\Kotor Tool.\n\nPlease reinstall Kotor Tool.",
                MsgBoxStyle.Critical);
            Environment.Exit(0);
        }

        GRootPath = StringType.FromObject(registryKey.GetValue("path"));
        if (!GRootPath.EndsWith("\\"))
            GRootPath += "\\";
        //TreeView.HideSelection = false;
        //Text = "Kotor Tool v" + Application.ProductVersion + "";
        _hasK1 = HasKotor1();
        _hasK2 = HasKotor2();
        CurrentSettings = UserSettings.GetSettings();
        var mainWindowLoc = CurrentSettings.MainWindowLoc;
        if (mainWindowLoc.X < 0 | mainWindowLoc.Y < 0)
        {
            mainWindowLoc.X = 100;
            mainWindowLoc.Y = 100;
            CurrentSettings.MainWindowLoc = mainWindowLoc;
            UserSettings.SaveSettings(CurrentSettings);
        }

        ((Control)this).Location = mainWindowLoc;
        if (!CurrentSettings.MainWindowSize.IsEmpty)
        {
            var size1 = CurrentSettings.MainWindowSize;
            Point location1 = default;
            Point location2 = default;
            int height1 = 0;
            if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                ref var local1 = ref location1;
                location2 = ((Control)this).Location;
                var x = location2.X;
                var top = Screen.PrimaryScreen.WorkingArea.Top;
                local1 = new Point(x, top);
                ((Control)this).Location = location1;
                height1 = Screen.PrimaryScreen.WorkingArea.Height;
                Size size2 = default;
                ref var local2 = ref size2;
                size1 = Size;
                var width = size1.Width;
                var height2 = height1;
                local2 = new Size(width, height2);
                Size = size2;
            }

            var size3 = CurrentSettings.MainWindowSize;
            int width1 = 0;
            if (size3.Width > Screen.PrimaryScreen.WorkingArea.Width)
            {
                ref var local3 = ref location2;
                var left = Screen.PrimaryScreen.WorkingArea.Left;
                location1 = ((Control)this).Location;
                var y = location1.Y;
                local3 = new Point(left, y);
                ((Control)this).Location = location2;
                width1 = Screen.PrimaryScreen.WorkingArea.Width;
                ref var local4 = ref size1;
                var width2 = width1;
                size3 = Size;
                var height3 = size3.Height;
                local4 = new Size(width2, height3);
                Size = size1;
            }

            if (width1 == 0 & height1 == 0)
                Size = CurrentSettings.MainWindowSize;
        }

        if (!_hasK1 & !_hasK2)
        {
            var num1 = (int)Interaction.MsgBox(
                "No installation of Kotor I or II was detected.\n\nMost features will not work.",
                MsgBoxStyle.Critical, "No games detected");
        }

        if (StringType.StrCmp(CurrentSettings.defaultKotORLocation, "", false) == 0 & _hasK1 |
            StringType.StrCmp(CurrentSettings.defaultKotORLocation2, "", false) == 0 & _hasK2)
        {
            var frmPathManager = new frmPathManager();
            var num2 = (int)Interaction.MsgBox(
                "We've attempted to detect your KotOR installation,\rbut please verify the directories are correct.",
                MsgBoxStyle.Information, "First run configuration");
            if (StringType.StrCmp(CurrentSettings.defaultKotORLocation, "", false) == 0 & _hasK1)
                frmPathManager.btnAutoDetectKotor1_Click(null, null);
            if (StringType.StrCmp(CurrentSettings.defaultKotORLocation2, "", false) == 0 & _hasK2)
                frmPathManager.btnAutoDetectKotor2_Click(null, null);
            frmPathManager.StartPosition = FormStartPosition.CenterScreen;
            var num3 = (int)frmPathManager.ShowDialog(this);
            CurrentSettings = UserSettings.GetSettings();
            CurrentSettings.bBuildModelsBifNode = true;
        }

        if (_hasK1)
        {
            GK1ChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(0));
            Console.WriteLine("gK1ChitinKey: Lsum = " + StringType.FromLong(GK1ChitinKey.Lsum) + ", Llength = " +
                              StringType.FromLong(GK1ChitinKey.Llength));
            /*if (!ChitinKey.IsValid(GK1ChitinKey._hashtableBiff, 0))
            {
                var num4 = (int)Interaction.MsgBox(
                    "Your Kotor I chitin.key file appears to be corrupt.\nYou may want to reinstall KotOR II to fix this.",
                    MsgBoxStyle.Information, "Chitin.key file not valid");
            }

            if (GK1ChitinKey.BiffList.Length != 26)
            {
                var num5 = (int)Interaction.MsgBox(
                    "Your Kotor I chitin.key file appears to have been altered from the official version.\n\nIf you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.",
                    MsgBoxStyle.Critical, "Chitin.key file altered");
            }*/
        }

        if (_hasK2)
        {
            GK2ChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(1));
            Console.WriteLine("gK2ChitinKey: Lsum = " + StringType.FromLong(GK2ChitinKey.Lsum) + ", Llength = " +
                              StringType.FromLong(GK2ChitinKey.Llength));
            /*if (!ChitinKey.IsValid(GK2ChitinKey._hashtableBiff, 1))
            {
                var num6 = (int)Interaction.MsgBox(
                    "Your Kotor II chitin.key file appears to be corrupt or is a non-US version.",
                    MsgBoxStyle.Information, "Chitin.key file not valid");
            }

            if (GK2ChitinKey.BiffList.Length != 11)
            {
                var num7 = (int)Interaction.MsgBox(
                    "Your Kotor II chitin.key file appears to have been altered from the official version.\n\nIf you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.",
                    MsgBoxStyle.Critical, "Chitin.key file altered");
            }*/
        }

        SetupTreeRoots();
        /*
        if (!_hasK1)
        {
            TreeView.Nodes[0].ForeColor = Color.Gray;
        }

        if (!_hasK2)
        {
            TreeView.Nodes[1].ForeColor = Color.Gray;
        }

        if (_hasK1)
            SetupRootChildren((KotorTreeNode)TreeView.Nodes[0]);
        if (_hasK2)
            SetupRootChildren((KotorTreeNode)TreeView.Nodes[1]);
        if (CurrentSettings.bBuildBIFFtreeOnStartup)
        {
            if (_hasK1)
                BuildTreeView((KotorTreeNode)TreeView.Nodes[0]);
            if (_hasK2)
                BuildTreeView((KotorTreeNode)TreeView.Nodes[1]);
        }

        if (IsOnly1KotORInstalled())
        {
            if (_hasK1)
                TreeView.SelectedNode = TreeView.Nodes[0];
            if (_hasK2)
                TreeView.SelectedNode = TreeView.Nodes[1];
        }
        */

        CreateTemplateTagsHashFiles();
        ExtractNwScripts();
        if (_cmdArgs != null)
            _gCmdLineOpenedForm = OpenFileFromCmdLine();
        ManageMruMainFileMenu();
        /*if (CurrentSettings.bRememberLastTreeNode && CurrentSettings.LastClickedTVNodePath != null &&
            StringType.StrCmp(CurrentSettings.LastClickedTVNodePath, "", false) != 0)
            OpenTreeViewToPath(CurrentSettings.LastClickedTVNodePath, TreeView.Nodes[0], 0);*/
        if (CurrentSettings.bRememberTreeViewState)
        {
            try
            {
                /*foreach (var treeOpenPath in CurrentSettings.TreeOpenPaths)
                    OpenTreeViewToPath(StringType.FromObject(treeOpenPath), TreeView.Nodes[0], 0);*/
            }
            finally
            {
            }
        }

        if (CurrentSettings.bCheckForUpdatesAtStartup)
        {
            // _gCheckForUpdatesSilently = true;
            var checkForUpdate = new CheckForUpdate(CheckForUpdateA);
            Console.WriteLine("Starting CheckForUpdate thread");
            checkForUpdate.BeginInvoke(null, null);
        }

        UserSettings.SaveSettings(CurrentSettings);
    }
// TODO : Move to new Form
    private void frmMain_Closing(object sender, CancelEventArgs e) => SaveSettings();
// TODO : Move to new Form
    private void frmMain_Move(object sender, EventArgs e)
    {
        if (CurrentSettings == null || !CurrentSettings.bDockImageViewer || GImageViewer == null ||
            !GImageViewer.Visible)
            return;
        ((Control)GImageViewer).Location = new Point(checked(((Control)this).Location.X + Size.Width),
            ((Control)this).Location.Y);
    }
// TODO : Move to new Form
    private void frmMain_Activated(object sender, EventArgs e)
    {
        if (!(_cmdArgs != null & _gCmdLineOpenedForm != null))
            return;
        _gCmdLineOpenedForm.BringToFront();
        _gCmdLineOpenedForm = null;
    }

    private void CreateMapInfoBFD_Click(object sender, EventArgs e) => new clsMapInfoCreator().Write(GRootPath);

    private void btnExtract_Click(object sender, EventArgs e)
    {
        //ExtractSelectedKotorFile((KotorTreeNode)TreeView.SelectedNode);
    }

    private object ExtractSelectedKotorFile(
        KotorTreeNode node,
        string outputpath = "",
        string SaveMsg = "",
        Hashtable ResTypes = null)
    {
        var tag = node.Tag;
        if (ObjectType.ObjTst(tag, "RIM", false) == 0)
        {
            if (StringType.StrCmp(SaveMsg, "", false) == 0)
            {
                SaveMsg = "Select Folder to extract RIM to...";
            }
            if (StringType.StrCmp(outputpath, "", false) == 0)
            {
                outputpath =
                    StringType.FromObject(ObjectType.StrCatObj(
                        GetFilePath(string.Empty, CurrentSettings.defaultSaveLocation, string.Empty, SaveMsg, string.Empty),
                        "\\"));
            }
            if (StringType.StrCmp(outputpath, "\\", false) != 0)
            {
                var current = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                   
                var input = new FileStream(node.FilePath + "\\" + node.Filename, FileMode.Open, FileAccess.Read);
                var binaryReader = new BinaryReader(input, Encoding.ASCII);
                var data = binaryReader.ReadBytes(checked((int)input.Length));
                binaryReader.Close();
                   
                var clsRim = ClsRim.CreateInstance(data);
                if (ResTypes == null)
                {
                    var num = checked(clsRim.EntryCount - 1);
                    var index = 0;
                    while (index <= num)
                    {
                        WriteByteArray(
                            outputpath + ((RimKeyEntry)clsRim.KeyEntryList[index])._ResourceName + "." +
                            ((RimKeyEntry)clsRim.KeyEntryList[index])._ResTypeStr, clsRim.GetRimResource(index));
                        checked
                        {
                            ++index;
                        }
                    }
                }
                else
                {
                    var num = checked(clsRim.EntryCount - 1);
                    var index = 0;
                    while (index <= num)
                    {
                        if (ResTypes.Contains(((RimKeyEntry)clsRim.KeyEntryList[index])._ResType))
                            WriteByteArray(
                                outputpath + ((RimKeyEntry)clsRim.KeyEntryList[index])._ResourceName + "." +
                                ((RimKeyEntry)clsRim.KeyEntryList[index])._ResTypeStr,
                                clsRim.GetRimResource(index));
                        checked
                        {
                            ++index;
                        }
                    }
                }

                Cursor.Current = current;
            }
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0)
        {
            outputpath = StringType.FromObject(GetFilePath("save", CurrentSettings.defaultSaveLocation,
                node.Filename, "Save " + node.Filename + " file...", node.ResTypeStr));
            if (StringType.StrCmp(outputpath, "", false) != 0)
            {
                var rimResource = GetRimResource(node.FilePath, node);
                WriteByteArray(outputpath, rimResource);
            }
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "BIFF", false) == 0)
        {
            if (StringType.StrCmp(outputpath, "", false) == 0)
                outputpath = StringType.FromObject(ObjectType.StrCatObj(
                    GetFilePath("", CurrentSettings.defaultSaveLocation, "", "Select Folder to extract BIF to...",
                        ""), "\\"));
            if (StringType.StrCmp(outputpath, "\\", false) != 0)
            {
                var current = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    foreach (KotorTreeNode node1 in node.Nodes)
                    {
                        var num = checked(node1.GetNodeCount(false) - 1);
                        var index = 0;
                        while (index <= num)
                        {
                            ExportBiffResource(node.FilePath + "\\" + node.Filename,
                                outputpath + ((KotorTreeNode)node1.Nodes[index]).ResRef + "." +
                                ((KotorTreeNode)node1.Nodes[index]).ResTypeStr,
                                ((KotorTreeNode)node1.Nodes[index]).LocalResId);
                            checked
                            {
                                ++index;
                            }
                        }
                    }
                }
                finally
                {
                }

                Cursor.Current = current;
            }
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "BIFF_Res", false) == 0)
        {
            outputpath = StringType.FromObject(GetFilePath("save", CurrentSettings.defaultSaveLocation,
                node.Filename, "Save " + node.Filename + " file...", node.ResTypeStr));
            if (StringType.StrCmp(outputpath, "", false) != 0)
                ExportBiffResource(node.FilePath, outputpath, node.LocalResId);
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "ERF", false) == 0)
        {
            outputpath = StringType.FromObject(ObjectType.StrCatObj(
                GetFilePath("", CurrentSettings.defaultSaveLocation, "", "Select Folder to extract ERF to...", ""),
                "\\"));
            if (StringType.StrCmp(outputpath, "\\", false) != 0)
            {
                var fs = new FileStream(node.FilePath + "\\" + node.Filename, FileMode.Open, FileAccess.Read);
                var clsErf = new ClsErf(fs);
                var childForm = new FrmProgressMeter();
                childForm.StepAmount = 1;
                childForm.Maxvalue = clsErf.EntryCount;
                childForm.Message = "Extracting files from " + node.Filename;
                ((Control)childForm).Location = new utilWindowRelativePositioner(this, childForm).GetConcentric();
                childForm.Show();
                var num = checked(clsErf.EntryCount - 1);
                var index = 0;
                while (index <= num)
                {
                    var erfResource = clsErf.GetErfResource(index);
                    var keyEntry = (ERFKeyEntry)clsErf.KeyEntryList[index];
                    childForm.Status = "Writing " + keyEntry._ResourceName + "." + keyEntry._ResTypeStr;
                    var fileStream =
                        new FileStream(outputpath + keyEntry._ResourceName + "." + keyEntry._ResTypeStr,
                            FileMode.Create);
                    fileStream.Write(erfResource, 0, erfResource.Length);
                    fileStream.Close();
                    childForm.StepUp();
                    checked
                    {
                        ++index;
                    }
                }

                fs.Close();
                childForm.Close();
            }
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "ERF_Res", false) == 0)
        {
            string sLeft = null;
            if (StringType.StrCmp(node.ResTypeStr, "tpc", false) == 0)
            {
                if (!CurrentSettings.bAlwaysConvertTPC2TGA)
                {
                    var frmTpcFileSaveType = new frmTPCFileSaveType();
                    if (frmTpcFileSaveType.ShowDialog(this) != DialogResult.Cancel)
                        sLeft = frmTpcFileSaveType.saveType;
                    else
                        goto label_78;
                }
                else
                    sLeft = "tga";

                outputpath = StringType.StrCmp(sLeft, "tga", false) != 0
                    ? StringType.FromObject(GetFilePath("save", CurrentSettings.defaultSaveLocation, node.Filename,
                        "Save " + node.Filename + " file...", "tpc"))
                    : StringType.FromObject(GetFilePath("save", CurrentSettings.defaultSaveLocation,
                        node.ResRef + ".tga", "Save " + node.ResRef + ".tga file...", "tga"));
            }
            else
                outputpath = StringType.FromObject(GetFilePath("save", CurrentSettings.defaultSaveLocation,
                    node.Filename + "", "Save " + node.Filename + " file...", ""));

            if (StringType.StrCmp(outputpath, "", false) != 0)
            {
                var erfResource = GetErfResource(node.FilePath, node);
                if (StringType.StrCmp(sLeft, "tga", false) == 0)
                {
                    var frmImageViewer = new frmImageViewer();
                    frmImageViewer.SetupTPCData(erfResource, "foo");
                    frmImageViewer.DecodeImage();
                    frmImageViewer.WriteTGAFile(outputpath);
                }
                else
                    WriteByteArray(outputpath, erfResource);
            }
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "NodeCategory", false) == 0)
        {
            var containingFileType = ((KotorTreeNode)node.Parent).ContainingFileType;
            var parent = (KotorTreeNode)node.Parent;
            if (StringType.StrCmp(containingFileType, "BIF", false) == 0 ||
                StringType.StrCmp(containingFileType, "rim", false) == 0)
            {
                if (StringType.StrCmp(SaveMsg, "", false) == 0)
                    SaveMsg = "Select Folder to extract entire subtype to...";
                if (StringType.StrCmp(outputpath, "", false) == 0)
                    outputpath = StringType.FromObject(ObjectType.StrCatObj(
                        GetFilePath("", CurrentSettings.defaultSaveLocation, "", SaveMsg, ""), "\\"));
                if (StringType.StrCmp(outputpath, "\\", false) == 0)
                    goto label_78;
            }

            var sLeft = containingFileType;
            if (StringType.StrCmp(sLeft, "BIF", false) == 0)
            {
                var current = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    foreach (KotorTreeNode node2 in node.Nodes)
                        ExportBiffResource(parent.FilePath + "\\" + parent.Filename,
                            outputpath + node2.ResRef + "." + node2.ResTypeStr, node2.LocalResId);
                }
                finally
                {
                }

                Cursor.Current = current;
            }
            else if (StringType.StrCmp(sLeft, "rim", false) == 0)
            {
                var current = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                var input = new FileStream(parent.FilePath + "\\" + parent.Filename, FileMode.Open,
                    FileAccess.Read);
                var binaryReader = new BinaryReader(input, Encoding.ASCII);
                var indata = binaryReader.ReadBytes(checked((int)input.Length));
                binaryReader.Close();
                var clsRim = ClsRim.CreateInstance(indata);
                var num = checked(clsRim.EntryCount - 1);
                var index = 0;
                while (index <= num)
                {
                    if (((RimKeyEntry)clsRim.KeyEntryList[index])._ResType == node.ResType)
                        WriteByteArray(
                            outputpath + ((RimKeyEntry)clsRim.KeyEntryList[index])._ResourceName + "." +
                            ((RimKeyEntry)clsRim.KeyEntryList[index])._ResTypeStr, clsRim.GetRimResource(index));
                    checked
                    {
                        ++index;
                    }
                }

                Cursor.Current = current;
            }
        }

        return outputpath;
        label_78:
        object selectedKotorFile = null;
        return selectedKotorFile;
    }

    private void btnHexViewer_Click(object sender, EventArgs e)
    {
        /*var selectedNode = null;
        //var selectedNode = (KotorTreeNode)TreeView.SelectedNode;
        if (selectedNode == null || ObjectType.ObjTst(selectedNode.Tag, "BIFF_Root", false) == 0 ||
            ObjectType.ObjTst(selectedNode.Tag, "RIM_Root", false) == 0)
            return;*/
        /*var tag = selectedNode.Tag;
        frmByteViewer frmByteViewer;
        if (ObjectType.ObjTst(tag, "BIFF", false) == 0 || ObjectType.ObjTst(tag, "RIM", false) == 0)
            frmByteViewer = new frmByteViewer(selectedNode.FilePath + "\\" + selectedNode.Filename);
        else if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0)
            frmByteViewer = new frmByteViewer(GetRimResource(selectedNode.FilePath, selectedNode));
        else if (ObjectType.ObjTst(tag, "BIFF_Res", false) == 0)
        {
            frmByteViewer = new frmByteViewer(GetBiffResource(selectedNode.FilePath, selectedNode.LocalResId).Data);
        }
        else
        {
            if (ObjectType.ObjTst(tag, "ERF_Res", false) != 0)
                return;
            frmByteViewer = new frmByteViewer(GetErfResource(selectedNode.FilePath, selectedNode));
        }

        frmByteViewer.Show();*/
    }

    private void TreeView_DoubleClick(object sender, EventArgs e)
    {
        //HandleDataByNodeType((KotorTreeNode)TreeView.SelectedNode, RuntimeHelpers.GetObjectValue(sender));
    }
           

    private string GetMdlRoomBaseName(KotorTreeNode node)
    {
        switch (NodeTreeRootIndex(node))
        {
            case 0:
                return node.ResRef.Substring(0, 5);
            case 1:
                return node.ResRef.Substring(0, 6);
            default:
                string mdlRoomBaseName = null;
                return mdlRoomBaseName;
        }
    }

    private int GetMdlRoomCount(KotorTreeNode node)
    {
        var mdlRoomCount = -1;
        var biffResourceData = GetBiffResourceData(NodeTreeRootIndex(node), GetMdlRoomBaseName(node), 3000);
        if (biffResourceData == null) return mdlRoomCount;

        using var streamReader = new StreamReader(new MemoryStream(biffResourceData));
        streamReader.ReadLine();
        streamReader.ReadLine();
        streamReader.ReadLine();
        mdlRoomCount = Convert.ToInt32(streamReader.ReadLine()?.Replace(" ", string.Empty)
            .Replace("roomcount", string.Empty));


        return mdlRoomCount;
    }


    private int CurrentTreeRootIndex()
    {
        var lower1 = _lastClickedTvNode.FullPath.ToLower();
        var sLeft = lower1;
        if (StringType.StrCmp(sLeft, "kotor i", false) == 0)
            return 0;
        if (StringType.StrCmp(sLeft, "kotor ii", false) == 0)
            return 1;
        //var lower2 = lower1.Substring(0, lower1.IndexOf(TreeView.PathSeparator)).ToLower();
        /*f (StringType.StrCmp(lower2, "kotor i", false) == 0)
            return 0;
        var num = 0;
        return StringType.StrCmp(lower2, "kotor ii", false) == 0 ? 1 : num;*/
        return 0;
    }

    private KotorTreeNode CurrentTreeRoot()
    {
        return null;
        // return (KotorTreeNode)TreeView.Nodes[CurrentTreeRootIndex()];
    }

    private int NodeTreeRootIndex(KotorTreeNode node)
    {
        int num = 0;
        try
        {
            var lower1 = node.FullPath.ToLower();
            var sLeft = lower1;
            if (StringType.StrCmp(sLeft, "kotor i", false) == 0)
                num = 0;
            else if (StringType.StrCmp(sLeft, "kotor ii", false) == 0)
            {
                num = 1;
            }
            else
            {
                /*var lower2 = lower1.Substring(0, lower1.IndexOf(TreeView.PathSeparator)).ToLower();
                if (StringType.StrCmp(lower2, "kotor i", false) == 0)
                    num = 0;
                else if (StringType.StrCmp(lower2, "kotor ii", false) == 0)
                    num = 1;*/
            }
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            if (node == null)
            {
                num = -1;
                ProjectData.ClearProjectError();
            }
            else
            {
                num = node.KotorVerIndex;
                ProjectData.ClearProjectError();
            }
        }

        return num;
    }

    private KotorTreeNode NodeTreeRoot(KotorTreeNode node)
    {
        return null;
        // return (KotorTreeNode)TreeView.Nodes[NodeTreeRootIndex(node)];
    }


    private void SetAabbNode(ref Aabb node, Aabb[] aabbArray)
    {
        if (_gAbbbIndex > aabbArray.Length)
            return;
        if (node.Face == -1)
        {
            checked
            {
                ++_gAbbbIndex;
            }

            node.Left = _gAbbbIndex;
            SetAabbNode(ref aabbArray[_gAbbbIndex], aabbArray);
            checked
            {
                ++_gAbbbIndex;
            }

            node.Right = _gAbbbIndex;
            SetAabbNode(ref aabbArray[_gAbbbIndex], aabbArray);
        }
        else
        {
            node.Left = -1;
            node.Right = -1;
        }
    }

    public static string GetGffTag(byte[] data) => GetGffRootStringField(data, "Tag");

    public static string GetGffRootStringField(byte[] data, string FieldName)
    {
            
        var stringBuilder = new StringBuilder();
        var input = new MemoryStream(data);
        var binaryReader = new BinaryReader(input, Encoding.ASCII);
        input.Seek(8L, SeekOrigin.Begin);
        var num1 = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        var num2 = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        var num3 = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        var num4 = binaryReader.ReadInt32();
        input.Seek(checked(num1 + 8), SeekOrigin.Begin);
           
            
        var num5 = checked(binaryReader.ReadInt32() - 1);
        var num6 = 0;
        while (num6 <= num5)
        {
            input.Seek(checked(num2 + num6 * 12), SeekOrigin.Begin);
            if (binaryReader.ReadInt32() == 10)
            {
                var num7 = binaryReader.ReadInt32();
                var position = binaryReader.BaseStream.Position;
                input.Seek(checked(num3 + num7 * 16), SeekOrigin.Begin);
                stringBuilder.Length = 0;
                stringBuilder.Append(binaryReader.ReadChars(16));
                var index = 0;
                while (Strings.Asc(stringBuilder[index]) != 0)
                {
                    checked
                    {
                        ++index;
                    }

                    if (index > 15)
                        break;
                }

                stringBuilder.Length = index;
                if (StringType.StrCmp(stringBuilder.ToString().ToLower(), FieldName.ToLower(), false) == 0)
                {
                    input.Seek(position, SeekOrigin.Begin);
                    var num8 = binaryReader.ReadInt32();
                    input.Seek(checked(num4 + num8), SeekOrigin.Begin);
                    var count = binaryReader.ReadInt32();
                    var numArray = new byte[checked(count - 1 + 1)];
                    return Encoding.GetEncoding(1252).GetString(binaryReader.ReadBytes(count));
                }
            }

            checked
            {
                ++num6;
            }
        }

        string gffRootStringField = null;
        return gffRootStringField;
    }

    private void btnExtractForModuleEditing_Click(object sender, EventArgs e)
    {
        //cmiExtractForModuleEditing_Click(null, null);
    }

    private void CreateTemplateTagsHashFiles()
    {
        var hashtable = new Hashtable();
        var graph1 = new Hashtable();
        var graph2 = new Hashtable();
        var binaryFormatter = new BinaryFormatter();
        hashtable.Add(2040, 0);
        hashtable.Add(2027, 0);
        hashtable.Add(2042, 0);
        hashtable.Add(2025, 0);
        hashtable.Add(2051, 0);
        hashtable.Add(2044, 0);
        hashtable.Add(2035, 0);
        hashtable.Add(2032, 0);
        hashtable.Add(2058, 0);
        if (_hasK1 && !File.Exists("K1TemplateTags.bfd"))
        {
            /*
            if (ObjectType.ObjTst(TreeView.Nodes[0].Nodes[0].Nodes[0].Tag, "dummy", false) == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                BuildTreeView((KotorTreeNode)TreeView.Nodes[0], true);
            }
            */

            try
            {
                foreach (KeyEntry keyEntry in _biffEntryListArray[0, 23])
                {
                    if (hashtable.ContainsKey(Convert.ToInt32(keyEntry.ResourceType)))
                    {
                        var gffTag = GetGffTag(K1TemplatesBif()
                            .GetBiffResource(checked(keyEntry.ResId - keyEntry.ResId >> 20 << 20)).Data);
                        graph1.Add(keyEntry.ResRef + "." + ResourceIdentification.FindResourceTypeForId(keyEntry.ResourceType), gffTag);
                        if (StringType.StrCmp(gffTag, "", false) == 0)
                            Console.WriteLine("-----------------------------");
                    }
                }
            }
            finally
            {
            }

            var serializationStream = (Stream)File.Create("K1TemplateTags.bfd");
            binaryFormatter.Serialize(serializationStream, graph1);
            serializationStream.Close();
        }

        if (!_hasK2 || File.Exists("K2TemplateTags.bfd"))
            return;
        /*if (ObjectType.ObjTst(TreeView.Nodes[1].Nodes[0].Nodes[0].Tag, "dummy", false) == 0)
        {
            Cursor.Current = Cursors.WaitCursor;
            BuildTreeView((KotorTreeNode)TreeView.Nodes[1], true);
        }*/

        try
        {
            foreach (KeyEntry keyEntry in _biffEntryListArray[1, 2])
            {
                if (hashtable.ContainsKey(Convert.ToInt32(keyEntry.ResourceType)))
                {
                    var gffTag = GetGffTag(K2TemplatesBif()
                        .GetBiffResource(checked(keyEntry.ResId - keyEntry.ResId >> 20 << 20)).Data);
                    graph2.Add(keyEntry.ResRef + "." + ResourceIdentification.FindResourceTypeForId(keyEntry.ResourceType), gffTag);
                    if (StringType.StrCmp(gffTag, "", false) == 0)
                        Console.WriteLine("-----------------------------");
                }
            }
        }
        finally
        {
        }

        var serializationStream1 = (Stream)File.Create("K2TemplateTags.bfd");
        binaryFormatter.Serialize(serializationStream1, graph2);
        serializationStream1.Close();
    }

    private void ExtractNwScripts()
    {
        if (_hasK1 && !Directory.Exists(Path.Combine(CurrentSettings.KotorLocation(0), "override")))
            Directory.CreateDirectory(Path.Combine(CurrentSettings.KotorLocation(0), "override"));
        if (_hasK2 && !Directory.Exists(Path.Combine(CurrentSettings.KotorLocation(1), "override")))
            Directory.CreateDirectory(Path.Combine(CurrentSettings.KotorLocation(1), "override"));
        var str = Path.Combine(CurrentSettings.KotorLocation(0), "override\\nwscript.nss");
        var outputPath = Path.Combine(CurrentSettings.KotorLocation(1), "override\\nwscript.nss");
        if (_hasK1 && !File.Exists(str))
            ExportBiffResource(Path.Combine(CurrentSettings.KotorLocation(0), "data\\scripts.bif"), str, 3533);
        if (!_hasK2 || File.Exists(str))
            return;
        ExportBiffResource(Path.Combine(CurrentSettings.KotorLocation(1), "data\\scripts.bif"), outputPath, 1245);
    }

    private void ReadTreeBFD_Click(object sender, EventArgs e)
    {
        var version = Assembly
            .LoadFrom(
                "G:\\My Documents\\Visual Studio Projects\\kotor_tool\\MapInfo Generator\\bin\\MapInfo Generator.exe")
            .GetName().Version;
        Console.WriteLine(StringType.FromInteger(version.Major) + "." + StringType.FromInteger(version.Minor) +
                          "." + StringType.FromInteger(version.Build) + "." +
                          StringType.FromInteger(version.Revision));
    }

    public static KtSoundInfo GetKotorSoundInfo(object filepath)
    {
        var input = (Stream)File.Open(StringType.FromObject(filepath), FileMode.Open);
        var binaryReader = new BinaryReader(input);
        var sLeft1 = new string(binaryReader.ReadChars(4));
        while (StringType.StrCmp(sLeft1, "RIFF", false) != 0)
            sLeft1 = new string(binaryReader.ReadChars(4));
        var num1 = checked((int)(binaryReader.BaseStream.Position - 4L));
        binaryReader.ReadBytes(8);
        string sLeft2;
        int num2;
        for (sLeft2 = new string(binaryReader.ReadChars(4));
             StringType.StrCmp(sLeft2, "data", false) != 0;
             sLeft2 = new string(binaryReader.ReadChars(4)))
        {
            var sLeft3 = sLeft2;
            if (StringType.StrCmp(sLeft3, "fmt ", false) == 0)
            {
                var num3 = binaryReader.ReadInt32();
                var num4 = (int)binaryReader.ReadInt16();
                var num5 = (int)binaryReader.ReadInt16();
                num2 = binaryReader.ReadInt32();
                binaryReader.ReadInt32();
                var num6 = (int)binaryReader.ReadInt16();
                var num7 = (int)binaryReader.ReadInt16();
                if (num3 > 16)
                    binaryReader.ReadBytes(checked(num3 - 16));
            }
            else if (StringType.StrCmp(sLeft3, "fact", false) == 0)
            {
                var count = binaryReader.ReadInt32();
                binaryReader.ReadBytes(count);
            }
        }

        int num8 = 0;
        int num9 = 0;
        string str = null;
        if (StringType.StrCmp(sLeft2, "data", false) == 0)
        {
            if (binaryReader.ReadInt32() == 0)
            {
                num8 = checked((int)binaryReader.BaseStream.Position);
                num9 = checked((int)(binaryReader.BaseStream.Length - num8));
                binaryReader.ReadBytes(1);
                var num10 = binaryReader.ReadByte();
                var num11 = binaryReader.ReadByte();
                var num12 = (num10 & 24) >> 3;
                var num13 = (num10 & 6) >> 1;
                var num14 = (num11 & 240) >> 4;
                num2 = (num11 & 12) >> 2;
                str = "MPEG " + StringType.FromInteger(num12) + "-" + StringType.FromInteger(num13);
            }
            else
            {
                num8 = num1;
                num9 = checked((int)(binaryReader.BaseStream.Length - num8));
                str = "WAVE";
            }
        }

        input.Close();
        return new KtSoundInfo()
        {
            DataOffset = num8,
            DataSize = num9,
            Format = str
        };
    }

    private void Read_NWScript_Click(object sender, EventArgs e)
    {
        var fileStream =
            new FileStream(
                "C:\\SharpDevelop_1.1.0.2081\\src\\Libraries\\ICSharpCode.TextEditor\\src\\ICSharpCode.TextEditor.prjx",
                FileMode.Open);
        var text = File.CreateText("c:\\TextEditor.csproj");
        var streamReader = new StreamReader(fileStream);
        var num = 1;
        do
        {
            var str1 = streamReader.ReadLine();
            if (str1.ToLower().IndexOf("<file") > -1 && str1.IndexOf("Exclude") == -1)
            {
                var str2 = str1.Replace("name=", "RelPath =").Replace(".\\", "");
                text.WriteLine(str2);
            }

            checked
            {
                ++num;
            }
        } while (num <= 647);

        streamReader.Close();
        text.Close();
    }

    private delegate void CheckForUpdate();

    private delegate void DownloadUpdate(
        string url,
        string filePath,
        string signature,
        string onlineVersion);

    public struct Aabb
    {
        public int Left;
        public int Right;
        public int Face;
    }
}