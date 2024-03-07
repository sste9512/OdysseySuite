// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmProjectManager
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmProjectManager : frmParent
{
  [AccessedThroughProperty("tvcmiStreamWavesModulesParent_RemoveSelf")]
  private ToolStripMenuItem _tvcmiStreamWavesModulesParent_RemoveSelf;
  [AccessedThroughProperty("ToolStripMenuItem15")]
  private ToolStripMenuItem _ToolStripMenuItem15;
  [AccessedThroughProperty("tvcmiStreamWavesModuleParent_RenameSelf")]
  private ToolStripMenuItem _tvcmiStreamWavesModuleParent_RenameSelf;
  [AccessedThroughProperty("ToolStripMenuItem14")]
  private ToolStripMenuItem _ToolStripMenuItem14;
  [AccessedThroughProperty("tvcmiStreamWavesModuleParent_ExcludeAllFiles")]
  private ToolStripMenuItem _tvcmiStreamWavesModuleParent_ExcludeAllFiles;
  [AccessedThroughProperty("miOpenProject")]
  private ToolStripMenuItem _miOpenProject;
  [AccessedThroughProperty("ToolStripMenuItem9")]
  private ToolStripMenuItem _ToolStripMenuItem9;
  [AccessedThroughProperty("tvcmiStreamWavesModuleParent_AddFiles")]
  private ToolStripMenuItem _tvcmiStreamWavesModuleParent_AddFiles;
  [AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveEverything")]
  private ToolStripMenuItem _tvcmiStreamWavesRoot_RemoveEverything;
  [AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveAllModules")]
  private ToolStripMenuItem _tvcmiStreamWavesRoot_RemoveAllModules;
  [AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveAllFiles")]
  private ToolStripMenuItem _tvcmiStreamWavesRoot_RemoveAllFiles;
  [AccessedThroughProperty("tvcmiStreamWavesRoot_AddModule")]
  private ToolStripMenuItem _tvcmiStreamWavesRoot_AddModule;
  [AccessedThroughProperty("tvcmiStreamWavesRoot_AddFile")]
  private ToolStripMenuItem _tvcmiStreamWavesRoot_AddFile;
  [AccessedThroughProperty("tvcmiStreamWavesFileChild_ExcludeSelf")]
  private ToolStripMenuItem _tvcmiStreamWavesFileChild_ExcludeSelf;
  [AccessedThroughProperty("ilistTree")]
  private ImageList _ilistTree;
  [AccessedThroughProperty("tvcmiModulesParent_Properties")]
  private ToolStripMenuItem _tvcmiModulesParent_Properties;
  [AccessedThroughProperty("ToolStripMenuItem16")]
  private ToolStripMenuItem _ToolStripMenuItem16;
  [AccessedThroughProperty("tvcmStreamWavesFileChild")]
  private ContextMenu _tvcmStreamWavesFileChild;
  [AccessedThroughProperty("tvcmStreamWavesModulesChild")]
  private ContextMenu _tvcmStreamWavesModulesChild;
  [AccessedThroughProperty("tvcmStreamWavesModulesParent")]
  private ContextMenu _tvcmStreamWavesModulesParent;
  [AccessedThroughProperty("ToolStripMenuItem11")]
  private ToolStripMenuItem _ToolStripMenuItem11;
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("tvcmStreamWavesRoot")]
  private ContextMenu _tvcmStreamWavesRoot;
  [AccessedThroughProperty("ToolStripMenuItem12")]
  private ToolStripMenuItem _ToolStripMenuItem12;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("miCleanReleasePrjFilesOnly")]
  private ToolStripMenuItem _miCleanReleasePrjFilesOnly;
  [AccessedThroughProperty("miCleanDebugPrjFilesOnly")]
  private ToolStripMenuItem _miCleanDebugPrjFilesOnly;
  [AccessedThroughProperty("tvcmiLipsModulesParent_RenameSelf")]
  private ToolStripMenuItem _tvcmiLipsModulesParent_RenameSelf;
  [AccessedThroughProperty("TreeView")]
  private TreeView _TreeView;
  [AccessedThroughProperty("tvcmiModulesParent_RenameSelf")]
  private ToolStripMenuItem _tvcmiModulesParent_RenameSelf;
  [AccessedThroughProperty("miExploreDebugFolder")]
  private ToolStripMenuItem _miExploreDebugFolder;
  [AccessedThroughProperty("miExploreReleaseFolder")]
  private ToolStripMenuItem _miExploreReleaseFolder;
  [AccessedThroughProperty("tvcmiProperties")]
  private ToolStripMenuItem _tvcmiProperties;
  [AccessedThroughProperty("tvcmProjectRoot")]
  private ContextMenu _tvcmProjectRoot;
  [AccessedThroughProperty("tvcmiLipsModulesParent_RemoveSelf")]
  private ToolStripMenuItem _tvcmiLipsModulesParent_RemoveSelf;
  [AccessedThroughProperty("ToolStripMenuItem13")]
  private ToolStripMenuItem _ToolStripMenuItem13;
  [AccessedThroughProperty("ToolStripMenuItem5")]
  private ToolStripMenuItem _ToolStripMenuItem5;
  [AccessedThroughProperty("miQuit")]
  private ToolStripMenuItem _miQuit;
  [AccessedThroughProperty("ToolStripMenuItem8")]
  private ToolStripMenuItem _ToolStripMenuItem8;
  [AccessedThroughProperty("tvcmiModulesParent_RemoveSelf")]
  private ToolStripMenuItem _tvcmiModulesParent_RemoveSelf;
  [AccessedThroughProperty("tvcmiLipsModulesRoot_RemoveAllModules")]
  private ToolStripMenuItem _tvcmiLipsModulesRoot_RemoveAllModules;
  [AccessedThroughProperty("tvcmiModulesRoot_RemoveAllModules")]
  private ToolStripMenuItem _tvcmiModulesRoot_RemoveAllModules;
  [AccessedThroughProperty("lblStatus")]
  private Label _lblStatus;
  [AccessedThroughProperty("tvcmiLipsModulesParent_RemoveAll")]
  private ToolStripMenuItem _tvcmiLipsModulesParent_RemoveAll;
  [AccessedThroughProperty("ToolStripMenuItem2")]
  private ToolStripMenuItem _ToolStripMenuItem2;
  [AccessedThroughProperty("tvcmiModulesParent_RemoveAll")]
  private ToolStripMenuItem _tvcmiModulesParent_RemoveAll;
  [AccessedThroughProperty("ToolStripMenuItem4")]
  private ToolStripMenuItem _ToolStripMenuItem4;
  [AccessedThroughProperty("tvcmiOverrideRoot_RemoveAll")]
  private ToolStripMenuItem _tvcmiOverrideRoot_RemoveAll;
  [AccessedThroughProperty("ToolStripMenuItem7")]
  private ToolStripMenuItem _ToolStripMenuItem7;
  [AccessedThroughProperty("ToolStripMenuItem6")]
  private ToolStripMenuItem _ToolStripMenuItem6;
  [AccessedThroughProperty("ToolStripMenuItem3")]
  private ToolStripMenuItem _ToolStripMenuItem3;
  [AccessedThroughProperty("miBuildProject")]
  private ToolStripMenuItem _miBuildProject;
  [AccessedThroughProperty("ToolStripMenuItem10")]
  private ToolStripMenuItem _ToolStripMenuItem10;
  [AccessedThroughProperty("tvcmOverrideRoot")]
  private ContextMenu _tvcmOverrideRoot;
  [AccessedThroughProperty("tvcmOverrideChild")]
  private ContextMenu _tvcmOverrideChild;
  [AccessedThroughProperty("miSaveProject")]
  private ToolStripMenuItem _miSaveProject;
  [AccessedThroughProperty("tvcmModulesRoot")]
  private ContextMenu _tvcmModulesRoot;
  [AccessedThroughProperty("tvcmModulesParent")]
  private ContextMenu _tvcmModulesParent;
  [AccessedThroughProperty("tvcmModulesChild")]
  private ContextMenu _tvcmModulesChild;
  [AccessedThroughProperty("tvcmLipsModulesRoot")]
  private ContextMenu _tvcmLipsModulesRoot;
  [AccessedThroughProperty("tvcmLipsModulesParent")]
  private ContextMenu _tvcmLipsModulesParent;
  [AccessedThroughProperty("tvcmLipsModulesChild")]
  private ContextMenu _tvcmLipsModulesChild;
  [AccessedThroughProperty("tvcmiStreamWavesModulesChild_ExcludeSelf")]
  private ToolStripMenuItem _tvcmiStreamWavesModulesChild_ExcludeSelf;
  [AccessedThroughProperty("tvcmiOverrideRoot_Add")]
  private ToolStripMenuItem _tvcmiOverrideRoot_Add;
  [AccessedThroughProperty("tvcmiOverrideChild_Exclude")]
  private ToolStripMenuItem _tvcmiOverrideChild_Exclude;
  [AccessedThroughProperty("miRelease")]
  private ToolStripMenuItem _miRelease;
  [AccessedThroughProperty("tvcmiModulesRoot_Add")]
  private ToolStripMenuItem _tvcmiModulesRoot_Add;
  [AccessedThroughProperty("tvcmiModulesParent_Add")]
  private ToolStripMenuItem _tvcmiModulesParent_Add;
  [AccessedThroughProperty("tvcmiModulesChild_Exclude")]
  private ToolStripMenuItem _tvcmiModulesChild_Exclude;
  [AccessedThroughProperty("tvcmiLipsModulesRoot_Add")]
  private ToolStripMenuItem _tvcmiLipsModulesRoot_Add;
  [AccessedThroughProperty("tvcmiLipsModulesParent_Add")]
  private ToolStripMenuItem _tvcmiLipsModulesParent_Add;
  [AccessedThroughProperty("tvcmiLipsModulesChild_Exclude")]
  private ToolStripMenuItem _tvcmiLipsModulesChild_Exclude;
  [AccessedThroughProperty("miProjectProperties")]
  private ToolStripMenuItem _miProjectProperties;
  [AccessedThroughProperty("miNewPoject")]
  private ToolStripMenuItem _miNewPoject;
  [AccessedThroughProperty("miDebug")]
  private ToolStripMenuItem _miDebug;
  private string InitialBrowsePath;
  private string ProjectFilePath;
  private string WorkingPath;
  private ClsProjectManager ProjectMgr;
  private ClsProject Project;
  private TreeNode LastClickedTVNode;
  private FrmMain MyParentForm;
  private string BuildMode;
  private const int ilFileIcon = 1;
  private const int ilFolderIcon = 2;
  private IContainer components;

  public frmProjectManager()
  {
      Closing += new CancelEventHandler(frmProjectManager_Closing);
      Load += new EventHandler(frmProjectManager_Load);
      InitialBrowsePath = "c:\\";
      BuildMode = "debug";
      InitializeComponent();
    }

  public frmProjectManager(FrmMain parentForm)
    : this()
  {
      MyParentForm = parentForm;
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TreeView TreeView
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TreeView != null)
        {
          _TreeView.DoubleClick -= new EventHandler(TreeView_DoubleClick);
          _TreeView.MouseLeave -= new EventHandler(TreeView_MouseLeave);
          _TreeView.MouseMove -= new MouseEventHandler(TreeView_MouseMove);
          _TreeView.DragOver -= new DragEventHandler(TreeView_DragOver);
          _TreeView.DragDrop -= new DragEventHandler(TreeView_DragDrop);
          _TreeView.MouseDown -= new MouseEventHandler(TreeView_MouseDown);
        }
        _TreeView = value;
        if (_TreeView == null)
          return;
        _TreeView.DoubleClick += new EventHandler(TreeView_DoubleClick);
        _TreeView.MouseLeave += new EventHandler(TreeView_MouseLeave);
        _TreeView.MouseMove += new MouseEventHandler(TreeView_MouseMove);
        _TreeView.DragOver += new DragEventHandler(TreeView_DragOver);
        _TreeView.DragDrop += new DragEventHandler(TreeView_DragDrop);
        _TreeView.MouseDown += new MouseEventHandler(TreeView_MouseDown);
      }
    get => _TreeView;
  }

  internal virtual MainMenu MainMenu1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_MainMenu1 == null)
          ;
        _MainMenu1 = value;
        if (_MainMenu1 == null)
          ;
      }
    get => _MainMenu1;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem1
  {
    get => _ToolStripMenuItem1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem1 == null)
          ;
        _ToolStripMenuItem1 = value;
        if (_ToolStripMenuItem1 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem4 == null)
          ;
        _ToolStripMenuItem4 = value;
        if (_ToolStripMenuItem4 == null)
          ;
      }
    get => _ToolStripMenuItem4;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem7
  {
    get => _ToolStripMenuItem7;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem7 == null)
          ;
        _ToolStripMenuItem7 = value;
        if (_ToolStripMenuItem7 == null)
          ;
      }
  }

  internal virtual ContextMenu tvcmOverrideRoot
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmOverrideRoot == null)
          ;
        _tvcmOverrideRoot = value;
        if (_tvcmOverrideRoot == null)
          ;
      }
    get => _tvcmOverrideRoot;
  }

  internal virtual ContextMenu tvcmOverrideChild
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmOverrideChild == null)
          ;
        _tvcmOverrideChild = value;
        if (_tvcmOverrideChild == null)
          ;
      }
    get => _tvcmOverrideChild;
  }

  internal virtual ContextMenu tvcmModulesRoot
  {
    get => _tvcmModulesRoot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmModulesRoot == null)
          ;
        _tvcmModulesRoot = value;
        if (_tvcmModulesRoot == null)
          ;
      }
  }

  internal virtual ContextMenu tvcmModulesParent
  {
    get => _tvcmModulesParent;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmModulesParent == null)
          ;
        _tvcmModulesParent = value;
        if (_tvcmModulesParent == null)
          ;
      }
  }

  internal virtual ContextMenu tvcmModulesChild
  {
    get => _tvcmModulesChild;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmModulesChild == null)
          ;
        _tvcmModulesChild = value;
        if (_tvcmModulesChild == null)
          ;
      }
  }

  internal virtual ContextMenu tvcmLipsModulesRoot
  {
    get => _tvcmLipsModulesRoot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmLipsModulesRoot == null)
          ;
        _tvcmLipsModulesRoot = value;
        if (_tvcmLipsModulesRoot == null)
          ;
      }
  }

  internal virtual ContextMenu tvcmLipsModulesParent
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmLipsModulesParent == null)
          ;
        _tvcmLipsModulesParent = value;
        if (_tvcmLipsModulesParent == null)
          ;
      }
    get => _tvcmLipsModulesParent;
  }

  internal virtual ContextMenu tvcmLipsModulesChild
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmLipsModulesChild == null)
          ;
        _tvcmLipsModulesChild = value;
        if (_tvcmLipsModulesChild == null)
          ;
      }
    get => _tvcmLipsModulesChild;
  }

  internal virtual ToolStripMenuItem tvcmiOverrideRoot_Add
  {
    get => _tvcmiOverrideRoot_Add;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiOverrideRoot_Add != null)
          _tvcmiOverrideRoot_Add.Click -= new EventHandler(tvcmiOverrideRoot_Add_Click);
        _tvcmiOverrideRoot_Add = value;
        if (_tvcmiOverrideRoot_Add == null)
          return;
        _tvcmiOverrideRoot_Add.Click += new EventHandler(tvcmiOverrideRoot_Add_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiOverrideChild_Exclude
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiOverrideChild_Exclude != null)
          _tvcmiOverrideChild_Exclude.Click -= new EventHandler(tvcmiOverrideChild_Exclude_Click);
        _tvcmiOverrideChild_Exclude = value;
        if (_tvcmiOverrideChild_Exclude == null)
          return;
        _tvcmiOverrideChild_Exclude.Click += new EventHandler(tvcmiOverrideChild_Exclude_Click);
      }
    get => _tvcmiOverrideChild_Exclude;
  }

  internal virtual ToolStripMenuItem tvcmiModulesRoot_Add
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesRoot_Add != null)
          _tvcmiModulesRoot_Add.Click -= new EventHandler(tvcmiModulesRoot_Add_Click);
        _tvcmiModulesRoot_Add = value;
        if (_tvcmiModulesRoot_Add == null)
          return;
        _tvcmiModulesRoot_Add.Click += new EventHandler(tvcmiModulesRoot_Add_Click);
      }
    get => _tvcmiModulesRoot_Add;
  }

  internal virtual ToolStripMenuItem tvcmiModulesParent_Add
  {
    get => _tvcmiModulesParent_Add;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesParent_Add != null)
          _tvcmiModulesParent_Add.Click -= new EventHandler(tvcmiModulesParent_Add_Click);
        _tvcmiModulesParent_Add = value;
        if (_tvcmiModulesParent_Add == null)
          return;
        _tvcmiModulesParent_Add.Click += new EventHandler(tvcmiModulesParent_Add_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiModulesChild_Exclude
  {
    get => _tvcmiModulesChild_Exclude;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesChild_Exclude != null)
          _tvcmiModulesChild_Exclude.Click -= new EventHandler(tvcmiModulesChild_Exclude_Click);
        _tvcmiModulesChild_Exclude = value;
        if (_tvcmiModulesChild_Exclude == null)
          return;
        _tvcmiModulesChild_Exclude.Click += new EventHandler(tvcmiModulesChild_Exclude_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesRoot_Add
  {
    get => _tvcmiLipsModulesRoot_Add;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesRoot_Add != null)
          _tvcmiLipsModulesRoot_Add.Click -= new EventHandler(tvcmiLipsModulesRoot_Add_Click);
        _tvcmiLipsModulesRoot_Add = value;
        if (_tvcmiLipsModulesRoot_Add == null)
          return;
        _tvcmiLipsModulesRoot_Add.Click += new EventHandler(tvcmiLipsModulesRoot_Add_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesParent_Add
  {
    get => _tvcmiLipsModulesParent_Add;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesParent_Add != null)
          _tvcmiLipsModulesParent_Add.Click -= new EventHandler(tvcmiLipsModulesParent_Add_Click);
        _tvcmiLipsModulesParent_Add = value;
        if (_tvcmiLipsModulesParent_Add == null)
          return;
        _tvcmiLipsModulesParent_Add.Click += new EventHandler(tvcmiLipsModulesParent_Add_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesChild_Exclude
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesChild_Exclude != null)
          _tvcmiLipsModulesChild_Exclude.Click -= new EventHandler(tvcmiLipsModulesChild_Exclude_Click);
        _tvcmiLipsModulesChild_Exclude = value;
        if (_tvcmiLipsModulesChild_Exclude == null)
          return;
        _tvcmiLipsModulesChild_Exclude.Click += new EventHandler(tvcmiLipsModulesChild_Exclude_Click);
      }
    get => _tvcmiLipsModulesChild_Exclude;
  }

  internal virtual ToolStripMenuItem miProjectProperties
  {
    get => _miProjectProperties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miProjectProperties != null)
          _miProjectProperties.Click -= new EventHandler(miProjectProperties_Click);
        _miProjectProperties = value;
        if (_miProjectProperties == null)
          return;
        _miProjectProperties.Click += new EventHandler(miProjectProperties_Click);
      }
  }

  internal virtual ToolStripMenuItem miNewPoject
  {
    get => _miNewPoject;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miNewPoject != null)
          _miNewPoject.Click -= new EventHandler(miNewPoject_Click);
        _miNewPoject = value;
        if (_miNewPoject == null)
          return;
        _miNewPoject.Click += new EventHandler(miNewPoject_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem6
  {
    get => _ToolStripMenuItem6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem6 == null)
          ;
        _ToolStripMenuItem6 = value;
        if (_ToolStripMenuItem6 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miDebug
  {
    get => _miDebug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miDebug != null)
          _miDebug.Click -= new EventHandler(miDebug_Click);
        _miDebug = value;
        if (_miDebug == null)
          return;
        _miDebug.Click += new EventHandler(miDebug_Click);
      }
  }

  internal virtual ToolStripMenuItem miRelease
  {
    get => _miRelease;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miRelease != null)
          _miRelease.Click -= new EventHandler(miRelease_Click);
        _miRelease = value;
        if (_miRelease == null)
          return;
        _miRelease.Click += new EventHandler(miRelease_Click);
      }
  }

  internal virtual ToolStripMenuItem miOpenProject
  {
    get => _miOpenProject;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenProject != null)
          _miOpenProject.Click -= new EventHandler(miOpenProject_Click);
        _miOpenProject = value;
        if (_miOpenProject == null)
          return;
        _miOpenProject.Click += new EventHandler(miOpenProject_Click);
      }
  }

  internal virtual ToolStripMenuItem miSaveProject
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSaveProject != null)
          _miSaveProject.Click -= new EventHandler(miSaveProject_Click);
        _miSaveProject = value;
        if (_miSaveProject == null)
          return;
        _miSaveProject.Click += new EventHandler(miSaveProject_Click);
      }
    get => _miSaveProject;
  }

  internal virtual ToolStripMenuItem miQuit
  {
    get => _miQuit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miQuit != null)
          _miQuit.Click -= new EventHandler(miQuit_Click);
        _miQuit = value;
        if (_miQuit == null)
          return;
        _miQuit.Click += new EventHandler(miQuit_Click);
      }
  }

  internal virtual ToolStripMenuItem miBuildProject
  {
    get => _miBuildProject;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miBuildProject != null)
          _miBuildProject.Click -= new EventHandler(miBuildProject_Click);
        _miBuildProject = value;
        if (_miBuildProject == null)
          return;
        _miBuildProject.Click += new EventHandler(miBuildProject_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem3
  {
    get => _ToolStripMenuItem3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem3 == null)
          ;
        _ToolStripMenuItem3 = value;
        if (_ToolStripMenuItem3 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem tvcmiOverrideRoot_RemoveAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiOverrideRoot_RemoveAll != null)
          _tvcmiOverrideRoot_RemoveAll.Click -= new EventHandler(tvcmiOverrideRoot_RemoveAll_Click);
        _tvcmiOverrideRoot_RemoveAll = value;
        if (_tvcmiOverrideRoot_RemoveAll == null)
          return;
        _tvcmiOverrideRoot_RemoveAll.Click += new EventHandler(tvcmiOverrideRoot_RemoveAll_Click);
      }
    get => _tvcmiOverrideRoot_RemoveAll;
  }

  internal virtual ToolStripMenuItem tvcmiModulesParent_RemoveAll
  {
    get => _tvcmiModulesParent_RemoveAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesParent_RemoveAll != null)
          _tvcmiModulesParent_RemoveAll.Click -= new EventHandler(tvcmiModulesParent_RemoveAll_Click);
        _tvcmiModulesParent_RemoveAll = value;
        if (_tvcmiModulesParent_RemoveAll == null)
          return;
        _tvcmiModulesParent_RemoveAll.Click += new EventHandler(tvcmiModulesParent_RemoveAll_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesParent_RemoveAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesParent_RemoveAll != null)
          _tvcmiLipsModulesParent_RemoveAll.Click -= new EventHandler(tvcmiLipsModulesParent_RemoveAll_Click);
        _tvcmiLipsModulesParent_RemoveAll = value;
        if (_tvcmiLipsModulesParent_RemoveAll == null)
          return;
        _tvcmiLipsModulesParent_RemoveAll.Click += new EventHandler(tvcmiLipsModulesParent_RemoveAll_Click);
      }
    get => _tvcmiLipsModulesParent_RemoveAll;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem2
  {
    get => _ToolStripMenuItem2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem2 == null)
          ;
        _ToolStripMenuItem2 = value;
        if (_ToolStripMenuItem2 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem5
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem5 == null)
          ;
        _ToolStripMenuItem5 = value;
        if (_ToolStripMenuItem5 == null)
          ;
      }
    get => _ToolStripMenuItem5;
  }

  internal virtual ToolStripMenuItem tvcmiModulesRoot_RemoveAllModules
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesRoot_RemoveAllModules != null)
          _tvcmiModulesRoot_RemoveAllModules.Click -= new EventHandler(tvcmModulesRoot_RemoveAllModules_Click);
        _tvcmiModulesRoot_RemoveAllModules = value;
        if (_tvcmiModulesRoot_RemoveAllModules == null)
          return;
        _tvcmiModulesRoot_RemoveAllModules.Click += new EventHandler(tvcmModulesRoot_RemoveAllModules_Click);
      }
    get => _tvcmiModulesRoot_RemoveAllModules;
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesRoot_RemoveAllModules
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesRoot_RemoveAllModules != null)
          _tvcmiLipsModulesRoot_RemoveAllModules.Click -= new EventHandler(tvcmLipsModulesRoot_RemoveAllModules_Click);
        _tvcmiLipsModulesRoot_RemoveAllModules = value;
        if (_tvcmiLipsModulesRoot_RemoveAllModules == null)
          return;
        _tvcmiLipsModulesRoot_RemoveAllModules.Click += new EventHandler(tvcmLipsModulesRoot_RemoveAllModules_Click);
      }
    get => _tvcmiLipsModulesRoot_RemoveAllModules;
  }

  internal virtual ToolStripMenuItem tvcmiModulesParent_RemoveSelf
  {
    get => _tvcmiModulesParent_RemoveSelf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesParent_RemoveSelf != null)
          _tvcmiModulesParent_RemoveSelf.Click -= new EventHandler(tvcmiModulesParent_RemoveSelf_Click);
        _tvcmiModulesParent_RemoveSelf = value;
        if (_tvcmiModulesParent_RemoveSelf == null)
          return;
        _tvcmiModulesParent_RemoveSelf.Click += new EventHandler(tvcmiModulesParent_RemoveSelf_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesParent_RemoveSelf
  {
    get => _tvcmiLipsModulesParent_RemoveSelf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesParent_RemoveSelf != null)
          _tvcmiLipsModulesParent_RemoveSelf.Click -= new EventHandler(tvcmiLipsModulesParent_RemoveSelf_Click);
        _tvcmiLipsModulesParent_RemoveSelf = value;
        if (_tvcmiLipsModulesParent_RemoveSelf == null)
          return;
        _tvcmiLipsModulesParent_RemoveSelf.Click += new EventHandler(tvcmiLipsModulesParent_RemoveSelf_Click);
      }
  }

  internal virtual ContextMenu tvcmProjectRoot
  {
    get => _tvcmProjectRoot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmProjectRoot == null)
          ;
        _tvcmProjectRoot = value;
        if (_tvcmProjectRoot == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem tvcmiProperties
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiProperties != null)
          _tvcmiProperties.Click -= new EventHandler(tvcmiProperties_Click);
        _tvcmiProperties = value;
        if (_tvcmiProperties == null)
          return;
        _tvcmiProperties.Click += new EventHandler(tvcmiProperties_Click);
      }
    get => _tvcmiProperties;
  }

  internal virtual ToolStripMenuItem miExploreReleaseFolder
  {
    get => _miExploreReleaseFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miExploreReleaseFolder != null)
          _miExploreReleaseFolder.Click -= new EventHandler(miExploreReleaseFolder_Click);
        _miExploreReleaseFolder = value;
        if (_miExploreReleaseFolder == null)
          return;
        _miExploreReleaseFolder.Click += new EventHandler(miExploreReleaseFolder_Click);
      }
  }

  internal virtual ToolStripMenuItem miExploreDebugFolder
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miExploreDebugFolder != null)
          _miExploreDebugFolder.Click -= new EventHandler(miExploreDebugFolder_Click);
        _miExploreDebugFolder = value;
        if (_miExploreDebugFolder == null)
          return;
        _miExploreDebugFolder.Click += new EventHandler(miExploreDebugFolder_Click);
      }
    get => _miExploreDebugFolder;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem10
  {
    get => _ToolStripMenuItem10;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem10 == null)
          ;
        _ToolStripMenuItem10 = value;
        if (_ToolStripMenuItem10 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem tvcmiModulesParent_RenameSelf
  {
    get => _tvcmiModulesParent_RenameSelf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesParent_RenameSelf != null)
          _tvcmiModulesParent_RenameSelf.Click -= new EventHandler(tvcmiModulesParent_RenameSelf_Click);
        _tvcmiModulesParent_RenameSelf = value;
        if (_tvcmiModulesParent_RenameSelf == null)
          return;
        _tvcmiModulesParent_RenameSelf.Click += new EventHandler(tvcmiModulesParent_RenameSelf_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiLipsModulesParent_RenameSelf
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiLipsModulesParent_RenameSelf != null)
          _tvcmiLipsModulesParent_RenameSelf.Click -= new EventHandler(tvcmiLipsModulesParent_RenameSelf_Click);
        _tvcmiLipsModulesParent_RenameSelf = value;
        if (_tvcmiLipsModulesParent_RenameSelf == null)
          return;
        _tvcmiLipsModulesParent_RenameSelf.Click += new EventHandler(tvcmiLipsModulesParent_RenameSelf_Click);
      }
    get => _tvcmiLipsModulesParent_RenameSelf;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem9
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem9 == null)
          ;
        _ToolStripMenuItem9 = value;
        if (_ToolStripMenuItem9 == null)
          ;
      }
    get => _ToolStripMenuItem9;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem8
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem8 == null)
          ;
        _ToolStripMenuItem8 = value;
        if (_ToolStripMenuItem8 == null)
          ;
      }
    get => _ToolStripMenuItem8;
  }

  internal virtual ToolStripMenuItem miCleanDebugPrjFilesOnly
  {
    get => _miCleanDebugPrjFilesOnly;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCleanDebugPrjFilesOnly != null)
          _miCleanDebugPrjFilesOnly.Click -= new EventHandler(miCleanDebugPrjFilesOnly_Click);
        _miCleanDebugPrjFilesOnly = value;
        if (_miCleanDebugPrjFilesOnly == null)
          return;
        _miCleanDebugPrjFilesOnly.Click += new EventHandler(miCleanDebugPrjFilesOnly_Click);
      }
  }

  internal virtual ToolStripMenuItem miCleanReleasePrjFilesOnly
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCleanReleasePrjFilesOnly != null)
          _miCleanReleasePrjFilesOnly.Click -= new EventHandler(miCleanReleasePrjFilesOnly_Click);
        _miCleanReleasePrjFilesOnly = value;
        if (_miCleanReleasePrjFilesOnly == null)
          return;
        _miCleanReleasePrjFilesOnly.Click += new EventHandler(miCleanReleasePrjFilesOnly_Click);
      }
    get => _miCleanReleasePrjFilesOnly;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem11
  {
    get => _ToolStripMenuItem11;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem11 == null)
          ;
        _ToolStripMenuItem11 = value;
        if (_ToolStripMenuItem11 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem12
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem12 == null)
          ;
        _ToolStripMenuItem12 = value;
        if (_ToolStripMenuItem12 == null)
          ;
      }
    get => _ToolStripMenuItem12;
  }

  internal virtual ContextMenu tvcmStreamWavesRoot
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmStreamWavesRoot == null)
          ;
        _tvcmStreamWavesRoot = value;
        if (_tvcmStreamWavesRoot == null)
          ;
      }
    get => _tvcmStreamWavesRoot;
  }

  internal virtual ContextMenu tvcmStreamWavesModulesParent
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmStreamWavesModulesParent == null)
          ;
        _tvcmStreamWavesModulesParent = value;
        if (_tvcmStreamWavesModulesParent == null)
          ;
      }
    get => _tvcmStreamWavesModulesParent;
  }

  internal virtual ContextMenu tvcmStreamWavesModulesChild
  {
    get => _tvcmStreamWavesModulesChild;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmStreamWavesModulesChild == null)
          ;
        _tvcmStreamWavesModulesChild = value;
        if (_tvcmStreamWavesModulesChild == null)
          ;
      }
  }

  internal virtual ContextMenu tvcmStreamWavesFileChild
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmStreamWavesFileChild == null)
          ;
        _tvcmStreamWavesFileChild = value;
        if (_tvcmStreamWavesFileChild == null)
          ;
      }
    get => _tvcmStreamWavesFileChild;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesRoot_AddFile
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesRoot_AddFile != null)
          _tvcmiStreamWavesRoot_AddFile.Click -= new EventHandler(tvcmiStreamWavesRoot_AddFile_Click);
        _tvcmiStreamWavesRoot_AddFile = value;
        if (_tvcmiStreamWavesRoot_AddFile == null)
          return;
        _tvcmiStreamWavesRoot_AddFile.Click += new EventHandler(tvcmiStreamWavesRoot_AddFile_Click);
      }
    get => _tvcmiStreamWavesRoot_AddFile;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesRoot_AddModule
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesRoot_AddModule != null)
          _tvcmiStreamWavesRoot_AddModule.Click -= new EventHandler(tvcmiStreamWavesRoot_AddModule_Click);
        _tvcmiStreamWavesRoot_AddModule = value;
        if (_tvcmiStreamWavesRoot_AddModule == null)
          return;
        _tvcmiStreamWavesRoot_AddModule.Click += new EventHandler(tvcmiStreamWavesRoot_AddModule_Click);
      }
    get => _tvcmiStreamWavesRoot_AddModule;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem13
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem13 == null)
          ;
        _ToolStripMenuItem13 = value;
        if (_ToolStripMenuItem13 == null)
          ;
      }
    get => _ToolStripMenuItem13;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesRoot_RemoveAllFiles
  {
    get => _tvcmiStreamWavesRoot_RemoveAllFiles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesRoot_RemoveAllFiles != null)
          _tvcmiStreamWavesRoot_RemoveAllFiles.Click -= new EventHandler(tvcmiStreamWavesRoot_RemoveAllFiles_Click);
        _tvcmiStreamWavesRoot_RemoveAllFiles = value;
        if (_tvcmiStreamWavesRoot_RemoveAllFiles == null)
          return;
        _tvcmiStreamWavesRoot_RemoveAllFiles.Click += new EventHandler(tvcmiStreamWavesRoot_RemoveAllFiles_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesRoot_RemoveAllModules
  {
    get => _tvcmiStreamWavesRoot_RemoveAllModules;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesRoot_RemoveAllModules != null)
          _tvcmiStreamWavesRoot_RemoveAllModules.Click -= new EventHandler(tvcmiStreamWavesRoot_RemoveAllModules_Click);
        _tvcmiStreamWavesRoot_RemoveAllModules = value;
        if (_tvcmiStreamWavesRoot_RemoveAllModules == null)
          return;
        _tvcmiStreamWavesRoot_RemoveAllModules.Click += new EventHandler(tvcmiStreamWavesRoot_RemoveAllModules_Click);
      }
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesRoot_RemoveEverything
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesRoot_RemoveEverything != null)
          _tvcmiStreamWavesRoot_RemoveEverything.Click -= new EventHandler(tvcmiStreamWavesRoot_RemoveEverything_Click);
        _tvcmiStreamWavesRoot_RemoveEverything = value;
        if (_tvcmiStreamWavesRoot_RemoveEverything == null)
          return;
        _tvcmiStreamWavesRoot_RemoveEverything.Click += new EventHandler(tvcmiStreamWavesRoot_RemoveEverything_Click);
      }
    get => _tvcmiStreamWavesRoot_RemoveEverything;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesModuleParent_AddFiles
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesModuleParent_AddFiles != null)
          _tvcmiStreamWavesModuleParent_AddFiles.Click -= new EventHandler(tvcmiStreamWavesModuleParent_AddFiles_Click);
        _tvcmiStreamWavesModuleParent_AddFiles = value;
        if (_tvcmiStreamWavesModuleParent_AddFiles == null)
          return;
        _tvcmiStreamWavesModuleParent_AddFiles.Click += new EventHandler(tvcmiStreamWavesModuleParent_AddFiles_Click);
      }
    get => _tvcmiStreamWavesModuleParent_AddFiles;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesModuleParent_ExcludeAllFiles
  {
    get => _tvcmiStreamWavesModuleParent_ExcludeAllFiles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesModuleParent_ExcludeAllFiles != null)
          _tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click -= new EventHandler(tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click);
        _tvcmiStreamWavesModuleParent_ExcludeAllFiles = value;
        if (_tvcmiStreamWavesModuleParent_ExcludeAllFiles == null)
          return;
        _tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click += new EventHandler(tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem14
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem14 == null)
          ;
        _ToolStripMenuItem14 = value;
        if (_ToolStripMenuItem14 == null)
          ;
      }
    get => _ToolStripMenuItem14;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesModuleParent_RenameSelf
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesModuleParent_RenameSelf != null)
          _tvcmiStreamWavesModuleParent_RenameSelf.Click -= new EventHandler(tvcmiStreamWavesModuleParent_RenameSelf_Click);
        _tvcmiStreamWavesModuleParent_RenameSelf = value;
        if (_tvcmiStreamWavesModuleParent_RenameSelf == null)
          return;
        _tvcmiStreamWavesModuleParent_RenameSelf.Click += new EventHandler(tvcmiStreamWavesModuleParent_RenameSelf_Click);
      }
    get => _tvcmiStreamWavesModuleParent_RenameSelf;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem15
  {
    get => _ToolStripMenuItem15;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem15 == null)
          ;
        _ToolStripMenuItem15 = value;
        if (_ToolStripMenuItem15 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesModulesParent_RemoveSelf
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesModulesParent_RemoveSelf != null)
          _tvcmiStreamWavesModulesParent_RemoveSelf.Click -= new EventHandler(tvcmiStreamWavesModulesParent_RemoveSelf_Click);
        _tvcmiStreamWavesModulesParent_RemoveSelf = value;
        if (_tvcmiStreamWavesModulesParent_RemoveSelf == null)
          return;
        _tvcmiStreamWavesModulesParent_RemoveSelf.Click += new EventHandler(tvcmiStreamWavesModulesParent_RemoveSelf_Click);
      }
    get => _tvcmiStreamWavesModulesParent_RemoveSelf;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesModulesChild_ExcludeSelf
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesModulesChild_ExcludeSelf != null)
          _tvcmiStreamWavesModulesChild_ExcludeSelf.Click -= new EventHandler(tvcmiStreamWavesModulesChild_ExcludeSelf_Click);
        _tvcmiStreamWavesModulesChild_ExcludeSelf = value;
        if (_tvcmiStreamWavesModulesChild_ExcludeSelf == null)
          return;
        _tvcmiStreamWavesModulesChild_ExcludeSelf.Click += new EventHandler(tvcmiStreamWavesModulesChild_ExcludeSelf_Click);
      }
    get => _tvcmiStreamWavesModulesChild_ExcludeSelf;
  }

  internal virtual ToolStripMenuItem tvcmiStreamWavesFileChild_ExcludeSelf
  {
    get => _tvcmiStreamWavesFileChild_ExcludeSelf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiStreamWavesFileChild_ExcludeSelf != null)
          _tvcmiStreamWavesFileChild_ExcludeSelf.Click -= new EventHandler(tvcmiStreamWavesFileChild_ExcludeSelf_Click);
        _tvcmiStreamWavesFileChild_ExcludeSelf = value;
        if (_tvcmiStreamWavesFileChild_ExcludeSelf == null)
          return;
        _tvcmiStreamWavesFileChild_ExcludeSelf.Click += new EventHandler(tvcmiStreamWavesFileChild_ExcludeSelf_Click);
      }
  }

  internal virtual ImageList ilistTree
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ilistTree == null)
          ;
        _ilistTree = value;
        if (_ilistTree == null)
          ;
      }
    get => _ilistTree;
  }

  internal virtual Label lblStatus
  {
    get => _lblStatus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblStatus == null)
          ;
        _lblStatus = value;
        if (_lblStatus == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem tvcmiModulesParent_Properties
  {
    get => _tvcmiModulesParent_Properties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvcmiModulesParent_Properties != null)
          _tvcmiModulesParent_Properties.Click -= new EventHandler(tvcmiModulesParent_Properties_Click);
        _tvcmiModulesParent_Properties = value;
        if (_tvcmiModulesParent_Properties == null)
          return;
        _tvcmiModulesParent_Properties.Click += new EventHandler(tvcmiModulesParent_Properties_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem16
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem16 == null)
          ;
        _ToolStripMenuItem16 = value;
        if (_ToolStripMenuItem16 == null)
          ;
      }
    get => _ToolStripMenuItem16;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmProjectManager));
      TreeView = new TreeView();
      this.ilistTree = new ImageList(components);
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miNewPoject = new ToolStripMenuItem();
      miOpenProject = new ToolStripMenuItem();
      miSaveProject = new ToolStripMenuItem();
      ToolStripMenuItem4 = new ToolStripMenuItem();
      miProjectProperties = new ToolStripMenuItem();
      ToolStripMenuItem7 = new ToolStripMenuItem();
      miExploreDebugFolder = new ToolStripMenuItem();
      miExploreReleaseFolder = new ToolStripMenuItem();
      ToolStripMenuItem10 = new ToolStripMenuItem();
      miQuit = new ToolStripMenuItem();
      ToolStripMenuItem6 = new ToolStripMenuItem();
      miBuildProject = new ToolStripMenuItem();
      ToolStripMenuItem3 = new ToolStripMenuItem();
      miDebug = new ToolStripMenuItem();
      miRelease = new ToolStripMenuItem();
      ToolStripMenuItem8 = new ToolStripMenuItem();
      miCleanDebugPrjFilesOnly = new ToolStripMenuItem();
      miCleanReleasePrjFilesOnly = new ToolStripMenuItem();
      tvcmOverrideRoot = new ContextMenu();
      tvcmiOverrideRoot_Add = new ToolStripMenuItem();
      tvcmiOverrideRoot_RemoveAll = new ToolStripMenuItem();
      tvcmOverrideChild = new ContextMenu();
      tvcmiOverrideChild_Exclude = new ToolStripMenuItem();
      tvcmModulesRoot = new ContextMenu();
      tvcmiModulesRoot_Add = new ToolStripMenuItem();
      ToolStripMenuItem11 = new ToolStripMenuItem();
      tvcmiModulesRoot_RemoveAllModules = new ToolStripMenuItem();
      ToolStripMenuItem5 = new ToolStripMenuItem();
      tvcmLipsModulesRoot = new ContextMenu();
      tvcmiLipsModulesRoot_Add = new ToolStripMenuItem();
      ToolStripMenuItem12 = new ToolStripMenuItem();
      tvcmiLipsModulesRoot_RemoveAllModules = new ToolStripMenuItem();
      tvcmModulesParent = new ContextMenu();
      tvcmiModulesParent_Add = new ToolStripMenuItem();
      tvcmiModulesParent_RemoveAll = new ToolStripMenuItem();
      tvcmiModulesParent_RenameSelf = new ToolStripMenuItem();
      tvcmiModulesParent_RemoveSelf = new ToolStripMenuItem();
      ToolStripMenuItem16 = new ToolStripMenuItem();
      tvcmiModulesParent_Properties = new ToolStripMenuItem();
      ToolStripMenuItem2 = new ToolStripMenuItem();
      ToolStripMenuItem9 = new ToolStripMenuItem();
      tvcmLipsModulesParent = new ContextMenu();
      tvcmiLipsModulesParent_Add = new ToolStripMenuItem();
      tvcmiLipsModulesParent_RemoveAll = new ToolStripMenuItem();
      tvcmiLipsModulesParent_RenameSelf = new ToolStripMenuItem();
      tvcmiLipsModulesParent_RemoveSelf = new ToolStripMenuItem();
      tvcmModulesChild = new ContextMenu();
      tvcmiModulesChild_Exclude = new ToolStripMenuItem();
      tvcmLipsModulesChild = new ContextMenu();
      tvcmiLipsModulesChild_Exclude = new ToolStripMenuItem();
      tvcmProjectRoot = new ContextMenu();
      tvcmiProperties = new ToolStripMenuItem();
      tvcmStreamWavesRoot = new ContextMenu();
      tvcmiStreamWavesRoot_AddFile = new ToolStripMenuItem();
      tvcmiStreamWavesRoot_AddModule = new ToolStripMenuItem();
      ToolStripMenuItem13 = new ToolStripMenuItem();
      tvcmiStreamWavesRoot_RemoveAllFiles = new ToolStripMenuItem();
      tvcmiStreamWavesRoot_RemoveAllModules = new ToolStripMenuItem();
      tvcmiStreamWavesRoot_RemoveEverything = new ToolStripMenuItem();
      tvcmStreamWavesModulesParent = new ContextMenu();
      tvcmiStreamWavesModuleParent_AddFiles = new ToolStripMenuItem();
      tvcmiStreamWavesModuleParent_ExcludeAllFiles = new ToolStripMenuItem();
      ToolStripMenuItem14 = new ToolStripMenuItem();
      tvcmiStreamWavesModuleParent_RenameSelf = new ToolStripMenuItem();
      ToolStripMenuItem15 = new ToolStripMenuItem();
      tvcmiStreamWavesModulesParent_RemoveSelf = new ToolStripMenuItem();
      tvcmStreamWavesModulesChild = new ContextMenu();
      tvcmiStreamWavesModulesChild_ExcludeSelf = new ToolStripMenuItem();
      tvcmStreamWavesFileChild = new ContextMenu();
      tvcmiStreamWavesFileChild_ExcludeSelf = new ToolStripMenuItem();
      lblStatus = new Label();
      SuspendLayout();
      TreeView.AllowDrop = true;
      TreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TreeView.HideSelection = false;
      TreeView.ImageList = this.ilistTree;
      TreeView.Indent = 19;
      TreeView treeView1 = TreeView;
      Point point1 = new Point(12, 11);
      Point point2 = point1;
      treeView1.Location = point2;
      TreeView.Name = "TreeView";
      TreeView.RightToLeft = RightToLeft.No;
      TreeView treeView2 = TreeView;
      Size size1 = new Size(264, 341);
      Size size2 = size1;
      treeView2.Size = size2;
      TreeView.TabIndex = 0;
      ImageList ilistTree = this.ilistTree;
      size1 = new Size(16, 16);
      Size size3 = size1;
      ilistTree.ImageSize = size3;
      this.ilistTree.ImageStream = (ImageListStreamer) resourceManager.GetObject("ilistTree.ImageStream");
      this.ilistTree.TransparentColor = Color.Transparent;
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[2]
      {
        ToolStripMenuItem1,
        ToolStripMenuItem6
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[10]
      {
        miNewPoject,
        miOpenProject,
        miSaveProject,
        ToolStripMenuItem4,
        miProjectProperties,
        ToolStripMenuItem7,
        miExploreDebugFolder,
        miExploreReleaseFolder,
        ToolStripMenuItem10,
        miQuit
      });
      ToolStripMenuItem1.Text = "&File";
      miNewPoject.Index = 0;
      miNewPoject.Shortcut = Shortcut.CtrlN;
      miNewPoject.Text = "&New Project...";
      miOpenProject.Index = 1;
      miOpenProject.Shortcut = Shortcut.CtrlO;
      miOpenProject.Text = "&Open project...";
      miSaveProject.Enabled = false;
      miSaveProject.Index = 2;
      miSaveProject.Shortcut = Shortcut.CtrlS;
      miSaveProject.Text = "&Save Project";
      ToolStripMenuItem4.Index = 3;
      ToolStripMenuItem4.Text = "-";
      miProjectProperties.Enabled = false;
      miProjectProperties.Index = 4;
      miProjectProperties.Text = "&Project Properties...";
      ToolStripMenuItem7.Index = 5;
      ToolStripMenuItem7.Text = "-";
      miExploreDebugFolder.Enabled = false;
      miExploreDebugFolder.Index = 6;
      miExploreDebugFolder.Text = "Open &Debug Folder";
      miExploreReleaseFolder.Enabled = false;
      miExploreReleaseFolder.Index = 7;
      miExploreReleaseFolder.Text = "Open &Release Folder";
      ToolStripMenuItem10.Index = 8;
      ToolStripMenuItem10.Text = "-";
      miQuit.Index = 9;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      ToolStripMenuItem6.Index = 1;
      ToolStripMenuItem6.ToolStripMenuItems.AddRange(new ToolStripMenuItem[7]
      {
        miBuildProject,
        ToolStripMenuItem3,
        miDebug,
        miRelease,
        ToolStripMenuItem8,
        miCleanDebugPrjFilesOnly,
        miCleanReleasePrjFilesOnly
      });
      ToolStripMenuItem6.Text = "&Build";
      miBuildProject.Enabled = false;
      miBuildProject.Index = 0;
      miBuildProject.Shortcut = Shortcut.F5;
      miBuildProject.Text = "B&uild Project";
      ToolStripMenuItem3.Index = 1;
      ToolStripMenuItem3.Text = "-";
      miDebug.Checked = true;
      miDebug.Index = 2;
      miDebug.Text = "&Debug";
      miRelease.Index = 3;
      miRelease.Text = "&Release";
      ToolStripMenuItem8.Index = 4;
      ToolStripMenuItem8.Text = "-";
      miCleanDebugPrjFilesOnly.Enabled = false;
      miCleanDebugPrjFilesOnly.Index = 5;
      miCleanDebugPrjFilesOnly.Text = "Clean Debug Directory - Project Files Only";
      miCleanReleasePrjFilesOnly.Enabled = false;
      miCleanReleasePrjFilesOnly.Index = 6;
      miCleanReleasePrjFilesOnly.Text = "Clean Release Directory - Project Files Only";
      tvcmOverrideRoot.ToolStripMenuItems.AddRange(new ToolStripMenuItem[2]
      {
        tvcmiOverrideRoot_Add,
        tvcmiOverrideRoot_RemoveAll
      });
      tvcmiOverrideRoot_Add.Index = 0;
      tvcmiOverrideRoot_Add.Text = "Add Files...";
      tvcmiOverrideRoot_RemoveAll.Enabled = false;
      tvcmiOverrideRoot_RemoveAll.Index = 1;
      tvcmiOverrideRoot_RemoveAll.Text = "Exclude All Files...";
      tvcmOverrideChild.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        tvcmiOverrideChild_Exclude
      });
      tvcmiOverrideChild_Exclude.Index = 0;
      tvcmiOverrideChild_Exclude.Text = "Exclude file from Project";
      tvcmModulesRoot.ToolStripMenuItems.AddRange(new ToolStripMenuItem[3]
      {
        tvcmiModulesRoot_Add,
        ToolStripMenuItem11,
        tvcmiModulesRoot_RemoveAllModules
      });
      tvcmiModulesRoot_Add.Index = 0;
      tvcmiModulesRoot_Add.Text = "Add New Package...";
      ToolStripMenuItem11.Index = 1;
      ToolStripMenuItem11.Text = "-";
      tvcmiModulesRoot_RemoveAllModules.Enabled = false;
      tvcmiModulesRoot_RemoveAllModules.Index = 2;
      tvcmiModulesRoot_RemoveAllModules.Text = "Remove All Packages...";
      ToolStripMenuItem5.Index = -1;
      ToolStripMenuItem5.Text = "-";
      tvcmLipsModulesRoot.ToolStripMenuItems.AddRange(new ToolStripMenuItem[3]
      {
        tvcmiLipsModulesRoot_Add,
        ToolStripMenuItem12,
        tvcmiLipsModulesRoot_RemoveAllModules
      });
      tvcmiLipsModulesRoot_Add.Index = 0;
      tvcmiLipsModulesRoot_Add.Text = "Add New Module...";
      ToolStripMenuItem12.Index = 1;
      ToolStripMenuItem12.Text = "-";
      tvcmiLipsModulesRoot_RemoveAllModules.Enabled = false;
      tvcmiLipsModulesRoot_RemoveAllModules.Index = 2;
      tvcmiLipsModulesRoot_RemoveAllModules.Text = "Remove All Modules...";
      tvcmModulesParent.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
      {
        tvcmiModulesParent_Add,
        tvcmiModulesParent_RemoveAll,
        tvcmiModulesParent_RenameSelf,
        tvcmiModulesParent_RemoveSelf,
        ToolStripMenuItem16,
        tvcmiModulesParent_Properties
      });
      tvcmiModulesParent_Add.Index = 0;
      tvcmiModulesParent_Add.Text = "Add Files...";
      tvcmiModulesParent_RemoveAll.Enabled = false;
      tvcmiModulesParent_RemoveAll.Index = 1;
      tvcmiModulesParent_RemoveAll.Text = "Exclude All Files...";
      tvcmiModulesParent_RenameSelf.Index = 2;
      tvcmiModulesParent_RenameSelf.Text = "Rename";
      tvcmiModulesParent_RemoveSelf.Index = 3;
      tvcmiModulesParent_RemoveSelf.Text = "Remove Package";
      ToolStripMenuItem16.Index = 4;
      ToolStripMenuItem16.Text = "-";
      tvcmiModulesParent_Properties.Index = 5;
      tvcmiModulesParent_Properties.Text = "Properties";
      ToolStripMenuItem2.Index = 2;
      ToolStripMenuItem2.Text = "-";
      ToolStripMenuItem9.Index = 4;
      ToolStripMenuItem9.Text = "-";
      tvcmLipsModulesParent.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
      {
        tvcmiLipsModulesParent_Add,
        tvcmiLipsModulesParent_RemoveAll,
        ToolStripMenuItem2,
        tvcmiLipsModulesParent_RenameSelf,
        ToolStripMenuItem9,
        tvcmiLipsModulesParent_RemoveSelf
      });
      tvcmiLipsModulesParent_Add.Index = 0;
      tvcmiLipsModulesParent_Add.Text = "Add Files...";
      tvcmiLipsModulesParent_RemoveAll.Enabled = false;
      tvcmiLipsModulesParent_RemoveAll.Index = 1;
      tvcmiLipsModulesParent_RemoveAll.Text = "Exclude All Files...";
      tvcmiLipsModulesParent_RenameSelf.Index = 3;
      tvcmiLipsModulesParent_RenameSelf.Text = "Rename";
      tvcmiLipsModulesParent_RemoveSelf.Index = 5;
      tvcmiLipsModulesParent_RemoveSelf.Text = "Remove Module";
      tvcmModulesChild.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        tvcmiModulesChild_Exclude
      });
      tvcmiModulesChild_Exclude.Index = 0;
      tvcmiModulesChild_Exclude.Text = "Exclude file from Project";
      tvcmLipsModulesChild.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        tvcmiLipsModulesChild_Exclude
      });
      tvcmiLipsModulesChild_Exclude.Index = 0;
      tvcmiLipsModulesChild_Exclude.Text = "Exclude file from Project";
      tvcmProjectRoot.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        tvcmiProperties
      });
      tvcmiProperties.Index = 0;
      tvcmiProperties.Text = "Properties";
      tvcmStreamWavesRoot.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
      {
        tvcmiStreamWavesRoot_AddFile,
        tvcmiStreamWavesRoot_AddModule,
        ToolStripMenuItem13,
        tvcmiStreamWavesRoot_RemoveAllFiles,
        tvcmiStreamWavesRoot_RemoveAllModules,
        tvcmiStreamWavesRoot_RemoveEverything
      });
      tvcmiStreamWavesRoot_AddFile.Index = 0;
      tvcmiStreamWavesRoot_AddFile.Text = "Add Files...";
      tvcmiStreamWavesRoot_AddModule.Index = 1;
      tvcmiStreamWavesRoot_AddModule.Text = "Add Module...";
      ToolStripMenuItem13.Index = 2;
      ToolStripMenuItem13.Text = "-";
      tvcmiStreamWavesRoot_RemoveAllFiles.Index = 3;
      tvcmiStreamWavesRoot_RemoveAllFiles.Text = "Remove all root-level files...";
      tvcmiStreamWavesRoot_RemoveAllModules.Index = 4;
      tvcmiStreamWavesRoot_RemoveAllModules.Text = "Remove All Modules...";
      tvcmiStreamWavesRoot_RemoveEverything.Index = 5;
      tvcmiStreamWavesRoot_RemoveEverything.Text = "Remove Everything...";
      tvcmStreamWavesModulesParent.ToolStripMenuItems.AddRange(new ToolStripMenuItem[6]
      {
        tvcmiStreamWavesModuleParent_AddFiles,
        tvcmiStreamWavesModuleParent_ExcludeAllFiles,
        ToolStripMenuItem14,
        tvcmiStreamWavesModuleParent_RenameSelf,
        ToolStripMenuItem15,
        tvcmiStreamWavesModulesParent_RemoveSelf
      });
      tvcmiStreamWavesModuleParent_AddFiles.Index = 0;
      tvcmiStreamWavesModuleParent_AddFiles.Text = "Add Files...";
      tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = false;
      tvcmiStreamWavesModuleParent_ExcludeAllFiles.Index = 1;
      tvcmiStreamWavesModuleParent_ExcludeAllFiles.Text = "Exclude All Files...";
      ToolStripMenuItem14.Index = 2;
      ToolStripMenuItem14.Text = "-";
      tvcmiStreamWavesModuleParent_RenameSelf.Index = 3;
      tvcmiStreamWavesModuleParent_RenameSelf.Text = "Rename";
      ToolStripMenuItem15.Index = 4;
      ToolStripMenuItem15.Text = "-";
      tvcmiStreamWavesModulesParent_RemoveSelf.Index = 5;
      tvcmiStreamWavesModulesParent_RemoveSelf.Text = "Remove Module";
      tvcmStreamWavesModulesChild.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        tvcmiStreamWavesModulesChild_ExcludeSelf
      });
      tvcmiStreamWavesModulesChild_ExcludeSelf.Index = 0;
      tvcmiStreamWavesModulesChild_ExcludeSelf.Text = "Exclude file from Project";
      tvcmStreamWavesFileChild.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        tvcmiStreamWavesFileChild_ExcludeSelf
      });
      tvcmiStreamWavesFileChild_ExcludeSelf.Index = 0;
      tvcmiStreamWavesFileChild_ExcludeSelf.Text = "Exclude file from Project";
      lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      lblStatus.BackColor = SystemColors.ActiveCaptionText;
      lblStatus.BorderStyle = BorderStyle.Fixed3D;
      lblStatus.FlatStyle = FlatStyle.System;
      Label lblStatus1 = lblStatus;
      point1 = new Point(12, 360);
      Point point3 = point1;
      lblStatus1.Location = point3;
      lblStatus.Name = "lblStatus";
      Label lblStatus2 = lblStatus;
      size1 = new Size(264, 32);
      Size size4 = size1;
      lblStatus2.Size = size4;
      lblStatus.TabIndex = 1;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(288, 401);
      ClientSize = size1;
      Controls.Add(lblStatus);
      Controls.Add(TreeView);
      Menu = MainMenu1;
      size1 = new Size(184, 232);
      MinimumSize = size1;
      Name = nameof (frmProjectManager);
      StartPosition = FormStartPosition.Manual;
      Text = "Project Manager";
      ResumeLayout(false);
    }

  private void frmProjectManager_Closing(object sender, CancelEventArgs e)
  {
      AskIfSaveProject();
      SaveSettings(GetType().Name);
    }

  private void TreeView_MouseDown(object sender, MouseEventArgs e)
  {
      LastClickedTVNode = TreeView.GetNodeAt(new Point(e.X, e.Y));
      TreeView.SelectedNode = LastClickedTVNode;
      if (e.Button != MouseButtons.Right)
        return;
      object tag = LastClickedTVNode.Tag;
      if (ObjectType.ObjTst(tag, "projectroot", false) == 0)
        tvcmProjectRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
      else if (ObjectType.ObjTst(tag, "overrideroot", false) == 0)
      {
        tvcmiOverrideRoot_RemoveAll.Enabled = Project.OverrideFiles.Count > 0;
        tvcmOverrideRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "overridechild", false) == 0)
        tvcmOverrideChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
      else if (ObjectType.ObjTst(tag, "moduleroot", false) == 0)
      {
        tvcmiModulesRoot_RemoveAllModules.Enabled = Project.Modules.Count > 0;
        tvcmModulesRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "moduleparent", false) == 0)
      {
        tvcmiModulesParent_RemoveAll.Enabled = Project.GetModuleFiles(LastClickedTVNode.Text).Count > 0;
        tvcmModulesParent.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "modulechild", false) == 0)
        tvcmModulesChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
      else if (ObjectType.ObjTst(tag, "lipsmoduleroot", false) == 0)
      {
        tvcmiLipsModulesRoot_RemoveAllModules.Enabled = Project.LipsModules.Count > 0;
        tvcmLipsModulesRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "lipsmoduleparent", false) == 0)
      {
        tvcmiLipsModulesParent_RemoveAll.Enabled = Project.GetLipsModuleFiles(LastClickedTVNode.Text).Count > 0;
        tvcmLipsModulesParent.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "lipsmodulechild", false) == 0)
        tvcmLipsModulesChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
      else if (ObjectType.ObjTst(tag, "streamwavesroot", false) == 0)
      {
        tvcmiStreamWavesRoot_RemoveAllFiles.Enabled = Project.StreamWavesFiles.Count > 0;
        tvcmiStreamWavesRoot_RemoveAllModules.Enabled = Project.StreamWavesModules.Count > 0;
        tvcmiStreamWavesRoot_RemoveEverything.Enabled = Project.StreamWavesFiles.Count > 0 || Project.StreamWavesModules.Count > 0;
        tvcmStreamWavesRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "streamwavesmoduleparent", false) == 0)
      {
        tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = Project.GetStreamWavesModuleFiles(LastClickedTVNode.Text).Count > 0;
        tvcmStreamWavesModulesParent.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else if (ObjectType.ObjTst(tag, "streamwavesmodulechild", false) == 0)
      {
        tvcmStreamWavesModulesChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
      else
      {
        if (ObjectType.ObjTst(tag, "streamwavesfilechild", false) != 0)
          return;
        tvcmStreamWavesFileChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
      }
    }

  private void TreeView_DoubleClick(object sender, EventArgs e)
  {
      ProjectFileItemTreeNode selectedNode = (ProjectFileItemTreeNode) TreeView.SelectedNode;
      if (ObjectType.ObjTst(selectedNode.Tag, "overridechild", false) != 0 && ObjectType.ObjTst(selectedNode.Tag, "modulechild", false) != 0 && ObjectType.ObjTst(selectedNode.Tag, "streamwavesfilechild", false) != 0 && ObjectType.ObjTst(selectedNode.Tag, "streamwavesmodulechild", false) != 0)
        return;
      string lower = Path.GetExtension(selectedNode.FilePath).ToLower();
      if (StringType.StrCmp(lower, ".nss", false) == 0 || StringType.StrCmp(lower, ".txt", false) == 0)
      {
        Options settings = UserSettings.GetSettings();
        if (settings.bProjMgrUseExternTxtEditor)
        {
          new Process()
          {
            StartInfo = {
              FileName = (settings.ProjMgrTxtEditorPath + " "),
              Arguments = selectedNode.FilePath
            }
          }.Start();
        }
        else
        {
          FileStream fileStream = new FileStream(selectedNode.FilePath, FileMode.Open);
          frmTextEditor frmTextEditor = new frmTextEditor(selectedNode.Filename);
          ASCIIEncoding asciiEncoding = new ASCIIEncoding();
          byte[] numArray = new byte[checked ((int) (fileStream.Length - 1L) + 1)];
          fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
          frmTextEditor.tbGeneric.Text = asciiEncoding.GetString(numArray);
          frmTextEditor.tbGeneric.SelectionLength = 0;
          fileStream.Close();
          frmTextEditor.Show();
        }
      }
      else if (StringType.StrCmp(lower, ".utc", false) == 0 || StringType.StrCmp(lower, ".utd", false) == 0 || StringType.StrCmp(lower, ".uti", false) == 0 || StringType.StrCmp(lower, ".utm", false) == 0 || StringType.StrCmp(lower, ".utp", false) == 0 || StringType.StrCmp(lower, ".utt", false) == 0)
      {
        MyParentForm.OpenGffFileInEditor(selectedNode.FilePath);
      }
      else
      {
        if (StringType.StrCmp(lower, ".dlg", false) != 0)
          return;
        Options settings = UserSettings.GetSettings();
        if (settings.bProjMgrUseExternDLGEditor)
          new Process()
          {
            StartInfo = {
              FileName = (settings.ProjMgrDLGEditorPath + " "),
              Arguments = selectedNode.FilePath
            }
          }.Start();
        else
          new frmDialogEditor(new FileStream(selectedNode.FilePath, FileMode.Open), KotorVersionIndex).Show();
      }
    }

  private void TreeView_DragDrop(object sender, DragEventArgs e)
  {
      ProjectFileItemTreeNode nodeAt = (ProjectFileItemTreeNode) TreeView.GetNodeAt(TreeView.PointToClient(new Point(e.X, e.Y)));
      string fullPath = nodeAt.FullPath;
      string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
      object tag = nodeAt.Tag;
      if (ObjectType.ObjTst(tag, "moduleparent", false) == 0)
      {
        Hashtable filesHashTable = ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
        int num1 = checked (data.Length - 1);
        int index = 0;
        while (index <= num1)
        {
          if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
          {
            int num2 = (int) Interaction.MsgBox("The file '" + data[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
          }
          else if (!filesHashTable.ContainsKey(data[index]))
          {
            Project.AddModuleFile(nodeAt.Text, data[index]);
            ProjectMgr.SaveProject();
          }
          checked { ++index; }
        }
      }
      else if (ObjectType.ObjTst(tag, "lipsmoduleparent", false) == 0)
      {
        Hashtable filesHashTable = ((ModuleFileEntry) Project.LipsModules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
        int num3 = checked (data.Length - 1);
        int index = 0;
        while (index <= num3)
        {
          if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
          {
            int num4 = (int) Interaction.MsgBox("The file '" + data[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
          }
          else if (!filesHashTable.ContainsKey(data[index]))
          {
            Project.AddLipsModuleFile(nodeAt.Text, data[index]);
            ProjectMgr.SaveProject();
          }
          checked { ++index; }
        }
      }
      else if (ObjectType.ObjTst(tag, "streamwavesmoduleparent", false) == 0)
      {
        Hashtable filesHashTable = ((ModuleFileEntry) Project.StreamWavesModules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
        int num5 = checked (data.Length - 1);
        int index = 0;
        while (index <= num5)
        {
          if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
          {
            int num6 = (int) Interaction.MsgBox("The file '" + data[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
          }
          else if (!filesHashTable.ContainsKey(data[index]))
          {
            Project.AddStreamWavesModuleFile(nodeAt.Text, data[index]);
            ProjectMgr.SaveProject();
          }
          checked { ++index; }
        }
      }
      else if (ObjectType.ObjTst(tag, "overrideroot", false) == 0)
      {
        Hashtable overrideFilesHashTable = Project.OverrideFilesHashTable;
        int num = checked (data.Length - 1);
        int index = 0;
        while (index <= num)
        {
          if (!overrideFilesHashTable.ContainsKey(data[index]))
            Project.OverrideFiles.Add(data[index]);
          checked { ++index; }
        }
        ProjectMgr.SaveProject();
      }
      else if (ObjectType.ObjTst(tag, "streamwavesroot", false) == 0)
      {
        Hashtable wavesFilesHashTable = Project.StreamWavesFilesHashTable;
        int num = checked (data.Length - 1);
        int index = 0;
        while (index <= num)
        {
          if (!wavesFilesHashTable.ContainsKey(data[index]))
            Project.StreamWavesFiles.Add(data[index]);
          checked { ++index; }
        }
        ProjectMgr.SaveProject();
      }
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void TreeView_DragOver(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      ProjectFileItemTreeNode nodeAt = (ProjectFileItemTreeNode) TreeView.GetNodeAt(TreeView.PointToClient(new Point(e.X, e.Y)));
      if (nodeAt == null)
        return;
      if (ObjectType.ObjTst(nodeAt.Tag, "overrideroot", false) == 0 || ObjectType.ObjTst(nodeAt.Tag, "moduleparent", false) == 0 || ObjectType.ObjTst(nodeAt.Tag, "lipsmoduleparent", false) == 0 || ObjectType.ObjTst(nodeAt.Tag, "streamwavesroot", false) == 0 || ObjectType.ObjTst(nodeAt.Tag, "streamwavesmoduleparent", false) == 0)
      {
        e.Effect = DragDropEffects.All;
        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Match: ", nodeAt.Tag), " "), DateAndTime.Now));
      }
      else
      {
        e.Effect = DragDropEffects.None;
        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("No match: ", nodeAt.Tag), " "), DateAndTime.Now));
      }
    }

  private void tvcmiProperties_Click(object sender, EventArgs e) => EditProjectProperties();

  private void tvcmiOverrideRoot_Add_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      object objectValue = RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", true));
      if (objectValue.GetType() == typeof (string))
        return;
      string[] strArray = (string[]) objectValue;
      Hashtable overrideFilesHashTable = Project.OverrideFilesHashTable;
      int num = checked (strArray.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (!overrideFilesHashTable.ContainsKey(strArray[index]))
          Project.OverrideFiles.Add(strArray[index]);
        checked { ++index; }
      }
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiOverrideChild_Exclude_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      Project.RemoveOverrideFile(((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiOverrideRoot_RemoveAll_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to exclude all of the files from Override?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllOverrideFiles();
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiModulesRoot_Add_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter name for new module";
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      Project.AddModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()));
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmModulesRoot_RemoveAllModules_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove all of the Packages from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      ProjectMgr.SaveProject();
      Project.RemoveAllModules();
      RefreshTreeView();
    }

  private void tvcmiModulesParent_RemoveSelf_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove the module '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveModule(LastClickedTVNode.Text.Trim());
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiModulesParent_Add_Click(object sender, EventArgs e)
  {
      object objectValue = RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", true));
      string fullPath = LastClickedTVNode.FullPath;
      if (objectValue.GetType() == typeof (string))
        return;
      string[] strArray = (string[]) objectValue;
      Hashtable filesHashTable = ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
      int num1 = checked (strArray.Length - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Path.GetFileNameWithoutExtension(strArray[index]).Length > 16)
        {
          int num2 = (int) Interaction.MsgBox("The file '" + strArray[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
        }
        else if (!filesHashTable.ContainsKey(strArray[index]))
          Project.AddModuleFile(LastClickedTVNode.Text, strArray[index]);
        checked { ++index; }
      }
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiModulesParent_RenameSelf_Click(object sender, EventArgs e)
  {
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter new name for package";
      frmPromptForString.tbValue.Text = LastClickedTVNode.Text;
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).ModuleName = frmPromptForString.tbValue.Text.Trim();
      LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim();
    }

  private void tvcmiModulesParent_RemoveAll_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to exclude all of the files from '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllModuleFiles(LastClickedTVNode.Text);
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiModulesParent_Properties_Click(object sender, EventArgs e)
  {
      frmPackageTypeSelector packageTypeSelector = new frmPackageTypeSelector(((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).PackageType);
      if (packageTypeSelector.ShowDialog(this) != DialogResult.OK)
        return;
      ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).PackageType = packageTypeSelector.PackageType;
    }

  private void tvcmiModulesChild_Exclude_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      Project.RemoveModuleFile(LastClickedTVNode.Parent.Text, ((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiLipsModulesRoot_Add_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter name for new module";
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      Project.AddLipsModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()));
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmLipsModulesRoot_RemoveAllModules_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove all of the Modules from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllLipsModules();
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiLipsModulesParent_RemoveSelf_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove the module '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveLipsModule(LastClickedTVNode.Text.Trim());
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiLipsModulesParent_Add_Click(object sender, EventArgs e)
  {
      object objectValue = RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", true));
      string fullPath = LastClickedTVNode.FullPath;
      if (objectValue.GetType() == typeof (string))
        return;
      string[] strArray = (string[]) objectValue;
      Hashtable filesHashTable = ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
      int num1 = checked (strArray.Length - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Path.GetFileNameWithoutExtension(strArray[index]).Length > 16)
        {
          int num2 = (int) Interaction.MsgBox("The file '" + strArray[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
        }
        else if (!filesHashTable.ContainsKey(strArray[index]))
          Project.AddLipsModuleFile(LastClickedTVNode.Text, strArray[index]);
        checked { ++index; }
      }
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiLipsModulesParent_RenameSelf_Click(object sender, EventArgs e)
  {
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter new name for module";
      frmPromptForString.tbValue.Text = LastClickedTVNode.Text;
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      ((ModuleFileEntry) Project.LipsModules[Project.GetLipsModuleIndex(LastClickedTVNode.Text)]).ModuleName = frmPromptForString.tbValue.Text.Trim();
      LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim();
    }

  private void tvcmiLipsModulesParent_RemoveAll_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to exclude all of the files from '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllLipsModuleFiles(LastClickedTVNode.Text);
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiLipsModulesChild_Exclude_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      Project.RemoveLipsModuleFile(LastClickedTVNode.Parent.Text, ((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiStreamWavesRoot_AddFile_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      object objectValue = RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", true));
      if (objectValue.GetType() == typeof (string))
        return;
      string[] strArray = (string[]) objectValue;
      Hashtable wavesFilesHashTable = Project.StreamWavesFilesHashTable;
      int num = checked (strArray.Length - 1);
      int index = 0;
      while (index <= num)
      {
        if (!wavesFilesHashTable.ContainsKey(strArray[index]))
          Project.StreamWavesFiles.Add(strArray[index]);
        checked { ++index; }
      }
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiStreamWavesRoot_AddModule_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter name for new module";
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      Project.AddStreamWavesModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()));
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiStreamWavesRoot_RemoveAllFiles_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to exclude all of the files?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllStreamWavesFiles();
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiStreamWavesRoot_RemoveAllModules_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove all of the StreamWaves Modules from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllStreamWavesModules();
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiStreamWavesRoot_RemoveEverything_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove everything (StreamWaves Modules and files) from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllStreamWavesModules();
      Project.RemoveAllStreamWavesFiles();
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiStreamWavesModuleParent_AddFiles_Click(object sender, EventArgs e)
  {
      object objectValue = RuntimeHelpers.GetObjectValue(FrmMain.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", true));
      string fullPath = LastClickedTVNode.FullPath;
      if (objectValue.GetType() == typeof (string))
        return;
      string[] strArray = (string[]) objectValue;
      Hashtable filesHashTable = ((ModuleFileEntry) Project.StreamWavesModules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
      int num1 = checked (strArray.Length - 1);
      int index = 0;
      while (index <= num1)
      {
        if (Path.GetFileNameWithoutExtension(strArray[index]).Length > 16)
        {
          int num2 = (int) Interaction.MsgBox("The file '" + strArray[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
        }
        else if (!filesHashTable.ContainsKey(strArray[index]))
          Project.AddStreamWavesModuleFile(LastClickedTVNode.Text, strArray[index]);
        checked { ++index; }
      }
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to exclude all of the files from '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveAllStreamWavesModuleFiles(LastClickedTVNode.Text);
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiStreamWavesModuleParent_RenameSelf_Click(object sender, EventArgs e)
  {
      frmPromptForString frmPromptForString = new frmPromptForString();
      frmPromptForString.lblMsg.Text = "Enter new name for module";
      frmPromptForString.tbValue.Text = LastClickedTVNode.Text;
      if (frmPromptForString.ShowDialog() != DialogResult.OK)
        return;
      ((ModuleFileEntry) Project.StreamWavesModules[Project.GetStreamWavesModuleIndex(LastClickedTVNode.Text)]).ModuleName = frmPromptForString.tbValue.Text.Trim();
      LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim();
    }

  private void tvcmiStreamWavesModulesParent_RemoveSelf_Click(object sender, EventArgs e)
  {
      if (Interaction.MsgBox("Are you sure you want to remove the module '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
        return;
      Project.RemoveStreamWavesModule(LastClickedTVNode.Text.Trim());
      ProjectMgr.SaveProject();
      RefreshTreeView();
    }

  private void tvcmiStreamWavesModulesChild_ExcludeSelf_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      Project.RemoveStreamWavesModuleFile(LastClickedTVNode.Parent.Text, ((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void tvcmiStreamWavesFileChild_ExcludeSelf_Click(object sender, EventArgs e)
  {
      string fullPath = LastClickedTVNode.FullPath;
      string text = LastClickedTVNode.Parent.Text;
      Project.RemoveStreamWavesFile(((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
      ProjectMgr.SaveProject();
      RefreshTreeView();
      OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
    }

  private void miNewPoject_Click(object sender, EventArgs e)
  {
      AskIfSaveProject();
      frmProjectManagerProperties managerProperties = new frmProjectManagerProperties();
      if (managerProperties.ShowDialog(this) != DialogResult.OK)
        return;
      InitialBrowsePath = "C:\\";
      ProjectFilePath = managerProperties.tbProjectPath.Text.Trim();
      ProjectMgr = new ClsProjectManager(ProjectFilePath, managerProperties.tbProjectName.Text.Trim());
      Project = ProjectMgr.Project;
      Project.DebugFilePath = managerProperties.tbReleasePath.Text;
      Project.ReleaseFilePath = managerProperties.tbReleasePath.Text.Trim();
      if (managerProperties.rbKotor1.Checked)
        Project.KotorVersionIndex = 0;
      if (managerProperties.rbKotor2.Checked)
        Project.KotorVersionIndex = 1;
      if (!Project.DebugFilePath.EndsWith("\\"))
        Project.DebugFilePath += "\\";
      if (!Project.ReleaseFilePath.EndsWith("\\"))
        Project.ReleaseFilePath += "\\";
      EnableMenus();
      BuildTreeRoots();
      RefreshTreeView();
      Text = "Project Manager - " + Path.GetFileName(ProjectMgr.ProjectFilePath);
    }

  private void miOpenProject_Click(object sender, EventArgs e)
  {
      AskIfSaveProject();
      string str = BrowseForProjectFile();
      if (!File.Exists(str))
        return;
      ClsProjectManager clsProjectManager = new ClsProjectManager(str);
      if (clsProjectManager.Project == null)
        return;
      ProjectMgr = clsProjectManager;
      Project = ProjectMgr.Project;
      BuildTreeRoots();
      RefreshTreeView();
      Text = "Project Manager - " + Path.GetFileName(ProjectMgr.ProjectFilePath);
      miProjectProperties.Enabled = true;
      if (!Project.DebugFilePath.EndsWith("\\"))
        Project.DebugFilePath += "\\";
      if (!Project.ReleaseFilePath.EndsWith("\\"))
        Project.ReleaseFilePath += "\\";
      EnableMenus();
    }

  private void miSaveProject_Click(object sender, EventArgs e)
  {
      if (Project == null)
        return;
      ProjectMgr.SaveProject();
    }

  private void miProjectProperties_Click(object sender, EventArgs e) => EditProjectProperties();

  private void miExploreDebugFolder_Click(object sender, EventArgs e) => new Process()
  {
    StartInfo = {
      FileName = "explorer.exe ",
      Arguments = Project.DebugFilePath
    }
  }.Start();

  private void miExploreReleaseFolder_Click(object sender, EventArgs e) => new Process()
  {
    StartInfo = {
      FileName = "explorer.exe ",
      Arguments = Project.ReleaseFilePath
    }
  }.Start();

  private void miDebug_Click(object sender, EventArgs e)
  {
      miDebug.Checked = true;
      miRelease.Checked = false;
      BuildMode = "debug";
    }

  private void miRelease_Click(object sender, EventArgs e)
  {
      miDebug.Checked = false;
      miRelease.Checked = true;
      BuildMode = "build";
    }

  private void miBuildProject_Click(object sender, EventArgs e)
  {
      FrmProgressMeter childForm = new FrmProgressMeter();
      utilWindowRelativePositioner relativePositioner = new utilWindowRelativePositioner(this, childForm);
      WorkingPath = Path.Combine(Project.DebugFilePath, "working");
      string str1 = StringType.StrCmp(BuildMode, "debug", false) != 0 ? Project.ReleaseFilePath : Project.DebugFilePath;
      ((Control) childForm).Location = relativePositioner.GetConcentric();
      childForm.Show();
      if (Project.OverrideFiles.Count > 0)
      {
        EnsureDirectoryExists(str1 + "Override\\");
        childForm.Message = "Copying Override files";
        childForm.StepAmount = 100 / Project.OverrideFiles.Count;
        try
        {
          foreach (object overrideFile in Project.OverrideFiles)
          {
            string str2 = StringType.FromObject(overrideFile);
            if (!str2.ToLower().EndsWith("nss"))
            {
              childForm.Status = "Copying " + Path.GetFileName(str2);
              File.Copy(str2, str1 + "override\\" + Path.GetFileName(str2), true);
            }
            else
            {
              childForm.Status = "Compiling Script: " + Path.GetFileName(str2);
              string str3 = null;
              try
              {
                str3 = CompileNSS(str2);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                if (Interaction.MsgBox("Override Script " + str2 + " failed to compile." + "\n" + "Error message:" + "\n" + exception.Message + "\n" + "Do you wish to continue compiling scripts?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Script compile failure") == MsgBoxResult.No)
                {
                  childForm.Close();
                  ProjectData.ClearProjectError();
                  return;
                }
                ProjectData.ClearProjectError();
              }
              if (StringType.StrCmp(str3, "", false) != 0)
              {
                File.Copy(str3, str1 + "override\\" + Path.GetFileName(str3), true);
                childForm.StepUp();
              }
            }
            childForm.StepUp();
          }
        }
        finally
        {
          
        }
      }
      ArrayList modules = Project.Modules;
      if (modules.Count > 0)
      {
        EnsureDirectoryExists(str1 + "Modules\\");
        EnsureDirectoryExists(WorkingPath);
        try
        {
          foreach (ModuleFileEntry moduleFileEntry in modules)
          {
            if (moduleFileEntry.ModuleFiles.Count > 0)
            {
              childForm.Progress = 0;
              childForm.Message = "Compiling Package: " + moduleFileEntry.ModuleName;
              childForm.StepAmount = 100 / moduleFileEntry.ModuleFiles.Count;
              string[] inputFileList = new string[checked (moduleFileEntry.ModuleFiles.Count - 1 + 1)];
              int num1 = checked (moduleFileEntry.ModuleFiles.Count - 1);
              int index = 0;
              while (index <= num1)
              {
                if (!moduleFileEntry.ModuleFiles[index].ToString().ToLower().EndsWith("nss"))
                {
                  childForm.Status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                  inputFileList[index] = StringType.FromObject(moduleFileEntry.ModuleFiles[index]);
                  childForm.StepUp();
                }
                else
                {
                  childForm.Status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                  string sLeft = CompileNSS(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                  if (StringType.StrCmp(sLeft, "", false) == 0)
                  {
                    int num2 = (int) Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry.ModuleName + ":", moduleFileEntry.ModuleFiles[index]), " failed to compile."), '\n'), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure");
                    return;
                  }
                  inputFileList[index] = sLeft;
                  childForm.StepUp();
                }
                checked { ++index; }
              }
              ClsErf clsErf = new ClsErf(str1 + "Modules\\" + moduleFileEntry.ModuleName + "." + moduleFileEntry.PackageType.ToLower(), moduleFileEntry.PackageType.ToUpper(), Convert.ToUInt32(0), null, inputFileList);
            }
          }
        }
        finally
        {
          
        }
      }
      ArrayList lipsModules = Project.LipsModules;
      if (lipsModules.Count > 0)
      {
        EnsureDirectoryExists(str1 + "Lips\\");
        EnsureDirectoryExists(WorkingPath);
        try
        {
          foreach (ModuleFileEntry moduleFileEntry in lipsModules)
          {
            if (moduleFileEntry.ModuleFiles.Count > 0)
            {
              childForm.Progress = 0;
              childForm.Message = "Compiling Module: " + moduleFileEntry.ModuleName;
              childForm.StepAmount = 100 / moduleFileEntry.ModuleFiles.Count;
              string[] inputFileList = new string[checked (moduleFileEntry.ModuleFiles.Count - 1 + 1)];
              int num3 = checked (moduleFileEntry.ModuleFiles.Count - 1);
              int index = 0;
              while (index <= num3)
              {
                if (!moduleFileEntry.ModuleFiles[index].ToString().ToLower().EndsWith("nss"))
                {
                  childForm.Status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                  inputFileList[index] = StringType.FromObject(moduleFileEntry.ModuleFiles[index]);
                  childForm.StepUp();
                }
                else
                {
                  childForm.Status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                  string sLeft = CompileNSS(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                  if (StringType.StrCmp(sLeft, "", false) == 0)
                  {
                    int num4 = (int) Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry.ModuleName + ":", moduleFileEntry.ModuleFiles[index]), " failed to compile."), '\n'), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure");
                    return;
                  }
                  inputFileList[index] = sLeft;
                  childForm.StepUp();
                }
                checked { ++index; }
              }
              ClsErf clsErf = new ClsErf(str1 + "Lips\\" + moduleFileEntry.ModuleName + ".mod", "MOD", Convert.ToUInt32(0), null, inputFileList);
            }
          }
        }
        finally
        {
         
        }
      }
      ArrayList streamWavesModules = Project.StreamWavesModules;
      if (streamWavesModules.Count > 0)
      {
        EnsureDirectoryExists(str1 + "StreamWaves\\");
        try
        {
          foreach (ModuleFileEntry moduleFileEntry in streamWavesModules)
          {
            if (moduleFileEntry.ModuleFiles.Count > 0)
            {
              EnsureDirectoryExists(str1 + "StreamWaves\\" + moduleFileEntry.ModuleName + "\\");
              childForm.Progress = 0;
              childForm.Message = "Copying Module: " + moduleFileEntry.ModuleName;
              childForm.StepAmount = 100 / moduleFileEntry.ModuleFiles.Count;
              int num = checked (moduleFileEntry.ModuleFiles.Count - 1);
              int index = 0;
              while (index <= num)
              {
                childForm.Status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                File.Copy(StringType.FromObject(moduleFileEntry.ModuleFiles[index]), str1 + "StreamWaves\\" + moduleFileEntry.ModuleName + "\\" + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index])), true);
                checked { ++index; }
              }
            }
          }
        }
        finally
        {
         
        }
      }
      if (Project.StreamWavesFiles.Count > 0)
      {
        childForm.Message = "Copying StreamWaves files";
        childForm.StepAmount = 100 / Project.StreamWavesFiles.Count;
        try
        {
          foreach (object streamWavesFile in Project.StreamWavesFiles)
          {
            string str4 = StringType.FromObject(streamWavesFile);
            childForm.Status = "Copying " + Path.GetFileName(str4);
            File.Copy(str4, str1 + "StreamWaves\\" + Path.GetFileName(str4), true);
            childForm.StepUp();
          }
        }
        finally
        {
         
        }
      }
      childForm.Close();
    }

  private void miQuit_Click(object sender, EventArgs e) => Close();

  private void miCleanDebugPrjFilesOnly_Click(object sender, EventArgs e) => CleanProjectFilesFromDir(Project.DebugFilePath);

  private void miCleanReleasePrjFilesOnly_Click(object sender, EventArgs e) => CleanProjectFilesFromDir(Project.ReleaseFilePath);

  private void AskIfSaveProject()
  {
      if (Project == null || Interaction.MsgBox("Save Project before closing?", MsgBoxStyle.YesNo, "") != MsgBoxResult.Yes)
        return;
      ProjectMgr.SaveProject();
    }

  private void EnableMenus()
  {
      miProjectProperties.Enabled = true;
      miExploreDebugFolder.Enabled = true;
      miExploreReleaseFolder.Enabled = true;
      miSaveProject.Enabled = true;
      miBuildProject.Enabled = true;
      miCleanDebugPrjFilesOnly.Enabled = true;
      miCleanReleasePrjFilesOnly.Enabled = true;
    }

  private void BuildTreeRoots()
  {
      TreeView.Nodes.Clear();
      TreeView.Nodes.AddRange(new ProjectFileItemTreeNode[1]
      {
        new ProjectFileItemTreeNode("Project", new ProjectFileItemTreeNode[4]
        {
          new ProjectFileItemTreeNode("Overrides"),
          new ProjectFileItemTreeNode("Packages"),
          new ProjectFileItemTreeNode("Lips Modules"),
          new ProjectFileItemTreeNode("StreamWaves")
        })
      });
      TreeView.Nodes[0].Nodes[0].Tag = "overrideroot";
      TreeView.Nodes[0].Nodes[1].Tag = "moduleroot";
      TreeView.Nodes[0].Nodes[2].Tag = "lipsmoduleroot";
      TreeView.Nodes[0].Nodes[3].Tag = "streamwavesroot";
      TreeView.Nodes[0].Nodes[0].ImageIndex = 2;
      TreeView.Nodes[0].Nodes[1].ImageIndex = 2;
      TreeView.Nodes[0].Nodes[2].ImageIndex = 2;
      TreeView.Nodes[0].Nodes[3].ImageIndex = 2;
      TreeView.Nodes[0].Nodes[0].SelectedImageIndex = 2;
      TreeView.Nodes[0].Nodes[1].SelectedImageIndex = 2;
      TreeView.Nodes[0].Nodes[2].SelectedImageIndex = 2;
      TreeView.Nodes[0].Nodes[3].SelectedImageIndex = 2;
      TreeView.Nodes[0].Text = "projectroot";
      TreeView.Nodes[0].Expand();
    }

  private void RefreshTreeView()
  {
      TreeView.BeginUpdate();
      TreeView.Nodes[0].Nodes[0].Nodes.Clear();
      TreeView.Nodes[0].Nodes[1].Nodes.Clear();
      TreeView.Nodes[0].Nodes[2].Nodes.Clear();
      TreeView.Nodes[0].Nodes[3].Nodes.Clear();
      TreeView.Nodes[0].Text = Project.Name;
      TreeView.Nodes[0].Tag = "projectroot";
      TreeView.Nodes[0].ImageIndex = 0;
      TreeView.Nodes[0].SelectedImageIndex = TreeView.Nodes[0].ImageIndex;
      Project.OverrideFiles.Sort();
      try
      {
        foreach (object overrideFile in Project.OverrideFiles)
        {
          string path = StringType.FromObject(overrideFile);
          ProjectFileItemTreeNode node = new ProjectFileItemTreeNode(Path.GetFileName(path));
          node.Tag = "overridechild";
          node.ImageIndex = 1;
          node.SelectedImageIndex = node.ImageIndex;
          node.FilePath = path;
          TreeView.Nodes[0].Nodes[0].Nodes.Add(node);
        }
      }
      finally
      {
        
      }
      ArrayList modules = Project.Modules;
      try
      {
        foreach (ModuleFileEntry moduleFileEntry in modules)
        {
          ProjectFileItemTreeNode node1 = new ProjectFileItemTreeNode(moduleFileEntry.ModuleName);
          node1.Tag = "moduleparent";
          node1.ImageIndex = 2;
          node1.SelectedImageIndex = node1.ImageIndex;
          moduleFileEntry.ModuleFiles.Sort();
          try
          {
            foreach (object moduleFile in moduleFileEntry.ModuleFiles)
            {
              string path = StringType.FromObject(moduleFile);
              ProjectFileItemTreeNode node2 = new ProjectFileItemTreeNode(Path.GetFileName(path));
              node2.Tag = "modulechild";
              node2.ImageIndex = 1;
              node2.SelectedImageIndex = node2.ImageIndex;
              node2.FilePath = path;
              node1.Nodes.Add(node2);
            }
          }
          finally
          {
          
          }
          TreeView.Nodes[0].Nodes[1].Nodes.Add(node1);
        }
      }
      finally
      {
       
      }
      ArrayList lipsModules = Project.LipsModules;
      try
      {
        foreach (ModuleFileEntry moduleFileEntry in lipsModules)
        {
          ProjectFileItemTreeNode node3 = new ProjectFileItemTreeNode(moduleFileEntry.ModuleName);
          node3.Tag = "lipsmoduleparent";
          node3.ImageIndex = 2;
          node3.SelectedImageIndex = node3.ImageIndex;
          moduleFileEntry.ModuleFiles.Sort();
          try
          {
            foreach (object moduleFile in moduleFileEntry.ModuleFiles)
            {
              string path = StringType.FromObject(moduleFile);
              ProjectFileItemTreeNode node4 = new ProjectFileItemTreeNode(Path.GetFileName(path));
              node4.Tag = "lipsmodulechild";
              node4.ImageIndex = 1;
              node4.SelectedImageIndex = node4.ImageIndex;
              node4.FilePath = path;
              node3.Nodes.Add(node4);
            }
          }
          finally
          {
           
          }
          TreeView.Nodes[0].Nodes[2].Nodes.Add(node3);
        }
      }
      finally
      {
       
      }
      ArrayList streamWavesModules = Project.StreamWavesModules;
      try
      {
        foreach (ModuleFileEntry moduleFileEntry in streamWavesModules)
        {
          ProjectFileItemTreeNode node5 = new ProjectFileItemTreeNode(moduleFileEntry.ModuleName);
          node5.Tag = "streamwavesmoduleparent";
          node5.ImageIndex = 2;
          node5.SelectedImageIndex = node5.ImageIndex;
          moduleFileEntry.ModuleFiles.Sort();
          try
          {
            foreach (object moduleFile in moduleFileEntry.ModuleFiles)
            {
              string path = StringType.FromObject(moduleFile);
              ProjectFileItemTreeNode node6 = new ProjectFileItemTreeNode(Path.GetFileName(path));
              node6.Tag = "streamwavesmodulechild";
              node6.ImageIndex = 1;
              node6.SelectedImageIndex = node6.ImageIndex;
              node6.FilePath = path;
              node5.Nodes.Add(node6);
            }
          }
          finally
          {
           
          }
          TreeView.Nodes[0].Nodes[3].Nodes.Add(node5);
        }
      }
      finally
      {
        
      }
      Project.StreamWavesFiles.Sort();
      try
      {
        foreach (object streamWavesFile in Project.StreamWavesFiles)
        {
          string path = StringType.FromObject(streamWavesFile);
          ProjectFileItemTreeNode node = new ProjectFileItemTreeNode(Path.GetFileName(path));
          node.Tag = "streamwavesfilechild";
          node.ImageIndex = 1;
          node.SelectedImageIndex = node.ImageIndex;
          node.FilePath = path;
          TreeView.Nodes[0].Nodes[3].Nodes.Add(node);
        }
      }
      finally
      {
       
      }
      TreeView.EndUpdate();
    }

  private void EditProjectProperties()
  {
      frmProjectManagerProperties managerProperties = new frmProjectManagerProperties("edit");
      managerProperties.tbProjectName.Text = Project.Name;
      managerProperties.tbProjectPath.Text = ProjectMgr.ProjectFilePath;
      managerProperties.tbDebugPath.Text = Project.DebugFilePath;
      managerProperties.tbReleasePath.Text = Project.ReleaseFilePath;
      managerProperties.rbKotor1.Checked = Project.KotorVersionIndex == 0;
      managerProperties.rbKotor2.Checked = Project.KotorVersionIndex == 1;
      if (managerProperties.ShowDialog(this) != DialogResult.OK)
        return;
      if (StringType.StrCmp(managerProperties.tbProjectName.Text.Trim(), Project.Name, false) != 0)
      {
        Project.Name = managerProperties.tbProjectName.Text.Trim();
        TreeView.Nodes[0].Text = managerProperties.tbProjectName.Text.Trim();
      }
      ProjectMgr.ProjectFilePath = managerProperties.tbProjectPath.Text.Trim();
      Text = "Project Manager - " + Path.GetFileName(managerProperties.tbProjectPath.Text.Trim());
      Project.DebugFilePath = managerProperties.tbDebugPath.Text.Trim();
      Project.ReleaseFilePath = managerProperties.tbReleasePath.Text.Trim();
      if (!Project.DebugFilePath.EndsWith("\\"))
        Project.DebugFilePath += "\\";
      if (!Project.ReleaseFilePath.EndsWith("\\"))
        Project.ReleaseFilePath += "\\";
      if (managerProperties.rbKotor1.Checked)
        Project.KotorVersionIndex = 0;
      if (!managerProperties.rbKotor2.Checked)
        return;
      Project.KotorVersionIndex = 1;
    }

  public void OpenTreeViewToPath(string treepath, TreeNode currNode, int currLevel)
  {
      string[] strArray = Strings.Split(treepath, "\\");
      if (currLevel == strArray.Length)
        return;
      try
      {
        foreach (TreeNode node in currNode.Nodes)
        {
          if (StringType.StrCmp(node.Text, strArray[currLevel], false) == 0)
          {
            node.Expand();
            OpenTreeViewToPath(treepath, node, checked (currLevel + 1));
          }
        }
      }
      finally
      {
        
      }
    }

  private string BrowseForProjectFile()
  {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Select project file...";
      openFileDialog.Filter = "Kotor Tool Project (*.ktp)|*.ktp";
      openFileDialog.CheckFileExists = true;
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.FileName = "*.ktp";
      string str = null;
      return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : str;
    }

  public void EnsureDirectoryExists(object dirPath)
  {
      if (Directory.Exists(StringType.FromObject(dirPath)))
        return;
      Directory.CreateDirectory(StringType.FromObject(dirPath));
    }

  private string CompileNSS(string sourcefilepath)
  {
      string str = "-g " + Convert.ToString(checked (Project.KotorVersionIndex + 1));
      string path = WorkingPath + "\\" + Path.GetFileNameWithoutExtension(sourcefilepath) + ".ncs";
      EnsureDirectoryExists(WorkingPath);
      if (File.Exists(path))
        File.Delete(path);
      Process process = new Process();
      process.StartInfo.FileName = FrmMain.GRootPath + "nwnnsscomp.exe";
      process.StartInfo.UseShellExecute = false;
      process.StartInfo.CreateNoWindow = true;
      process.StartInfo.Arguments = "-c " + str + " -o " + "\"" + path + "\"" + " " + "\"" + sourcefilepath + "\"";
      process.StartInfo.RedirectStandardOutput = true;
      process.Start();
      string end = process.StandardOutput.ReadToEnd();
      process.WaitForExit(4000);
      if (end.IndexOf("Error") == -1)
        return path;
      throw new NSSCompilerException(end);
    }

  private void CleanProjectFilesFromDir(string dirname)
  {
      try
      {
        foreach (object overrideFile in Project.OverrideFiles)
        {
          string path = StringType.FromObject(overrideFile);
          try
          {
            File.Delete(dirname + "override\\" + Path.GetFileName(path));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        
      }
      try
      {
        foreach (ModuleFileEntry module in Project.Modules)
        {
          try
          {
            File.Delete(dirname + "modules\\" + module.ModuleName + ".mod");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
       
      }
      try
      {
        foreach (ModuleFileEntry lipsModule in Project.LipsModules)
        {
          try
          {
            File.Delete(dirname + "lips\\" + lipsModule.ModuleName + ".mod");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
       
      }
      try
      {
        foreach (ModuleFileEntry streamWavesModule in Project.StreamWavesModules)
        {
          try
          {
            foreach (object moduleFile in streamWavesModule.ModuleFiles)
            {
              string path = StringType.FromObject(moduleFile);
              try
              {
                File.Delete(dirname + "StreamWaves\\" + streamWavesModule.ModuleName + "\\" + Path.GetFileName(path));
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
              }
            }
          }
          finally
          {
            
          }
          try
          {
            Directory.Delete(dirname + "StreamWaves\\" + streamWavesModule.ModuleName + "\\");
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
       
      }
      try
      {
        foreach (object streamWavesFile in Project.StreamWavesFiles)
        {
          string path = StringType.FromObject(streamWavesFile);
          try
          {
            File.Delete(dirname + "StreamWaves\\" + Path.GetFileName(path));
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
       
      }
    }

  private void TreeView_MouseMove(object sender, MouseEventArgs e)
  {
      ProjectFileItemTreeNode nodeAt = (ProjectFileItemTreeNode) TreeView.GetNodeAt(TreeView.PointToClient(MousePosition));
      if (nodeAt == null)
        return;
      lblStatus.Text = nodeAt.FilePath;
    }

  private void TreeView_MouseLeave(object sender, EventArgs e) => lblStatus.Text = "";

  private void frmProjectManager_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private class NSSCompilerException : Exception
  {
    public NSSCompilerException(object Message)
      : base(StringType.FromObject(Message))
    {
      }
  }
}