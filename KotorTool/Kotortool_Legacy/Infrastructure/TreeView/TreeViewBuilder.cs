using Kotortool_Legacy.Application.Implementations;
using Kotortool_Legacy.Infrastructure.View.MainForm;

namespace Kotortool_Legacy.Infrastructure.TreeView;

public sealed class TreeViewBuilder : AppComponent
{

    private WeakReference<MainForm> _mainForm;
    private MainForm MainForm => _mainForm.TryGetTarget(out var mainForm) ? mainForm : null;
    private System.Windows.Forms.TreeView TreeView => MainForm?.TreeView;

    
    public TreeViewBuilder(AutofacInternalFactory serviceFactory) : base(serviceFactory) { }

    public void CreateFromView(MainForm mainForm)
    {
        _mainForm = new WeakReference<MainForm>(mainForm);
    }

    public void BeginInitialization()
    {
        //SetupTreeRoots();
                                                                                                        
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

        // TODO: Fix this
        /*CreateTemplateTagsHashFiles();
        ExtractNwScripts();*/

        /*if (_cmdArgs != null)
            _gCmdLineOpenedForm = OpenFileFromCmdLine();*/

        //ManageMruMainFileMenu();
        /*if (CurrentSettings.bRememberLastTreeNode && CurrentSettings.LastClickedTVNodePath != null &&
            StringType.StrCmp(CurrentSettings.LastClickedTVNodePath, "", false) != 0)
            OpenTreeViewToPath(CurrentSettings.LastClickedTVNodePath, TreeView.Nodes[0], 0);*/
        /*if (CurrentSettings.bRememberTreeViewState)
        {
            try
            {
                /*foreach (var treeOpenPath in CurrentSettings.TreeOpenPaths)
                    OpenTreeViewToPath(StringType.FromObject(treeOpenPath), TreeView.Nodes[0], 0);#1#
            }
            finally
            {
            }
        }*/
        

        // Make this an api call
       // UserSettings.SaveSettings(CurrentSettings);
    }
    
    /*private void SetupRootChildren(KotorTreeNode Root)
    {
        var node1 = new KotorTreeNode("BIFs")
        {
            Tag = "BIFF_Root",
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\data"
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
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\Modules"
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
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\texturePacks"
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
            FilePath = CurrentSettings.KotorLocation(TreeView.Nodes.IndexOf(Root)) + "\\Saves"
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
       
        var filePath = Root.FilePath;
        var index1 = NodeTreeRootIndex(Root);
        var fileStream = new FileStream(CurrentSettings.KeyFileLocation(index1), FileMode.Open, FileAccess.Read,
            FileShare.ReadWrite, 600000);
        var binaryReader = new BinaryReader(fileStream);
        childForm.Message = "Preparing Resource List";
        childForm.Status = "Reading key file";
        
        
        Root.Nodes[0].Nodes.Clear();
        TreeView.BeginUpdate();
        var now = DateAndTime.Now;
        fileStream.Seek(8L, SeekOrigin.Begin);
        
        //TODO : add this to build tree view xommand
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
            _biffEntries[index1].Add(new BIFFEntry(index2, fileStream, checked(num2 + 12 * index2)));
            _biffEntryListArray[index1, index2] = new ArrayList();
            checked
            {
                ++index2;
            }
        }

        try
        {
            foreach (BIFFEntry biffEntry in _biffEntries[index1])
            {
                var node = new KotorTreeNode(Strings.Mid(biffEntry.filename,
                    checked(biffEntry.filename.LastIndexOf("\\") + 2)))
                {
                    Tag = "BIFF",
                    Filename = Strings.Mid(biffEntry.filename, checked(biffEntry.filename.LastIndexOf("\\") + 2)),
                    FilePath = filePath + "\\" +
                               Strings.Mid(biffEntry.filename, 1, biffEntry.filename.LastIndexOf("\\")),
                    ContainingFileType = "BIF"
                };
                Root.Nodes[0].Nodes.Add(node);
                Console.WriteLine("Bif name: " + biffEntry.filename + "  Length: " +
                                  StringType.FromInteger(biffEntry.filelength));
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
            childForm.Status = "Building tree for " + ((BIFFEntry)_biffEntries[index1][index4]).filename;
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
                        FilePath = filePath + "\\" + ((BIFFEntry)_biffEntries[index1][index4]).filename
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

        TreeView.EndUpdate();
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

 
    
    private TreeViewPresenter SetupTreeRoots()
    {
        // Add node per game
        _logger.LogTrace("Setting Up Tree Roots");
        var node1 = new KotorTreeNode("Kotor I")
        {
            Tag = "Kotor1",
            FilePath = MainForm.Project.FilePath
        };

        TreeView.Nodes.Add(node1);

        /*
        var node2 = new KotorTreeNode("Kotor II")
        {
            Tag = "Kotor2",
            FilePath = CurrentSettings.defaultKotORLocation2
        };
        #1#

        //TreeView.Nodes.Add(node2);
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

    // TODO : Move to Presenter
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
    }*/

    
    
}