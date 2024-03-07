// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmOptions
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmOptions : Form
{
  [AccessedThroughProperty("btnBrowseProjMgrDLGEditorPath")]
  private Button _btnBrowseProjMgrDLGEditorPath;
  [AccessedThroughProperty("rbProjMgrUseExternTxtEditor")]
  private RadioButton _rbProjMgrUseExternTxtEditor;
  [AccessedThroughProperty("rbProjMgrUseExternDLGEditor")]
  private RadioButton _rbProjMgrUseExternDLGEditor;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("btnBrowseProjMgrTxtEditorPath")]
  private Button _btnBrowseProjMgrTxtEditorPath;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("tabpagProjectManager")]
  private TabPage _tabpagProjectManager;
  [AccessedThroughProperty("tabpagOther")]
  private TabPage _tabpagOther;
  [AccessedThroughProperty("tabpagTreeview")]
  private TabPage _tabpagTreeview;
  [AccessedThroughProperty("chkbRememberTreeViewState")]
  private CheckBox _chkbRememberTreeViewState;
  [AccessedThroughProperty("chkbUseOverrideFiles")]
  private CheckBox _chkbUseOverrideFiles;
  [AccessedThroughProperty("chkbRememberLastTreeNode")]
  private CheckBox _chkbRememberLastTreeNode;
  [AccessedThroughProperty("chkbDownloadUpdatesAutomatically")]
  private CheckBox _chkbDownloadUpdatesAutomatically;
  [AccessedThroughProperty("chkbCheckForUpdatesAtStartup")]
  private CheckBox _chkbCheckForUpdatesAtStartup;
  [AccessedThroughProperty("chkbShowModuleDescriptions")]
  private CheckBox _chkbShowModuleDescriptions;
  [AccessedThroughProperty("tbProjMgrTxtEditorPath")]
  private TextBox _tbProjMgrTxtEditorPath;
  [AccessedThroughProperty("chkbShowModuleLocations")]
  private CheckBox _chkbShowModuleLocations;
  [AccessedThroughProperty("rbProjMgrUseInternDLGEditor")]
  private RadioButton _rbProjMgrUseInternDLGEditor;
  [AccessedThroughProperty("chkbAlwaysUnknownGFFasText")]
  private CheckBox _chkbAlwaysUnknownGFFasText;
  [AccessedThroughProperty("rbProjMgrUseInternTxtEditor")]
  private RadioButton _rbProjMgrUseInternTxtEditor;
  [AccessedThroughProperty("btnOK")]
  private Button _btnOK;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("chkbBuildBIFTreeAtStartup")]
  private CheckBox _chkbBuildBIFTreeAtStartup;
  [AccessedThroughProperty("tbProjMgrDLGEditorPath")]
  private TextBox _tbProjMgrDLGEditorPath;
  [AccessedThroughProperty("chkbAlwaysConvertTPC2TGA")]
  private CheckBox _chkbAlwaysConvertTPC2TGA;
  [AccessedThroughProperty("chkbDockImageViewer")]
  private CheckBox _chkbDockImageViewer;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("chkbTextEditorWordWrap")]
  private CheckBox _chkbTextEditorWordWrap;
  [AccessedThroughProperty("chkbBuildModelsBifNode")]
  private CheckBox _chkbBuildModelsBifNode;
  private IContainer components;
  private Options options;

  public frmOptions()
  {
      InitializeComponent();
      Setup();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Button btnOK
  {
    get => _btnOK;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnOK != null)
          _btnOK.Click -= new EventHandler(btnOK_Click);
        _btnOK = value;
        if (_btnOK == null)
          return;
        _btnOK.Click += new EventHandler(btnOK_Click);
      }
  }

  internal virtual Button btnCancel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel == null)
          ;
        _btnCancel = value;
        if (_btnCancel == null)
          ;
      }
    get => _btnCancel;
  }

  internal virtual CheckBox chkbBuildBIFTreeAtStartup
  {
    get => _chkbBuildBIFTreeAtStartup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbBuildBIFTreeAtStartup == null)
          ;
        _chkbBuildBIFTreeAtStartup = value;
        if (_chkbBuildBIFTreeAtStartup == null)
          ;
      }
  }

  internal virtual CheckBox chkbAlwaysConvertTPC2TGA
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbAlwaysConvertTPC2TGA == null)
          ;
        _chkbAlwaysConvertTPC2TGA = value;
        if (_chkbAlwaysConvertTPC2TGA == null)
          ;
      }
    get => _chkbAlwaysConvertTPC2TGA;
  }

  internal virtual CheckBox chkbDockImageViewer
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbDockImageViewer == null)
          ;
        _chkbDockImageViewer = value;
        if (_chkbDockImageViewer == null)
          ;
      }
    get => _chkbDockImageViewer;
  }

  internal virtual CheckBox chkbTextEditorWordWrap
  {
    get => _chkbTextEditorWordWrap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTextEditorWordWrap == null)
          ;
        _chkbTextEditorWordWrap = value;
        if (_chkbTextEditorWordWrap == null)
          ;
      }
  }

  internal virtual CheckBox chkbBuildModelsBifNode
  {
    get => _chkbBuildModelsBifNode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbBuildModelsBifNode == null)
          ;
        _chkbBuildModelsBifNode = value;
        if (_chkbBuildModelsBifNode == null)
          ;
      }
  }

  internal virtual CheckBox chkbAlwaysUnknownGFFasText
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbAlwaysUnknownGFFasText == null)
          ;
        _chkbAlwaysUnknownGFFasText = value;
        if (_chkbAlwaysUnknownGFFasText == null)
          ;
      }
    get => _chkbAlwaysUnknownGFFasText;
  }

  internal virtual TabControl TabControl1
  {
    get => _TabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl1 == null)
          ;
        _TabControl1 = value;
        if (_TabControl1 == null)
          ;
      }
  }

  internal virtual CheckBox chkbShowModuleLocations
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbShowModuleLocations == null)
          ;
        _chkbShowModuleLocations = value;
        if (_chkbShowModuleLocations == null)
          ;
      }
    get => _chkbShowModuleLocations;
  }

  internal virtual CheckBox chkbShowModuleDescriptions
  {
    get => _chkbShowModuleDescriptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbShowModuleDescriptions == null)
          ;
        _chkbShowModuleDescriptions = value;
        if (_chkbShowModuleDescriptions == null)
          ;
      }
  }

  internal virtual CheckBox chkbCheckForUpdatesAtStartup
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbCheckForUpdatesAtStartup != null)
          _chkbCheckForUpdatesAtStartup.CheckedChanged -= new EventHandler(chkbCheckForUpdatesAtStartup_CheckedChanged);
        _chkbCheckForUpdatesAtStartup = value;
        if (_chkbCheckForUpdatesAtStartup == null)
          return;
        _chkbCheckForUpdatesAtStartup.CheckedChanged += new EventHandler(chkbCheckForUpdatesAtStartup_CheckedChanged);
      }
    get => _chkbCheckForUpdatesAtStartup;
  }

  internal virtual CheckBox chkbDownloadUpdatesAutomatically
  {
    get => _chkbDownloadUpdatesAutomatically;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbDownloadUpdatesAutomatically == null)
          ;
        _chkbDownloadUpdatesAutomatically = value;
        if (_chkbDownloadUpdatesAutomatically == null)
          ;
      }
  }

  internal virtual CheckBox chkbRememberLastTreeNode
  {
    get => _chkbRememberLastTreeNode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbRememberLastTreeNode == null)
          ;
        _chkbRememberLastTreeNode = value;
        if (_chkbRememberLastTreeNode == null)
          ;
      }
  }

  internal virtual CheckBox chkbUseOverrideFiles
  {
    get => _chkbUseOverrideFiles;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbUseOverrideFiles == null)
          ;
        _chkbUseOverrideFiles = value;
        if (_chkbUseOverrideFiles == null)
          ;
      }
  }

  internal virtual CheckBox chkbRememberTreeViewState
  {
    get => _chkbRememberTreeViewState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbRememberTreeViewState == null)
          ;
        _chkbRememberTreeViewState = value;
        if (_chkbRememberTreeViewState == null)
          ;
      }
  }

  internal virtual TabPage tabpagTreeview
  {
    get => _tabpagTreeview;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagTreeview == null)
          ;
        _tabpagTreeview = value;
        if (_tabpagTreeview == null)
          ;
      }
  }

  internal virtual TabPage tabpagOther
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagOther == null)
          ;
        _tabpagOther = value;
        if (_tabpagOther == null)
          ;
      }
    get => _tabpagOther;
  }

  internal virtual TabPage tabpagProjectManager
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagProjectManager == null)
          ;
        _tabpagProjectManager = value;
        if (_tabpagProjectManager == null)
          ;
      }
    get => _tabpagProjectManager;
  }

  internal virtual GroupBox GroupBox1
  {
    get => _GroupBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox1 == null)
          ;
        _GroupBox1 = value;
        if (_GroupBox1 == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox2
  {
    get => _GroupBox2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox2 == null)
          ;
        _GroupBox2 = value;
        if (_GroupBox2 == null)
          ;
      }
  }

  internal virtual RadioButton rbProjMgrUseExternDLGEditor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbProjMgrUseExternDLGEditor != null)
          _rbProjMgrUseExternDLGEditor.CheckedChanged -= new EventHandler(rbProjMgrUseExternDLGEditor_CheckedChanged);
        _rbProjMgrUseExternDLGEditor = value;
        if (_rbProjMgrUseExternDLGEditor == null)
          return;
        _rbProjMgrUseExternDLGEditor.CheckedChanged += new EventHandler(rbProjMgrUseExternDLGEditor_CheckedChanged);
      }
    get => _rbProjMgrUseExternDLGEditor;
  }

  internal virtual RadioButton rbProjMgrUseExternTxtEditor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbProjMgrUseExternTxtEditor != null)
          _rbProjMgrUseExternTxtEditor.CheckedChanged -= new EventHandler(rbProjMgrUseExternTxtEditor_CheckedChanged_1);
        _rbProjMgrUseExternTxtEditor = value;
        if (_rbProjMgrUseExternTxtEditor == null)
          return;
        _rbProjMgrUseExternTxtEditor.CheckedChanged += new EventHandler(rbProjMgrUseExternTxtEditor_CheckedChanged_1);
      }
    get => _rbProjMgrUseExternTxtEditor;
  }

  internal virtual Button btnBrowseProjMgrDLGEditorPath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnBrowseProjMgrDLGEditorPath != null)
          _btnBrowseProjMgrDLGEditorPath.Click -= new EventHandler(btnBrowseProjMgrDLGEditorPath_Click);
        _btnBrowseProjMgrDLGEditorPath = value;
        if (_btnBrowseProjMgrDLGEditorPath == null)
          return;
        _btnBrowseProjMgrDLGEditorPath.Click += new EventHandler(btnBrowseProjMgrDLGEditorPath_Click);
      }
    get => _btnBrowseProjMgrDLGEditorPath;
  }

  internal virtual TextBox tbProjMgrDLGEditorPath
  {
    get => _tbProjMgrDLGEditorPath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbProjMgrDLGEditorPath == null)
          ;
        _tbProjMgrDLGEditorPath = value;
        if (_tbProjMgrDLGEditorPath == null)
          ;
      }
  }

  internal virtual Button btnBrowseProjMgrTxtEditorPath
  {
    get => _btnBrowseProjMgrTxtEditorPath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnBrowseProjMgrTxtEditorPath != null)
          _btnBrowseProjMgrTxtEditorPath.Click -= new EventHandler(btnBrowseProjMgrTxtEditorPath_Click);
        _btnBrowseProjMgrTxtEditorPath = value;
        if (_btnBrowseProjMgrTxtEditorPath == null)
          return;
        _btnBrowseProjMgrTxtEditorPath.Click += new EventHandler(btnBrowseProjMgrTxtEditorPath_Click);
      }
  }

  internal virtual TextBox tbProjMgrTxtEditorPath
  {
    get => _tbProjMgrTxtEditorPath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbProjMgrTxtEditorPath == null)
          ;
        _tbProjMgrTxtEditorPath = value;
        if (_tbProjMgrTxtEditorPath == null)
          ;
      }
  }

  internal virtual RadioButton rbProjMgrUseInternDLGEditor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbProjMgrUseInternDLGEditor == null)
          ;
        _rbProjMgrUseInternDLGEditor = value;
        if (_rbProjMgrUseInternDLGEditor == null)
          ;
      }
    get => _rbProjMgrUseInternDLGEditor;
  }

  internal virtual RadioButton rbProjMgrUseInternTxtEditor
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbProjMgrUseInternTxtEditor == null)
          ;
        _rbProjMgrUseInternTxtEditor = value;
        if (_rbProjMgrUseInternTxtEditor == null)
          ;
      }
    get => _rbProjMgrUseInternTxtEditor;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmOptions));
      btnOK = new Button();
      chkbBuildBIFTreeAtStartup = new CheckBox();
      this.btnCancel = new Button();
      chkbAlwaysConvertTPC2TGA = new CheckBox();
      chkbDockImageViewer = new CheckBox();
      chkbTextEditorWordWrap = new CheckBox();
      chkbBuildModelsBifNode = new CheckBox();
      chkbAlwaysUnknownGFFasText = new CheckBox();
      TabControl1 = new TabControl();
      tabpagTreeview = new TabPage();
      chkbShowModuleLocations = new CheckBox();
      chkbShowModuleDescriptions = new CheckBox();
      chkbRememberLastTreeNode = new CheckBox();
      chkbRememberTreeViewState = new CheckBox();
      tabpagProjectManager = new TabPage();
      GroupBox1 = new GroupBox();
      btnBrowseProjMgrDLGEditorPath = new Button();
      tbProjMgrDLGEditorPath = new TextBox();
      rbProjMgrUseInternDLGEditor = new RadioButton();
      rbProjMgrUseExternDLGEditor = new RadioButton();
      GroupBox2 = new GroupBox();
      rbProjMgrUseInternTxtEditor = new RadioButton();
      tbProjMgrTxtEditorPath = new TextBox();
      rbProjMgrUseExternTxtEditor = new RadioButton();
      btnBrowseProjMgrTxtEditorPath = new Button();
      tabpagOther = new TabPage();
      chkbCheckForUpdatesAtStartup = new CheckBox();
      chkbDownloadUpdatesAutomatically = new CheckBox();
      chkbUseOverrideFiles = new CheckBox();
      TabControl1.SuspendLayout();
      tabpagTreeview.SuspendLayout();
      tabpagProjectManager.SuspendLayout();
      GroupBox1.SuspendLayout();
      GroupBox2.SuspendLayout();
      tabpagOther.SuspendLayout();
      SuspendLayout();
      btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnOK.DialogResult = DialogResult.OK;
      Button btnOk = btnOK;
      Point point1 = new Point(232, 352);
      Point point2 = point1;
      btnOk.Location = point2;
      btnOK.Name = "btnOK";
      btnOK.TabIndex = 6;
      btnOK.Text = "OK";
      CheckBox bifTreeAtStartup1 = chkbBuildBIFTreeAtStartup;
      point1 = new Point(32, 16);
      Point point3 = point1;
      bifTreeAtStartup1.Location = point3;
      chkbBuildBIFTreeAtStartup.Name = "chkbBuildBIFTreeAtStartup";
      CheckBox bifTreeAtStartup2 = chkbBuildBIFTreeAtStartup;
      Size size1 = new Size(160, 24);
      Size size2 = size1;
      bifTreeAtStartup2.Size = size2;
      chkbBuildBIFTreeAtStartup.TabIndex = 0;
      chkbBuildBIFTreeAtStartup.Text = "Build BIF Tree at startup";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(320, 352);
      Point point4 = point1;
      btnCancel.Location = point4;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      CheckBox alwaysConvertTpC2Tga1 = chkbAlwaysConvertTPC2TGA;
      point1 = new Point(32, 112);
      Point point5 = point1;
      alwaysConvertTpC2Tga1.Location = point5;
      chkbAlwaysConvertTPC2TGA.Name = "chkbAlwaysConvertTPC2TGA";
      CheckBox alwaysConvertTpC2Tga2 = chkbAlwaysConvertTPC2TGA;
      size1 = new Size(264, 24);
      Size size3 = size1;
      alwaysConvertTpC2Tga2.Size = size3;
      chkbAlwaysConvertTPC2TGA.TabIndex = 3;
      chkbAlwaysConvertTPC2TGA.Text = "Always convert TPC files to TGA upon extract";
      CheckBox chkbDockImageViewer1 = chkbDockImageViewer;
      point1 = new Point(32, 16);
      Point point6 = point1;
      chkbDockImageViewer1.Location = point6;
      chkbDockImageViewer.Name = "chkbDockImageViewer";
      CheckBox chkbDockImageViewer2 = chkbDockImageViewer;
      size1 = new Size(208, 24);
      Size size4 = size1;
      chkbDockImageViewer2.Size = size4;
      chkbDockImageViewer.TabIndex = 4;
      chkbDockImageViewer.Text = "Dock Image Viewer to Main window";
      CheckBox textEditorWordWrap1 = chkbTextEditorWordWrap;
      point1 = new Point(32, 48);
      Point point7 = point1;
      textEditorWordWrap1.Location = point7;
      chkbTextEditorWordWrap.Name = "chkbTextEditorWordWrap";
      CheckBox textEditorWordWrap2 = chkbTextEditorWordWrap;
      size1 = new Size(232, 24);
      Size size5 = size1;
      textEditorWordWrap2.Size = size5;
      chkbTextEditorWordWrap.TabIndex = 5;
      chkbTextEditorWordWrap.Text = "Word Wrap on by default in text editor";
      chkbBuildModelsBifNode.Checked = true;
      chkbBuildModelsBifNode.CheckState = CheckState.Checked;
      CheckBox buildModelsBifNode1 = chkbBuildModelsBifNode;
      point1 = new Point(32, 48);
      Point point8 = point1;
      buildModelsBifNode1.Location = point8;
      chkbBuildModelsBifNode.Name = "chkbBuildModelsBifNode";
      CheckBox buildModelsBifNode2 = chkbBuildModelsBifNode;
      size1 = new Size(254, 24);
      Size size6 = size1;
      buildModelsBifNode2.Size = size6;
      chkbBuildModelsBifNode.TabIndex = 1;
      chkbBuildModelsBifNode.Text = "Build Model BIF node in Tree";
      CheckBox unknownGfFasText1 = chkbAlwaysUnknownGFFasText;
      point1 = new Point(32, 80);
      Point point9 = point1;
      unknownGfFasText1.Location = point9;
      chkbAlwaysUnknownGFFasText.Name = "chkbAlwaysUnknownGFFasText";
      CheckBox unknownGfFasText2 = chkbAlwaysUnknownGFFasText;
      size1 = new Size(270, 24);
      Size size7 = size1;
      unknownGfFasText2.Size = size7;
      chkbAlwaysUnknownGFFasText.TabIndex = 2;
      chkbAlwaysUnknownGFFasText.Text = "Double-click opens unsupported GFFs as Text";
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(tabpagTreeview);
      TabControl1.Controls.Add(tabpagProjectManager);
      TabControl1.Controls.Add(tabpagOther);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(16, 16);
      Point point10 = point1;
      tabControl1_1.Location = point10;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = TabControl1;
      size1 = new Size(392, 312);
      Size size8 = size1;
      tabControl1_2.Size = size8;
      TabControl1.TabIndex = 8;
      tabpagTreeview.Controls.Add(chkbBuildModelsBifNode);
      tabpagTreeview.Controls.Add(chkbAlwaysConvertTPC2TGA);
      tabpagTreeview.Controls.Add(chkbBuildBIFTreeAtStartup);
      tabpagTreeview.Controls.Add(chkbAlwaysUnknownGFFasText);
      tabpagTreeview.Controls.Add(chkbShowModuleLocations);
      tabpagTreeview.Controls.Add(chkbShowModuleDescriptions);
      tabpagTreeview.Controls.Add(chkbRememberLastTreeNode);
      tabpagTreeview.Controls.Add(chkbRememberTreeViewState);
      TabPage tabpagTreeview1 = tabpagTreeview;
      point1 = new Point(4, 22);
      Point point11 = point1;
      ((Control) tabpagTreeview1).Location = point11;
      tabpagTreeview.Name = "tabpagTreeview";
      TabPage tabpagTreeview2 = tabpagTreeview;
      size1 = new Size(384, 286);
      Size size9 = size1;
      tabpagTreeview2.Size = size9;
      tabpagTreeview.TabIndex = 0;
      tabpagTreeview.Text = "Treeview";
      chkbShowModuleLocations.Checked = true;
      chkbShowModuleLocations.CheckState = CheckState.Checked;
      CheckBox showModuleLocations1 = chkbShowModuleLocations;
      point1 = new Point(32, 176);
      Point point12 = point1;
      showModuleLocations1.Location = point12;
      chkbShowModuleLocations.Name = "chkbShowModuleLocations";
      CheckBox showModuleLocations2 = chkbShowModuleLocations;
      size1 = new Size(264, 24);
      Size size10 = size1;
      showModuleLocations2.Size = size10;
      chkbShowModuleLocations.TabIndex = 3;
      chkbShowModuleLocations.Text = "Show Module Locations";
      chkbShowModuleDescriptions.Checked = true;
      chkbShowModuleDescriptions.CheckState = CheckState.Checked;
      CheckBox moduleDescriptions1 = chkbShowModuleDescriptions;
      point1 = new Point(32, 144);
      Point point13 = point1;
      moduleDescriptions1.Location = point13;
      chkbShowModuleDescriptions.Name = "chkbShowModuleDescriptions";
      CheckBox moduleDescriptions2 = chkbShowModuleDescriptions;
      size1 = new Size(270, 24);
      Size size11 = size1;
      moduleDescriptions2.Size = size11;
      chkbShowModuleDescriptions.TabIndex = 2;
      chkbShowModuleDescriptions.Text = "Show Module Descriptions";
      chkbRememberLastTreeNode.Checked = true;
      chkbRememberLastTreeNode.CheckState = CheckState.Checked;
      CheckBox rememberLastTreeNode1 = chkbRememberLastTreeNode;
      point1 = new Point(32, 208);
      Point point14 = point1;
      rememberLastTreeNode1.Location = point14;
      chkbRememberLastTreeNode.Name = "chkbRememberLastTreeNode";
      CheckBox rememberLastTreeNode2 = chkbRememberLastTreeNode;
      size1 = new Size(264, 24);
      Size size12 = size1;
      rememberLastTreeNode2.Size = size12;
      chkbRememberLastTreeNode.TabIndex = 3;
      chkbRememberLastTreeNode.Text = "Remember last opened node";
      chkbRememberTreeViewState.Checked = true;
      chkbRememberTreeViewState.CheckState = CheckState.Checked;
      CheckBox rememberTreeViewState1 = chkbRememberTreeViewState;
      point1 = new Point(32, 240);
      Point point15 = point1;
      rememberTreeViewState1.Location = point15;
      chkbRememberTreeViewState.Name = "chkbRememberTreeViewState";
      CheckBox rememberTreeViewState2 = chkbRememberTreeViewState;
      size1 = new Size(264, 24);
      Size size13 = size1;
      rememberTreeViewState2.Size = size13;
      chkbRememberTreeViewState.TabIndex = 3;
      chkbRememberTreeViewState.Text = "Remember treeview state";
      tabpagProjectManager.Controls.Add(GroupBox1);
      tabpagProjectManager.Controls.Add(GroupBox2);
      TabPage tabpagProjectManager1 = tabpagProjectManager;
      point1 = new Point(4, 22);
      Point point16 = point1;
      ((Control) tabpagProjectManager1).Location = point16;
      tabpagProjectManager.Name = "tabpagProjectManager";
      TabPage tabpagProjectManager2 = tabpagProjectManager;
      size1 = new Size(384, 286);
      Size size14 = size1;
      tabpagProjectManager2.Size = size14;
      tabpagProjectManager.TabIndex = 2;
      tabpagProjectManager.Text = "Project Manager";
      GroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      GroupBox1.Controls.Add(btnBrowseProjMgrDLGEditorPath);
      GroupBox1.Controls.Add(tbProjMgrDLGEditorPath);
      GroupBox1.Controls.Add(rbProjMgrUseInternDLGEditor);
      GroupBox1.Controls.Add(rbProjMgrUseExternDLGEditor);
      GroupBox groupBox1_1 = GroupBox1;
      point1 = new Point(16, 8);
      Point point17 = point1;
      groupBox1_1.Location = point17;
      GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = GroupBox1;
      size1 = new Size(352, 80);
      Size size15 = size1;
      groupBox1_2.Size = size15;
      GroupBox1.TabIndex = 0;
      GroupBox1.TabStop = false;
      GroupBox1.Text = "Dialog Editor";
      btnBrowseProjMgrDLGEditorPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnBrowseProjMgrDLGEditorPath.Enabled = false;
      Button mgrDlgEditorPath1 = btnBrowseProjMgrDLGEditorPath;
      point1 = new Point(312, 50);
      Point point18 = point1;
      mgrDlgEditorPath1.Location = point18;
      btnBrowseProjMgrDLGEditorPath.Name = "btnBrowseProjMgrDLGEditorPath";
      Button mgrDlgEditorPath2 = btnBrowseProjMgrDLGEditorPath;
      size1 = new Size(24, 20);
      Size size16 = size1;
      mgrDlgEditorPath2.Size = size16;
      btnBrowseProjMgrDLGEditorPath.TabIndex = 4;
      btnBrowseProjMgrDLGEditorPath.Text = "...";
      tbProjMgrDLGEditorPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbProjMgrDLGEditorPath.Enabled = false;
      TextBox mgrDlgEditorPath3 = tbProjMgrDLGEditorPath;
      point1 = new Point(96, 50);
      Point point19 = point1;
      mgrDlgEditorPath3.Location = point19;
      tbProjMgrDLGEditorPath.Name = "tbProjMgrDLGEditorPath";
      TextBox mgrDlgEditorPath4 = tbProjMgrDLGEditorPath;
      size1 = new Size(208, 20);
      Size size17 = size1;
      mgrDlgEditorPath4.Size = size17;
      tbProjMgrDLGEditorPath.TabIndex = 3;
      tbProjMgrDLGEditorPath.Text = "";
      rbProjMgrUseInternDLGEditor.Checked = true;
      RadioButton useInternDlgEditor1 = rbProjMgrUseInternDLGEditor;
      point1 = new Point(24, 16);
      Point point20 = point1;
      useInternDlgEditor1.Location = point20;
      rbProjMgrUseInternDLGEditor.Name = "rbProjMgrUseInternDLGEditor";
      RadioButton useInternDlgEditor2 = rbProjMgrUseInternDLGEditor;
      size1 = new Size(72, 24);
      Size size18 = size1;
      useInternDlgEditor2.Size = size18;
      rbProjMgrUseInternDLGEditor.TabIndex = 0;
      rbProjMgrUseInternDLGEditor.TabStop = true;
      rbProjMgrUseInternDLGEditor.Text = "Internal";
      RadioButton useExternDlgEditor1 = rbProjMgrUseExternDLGEditor;
      point1 = new Point(24, 48);
      Point point21 = point1;
      useExternDlgEditor1.Location = point21;
      rbProjMgrUseExternDLGEditor.Name = "rbProjMgrUseExternDLGEditor";
      RadioButton useExternDlgEditor2 = rbProjMgrUseExternDLGEditor;
      size1 = new Size(72, 24);
      Size size19 = size1;
      useExternDlgEditor2.Size = size19;
      rbProjMgrUseExternDLGEditor.TabIndex = 0;
      rbProjMgrUseExternDLGEditor.Text = "External";
      GroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      GroupBox2.Controls.Add(rbProjMgrUseInternTxtEditor);
      GroupBox2.Controls.Add(tbProjMgrTxtEditorPath);
      GroupBox2.Controls.Add(rbProjMgrUseExternTxtEditor);
      GroupBox2.Controls.Add(btnBrowseProjMgrTxtEditorPath);
      GroupBox groupBox2_1 = GroupBox2;
      point1 = new Point(16, 112);
      Point point22 = point1;
      groupBox2_1.Location = point22;
      GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = GroupBox2;
      size1 = new Size(352, 80);
      Size size20 = size1;
      groupBox2_2.Size = size20;
      GroupBox2.TabIndex = 0;
      GroupBox2.TabStop = false;
      GroupBox2.Text = "Text/NSS Editor";
      rbProjMgrUseInternTxtEditor.Checked = true;
      RadioButton useInternTxtEditor1 = rbProjMgrUseInternTxtEditor;
      point1 = new Point(24, 16);
      Point point23 = point1;
      useInternTxtEditor1.Location = point23;
      rbProjMgrUseInternTxtEditor.Name = "rbProjMgrUseInternTxtEditor";
      RadioButton useInternTxtEditor2 = rbProjMgrUseInternTxtEditor;
      size1 = new Size(72, 24);
      Size size21 = size1;
      useInternTxtEditor2.Size = size21;
      rbProjMgrUseInternTxtEditor.TabIndex = 0;
      rbProjMgrUseInternTxtEditor.TabStop = true;
      rbProjMgrUseInternTxtEditor.Text = "Internal";
      tbProjMgrTxtEditorPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      tbProjMgrTxtEditorPath.Enabled = false;
      TextBox mgrTxtEditorPath1 = tbProjMgrTxtEditorPath;
      point1 = new Point(96, 49);
      Point point24 = point1;
      mgrTxtEditorPath1.Location = point24;
      tbProjMgrTxtEditorPath.Name = "tbProjMgrTxtEditorPath";
      TextBox mgrTxtEditorPath2 = tbProjMgrTxtEditorPath;
      size1 = new Size(208, 20);
      Size size22 = size1;
      mgrTxtEditorPath2.Size = size22;
      tbProjMgrTxtEditorPath.TabIndex = 3;
      tbProjMgrTxtEditorPath.Text = "";
      RadioButton useExternTxtEditor1 = rbProjMgrUseExternTxtEditor;
      point1 = new Point(24, 48);
      Point point25 = point1;
      useExternTxtEditor1.Location = point25;
      rbProjMgrUseExternTxtEditor.Name = "rbProjMgrUseExternTxtEditor";
      RadioButton useExternTxtEditor2 = rbProjMgrUseExternTxtEditor;
      size1 = new Size(72, 24);
      Size size23 = size1;
      useExternTxtEditor2.Size = size23;
      rbProjMgrUseExternTxtEditor.TabIndex = 0;
      rbProjMgrUseExternTxtEditor.Text = "External";
      btnBrowseProjMgrTxtEditorPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnBrowseProjMgrTxtEditorPath.Enabled = false;
      Button mgrTxtEditorPath3 = btnBrowseProjMgrTxtEditorPath;
      point1 = new Point(312, 50);
      Point point26 = point1;
      mgrTxtEditorPath3.Location = point26;
      btnBrowseProjMgrTxtEditorPath.Name = "btnBrowseProjMgrTxtEditorPath";
      Button mgrTxtEditorPath4 = btnBrowseProjMgrTxtEditorPath;
      size1 = new Size(24, 20);
      Size size24 = size1;
      mgrTxtEditorPath4.Size = size24;
      btnBrowseProjMgrTxtEditorPath.TabIndex = 4;
      btnBrowseProjMgrTxtEditorPath.Text = "...";
      tabpagOther.Controls.Add(chkbTextEditorWordWrap);
      tabpagOther.Controls.Add(chkbDockImageViewer);
      tabpagOther.Controls.Add(chkbCheckForUpdatesAtStartup);
      tabpagOther.Controls.Add(chkbDownloadUpdatesAutomatically);
      tabpagOther.Controls.Add(chkbUseOverrideFiles);
      TabPage tabpagOther1 = tabpagOther;
      point1 = new Point(4, 22);
      Point point27 = point1;
      ((Control) tabpagOther1).Location = point27;
      tabpagOther.Name = "tabpagOther";
      TabPage tabpagOther2 = tabpagOther;
      size1 = new Size(384, 286);
      Size size25 = size1;
      tabpagOther2.Size = size25;
      tabpagOther.TabIndex = 1;
      tabpagOther.Text = "Other";
      CheckBox updatesAtStartup1 = chkbCheckForUpdatesAtStartup;
      point1 = new Point(32, 80);
      Point point28 = point1;
      updatesAtStartup1.Location = point28;
      chkbCheckForUpdatesAtStartup.Name = "chkbCheckForUpdatesAtStartup";
      CheckBox updatesAtStartup2 = chkbCheckForUpdatesAtStartup;
      size1 = new Size(232, 24);
      Size size26 = size1;
      updatesAtStartup2.Size = size26;
      chkbCheckForUpdatesAtStartup.TabIndex = 5;
      chkbCheckForUpdatesAtStartup.Text = "Check for program updates at startup";
      CheckBox updatesAutomatically1 = chkbDownloadUpdatesAutomatically;
      point1 = new Point(56, 104);
      Point point29 = point1;
      updatesAutomatically1.Location = point29;
      chkbDownloadUpdatesAutomatically.Name = "chkbDownloadUpdatesAutomatically";
      CheckBox updatesAutomatically2 = chkbDownloadUpdatesAutomatically;
      size1 = new Size(192, 24);
      Size size27 = size1;
      updatesAutomatically2.Size = size27;
      chkbDownloadUpdatesAutomatically.TabIndex = 5;
      chkbDownloadUpdatesAutomatically.Text = "Download updates automatically";
      CheckBox useOverrideFiles1 = chkbUseOverrideFiles;
      point1 = new Point(32, 136);
      Point point30 = point1;
      useOverrideFiles1.Location = point30;
      chkbUseOverrideFiles.Name = "chkbUseOverrideFiles";
      CheckBox useOverrideFiles2 = chkbUseOverrideFiles;
      size1 = new Size(256, 24);
      Size size28 = size1;
      useOverrideFiles2.Size = size28;
      chkbUseOverrideFiles.TabIndex = 5;
      chkbUseOverrideFiles.Text = "Look in Game's Override folder for 2DA files";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(432, 389);
      ClientSize = size1;
      Controls.Add(TabControl1);
      Controls.Add(btnOK);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = nameof (frmOptions);
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Options";
      TabControl1.ResumeLayout(false);
      tabpagTreeview.ResumeLayout(false);
      tabpagProjectManager.ResumeLayout(false);
      GroupBox1.ResumeLayout(false);
      GroupBox2.ResumeLayout(false);
      tabpagOther.ResumeLayout(false);
      ResumeLayout(false);
    }

  public void Setup()
  {
      options = UserSettings.GetSettings();
      chkbBuildBIFTreeAtStartup.Checked = options.bBuildBIFFtreeOnStartup;
      chkbBuildModelsBifNode.Checked = options.bBuildModelsBifNode;
      chkbAlwaysUnknownGFFasText.Checked = options.bAlwaysUnknownGFFasText;
      chkbAlwaysConvertTPC2TGA.Checked = options.bAlwaysConvertTPC2TGA;
      chkbDockImageViewer.Checked = options.bDockImageViewer;
      chkbTextEditorWordWrap.Checked = options.bTextEditorWordWrap;
      chkbShowModuleDescriptions.Checked = options.bShowModuleDescriptions;
      chkbShowModuleLocations.Checked = options.bShowModuleLocations;
      chkbCheckForUpdatesAtStartup.Checked = options.bCheckForUpdatesAtStartup;
      chkbDownloadUpdatesAutomatically.Checked = options.bDownloadUpdatesAutomatically & chkbCheckForUpdatesAtStartup.Checked;
      chkbRememberLastTreeNode.Checked = options.bRememberLastTreeNode;
      chkbRememberTreeViewState.Checked = options.bRememberTreeViewState;
      chkbUseOverrideFiles.Checked = options.bUseOverrideFiles;
      if (options.bProjMgrUseExternTxtEditor && StringType.StrCmp(options.ProjMgrTxtEditorPath, "", false) != 0)
      {
        rbProjMgrUseExternTxtEditor.Checked = true;
        tbProjMgrTxtEditorPath.Text = options.ProjMgrTxtEditorPath;
      }
      else
        rbProjMgrUseInternTxtEditor.Checked = true;
      if (options.bProjMgrUseExternDLGEditor && StringType.StrCmp(options.ProjMgrDLGEditorPath, "", false) != 0)
      {
        rbProjMgrUseExternDLGEditor.Checked = true;
        tbProjMgrDLGEditorPath.Text = options.ProjMgrDLGEditorPath;
      }
      else
        rbProjMgrUseInternDLGEditor.Checked = true;
    }

  private void btnOK_Click(object sender, EventArgs e)
  {
      options.bBuildBIFFtreeOnStartup = chkbBuildBIFTreeAtStartup.Checked;
      options.bBuildModelsBifNode = chkbBuildModelsBifNode.Checked;
      options.bAlwaysUnknownGFFasText = chkbAlwaysUnknownGFFasText.Checked;
      options.bAlwaysConvertTPC2TGA = chkbAlwaysConvertTPC2TGA.Checked;
      options.bDockImageViewer = chkbDockImageViewer.Checked;
      options.bTextEditorWordWrap = chkbTextEditorWordWrap.Checked;
      options.bShowModuleDescriptions = chkbShowModuleDescriptions.Checked;
      options.bShowModuleLocations = chkbShowModuleLocations.Checked;
      options.bCheckForUpdatesAtStartup = chkbCheckForUpdatesAtStartup.Checked;
      options.bDownloadUpdatesAutomatically = chkbDownloadUpdatesAutomatically.Checked;
      if (!options.bRememberLastTreeNode & chkbRememberLastTreeNode.Checked)
        options.LastClickedTVNodePath = "";
      options.bRememberLastTreeNode = chkbRememberLastTreeNode.Checked;
      options.bRememberTreeViewState = chkbRememberTreeViewState.Checked;
      options.bUseOverrideFiles = chkbUseOverrideFiles.Checked;
      if (rbProjMgrUseExternTxtEditor.Checked && StringType.StrCmp(tbProjMgrTxtEditorPath.Text.Trim(), "", false) != 0)
      {
        options.bProjMgrUseExternTxtEditor = true;
        options.ProjMgrTxtEditorPath = tbProjMgrTxtEditorPath.Text;
      }
      else
      {
        options.bProjMgrUseExternTxtEditor = false;
        options.ProjMgrTxtEditorPath = "";
      }
      if (rbProjMgrUseExternDLGEditor.Checked && StringType.StrCmp(tbProjMgrDLGEditorPath.Text.Trim(), "", false) != 0)
      {
        options.bProjMgrUseExternDLGEditor = true;
        options.ProjMgrDLGEditorPath = tbProjMgrDLGEditorPath.Text;
      }
      else
      {
        options.bProjMgrUseExternDLGEditor = false;
        options.ProjMgrDLGEditorPath = "";
      }
      UserSettings.SaveSettings(options);
    }

  private void chkbCheckForUpdatesAtStartup_CheckedChanged(object sender, EventArgs e)
  {
      chkbDownloadUpdatesAutomatically.Enabled = chkbCheckForUpdatesAtStartup.Checked;
      chkbDownloadUpdatesAutomatically.Checked = chkbCheckForUpdatesAtStartup.Checked;
    }

  private void btnBrowseProjMgrDLGEditorPath_Click(object sender, EventArgs e)
  {
      string sLeft = StringType.FromObject(FrmMain.GetFilePath("load", "C:\\", "*.exe", "Select the Dialog Editor you wish to use", ""));
      if (StringType.StrCmp(sLeft, "", false) == 0)
        return;
      tbProjMgrDLGEditorPath.Text = sLeft;
    }

  private void btnBrowseProjMgrTxtEditorPath_Click(object sender, EventArgs e)
  {
      string sLeft = StringType.FromObject(FrmMain.GetFilePath("load", "C:\\", "*.exe", "Select the Text Editor you wish to use", ""));
      if (StringType.StrCmp(sLeft, "", false) == 0)
        return;
      tbProjMgrTxtEditorPath.Text = sLeft;
    }

  private void rbProjMgrUseExternDLGEditor_CheckedChanged(object sender, EventArgs e)
  {
      bool flag = ((RadioButton) sender).Checked;
      tbProjMgrDLGEditorPath.Enabled = flag;
      btnBrowseProjMgrDLGEditorPath.Enabled = flag;
    }

  private void rbProjMgrUseExternTxtEditor_CheckedChanged_1(object sender, EventArgs e)
  {
      bool flag = ((RadioButton) sender).Checked;
      tbProjMgrTxtEditorPath.Enabled = flag;
      btnBrowseProjMgrTxtEditorPath.Enabled = flag;
    }
}