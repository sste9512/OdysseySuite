using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Kotortool_Legacy.API;
using Kotortool_Legacy.Application.Interfaces;
using Kotortool_Legacy.Infrastructure.TreeView;
using Kotortool_Legacy.Infrastructure.TreeView.CQRS.Commands;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Kotortool_Legacy.Infrastructure.View.MainForm;

public partial class MainForm : AppForm
{
    private readonly TreeViewBuilder _treeViewBuilder;
    public Project Project { get; set; }

    // can go into app settings
    public static string GRootPath;

    //public static frmImageViewer GImageViewer;

    public static ChitinKey GK1ChitinKey;
    public static ChitinKey GK2ChitinKey;

    public static BIFFArchive GK1TemplatesBif;
    public static BIFFArchive GK2TemplatesBif;

    public static Form Mainform;

    private ArrayList[,] _biffEntryListArray;
    private ArrayList[] _biffEntries;

    // Tree State
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

    public MainFormState MainFormState { get; set; }

    public MainForm()
    {
        InitializeComponent();
        Load += Form1_Load;
    }


    // TODO : Move to new Form
    private async void Form1_Load(object sender, EventArgs e)
    {
        var mainForm = (MainForm)sender;


        await Send(new BuildTreeViewFromProjectCommand { Project = Project, MainFormInstance = this });
        //Mainform = this;
        // GRootPath = "Thomas A. Luetz II";
        /*var registryKey = Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool");
        if (registryKey == null)
        {
            Interaction.MsgBox(
                "Kotor Tool cannot find its key in the registry at HKLM\\software\\SCM\\Kotor Tool.\n\nPlease reinstall Kotor Tool.",
                MsgBoxStyle.Critical);
            Environment.Exit(0);
        }*/

        /*GRootPath = StringType.FromObject(registryKey.GetValue("path"));
        if (!GRootPath.EndsWith("\\"))
            GRootPath += "\\";*/
        //TreeView.HideSelection = false;
        //Text = "Kotor Tool v" + Application.ProductVersion + "";

        /*_hasK1 = HasKotor1();
        _hasK2 = HasKotor2();
        CurrentSettings = UserSettings.GetSettings();


        if (!_hasK1 & !_hasK2)
        {
            Interaction.MsgBox(
                "No installation of Kotor I or II was detected.\n\nMost features will not work.",
                MsgBoxStyle.Critical, "No games detected");
        }

        if (StringType.StrCmp(CurrentSettings.defaultKotORLocation, "", false) == 0 & _hasK1 |
            StringType.StrCmp(CurrentSettings.defaultKotORLocation2, "", false) == 0 & _hasK2)
        {
            var frmPathManager = new frmPathManager();

            Interaction.MsgBox(
                "We've attempted to detect your KotOR installation,\rbut please verify the directories are correct.",
                MsgBoxStyle.Information, "First run configuration");

            if (StringType.StrCmp(CurrentSettings.defaultKotORLocation, string.Empty, false) == 0 & _hasK1)
                frmPathManager.btnAutoDetectKotor1_Click(null, null);
            if (StringType.StrCmp(CurrentSettings.defaultKotORLocation2, string.Empty, false) == 0 & _hasK2)
            {
                frmPathManager.btnAutoDetectKotor2_Click(null, null);
            }

            frmPathManager.StartPosition = FormStartPosition.CenterScreen;
            frmPathManager.ShowDialog(this);

            CurrentSettings = UserSettings.GetSettings();
            CurrentSettings.bBuildModelsBifNode = true;
        }

        if (_hasK1)
        {
            GK1ChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(0));
            Console.WriteLine("gK1ChitinKey: Lsum = " + StringType.FromLong(GK1ChitinKey.Lsum) + ", Llength = " +
                              StringType.FromLong(GK1ChitinKey.Llength));
            if (!GK1ChitinKey.IsValid(0))
            {
                Interaction.MsgBox(
                    "Your Kotor I chitin.key file appears to be corrupt.\nYou may want to reinstall KotOR II to fix this.",
                    MsgBoxStyle.Information, "Chitin.key file not valid");
            }

            if (GK1ChitinKey.BiffList.Length != 26)
            {
                Interaction.MsgBox(
                    "Your Kotor I chitin.key file appears to have been altered from the official version.\n\nIf you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.",
                    MsgBoxStyle.Critical, "Chitin.key file altered");
            }
        }

        if (_hasK2)
        {
            GK2ChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(1));
            Console.WriteLine("gK2ChitinKey: Lsum = " + StringType.FromLong(GK2ChitinKey.Lsum) + ", Llength = " +
                              StringType.FromLong(GK2ChitinKey.Llength));
            if (!GK2ChitinKey.IsValid(1))
            {
                Interaction.MsgBox(
                    "Your Kotor II chitin.key file appears to be corrupt or is a non-US version.",
                    MsgBoxStyle.Information, "Chitin.key file not valid");
            }

            if (GK2ChitinKey.BiffList.Length != 11)
            {
                Interaction.MsgBox(
                    "Your Kotor II chitin.key file appears to have been altered from the official version.\n\nIf you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.",
                    MsgBoxStyle.Critical, "Chitin.key file altered");
            }
        }*/

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

        /*if (CurrentSettings.bCheckForUpdatesAtStartup)
        {
            // _gCheckForUpdatesSilently = true;
            //var checkForUpdate = new CheckForUpdate(CheckForUpdateA);
            Console.WriteLine("Starting CheckForUpdate thread");
            checkForUpdate.BeginInvoke(null, null);
        }*/

        //UserSettings.SaveSettings(CurrentSettings);
    }

    // TODO : Move to new Form
    private void frmMain_Closing(object sender, CancelEventArgs e)
    {
        //SaveSettings();
    }

// TODO : Move to new Form
    private void frmMain_Move(object sender, EventArgs e)
    {
        /*if (CurrentSettings == null || !CurrentSettings.bDockImageViewer || GImageViewer == null ||
            !GImageViewer.Visible)
            return;
        ((Control)GImageViewer).Location = new Point(checked(((Control)this).Location.X + Size.Width),
            ((Control)this).Location.Y);*/
    }

// TODO : Move to new Form
    private void frmMain_Activated(object sender, EventArgs e)
    {
        if (!(_cmdArgs != null & _gCmdLineOpenedForm != null))
            return;
        _gCmdLineOpenedForm.BringToFront();
        _gCmdLineOpenedForm = null;
    }

    private void miManagePaths_Click(object sender, EventArgs e)
    {
        //new frmPathManager().ShowDialog(this);
    }

    private void miOpenGFFFile_Click(object sender, EventArgs e)
    {
        var objectValue = RuntimeHelpers.GetObjectValue(GetFilePath("load", CurrentSettings.defaultImportLocation,
            string.Empty, "Open GFF files...", "gffsupported", true));

        if (objectValue.GetType() == typeof(string))
        {
            return;
        }

        var strArray = (string[])objectValue;
        var num = checked(strArray.Length - 1);
        var index = 0;
        while (index <= num)
        {
            OpenGffFileInEditor(strArray[index], checked(index * 20));
            checked
            {
                ++index;
            }
        }
    }

    private void SetupRootChildren(KotorTreeNode Root)
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


    private void miViewGFFFile_Click(object sender, EventArgs e)
    {
        var objectValue = RuntimeHelpers.GetObjectValue(GetFilePath("load", CurrentSettings.defaultImportLocation,
            string.Empty, "Open GFF files...", string.Empty, true));

        if (objectValue.GetType() == typeof(string))
        {
            return;
        }

        var strArray = (string[])objectValue;
        var num = checked(strArray.Length - 1);
        var index = 0;
        while (index <= num)
        {
            var kotorVersionIndex = GetGffFileKotorVersionIndex(strArray[index]);
            var fs = new FileStream(strArray[index], FileMode.Open, FileAccess.Read);
            var clsGff = new ClsGff(kotorVersionIndex)
            {
                RtfMode = false
            };
            clsGff.Parse(fs);
            /*var frmTextEditor = new frmTextEditor();
            frmTextEditor.Filename = Path.GetFileName(strArray[index]);
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
            frmTextEditor.RTFMode = true;
            frmTextEditor.tbGeneric.Text = clsGff.ToString();
            frmTextEditor.tbGeneric.SelectionLength = 0;
            frmTextEditor.Show();
            ((Control)frmTextEditor).Location = new Point(checked(((Control)frmTextEditor).Location.X + index * 20),
                checked(((Control)frmTextEditor).Location.Y + index * 20));*/
            checked
            {
                ++index;
            }
        }
    }

    private void miRecentFiles_Click(object sender, EventArgs e)
    {
        /*var filepath = StringType.FromObject(CurrentSettings.MRUMainFiles[((ToolStripMenuItem)sender).Index]);
        Console.WriteLine(filepath);*/
        //OpenGffFileInEditor(filepath);
    }

    private void miQuit_Click(object sender, EventArgs e)
    {
        //SaveSettings();
        //Application.Exit();
    }

    private void miOpenMapsFolder_Click(object sender, EventArgs e) => new Process()
    {
        StartInfo =
        {
            FileName = "explorer.exe ",
            Arguments = (GRootPath + "maps")
        }
    }.Start();

    private void miOpenModuleEditor_Click(object sender, EventArgs e)
    {
        //new frmModule_Editor().Show();
    } 

    private void miShowSupportedModEditorMaps_Click(object sender, EventArgs e)
    {
        //new frmMapInfoStatus().ShowDialog();
    }

    private void miOpenSSFEditor_Click(object sender, EventArgs e)
    {
        //new frmSSFEditor().Show();
    } 

    private void miOpenProjectManager_Click(object sender, EventArgs e)
    {
    } // new frmProjectManager(this).Show();

    private void miOpen2DAFile_Click(object sender, EventArgs e) => Open2DaFileEditor();

    private void miConversationEditor_Click(object sender, EventArgs e) => OpenConversationEditor();

    private void miGlobalVariableEditor_Click(object sender, EventArgs e)
    {
        /*var childForm = new frmGlobalVar_Editor();
        new utilWindowRelativePositioner(Mainform, childForm).SetLocationConcentric();
        childForm.Show();*/
    }

    private void miOpenTextEditor_Click(object sender, EventArgs e) => OpenTextEditor();

    private void miOpenERFBuilder_Click(object sender, EventArgs e) => OpenErfBuilder();

    private void miOpenPWKEditor_Click(object sender, EventArgs e)
    {
       // new frmBWMEditor().Show();
    }

    private void miOpenDialogTlkViewer_Click(object sender, EventArgs e)
    {
        //new frmDialogTlk().Show();
    }

    private void miRefSearch_Click(object sender, EventArgs e)
    {
    } // PerformStringSearch();

    private void miCleanWorkingDir_Click(object sender, EventArgs e)
    {
        if (Interaction.MsgBox("Are you sure you want to delete all of the files in your working directory?",
                MsgBoxStyle.OkCancel | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2,
                "Clean working directory") != MsgBoxResult.Ok)
            return;
        CleanDirectory(GRootPath + "working");
    }

    private void miOpenWorkingDir_Click(object sender, EventArgs e) => new Process()
    {
        StartInfo =
        {
            FileName = "explorer.exe ",
            Arguments = (GRootPath + "working")
        }
    }.Start();

    private void miOptions_Click(object sender, EventArgs e)
    {
        /*var frmOptions = new frmOptions();
        CurrentSettings = UserSettings.GetSettings();
        var buildModelsBifNode = CurrentSettings.bBuildModelsBifNode;
        var moduleDescriptions = CurrentSettings.bShowModuleDescriptions;
        var showModuleLocations = CurrentSettings.bShowModuleLocations;
        var num1 = (int)frmOptions.ShowDialog(this);
        CurrentSettings = UserSettings.GetSettings();
        if (!buildModelsBifNode & CurrentSettings.bBuildModelsBifNode != buildModelsBifNode)
        {
            TreeView.Nodes.Clear();
            SetupTreeRoots();
            var num2 = (int)MessageBox.Show("Models node added; Treeview rebuilt", "Notice", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        var index = 0;
        do
        {
            if (TreeView.Nodes[index].Nodes.Count > 0 &&
                ObjectType.ObjTst(TreeView.Nodes[index].Nodes[1].Nodes[0].Nodes[0].Tag, "dummy", false) != 0 &&
                CurrentSettings.bShowModuleDescriptions != moduleDescriptions |
                CurrentSettings.bShowModuleLocations != showModuleLocations)
            {
                var isExpanded = TreeView.Nodes[index].Nodes[1].Nodes[0].IsExpanded;
                TreeView.Nodes[index].Nodes[1].Nodes[0].Collapse();
                TreeView.Nodes[index].Nodes[1].Nodes[0].Nodes.Clear();
                var node = new KotorTreeNode
                {
                    Tag = "dummy"
                };
                TreeView.Nodes[index].Nodes[1].Nodes[0].Nodes.Add(node);
                if (isExpanded)
                    TreeView.Nodes[index].Nodes[1].Nodes[0].Expand();
            }

            checked
            {
                ++index;
            }
        } while (index <= 1);*/
    }

    // Move to Extensions
    private void SetupTreeRoots()
    {
        //_logger.LogTrace("Setting Up Tree Roots");
        var node1 = new KotorTreeNode("Kotor I")
        {
            Tag = "Kotor1",
            FilePath = CurrentSettings.defaultKotORLocation
        };

        TreeView.Nodes.Add(node1);

        var node2 = new KotorTreeNode("Kotor II")
        {
            Tag = "Kotor2",
            FilePath = CurrentSettings.defaultKotORLocation2
        };

        TreeView.Nodes.Add(node2);
    }

    private void miBasicHelp_Click(object sender, EventArgs e)
    {
        try
        {
            Process.Start(GRootPath + "KT_Help.chm");
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);

            if (StringType.StrCmp(ex.Message, "", false) != 0)
            {
                var num = (int)Interaction.MsgBox(
                    "                      Error launching Help File\r\rIs it installed in the same directory as this program?");
            }

            ProjectData.ClearProjectError();
        }
    }

    private void miCheckForUpdates_Click(object sender, EventArgs e)
    {
        /*_gCheckForUpdatesSilently = false;
        var checkForUpdate = new CheckForUpdate(CheckForUpdateA);
        Console.WriteLine("Starting CheckForUpdate thread");
        checkForUpdate.BeginInvoke(null, null);*/
    }

    private void miAbout_Click(object sender, EventArgs e)
    {
        /*var frmAbout = new frmAbout();
        //frmAbout.lblVersion.Text = "Version " + Application.ProductVersion;
        var num = (int)frmAbout.ShowDialog(this);*/
    }

    private void cmiExtractForModuleEditing_Click(object sender, EventArgs e)
    {
        /*var mapInfo = frmMapInfoStatus.ReadMapInfoFile();
        var lower = Path.GetFileNameWithoutExtension(((KotorTreeNode)TreeView.SelectedNode).Filename).ToLower();
        var sLeft1 = "Unsupported";
        var sLeft2 = "Unsupported";
        string str1 = null;
        if (mapInfo != null)
        {
            var str2 = Path.Combine(
                StringType.FromObject(
                    Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool").GetValue("path")), "maps\\");
            try
            {
                foreach (MapInfo.Map map in mapInfo.MapList)
                {
                    if (StringType.StrCmp(lower, map.MapName, false) == 0)
                    {
                        if (map.S)
                            sLeft1 = !File.Exists(str2 + "map" + map.MapName + ".map") ? "Missing" : "Available";
                        if (map.L)
                            sLeft2 = !File.Exists(str2 + "map" + map.MapName + "_lg.map") ? "Missing" : "Available";
                    }
                }
            }
            finally
            {
            }

            if (StringType.StrCmp(sLeft1, "Unsupported", false) == 0 &&
                StringType.StrCmp(sLeft2, "Unsupported", false) == 0)
                str1 = "A map is not yet supported for this module.\n\nDo you want to proceed with the extraction?";
            else if (StringType.StrCmp(sLeft1, "Unsupported", false) == 0 &&
                     StringType.StrCmp(sLeft2, "Missing", false) == 0 ||
                     StringType.StrCmp(sLeft1, "Missing", false) == 0 &&
                     StringType.StrCmp(sLeft2, "Unsupported", false) == 0)
                str1 =
                    "At least one map size is supported for this module, but none was found in your Kotor Tool 'maps' folder.\n\nDo you want to proceed with the extraction?";
        }

        if (StringType.StrCmp(str1, "", false) != 0 &&
            Interaction.MsgBox(str1, MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Map support") == MsgBoxResult.No)
            return;
        var nextNode = (KotorTreeNode)TreeView.SelectedNode.NextNode;
        var resourceTypeSelector = new frmResourceTypeSelector();
        if (resourceTypeSelector.ShowDialog(this) == DialogResult.Cancel)
            return;
        var str3 = StringType.FromObject(GetFilePath("", CurrentSettings.ModuleExtractPath, "",
            "Select or create the folder to extract the module to...", "", updateSavePath: false));
        if (str3 == null || StringType.StrCmp(str3, "", false) == 0)
            return;
        if (!str3.EndsWith("\\"))
            str3 += "\\";
        ExtractSelectedKotorFile((KotorTreeNode)TreeView.SelectedNode, str3,
            ResTypes: resourceTypeSelector.SelectedResTypes);
        if (StringType.StrCmp(CurrentSettings.ModuleExtractPath, str3, false) != 0)
        {
            CurrentSettings.ModuleExtractPath = str3;
            UserSettings.SaveSettings(CurrentSettings);
        }

        ExtractSelectedKotorFile(nextNode, str3, ResTypes: resourceTypeSelector.SelectedResTypes);
        var files = Directory.GetFiles(str3, "*.git");
        string str4 = null;
        if (files.Length > 0)
            str4 = files[0];
        if (StringType.StrCmp(str4, "", false) != 0)
        {
            var clsGff = new ClsGff(new FileStream(str4, FileMode.Open), NodeTreeRootIndex(nextNode));
            if (Interaction.MsgBox("Would you like the .GIT file cleaned of all non-extracted entities?",
                    MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
            {
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("utc")))
                    clsGff.ClearListElements("Creature List");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("utd")))
                    clsGff.ClearListElements("Door List");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("ute")))
                    clsGff.ClearListElements("Encounter List");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("uti")))
                    clsGff.ClearListElements("Item List");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("utm")))
                    clsGff.ClearListElements("StoreList");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("utp")))
                    clsGff.ClearListElements("Placeable List");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("uts")))
                    clsGff.ClearListElements("SoundList");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("utt")))
                    clsGff.ClearListElements("TriggerList");
                if (!resourceTypeSelector.SelectedResTypes.Contains(Identification.GetIdForRsrcType("utw")))
                    clsGff.ClearListElements("WaypointList");
            }

            clsGff.WriteFile(str4, "GIT");
        }

        if (Interaction.MsgBox(
                "Extraction complete.\nWould you like the Module Editor to be set to open your extract location the next time you use it?",
                MsgBoxStyle.YesNo) != MsgBoxResult.Yes)
            return;
        CurrentSettings = UserSettings.GetSettings();
        CurrentSettings.LastModuleEditedPath = str3;
        UserSettings.SaveSettings(CurrentSettings);*/
    }

    // Move this to extractek kotorTreeNode Extensions
    private object ExtractSelectedKotorFile(
        KotorTreeNode node,
        string outputpath = "",
        string SaveMsg = "",
        Hashtable ResTypes = null)
    {
        var tag = node.Tag;
        //_logger.LogTrace("Extracting Node With Tag: {tag}", tag);
        if (ObjectType.ObjTst(tag, "RIM", false) == 0)
        {
            if (StringType.StrCmp(SaveMsg, "", false) == 0)
            {
                SaveMsg = "Select Folder to extract RIM to...";
            }

            if (StringType.StrCmp(outputpath, string.Empty, false) == 0)
            {
                outputpath =
                    StringType.FromObject(ObjectType.StrCatObj(
                        GetFilePath(string.Empty, CurrentSettings.defaultSaveLocation, string.Empty, SaveMsg,
                            string.Empty),
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
            outputpath = StringType
                .FromObject(GetFilePath("save", CurrentSettings.defaultSaveLocation, node.Filename,
                    "Save " + node.Filename + " file...", node.ResTypeStr));

            if (StringType.StrCmp(outputpath, "", false) != 0)
            {
                // var rimResource = GetRimResource(node.FilePath, node);
                // WriteByteArray(outputpath, rimResource);
            }
            else
                goto label_78;
        }
        else if (ObjectType.ObjTst(tag, "BIFF", false) == 0)
        {
            if (StringType.StrCmp(outputpath, string.Empty, false) == 0)
                outputpath = StringType.FromObject(ObjectType.StrCatObj(
                    GetFilePath(string.Empty, CurrentSettings.defaultSaveLocation, "",
                        "Select Folder to extract BIF to...",
                        string.Empty), "\\"));


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
                            /*ExportBiffResource(node.FilePath + "\\" + node.Filename,
                                outputpath + ((KotorTreeNode)node1.Nodes[index]).ResRef + "." +
                                ((KotorTreeNode)node1.Nodes[index]).ResTypeStr,
                                ((KotorTreeNode)node1.Nodes[index]).LocalResID);*/
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

            if (StringType.StrCmp(outputpath, string.Empty, false) != 0)
            {
                //ExportBiffResource(node.FilePath, outputpath, node.LocalResID);
            }

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
                // var childForm = new FrmProgressMeter();
                // childForm.StepAmount = 1;
                // childForm.Maxvalue = clsErf.EntryCount;
                // childForm.Message = "Extracting files from " + node.Filename;
                // ((Control)childForm).Location = new utilWindowRelativePositioner(this, childForm).GetConcentric();
                // childForm.Show();
                var num = checked(clsErf.EntryCount - 1);
                var index = 0;
                while (index <= num)
                {
                    var erfResource = clsErf.GetErfResource(index);
                    var keyEntry = (ERFKeyEntry)clsErf.KeyEntryList[index];
                    //childForm.Status = "Writing " + keyEntry._ResourceName + "." + keyEntry._ResTypeStr;
                    var fileStream =
                        new FileStream(outputpath + keyEntry._ResourceName + "." + keyEntry._ResTypeStr,
                            FileMode.Create);
                    fileStream.Write(erfResource, 0, erfResource.Length);
                    fileStream.Close();
                    //childForm.StepUp();
                    checked
                    {
                        ++index;
                    }
                }

                fs.Close();
                //childForm.Close();
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
                    /*var frmTpcFileSaveType = new frmTPCFileSaveType();
                    if (frmTpcFileSaveType.ShowDialog(this) != DialogResult.Cancel)
                        sLeft = frmTpcFileSaveType.saveType;
                    else
                        goto label_78;*/
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
                    /*var frmImageViewer = new frmImageViewer();
                    frmImageViewer.SetupTPCData(erfResource, "foo");
                    frmImageViewer.DecodeImage();
                    frmImageViewer.WriteTGAFile(outputpath);*/
                }
                else
                {
                    WriteByteArray(outputpath, erfResource);
                }
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
                {
                    SaveMsg = "Select Folder to extract entire subtype to...";
                }


                if (StringType.StrCmp(outputpath, "", false) == 0)
                {
                    outputpath = StringType.FromObject(ObjectType.StrCatObj(
                        GetFilePath("", CurrentSettings.defaultSaveLocation, "", SaveMsg, ""), "\\"));
                }


                if (StringType.StrCmp(outputpath, "\\", false) == 0)
                {
                    goto label_78;
                }
            }

            var sLeft = containingFileType;
            if (StringType.StrCmp(sLeft, "BIF", false) == 0)
            {
                var current = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    foreach (KotorTreeNode node2 in node.Nodes)
                    {
                        /*ExportBiffResource(parent.FilePath + "\\" + parent.Filename,
                            outputpath + node2.ResRef + "." + node2.ResTypeStr, node2.LocalResID);*/
                    }
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

    public static void WriteByteArray(string outputPath, byte[] byteArray)
    {
        using var binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create));
        binaryWriter.Write(byteArray);
    }

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
        {
            return string.Empty;
        }

        if (updateSavePath)
        {
            CurrentSettings = UserSettings.GetSettings();
            CurrentSettings.defaultSaveLocation = folderBrowserDialog.SelectedPath;
            UserSettings.SaveSettings(CurrentSettings);
        }

        return folderBrowserDialog.SelectedPath;
    }

    /*private void ToolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
        /*if (e.Button == Tbbtn2DaEditor)
            Open2DaFileEditor();
        else if (e.Button == TbbtnConversationEditor)
            OpenConversationEditor();
        else if (e.Button == TbbtnErfBuilder)
        {
            OpenErfBuilder();
        }
        else
        {
            if (e.Button != TbbtnTextEditor)
                return;
            OpenTextEditor();
        }#1#
    }*/

    private void Button6_Click(object sender, EventArgs e)
    {
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
        /*var frmImageViewer = new frmImageViewer();
        if (File.Exists(GRootPath + "tpc2tga.exe"))
        {
            Interaction.MsgBox(
                "tpc2tga is installed in the same directory as Kotor Tool, but is no longer needed",
                MsgBoxStyle.Critical, "TPC2TGA not needed");
        }

        if (!File.Exists(CurrentSettings.ImageViewerLocation))
        {
            Interaction.MsgBox(
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
                CaptureError(ex, new[] { "Error launching image viewer" });

                if (StringType.StrCmp(ex.Message, string.Empty, false) != 0)
                {
                    Interaction.MsgBox(
                        "Error launching image viewer\r\rIs it installed where you specified it to be?");
                }
            }
        }*/
    }

    private void OpenTgaInExternalViewer(string filename, byte[] data)
    {
        var imageViewerLocation = CurrentSettings.ImageViewerLocation;
        if (!File.Exists(imageViewerLocation))
        {
            Interaction.MsgBox(
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
                    Interaction.MsgBox(
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

        /*if (GImageViewer == null || !GImageViewer.Created)
        {
            GImageViewer = new frmImageViewer();
            ((Control)GImageViewer).Location = new Point(checked(((Control)this).Location.X + Size.Width),
                ((Control)this).Location.Y);
        }

        GImageViewer.SetupTPCData(data, node.Filename);
        GImageViewer.DecodeImage();
        GImageViewer.Show();*/
    }

    public BiffVarRsrcEntry GetBiffResource(string biffPath, int resourceId)
    {
        var fsin = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
        var biffResource = new BIFFArchive(fsin).GetBiffResource(resourceId);
        fsin.Close();
        return biffResource;
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

    private byte[] GetErfResource(string erfFilePath, KotorTreeNode ktn) =>
        new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(ktn.RiMorErFindex);


    private byte[] GetErfResource(string erfFilePath, string ResRef, int ResType) =>
        new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(ResRef, ResType);

    private void Open2DaFileEditor()
    {
        //new frm2DAEditor().Show();
    }

    private void OpenTextEditor()
    {
       // new frmTextEditor().Show();
    } 

    private void OpenErfBuilder()
    {
        //new frmERFManager().Show();
    }

    [Obsolete("this is extension method")]
    public void EnsureWorkingDirectoryExists()
    {
        if (Directory.Exists(GRootPath + "working"))
            return;
        Directory.CreateDirectory(GRootPath + "working");
    }

    // this is node function now
    public byte[] GetRimResource(int index)
    {
        /*RimKeyEntry keyEntry = (RimKeyEntry)KeyEntryList[index];
        byte[] destinationArray = new byte[checked(keyEntry._Length - 1 + 1)];
        Array.Copy(_data, keyEntry._Offset, destinationArray, 0, keyEntry._Length);
        return destinationArray;*/
        return Array.Empty<byte>();
    }

    public void HandleDataByNodeType(KotorTreeNode node, object sender)
    {
        var current = Cursor.Current;
        CurrentSettings = UserSettings.GetSettings();
        var tag = node.Tag;
        byte[] numArray1 = new byte[] { };
        if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0)
        {
            // numArray1 = GetRimResource(node.FilePath, node);
        }

        else if (ObjectType.ObjTst(tag, "BIFF_Res", false) == 0)
        {
            if (StringType.StrCmp(node.ResTypeStr, "mdl", false) != 0)
                numArray1 = GetBiffResource(node.FilePath, node.LocalResId).Data;
        }
        else if (ObjectType.ObjTst(tag, "ERF_Res", false) == 0)
        {
            numArray1 = GetErfResource(node.FilePath, node);
        }
        else
        {
            /*if (ObjectType.ObjTst(tag, "globalvar", false) != 0)
                return;
            new frmGlobalVar_Editor(
                new clsGlobalVars(ReadByteArray(node.FilePath + "\\" + node.Filename), NodeTreeRootIndex(node)),
                node.FilePath, NodeTreeRootIndex(node)).Show();*/
            return;
        }

        var resTypeStr = node.ResTypeStr;
        if (StringType.StrCmp(resTypeStr, "mdl", false) == 0)
        {
            if (CurrentSettings.ModelExportLocation == null ||
                !Directory.Exists(CurrentSettings.ModelExportLocation))
            {
                var num1 = (int)Interaction.MsgBox(
                    "The Model Export Location is not set.\n\nA default path has been set in the Path Manager; you may accept it or choose your own.",
                    MsgBoxStyle.Critical, "Path not set");
                /*var frmPathManager = new frmPathManager();
                if (!Directory.Exists(GRootPath + "working\\Exported Models"))
                    Directory.CreateDirectory(GRootPath + "working\\Exported Models");
                frmPathManager.tbModuleExportPath.Text = GRootPath + "working\\Exported Models";
                frmPathManager.StartPosition = FormStartPosition.CenterScreen;
                frmPathManager.TabControl1.SelectedIndex = 2;
                frmPathManager.tbModuleExportPath.BackColor = Color.MistyRose;
                var num2 = (int)frmPathManager.ShowDialog(this);
                CurrentSettings = UserSettings.GetSettings();*/
            }

            var mdlRoomCount = GetMdlRoomCount(node);
            /*var frmMdlOpsSwitches = new frmMdlOpsSwitches();
            frmMdlOpsSwitches.chkbExtractAnimations.Checked = CurrentSettings.bModelExtraction_ExtractAnimations;
            frmMdlOpsSwitches.chkbConvertSkin.Checked = CurrentSettings.bModelExtraction_ConvertSkinToTrimesh;
            frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked =
                CurrentSettings.bModelExtraction_EachModelInOwnDirectory;
            frmMdlOpsSwitches.chkbCleanWorkingDir.Checked =
                CurrentSettings.bModelExtraction_CleanWorkingDirectoryBeforeExport;
            frmMdlOpsSwitches.tbModelExtractionPath.Text = CurrentSettings.ModelExportLocation;
            if (frmMdlOpsSwitches.ShowDialog(this) != DialogResult.OK)
                return;
            while (frmMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith("\\"))
                frmMdlOpsSwitches.tbModelExtractionPath.Text =
                    frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0,
                        checked(frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1));
            if (StringType.StrCmp(
                    frmMdlOpsSwitches.tbModelExtractionPath.Text.Replace("\\" + GetMdlRoomBaseName(node), ""),
                    CurrentSettings.ModelExportLocation, false) != 0)
            {
                CurrentSettings.ModelExportLocation = frmMdlOpsSwitches.tbModelExtractionPath.Text;
                UserSettings.SaveSettings(CurrentSettings);
            }

            if (!Directory.Exists(frmMdlOpsSwitches.tbModelExtractionPath.Text))
                Directory.CreateDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text);
            var flag1 = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked;
            var flag2 = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked;
            var childForm = new FrmProgressMeter();*/
            /*childForm.StepAmount = 1;
            childForm.Maxvalue = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value);
            childForm.Message = "Extracting models";
            ((Control)childForm).Location = new utilWindowRelativePositioner(this, childForm).GetConcentric();
            childForm.Show();
            EnsureWorkingDirectoryExists();
            CurrentSettings.bModelExtraction_ExtractAnimations = frmMdlOpsSwitches.ExtractAnimations;
            CurrentSettings.bModelExtraction_ConvertSkinToTrimesh = frmMdlOpsSwitches.ConvertSkin;
            CurrentSettings.bModelExtraction_EachModelInOwnDirectory =
                frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked;
            CurrentSettings.bModelExtraction_CleanWorkingDirectoryBeforeExport =
                frmMdlOpsSwitches.chkbCleanWorkingDir.Checked;
            UserSettings.SaveSettings(CurrentSettings);
            if (flag2)
                CleanDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text);
            if (frmMdlOpsSwitches.chkbExportMdlAlignData.Checked | frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
            {
                string fileName = null;
                if (NodeTreeRootIndex(node) == 1)
                    fileName = node.ResRef.Substring(0, 6);
                var streamWriter = new StreamWriter(new FileStream("C:\\3dsmax7\\scripts\\NWmax\\plugins\\test.txt",
                    FileMode.Create));
                var streamReader =
                    new StreamReader(
                        new MemoryStream(GetBiffResourceData(NodeTreeRootIndex(node), fileName, 3000)));
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamWriter.WriteLine(mdlRoomCount);
                var num3 = mdlRoomCount;
                var num4 = 1;
                while (num4 <= num3)
                {
                    var strArray = streamReader.ReadLine().Trim().Split(' ');
                    var index = 1;
                    do
                    {
                        strArray[index] = (Convert.ToSingle(strArray[index]) * 100f).ToString();
                        checked
                        {
                            ++index;
                        }
                    } while (index <= 3);

                    streamWriter.WriteLine(frmMdlOpsSwitches.tbModelExtractionPath.Text + "\\" + strArray[0] +
                                           "-ascii.mdl," + strArray[0] + "," + strArray[1] + "," + strArray[2] +
                                           "," + strArray[3]);
                    checked
                    {
                        ++num4;
                    }
                }

                streamWriter.Close();
                streamReader.Close();
            }

            if (!frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
            {
                var int32 = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value);
                var num = 1;
                while (num <= int32)
                {
                    childForm.Status = "Getting data for " + node.ResRef;
                    var data = GetBiffResource(node.FilePath, node.LocalResId).Data;
                    var path = frmMdlOpsSwitches.tbModelExtractionPath.Text + "\\" + node.ResRef;
                    if (flag1)
                    {
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);
                        path = path + "\\" + node.ResRef;
                    }

                    WriteByteArray(path + ".mdl", data);
                    //ExportBiffResource(NodeTreeRootIndex(node), node.ResRef, 3008, path + ".mdx");
                    childForm.Status = "Exporting model " + node.ResRef;
                    var str1 = GRootPath + "mdlops.exe";
                    try
                    {
                        var process = new Process();
                        process.StartInfo.FileName = str1;
                        process.StartInfo.CreateNoWindow = true;
                        if (!frmMdlOpsSwitches.ExtractAnimations)
                            process.StartInfo.Arguments += "-a ";
                        if (frmMdlOpsSwitches.ConvertSkin)
                            process.StartInfo.Arguments += "-s ";
                        var startInfo = process.StartInfo;
                        startInfo.Arguments = startInfo.Arguments + "\"" + path + ".mdl" + "\"";
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.Start();
                        process.StandardOutput.ReadToEnd();
                        process.WaitForExit(15000);
                        childForm.Status = "Extracting textures for " + node.ResRef;
                        var fileStream = new FileStream(path + "-textures.txt", FileMode.Open);
                        var streamReader = new StreamReader(fileStream);
                        /*var frmImageViewer = new frmImageViewer();
                        for (var str2 = streamReader.ReadLine(); str2 != null; str2 = streamReader.ReadLine())
                        {
                            var str3 = str2.Trim();
                            if (str3.Length > 0 & StringType.StrCmp(str3, "null", false) != 0)
                            {
                                var erfResource =
                                    GetErfResource(
                                        CurrentSettings.KotorLocation(NodeTreeRootIndex(node)) +
                                        "\\TexturePacks\\swpc_tex_tpa.erf", str3, 3007);
                                frmImageViewer.SetupTPCData(erfResource, "foo");
                                frmImageViewer.DecodeImage();
                                frmImageViewer.WriteTGAFile(path.Substring(0, checked(path.LastIndexOf("\\") + 1)) +
                                                            str3 + ".tga");
                            }
                        }#1#

                        streamReader.Close();
                        fileStream.Close();
                        File.Delete(path + ".mdl");
                        File.Delete(path + ".mdx");
                        File.Delete(path + "-textures.txt");
                    }
                    catch (Exception ex)
                    {
                        CaptureError(ex, new[] { "Error extracting model " + node.ResRef });
                        //ProjectData.SetProjectError(ex);
                        if (StringType.StrCmp(ex.Message, "", false) == 0)
                            ;
                        ProjectData.ClearProjectError();
                    }

                    node = (KotorTreeNode)node.NextNode;
                    childForm.StepUp();
                    checked
                    {
                        ++num;
                    }
                }
            }

            childForm.Close();
            var num5 = (int)Interaction.MsgBox("Extraction Complete", MsgBoxStyle.Information, "Model Extraction");
        }
        else if (StringType.StrCmp(resTypeStr, "2da", false) == 0)
        {
            Cursor.Current = Cursors.WaitCursor;
            new frm2DAEditor(node.Filename, numArray1, NodeTreeRootIndex(node)).Show();
        }
        else if (StringType.StrCmp(resTypeStr, "pwk", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "dwk", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "wok", false) == 0)
            new frmBWMEditor(numArray1, node.Filename).Show();
        else if (StringType.StrCmp(resTypeStr, "nss", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "vis", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "txi", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "lyt", false) == 0)
        {
            /*var frmTextEditor = new frmTextEditor(node.Filename);
            var asciiEncoding = new ASCIIEncoding();
            frmTextEditor.tbGeneric.Text = asciiEncoding.GetString(numArray1);
            frmTextEditor.tbGeneric.SelectionLength = 0;
            frmTextEditor.KotorVersionIndex = NodeTreeRootIndex(node);
            if (StringType.StrCmp(node.ResTypeStr, "nss", false) == 0)
                frmTextEditor.PrepareForScriptEditing();
            frmTextEditor.Show();#1#
        }
        else if (StringType.StrCmp(resTypeStr, "ncs", false) == 0)
        {
            EnsureWorkingDirectoryExists();
            WriteByteArray(GRootPath + "working\\temp.ncs", numArray1);
            var str = GRootPath + "nwnnsscomp.exe";
            try
            {
                var process = new Process();
                process.StartInfo.FileName = str;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = "-d -o \"" + GRootPath + "working\\temp.nss" + "\"" + " " + "\"" +
                                              GRootPath + "working\\temp.ncs" + "\"";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit(4000);
                var fileStream = new FileStream(GRootPath + "working\\temp.nss", FileMode.Open);
                /*var frmTextEditor = new frmTextEditor(node.Filename);
                var asciiEncoding = new ASCIIEncoding();
                var numArray2 = new byte[checked((int)(fileStream.Length - 1L) + 1)];
                fileStream.Read(numArray2, 0, checked((int)fileStream.Length));
                frmTextEditor.tbGeneric.Text = asciiEncoding.GetString(numArray2);
                frmTextEditor.tbGeneric.SelectionLength = 0;
                fileStream.Close();
                frmTextEditor.Show();#1#
            }
            catch (Exception ex)
            {
                CaptureError(ex, new[] { "Error launching nwnnsscomp" });

                //ProjectData.SetProjectError(ex);

                if (StringType.StrCmp(ex.Message, "", false) != 0)
                {
                    Interaction.MsgBox(
                        "Error launching nwnnsscomp\r\rIs it installed in the same directory as this program?");
                }

                ProjectData.ClearProjectError();
            }
        }
        else if (StringType.StrCmp(resTypeStr, "are", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "fac", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "jrl", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "git", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "gui", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "ifo", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "itp", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "pth", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "ptm", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "ptt", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "res", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "ute", false) == 0)
        {
            Cursor.Current = Cursors.WaitCursor;
            if ((ModifierKeys & Keys.Shift) != 0)
            {
                var clsGff = new ClsGff(NodeTreeRootIndex(node))
                {
                    RtfMode = false
                };
                clsGff.Parse(numArray1);
                /*var frmTextEditor = new frmTextEditor();
                frmTextEditor.Filename = node.Filename;
                frmTextEditor.Text = "Text Editor - " + node.Filename;
                frmTextEditor.RTFMode = false;
                frmTextEditor.tbGeneric.Text = clsGff.ToString();
                frmTextEditor.tbGeneric.SelectionLength = 0;
                frmTextEditor.Show();#1#
            }
            /*else if ((ModifierKeys & Keys.Control | (Keys) -(CurrentSettings.bAlwaysUnknownGFFasText ? 1 : 0)) != 0)
            {
              var clsGff = new ClsGff(NodeTreeRootIndex(node))
              {
                RtfMode = true
              };
              clsGff.Parse(numArray1);
              var frmTextEditor = new frmTextEditor();
              frmTextEditor.Filename = node.Filename;
              frmTextEditor.Text = "Text Editor - " + node.Filename;
              frmTextEditor.RTFMode = true;
              frmTextEditor.tbGeneric.Rtf = clsGff.ToString();
              frmTextEditor.tbGeneric.SelectionLength = 0;
              frmTextEditor.Show();
            }#1#
            else
            {
                //EditGffResource(node.Filename, numArray1);
            }
        }
        else if (StringType.StrCmp(resTypeStr, "utc", false) == 0)
        {
            var frmUtcEditor = new frmUTC_Editor(new clsUTC(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtcEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtcEditor.Show();
        }
        else if (StringType.StrCmp(resTypeStr, "utd", false) == 0)
        {
            var frmUtdEditor = new frmUTD_Editor(new clsUTD(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtdEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtdEditor.Show();
        }
        else if (StringType.StrCmp(resTypeStr, "uti", false) == 0)
        {
            /*var frmUtiEditor = new frmUTI_Editor(new clsUTI(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtiEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtiEditor.Show();#1#
        }
        else if (StringType.StrCmp(resTypeStr, "utm", false) == 0)
        {
            var frmUtmEditor = new frmUTM_Editor(new clsUTM(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtmEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtmEditor.Show();
        }
        else if (StringType.StrCmp(resTypeStr, "utp", false) == 0)
        {
            var frmUtpEditor = new frmUTP_Editor(new clsUTP(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtpEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtpEditor.Show();
        }
        else if (StringType.StrCmp(resTypeStr, "uts", false) == 0)
        {
            /*var frmUtsEditor = new frmUTS_Editor(new clsUTS(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtsEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtsEditor.Show();#1#
        }
        else if (StringType.StrCmp(resTypeStr, "utt", false) == 0)
        {
            var frmUttEditor = new frmUTT_Editor(new clsUTT(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUttEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUttEditor.Show();
        }
        else if (StringType.StrCmp(resTypeStr, "utw", false) == 0)
        {
            var frmUtwEditor = new frmUTW_Editor(new clsUTW(numArray1, NodeTreeRootIndex(node)),
                NodeTreeRootIndex(node));
            frmUtwEditor.EditingFilePath = CurrentSettings.defaultSaveLocation + "\\" + node.Text;
            frmUtwEditor.Show();
        }
        else if (StringType.StrCmp(resTypeStr, "tpc", false) == 0 ||
                 StringType.StrCmp(resTypeStr, "txb", false) == 0)
        {
            if (ModifierKeys == Keys.Shift)
                EditTpcResource(node.Filename, numArray1);
            else
                ShowImage(node);
        }
        else if (StringType.StrCmp(resTypeStr, "tga", false) == 0)
            OpenTgaInExternalViewer(node.Filename, numArray1);
        else if (StringType.StrCmp(resTypeStr, "dlg", false) == 0)
            new frmDialogEditor(numArray1, node.ResRef, NodeTreeRootIndex(node)).Show();
        else if (StringType.StrCmp(resTypeStr, "ssf", false) == 0)
        {
            /*var ssf = new ClsSsf(numArray1, NodeTreeRootIndex(node));
            var frmSsfEditor = new frmSSFEditor(ssf);
            var index = 0;
            do
            {
                Console.WriteLine("Index: " + StringType.FromInteger(index) + "  StringRef: " +
                                  StringType.FromInteger(ssf.get_RefArray(index)) + "  SoundResRef: '" +
                                  ssf.get_RefArraySoundResRef(index) + "'  String: '" +
                                  ssf.get_RefArrayString(index) + "'");
                checked
                {
                    ++index;
                }
            } while (index <= 39);

            var num = (int)frmSsfEditor.ShowDialog();#1#
        }

        Cursor.Current = current;*/
        }
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

    private int CurrentTreeRootIndex()
    {
        var lower1 = _lastClickedTvNode.FullPath.ToLower();
        var sLeft = lower1;
        if (StringType.StrCmp(sLeft, "kotor i", false) == 0)
            return 0;
        if (StringType.StrCmp(sLeft, "kotor ii", false) == 0)
            return 1;
        var lower2 = lower1.Substring(0, lower1.IndexOf(TreeView.PathSeparator)).ToLower();
        if (StringType.StrCmp(lower2, "kotor i", false) == 0)
            return 0;
        var num = 0;
        return StringType.StrCmp(lower2, "kotor ii", false) == 0 ? 1 : num;
    }

    private KotorTreeNode CurrentTreeRoot() => (KotorTreeNode)TreeView.Nodes[CurrentTreeRootIndex()];

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
                var lower2 = lower1.Substring(0, lower1.IndexOf(TreeView.PathSeparator)).ToLower();
                if (StringType.StrCmp(lower2, "kotor i", false) == 0)
                    num = 0;
                else if (StringType.StrCmp(lower2, "kotor ii", false) == 0)
                    num = 1;
            }
        }
        catch (Exception ex)
        {
            CaptureError(ex, new[] { "Error determining node tree root index" });
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


    private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
    {
        /*if (e.Node.GetType() == (object)"System.Windows.Form.TreeNode")
            return;
        var node = (KotorTreeNode)e.Node;
        if (!(NodeTreeRootIndex(node) == 0 & _hasK1) && !(NodeTreeRootIndex(node) == 1 & _hasK2))
            return;
        if (node.Parent == null || node.Tag == null)
        {
            MiExtract.Enabled = false;
            BtnExtract.Enabled = false;
            BtnHexViewer.Enabled = false;
        }
        else
        {
            BtnExtractForModuleEditing.Enabled = false;
            var tag1 = node.Tag;
            if (ObjectType.ObjTst(tag1, "RIM_Modules", false) == 0 ||
                ObjectType.ObjTst(tag1, "RIM_Rims", false) == 0 ||
                ObjectType.ObjTst(tag1, "ERF_Root", false) == 0 ||
                ObjectType.ObjTst(tag1, "ERF_TexturePacks", false) == 0 ||
                ObjectType.ObjTst(tag1, "ERF_Modules", false) == 0 ||
                ObjectType.ObjTst(tag1, "globalvar", false) == 0)
            {
                MiExtract.Enabled = false;
                BtnExtract.Enabled = false;
                BtnHexViewer.Enabled = false;
            }
            else
            {
                MiExtract.Enabled = true;
                BtnExtract.Enabled = true;
                BtnHexViewer.Enabled = true;
                var tag2 = node.Tag;
                if (ObjectType.ObjTst(tag2, "BIFF", false) == 0)
                    BtnExtract.Text = "Extract entire BIFF file";
                else if (ObjectType.ObjTst(tag2, "RIM", false) == 0)
                {
                    BtnExtract.Text = "Extract entire RIM file";
                    if (ObjectType.ObjTst(node.Tag, "RIM", false) != 0 ||
                        ObjectType.ObjTst(node.Parent.Tag, "RIM_Modules", false) != 0 ||
                        node.Filename.Replace(".rim", "").EndsWith("_s"))
                        return;
                    BtnExtractForModuleEditing.Enabled = true;
                }
                else if (ObjectType.ObjTst(tag2, "ERF", false) == 0)
                    BtnExtract.Text = "Extract entire ERF file";
                else if (ObjectType.ObjTst(tag2, "BIFF_Res", false) == 0 ||
                         ObjectType.ObjTst(tag2, "RIM_Res", false) == 0 ||
                         ObjectType.ObjTst(tag2, "ERF_Res", false) == 0)
                {
                    BtnExtract.Text = "Extract file";
                }
                else
                {
                    if (ObjectType.ObjTst(tag2, "NodeCategory", false) != 0)
                        return;
                    var containingFileType = ((KotorTreeNode)node.Parent).ContainingFileType;
                    if (StringType.StrCmp(containingFileType, "BIF", false) == 0)
                    {
                        BtnExtract.Text = "Extract entire BIFF subtype";
                    }
                    else
                    {
                        if (StringType.StrCmp(containingFileType, "rim", false) != 0)
                            return;
                        BtnExtract.Text = "Extract entire RIM subtype";
                    }
                }
            }
        }*/
    }

    private void btnExtract_Click(object sender, EventArgs e)
    {
        //ExtractSelectedKotorFile((KotorTreeNode)TreeView.SelectedNode);
    }


    private void btnExtractForModuleEditing_Click(object sender, EventArgs e)
    {
        //cmiExtractForModuleEditing_Click(null, null);
    }


    private void TreeView_DoubleClick(object sender, EventArgs e)
    {
        // HandleDataByNodeType((KotorTreeNode)TreeView.SelectedNode, RuntimeHelpers.GetObjectValue(sender));
    }


    private void AddNodeChildrenToTreePaths(TreeNode node, IList arTreeOpenPaths)
    {
        try
        {
            foreach (KotorTreeNode treeNode in node.Nodes)
            {
                if (!treeNode.IsExpanded) continue;

                if (!arTreeOpenPaths.Contains(treeNode.FullPath))
                    arTreeOpenPaths.Add(treeNode.FullPath);

                AddNodeChildrenToTreePaths(treeNode, arTreeOpenPaths);
            }
        }
        catch (Exception ex)
        {
            CaptureError(ex, new[] { "Error adding node children to tree paths" });
            /*ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();*/
        }
    }


    public byte[] ReadByteArray(string Path)
    {
        try
        {
            var input = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            var binaryReader = new BinaryReader(input);
            var array = new byte[checked((int)(input.Length - 1L) + 1)];
            var read = input.Read(array, 0, checked((int)input.Length));
            input.Close();
            return array;
        }
        catch (Exception e)
        {
            CaptureError(e, new[] { "Error Reading Byte Array" });
        }

        return Array.Empty<byte>();
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

    private void CreateMapInfoBFD_Click(object sender, EventArgs e) => new clsMapInfoCreator().Write(GRootPath);

    private void Read_NWScript_Click(object sender, EventArgs e)
    {
        var fileStream =
            new FileStream(
                @"C:\SharpDevelop_1.1.0.2081\src\Libraries\ICSharpCode.TextEditor\src\ICSharpCode.TextEditor.prjx",
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

    private void btnHexViewer_Click(object sender, EventArgs e)
    {
        var selectedNode = (KotorTreeNode)TreeView.SelectedNode;
        if (selectedNode == null || ObjectType.ObjTst(selectedNode.Tag, "BIFF_Root", false) == 0 ||
            ObjectType.ObjTst(selectedNode.Tag, "RIM_Root", false) == 0)
            return;
        var tag = selectedNode.Tag;
        /*frmByteViewer frmByteViewer;
        if (ObjectType.ObjTst(tag, "BIFF", false) == 0 || ObjectType.ObjTst(tag, "RIM", false) == 0)
            frmByteViewer = new frmByteViewer(selectedNode.FilePath + "\\" + selectedNode.Filename);
        else if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0)
        {
            //frmByteViewer = new frmByteViewer(GetRimResource(selectedNode.FilePath, selectedNode));
        }

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

        //frmByteViewer.Show();*/
    }

    // TODO : Move to Presenter
    private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
        /*var node = (KotorTreeNode)e.Node;
        CurrentSettings = UserSettings.GetSettings();
        if (!CurrentSettings.TreeOpenPaths.Contains(node.FullPath))
            CurrentSettings.TreeOpenPaths.Add(node.FullPath);
        AddNodeChildrenToTreePaths(node, CurrentSettings.TreeOpenPaths);
        UserSettings.SaveSettings(CurrentSettings);
        var tag = node.Tag;
        if (ObjectType.ObjTst(tag, "BIFF_Root", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0)
                return;
            BuildTreeView((KotorTreeNode)node.Parent);
        }
        else if (ObjectType.ObjTst(tag, "RIM_Modules", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0)
                return;
            ScanForRimSandBuildTree(node, "modules");
            node.Nodes[0].Remove();
        }
        else if (ObjectType.ObjTst(tag, "RIM_Rims", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0)
                return;
            ScanForRimSandBuildTree(node, "rims");
            node.Nodes[0].Remove();
        }
        else if (ObjectType.ObjTst(tag, "RIM", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0)
                return;
            //ReadRiMentries(node.FilePath + "\\" + node.Filename, node);
            node.Nodes[0].Remove();
        }
        else if (ObjectType.ObjTst(tag, "ERF_TexturePacks", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0)
                return;
            ScanForErFsAndBuildTree(node, "texturePacks");
            node.Nodes[0].Remove();
        }
        else if (ObjectType.ObjTst(tag, "ERF_Modules", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) == 0)
            {
                ScanForErFsAndBuildTree(node, "modules");
                node.Nodes[0].Remove();
            }
            else
            {
                node.Nodes.Clear();
                ScanForErFsAndBuildTree(node, "modules");
            }
        }
        else if (ObjectType.ObjTst(tag, "ERF", false) == 0)
        {
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0)
                return;
            //ReadErFentries(node.FilePath + "\\" + node.Filename, node);
            node.Nodes[0].Remove();
        }
        else
        {
            if (ObjectType.ObjTst(tag, "Saves_Root", false) != 0)
                return;
            if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) == 0)
            {
                ScanForSavesAndBuildTree(node.FilePath, node);
                node.Nodes[0].Remove();
            }
            else
            {
                node.Nodes.Clear();
                ScanForSavesAndBuildTree(node.FilePath, node);
            }
        }*/
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

    // TODO : Move to Presenter
    private async Task BuildTreeView(KotorTreeNode Root, bool noProgressIndication = false)
    {
        //_logger.LogInformation("Building Tree View");
        //var childForm = await _internalServiceFactory.Create<FrmProgressMeter>();
        //var relativePositioner = await _internalServiceFactory.Create<utilWindowRelativePositioner>();
        //var relativePositioner = new utilWindowRelativePositioner(this, childForm);
        var filePath = Root.FilePath;
        var index1 = NodeTreeRootIndex(Root);
        var fileStream = new FileStream(CurrentSettings.KeyFileLocation(index1), FileMode.Open, FileAccess.Read,
            FileShare.ReadWrite, 600000);
        var binaryReader = new BinaryReader(fileStream);
        //childForm.Message = "Preparing Resource List";
        //childForm.Status = "Reading key file";
        // ((Control)childForm).Location = relativePositioner.GetConcentric();
        // childForm.StepAmount = 5;
        Root.Nodes[0].Nodes.Clear();
        TreeView.BeginUpdate();
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
        catch (Exception ex)
        {
            CaptureError(ex, new[] { "Error building tree view" });
        }


        // Reset back to the original position??
        fileStream.Seek(offset, SeekOrigin.Begin);
        now = DateAndTime.Now;
        var numArray = new byte[checked((int)fileStream.Length + 1)];
        fileStream.Position = 0L;
        fileStream.Read(numArray, 0, checked((int)(fileStream.Length - 1L)));
        if (!noProgressIndication)
        {
        }

        //childForm.Show();
        var num4 = num1 / 20;
        var num5 = checked(num1 - 1);
        var index3 = 0;
        while (index3 <= num5)
        {
            var keyEntry = new KeyEntry(index3, numArray, checked(offset + 22 * index3));
            _biffEntryListArray[index1, keyEntry.ResId >> 20].Add(keyEntry);
            if (index3 / num4 == index3 / (double)num4)
            {
            }

            //childForm.StepUp();
            checked
            {
                ++index3;
            }
        }

        //childForm.Progress = 0;
        var buildModelsBifNode = CurrentSettings.bBuildModelsBifNode;
        var num6 = 0;
        var num7 = checked(capacity - 1);
        var index4 = 0;
        while (index4 <= num7)
        {
            // childForm.Status = "Building tree for " + ((BIFFEntry)_biffEntries[index1][index4]).filename;
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
                    {
                    }

                    //childForm.StepUp();
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
        //childForm.Hide();
    }

    // TODO : Move to Presenter
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
        catch (Exception ex)
        {
            CaptureError(ex, new[] { "Error organizing nodes by res type" });
        }


        var node2 = new KotorTreeNode(ParentDescForResType(node.ResType))
        {
            ResType = node.ResType,
            Tag = "NodeCategory"
        };
        node2.Nodes.Add(node);
        Collection.Nodes.Add(node2);
    }

    // TODO : Move to Presenter
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
            _ => Identification.GetRsrcTypeForId(ResType)
        };
    }

    // TODO : Move to Presenter

    // TODO : Move to Presenter

    // TODO : Move to Presenter
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
        catch (Exception exception)
        {
            CaptureError(exception, new[] { "Error attaching node parents sorted by desc" });
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
            catch (Exception exception)
            {
                CaptureError(exception, new[] { "Error attaching node parents sorted by desc" });
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


    private static string GetModuleDescForRimName(string rimName)
    {
        var sLeft = rimName.Replace(".rim", string.Empty).Replace("_s", string.Empty);

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
    }

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
            /*var frm2DaEditor = new frm2DAEditor(Path.GetFileName(_cmdArgs[0]), a2da);
            ((Control)frm2DaEditor).Location = new Point(checked(((Control)this).Location.X + Size.Width),
                ((Control)this).Location.Y);
            frm2DaEditor.Show();
            return frm2DaEditor;*/
        }

        if (StringType.StrCmp(Path.GetExtension(_cmdArgs[0]).ToLower(), ".tlk", false) != 0)
        {
            Form form = null;
            return form;
        }

        /*var frmDialogTlk = new frmDialogTlk(_cmdArgs[0]);
        frmDialogTlk.Show();
        return frmDialogTlk;*/
        return null;
    }

    public int GetGffFileKotorVersionIndex(string filepath)
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
        }
        catch (FileNotFoundException ex)
        {
            CaptureError(ex, new[] { "Could not find file: " + filepath });
        }
        catch (DirectoryNotFoundException ex)
        {
            CaptureError(ex, new[] { "Could not directory in path to: " + filepath });
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

        /*var specifyKotorVersion = new frmSpecifyKotorVersion();
        specifyKotorVersion.FileName = Path.GetFileName(filepath);
        return specifyKotorVersion.ShowDialog(Mainform) == DialogResult.OK
            ? specifyKotorVersion.KotorVerIndexSelected
            : -1;*/
        return 1;
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
            CaptureError(ex, new[] { "Could not find file: " + filepath });
            ManageMruMainFileList(filepath, true);
            Interaction.MsgBox("Could not find file: " + filepath, MsgBoxStyle.Critical, "");

            goto label_26;
        }
        catch (DirectoryNotFoundException ex)
        {
            CaptureError(ex, new[] { "Could not directory in path to: " + filepath });
            ManageMruMainFileList(filepath, true);
            ShowError("Could not directory in path to: " + filepath);
            goto label_26;
        }

        if (kotorVersionIndex != -1)
        {
            /*
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
                Interaction.MsgBox("There is no editor available for that file type",
                    MsgBoxStyle.Exclamation, "Unsupported File Type");
                goto label_26;
            }

            ManageMruMainFileList(filepath);
            ((frmParent)o).EditingFilePath = filepath;
            LateBinding.LateCall(o, null, "Show", new object[0], null, null);

            if (formLocationOffset != -1)
            {
                ((Control)o).Location = new Point(checked(((Control)o).Location.X + formLocationOffset),
                    checked(((Control)o).Location.Y + formLocationOffset));
            }
            */
               return null;
           // return (Form)o;
        }

        label_26:
        Form form = null;
        return form;
    }


    private void OpenConversationEditor()
    {
        /*var frmDialogEditor = new frmDialogEditor();
        frmDialogEditor.SetupForNewDialog();
        frmDialogEditor.Show();*/
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
        {
            CurrentSettings.MRUMainFiles.RemoveAt(index);
        }


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
        catch (Exception exception)
        {
            CaptureError(exception, new[] { "Error in ManageMruMainFileMenu" });
        }*/
    }

    public void CleanDirectory(string dirname)
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
            CaptureError(ex, new[] { "The process failed: " + ex });
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
            CaptureError(ex, new[] { "The process failed: " + ex });
        }
    }

    // TODO : Move to Presenter
    public void OpenTreeViewToPath(
        string treepath,
        TreeNode currNode,
        int currLevel,
        bool SelectAfterExpand = true)
    {
        /*var strArray = treepath.Split('\\');
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
            catch (Exception ex)
            {
                CaptureError(ex, new[] { "Error in OpenTreeViewToPath" });
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
            catch (Exception ex)
            {
                CaptureError(ex, new[] { "Error in OpenTreeViewToPath" });
            }
        }*/
    }

    public static string TrimAfterDash(string s) =>
        s.IndexOf("-") == -1 ? s : s.Substring(0, checked(s.IndexOf("-") - 1));

    private void TreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
    {
        /*var node = (KotorTreeNode)e.Node;
        CurrentSettings = UserSettings.GetSettings();
        var index = checked(CurrentSettings.TreeOpenPaths.Count - 1);
        while (index >= 0)
        {
            if (BooleanType.FromObject(BooleanType.FromObject(LateBinding.LateGet(
                                           CurrentSettings.TreeOpenPaths[index], null, "StartsWith", new object[1]
                                           {
                                               node.FullPath + "\\"
                                           }, null, null)) ||
                                       BooleanType.FromObject(
                                           ObjectType.ObjTst(CurrentSettings.TreeOpenPaths[index], node.FullPath,
                                               false) == 0)
                    ? true
                    : (object)false))
                CurrentSettings.TreeOpenPaths.RemoveAt(index);
            checked
            {
                index += -1;
            }
        }

        UserSettings.SaveSettings(CurrentSettings);*/
    }

    private void TreeView_KeyUp(object sender, KeyEventArgs e)
    {
        /*var resTypeStr = ((KotorTreeNode)TreeView.SelectedNode).ResTypeStr;
        if (!(StringType.StrCmp(resTypeStr, "tpc", false) == 0 | StringType.StrCmp(resTypeStr, "txb", false) == 0))
            return;
        if (GImageViewer != null && GImageViewer.Created && GImageViewer.Visible)
        {
            if (!(e.KeyCode == Keys.Up | e.KeyCode == Keys.Down))
                return;
            ShowImage((KotorTreeNode)TreeView.SelectedNode);
        }
        else
        {
            if (e.KeyCode != Keys.Space)
                return;
            ShowImage((KotorTreeNode)TreeView.SelectedNode);
        }*/
    }

    private void TreeView_MouseDown(object sender, MouseEventArgs e)
    {
        /*var pt = new Point(e.X, e.Y);
        _secondToLastClickedTvNode = _lastClickedTvNode;
        _lastClickedTvNode = (KotorTreeNode)TreeView.GetNodeAt(pt);
        if (_lastClickedTvNode != null)
        {
            TreeView.SelectedNode = _lastClickedTvNode;
            CurrentSettings = UserSettings.GetSettings();
            CurrentSettings.LastClickedTVNodePath = _lastClickedTvNode.FullPath;
            UserSettings.SaveSettings(CurrentSettings);
        }

        if (MouseButtons != MouseButtons.Right || _lastClickedTvNode == null ||
            ObjectType.ObjTst(_lastClickedTvNode.Tag, "RIM", false) != 0 ||
            ObjectType.ObjTst(_lastClickedTvNode.Parent.Tag, "RIM_Modules", false) != 0 ||
            _lastClickedTvNode.Filename.Replace(".rim", "").EndsWith("_s"))
            return;
        TvCMenu.Show((Control)sender, TreeView.PointToClient(MousePosition));*/
    }

    private void TreeView_KeyPress(object sender, KeyPressEventArgs e)
    {
        /*if (e.KeyChar != '\r' || TreeView.SelectedNode == null)
            return;
        e.Handled = true;
        HandleDataByNodeType((KotorTreeNode)TreeView.SelectedNode, RuntimeHelpers.GetObjectValue(sender));*/
    }
}