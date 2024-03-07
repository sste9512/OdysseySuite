// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmModule_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms.VisualStyles;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Kotortool_Legacy;

public class frmModule_Editor : frmParent
{
  [AccessedThroughProperty("miCopyToOverride")]
  private ToolStripMenuItem _miCopyToOverride;
  [AccessedThroughProperty("miRemoveFromOverride")]
  private ToolStripMenuItem _miRemoveFromOverride;
  [AccessedThroughProperty("miCleanOverride")]
  private ToolStripMenuItem _miCleanOverride;
  [AccessedThroughProperty("chkbShowNames")]
  private CheckBox _chkbShowNames;
  [AccessedThroughProperty("ToolStripMenuItem9")]
  private ToolStripMenuItem _ToolStripMenuItem9;
  [AccessedThroughProperty("tvUserPalette")]
  private TreeView _tvUserPalette;
  [AccessedThroughProperty("miShowModulePaths")]
  private ToolStripMenuItem _miShowModulePaths;
  [AccessedThroughProperty("cmiTvModuleItemEdit")]
  private ToolStripMenuItem _cmiTvModuleItemEdit;
  [AccessedThroughProperty("miShowHidePalette")]
  private ToolStripMenuItem _miShowHidePalette;
  [AccessedThroughProperty("miShowHideModuleElements")]
  private ToolStripMenuItem _miShowHideModuleElements;
  [AccessedThroughProperty("ToolTip1")]
  private ToolTip _ToolTip1;
  [AccessedThroughProperty("miClose")]
  private ToolStripMenuItem _miClose;
  [AccessedThroughProperty("pnlModElements")]
  private Panel _pnlModElements;
  [AccessedThroughProperty("pnlPalette")]
  private Panel _pnlPalette;
  [AccessedThroughProperty("ImageList1")]
  private ImageList _ImageList1;
  [AccessedThroughProperty("btnLogFactors")]
  private Button _btnLogFactors;
  [AccessedThroughProperty("chkbShowResRefs")]
  private CheckBox _chkbShowResRefs;
  [AccessedThroughProperty("btnPalTrigger")]
  private Button _btnPalTrigger;
  [AccessedThroughProperty("btnPalSound")]
  private Button _btnPalSound;
  [AccessedThroughProperty("miFont")]
  private ToolStripMenuItem _miFont;
  [AccessedThroughProperty("btnCalToolsToggle")]
  private Button _btnCalToolsToggle;
  [AccessedThroughProperty("btnCalcCalibrationVals")]
  private Button _btnCalcCalibrationVals;
  [AccessedThroughProperty("btnAssignPt2")]
  private Button _btnAssignPt2;
  [AccessedThroughProperty("btnPalWaypoint")]
  private Button _btnPalWaypoint;
  [AccessedThroughProperty("btnPalPlaceable")]
  private Button _btnPalPlaceable;
  [AccessedThroughProperty("btnPalMerchant")]
  private Button _btnPalMerchant;
  [AccessedThroughProperty("btnPalItem")]
  private Button _btnPalItem;
  [AccessedThroughProperty("btnPalEncounter")]
  private Button _btnPalEncounter;
  [AccessedThroughProperty("cmiTvModuleItemDelete")]
  private ToolStripMenuItem _cmiTvModuleItemDelete;
  [AccessedThroughProperty("ToolStripMenuItem7")]
  private ToolStripMenuItem _ToolStripMenuItem7;
  [AccessedThroughProperty("btnPalCreature")]
  private Button _btnPalCreature;
  [AccessedThroughProperty("tbHelp")]
  private TextBox _tbHelp;
  [AccessedThroughProperty("miSave")]
  private ToolStripMenuItem _miSave;
  [AccessedThroughProperty("btnPalDoor")]
  private Button _btnPalDoor;
  [AccessedThroughProperty("tabpagUserPalette")]
  private TabPage _tabpagUserPalette;
  [AccessedThroughProperty("tb3dsMaxPt2X")]
  private TextBox _tb3dsMaxPt2X;
  [AccessedThroughProperty("tb3dsMaxPt2Y")]
  private TextBox _tb3dsMaxPt2Y;
  [AccessedThroughProperty("cmiTvModuleItemProperties")]
  private ToolStripMenuItem _cmiTvModuleItemProperties;
  [AccessedThroughProperty("tb3dsMaxPt1Y")]
  private TextBox _tb3dsMaxPt1Y;
  [AccessedThroughProperty("tb3dsMaxPt1X")]
  private TextBox _tb3dsMaxPt1X;
  [AccessedThroughProperty("btnAssignPt1")]
  private Button _btnAssignPt1;
  [AccessedThroughProperty("chkbFine")]
  private CheckBox _chkbFine;
  [AccessedThroughProperty("tbMouseY")]
  private TextBox _tbMouseY;
  [AccessedThroughProperty("tvModuleContextToolStripMenuItem")]
  private ContextMenu _tvModuleContextToolStripMenuItem;
  [AccessedThroughProperty("tabctrlPalette")]
  private TabControl _tabctrlPalette;
  [AccessedThroughProperty("tvPalette")]
  private TreeView _tvPalette;
  [AccessedThroughProperty("tvModule")]
  private TreeView _tvModule;
  [AccessedThroughProperty("btnClean")]
  private Button _btnClean;
  [AccessedThroughProperty("nudYoff")]
  private NumericUpDown _nudYoff;
  [AccessedThroughProperty("tbMouseX")]
  private TextBox _tbMouseX;
  [AccessedThroughProperty("nudXoff")]
  private NumericUpDown _nudXoff;
  [AccessedThroughProperty("miOpenProject")]
  private ToolStripMenuItem _miOpenProject;
  [AccessedThroughProperty("nudYmul")]
  private NumericUpDown _nudYmul;
  [AccessedThroughProperty("tabpagModuleElements")]
  private TabPage _tabpagModuleElements;
  [AccessedThroughProperty("nudXmul")]
  private NumericUpDown _nudXmul;
  [AccessedThroughProperty("tabpagScripts")]
  private TabPage _tabpagScripts;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("miUseAltSmallMap")]
  private ToolStripMenuItem _miUseAltSmallMap;
  [AccessedThroughProperty("lbDialogs")]
  private ListBox _lbDialogs;
  [AccessedThroughProperty("tabpagDialogs")]
  private TabPage _tabpagDialogs;
  [AccessedThroughProperty("tabctrlModule")]
  private TabControl _tabctrlModule;
  [AccessedThroughProperty("mnuView")]
  private ToolStripMenuItem _mnuView;
  [AccessedThroughProperty("miExploreModuleFolder")]
  private ToolStripMenuItem _miExploreModuleFolder;
  [AccessedThroughProperty("miBuildModFile")]
  private ToolStripMenuItem _miBuildModFile;
  [AccessedThroughProperty("chkbUseFactors")]
  private CheckBox _chkbUseFactors;
  [AccessedThroughProperty("miModuleProperties")]
  private ToolStripMenuItem _miModuleProperties;
  [AccessedThroughProperty("miShowGitDump")]
  private ToolStripMenuItem _miShowGitDump;
  [AccessedThroughProperty("btnTest")]
  private Button _btnTest;
  [AccessedThroughProperty("miShowAreDump")]
  private ToolStripMenuItem _miShowAreDump;
  [AccessedThroughProperty("miShowIfoDump")]
  private ToolStripMenuItem _miShowIfoDump;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("sbar")]
  private StatusBar _sbar;
  [AccessedThroughProperty("pbox")]
  private PictureBox _pbox;
  [AccessedThroughProperty("sbarpnlLocX")]
  private StatusBarPanel _sbarpnlLocX;
  [AccessedThroughProperty("ToolStripMenuItem3")]
  private ToolStripMenuItem _ToolStripMenuItem3;
  [AccessedThroughProperty("sbarpnlLocY")]
  private StatusBarPanel _sbarpnlLocY;
  [AccessedThroughProperty("sbarpnlDesc")]
  private StatusBarPanel _sbarpnlDesc;
  [AccessedThroughProperty("sbarpnlAddlInfo")]
  private StatusBarPanel _sbarpnlAddlInfo;
  [AccessedThroughProperty("sbarpnlStatus")]
  private StatusBarPanel _sbarpnlStatus;
  [AccessedThroughProperty("ToolBarModElementsFilter")]
  private VisualStyleElement.ToolBar _ToolBarModElementsFilter;
  [AccessedThroughProperty("ToolStripMenuItem6")]
  private ToolStripMenuItem _ToolStripMenuItem6;
  [AccessedThroughProperty("tbarbtnCreature")]
  private ToolBarButton _tbarbtnCreature;
  [AccessedThroughProperty("tbarbtnDoor")]
  private ToolBarButton _tbarbtnDoor;
  [AccessedThroughProperty("tbarbtnEncounter")]
  private ToolBarButton _tbarbtnEncounter;
  [AccessedThroughProperty("tbarbtnMerchant")]
  private ToolBarButton _tbarbtnMerchant;
  [AccessedThroughProperty("tbarbtnPlaceable")]
  private ToolBarButton _tbarbtnPlaceable;
  [AccessedThroughProperty("tbarbtnSound")]
  private ToolBarButton _tbarbtnSound;
  [AccessedThroughProperty("miOptions")]
  private ToolStripMenuItem _miOptions;
  [AccessedThroughProperty("ToolStripMenuItem4")]
  private ToolStripMenuItem _ToolStripMenuItem4;
  [AccessedThroughProperty("tbarbtnTrigger")]
  private ToolBarButton _tbarbtnTrigger;
  [AccessedThroughProperty("tbarbtnWaypoint")]
  private ToolBarButton _tbarbtnWaypoint;
  [AccessedThroughProperty("ilModElementsFilter")]
  private ImageList _ilModElementsFilter;
  [AccessedThroughProperty("lbScripts")]
  private ListBox _lbScripts;
  [AccessedThroughProperty("miUseLargeMap")]
  private ToolStripMenuItem _miUseLargeMap;
  [AccessedThroughProperty("miShowModuleEntryPoint")]
  private ToolStripMenuItem _miShowModuleEntryPoint;
  [AccessedThroughProperty("cmiAddNewSpawnPoint")]
  private ToolStripMenuItem _cmiAddNewSpawnPoint;
  [AccessedThroughProperty("cmiEditGFFFile")]
  private ToolStripMenuItem _cmiEditGFFFile;
  [AccessedThroughProperty("ToolStripMenuItem2")]
  private ToolStripMenuItem _ToolStripMenuItem2;
  [AccessedThroughProperty("miUseSmallMap")]
  private ToolStripMenuItem _miUseSmallMap;
  [AccessedThroughProperty("ToolStripMenuItem11")]
  private ToolStripMenuItem _ToolStripMenuItem11;
  [AccessedThroughProperty("miShowItemLabels")]
  private ToolStripMenuItem _miShowItemLabels;
  [AccessedThroughProperty("cmPbox")]
  private ContextMenu _cmPbox;
  [AccessedThroughProperty("ToolStripMenuItem5")]
  private ToolStripMenuItem _ToolStripMenuItem5;
  [AccessedThroughProperty("cmiModuleProperties")]
  private ToolStripMenuItem _cmiModuleProperties;
  [AccessedThroughProperty("cmiDelete")]
  private ToolStripMenuItem _cmiDelete;
  [AccessedThroughProperty("cmiCreateCameraHere")]
  private ToolStripMenuItem _cmiCreateCameraHere;
  [AccessedThroughProperty("cmiSetModuleStartPoint")]
  private ToolStripMenuItem _cmiSetModuleStartPoint;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("ToolStripMenuItem13")]
  private ToolStripMenuItem _ToolStripMenuItem13;
  [AccessedThroughProperty("cmiProperties")]
  private ToolStripMenuItem _cmiProperties;
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("cmMapSurfaceItems")]
  private ContextMenu _cmMapSurfaceItems;
  [AccessedThroughProperty("chkbShowTags")]
  private CheckBox _chkbShowTags;
  [AccessedThroughProperty("btnTweakUp")]
  private RepeatButton _btnTweakUp;
  [AccessedThroughProperty("TabPage1")]
  private TabPage _TabPage1;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("btnTweakLeft")]
  private RepeatButton _btnTweakLeft;
  [AccessedThroughProperty("btnTweakDown")]
  private RepeatButton _btnTweakDown;
  [AccessedThroughProperty("btnTweakRight")]
  private RepeatButton _btnTweakRight;
  private IContainer components;
  private const int HALF_ITEM_SIZE = 1;
  private const int ITEM_SIZE = 3;
  private const int NEAR_TOLERANCE = 2;
  public clsDialogTlk g_clsDialogTlk;
  private ModItem[] CreatureArr;
  private ModItem[] PlaceableArr;
  private ModItem[] DoorArr;
  private ModItem[] ItemArr;
  private ModItem[] SoundArr;
  private ModItem[] WaypointArr;
  private ModItem[] MerchantArr;
  private ModItem[] TriggerArr;
  private ModItem[] EncounterArr;
  private ModItem[] CameraArr;
  private Region[] TriggerRegions;
  private Region[] EncounterRegions;
  private bool bModuleLoadedOK;
  private int g_imageYsize;
  private ModItem CurrentModItem;
  private ModItem IndicatedModItem;
  private int gCurrentModItemType;
  private Color gCurrentRegionDrawingColor;
  private ClsGff GITfile;
  private ClsGff AREfile;
  private ClsGff IFOfile;
  private Bitmap backbuffer;
  private Bitmap CurrentModItemBmp;
  private Bitmap bmp;
  private Bitmap bmp_cache;
  private Point gLastMousePos;
  private Point g_LastMouseDownPos;
  private Point gLastBackBufferOrigin;
  private Point gCurrentRegionSegmentOrigin;
  private bool LeftMouseClickActive;
  private ModItemTvNode LastClickedTvModuleNode;
  private ModItemTvNode CurrentContextMenuTvModuleNode;
  private bool g_ShowPaletteNames;
  private bool g_ShowPaletteResRefs;
  private string g_CurrentPaletteName;
  private int g_CurrentPaletteModItemType;
  private string g_ProjectPath;
  private string g_GlobalTemplatesPath;
  private string g_UserPalettePath;
  private bool g_IsDrawingRegion;
  private ArrayList g_RegionPointList;
  private string g_RegionResRef;
  private string g_MapName;
  private string g_mapImageName;
  private bool g_LargeMapAvailable;
  private bool g_SmallMapAvailable;
  private bool g_UsingLargeMap;
  private bool g_AltSmallMapAvailable;
  private int g_MapTypeInUse;
  private string g_mapsPath;
  private bool bPaletteVisible;
  private bool bModElementsVisible;
  private bool bConfirmDeletes;
  private bool bShowLocatorRay;
  private Decimal dModuleElementIndicatorSize;
  private string gModuleEditorModOutputPath;
  private ModuleEditorProjectOptions gModuleEditorSettings;
  private ArrayList g_tvModule_TreeOpenPaths;
  private FileSystemWatcher g_UserPalettteFsw;
  private FileSystemWatcher g_ProjectFsw;
  public static frmModule_Editor g_form;
  private PointF g_ModuleStartPoint;
  private FrmMain f;
  private Hashtable htK1Tags;
  private Hashtable htK2Tags;
  private Hashtable htTemplateBifFiles;
  private Point MapCalibratePt1;
  private Point MapCalibratePt2;
  private bool CalibrationToolsVis;
  private Font labelFont;
  private SolidBrush labelBrush;
  private int tb;
  private int lcl;

  public frmModule_Editor()
  {
      Load += new EventHandler(frmModule_Editor_Load);
      Closing += new CancelEventHandler(frmModule_Editor_Closing);
      bModuleLoadedOK = false;
      g_ShowPaletteNames = true;
      g_CurrentPaletteModItemType = -1;
      g_mapsPath = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool").GetValue("path")), "maps\\");
      bPaletteVisible = true;
      bModElementsVisible = true;
      bConfirmDeletes = true;
      bShowLocatorRay = true;
      dModuleElementIndicatorSize = 1M;
      g_tvModule_TreeOpenPaths = new ArrayList();
      g_UserPalettteFsw = new FileSystemWatcher();
      g_ProjectFsw = new FileSystemWatcher();
      CalibrationToolsVis = false;
      labelFont = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      labelBrush = new SolidBrush(Color.White);
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual Panel Panel1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Panel1 != null)
        {
          _Panel1.DragEnter -= new DragEventHandler(Panel1_DragEnter);
          _Panel1.DragDrop -= new DragEventHandler(Panel1_DragDrop);
        }
        _Panel1 = value;
        if (_Panel1 == null)
          return;
        _Panel1.DragEnter += new DragEventHandler(Panel1_DragEnter);
        _Panel1.DragDrop += new DragEventHandler(Panel1_DragDrop);
      }
    get => _Panel1;
  }

  internal virtual PictureBox pbox
  {
    get => _pbox;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pbox != null)
        {
          _pbox.MouseLeave -= new EventHandler(pbox_MouseLeave);
          _pbox.MouseUp -= new MouseEventHandler(pbox_MouseUp);
          _pbox.MouseMove -= new MouseEventHandler(pbox_MouseMove);
          _pbox.MouseDown -= new MouseEventHandler(pbox_MouseDown);
        }
        _pbox = value;
        if (_pbox == null)
          return;
        _pbox.MouseLeave += new EventHandler(pbox_MouseLeave);
        _pbox.MouseUp += new MouseEventHandler(pbox_MouseUp);
        _pbox.MouseMove += new MouseEventHandler(pbox_MouseMove);
        _pbox.MouseDown += new MouseEventHandler(pbox_MouseDown);
      }
  }

  internal virtual NumericUpDown nudXmul
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudXmul != null)
          _nudXmul.ValueChanged -= new EventHandler(nudMulOff_ValueChanged);
        _nudXmul = value;
        if (_nudXmul == null)
          return;
        _nudXmul.ValueChanged += new EventHandler(nudMulOff_ValueChanged);
      }
    get => _nudXmul;
  }

  internal virtual NumericUpDown nudYmul
  {
    get => _nudYmul;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudYmul != null)
          _nudYmul.ValueChanged -= new EventHandler(nudMulOff_ValueChanged);
        _nudYmul = value;
        if (_nudYmul == null)
          return;
        _nudYmul.ValueChanged += new EventHandler(nudMulOff_ValueChanged);
      }
  }

  internal virtual NumericUpDown nudXoff
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudXoff != null)
          _nudXoff.ValueChanged -= new EventHandler(nudMulOff_ValueChanged);
        _nudXoff = value;
        if (_nudXoff == null)
          return;
        _nudXoff.ValueChanged += new EventHandler(nudMulOff_ValueChanged);
      }
    get => _nudXoff;
  }

  internal virtual NumericUpDown nudYoff
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudYoff != null)
          _nudYoff.ValueChanged -= new EventHandler(nudMulOff_ValueChanged);
        _nudYoff = value;
        if (_nudYoff == null)
          return;
        _nudYoff.ValueChanged += new EventHandler(nudMulOff_ValueChanged);
      }
    get => _nudYoff;
  }

  internal virtual Button btnTest
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTest != null)
          _btnTest.Click -= new EventHandler(btnTest_Click);
        _btnTest = value;
        if (_btnTest == null)
          return;
        _btnTest.Click += new EventHandler(btnTest_Click);
      }
    get => _btnTest;
  }

  internal virtual Button btnClean
  {
    get => _btnClean;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnClean != null)
          _btnClean.Click -= new EventHandler(btnClean_Click);
        _btnClean = value;
        if (_btnClean == null)
          return;
        _btnClean.Click += new EventHandler(btnClean_Click);
      }
  }

  internal virtual TreeView tvModule
  {
    get => _tvModule;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvModule != null)
        {
          _tvModule.BeforeCollapse -= new TreeViewCancelEventHandler(tvModule_BeforeCollapse);
          _tvModule.BeforeExpand -= new TreeViewCancelEventHandler(tvModule_BeforeExpand);
          _tvModule.KeyUp -= new KeyEventHandler(tvModule_KeyUp);
          _tvModule.MouseUp -= new MouseEventHandler(tvModule_MouseUp);
          _tvModule.MouseDown -= new MouseEventHandler(tvModule_MouseDown);
        }
        _tvModule = value;
        if (_tvModule == null)
          return;
        _tvModule.BeforeCollapse += new TreeViewCancelEventHandler(tvModule_BeforeCollapse);
        _tvModule.BeforeExpand += new TreeViewCancelEventHandler(tvModule_BeforeExpand);
        _tvModule.KeyUp += new KeyEventHandler(tvModule_KeyUp);
        _tvModule.MouseUp += new MouseEventHandler(tvModule_MouseUp);
        _tvModule.MouseDown += new MouseEventHandler(tvModule_MouseDown);
      }
  }

  internal virtual TreeView tvPalette
  {
    get => _tvPalette;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvPalette != null)
          _tvPalette.ItemDrag -= new ItemDragEventHandler(tvPalette_ItemDrag);
        _tvPalette = value;
        if (_tvPalette == null)
          return;
        _tvPalette.ItemDrag += new ItemDragEventHandler(tvPalette_ItemDrag);
      }
  }

  internal virtual ContextMenu tvModuleContextToolStripMenuItem
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvModuleContextToolStripMenuItem == null)
          ;
        _tvModuleContextToolStripMenuItem = value;
        if (_tvModuleContextToolStripMenuItem == null)
          ;
      }
    get => _tvModuleContextToolStripMenuItem;
  }

  internal virtual ToolStripMenuItem cmiTvModuleItemProperties
  {
    get => _cmiTvModuleItemProperties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTvModuleItemProperties != null)
          _cmiTvModuleItemProperties.Click -= new EventHandler(cmiTvModuleItemProperties_Click);
        _cmiTvModuleItemProperties = value;
        if (_cmiTvModuleItemProperties == null)
          return;
        _cmiTvModuleItemProperties.Click += new EventHandler(cmiTvModuleItemProperties_Click);
      }
  }

  internal virtual Button btnPalDoor
  {
    get => _btnPalDoor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalDoor != null)
          _btnPalDoor.Click -= new EventHandler(btnPalDoor_Click);
        _btnPalDoor = value;
        if (_btnPalDoor == null)
          return;
        _btnPalDoor.Click += new EventHandler(btnPalDoor_Click);
      }
  }

  internal virtual Button btnPalCreature
  {
    get => _btnPalCreature;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalCreature != null)
          _btnPalCreature.Click -= new EventHandler(btnPalCreature_Click);
        _btnPalCreature = value;
        if (_btnPalCreature == null)
          return;
        _btnPalCreature.Click += new EventHandler(btnPalCreature_Click);
      }
  }

  internal virtual Button btnPalEncounter
  {
    get => _btnPalEncounter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalEncounter != null)
          _btnPalEncounter.Click -= new EventHandler(btnPalEncounter_Click);
        _btnPalEncounter = value;
        if (_btnPalEncounter == null)
          return;
        _btnPalEncounter.Click += new EventHandler(btnPalEncounter_Click);
      }
  }

  internal virtual Button btnPalItem
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalItem != null)
          _btnPalItem.Click -= new EventHandler(btnPalItem_Click);
        _btnPalItem = value;
        if (_btnPalItem == null)
          return;
        _btnPalItem.Click += new EventHandler(btnPalItem_Click);
      }
    get => _btnPalItem;
  }

  internal virtual Button btnPalMerchant
  {
    get => _btnPalMerchant;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalMerchant != null)
          _btnPalMerchant.Click -= new EventHandler(btnPalMerchant_Click);
        _btnPalMerchant = value;
        if (_btnPalMerchant == null)
          return;
        _btnPalMerchant.Click += new EventHandler(btnPalMerchant_Click);
      }
  }

  internal virtual Button btnPalPlaceable
  {
    get => _btnPalPlaceable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalPlaceable != null)
          _btnPalPlaceable.Click -= new EventHandler(btnPalPlaceable_Click);
        _btnPalPlaceable = value;
        if (_btnPalPlaceable == null)
          return;
        _btnPalPlaceable.Click += new EventHandler(btnPalPlaceable_Click);
      }
  }

  internal virtual Button btnPalWaypoint
  {
    get => _btnPalWaypoint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalWaypoint != null)
          _btnPalWaypoint.Click -= new EventHandler(btnPalWaypoint_Click);
        _btnPalWaypoint = value;
        if (_btnPalWaypoint == null)
          return;
        _btnPalWaypoint.Click += new EventHandler(btnPalWaypoint_Click);
      }
  }

  internal virtual Button btnPalSound
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalSound != null)
          _btnPalSound.Click -= new EventHandler(btnPalSound_Click);
        _btnPalSound = value;
        if (_btnPalSound == null)
          return;
        _btnPalSound.Click += new EventHandler(btnPalSound_Click);
      }
    get => _btnPalSound;
  }

  internal virtual Button btnPalTrigger
  {
    get => _btnPalTrigger;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPalTrigger != null)
          _btnPalTrigger.Click -= new EventHandler(btnPalTrigger_Click);
        _btnPalTrigger = value;
        if (_btnPalTrigger == null)
          return;
        _btnPalTrigger.Click += new EventHandler(btnPalTrigger_Click);
      }
  }

  internal virtual CheckBox chkbShowResRefs
  {
    get => _chkbShowResRefs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbShowResRefs != null)
          _chkbShowResRefs.CheckedChanged -= new EventHandler(chkbShowResRefs_CheckedChanged);
        _chkbShowResRefs = value;
        if (_chkbShowResRefs == null)
          return;
        _chkbShowResRefs.CheckedChanged += new EventHandler(chkbShowResRefs_CheckedChanged);
      }
  }

  internal virtual ToolTip ToolTip1
  {
    get => _ToolTip1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolTip1 == null)
          ;
        _ToolTip1 = value;
        if (_ToolTip1 == null)
          ;
      }
  }

  internal virtual Button btnLogFactors
  {
    get => _btnLogFactors;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnLogFactors != null)
          _btnLogFactors.Click -= new EventHandler(btnLogFactors_Click);
        _btnLogFactors = value;
        if (_btnLogFactors == null)
          return;
        _btnLogFactors.Click += new EventHandler(btnLogFactors_Click);
      }
  }

  internal virtual ImageList ImageList1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ImageList1 == null)
          ;
        _ImageList1 = value;
        if (_ImageList1 == null)
          ;
      }
    get => _ImageList1;
  }

  internal virtual Panel pnlPalette
  {
    get => _pnlPalette;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlPalette == null)
          ;
        _pnlPalette = value;
        if (_pnlPalette == null)
          ;
      }
  }

  internal virtual Panel pnlModElements
  {
    get => _pnlModElements;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlModElements == null)
          ;
        _pnlModElements = value;
        if (_pnlModElements == null)
          ;
      }
  }

  internal virtual MainMenu MainMenu1
  {
    get => _MainMenu1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_MainMenu1 == null)
          ;
        _MainMenu1 = value;
        if (_MainMenu1 == null)
          ;
      }
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

  internal virtual ToolStripMenuItem miSave
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSave != null)
          _miSave.Click -= new EventHandler(miSave_Click);
        _miSave = value;
        if (_miSave == null)
          return;
        _miSave.Click += new EventHandler(miSave_Click);
      }
    get => _miSave;
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem3
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem3 == null)
          ;
        _ToolStripMenuItem3 = value;
        if (_ToolStripMenuItem3 == null)
          ;
      }
    get => _ToolStripMenuItem3;
  }

  internal virtual ToolStripMenuItem miClose
  {
    get => _miClose;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miClose != null)
          _miClose.Click -= new EventHandler(miClose_Click);
        _miClose = value;
        if (_miClose == null)
          return;
        _miClose.Click += new EventHandler(miClose_Click);
      }
  }

  internal virtual ToolStripMenuItem miShowHideModuleElements
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowHideModuleElements != null)
          _miShowHideModuleElements.Click -= new EventHandler(miShowHideModuleElements_Click);
        _miShowHideModuleElements = value;
        if (_miShowHideModuleElements == null)
          return;
        _miShowHideModuleElements.Click += new EventHandler(miShowHideModuleElements_Click);
      }
    get => _miShowHideModuleElements;
  }

  internal virtual ToolStripMenuItem miShowHidePalette
  {
    get => _miShowHidePalette;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowHidePalette != null)
          _miShowHidePalette.Click -= new EventHandler(miShowHidePalette_Click);
        _miShowHidePalette = value;
        if (_miShowHidePalette == null)
          return;
        _miShowHidePalette.Click += new EventHandler(miShowHidePalette_Click);
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

  internal virtual ToolStripMenuItem miShowModulePaths
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowModulePaths != null)
          _miShowModulePaths.Click -= new EventHandler(miShowModulePaths_Click);
        _miShowModulePaths = value;
        if (_miShowModulePaths == null)
          return;
        _miShowModulePaths.Click += new EventHandler(miShowModulePaths_Click);
      }
    get => _miShowModulePaths;
  }

  internal virtual Button btnDebug
  {
    get => _btnDebug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnDebug != null)
          _btnDebug.Click -= new EventHandler(btnDebug_Click);
        _btnDebug = value;
        if (_btnDebug == null)
          return;
        _btnDebug.Click += new EventHandler(btnDebug_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem4
  {
    get => _ToolStripMenuItem4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem4 == null)
          ;
        _ToolStripMenuItem4 = value;
        if (_ToolStripMenuItem4 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miOptions
  {
    get => _miOptions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOptions != null)
          _miOptions.Click -= new EventHandler(miOptions_Click);
        _miOptions = value;
        if (_miOptions == null)
          return;
        _miOptions.Click += new EventHandler(miOptions_Click);
      }
  }

  internal virtual TreeView tvUserPalette
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tvUserPalette != null)
          _tvUserPalette.ItemDrag -= new ItemDragEventHandler(tvUserPalette_ItemDrag);
        _tvUserPalette = value;
        if (_tvUserPalette == null)
          return;
        _tvUserPalette.ItemDrag += new ItemDragEventHandler(tvUserPalette_ItemDrag);
      }
    get => _tvUserPalette;
  }

  internal virtual TabPage TabPage1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPage1 == null)
          ;
        _TabPage1 = value;
        if (_TabPage1 == null)
          ;
      }
    get => _TabPage1;
  }

  internal virtual CheckBox chkbShowNames
  {
    get => _chkbShowNames;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbShowNames != null)
          _chkbShowNames.CheckedChanged -= new EventHandler(chkbShowNames_CheckedChanged);
        _chkbShowNames = value;
        if (_chkbShowNames == null)
          return;
        _chkbShowNames.CheckedChanged += new EventHandler(chkbShowNames_CheckedChanged);
      }
  }

  internal virtual ToolStripMenuItem miRemoveFromOverride
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miRemoveFromOverride == null)
          ;
        _miRemoveFromOverride = value;
        if (_miRemoveFromOverride == null)
          ;
      }
    get => _miRemoveFromOverride;
  }

  internal virtual ToolStripMenuItem miCopyToOverride
  {
    get => _miCopyToOverride;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCopyToOverride == null)
          ;
        _miCopyToOverride = value;
        if (_miCopyToOverride == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miCleanOverride
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCleanOverride == null)
          ;
        _miCleanOverride = value;
        if (_miCleanOverride == null)
          ;
      }
    get => _miCleanOverride;
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

  internal virtual ToolStripMenuItem cmiTvModuleItemEdit
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTvModuleItemEdit != null)
          _cmiTvModuleItemEdit.Click -= new EventHandler(cmiTvModuleItemEdit_Click);
        _cmiTvModuleItemEdit = value;
        if (_cmiTvModuleItemEdit == null)
          return;
        _cmiTvModuleItemEdit.Click += new EventHandler(cmiTvModuleItemEdit_Click);
      }
    get => _cmiTvModuleItemEdit;
  }

  internal virtual ToolStripMenuItem cmiTvModuleItemDelete
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiTvModuleItemDelete != null)
          _cmiTvModuleItemDelete.Click -= new EventHandler(cmiTvModuleItemDelete_Click);
        _cmiTvModuleItemDelete = value;
        if (_cmiTvModuleItemDelete == null)
          return;
        _cmiTvModuleItemDelete.Click += new EventHandler(cmiTvModuleItemDelete_Click);
      }
    get => _cmiTvModuleItemDelete;
  }

  internal virtual Label Label5
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 == null)
          ;
      }
    get => _Label5;
  }

  internal virtual TextBox tbHelp
  {
    get => _tbHelp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbHelp == null)
          ;
        _tbHelp = value;
        if (_tbHelp == null)
          ;
      }
  }

  internal virtual TabPage tabpagUserPalette
  {
    get => _tabpagUserPalette;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagUserPalette == null)
          ;
        _tabpagUserPalette = value;
        if (_tabpagUserPalette == null)
          ;
      }
  }

  internal virtual TabControl tabctrlPalette
  {
    get => _tabctrlPalette;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabctrlPalette != null)
          _tabctrlPalette.SelectedIndexChanged -= new EventHandler(TabControl1_SelectedIndexChanged);
        _tabctrlPalette = value;
        if (_tabctrlPalette == null)
          return;
        _tabctrlPalette.SelectedIndexChanged += new EventHandler(TabControl1_SelectedIndexChanged);
      }
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

  internal virtual ToolStripMenuItem miOpenProject
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpenProject != null)
          _miOpenProject.Click -= new EventHandler(miOpenProject_Click);
        _miOpenProject = value;
        if (_miOpenProject == null)
          return;
        _miOpenProject.Click += new EventHandler(miOpenProject_Click);
      }
    get => _miOpenProject;
  }

  internal virtual TabPage tabpagModuleElements
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagModuleElements == null)
          ;
        _tabpagModuleElements = value;
        if (_tabpagModuleElements == null)
          ;
      }
    get => _tabpagModuleElements;
  }

  internal virtual TabPage tabpagScripts
  {
    get => _tabpagScripts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagScripts == null)
          ;
        _tabpagScripts = value;
        if (_tabpagScripts == null)
          ;
      }
  }

  internal virtual TabControl tabctrlModule
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabctrlModule == null)
          ;
        _tabctrlModule = value;
        if (_tabctrlModule == null)
          ;
      }
    get => _tabctrlModule;
  }

  internal virtual ToolStripMenuItem mnuView
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_mnuView == null)
          ;
        _mnuView = value;
        if (_mnuView == null)
          ;
      }
    get => _mnuView;
  }

  internal virtual ToolStripMenuItem miExploreModuleFolder
  {
    get => _miExploreModuleFolder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miExploreModuleFolder != null)
          _miExploreModuleFolder.Click -= new EventHandler(miExploreModuleFolder_Click);
        _miExploreModuleFolder = value;
        if (_miExploreModuleFolder == null)
          return;
        _miExploreModuleFolder.Click += new EventHandler(miExploreModuleFolder_Click);
      }
  }

  internal virtual ToolStripMenuItem miBuildModFile
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miBuildModFile != null)
          _miBuildModFile.Click -= new EventHandler(miBuildModFile_Click);
        _miBuildModFile = value;
        if (_miBuildModFile == null)
          return;
        _miBuildModFile.Click += new EventHandler(miBuildModFile_Click);
      }
    get => _miBuildModFile;
  }

  internal virtual CheckBox chkbUseFactors
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbUseFactors == null)
          ;
        _chkbUseFactors = value;
        if (_chkbUseFactors == null)
          ;
      }
    get => _chkbUseFactors;
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

  internal virtual ToolStripMenuItem miModuleProperties
  {
    get => _miModuleProperties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miModuleProperties != null)
          _miModuleProperties.Click -= new EventHandler(miModuleProperties_Click);
        _miModuleProperties = value;
        if (_miModuleProperties == null)
          return;
        _miModuleProperties.Click += new EventHandler(miModuleProperties_Click);
      }
  }

  internal virtual ToolStripMenuItem miShowGitDump
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowGitDump != null)
          _miShowGitDump.Click -= new EventHandler(miShowGffDump_Click);
        _miShowGitDump = value;
        if (_miShowGitDump == null)
          return;
        _miShowGitDump.Click += new EventHandler(miShowGffDump_Click);
      }
    get => _miShowGitDump;
  }

  internal virtual ToolStripMenuItem miShowAreDump
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowAreDump != null)
          _miShowAreDump.Click -= new EventHandler(miShowGffDump_Click);
        _miShowAreDump = value;
        if (_miShowAreDump == null)
          return;
        _miShowAreDump.Click += new EventHandler(miShowGffDump_Click);
      }
    get => _miShowAreDump;
  }

  internal virtual ToolStripMenuItem miShowIfoDump
  {
    get => _miShowIfoDump;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowIfoDump != null)
          _miShowIfoDump.Click -= new EventHandler(miShowGffDump_Click);
        _miShowIfoDump = value;
        if (_miShowIfoDump == null)
          return;
        _miShowIfoDump.Click += new EventHandler(miShowGffDump_Click);
      }
  }

  internal virtual StatusBar sbar
  {
    get => _sbar;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbar == null)
          ;
        _sbar = value;
        if (_sbar == null)
          ;
      }
  }

  internal virtual StatusBarPanel sbarpnlLocX
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbarpnlLocX == null)
          ;
        _sbarpnlLocX = value;
        if (_sbarpnlLocX == null)
          ;
      }
    get => _sbarpnlLocX;
  }

  internal virtual StatusBarPanel sbarpnlLocY
  {
    get => _sbarpnlLocY;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbarpnlLocY == null)
          ;
        _sbarpnlLocY = value;
        if (_sbarpnlLocY == null)
          ;
      }
  }

  internal virtual StatusBarPanel sbarpnlDesc
  {
    get => _sbarpnlDesc;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbarpnlDesc == null)
          ;
        _sbarpnlDesc = value;
        if (_sbarpnlDesc == null)
          ;
      }
  }

  internal virtual StatusBarPanel sbarpnlAddlInfo
  {
    get => _sbarpnlAddlInfo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbarpnlAddlInfo == null)
          ;
        _sbarpnlAddlInfo = value;
        if (_sbarpnlAddlInfo == null)
          ;
      }
  }

  internal virtual StatusBarPanel sbarpnlStatus
  {
    get => _sbarpnlStatus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_sbarpnlStatus == null)
          ;
        _sbarpnlStatus = value;
        if (_sbarpnlStatus == null)
          ;
      }
  }

  internal virtual VisualStyleElement.ToolBar ToolBarModElementsFilter
  {
    get => _ToolBarModElementsFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolBarModElementsFilter != null)
          _ToolBarModElementsFilter.ButtonClick -= new ToolBarButtonClickEventHandler(ToolBarModElementsFilter_ButtonClick);
        _ToolBarModElementsFilter = value;
        if (_ToolBarModElementsFilter == null)
          return;
        _ToolBarModElementsFilter.ButtonClick += new ToolBarButtonClickEventHandler(ToolBarModElementsFilter_ButtonClick);
      }
  }

  internal virtual ToolBarButton tbarbtnCreature
  {
    get => _tbarbtnCreature;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnCreature == null)
          ;
        _tbarbtnCreature = value;
        if (_tbarbtnCreature == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnDoor
  {
    get => _tbarbtnDoor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnDoor == null)
          ;
        _tbarbtnDoor = value;
        if (_tbarbtnDoor == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnEncounter
  {
    get => _tbarbtnEncounter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnEncounter == null)
          ;
        _tbarbtnEncounter = value;
        if (_tbarbtnEncounter == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnMerchant
  {
    get => _tbarbtnMerchant;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnMerchant == null)
          ;
        _tbarbtnMerchant = value;
        if (_tbarbtnMerchant == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnPlaceable
  {
    get => _tbarbtnPlaceable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnPlaceable == null)
          ;
        _tbarbtnPlaceable = value;
        if (_tbarbtnPlaceable == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnSound
  {
    get => _tbarbtnSound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnSound == null)
          ;
        _tbarbtnSound = value;
        if (_tbarbtnSound == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnTrigger
  {
    get => _tbarbtnTrigger;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnTrigger == null)
          ;
        _tbarbtnTrigger = value;
        if (_tbarbtnTrigger == null)
          ;
      }
  }

  internal virtual ToolBarButton tbarbtnWaypoint
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbarbtnWaypoint == null)
          ;
        _tbarbtnWaypoint = value;
        if (_tbarbtnWaypoint == null)
          ;
      }
    get => _tbarbtnWaypoint;
  }

  internal virtual ImageList ilModElementsFilter
  {
    get => _ilModElementsFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ilModElementsFilter == null)
          ;
        _ilModElementsFilter = value;
        if (_ilModElementsFilter == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miUseLargeMap
  {
    get => _miUseLargeMap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miUseLargeMap != null)
          _miUseLargeMap.Click -= new EventHandler(miUseLargeMap_Click);
        _miUseLargeMap = value;
        if (_miUseLargeMap == null)
          return;
        _miUseLargeMap.Click += new EventHandler(miUseLargeMap_Click);
      }
  }

  internal virtual ToolStripMenuItem miUseSmallMap
  {
    get => _miUseSmallMap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miUseSmallMap != null)
          _miUseSmallMap.Click -= new EventHandler(miUseSmallMap_Click);
        _miUseSmallMap = value;
        if (_miUseSmallMap == null)
          return;
        _miUseSmallMap.Click += new EventHandler(miUseSmallMap_Click);
      }
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

  internal virtual ToolStripMenuItem miShowItemLabels
  {
    get => _miShowItemLabels;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowItemLabels != null)
          _miShowItemLabels.Click -= new EventHandler(miShowItemLabels_Click);
        _miShowItemLabels = value;
        if (_miShowItemLabels == null)
          return;
        _miShowItemLabels.Click += new EventHandler(miShowItemLabels_Click);
      }
  }

  internal virtual ContextMenu cmPbox
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmPbox == null)
          ;
        _cmPbox = value;
        if (_cmPbox == null)
          ;
      }
    get => _cmPbox;
  }

  internal virtual ToolStripMenuItem cmiModuleProperties
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiModuleProperties != null)
          _cmiModuleProperties.Click -= new EventHandler(cmiModuleProperties_Click);
        _cmiModuleProperties = value;
        if (_cmiModuleProperties == null)
          return;
        _cmiModuleProperties.Click += new EventHandler(cmiModuleProperties_Click);
      }
    get => _cmiModuleProperties;
  }

  internal virtual ToolStripMenuItem cmiCreateCameraHere
  {
    get => _cmiCreateCameraHere;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiCreateCameraHere != null)
          _cmiCreateCameraHere.Click -= new EventHandler(cmiCreateCameraHere_Click);
        _cmiCreateCameraHere = value;
        if (_cmiCreateCameraHere == null)
          return;
        _cmiCreateCameraHere.Click += new EventHandler(cmiCreateCameraHere_Click);
      }
  }

  internal virtual ToolStripMenuItem cmiSetModuleStartPoint
  {
    get => _cmiSetModuleStartPoint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiSetModuleStartPoint != null)
          _cmiSetModuleStartPoint.Click -= new EventHandler(cmiSetModuleStartPoint_Click);
        _cmiSetModuleStartPoint = value;
        if (_cmiSetModuleStartPoint == null)
          return;
        _cmiSetModuleStartPoint.Click += new EventHandler(cmiSetModuleStartPoint_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem13
  {
    get => _ToolStripMenuItem13;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem13 == null)
          ;
        _ToolStripMenuItem13 = value;
        if (_ToolStripMenuItem13 == null)
          ;
      }
  }

  internal virtual CheckBox chkbShowTags
  {
    get => _chkbShowTags;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbShowTags == null)
          ;
        _chkbShowTags = value;
        if (_chkbShowTags == null)
          ;
      }
  }

  internal virtual RepeatButton btnTweakUp
  {
    get => _btnTweakUp;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTweakUp != null)
          _btnTweakUp.Click -= new EventHandler(btnTweakUp_Click);
        _btnTweakUp = value;
        if (_btnTweakUp == null)
          return;
        _btnTweakUp.Click += new EventHandler(btnTweakUp_Click);
      }
  }

  internal virtual RepeatButton btnTweakLeft
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTweakLeft != null)
          _btnTweakLeft.Click -= new EventHandler(btnTweakLeft_Click);
        _btnTweakLeft = value;
        if (_btnTweakLeft == null)
          return;
        _btnTweakLeft.Click += new EventHandler(btnTweakLeft_Click);
      }
    get => _btnTweakLeft;
  }

  internal virtual RepeatButton btnTweakRight
  {
    get => _btnTweakRight;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTweakRight != null)
          _btnTweakRight.Click -= new EventHandler(btnTweakRight_Click);
        _btnTweakRight = value;
        if (_btnTweakRight == null)
          return;
        _btnTweakRight.Click += new EventHandler(btnTweakRight_Click);
      }
  }

  internal virtual RepeatButton btnTweakDown
  {
    get => _btnTweakDown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnTweakDown != null)
          _btnTweakDown.Click -= new EventHandler(btnTweakDown_Click);
        _btnTweakDown = value;
        if (_btnTweakDown == null)
          return;
        _btnTweakDown.Click += new EventHandler(btnTweakDown_Click);
      }
  }

  internal virtual ContextMenu cmMapSurfaceItems
  {
    get => _cmMapSurfaceItems;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmMapSurfaceItems == null)
          ;
        _cmMapSurfaceItems = value;
        if (_cmMapSurfaceItems == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem cmiProperties
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiProperties != null)
          _cmiProperties.Click -= new EventHandler(cmiProperties_Click);
        _cmiProperties = value;
        if (_cmiProperties == null)
          return;
        _cmiProperties.Click += new EventHandler(cmiProperties_Click);
      }
    get => _cmiProperties;
  }

  internal virtual ToolStripMenuItem cmiDelete
  {
    get => _cmiDelete;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiDelete != null)
          _cmiDelete.Click -= new EventHandler(cmiDelete_Click);
        _cmiDelete = value;
        if (_cmiDelete == null)
          return;
        _cmiDelete.Click += new EventHandler(cmiDelete_Click);
      }
  }

  internal virtual ToolStripMenuItem cmiEditGFFFile
  {
    get => _cmiEditGFFFile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiEditGFFFile != null)
          _cmiEditGFFFile.Click -= new EventHandler(cmiEdit_Click);
        _cmiEditGFFFile = value;
        if (_cmiEditGFFFile == null)
          return;
        _cmiEditGFFFile.Click += new EventHandler(cmiEdit_Click);
      }
  }

  internal virtual ToolStripMenuItem cmiAddNewSpawnPoint
  {
    get => _cmiAddNewSpawnPoint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiAddNewSpawnPoint != null)
          _cmiAddNewSpawnPoint.Click -= new EventHandler(cmiAddNewSpawnPoint_Click);
        _cmiAddNewSpawnPoint = value;
        if (_cmiAddNewSpawnPoint == null)
          return;
        _cmiAddNewSpawnPoint.Click += new EventHandler(cmiAddNewSpawnPoint_Click);
      }
  }

  internal virtual ToolStripMenuItem miShowModuleEntryPoint
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miShowModuleEntryPoint != null)
          _miShowModuleEntryPoint.Click -= new EventHandler(miShowModuleEntryPoint_Click);
        _miShowModuleEntryPoint = value;
        if (_miShowModuleEntryPoint == null)
          return;
        _miShowModuleEntryPoint.Click += new EventHandler(miShowModuleEntryPoint_Click);
      }
    get => _miShowModuleEntryPoint;
  }

  internal virtual ListBox lbScripts
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbScripts != null)
          _lbScripts.DoubleClick -= new EventHandler(lbScripts_DoubleClick);
        _lbScripts = value;
        if (_lbScripts == null)
          return;
        _lbScripts.DoubleClick += new EventHandler(lbScripts_DoubleClick);
      }
    get => _lbScripts;
  }

  internal virtual TabPage tabpagDialogs
  {
    get => _tabpagDialogs;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagDialogs == null)
          ;
        _tabpagDialogs = value;
        if (_tabpagDialogs == null)
          ;
      }
  }

  internal virtual ListBox lbDialogs
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbDialogs != null)
          _lbDialogs.DoubleClick -= new EventHandler(lbDialogs_DoubleClick);
        _lbDialogs = value;
        if (_lbDialogs == null)
          return;
        _lbDialogs.DoubleClick += new EventHandler(lbDialogs_DoubleClick);
      }
    get => _lbDialogs;
  }

  internal virtual TextBox tbMouseX
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMouseX == null)
          ;
        _tbMouseX = value;
        if (_tbMouseX == null)
          ;
      }
    get => _tbMouseX;
  }

  internal virtual TextBox tbMouseY
  {
    get => _tbMouseY;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbMouseY == null)
          ;
        _tbMouseY = value;
        if (_tbMouseY == null)
          ;
      }
  }

  internal virtual CheckBox chkbFine
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbFine != null)
          _chkbFine.CheckedChanged -= new EventHandler(chkbFine_CheckedChanged);
        _chkbFine = value;
        if (_chkbFine == null)
          return;
        _chkbFine.CheckedChanged += new EventHandler(chkbFine_CheckedChanged);
      }
    get => _chkbFine;
  }

  internal virtual Button btnAssignPt1
  {
    get => _btnAssignPt1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAssignPt1 != null)
          _btnAssignPt1.Click -= new EventHandler(btnAssignPt1_Click);
        _btnAssignPt1 = value;
        if (_btnAssignPt1 == null)
          return;
        _btnAssignPt1.Click += new EventHandler(btnAssignPt1_Click);
      }
  }

  internal virtual TextBox tb3dsMaxPt1X
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tb3dsMaxPt1X == null)
          ;
        _tb3dsMaxPt1X = value;
        if (_tb3dsMaxPt1X == null)
          ;
      }
    get => _tb3dsMaxPt1X;
  }

  internal virtual TextBox tb3dsMaxPt1Y
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tb3dsMaxPt1Y == null)
          ;
        _tb3dsMaxPt1Y = value;
        if (_tb3dsMaxPt1Y == null)
          ;
      }
    get => _tb3dsMaxPt1Y;
  }

  internal virtual TextBox tb3dsMaxPt2Y
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tb3dsMaxPt2Y == null)
          ;
        _tb3dsMaxPt2Y = value;
        if (_tb3dsMaxPt2Y == null)
          ;
      }
    get => _tb3dsMaxPt2Y;
  }

  internal virtual TextBox tb3dsMaxPt2X
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tb3dsMaxPt2X == null)
          ;
        _tb3dsMaxPt2X = value;
        if (_tb3dsMaxPt2X == null)
          ;
      }
    get => _tb3dsMaxPt2X;
  }

  internal virtual Button btnAssignPt2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAssignPt2 != null)
          _btnAssignPt2.Click -= new EventHandler(btnAssignPt2_Click);
        _btnAssignPt2 = value;
        if (_btnAssignPt2 == null)
          return;
        _btnAssignPt2.Click += new EventHandler(btnAssignPt2_Click);
      }
    get => _btnAssignPt2;
  }

  internal virtual Button btnCalcCalibrationVals
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCalcCalibrationVals != null)
          _btnCalcCalibrationVals.Click -= new EventHandler(btnCalcCalibrationVals_Click);
        _btnCalcCalibrationVals = value;
        if (_btnCalcCalibrationVals == null)
          return;
        _btnCalcCalibrationVals.Click += new EventHandler(btnCalcCalibrationVals_Click);
      }
    get => _btnCalcCalibrationVals;
  }

  internal virtual Button btnCalToolsToggle
  {
    get => _btnCalToolsToggle;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCalToolsToggle != null)
          _btnCalToolsToggle.MouseDown -= new MouseEventHandler(btnCalToolsToggle_MouseDown);
        _btnCalToolsToggle = value;
        if (_btnCalToolsToggle == null)
          return;
        _btnCalToolsToggle.MouseDown += new MouseEventHandler(btnCalToolsToggle_MouseDown);
      }
  }

  internal virtual ToolStripMenuItem miFont
  {
    get => _miFont;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miFont != null)
          _miFont.Click -= new EventHandler(miFont_Click);
        _miFont = value;
        if (_miFont == null)
          return;
        _miFont.Click += new EventHandler(miFont_Click);
      }
  }

  internal virtual ToolStripMenuItem miUseAltSmallMap
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miUseAltSmallMap != null)
          _miUseAltSmallMap.Click -= new EventHandler(miUseAltSmallMap_Click);
        _miUseAltSmallMap = value;
        if (_miUseAltSmallMap == null)
          return;
        _miUseAltSmallMap.Click += new EventHandler(miUseAltSmallMap_Click);
      }
    get => _miUseAltSmallMap;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmModule_Editor));
      Panel1 = new Panel();
      pbox = new PictureBox();
      nudXmul = new NumericUpDown();
      nudYmul = new NumericUpDown();
      nudXoff = new NumericUpDown();
      nudYoff = new NumericUpDown();
      this.btnTest = new Button();
      this.btnClean = new Button();
      tvModule = new TreeView();
      ImageList1 = new ImageList(components);
      tvPalette = new TreeView();
      tvModuleContextToolStripMenuItem = new ContextMenu();
      cmiTvModuleItemDelete = new ToolStripMenuItem();
      cmiTvModuleItemEdit = new ToolStripMenuItem();
      cmiTvModuleItemProperties = new ToolStripMenuItem();
      btnPalDoor = new Button();
      btnPalEncounter = new Button();
      btnPalItem = new Button();
      btnPalCreature = new Button();
      btnPalPlaceable = new Button();
      btnPalMerchant = new Button();
      btnPalWaypoint = new Button();
      btnPalSound = new Button();
      btnPalTrigger = new Button();
      chkbShowResRefs = new CheckBox();
      ToolTip1 = new ToolTip(components);
      btnLogFactors = new Button();
      pnlPalette = new Panel();
      Label5 = new Label();
      tbHelp = new TextBox();
      tabctrlPalette = new TabControl();
      TabPage1 = new TabPage();
      chkbShowNames = new CheckBox();
      tabpagUserPalette = new TabPage();
      tvUserPalette = new TreeView();
      btnCalToolsToggle = new Button();
      pnlModElements = new Panel();
      ToolBarModElementsFilter = new VisualStyleElement.ToolBar();
      tbarbtnCreature = new ToolBarButton();
      tbarbtnDoor = new ToolBarButton();
      tbarbtnEncounter = new ToolBarButton();
      tbarbtnMerchant = new ToolBarButton();
      tbarbtnPlaceable = new ToolBarButton();
      tbarbtnSound = new ToolBarButton();
      tbarbtnTrigger = new ToolBarButton();
      tbarbtnWaypoint = new ToolBarButton();
      ilModElementsFilter = new ImageList(components);
      tabctrlModule = new TabControl();
      tabpagModuleElements = new TabPage();
      tabpagScripts = new TabPage();
      lbScripts = new ListBox();
      tabpagDialogs = new TabPage();
      lbDialogs = new ListBox();
      chkbUseFactors = new CheckBox();
      chkbShowTags = new CheckBox();
      btnTweakUp = new RepeatButton();
      btnTweakLeft = new RepeatButton();
      btnTweakRight = new RepeatButton();
      btnTweakDown = new RepeatButton();
      chkbFine = new CheckBox();
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miOpenProject = new ToolStripMenuItem();
      miSave = new ToolStripMenuItem();
      ToolStripMenuItem3 = new ToolStripMenuItem();
      miBuildModFile = new ToolStripMenuItem();
      ToolStripMenuItem7 = new ToolStripMenuItem();
      miExploreModuleFolder = new ToolStripMenuItem();
      miCopyToOverride = new ToolStripMenuItem();
      miRemoveFromOverride = new ToolStripMenuItem();
      miCleanOverride = new ToolStripMenuItem();
      ToolStripMenuItem9 = new ToolStripMenuItem();
      miClose = new ToolStripMenuItem();
      ToolStripMenuItem2 = new ToolStripMenuItem();
      miModuleProperties = new ToolStripMenuItem();
      mnuView = new ToolStripMenuItem();
      miShowHideModuleElements = new ToolStripMenuItem();
      miShowHidePalette = new ToolStripMenuItem();
      miShowItemLabels = new ToolStripMenuItem();
      ToolStripMenuItem6 = new ToolStripMenuItem();
      miUseSmallMap = new ToolStripMenuItem();
      miUseLargeMap = new ToolStripMenuItem();
      miUseAltSmallMap = new ToolStripMenuItem();
      ToolStripMenuItem11 = new ToolStripMenuItem();
      miShowModuleEntryPoint = new ToolStripMenuItem();
      miShowModulePaths = new ToolStripMenuItem();
      miFont = new ToolStripMenuItem();
      ToolStripMenuItem4 = new ToolStripMenuItem();
      miShowGitDump = new ToolStripMenuItem();
      miShowAreDump = new ToolStripMenuItem();
      miShowIfoDump = new ToolStripMenuItem();
      ToolStripMenuItem5 = new ToolStripMenuItem();
      miOptions = new ToolStripMenuItem();
      btnDebug = new Button();
      sbar = new StatusBar();
      sbarpnlLocX = new StatusBarPanel();
      sbarpnlLocY = new StatusBarPanel();
      sbarpnlDesc = new StatusBarPanel();
      sbarpnlAddlInfo = new StatusBarPanel();
      sbarpnlStatus = new StatusBarPanel();
      cmPbox = new ContextMenu();
      cmiCreateCameraHere = new ToolStripMenuItem();
      cmiSetModuleStartPoint = new ToolStripMenuItem();
      ToolStripMenuItem13 = new ToolStripMenuItem();
      cmiModuleProperties = new ToolStripMenuItem();
      cmMapSurfaceItems = new ContextMenu();
      cmiDelete = new ToolStripMenuItem();
      cmiEditGFFFile = new ToolStripMenuItem();
      cmiProperties = new ToolStripMenuItem();
      cmiAddNewSpawnPoint = new ToolStripMenuItem();
      tbMouseX = new TextBox();
      tbMouseY = new TextBox();
      btnAssignPt1 = new Button();
      btnAssignPt2 = new Button();
      tb3dsMaxPt1X = new TextBox();
      tb3dsMaxPt1Y = new TextBox();
      tb3dsMaxPt2Y = new TextBox();
      tb3dsMaxPt2X = new TextBox();
      btnCalcCalibrationVals = new Button();
      Panel1.SuspendLayout();
      nudXmul.BeginInit();
      nudYmul.BeginInit();
      nudXoff.BeginInit();
      nudYoff.BeginInit();
      pnlPalette.SuspendLayout();
      tabctrlPalette.SuspendLayout();
      TabPage1.SuspendLayout();
      tabpagUserPalette.SuspendLayout();
      pnlModElements.SuspendLayout();
      tabctrlModule.SuspendLayout();
      tabpagModuleElements.SuspendLayout();
      tabpagScripts.SuspendLayout();
      tabpagDialogs.SuspendLayout();
      sbarpnlLocX.BeginInit();
      sbarpnlLocY.BeginInit();
      sbarpnlDesc.BeginInit();
      sbarpnlAddlInfo.BeginInit();
      sbarpnlStatus.BeginInit();
      SuspendLayout();
      Panel1.AllowDrop = true;
      Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      Panel1.AutoScroll = true;
      Panel1.BorderStyle = BorderStyle.FixedSingle;
      Panel1.Controls.Add(pbox);
      Panel1.Enabled = false;
      Panel panel1_1 = Panel1;
      Point point1 = new Point(200, 8);
      Point point2 = point1;
      panel1_1.Location = point2;
      Panel1.Name = "Panel1";
      Panel panel1_2 = Panel1;
      Size size1 = new Size(424, 424);
      Size size2 = size1;
      panel1_2.Size = size2;
      Panel1.TabIndex = 5;
      pbox.BorderStyle = BorderStyle.FixedSingle;
      PictureBox pbox1 = pbox;
      point1 = new Point(0, 0);
      Point point3 = point1;
      pbox1.Location = point3;
      pbox.Name = "pbox";
      PictureBox pbox2 = pbox;
      size1 = new Size(96, 80);
      Size size3 = size1;
      pbox2.Size = size3;
      pbox.SizeMode = PictureBoxSizeMode.CenterImage;
      pbox.TabIndex = 0;
      pbox.TabStop = false;
      pbox.Visible = false;
      nudXmul.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      nudXmul.DecimalPlaces = 2;
      NumericUpDown nudXmul1 = nudXmul;
      Decimal num1 = new Decimal(new int[4]
      {
        1,
        0,
        0,
        131072
      });
      Decimal num2 = num1;
      nudXmul1.Increment = num2;
      NumericUpDown nudXmul2 = nudXmul;
      point1 = new Point(8, 354);
      Point point4 = point1;
      nudXmul2.Location = point4;
      NumericUpDown nudXmul3 = nudXmul;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 262144 });
      Decimal num3 = num1;
      nudXmul3.Minimum = num3;
      nudXmul.Name = "nudXmul";
      NumericUpDown nudXmul4 = nudXmul;
      size1 = new Size(64, 20);
      Size size4 = size1;
      nudXmul4.Size = size4;
      nudXmul.TabIndex = 0;
      nudXmul.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudXmul5 = nudXmul;
      num1 = new Decimal(new int[4]{ 125, 0, 0, 65536 });
      Decimal num4 = num1;
      nudXmul5.Value = num4;
      nudXmul.Visible = false;
      nudYmul.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      nudYmul.DecimalPlaces = 2;
      NumericUpDown nudYmul1 = nudYmul;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 131072 });
      Decimal num5 = num1;
      nudYmul1.Increment = num5;
      NumericUpDown nudYmul2 = nudYmul;
      point1 = new Point(85, 354);
      Point point5 = point1;
      nudYmul2.Location = point5;
      NumericUpDown nudYmul3 = nudYmul;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 262144 });
      Decimal num6 = num1;
      nudYmul3.Minimum = num6;
      nudYmul.Name = "nudYmul";
      NumericUpDown nudYmul4 = nudYmul;
      size1 = new Size(64, 20);
      Size size5 = size1;
      nudYmul4.Size = size5;
      nudYmul.TabIndex = 1;
      nudYmul.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudYmul5 = nudYmul;
      num1 = new Decimal(new int[4]{ 125, 0, 0, 65536 });
      Decimal num7 = num1;
      nudYmul5.Value = num7;
      nudYmul.Visible = false;
      nudXoff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      NumericUpDown nudXoff1 = nudXoff;
      point1 = new Point(8, 376);
      Point point6 = point1;
      nudXoff1.Location = point6;
      NumericUpDown nudXoff2 = nudXoff;
      num1 = new Decimal(new int[4]{ 20000, 0, 0, 0 });
      Decimal num8 = num1;
      nudXoff2.Maximum = num8;
      NumericUpDown nudXoff3 = nudXoff;
      num1 = new Decimal(new int[4]
      {
        20000,
        0,
        0,
        int.MinValue
      });
      Decimal num9 = num1;
      nudXoff3.Minimum = num9;
      nudXoff.Name = "nudXoff";
      NumericUpDown nudXoff4 = nudXoff;
      size1 = new Size(64, 20);
      Size size6 = size1;
      nudXoff4.Size = size6;
      nudXoff.TabIndex = 2;
      nudXoff.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudXoff5 = nudXoff;
      num1 = new Decimal(new int[4]{ 838, 0, 0, 0 });
      Decimal num10 = num1;
      nudXoff5.Value = num10;
      nudXoff.Visible = false;
      nudYoff.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      NumericUpDown nudYoff1 = nudYoff;
      point1 = new Point(85, 376);
      Point point7 = point1;
      nudYoff1.Location = point7;
      NumericUpDown nudYoff2 = nudYoff;
      num1 = new Decimal(new int[4]{ 20000, 0, 0, 0 });
      Decimal num11 = num1;
      nudYoff2.Maximum = num11;
      NumericUpDown nudYoff3 = nudYoff;
      num1 = new Decimal(new int[4]
      {
        20000,
        0,
        0,
        int.MinValue
      });
      Decimal num12 = num1;
      nudYoff3.Minimum = num12;
      nudYoff.Name = "nudYoff";
      NumericUpDown nudYoff4 = nudYoff;
      size1 = new Size(64, 20);
      Size size7 = size1;
      nudYoff4.Size = size7;
      nudYoff.TabIndex = 3;
      nudYoff.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudYoff5 = nudYoff;
      num1 = new Decimal(new int[4]{ 846, 0, 0, 0 });
      Decimal num13 = num1;
      nudYoff5.Value = num13;
      nudYoff.Visible = false;
      this.btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnTest = this.btnTest;
      point1 = new Point(664, 440);
      Point point8 = point1;
      btnTest.Location = point8;
      this.btnTest.Name = "btnTest";
      this.btnTest.TabIndex = 4;
      this.btnTest.Text = "Test";
      this.btnTest.Visible = false;
      this.btnClean.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnClean = this.btnClean;
      point1 = new Point(760, 440);
      Point point9 = point1;
      btnClean.Location = point9;
      this.btnClean.Name = "btnClean";
      this.btnClean.TabIndex = 4;
      this.btnClean.Text = "Clean";
      this.btnClean.Visible = false;
      tvModule.Dock = DockStyle.Fill;
      tvModule.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      tvModule.ImageList = ImageList1;
      tvModule.Indent = 19;
      TreeView tvModule1 = tvModule;
      point1 = new Point(0, 0);
      Point point10 = point1;
      tvModule1.Location = point10;
      tvModule.Name = "tvModule";
      TreeView tvModule2 = tvModule;
      size1 = new Size(184, 216);
      Size size8 = size1;
      tvModule2.Size = size8;
      tvModule.TabIndex = 8;
      ImageList imageList1 = ImageList1;
      size1 = new Size(16, 16);
      Size size9 = size1;
      imageList1.ImageSize = size9;
      ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
      ImageList1.TransparentColor = Color.Transparent;
      tvPalette.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      tvPalette.ImageIndex = -1;
      TreeView tvPalette1 = tvPalette;
      point1 = new Point(8, 40);
      Point point11 = point1;
      tvPalette1.Location = point11;
      tvPalette.Name = "tvPalette";
      tvPalette.SelectedImageIndex = -1;
      TreeView tvPalette2 = tvPalette;
      size1 = new Size(208, 192);
      Size size10 = size1;
      tvPalette2.Size = size10;
      tvPalette.TabIndex = 9;
      tvModuleContextToolStripMenuItem.ToolStripMenuItems.AddRange(new ToolStripMenuItem[3]
      {
        cmiTvModuleItemDelete,
        cmiTvModuleItemEdit,
        cmiTvModuleItemProperties
      });
      cmiTvModuleItemDelete.Index = 0;
      cmiTvModuleItemDelete.Text = "Delete...";
      cmiTvModuleItemEdit.Index = 1;
      cmiTvModuleItemEdit.Text = "Edit GFF File...";
      cmiTvModuleItemProperties.Index = 2;
      cmiTvModuleItemProperties.Text = "Properties in Module...";
      btnPalDoor.Image = (Image) resourceManager.GetObject("btnPalDoor.Image");
      btnPalDoor.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalDoor1 = btnPalDoor;
      point1 = new Point(34, 8);
      Point point12 = point1;
      btnPalDoor1.Location = point12;
      btnPalDoor.Name = "btnPalDoor";
      Button btnPalDoor2 = btnPalDoor;
      size1 = new Size(22, 22);
      Size size11 = size1;
      btnPalDoor2.Size = size11;
      btnPalDoor.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalDoor, "Doors");
      btnPalEncounter.Image = (Image) resourceManager.GetObject("btnPalEncounter.Image");
      btnPalEncounter.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalEncounter1 = btnPalEncounter;
      point1 = new Point(61, 8);
      Point point13 = point1;
      btnPalEncounter1.Location = point13;
      btnPalEncounter.Name = "btnPalEncounter";
      Button btnPalEncounter2 = btnPalEncounter;
      size1 = new Size(22, 22);
      Size size12 = size1;
      btnPalEncounter2.Size = size12;
      btnPalEncounter.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalEncounter, "Encounters");
      btnPalItem.Enabled = false;
      btnPalItem.Image = (Image) resourceManager.GetObject("btnPalItem.Image");
      btnPalItem.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalItem1 = btnPalItem;
      point1 = new Point(128, 16);
      Point point14 = point1;
      btnPalItem1.Location = point14;
      btnPalItem.Name = "btnPalItem";
      Button btnPalItem2 = btnPalItem;
      size1 = new Size(22, 22);
      Size size13 = size1;
      btnPalItem2.Size = size13;
      btnPalItem.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalItem, "Items");
      btnPalItem.Visible = false;
      btnPalCreature.BackColor = SystemColors.Control;
      btnPalCreature.Image = (Image) resourceManager.GetObject("btnPalCreature.Image");
      btnPalCreature.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalCreature1 = btnPalCreature;
      point1 = new Point(7, 8);
      Point point15 = point1;
      btnPalCreature1.Location = point15;
      btnPalCreature.Name = "btnPalCreature";
      Button btnPalCreature2 = btnPalCreature;
      size1 = new Size(22, 22);
      Size size14 = size1;
      btnPalCreature2.Size = size14;
      btnPalCreature.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalCreature, "Creatures");
      btnPalPlaceable.Image = (Image) resourceManager.GetObject("btnPalPlaceable.Image");
      btnPalPlaceable.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalPlaceable1 = btnPalPlaceable;
      point1 = new Point(115, 8);
      Point point16 = point1;
      btnPalPlaceable1.Location = point16;
      btnPalPlaceable.Name = "btnPalPlaceable";
      Button btnPalPlaceable2 = btnPalPlaceable;
      size1 = new Size(22, 22);
      Size size15 = size1;
      btnPalPlaceable2.Size = size15;
      btnPalPlaceable.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalPlaceable, "Placeables");
      btnPalMerchant.Image = (Image) resourceManager.GetObject("btnPalMerchant.Image");
      btnPalMerchant.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalMerchant1 = btnPalMerchant;
      point1 = new Point(88, 8);
      Point point17 = point1;
      btnPalMerchant1.Location = point17;
      btnPalMerchant.Name = "btnPalMerchant";
      Button btnPalMerchant2 = btnPalMerchant;
      size1 = new Size(22, 22);
      Size size16 = size1;
      btnPalMerchant2.Size = size16;
      btnPalMerchant.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalMerchant, "Merchants");
      btnPalWaypoint.Image = (Image) resourceManager.GetObject("btnPalWaypoint.Image");
      btnPalWaypoint.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalWaypoint1 = btnPalWaypoint;
      point1 = new Point(195, 8);
      Point point18 = point1;
      btnPalWaypoint1.Location = point18;
      btnPalWaypoint.Name = "btnPalWaypoint";
      Button btnPalWaypoint2 = btnPalWaypoint;
      size1 = new Size(22, 22);
      Size size17 = size1;
      btnPalWaypoint2.Size = size17;
      btnPalWaypoint.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalWaypoint, "Waypoints");
      btnPalSound.Image = (Image) resourceManager.GetObject("btnPalSound.Image");
      btnPalSound.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalSound1 = btnPalSound;
      point1 = new Point(141, 8);
      Point point19 = point1;
      btnPalSound1.Location = point19;
      btnPalSound.Name = "btnPalSound";
      Button btnPalSound2 = btnPalSound;
      size1 = new Size(22, 22);
      Size size18 = size1;
      btnPalSound2.Size = size18;
      btnPalSound.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalSound, "Sounds");
      btnPalTrigger.Image = (Image) resourceManager.GetObject("btnPalTrigger.Image");
      btnPalTrigger.ImageAlign = ContentAlignment.BottomRight;
      Button btnPalTrigger1 = btnPalTrigger;
      point1 = new Point(168, 8);
      Point point20 = point1;
      btnPalTrigger1.Location = point20;
      btnPalTrigger.Name = "btnPalTrigger";
      Button btnPalTrigger2 = btnPalTrigger;
      size1 = new Size(22, 22);
      Size size19 = size1;
      btnPalTrigger2.Size = size19;
      btnPalTrigger.TabIndex = 10;
      ToolTip1.SetToolTip(btnPalTrigger, "Triggers");
      chkbShowResRefs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      CheckBox chkbShowResRefs1 = chkbShowResRefs;
      point1 = new Point(117, 235);
      Point point21 = point1;
      chkbShowResRefs1.Location = point21;
      chkbShowResRefs.Name = "chkbShowResRefs";
      CheckBox chkbShowResRefs2 = chkbShowResRefs;
      size1 = new Size(98, 24);
      Size size20 = size1;
      chkbShowResRefs2.Size = size20;
      chkbShowResRefs.TabIndex = 11;
      chkbShowResRefs.Text = "Show ResRefs";
      btnLogFactors.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnLogFactors1 = btnLogFactors;
      point1 = new Point(154, 376);
      Point point22 = point1;
      btnLogFactors1.Location = point22;
      btnLogFactors.Name = "btnLogFactors";
      Button btnLogFactors2 = btnLogFactors;
      size1 = new Size(32, 23);
      Size size21 = size1;
      btnLogFactors2.Size = size21;
      btnLogFactors.TabIndex = 4;
      btnLogFactors.Text = "Log factors";
      btnLogFactors.Visible = false;
      pnlPalette.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      pnlPalette.Controls.Add(Label5);
      pnlPalette.Controls.Add(tbHelp);
      pnlPalette.Controls.Add(tabctrlPalette);
      Panel pnlPalette1 = pnlPalette;
      point1 = new Point(632, 8);
      Point point23 = point1;
      pnlPalette1.Location = point23;
      pnlPalette.Name = "pnlPalette";
      Panel pnlPalette2 = pnlPalette;
      size1 = new Size(232, 424);
      Size size22 = size1;
      pnlPalette2.Size = size22;
      pnlPalette.TabIndex = 13;
      Label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label5_1 = Label5;
      point1 = new Point(16, 312);
      Point point24 = point1;
      label5_1.Location = point24;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(56, 16);
      Size size23 = size1;
      label5_2.Size = size23;
      Label5.TabIndex = 14;
      Label5.Text = "Help Info";
      tbHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tbHelp1 = tbHelp;
      point1 = new Point(8, 328);
      Point point25 = point1;
      tbHelp1.Location = point25;
      tbHelp.Multiline = true;
      tbHelp.Name = "tbHelp";
      TextBox tbHelp2 = tbHelp;
      size1 = new Size(208, 88);
      Size size24 = size1;
      tbHelp2.Size = size24;
      tbHelp.TabIndex = 13;
      tbHelp.Text = "";
      tabctrlPalette.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      tabctrlPalette.Controls.Add(TabPage1);
      tabctrlPalette.Controls.Add(tabpagUserPalette);
      tabctrlPalette.Enabled = false;
      TabControl tabctrlPalette1 = tabctrlPalette;
      point1 = new Point(0, 8);
      Point point26 = point1;
      tabctrlPalette1.Location = point26;
      tabctrlPalette.Name = "tabctrlPalette";
      tabctrlPalette.SelectedIndex = 0;
      TabControl tabctrlPalette2 = tabctrlPalette;
      size1 = new Size(228, 288);
      Size size25 = size1;
      tabctrlPalette2.Size = size25;
      tabctrlPalette.TabIndex = 12;
      TabPage1.Controls.Add(btnPalWaypoint);
      TabPage1.Controls.Add(btnPalSound);
      TabPage1.Controls.Add(btnPalTrigger);
      TabPage1.Controls.Add(btnPalDoor);
      TabPage1.Controls.Add(btnPalEncounter);
      TabPage1.Controls.Add(btnPalCreature);
      TabPage1.Controls.Add(btnPalPlaceable);
      TabPage1.Controls.Add(btnPalMerchant);
      TabPage1.Controls.Add(tvPalette);
      TabPage1.Controls.Add(chkbShowResRefs);
      TabPage1.Controls.Add(chkbShowNames);
      TabPage1.Controls.Add(btnPalItem);
      TabPage tabPage1_1 = TabPage1;
      point1 = new Point(4, 22);
      Point point27 = point1;
      ((Control) tabPage1_1).Location = point27;
      TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = TabPage1;
      size1 = new Size(220, 262);
      Size size26 = size1;
      tabPage1_2.Size = size26;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "Standard";
      chkbShowNames.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      chkbShowNames.Checked = true;
      chkbShowNames.CheckState = CheckState.Checked;
      CheckBox chkbShowNames1 = chkbShowNames;
      point1 = new Point(11, 235);
      Point point28 = point1;
      chkbShowNames1.Location = point28;
      chkbShowNames.Name = "chkbShowNames";
      CheckBox chkbShowNames2 = chkbShowNames;
      size1 = new Size(96, 24);
      Size size27 = size1;
      chkbShowNames2.Size = size27;
      chkbShowNames.TabIndex = 11;
      chkbShowNames.Text = "Show Names";
      tabpagUserPalette.Controls.Add(tvUserPalette);
      TabPage tabpagUserPalette1 = tabpagUserPalette;
      point1 = new Point(4, 22);
      Point point29 = point1;
      ((Control) tabpagUserPalette1).Location = point29;
      tabpagUserPalette.Name = "tabpagUserPalette";
      TabPage tabpagUserPalette2 = tabpagUserPalette;
      size1 = new Size(220, 262);
      Size size28 = size1;
      tabpagUserPalette2.Size = size28;
      tabpagUserPalette.TabIndex = 1;
      tabpagUserPalette.Text = "User";
      tvUserPalette.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      tvUserPalette.ImageIndex = -1;
      TreeView tvUserPalette1 = tvUserPalette;
      point1 = new Point(8, 16);
      Point point30 = point1;
      tvUserPalette1.Location = point30;
      tvUserPalette.Name = "tvUserPalette";
      tvUserPalette.Nodes.AddRange(new TreeNode[7]
      {
        new TreeNode("Creatures"),
        new TreeNode("Doors"),
        new TreeNode("Encounters"),
        new TreeNode("Stores"),
        new TreeNode("Placeables"),
        new TreeNode("Sounds"),
        new TreeNode("Triggers")
      });
      tvUserPalette.SelectedImageIndex = -1;
      TreeView tvUserPalette2 = tvUserPalette;
      size1 = new Size(200, 232);
      Size size29 = size1;
      tvUserPalette2.Size = size29;
      tvUserPalette.TabIndex = 9;
      btnCalToolsToggle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnCalToolsToggle.BackColor = SystemColors.Control;
      btnCalToolsToggle.FlatStyle = FlatStyle.Flat;
      btnCalToolsToggle.ForeColor = SystemColors.Control;
      Button btnCalToolsToggle1 = btnCalToolsToggle;
      point1 = new Point(616, 436);
      Point point31 = point1;
      btnCalToolsToggle1.Location = point31;
      btnCalToolsToggle.Name = "btnCalToolsToggle";
      Button btnCalToolsToggle2 = btnCalToolsToggle;
      size1 = new Size(8, 8);
      Size size30 = size1;
      btnCalToolsToggle2.Size = size30;
      btnCalToolsToggle.TabIndex = 8;
      btnCalToolsToggle.TabStop = false;
      pnlModElements.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      pnlModElements.Controls.Add(ToolBarModElementsFilter);
      pnlModElements.Controls.Add(tabctrlModule);
      pnlModElements.Controls.Add(nudXmul);
      pnlModElements.Controls.Add(nudYmul);
      pnlModElements.Controls.Add(nudXoff);
      pnlModElements.Controls.Add(nudYoff);
      pnlModElements.Controls.Add(chkbUseFactors);
      pnlModElements.Controls.Add(btnLogFactors);
      pnlModElements.Controls.Add(chkbShowTags);
      pnlModElements.Controls.Add(btnTweakUp);
      pnlModElements.Controls.Add(btnTweakLeft);
      pnlModElements.Controls.Add(btnTweakRight);
      pnlModElements.Controls.Add(btnTweakDown);
      pnlModElements.Controls.Add(chkbFine);
      Panel pnlModElements1 = pnlModElements;
      point1 = new Point(0, 8);
      Point point32 = point1;
      pnlModElements1.Location = point32;
      pnlModElements.Name = "pnlModElements";
      Panel pnlModElements2 = pnlModElements;
      size1 = new Size(192, 424);
      Size size31 = size1;
      pnlModElements2.Size = size31;
      pnlModElements.TabIndex = 15;
      ToolBarModElementsFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      ToolBarModElementsFilter.BorderStyle = BorderStyle.FixedSingle;
      ToolBarModElementsFilter.Buttons.AddRange(new ToolBarButton[8]
      {
        tbarbtnCreature,
        tbarbtnDoor,
        tbarbtnEncounter,
        tbarbtnMerchant,
        tbarbtnPlaceable,
        tbarbtnSound,
        tbarbtnTrigger,
        tbarbtnWaypoint
      });
      ToolBarModElementsFilter.Divider = false;
      ToolBarModElementsFilter.Dock = DockStyle.None;
      ToolBarModElementsFilter.DropDownArrows = true;
      ToolBarModElementsFilter.Enabled = false;
      ToolBarModElementsFilter.ImageList = ilModElementsFilter;
      VisualStyleElement.ToolBar modElementsFilter1 = ToolBarModElementsFilter;
      point1 = new Point(16, 304);
      Point point33 = point1;
      modElementsFilter1.Location = point33;
      ToolBarModElementsFilter.Name = "ToolBarModElementsFilter";
      ToolBarModElementsFilter.ShowToolTips = true;
      VisualStyleElement.ToolBar modElementsFilter2 = ToolBarModElementsFilter;
      size1 = new Size(96, 49);
      Size size32 = size1;
      modElementsFilter2.Size = size32;
      ToolBarModElementsFilter.TabIndex = 18;
      tbarbtnCreature.ImageIndex = 0;
      tbarbtnCreature.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnCreature.ToolTipText = "Show Creatures";
      tbarbtnDoor.ImageIndex = 1;
      tbarbtnDoor.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnDoor.ToolTipText = "Show Doors";
      tbarbtnEncounter.ImageIndex = 2;
      tbarbtnEncounter.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnEncounter.ToolTipText = "Show Encounters";
      tbarbtnMerchant.ImageIndex = 3;
      tbarbtnMerchant.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnMerchant.ToolTipText = "Show Merchants";
      tbarbtnPlaceable.ImageIndex = 4;
      tbarbtnPlaceable.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnPlaceable.ToolTipText = "Show Placeables";
      tbarbtnSound.ImageIndex = 5;
      tbarbtnSound.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnSound.ToolTipText = "Show Sounds";
      tbarbtnTrigger.ImageIndex = 6;
      tbarbtnTrigger.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnTrigger.ToolTipText = "Show Triggers";
      tbarbtnWaypoint.ImageIndex = 7;
      tbarbtnWaypoint.Style = ToolBarButtonStyle.ToggleButton;
      tbarbtnWaypoint.ToolTipText = "Show Waypoints";
      ImageList modElementsFilter3 = ilModElementsFilter;
      size1 = new Size(16, 16);
      Size size33 = size1;
      modElementsFilter3.ImageSize = size33;
      ilModElementsFilter.ImageStream = (ImageListStreamer) resourceManager.GetObject("ilModElementsFilter.ImageStream");
      ilModElementsFilter.TransparentColor = Color.Transparent;
      tabctrlModule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      tabctrlModule.Controls.Add(tabpagModuleElements);
      tabctrlModule.Controls.Add(tabpagScripts);
      tabctrlModule.Controls.Add(tabpagDialogs);
      TabControl tabctrlModule1 = tabctrlModule;
      size1 = new Size(93, 20);
      Size size34 = size1;
      tabctrlModule1.ItemSize = size34;
      TabControl tabctrlModule2 = tabctrlModule;
      point1 = new Point(0, 8);
      Point point34 = point1;
      tabctrlModule2.Location = point34;
      tabctrlModule.Multiline = true;
      tabctrlModule.Name = "tabctrlModule";
      TabControl tabctrlModule3 = tabctrlModule;
      point1 = new Point(8, 3);
      Point point35 = point1;
      tabctrlModule3.Padding = point35;
      tabctrlModule.SelectedIndex = 0;
      TabControl tabctrlModule4 = tabctrlModule;
      size1 = new Size(192, 264);
      Size size35 = size1;
      tabctrlModule4.Size = size35;
      tabctrlModule.SizeMode = TabSizeMode.FillToRight;
      tabctrlModule.TabIndex = 13;
      tabpagModuleElements.Controls.Add(tvModule);
      TabPage tabpagModuleElements1 = tabpagModuleElements;
      point1 = new Point(4, 44);
      Point point36 = point1;
      ((Control) tabpagModuleElements1).Location = point36;
      tabpagModuleElements.Name = "tabpagModuleElements";
      TabPage tabpagModuleElements2 = tabpagModuleElements;
      size1 = new Size(184, 216);
      Size size36 = size1;
      tabpagModuleElements2.Size = size36;
      tabpagModuleElements.TabIndex = 0;
      tabpagModuleElements.Text = "Module Elements";
      tabpagScripts.Controls.Add(lbScripts);
      TabPage tabpagScripts1 = tabpagScripts;
      point1 = new Point(4, 44);
      Point point37 = point1;
      ((Control) tabpagScripts1).Location = point37;
      tabpagScripts.Name = "tabpagScripts";
      TabPage tabpagScripts2 = tabpagScripts;
      size1 = new Size(184, 216);
      Size size37 = size1;
      tabpagScripts2.Size = size37;
      tabpagScripts.TabIndex = 1;
      tabpagScripts.Text = "Scripts";
      lbScripts.AllowDrop = true;
      lbScripts.Dock = DockStyle.Fill;
      ListBox lbScripts1 = lbScripts;
      point1 = new Point(0, 0);
      Point point38 = point1;
      lbScripts1.Location = point38;
      lbScripts.Name = "lbScripts";
      ListBox lbScripts2 = lbScripts;
      size1 = new Size(184, 216);
      Size size38 = size1;
      lbScripts2.Size = size38;
      lbScripts.Sorted = true;
      lbScripts.TabIndex = 0;
      tabpagDialogs.Controls.Add(lbDialogs);
      TabPage tabpagDialogs1 = tabpagDialogs;
      point1 = new Point(4, 44);
      Point point39 = point1;
      ((Control) tabpagDialogs1).Location = point39;
      tabpagDialogs.Name = "tabpagDialogs";
      TabPage tabpagDialogs2 = tabpagDialogs;
      size1 = new Size(184, 216);
      Size size39 = size1;
      tabpagDialogs2.Size = size39;
      tabpagDialogs.TabIndex = 2;
      tabpagDialogs.Text = "Dialogs";
      lbDialogs.AllowDrop = true;
      lbDialogs.Dock = DockStyle.Fill;
      ListBox lbDialogs1 = lbDialogs;
      point1 = new Point(0, 0);
      Point point40 = point1;
      lbDialogs1.Location = point40;
      lbDialogs.Name = "lbDialogs";
      ListBox lbDialogs2 = lbDialogs;
      size1 = new Size(184, 216);
      Size size40 = size1;
      lbDialogs2.Size = size40;
      lbDialogs.Sorted = true;
      lbDialogs.TabIndex = 1;
      chkbUseFactors.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      CheckBox chkbUseFactors1 = chkbUseFactors;
      point1 = new Point(8, 400);
      Point point41 = point1;
      chkbUseFactors1.Location = point41;
      chkbUseFactors.Name = "chkbUseFactors";
      CheckBox chkbUseFactors2 = chkbUseFactors;
      size1 = new Size(112, 16);
      Size size41 = size1;
      chkbUseFactors2.Size = size41;
      chkbUseFactors.TabIndex = 17;
      chkbUseFactors.Text = "Use these factors";
      chkbUseFactors.Visible = false;
      chkbShowTags.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      chkbShowTags.Enabled = false;
      CheckBox chkbShowTags1 = chkbShowTags;
      point1 = new Point(56, 280);
      Point point42 = point1;
      chkbShowTags1.Location = point42;
      chkbShowTags.Name = "chkbShowTags";
      CheckBox chkbShowTags2 = chkbShowTags;
      size1 = new Size(80, 16);
      Size size42 = size1;
      chkbShowTags2.Size = size42;
      chkbShowTags.TabIndex = 17;
      chkbShowTags.Text = "Show Tags";
      btnTweakUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnTweakUp.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      btnTweakUp.Interval = 100;
      RepeatButton btnTweakUp1 = btnTweakUp;
      point1 = new Point(160, 296);
      Point point43 = point1;
      btnTweakUp1.Location = point43;
      btnTweakUp.Name = "btnTweakUp";
      RepeatButton btnTweakUp2 = btnTweakUp;
      size1 = new Size(16, 16);
      Size size43 = size1;
      btnTweakUp2.Size = size43;
      btnTweakUp.TabIndex = 4;
      btnTweakUp.Text = "^";
      btnTweakUp.TextAlign = ContentAlignment.TopLeft;
      btnTweakLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnTweakLeft.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      btnTweakLeft.Interval = 100;
      RepeatButton btnTweakLeft1 = btnTweakLeft;
      point1 = new Point(144, 312);
      Point point44 = point1;
      btnTweakLeft1.Location = point44;
      btnTweakLeft.Name = "btnTweakLeft";
      RepeatButton btnTweakLeft2 = btnTweakLeft;
      size1 = new Size(16, 16);
      Size size44 = size1;
      btnTweakLeft2.Size = size44;
      btnTweakLeft.TabIndex = 4;
      btnTweakLeft.Text = "<";
      btnTweakLeft.TextAlign = ContentAlignment.MiddleLeft;
      btnTweakRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnTweakRight.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      btnTweakRight.Interval = 100;
      RepeatButton btnTweakRight1 = btnTweakRight;
      point1 = new Point(176, 312);
      Point point45 = point1;
      btnTweakRight1.Location = point45;
      btnTweakRight.Name = "btnTweakRight";
      RepeatButton btnTweakRight2 = btnTweakRight;
      size1 = new Size(16, 16);
      Size size45 = size1;
      btnTweakRight2.Size = size45;
      btnTweakRight.TabIndex = 4;
      btnTweakRight.Text = ">";
      btnTweakRight.TextAlign = ContentAlignment.MiddleLeft;
      btnTweakDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnTweakDown.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      btnTweakDown.Interval = 100;
      RepeatButton btnTweakDown1 = btnTweakDown;
      point1 = new Point(160, 328);
      Point point46 = point1;
      btnTweakDown1.Location = point46;
      btnTweakDown.Name = "btnTweakDown";
      RepeatButton btnTweakDown2 = btnTweakDown;
      size1 = new Size(16, 16);
      Size size46 = size1;
      btnTweakDown2.Size = size46;
      btnTweakDown.TabIndex = 4;
      btnTweakDown.Text = "v";
      btnTweakDown.TextAlign = ContentAlignment.MiddleLeft;
      chkbFine.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      CheckBox chkbFine1 = chkbFine;
      point1 = new Point(128, 400);
      Point point47 = point1;
      chkbFine1.Location = point47;
      chkbFine.Name = "chkbFine";
      CheckBox chkbFine2 = chkbFine;
      size1 = new Size(48, 16);
      Size size47 = size1;
      chkbFine2.Size = size47;
      chkbFine.TabIndex = 17;
      chkbFine.Text = "Fine";
      chkbFine.Visible = false;
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[4]
      {
        ToolStripMenuItem1,
        ToolStripMenuItem2,
        mnuView,
        ToolStripMenuItem4
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[11]
      {
        miOpenProject,
        miSave,
        ToolStripMenuItem3,
        miBuildModFile,
        ToolStripMenuItem7,
        miExploreModuleFolder,
        miCopyToOverride,
        miRemoveFromOverride,
        miCleanOverride,
        ToolStripMenuItem9,
        miClose
      });
      ToolStripMenuItem1.Text = "&File";
      miOpenProject.Index = 0;
      miOpenProject.Shortcut = Shortcut.CtrlO;
      miOpenProject.Text = "&Open Module Project...";
      miSave.Enabled = false;
      miSave.Index = 1;
      miSave.Shortcut = Shortcut.CtrlS;
      miSave.Text = "&Save changes";
      ToolStripMenuItem3.Index = 2;
      ToolStripMenuItem3.Text = "-";
      miBuildModFile.Enabled = false;
      miBuildModFile.Index = 3;
      miBuildModFile.Shortcut = Shortcut.F5;
      miBuildModFile.Text = "&Build Mod file...";
      ToolStripMenuItem7.Index = 4;
      ToolStripMenuItem7.Text = "-";
      miExploreModuleFolder.Enabled = false;
      miExploreModuleFolder.Index = 5;
      miExploreModuleFolder.Text = "Explore &Module folder";
      miCopyToOverride.Index = 6;
      miCopyToOverride.Text = "Copy Project to Override folder";
      miCopyToOverride.Visible = false;
      miRemoveFromOverride.Index = 7;
      miRemoveFromOverride.Text = "Remove Project from Override folder";
      miRemoveFromOverride.Visible = false;
      miCleanOverride.Index = 8;
      miCleanOverride.Text = "Clean Override folder";
      miCleanOverride.Visible = false;
      ToolStripMenuItem9.Index = 9;
      ToolStripMenuItem9.Text = "-";
      miClose.Index = 10;
      miClose.Text = "&Close";
      ToolStripMenuItem2.Index = 1;
      ToolStripMenuItem2.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        miModuleProperties
      });
      ToolStripMenuItem2.Text = "&Edit";
      miModuleProperties.Enabled = false;
      miModuleProperties.Index = 0;
      miModuleProperties.Shortcut = Shortcut.CtrlM;
      miModuleProperties.Text = "Module &Properties...";
      mnuView.Index = 2;
      mnuView.ToolStripMenuItems.AddRange(new ToolStripMenuItem[11]
      {
        miShowHideModuleElements,
        miShowHidePalette,
        miShowItemLabels,
        ToolStripMenuItem6,
        miUseSmallMap,
        miUseLargeMap,
        miUseAltSmallMap,
        ToolStripMenuItem11,
        miShowModuleEntryPoint,
        miShowModulePaths,
        miFont
      });
      mnuView.Text = "&View";
      miShowHideModuleElements.Checked = true;
      miShowHideModuleElements.Enabled = false;
      miShowHideModuleElements.Index = 0;
      miShowHideModuleElements.Shortcut = Shortcut.F1;
      miShowHideModuleElements.Text = "&Module Elements";
      miShowHidePalette.Checked = true;
      miShowHidePalette.Enabled = false;
      miShowHidePalette.Index = 1;
      miShowHidePalette.Shortcut = Shortcut.F2;
      miShowHidePalette.Text = "&Palette";
      miShowItemLabels.Enabled = false;
      miShowItemLabels.Index = 2;
      miShowItemLabels.Shortcut = Shortcut.F4;
      miShowItemLabels.Text = "&Item Labels";
      ToolStripMenuItem6.Index = 3;
      ToolStripMenuItem6.Text = "-";
      miUseSmallMap.Enabled = false;
      miUseSmallMap.Index = 4;
      miUseSmallMap.Text = "Use &small map backgound";
      miUseLargeMap.Enabled = false;
      miUseLargeMap.Index = 5;
      miUseLargeMap.Text = "Use &large map backgound";
      miUseAltSmallMap.Enabled = false;
      miUseAltSmallMap.Index = 6;
      miUseAltSmallMap.Text = "Use alternate map bkgnd";
      ToolStripMenuItem11.Index = 7;
      ToolStripMenuItem11.Text = "-";
      miShowModuleEntryPoint.Enabled = false;
      miShowModuleEntryPoint.Index = 8;
      miShowModuleEntryPoint.Text = "Show Module Entry Point";
      miShowModulePaths.Enabled = false;
      miShowModulePaths.Index = 9;
      miShowModulePaths.Text = "&Show Module Paths";
      miFont.Index = 10;
      miFont.Text = "Label Font...";
      ToolStripMenuItem4.Index = 3;
      ToolStripMenuItem4.ToolStripMenuItems.AddRange(new ToolStripMenuItem[5]
      {
        miShowGitDump,
        miShowAreDump,
        miShowIfoDump,
        ToolStripMenuItem5,
        miOptions
      });
      ToolStripMenuItem4.Text = "&Tools";
      miShowGitDump.Enabled = false;
      miShowGitDump.Index = 0;
      miShowGitDump.Text = "Show GIT dump";
      miShowAreDump.Enabled = false;
      miShowAreDump.Index = 1;
      miShowAreDump.Text = "Show ARE dump";
      miShowIfoDump.Enabled = false;
      miShowIfoDump.Index = 2;
      miShowIfoDump.Text = "Show IFO dump";
      ToolStripMenuItem5.Index = 3;
      ToolStripMenuItem5.Text = "-";
      miOptions.Enabled = false;
      miOptions.Index = 4;
      miOptions.Text = "&Options...";
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point48 = point1;
      btnDebug1.Location = point48;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size48 = size1;
      btnDebug2.Size = size48;
      btnDebug.TabIndex = 16;
      btnDebug.TabStop = false;
      StatusBar sbar1 = sbar;
      point1 = new Point(0, 451);
      Point point49 = point1;
      sbar1.Location = point49;
      sbar.Name = "sbar";
      sbar.Panels.AddRange(new StatusBarPanel[5]
      {
        sbarpnlLocX,
        sbarpnlLocY,
        sbarpnlDesc,
        sbarpnlAddlInfo,
        sbarpnlStatus
      });
      sbar.ShowPanels = true;
      StatusBar sbar2 = sbar;
      size1 = new Size(864, 22);
      Size size49 = size1;
      sbar2.Size = size49;
      sbar.TabIndex = 18;
      sbar.Text = "StatusBar1";
      sbarpnlLocX.Width = 70;
      sbarpnlLocY.Width = 70;
      sbarpnlDesc.Width = 120;
      sbarpnlAddlInfo.Width = 180;
      sbarpnlStatus.AutoSize = StatusBarPanelAutoSize.Spring;
      sbarpnlStatus.Width = 408;
      cmPbox.ToolStripMenuItems.AddRange(new ToolStripMenuItem[4]
      {
        cmiCreateCameraHere,
        cmiSetModuleStartPoint,
        ToolStripMenuItem13,
        cmiModuleProperties
      });
      cmiCreateCameraHere.Index = 0;
      cmiCreateCameraHere.Text = "Create Camera here";
      cmiSetModuleStartPoint.Index = 1;
      cmiSetModuleStartPoint.Text = "Set as Module starting point";
      ToolStripMenuItem13.Index = 2;
      ToolStripMenuItem13.Text = "-";
      cmiModuleProperties.Index = 3;
      cmiModuleProperties.Text = "Module Properties...";
      cmMapSurfaceItems.ToolStripMenuItems.AddRange(new ToolStripMenuItem[4]
      {
        cmiDelete,
        cmiEditGFFFile,
        cmiProperties,
        cmiAddNewSpawnPoint
      });
      cmiDelete.Index = 0;
      cmiDelete.Text = "Delete from Module...";
      cmiEditGFFFile.Index = 1;
      cmiEditGFFFile.Text = "Edit GFF File...";
      cmiProperties.Index = 2;
      cmiProperties.Text = "Properties in Module...";
      cmiAddNewSpawnPoint.Index = 3;
      cmiAddNewSpawnPoint.Text = "Add New SpawnPoint";
      tbMouseX.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tbMouseX1 = tbMouseX;
      point1 = new Point(0, 432);
      Point point50 = point1;
      tbMouseX1.Location = point50;
      tbMouseX.Name = "tbMouseX";
      TextBox tbMouseX2 = tbMouseX;
      size1 = new Size(64, 20);
      Size size50 = size1;
      tbMouseX2.Size = size50;
      tbMouseX.TabIndex = 0;
      tbMouseX.Text = "";
      tbMouseX.Visible = false;
      tbMouseY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tbMouseY1 = tbMouseY;
      point1 = new Point(88, 432);
      Point point51 = point1;
      tbMouseY1.Location = point51;
      tbMouseY.Name = "tbMouseY";
      TextBox tbMouseY2 = tbMouseY;
      size1 = new Size(64, 20);
      Size size51 = size1;
      tbMouseY2.Size = size51;
      tbMouseY.TabIndex = 1;
      tbMouseY.Text = "";
      tbMouseY.Visible = false;
      btnAssignPt1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnAssignPt1_1 = btnAssignPt1;
      point1 = new Point(160, 435);
      Point point52 = point1;
      btnAssignPt1_1.Location = point52;
      btnAssignPt1.Name = "btnAssignPt1";
      Button btnAssignPt1_2 = btnAssignPt1;
      size1 = new Size(16, 16);
      Size size52 = size1;
      btnAssignPt1_2.Size = size52;
      btnAssignPt1.TabIndex = 2;
      btnAssignPt1.Text = "1";
      btnAssignPt1.Visible = false;
      btnAssignPt2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnAssignPt2_1 = btnAssignPt2;
      point1 = new Point(184, 435);
      Point point53 = point1;
      btnAssignPt2_1.Location = point53;
      btnAssignPt2.Name = "btnAssignPt2";
      Button btnAssignPt2_2 = btnAssignPt2;
      size1 = new Size(16, 16);
      Size size53 = size1;
      btnAssignPt2_2.Size = size53;
      btnAssignPt2.TabIndex = 3;
      btnAssignPt2.Text = "2";
      btnAssignPt2.Visible = false;
      tb3dsMaxPt1X.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tb3dsMaxPt1X1 = tb3dsMaxPt1X;
      point1 = new Point(264, 432);
      Point point54 = point1;
      tb3dsMaxPt1X1.Location = point54;
      tb3dsMaxPt1X.Name = "tb3dsMaxPt1X";
      TextBox tb3dsMaxPt1X2 = tb3dsMaxPt1X;
      size1 = new Size(64, 20);
      Size size54 = size1;
      tb3dsMaxPt1X2.Size = size54;
      tb3dsMaxPt1X.TabIndex = 4;
      tb3dsMaxPt1X.Text = "110.516";
      tb3dsMaxPt1X.Visible = false;
      tb3dsMaxPt1Y.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tb3dsMaxPt1Y1 = tb3dsMaxPt1Y;
      point1 = new Point(344, 432);
      Point point55 = point1;
      tb3dsMaxPt1Y1.Location = point55;
      tb3dsMaxPt1Y.Name = "tb3dsMaxPt1Y";
      TextBox tb3dsMaxPt1Y2 = tb3dsMaxPt1Y;
      size1 = new Size(64, 20);
      Size size55 = size1;
      tb3dsMaxPt1Y2.Size = size55;
      tb3dsMaxPt1Y.TabIndex = 5;
      tb3dsMaxPt1Y.Text = "133.604";
      tb3dsMaxPt1Y.Visible = false;
      tb3dsMaxPt2Y.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tb3dsMaxPt2Y1 = tb3dsMaxPt2Y;
      point1 = new Point(528, 432);
      Point point56 = point1;
      tb3dsMaxPt2Y1.Location = point56;
      tb3dsMaxPt2Y.Name = "tb3dsMaxPt2Y";
      TextBox tb3dsMaxPt2Y2 = tb3dsMaxPt2Y;
      size1 = new Size(64, 20);
      Size size56 = size1;
      tb3dsMaxPt2Y2.Size = size56;
      tb3dsMaxPt2Y.TabIndex = 7;
      tb3dsMaxPt2Y.Text = "78.001";
      tb3dsMaxPt2Y.Visible = false;
      tb3dsMaxPt2X.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      TextBox tb3dsMaxPt2X1 = tb3dsMaxPt2X;
      point1 = new Point(448, 432);
      Point point57 = point1;
      tb3dsMaxPt2X1.Location = point57;
      tb3dsMaxPt2X.Name = "tb3dsMaxPt2X";
      TextBox tb3dsMaxPt2X2 = tb3dsMaxPt2X;
      size1 = new Size(64, 20);
      Size size57 = size1;
      tb3dsMaxPt2X2.Size = size57;
      tb3dsMaxPt2X.TabIndex = 6;
      tb3dsMaxPt2X.Text = "105.987";
      tb3dsMaxPt2X.Visible = false;
      btnCalcCalibrationVals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnCalcCalibrationVals.Enabled = false;
      Button calcCalibrationVals1 = btnCalcCalibrationVals;
      point1 = new Point(208, 435);
      Point point58 = point1;
      calcCalibrationVals1.Location = point58;
      btnCalcCalibrationVals.Name = "btnCalcCalibrationVals";
      Button calcCalibrationVals2 = btnCalcCalibrationVals;
      size1 = new Size(16, 16);
      Size size58 = size1;
      calcCalibrationVals2.Size = size58;
      btnCalcCalibrationVals.TabIndex = 8;
      btnCalcCalibrationVals.Text = "C";
      btnCalcCalibrationVals.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(864, 473);
      ClientSize = size1;
      Controls.Add(btnAssignPt1);
      Controls.Add(tbMouseX);
      Controls.Add(sbar);
      Controls.Add(btnDebug);
      Controls.Add(pnlModElements);
      Controls.Add(pnlPalette);
      Controls.Add(this.btnTest);
      Controls.Add(Panel1);
      Controls.Add(this.btnClean);
      Controls.Add(tbMouseY);
      Controls.Add(btnAssignPt2);
      Controls.Add(tb3dsMaxPt1X);
      Controls.Add(tb3dsMaxPt1Y);
      Controls.Add(tb3dsMaxPt2Y);
      Controls.Add(tb3dsMaxPt2X);
      Controls.Add(btnCalcCalibrationVals);
      Controls.Add(btnCalToolsToggle);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Menu = MainMenu1;
      size1 = new Size(576, 480);
      MinimumSize = size1;
      Name = nameof (frmModule_Editor);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Module Editor";
      Panel1.ResumeLayout(false);
      nudXmul.EndInit();
      nudYmul.EndInit();
      nudXoff.EndInit();
      nudYoff.EndInit();
      pnlPalette.ResumeLayout(false);
      tabctrlPalette.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      tabpagUserPalette.ResumeLayout(false);
      pnlModElements.ResumeLayout(false);
      tabctrlModule.ResumeLayout(false);
      tabpagModuleElements.ResumeLayout(false);
      tabpagScripts.ResumeLayout(false);
      tabpagDialogs.ResumeLayout(false);
      sbarpnlLocX.EndInit();
      sbarpnlLocY.EndInit();
      sbarpnlDesc.EndInit();
      sbarpnlAddlInfo.EndInit();
      sbarpnlStatus.EndInit();
      ResumeLayout(false);
    }

  public bool Setup(string ProjectPath)
  {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      g_form = this;
      CurrentSettings = UserSettings.GetSettings();
      gModuleEditorSettings = ModuleEditorProjectSettings.GetSettings(ProjectPath);
      while (ProjectPath.EndsWith("\\"))
        ProjectPath = ProjectPath.Substring(0, checked (ProjectPath.Length - 1));
      g_ProjectPath = ProjectPath;
      if (StringType.StrCmp(gModuleEditorSettings.ModuleEditorModOutputPath, "", false) == 0)
        gModuleEditorSettings.ModuleEditorModOutputPath = g_ProjectPath;
      if (!Directory.Exists(g_ProjectPath + "\\extras"))
        Directory.CreateDirectory(g_ProjectPath + "\\extras");
      if (Directory.GetFiles(g_ProjectPath, "*.git").Length == 0)
      {
        int num = (int) Interaction.MsgBox("It would appear that your module is missing it's .git file.", MsgBoxStyle.Critical, "Module load error");
        return false;
      }
      string file = Directory.GetFiles(g_ProjectPath, "*.git")[0];
      g_MapName = Path.GetFileNameWithoutExtension(file);
      KotorVersionIndex = FrmMain.GetGffFileKotorVersionIndex(file);
      SetEditorCaption();
      g_UserPalettePath = g_ProjectPath + "\\userpalette";
      g_GlobalTemplatesPath = FrmMain.GRootPath + "\\Global Templates\\k" + StringType.FromInteger(checked (KotorVersionIndex + 1));
      htTemplateBifFiles = FrmMain.KxChitinKey(KotorVersionIndex).GetBifFileHash("templates");
      try
      {
        Stream serializationStream = File.OpenRead(FrmMain.GRootPath + "K1TemplateTags.bfd");
        htK1Tags = (Hashtable) binaryFormatter.Deserialize(serializationStream);
        serializationStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        Stream serializationStream = File.OpenRead(FrmMain.GRootPath + "K2TemplateTags.bfd");
        htK2Tags = (Hashtable) binaryFormatter.Deserialize(serializationStream);
        serializationStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\dialog.tlk");
      bool flag1;
      try
      {
        GITfile = new ClsGff(new FileStream(file, FileMode.Open, FileAccess.Read), KotorVersionIndex);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox("It would appear that your module .GIT file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error");
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_62;
      }
      try
      {
        IFOfile = new ClsGff(new FileStream(Path.Combine(Path.GetDirectoryName(file), "module.ifo"), FileMode.Open, FileAccess.Read), KotorVersionIndex);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox("It would appear that your Module.ifo file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error");
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_62;
      }
      Stream stream;
      try
      {
        stream = new FileStream(file.ToLower().Replace(".git", ".are"), FileMode.Open, FileAccess.Read);
        AREfile = new ClsGff((FileStream) stream, KotorVersionIndex);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox("It would appear that your module .ARE file is missing or corrupted. Extract a fresh copy.", MsgBoxStyle.Critical, "Module load error");
        flag1 = false;
        ProjectData.ClearProjectError();
        goto label_62;
      }
      g_MapName = Path.GetFileNameWithoutExtension(file).ToLower();
      g_SmallMapAvailable = File.Exists(g_mapsPath + "map" + g_MapName + ".map");
      g_LargeMapAvailable = File.Exists(g_mapsPath + "map" + g_MapName + "_lg.map");
      g_AltSmallMapAvailable = File.Exists(g_mapsPath + "map" + g_MapName + "_alt.map");
      if (!(g_SmallMapAvailable | g_LargeMapAvailable))
      {
        int num = (int) MessageBox.Show("You do not have a .map file for this module in your Kotor Tool 'Maps' directory.\n\nUse the '' menu item on the main Tools menu to see if this module is supported.\n\nIf it is, you will need to obtain the map file, put in the 'Maps' directory, and reload this module.", "Missing .map file", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return false;
      }
      miUseSmallMap.Enabled = g_SmallMapAvailable;
      miUseLargeMap.Enabled = g_LargeMapAvailable;
      miUseAltSmallMap.Enabled = g_AltSmallMapAvailable;
      if (StringType.StrCmp(gModuleEditorSettings.MapSize, "small", false) == 0 && !g_SmallMapAvailable && g_LargeMapAvailable)
        gModuleEditorSettings.MapSize = "large";
      if (StringType.StrCmp(gModuleEditorSettings.MapSize, "large", false) == 0 && !g_LargeMapAvailable && g_SmallMapAvailable)
        gModuleEditorSettings.MapSize = "small";
      if (StringType.StrCmp(gModuleEditorSettings.MapSize, "altsmall", false) == 0 && !g_AltSmallMapAvailable)
      {
        if (g_SmallMapAvailable)
          gModuleEditorSettings.MapSize = "small";
        else if (g_LargeMapAvailable)
          gModuleEditorSettings.MapSize = "large";
      }
      if (StringType.StrCmp(gModuleEditorSettings.MapSize, "", false) == 0 | StringType.StrCmp(gModuleEditorSettings.MapSize, "small", false) == 0 && g_SmallMapAvailable)
      {
        g_mapImageName = "map" + g_MapName + ".map";
        g_MapTypeInUse = 0;
        g_UsingLargeMap = false;
        miUseSmallMap.Checked = true;
        miUseLargeMap.Checked = false;
        miUseAltSmallMap.Checked = false;
      }
      else if (StringType.StrCmp(gModuleEditorSettings.MapSize, "", false) == 0 | StringType.StrCmp(gModuleEditorSettings.MapSize, "large", false) == 0 && g_LargeMapAvailable)
      {
        g_mapImageName = "map" + g_MapName + "_lg.map";
        g_MapTypeInUse = 1;
        g_UsingLargeMap = true;
        miUseSmallMap.Checked = false;
        miUseLargeMap.Checked = true;
        miUseAltSmallMap.Checked = false;
      }
      else if (StringType.StrCmp(gModuleEditorSettings.MapSize, "altsmall", false) == 0 && g_AltSmallMapAvailable)
      {
        g_mapImageName = "map" + g_MapName + "_alt.map";
        g_MapTypeInUse = 2;
        miUseSmallMap.Checked = false;
        miUseLargeMap.Checked = false;
        miUseAltSmallMap.Checked = true;
      }
      if (!chkbUseFactors.Checked)
      {
        MapInfo graph;
        try
        {
          stream = File.OpenRead(FrmMain.GRootPath + "MapInfo.bfd");
          graph = (MapInfo) binaryFormatter.Deserialize(stream);
          stream.Close();
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          stream.Seek(0L, SeekOrigin.Begin);
          graph = (MapInfo) frmMapInfoStatus.CreateMapInfoFormatter(Type.GetType("kotor_tool.MapInfo")).Deserialize(stream);
          stream.Close();
          if (graph.GetType() == Type.GetType("kotor_tool.MapInfo"))
          {
            Stream serializationStream = File.OpenWrite(FrmMain.GRootPath + "MapInfo.bfd");
            new BinaryFormatter().Serialize(serializationStream, graph);
            serializationStream.Close();
          }
          else
          {
            int num = (int) Interaction.MsgBox("Unable to load MapInfo.bfd file.\n\nPlease download a fresh copy.", MsgBoxStyle.Critical, "MapInfo error");
          }
          ProjectData.ClearProjectError();
        }
        bool flag2 = false;
        try
        {
          foreach (MapInfo.Map map in graph.MapList)
          {
            if (StringType.StrCmp(g_MapName, map.MapName, false) == 0)
            {
              if (g_UsingLargeMap)
              {
                if (!map.L)
                  break;
              }
              if (!g_UsingLargeMap)
              {
                if (!map.S)
                  break;
              }
              flag2 = true;
              switch (g_MapTypeInUse)
              {
                case 0:
                  nudXmul.Value = map.SXMul;
                  nudYmul.Value = map.SYMul;
                  nudXoff.Value = new Decimal(map.SXOff);
                  nudYoff.Value = new Decimal(map.SYOff);
                  goto label_59;
                case 1:
                  nudXmul.Value = map.LXMul;
                  nudYmul.Value = map.LYMul;
                  nudXoff.Value = new Decimal(map.LXOff);
                  nudYoff.Value = new Decimal(map.LYOff);
                  goto label_59;
                case 2:
                  nudXmul.Value = map.AltSXMul;
                  nudYmul.Value = map.AltSYMul;
                  nudXoff.Value = new Decimal(map.AltSXOff);
                  nudYoff.Value = new Decimal(map.AltSYOff);
                  goto label_59;
                default:
                  goto label_59;
              }
            }
          }
        }
        finally
        {
         
        }
label_59:
        if (!flag2)
        {
          int num = (int) Interaction.MsgBox("You have the map for this module, but the MapInfo file appears to be incorrect or out-of date.", MsgBoxStyle.Critical, "Map Info missing");
          return false;
        }
      }
      UpdateVisibilityBtnsWithSettings();
      chkbShowTags.CheckedChanged += new EventHandler(chkbShowTags_CheckedChanged);
      bmp = null;
      bmp_cache = null;
      LoadBackground();
      pbox.Size = bmp.Size;
      BuildUserPaletteTreeView();
      BuildScriptsPalette();
      BuildDialogsPalette();
      DisableFileSystemWatchers();
      CreateFileSystemWatchers();
      EnableControls(true);
      Panel1.AutoScrollPosition = new Point(gModuleEditorSettings.LastScrollPosX, gModuleEditorSettings.LastScrollPosY);
      return true;
label_62:
      return flag1;
    }

  private void UpdateVisibilityBtnsWithSettings()
  {
      tbarbtnCreature.Pushed = gModuleEditorSettings.FilterShowCreatures;
      tbarbtnDoor.Pushed = gModuleEditorSettings.FilterShowDoors;
      tbarbtnEncounter.Pushed = gModuleEditorSettings.FilterShowEncounters;
      tbarbtnMerchant.Pushed = gModuleEditorSettings.FilterShowMerchants;
      tbarbtnPlaceable.Pushed = gModuleEditorSettings.FilterShowPlaceables;
      tbarbtnSound.Pushed = gModuleEditorSettings.FilterShowSounds;
      tbarbtnTrigger.Pushed = gModuleEditorSettings.FilterShowTriggers;
      tbarbtnWaypoint.Pushed = gModuleEditorSettings.FilterShowWaypoints;
      chkbShowTags.Checked = gModuleEditorSettings.ShowTagsOnModulePalette;
    }

  private void CreateFileSystemWatchers()
  {
      if (!Directory.Exists(g_ProjectPath + "\\userpalette"))
        Directory.CreateDirectory(g_ProjectPath + "\\userpalette");
      g_UserPalettteFsw.Path = g_ProjectPath + "\\userpalette";
      g_UserPalettteFsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.CreationTime;
      g_UserPalettteFsw.SynchronizingObject = this;
      g_UserPalettteFsw.Created += new FileSystemEventHandler(OnUserPaletteFSChanged);
      g_UserPalettteFsw.Deleted += new FileSystemEventHandler(OnUserPaletteFSChanged);
      g_UserPalettteFsw.Renamed += new RenamedEventHandler(OnUserPaletteFSChanged);
      g_ProjectFsw.Path = g_ProjectPath;
      g_ProjectFsw.NotifyFilter = NotifyFilters.FileName | NotifyFilters.CreationTime;
      g_ProjectFsw.SynchronizingObject = this;
      g_ProjectFsw.Created += new FileSystemEventHandler(OnProjectFSChanged);
      g_ProjectFsw.Deleted += new FileSystemEventHandler(OnProjectFSChanged);
      g_ProjectFsw.Renamed += new RenamedEventHandler(OnProjectFSChanged);
      g_UserPalettteFsw.EnableRaisingEvents = true;
      g_ProjectFsw.EnableRaisingEvents = true;
    }

  private void DisableFileSystemWatchers()
  {
      if (g_UserPalettteFsw.EnableRaisingEvents)
      {
        g_UserPalettteFsw.EnableRaisingEvents = false;
        g_UserPalettteFsw.Created -= new FileSystemEventHandler(OnUserPaletteFSChanged);
        g_UserPalettteFsw.Deleted -= new FileSystemEventHandler(OnUserPaletteFSChanged);
        g_UserPalettteFsw.Renamed -= new RenamedEventHandler(OnUserPaletteFSChanged);
      }
      if (!g_ProjectFsw.EnableRaisingEvents)
        return;
      g_ProjectFsw.EnableRaisingEvents = false;
      g_ProjectFsw.Created -= new FileSystemEventHandler(OnProjectFSChanged);
      g_ProjectFsw.Deleted -= new FileSystemEventHandler(OnProjectFSChanged);
      g_ProjectFsw.Renamed -= new RenamedEventHandler(OnProjectFSChanged);
    }

  private void OnUserPaletteFSChanged(object source, FileSystemEventArgs e)
  {
      BuildUserPaletteTreeView();
      Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger((int) e.ChangeType));
    }

  private void OnUserPaletteFSChanged(object source, RenamedEventArgs e)
  {
      g_form.BuildUserPaletteTreeView();
      Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger((int) e.ChangeType));
    }

  private void OnProjectFSChanged(object source, FileSystemEventArgs e)
  {
      string extension = Path.GetExtension(e.Name.ToLower());
      if (StringType.StrCmp(extension, ".nss", false) == 0)
        BuildScriptsPalette();
      else if (StringType.StrCmp(extension, ".dlg", false) == 0)
        BuildDialogsPalette();
      Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger((int) e.ChangeType));
    }

  private void OnProjectFSChanged(object source, RenamedEventArgs e)
  {
      string extension = Path.GetExtension(e.Name.ToLower());
      if (StringType.StrCmp(extension, ".nss", false) == 0)
        BuildScriptsPalette();
      else if (StringType.StrCmp(extension, ".dlg", false) == 0)
        BuildDialogsPalette();
      Console.WriteLine("File: " + e.FullPath + " " + StringType.FromInteger((int) e.ChangeType));
    }

  private void BuildScriptsPalette()
  {
      lbScripts.Items.Clear();
      FileInfo[] files = new DirectoryInfo(g_ProjectPath).GetFiles("*.nss");
      int index = 0;
      while (index < files.Length)
      {
        lbScripts.Items.Add(Path.GetFileNameWithoutExtension(files[index].Name));
        checked { ++index; }
      }
    }

  private void BuildDialogsPalette()
  {
      lbDialogs.Items.Clear();
      FileInfo[] files = new DirectoryInfo(g_ProjectPath).GetFiles("*.dlg");
      int index = 0;
      while (index < files.Length)
      {
        lbDialogs.Items.Add(Path.GetFileNameWithoutExtension(files[index].Name));
        checked { ++index; }
      }
    }

  public void LoadBackground()
  {
      if (bmp_cache == null)
      {
        switch (g_MapTypeInUse)
        {
          case 0:
            bmp = new Bitmap(g_mapsPath + "map" + g_MapName + ".map");
            break;
          case 1:
            bmp = new Bitmap(g_mapsPath + "map" + g_MapName + "_lg.map");
            break;
          case 2:
            bmp = new Bitmap(g_mapsPath + "map" + g_MapName + "_alt.map");
            break;
        }
        bmp_cache = bmp.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), bmp.PixelFormat);
      }
      else
        bmp = bmp_cache.Clone(new Rectangle(0, 0, bmp.Width, bmp.Height), bmp.PixelFormat);
      g_imageYsize = bmp.Height;
    }

  public void Draw()
  {
      Font font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      float num1 = SingleType.FromObject(IFOfile.GetNodeValue("Mod_Entry_X"));
      float num2 = SingleType.FromObject(IFOfile.GetNodeValue("Mod_Entry_Y"));
      int o1_1 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * num1))), nudXoff.Value));
      int o1_2 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * num2))), nudYoff.Value)));
      Pen pen1 = new Pen(Color.White, 1f);
      pen1.SetLineCap(LineCap.NoAnchor, LineCap.ArrowAnchor, DashCap.Flat);
      try
      {
        Graphics o = Graphics.FromImage(bmp);
        object[] objArray = new object[5]
        {
          pen1,
          o1_1,
          o1_2,
          ObjectType.AddObj(o1_1, ObjectType.MulObj(IFOfile.GetNodeValue("Mod_Entry_Dir_X"), nudXmul.Value)),
          ObjectType.SubObj(o1_2, ObjectType.MulObj(IFOfile.GetNodeValue("Mod_Entry_Dir_Y"), nudYmul.Value))
        };
        object[] args = objArray;
        bool[] flagArray = new bool[5]
        {
          true,
          true,
          true,
          false,
          false
        };
        bool[] CopyBack = flagArray;
        LateBinding.LateCall(o, null, "DrawLine", args, null, CopyBack);
        if (flagArray[2])
          o1_2 = IntegerType.FromObject(objArray[2]);
        if (flagArray[1])
          o1_1 = IntegerType.FromObject(objArray[1]);
        if (flagArray[0])
        {
          Pen pen2 = (Pen) objArray[0];
        }
        Graphics.FromImage(bmp).DrawEllipse(new Pen(Color.Red, 2f), checked (o1_1 - 6), checked (o1_2 - 6), 12, 12);
      }
      catch (SystemException ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      long ticks = DateAndTime.Now.Ticks;
      CreatureArr = new ModItem[checked (GITfile.GetListItemCount("Creature List") - 1 + 1)];
      int upperBound1 = CreatureArr.GetUpperBound(0);
      int index1 = 0;
      while (index1 <= upperBound1)
      {
        float X = SingleType.FromObject(GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(index1) + ").XPosition"));
        float Y = SingleType.FromObject(GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(index1) + ").YPosition"));
        int num3 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * X))), nudXoff.Value));
        int num4 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        object vLeft = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(index1) + ").TemplateResRef"));
        CreatureArr[index1] = new ModItem(num3, num4, X, Y, StringType.FromObject(vLeft), "Creature List(" + StringType.FromInteger(index1) + ")");
        CreatureArr[index1].XPosAccessor = "XPosition";
        CreatureArr[index1].YPosAccessor = "YPosition";
        CreatureArr[index1].ZPosAccessor = "ZPosition";
        CreatureArr[index1].ItemType = 2027;
        if (CreatureArr[index1].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), num3, num4);
        if (gModuleEditorSettings.FilterShowCreatures)
        {
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              vLeft = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(vLeft, ".utc")));
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(vLeft), labelFont, labelBrush, checked (num3 + 5), checked (num4 - 5));
          }
          try
          {
            Graphics o = Graphics.FromImage(bmp);
            object[] objArray = new object[5]
            {
              new Pen(Color.White, 1f),
              num3,
              num4,
              ObjectType.AddObj(num3, ObjectType.MulObj(GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(index1) + ").XOrientation"), nudXmul.Value)),
              ObjectType.SubObj(num4, ObjectType.MulObj(GITfile.GetNodeValue("Creature List(" + StringType.FromInteger(index1) + ").YOrientation"), nudYmul.Value))
            };
            object[] args = objArray;
            bool[] flagArray = new bool[5]
            {
              false,
              true,
              true,
              false,
              false
            };
            bool[] CopyBack = flagArray;
            LateBinding.LateCall(o, null, "DrawLine", args, null, CopyBack);
            if (flagArray[2])
              num4 = IntegerType.FromObject(objArray[2]);
            if (flagArray[1])
              num3 = IntegerType.FromObject(objArray[1]);
            Draw3x3Box(bmp, num3, num4, Color.HotPink);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index1; }
      }
      PlaceableArr = new ModItem[checked (GITfile.GetListItemCount("Placeable List") - 1 + 1)];
      int upperBound2 = PlaceableArr.GetUpperBound(0);
      int index2 = 0;
      while (index2 <= upperBound2)
      {
        float num5 = SingleType.FromObject(GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(index2) + ").X"));
        float Y = SingleType.FromObject(GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(index2) + ").Y"));
        int int32 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * num5))), nudXoff.Value));
        int num6 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        object vLeft = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(index2) + ").TemplateResRef"));
        PlaceableArr[index2] = new ModItem(int32, num6, num5, Y, StringType.FromObject(vLeft), "Placeable List(" + StringType.FromInteger(index2) + ")");
        PlaceableArr[index2].XPosAccessor = "X";
        PlaceableArr[index2].YPosAccessor = "Y";
        PlaceableArr[index2].ZPosAccessor = "Z";
        PlaceableArr[index2].ItemType = 2044;
        if (PlaceableArr[index2].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), int32, num6);
        if (gModuleEditorSettings.FilterShowPlaceables)
        {
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              vLeft = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(vLeft, ".utp")));
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(vLeft), labelFont, labelBrush, checked (int32 + 5), checked (num6 - 5));
          }
          try
          {
            num5 = SingleType.FromObject(GITfile.GetNodeValue("Placeable List(" + StringType.FromInteger(index2) + ").Bearing"));
            Graphics.FromImage(bmp).DrawLine(new Pen(Color.White, 1f), int32, num6, checked (int32 - (int) Math.Round(Math.Cos(num5) * Convert.ToDouble(nudXmul.Value))), checked (num6 + (int) Math.Round(Math.Sin(num5) * Convert.ToDouble(nudYmul.Value))));
            Draw3x3Box(bmp, int32, num6, Color.LightGreen);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            Console.WriteLine(ex.Message + ":  " + StringType.FromInteger(int32) + "  " + StringType.FromInteger(num6) + "  " + StringType.FromInteger(checked (int32 - (int) Math.Round(Math.Cos(num5) * Convert.ToDouble(nudXmul.Value)))) + "  " + StringType.FromInteger(checked (num6 + (int) Math.Round(Math.Sin(num5) * Convert.ToDouble(nudYmul.Value)))));
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index2; }
      }
      DoorArr = new ModItem[checked (GITfile.GetListItemCount("Door List") - 1 + 1)];
      int upperBound3 = DoorArr.GetUpperBound(0);
      int index3 = 0;
      while (index3 <= upperBound3)
      {
        float X = SingleType.FromObject(GITfile.GetNodeValue("Door List(" + StringType.FromInteger(index3) + ").X"));
        float Y = SingleType.FromObject(GITfile.GetNodeValue("Door List(" + StringType.FromInteger(index3) + ").Y"));
        int int32 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * X))), nudXoff.Value));
        int num7 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        object vLeft = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("Door List(" + StringType.FromInteger(index3) + ").TemplateResRef"));
        DoorArr[index3] = new ModItem(int32, num7, X, Y, StringType.FromObject(vLeft), "Door List(" + StringType.FromInteger(index3) + ")");
        DoorArr[index3].XPosAccessor = "X";
        DoorArr[index3].YPosAccessor = "Y";
        DoorArr[index3].ZPosAccessor = "Z";
        DoorArr[index3].ItemType = 2042;
        if (DoorArr[index3].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), int32, num7);
        if (gModuleEditorSettings.FilterShowDoors)
        {
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              vLeft = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(vLeft, ".utd")));
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(vLeft), labelFont, labelBrush, checked (int32 + 5), checked (num7 - 5));
          }
          try
          {
            float num8 = SingleType.FromObject(ObjectType.AddObj(GITfile.GetNodeValue("Door List(" + StringType.FromInteger(index3) + ").Bearing"), Math.PI / 2.0));
            Graphics.FromImage(bmp).DrawLine(new Pen(Color.White, 1f), int32, num7, checked (int32 - (int) Math.Round(Math.Cos(num8) * Convert.ToDouble(nudXmul.Value))), checked (num7 + (int) Math.Round(Math.Sin(num8) * Convert.ToDouble(nudYmul.Value))));
            Draw3x3Box(bmp, int32, num7, Color.Yellow);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index3; }
      }
      SoundArr = new ModItem[checked (GITfile.GetListItemCount("SoundList") - 1 + 1)];
      int upperBound4 = SoundArr.GetUpperBound(0);
      int index4 = 0;
      while (index4 <= upperBound4)
      {
        float X = SingleType.FromObject(GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(index4) + ").XPosition"));
        float Y = SingleType.FromObject(GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(index4) + ").YPosition"));
        int int32 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * X))), nudXoff.Value));
        int num9 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        object vLeft = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("SoundList(" + StringType.FromInteger(index4) + ").TemplateResRef"));
        SoundArr[index4] = new ModItem(int32, num9, X, Y, StringType.FromObject(vLeft), "SoundList(" + StringType.FromInteger(index4) + ")");
        SoundArr[index4].XPosAccessor = "XPosition";
        SoundArr[index4].YPosAccessor = "YPosition";
        SoundArr[index4].ZPosAccessor = "ZPosition";
        SoundArr[index4].ItemType = 2035;
        if (SoundArr[index4].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), int32, num9);
        if (gModuleEditorSettings.FilterShowSounds)
        {
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              vLeft = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(vLeft, ".uts")));
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(vLeft), labelFont, labelBrush, checked (int32 + 5), checked (num9 - 5));
          }
          try
          {
            Draw3x3Box(bmp, int32, num9, Color.Blue);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index4; }
      }
      WaypointArr = new ModItem[checked (GITfile.GetListItemCount("WaypointList") - 1 + 1)];
      int upperBound5 = WaypointArr.GetUpperBound(0);
      int index5 = 0;
      while (index5 <= upperBound5)
      {
        float X = SingleType.FromObject(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").XPosition"));
        float Y = SingleType.FromObject(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").YPosition"));
        int num10 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * X))), nudXoff.Value));
        int num11 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        object obj = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").TemplateResRef"));
        WaypointArr[index5] = new ModItem(num10, num11, X, Y, StringType.FromObject(obj), "WaypointList(" + StringType.FromInteger(index5) + ")");
        WaypointArr[index5].XPosAccessor = "XPosition";
        WaypointArr[index5].YPosAccessor = "YPosition";
        WaypointArr[index5].ZPosAccessor = "ZPosition";
        WaypointArr[index5].ItemType = 2058;
        WaypointArr[index5].Tag = StringType.FromObject(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").Tag"));
        if (WaypointArr[index5].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), num10, num11);
        Color color = !BooleanType.FromObject(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").HasMapNote")) ? Color.Orange : Color.Red;
        if (gModuleEditorSettings.FilterShowWaypoints)
        {
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              obj = WaypointArr[index5].Tag;
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(obj), labelFont, labelBrush, checked (num10 + 5), checked (num11 - 5));
          }
          try
          {
            Graphics o = Graphics.FromImage(bmp);
            object[] objArray = new object[5]
            {
              new Pen(Color.White, 1f),
              num10,
              num11,
              ObjectType.AddObj(num10, ObjectType.MulObj(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").XOrientation"), nudXmul.Value)),
              ObjectType.SubObj(num11, ObjectType.MulObj(GITfile.GetNodeValue("WaypointList(" + StringType.FromInteger(index5) + ").YOrientation"), nudYmul.Value))
            };
            object[] args = objArray;
            bool[] flagArray = new bool[5]
            {
              false,
              true,
              true,
              false,
              false
            };
            bool[] CopyBack = flagArray;
            LateBinding.LateCall(o, null, "DrawLine", args, null, CopyBack);
            if (flagArray[2])
              num11 = IntegerType.FromObject(objArray[2]);
            if (flagArray[1])
              num10 = IntegerType.FromObject(objArray[1]);
            Draw3x3Box(bmp, num10, num11, color);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index5; }
      }
      MerchantArr = new ModItem[checked (GITfile.GetListItemCount("StoreList") - 1 + 1)];
      int upperBound6 = MerchantArr.GetUpperBound(0);
      int index6 = 0;
      while (index6 <= upperBound6)
      {
        float X = SingleType.FromObject(GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(index6) + ").XPosition"));
        float Y = SingleType.FromObject(GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(index6) + ").YPosition"));
        int num12 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * X))), nudXoff.Value));
        int num13 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        object vLeft = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(index6) + ").ResRef"));
        MerchantArr[index6] = new ModItem(num12, num13, X, Y, StringType.FromObject(vLeft), "StoreList(" + StringType.FromInteger(index6) + ")");
        MerchantArr[index6].XPosAccessor = "XPosition";
        MerchantArr[index6].YPosAccessor = "YPosition";
        MerchantArr[index6].ZPosAccessor = "ZPosition";
        MerchantArr[index6].ItemType = 2051;
        if (MerchantArr[index6].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), num12, num13);
        if (gModuleEditorSettings.FilterShowMerchants)
        {
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              vLeft = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(vLeft, ".utm")));
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(vLeft), labelFont, labelBrush, checked (num12 + 5), checked (num13 - 5));
          }
          try
          {
            Graphics o = Graphics.FromImage(bmp);
            object[] objArray = new object[5]
            {
              new Pen(Color.White, 1f),
              num12,
              num13,
              ObjectType.AddObj(num12, ObjectType.MulObj(GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(index6) + ").XOrientation"), nudXmul.Value)),
              ObjectType.SubObj(num13, ObjectType.MulObj(GITfile.GetNodeValue("StoreList(" + StringType.FromInteger(index6) + ").YOrientation"), nudYmul.Value))
            };
            object[] args = objArray;
            bool[] flagArray = new bool[5]
            {
              false,
              true,
              true,
              false,
              false
            };
            bool[] CopyBack = flagArray;
            LateBinding.LateCall(o, null, "DrawLine", args, null, CopyBack);
            if (flagArray[2])
              num13 = IntegerType.FromObject(objArray[2]);
            if (flagArray[1])
              num12 = IntegerType.FromObject(objArray[1]);
            Draw3x3Box(bmp, num12, num13, Color.Plum);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        checked { ++index6; }
      }
      int listItemCount1 = GITfile.GetListItemCount("CameraList");
      CameraArr = new ModItem[checked (listItemCount1 - 1 + 1)];
      int num14 = checked (listItemCount1 - 1);
      int index7 = 0;
      while (index7 <= num14)
      {
        GFFType17 nodeValue = (GFFType17) GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(index7) + ").Position");
        float f1 = nodeValue.f1;
        float f2 = nodeValue.f2;
        int int32 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * f1))), nudXoff.Value));
        int num15 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * f2))), nudYoff.Value)));
        object objectValue = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(index7) + ").CameraID"));
        CameraArr[index7] = new ModItem(int32, num15, f1, f2, StringType.FromObject(objectValue), "CameraList(" + StringType.FromInteger(index7) + ")");
        CameraArr[index7].ItemType = 6;
        if (CameraArr[index7].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), int32, num15);
        if (gModuleEditorSettings.ShowItemLabels)
          Graphics.FromImage(bmp).DrawString(StringType.FromObject(ObjectType.StrCatObj("Cam ", objectValue)), labelFont, labelBrush, checked (int32 + 5), checked (num15 - 5));
        try
        {
          Draw3x3Box(bmp, int32, num15, Color.Olive);
        }
        catch (SystemException ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index7; }
      }
      Graphics g1 = Graphics.FromImage(bmp);
      int listItemCount2 = GITfile.GetListItemCount("TriggerList");
      TriggerRegions = new Region[checked (listItemCount2 - 1 + 1)];
      TriggerArr = new ModItem[checked (listItemCount2 - 1 + 1)];
      int num16 = checked (listItemCount2 - 1);
      int index8 = 0;
      float num17;
      float num18;
      Point point1;
      while (index8 <= num16)
      {
        float num19 = SingleType.FromObject(GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").XPosition"));
        float num20 = SingleType.FromObject(GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").YPosition"));
        float a1 = Convert.ToSingle(nudXmul.Value) * num19 - Convert.ToSingle(nudXoff.Value);
        float a2 = Convert.ToSingle(nudYmul.Value) * num20 - Convert.ToSingle(nudYoff.Value);
        float single1 = Convert.ToSingle(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudXmul.Value, ObjectType.AddObj(num19, GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").Geometry(0).PointX"))))), nudXoff.Value));
        float a3 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudYmul.Value, ObjectType.AddObj(num20, GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").Geometry(0).PointY"))))), nudYoff.Value)));
        num17 = single1;
        num18 = a3;
        TriggerArr[index8] = new ModItem(checked ((int) Math.Round(a1)), checked ((int) Math.Round(a2)), num19, num20, StringType.FromObject(GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").TemplateResRef")), "TriggerList(" + StringType.FromInteger(index8) + ")");
        TriggerArr[index8].Z = SingleType.FromObject(GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").ZPosition"));
        TriggerArr[index8].XPosAccessor = "XPosition";
        TriggerArr[index8].YPosAccessor = "YPosition";
        TriggerArr[index8].ZPosAccessor = "ZPosition";
        TriggerArr[index8].ItemType = 2032;
        TriggerArr[index8].GeometryList = new ArrayList();
        ArrayList geometryList1 = TriggerArr[index8].GeometryList;
        point1 = new Point(checked ((int) Math.Round(single1)), checked ((int) Math.Round(a3)));
        // ISSUE: variable of a boxed type
        //__Boxed<Point> local1 = (ValueType) point1;
        //geometryList1.Add((object) local1);
        object objectValue = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").TemplateResRef"));
        int num21 = checked (GITfile.GetListItemCount("TriggerList(" + StringType.FromInteger(index8) + ").Geometry") - 1);
        int num22 = num21;
        int num23 = 1;
        while (num23 <= num22)
        {
          float single2 = Convert.ToSingle(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudXmul.Value, ObjectType.AddObj(num19, GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").Geometry(" + StringType.FromInteger(num23) + ").PointX"))))), nudXoff.Value));
          float a4 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudYmul.Value, ObjectType.AddObj(num20, GITfile.GetNodeValue("TriggerList(" + StringType.FromInteger(index8) + ").Geometry(" + StringType.FromInteger(num23) + ").PointY"))))), nudYoff.Value)));
          try
          {
            ArrayList geometryList2 = TriggerArr[index8].GeometryList;
            point1 = new Point(checked ((int) Math.Round(single2)), checked ((int) Math.Round(a4)));
            // ISSUE: variable of a boxed type
            //__Boxed<Point> local2 = (ValueType) point1;
            //geometryList2.Add((object) local2);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++num23; }
        }
        float o1_3 = 0.0f;
        float o1_4 = 0.0f;
        int num24 = num21;
        int index9 = 0;
        while (index9 <= num24)
        {
          o1_3 = SingleType.FromObject(ObjectType.AddObj(o1_3, LateBinding.LateGet(TriggerArr[index8].GeometryList[index9], null, "X", new object[0], null, null)));
          o1_4 = SingleType.FromObject(ObjectType.AddObj(o1_4, LateBinding.LateGet(TriggerArr[index8].GeometryList[index9], null, "Y", new object[0], null, null)));
          checked { ++index9; }
        }
        float a5 = checked ((int) Math.Round(o1_3 / checked (num21 + 1)));
        float a6 = checked ((int) Math.Round(o1_4 / checked (num21 + 1)));
        if (TriggerArr[index8].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), checked ((int) Math.Round(a5)), checked ((int) Math.Round(a6)));
        if (gModuleEditorSettings.FilterShowTriggers)
        {
          if (gModuleEditorSettings.ShowItemLabels && gModuleEditorSettings.ShowTagsOnModulePalette)
          {
            string modItemTag = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(objectValue, ".utt")));
            if (modItemTag != null && StringType.StrCmp(modItemTag, "", false) != 0)
            {
              Graphics.FromImage(bmp).DrawString(modItemTag, labelFont, labelBrush, a5 + 5f, a6 - 5f);
            }
            else
            {
              string vRight = null;
              if (Directory.Exists(g_ProjectPath + "\\recycle") && Directory.GetFiles(g_ProjectPath + "\\recycle", StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj("*", objectValue), ".utt"))).Length > 0)
                vRight = "\n\nHowever, there are one or more files in your project's 'recycle' folder that match the file's name.\n\nIf you wish to keep the file's item, you can move and rename the desired file back into your project folder without quitting the Module editor. Otherwise, select the item in the Module treeview, right click to bring up the menu, then choose Delete.";
              int num25 = (int) Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Unable to find file for trigger '", objectValue), "' in your project folder or in templates.bif"), vRight), MsgBoxStyle.Exclamation, "Missing file");
              Graphics.FromImage(bmp).DrawString(StringType.FromObject(ObjectType.StrCatObj(objectValue, " - MISSING")), labelFont, labelBrush, a5 + 5f, a6 - 5f);
            }
          }
          TriggerRegions[index8] = !objectValue.ToString().StartsWith("g_t_") ? DrawRegionPoints(g1, TriggerArr[index8].GeometryList, Color.MediumTurquoise) : DrawRegionPoints(g1, TriggerArr[index8].GeometryList, Color.MediumAquamarine);
        }
        checked { ++index8; }
      }
      Graphics g2 = Graphics.FromImage(bmp);
      int listItemCount3 = GITfile.GetListItemCount("Encounter List");
      EncounterRegions = new Region[checked (listItemCount3 - 1 + 1)];
      EncounterArr = new ModItem[checked (listItemCount3 - 1 + 1)];
      int num26 = checked (listItemCount3 - 1);
      int index10 = 0;
      while (index10 <= num26)
      {
        float num27 = SingleType.FromObject(GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").XPosition"));
        float num28 = SingleType.FromObject(GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").YPosition"));
        float a7 = Convert.ToSingle(nudXmul.Value) * num27 - Convert.ToSingle(nudXoff.Value);
        float a8 = Convert.ToSingle(nudYmul.Value) * num28 - Convert.ToSingle(nudYoff.Value);
        float single3 = Convert.ToSingle(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudXmul.Value, ObjectType.AddObj(num27, GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").Geometry(0).PointX"))))), nudXoff.Value));
        float a9 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudYmul.Value, ObjectType.AddObj(num28, GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").Geometry(0).PointY"))))), nudYoff.Value)));
        num17 = single3;
        num18 = a9;
        EncounterArr[index10] = new ModItem(checked ((int) Math.Round(a7)), checked ((int) Math.Round(a8)), num27, num28, StringType.FromObject(GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").TemplateResRef")), "Encounter List(" + StringType.FromInteger(index10) + ")");
        EncounterArr[index10].Z = SingleType.FromObject(GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").ZPosition"));
        EncounterArr[index10].XPosAccessor = "XPosition";
        EncounterArr[index10].YPosAccessor = "YPosition";
        EncounterArr[index10].ZPosAccessor = "ZPosition";
        EncounterArr[index10].ItemType = 2040;
        EncounterArr[index10].GeometryList = new ArrayList();
        ArrayList geometryList3 = EncounterArr[index10].GeometryList;
        point1 = new Point(checked ((int) Math.Round(single3)), checked ((int) Math.Round(a9)));
        // ISSUE: variable of a boxed type
        //__Boxed<Point> local3 = (ValueType) point1;
        //geometryList3.Add((object) local3);
        EncounterArr[index10].SpawnPointList = new ArrayList();
        object vLeft = RuntimeHelpers.GetObjectValue(GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").TemplateResRef"));
        int num29 = checked (GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(index10) + ").Geometry") - 1);
        int num30 = 1;
        while (num30 <= num29)
        {
          float single4 = Convert.ToSingle(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudXmul.Value, ObjectType.AddObj(num27, GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").Geometry(" + StringType.FromInteger(num30) + ").X"))))), nudXoff.Value));
          float a10 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudYmul.Value, ObjectType.AddObj(num28, GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").Geometry(" + StringType.FromInteger(num30) + ").Y"))))), nudYoff.Value)));
          try
          {
            ArrayList geometryList4 = EncounterArr[index10].GeometryList;
            point1 = new Point(checked ((int) Math.Round(single4)), checked ((int) Math.Round(a10)));
            // ISSUE: variable of a boxed type
            //__Boxed<Point> local4 = (ValueType) point1;
            //geometryList4.Add((object) local4);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++num30; }
        }
        int num31 = checked (GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(index10) + ").SpawnPointList") - 1);
        int num32 = 0;
        while (num32 <= num31)
        {
          float single5 = Convert.ToSingle(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudXmul.Value, GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").SpawnPointList(" + StringType.FromInteger(num32) + ").X")))), nudXoff.Value));
          float a11 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(IntegerType.FromObject(ObjectType.MulObj(nudYmul.Value, GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").SpawnPointList(" + StringType.FromInteger(num32) + ").Y")))), nudYoff.Value)));
          try
          {
            ArrayList spawnPointList = EncounterArr[index10].SpawnPointList;
            point1 = new Point(checked ((int) Math.Round(single5)), checked ((int) Math.Round(a11)));
            // ISSUE: variable of a boxed type
            //__Boxed<Point> local5 = (ValueType) point1;
            //spawnPointList.Add((object) local5);
          }
          catch (SystemException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++num32; }
        }
        float o1_5 = 0.0f;
        float o1_6 = 0.0f;
        int num33 = checked (GITfile.GetListItemCount("Encounter List(" + StringType.FromInteger(index10) + ").Geometry") - 1);
        int num34 = num33;
        int index11 = 0;
        while (index11 <= num34)
        {
          o1_5 = SingleType.FromObject(ObjectType.AddObj(o1_5, LateBinding.LateGet(EncounterArr[index10].GeometryList[index11], null, "X", new object[0], null, null)));
          o1_6 = SingleType.FromObject(ObjectType.AddObj(o1_6, LateBinding.LateGet(EncounterArr[index10].GeometryList[index11], null, "Y", new object[0], null, null)));
          checked { ++index11; }
        }
        float num35 = checked ((int) Math.Round(o1_5 / checked (num33 + 1)));
        float num36 = checked ((int) Math.Round(o1_6 / checked (num33 + 1)));
        Pen pen3 = new Pen(Color.Wheat, 0.5f);
        pen3.SetLineCap(LineCap.RoundAnchor, LineCap.ArrowAnchor, DashCap.Flat);
        if (EncounterArr[index10].IsEqual(IndicatedModItem))
          IndicateModItem(Graphics.FromImage(bmp), checked ((int) Math.Round(num35)), checked ((int) Math.Round(num36)));
        if (gModuleEditorSettings.FilterShowEncounters)
        {
          try
          {
            foreach (object spawnPoint in EncounterArr[index10].SpawnPointList)
            {
              Point point2 = (Point) (spawnPoint ?? Activator.CreateInstance(typeof (Point)));
              Graphics.FromImage(bmp).DrawLine(pen3, point2.X, point2.Y, num35, num36);
              Graphics.FromImage(bmp).DrawString(StringType.FromInteger(checked (EncounterArr[index10].SpawnPointList.IndexOf(point2) + 1)), font, Brushes.Orchid, checked (point2.X + 2), checked (point2.Y + 2));
              Draw3x3Box(bmp, point2.X, point2.Y, Color.Orchid);
              float num37 = SingleType.FromObject(GITfile.GetNodeValue("Encounter List(" + StringType.FromInteger(index10) + ").SpawnPointList(" + StringType.FromInteger(EncounterArr[index10].SpawnPointList.IndexOf(point2)) + ").Orientation"));
              Graphics.FromImage(bmp).DrawLine(new Pen(Color.White, 1f), point2.X, point2.Y, checked (point2.X + (int) Math.Round(Math.Sin(num37) * Convert.ToDouble(nudXmul.Value))), checked (point2.Y - (int) Math.Round(Math.Cos(num37) * Convert.ToDouble(nudYmul.Value))));
            }
          }
          finally
          {
            
          }
          if (gModuleEditorSettings.ShowItemLabels)
          {
            if (gModuleEditorSettings.ShowTagsOnModulePalette)
              vLeft = GetModItemTag(StringType.FromObject(ObjectType.StrCatObj(vLeft, ".ute")));
            Graphics.FromImage(bmp).DrawString(StringType.FromObject(vLeft), labelFont, labelBrush, num35 + 5f, num36 - 5f);
          }
          EncounterRegions[index10] = DrawRegionPoints(g2, EncounterArr[index10].GeometryList, Color.Teal);
        }
        checked { ++index10; }
      }
      pbox.Image = bmp;
      GC.Collect();
    }

  private Region DrawRegionPoints(
    Graphics g,
    ArrayList PointList,
    Color color,
    bool CloseFigure = true)
  {
      GraphicsPath path = new GraphicsPath();
      Pen pen1 = new Pen(color, 1f);
      pen1.EndCap = LineCap.Square;
      Point pt1 = (Point) (PointList[0] ?? Activator.CreateInstance(typeof (Point)));
      int num = checked (PointList.Count - 1);
      int index = 1;
      Rectangle rectangle;
      while (index <= num)
      {
        Graphics graphics = g;
        Pen pen2 = pen1;
        rectangle = new Rectangle(checked (pt1.X - 1), checked (pt1.Y - 1), 2, 2);
        Rectangle rect = rectangle;
        graphics.DrawRectangle(pen2, rect);
        path.AddLine(pt1, (Point) (PointList[index] ?? Activator.CreateInstance(typeof (Point))));
        pt1 = (Point) (PointList[index] ?? Activator.CreateInstance(typeof (Point)));
        checked { ++index; }
      }
      Graphics graphics1 = g;
      Pen pen3 = pen1;
      rectangle = new Rectangle(checked (pt1.X - 1), checked (pt1.Y - 1), 2, 2);
      Rectangle rect1 = rectangle;
      graphics1.DrawRectangle(pen3, rect1);
      if (CloseFigure)
        path.CloseFigure();
      g.DrawPath(pen1, path);
      return new Region(path);
    }

  private void Draw3x3Box(Bitmap bmp, int x, int y, Color color) => Graphics.FromImage(bmp).DrawRectangle(new Pen(color, Convert.ToSingle(dModuleElementIndicatorSize)), checked (x - 1), checked (y - 1), 2, 2);

  private void Draw6x6Box(Bitmap bmp, int x, int y, Color color) => Graphics.FromImage(bmp).DrawRectangle(new Pen(color, Convert.ToSingle(dModuleElementIndicatorSize)), checked (x - 2), checked (y - 2), 5, 5);

  private void IndicateModItem(Graphics g, int x, int y)
  {
      if (!LeftMouseClickActive)
      {
        Panel1.AutoScrollPosition = new Point(checked ((int) Math.Round(x - Panel1.Size.Width / 2.0)), checked ((int) Math.Round(y - Panel1.Size.Height / 2.0)));
        if (bShowLocatorRay)
          g.DrawLine(new Pen(Color.Orange, 2f), 0, 0, x, y);
      }
      Pen pen = new Pen(Color.Orange, 1f);
      pen.EndCap = LineCap.ArrowAnchor;
      g.DrawLine(pen, checked (x + 10), checked (y + 10), checked (x + 4), checked (y + 4));
      g.DrawLine(pen, checked (x - 10), checked (y + 10), checked (x - 4), checked (y + 4));
      g.DrawLine(pen, checked (x + 10), checked (y - 10), checked (x + 4), checked (y - 4));
      g.DrawLine(pen, checked (x - 10), checked (y - 10), checked (x - 4), checked (y - 4));
    }

  private int invy(int y) => checked (g_imageYsize - y);

  private void CopyModFilesToPath(ModItem[] ModItemArr, string destPath)
  {
      if (ModItemArr == null)
        return;
      ModItem[] modItemArray = ModItemArr;
      int index = 0;
      while (index < modItemArray.Length)
      {
        ModItem modItem = modItemArray[index];
        if (modItem != null & File.Exists(g_ProjectPath + "\\" + modItem.FileName))
          File.Copy(g_ProjectPath + "\\" + modItem.FileName, destPath + modItem.FileName, true);
        checked { ++index; }
      }
    }

  private bool Near(object x, object y, object xCompare, object yCompare)
  {
      // ISSUE: variable of a boxed type
      //__Boxed<bool> local;
      if (BooleanType.FromObject(ObjectType.ObjTst(LateBinding.LateGet(null, typeof (Math), "Abs", new object[1]
          {
            ObjectType.SubObj(x, xCompare)
          }, null, null), 2, false) <= 0))
      {
        if (BooleanType.FromObject(ObjectType.ObjTst(LateBinding.LateGet(null, typeof (Math), "Abs", new object[1]
            {
              ObjectType.SubObj(y, yCompare)
            }, null, null), 2, false) <= 0))
        {
          //local = (ValueType) true;
          goto label_4;
        }
      }
      //local = (ValueType) false;
label_4:
      //return BooleanType.FromObject((object) local);
      return true;
    }

  private ModItem FindModItem(PictureBox pb)
  {
      int x = pb.PointToClient(MousePosition).X;
      int y = pb.PointToClient(MousePosition).Y;
      bool flag = false;
      ModItem parent = null;
      if (CreatureArr != null)
      {
        ModItem[] creatureArr = CreatureArr;
        int index = 0;
        while (index < creatureArr.Length)
        {
          parent = creatureArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag && PlaceableArr != null)
      {
        ModItem[] placeableArr = PlaceableArr;
        int index = 0;
        while (index < placeableArr.Length)
        {
          parent = placeableArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag && WaypointArr != null)
      {
        ModItem[] waypointArr = WaypointArr;
        int index = 0;
        while (index < waypointArr.Length)
        {
          parent = waypointArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag && DoorArr != null)
      {
        ModItem[] doorArr = DoorArr;
        int index = 0;
        while (index < doorArr.Length)
        {
          parent = doorArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag && SoundArr != null)
      {
        ModItem[] soundArr = SoundArr;
        int index = 0;
        while (index < soundArr.Length)
        {
          parent = soundArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag && MerchantArr != null)
      {
        ModItem[] merchantArr = MerchantArr;
        int index = 0;
        while (index < merchantArr.Length)
        {
          parent = merchantArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag && TriggerArr != null)
      {
        ModItem[] triggerArr = TriggerArr;
        int index1 = 0;
        while (index1 < triggerArr.Length)
        {
          parent = triggerArr[index1];
          if (parent != null)
          {
            int num = checked (parent.GeometryList.Count - 1);
            int index2 = 0;
            while (index2 <= num)
            {
              Point point = (Point) (parent.GeometryList[index2] ?? Activator.CreateInstance(typeof (Point)));
              if (Near(x, y, point.X, point.Y))
              {
                flag = true;
                parent = new ModItem(parent.ScreenX, parent.ScreenY, 0.0f, 0.0f, parent.ResRef, parent.Path, parent);
                parent.XPosAccessor = "Geometry(" + StringType.FromInteger(index2) + ").PointX";
                parent.YPosAccessor = "Geometry(" + StringType.FromInteger(index2) + ").PointY";
                parent.ItemType = 2032;
                sbarpnlAddlInfo.Text = "Node: " + StringType.FromInteger(index2) + "   x: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(point.X), nudXoff.Value), nudXmul.Value))) + "   y: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(point.Y)), nudYoff.Value), nudYmul.Value)));
                parent.GeometryList = new ArrayList();
                parent.GeometryList.Add(point);
                break;
              }
              checked { ++index2; }
            }
          }
          if (!flag)
            checked { ++index1; }
          else
            break;
        }
      }
      if (!flag && EncounterArr != null)
      {
        ModItem[] encounterArr = EncounterArr;
        int index3 = 0;
        while (index3 < encounterArr.Length)
        {
          parent = encounterArr[index3];
          if (parent != null)
          {
            int num1 = checked (parent.GeometryList.Count - 1);
            int index4 = 0;
            Point point;
            while (index4 <= num1)
            {
              point = (Point) (parent.GeometryList[index4] ?? Activator.CreateInstance(typeof (Point)));
              if (Near(x, y, point.X, point.Y))
              {
                flag = true;
                parent = new ModItem(parent.ScreenX, parent.ScreenY, 0.0f, 0.0f, parent.ResRef, parent.Path, parent);
                parent.XPosAccessor = "Geometry(" + StringType.FromInteger(index4) + ").X";
                parent.YPosAccessor = "Geometry(" + StringType.FromInteger(index4) + ").Y";
                parent.ItemType = 2040;
                sbarpnlAddlInfo.Text = "Node: " + StringType.FromInteger(checked (index4 + 1)) + "   x: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(point.X), nudXoff.Value), nudXmul.Value))) + "   y: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(point.Y)), nudYoff.Value), nudYmul.Value)));
                parent.GeometryList = new ArrayList();
                parent.GeometryList.Add(point);
                break;
              }
              checked { ++index4; }
            }
            if (!flag)
            {
              int num2 = checked (parent.SpawnPointList.Count - 1);
              int index5 = 0;
              while (index5 <= num2)
              {
                point = (Point) (parent.SpawnPointList[index5] ?? Activator.CreateInstance(typeof (Point)));
                if (Near(x, y, point.X, point.Y))
                {
                  flag = true;
                  parent = new ModItem(parent.ScreenX, parent.ScreenY, 0.0f, 0.0f, parent.ResRef, parent.Path + ".SpawnPointList(" + StringType.FromInteger(index5) + ")", parent);
                  parent.XPosAccessor = "X";
                  parent.YPosAccessor = "Y";
                  parent.ItemType = 12040;
                  sbarpnlAddlInfo.Text = "SP: " + StringType.FromInteger(checked (index5 + 1)) + "   x: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(point.X), nudXoff.Value), nudXmul.Value))) + "   y: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(point.Y)), nudYoff.Value), nudYmul.Value)));
                  parent.GeometryList = new ArrayList();
                  parent.GeometryList.Add(point);
                  break;
                }
                checked { ++index5; }
              }
            }
          }
          if (!flag)
            checked { ++index3; }
          else
            break;
        }
      }
      if (!flag && CameraArr != null)
      {
        ModItem[] cameraArr = CameraArr;
        int index = 0;
        while (index < cameraArr.Length)
        {
          parent = cameraArr[index];
          if (parent != null && Near(x, y, parent.ScreenX, parent.ScreenY))
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (!flag)
      {
        float X = SingleType.FromObject(IFOfile.GetNodeValue("Mod_Entry_X"));
        float Y = SingleType.FromObject(IFOfile.GetNodeValue("Mod_Entry_Y"));
        int int32 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * X))), nudXoff.Value));
        int num = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * Y))), nudYoff.Value)));
        if (Near(x, y, int32, num))
        {
          flag = true;
          parent = new ModItem(int32, num, X, Y, "Mod Entry Point", "");
          parent.ItemType = 5000;
        }
      }
      return flag ? parent : null;
    }

  private void EditItemProperties(ModItem cmi)
  {
      frmModuleItem_Base_Editor moduleItemBaseEditor = new frmModuleItem_Base_Editor();
      string resRef = cmi.ResRef;
      moduleItemBaseEditor.tbResRef.Text = cmi.ResRef;
      moduleItemBaseEditor.tbXPosition.Text = StringType.FromSingle(cmi.X);
      moduleItemBaseEditor.tbYPosition.Text = StringType.FromSingle(cmi.Y);
      moduleItemBaseEditor.tbZPosition.Text = StringType.FromObject(GITfile.GetNodeValue(cmi.ZPosPath));
      bool flag = false;
      int listItemCount = 0;
      switch (cmi.ItemType)
      {
        case 6:
          GFFType17 nodeValue1 = (GFFType17) GITfile.GetNodeValue(cmi.Path + ".Position");
          moduleItemBaseEditor.tbZPosition.Text = StringType.FromSingle(nodeValue1.f3);
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbCamFieldOfView, cmi.Path + ".FieldOfView");
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbCamHeight, cmi.Path + ".Height");
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbCamMicRange, cmi.Path + ".MicRange");
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbCamPitch, cmi.Path + ".Pitch");
          GFFType16 nodeValue2 = (GFFType16) GITfile.GetNodeValue(cmi.Path + ".Orientation");
          moduleItemBaseEditor.CameraOrientationQuat = nodeValue2;
          if (GITfile.VerifyNodeExists(cmi.Path + ".EAOrientation"))
          {
            moduleItemBaseEditor.CameraOrientationEulerAngles = (GFFType17) GITfile.GetNodeValue(cmi.Path + ".EAOrientation");
            break;
          }
          moduleItemBaseEditor.nudCamOrientationX.Value = 0M;
          moduleItemBaseEditor.nudCamOrientationY.Value = 0M;
          moduleItemBaseEditor.nudCamOrientationZ.Value = 0M;
          moduleItemBaseEditor.ErrorProvider1.SetError(moduleItemBaseEditor.nudCamOrientationX, "Unable to represent Quaternion as Euler angles; choose new values");
          break;
        case 2027:
        case 2051:
          moduleItemBaseEditor.XOrientation = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".XOrientation"));
          moduleItemBaseEditor.YOrientation = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".YOrientation"));
          moduleItemBaseEditor.SetupOrientationIndicators();
          break;
        case 2032:
          ClsGff clsGff = null;
          if (File.Exists(g_ProjectPath + "\\" + cmi.FileName))
          {
            clsGff = new ClsGff(File.OpenRead(g_ProjectPath + "\\" + cmi.FileName), KotorVersionIndex);
          }
          else
          {
            byte[] biffResourceData = FrmMain.GetBiffResourceData(KotorVersionIndex, cmi.ResRef, 2032);
            if (biffResourceData != null)
              clsGff = new ClsGff(biffResourceData, KotorVersionIndex);
          }
          if (clsGff != null)
          {
            Console.WriteLine(ObjectType.StrCatObj("Trigger type: ", clsGff.GetNodeValue("Type")));
            flag = ObjectType.ObjTst(clsGff.GetNodeValue("Type"), 1, false) == 0;
            if (!flag)
              moduleItemBaseEditor.DisableLinkedToFields();
          }
          if (GITfile.VerifyNodeExists(cmi.Path + ".LinkedToFlags"))
          {
            if (GITfile.VerifyNodeExists(cmi.Path + ".LinkedTo"))
              GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbDoorLinkedTo, cmi.Path + ".LinkedTo");
            if (GITfile.VerifyNodeExists(cmi.Path + ".LinkedToModule"))
              GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule");
            if (GITfile.VerifyNodeExists(cmi.Path + ".TransitionDestin"))
              GITfile.SetTextBoxFromCExoLocStringNodeValue(moduleItemBaseEditor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", g_clsDialogTlk);
            moduleItemBaseEditor.cmbxDoorLinkedToFlags.SelectedIndex = IntegerType.FromObject(GITfile.GetNodeValue(cmi.Path + ".LinkedToFlags"));
          }
          if (cmi.Parent != null)
          {
            moduleItemBaseEditor.tbXPosition.Text = StringType.FromSingle(cmi.Parent.X);
            moduleItemBaseEditor.tbYPosition.Text = StringType.FromSingle(cmi.Parent.Y);
            moduleItemBaseEditor.tbZPosition.Text = StringType.FromObject(GITfile.GetNodeValue(cmi.Parent.ZPosPath));
          }
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          break;
        case 2040:
          if (cmi.Parent != null)
          {
            moduleItemBaseEditor.tbXPosition.Text = StringType.FromSingle(cmi.Parent.X);
            moduleItemBaseEditor.tbYPosition.Text = StringType.FromSingle(cmi.Parent.Y);
            moduleItemBaseEditor.tbZPosition.Text = StringType.FromObject(GITfile.GetNodeValue(cmi.Parent.ZPosPath));
          }
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          listItemCount = GITfile.GetListItemCount(cmi.Path + ".SpawnPointList");
          GFFType16[] gffType16Array = new GFFType16[checked (listItemCount - 1 + 1)];
          int num1 = checked (listItemCount - 1);
          int index1 = 0;
          while (index1 <= num1)
          {
            gffType16Array[index1] = new GFFType16();
            gffType16Array[index1].X = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index1) + ").X"));
            gffType16Array[index1].Y = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index1) + ").Y"));
            gffType16Array[index1].Z = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index1) + ").Z"));
            gffType16Array[index1].W = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index1) + ").Orientation"));
            checked { ++index1; }
          }
          moduleItemBaseEditor.SpawnPoints = gffType16Array;
          break;
        case 2042:
          moduleItemBaseEditor.set_Bearing(2042, SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".Bearing")));
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbDoorLinkedTo, cmi.Path + ".LinkedTo");
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule");
          GITfile.SetTextBoxFromCExoLocStringNodeValue(moduleItemBaseEditor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin", g_clsDialogTlk);
          moduleItemBaseEditor.cmbxDoorLinkedToFlags.SelectedIndex = IntegerType.FromObject(GITfile.GetNodeValue(cmi.Path + ".LinkedToFlags"));
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          break;
        case 2044:
          moduleItemBaseEditor.set_Bearing(2044, SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".Bearing")));
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          break;
        case 2058:
          moduleItemBaseEditor.XOrientation = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".XOrientation"));
          moduleItemBaseEditor.YOrientation = SingleType.FromObject(GITfile.GetNodeValue(cmi.Path + ".YOrientation"));
          moduleItemBaseEditor.SetupOrientationIndicators();
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          GITfile.SetTextBoxToNodeValue(moduleItemBaseEditor.tbWPLinkedTo, cmi.Path + ".LinkedTo");
          GITfile.SetTextBoxFromCExoLocStringNodeValue(moduleItemBaseEditor.tbWpLocalizedName, cmi.Path + ".LocalizedName", g_clsDialogTlk);
          GITfile.SetTextBoxFromCExoLocStringNodeValue(moduleItemBaseEditor.tbWpDescription, cmi.Path + ".Description", g_clsDialogTlk);
          GITfile.SetTextBoxFromCExoLocStringNodeValue(moduleItemBaseEditor.tbWpMapNote, cmi.Path + ".MapNote", g_clsDialogTlk);
          moduleItemBaseEditor.chkbHasMapNote.Checked = BooleanType.FromObject(GITfile.GetNodeValue(cmi.Path + ".HasMapNote"));
          moduleItemBaseEditor.chkbMapNoteEnabled.Checked = BooleanType.FromObject(GITfile.GetNodeValue(cmi.Path + ".MapNoteEnabled"));
          break;
      }
      moduleItemBaseEditor.SetupForItemType(cmi.ItemType);
      int num2 = (int) moduleItemBaseEditor.ShowDialog(this);
      if (moduleItemBaseEditor.DialogResult != DialogResult.OK)
        return;
      switch (cmi.ItemType)
      {
        case 6:
          GITfile.SetNodeValue(cmi.Path + ".Position", new GFFType17()
          {
            f1 = SingleType.FromString(moduleItemBaseEditor.tbXPosition.Text),
            f2 = SingleType.FromString(moduleItemBaseEditor.tbYPosition.Text),
            f3 = SingleType.FromString(moduleItemBaseEditor.tbZPosition.Text)
          });
          GFFType16 gffType16 = new GFFType16();
          GFFType16 cameraOrientationQuat = moduleItemBaseEditor.CameraOrientationQuat;
          GITfile.SetNodeValue(cmi.Path + ".Orientation", cameraOrientationQuat);
          if (GITfile.VerifyNodeExists(cmi.Path + ".EAOrientation"))
          {
            GITfile.SetNodeValue(cmi.Path + ".EAOrientation", moduleItemBaseEditor.CameraOrientationEulerAngles);
            break;
          }
          GITfile.AddFieldToStruct(cmi.Path, "EAOrientation", 17, moduleItemBaseEditor.CameraOrientationEulerAngles);
          break;
        case 2032:
        case 2040:
          if (cmi.Parent != null)
          {
            GITfile.SetNodeValue(cmi.Parent.XPosPath, SingleType.FromString(moduleItemBaseEditor.tbXPosition.Text));
            GITfile.SetNodeValue(cmi.Parent.YPosPath, SingleType.FromString(moduleItemBaseEditor.tbYPosition.Text));
            GITfile.SetNodeValue(cmi.Parent.ZPosPath, SingleType.FromString(moduleItemBaseEditor.tbZPosition.Text));
          }
          else
          {
            GITfile.SetNodeValue(cmi.XPosPath, SingleType.FromString(moduleItemBaseEditor.tbXPosition.Text));
            GITfile.SetNodeValue(cmi.YPosPath, SingleType.FromString(moduleItemBaseEditor.tbYPosition.Text));
            GITfile.SetNodeValue(cmi.ZPosPath, SingleType.FromString(moduleItemBaseEditor.tbZPosition.Text));
          }
          GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", Strings.Trim(moduleItemBaseEditor.tbResRef.Text));
          if (StringType.StrCmp(moduleItemBaseEditor.tbResRef.Text, resRef, false) != 0)
          {
            Draw();
            BuildModuleTreeView();
            break;
          }
          break;
        default:
          GITfile.SetNodeValue(cmi.XPosPath, SingleType.FromString(moduleItemBaseEditor.tbXPosition.Text));
          GITfile.SetNodeValue(cmi.YPosPath, SingleType.FromString(moduleItemBaseEditor.tbYPosition.Text));
          GITfile.SetNodeValue(cmi.ZPosPath, SingleType.FromString(moduleItemBaseEditor.tbZPosition.Text));
          GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", Strings.Trim(moduleItemBaseEditor.tbResRef.Text));
          if (StringType.StrCmp(moduleItemBaseEditor.tbResRef.Text, resRef, false) != 0)
          {
            Draw();
            BuildModuleTreeView();
            break;
          }
          break;
      }
      switch (cmi.ItemType)
      {
        case 6:
          GITfile.SetNodeValue(cmi.Path + ".FieldOfView", SingleType.FromString(moduleItemBaseEditor.tbCamFieldOfView.Text));
          GITfile.SetNodeValue(cmi.Path + ".Height", SingleType.FromString(moduleItemBaseEditor.tbCamHeight.Text));
          GITfile.SetNodeValue(cmi.Path + ".MicRange", SingleType.FromString(moduleItemBaseEditor.tbCamMicRange.Text));
          GITfile.SetNodeValue(cmi.Path + ".Pitch", SingleType.FromString(moduleItemBaseEditor.tbCamPitch.Text));
          break;
        case 2027:
        case 2051:
          GITfile.SetNodeValue(cmi.Path + ".XOrientation", moduleItemBaseEditor.XOrientation);
          GITfile.SetNodeValue(cmi.Path + ".YOrientation", moduleItemBaseEditor.YOrientation);
          break;
        case 2032:
        case 2040:
        case 2042:
          if (cmi.ItemType == 2042)
          {
            GITfile.SetNodeValue(cmi.Path + ".Bearing", moduleItemBaseEditor.get_Bearing(2042));
            GITfile.SetNodeValueFromTextBox(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          }
          if (flag)
          {
            GITfile.SetNodeValueFromTextBox(moduleItemBaseEditor.tbDoorLinkedTo, cmi.Path + ".LinkedTo");
            GITfile.SetNodeValueFromTextBox(moduleItemBaseEditor.tbDoorLinkedToModule, cmi.Path + ".LinkedToModule");
            GITfile.SetCExoLocStringNodeValueFromTextBox(moduleItemBaseEditor.tbDoorLinkedToTransitionDestin, cmi.Path + ".TransitionDestin");
            GITfile.SetNodeValue(cmi.Path + ".LinkedToFlags", moduleItemBaseEditor.cmbxDoorLinkedToFlags.SelectedIndex);
          }
          if (cmi.ItemType != 2040)
            break;
          int num3 = checked (listItemCount - 1);
          int index2 = 0;
          while (index2 <= num3)
          {
            GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index2) + ").X", moduleItemBaseEditor.SpawnPoints[index2].X);
            GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index2) + ").Y", moduleItemBaseEditor.SpawnPoints[index2].Y);
            GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index2) + ").Z", moduleItemBaseEditor.SpawnPoints[index2].Z);
            GITfile.SetNodeValue(cmi.Path + ".SpawnPointList(" + StringType.FromInteger(index2) + ").Orientation", moduleItemBaseEditor.SpawnPoints[index2].W);
            checked { ++index2; }
          }
          break;
        case 2044:
          GITfile.SetNodeValue(cmi.Path + ".Bearing", moduleItemBaseEditor.get_Bearing(2044));
          break;
        case 2058:
          GITfile.SetNodeValue(cmi.Path + ".XOrientation", moduleItemBaseEditor.XOrientation);
          GITfile.SetNodeValue(cmi.Path + ".YOrientation", moduleItemBaseEditor.YOrientation);
          GITfile.SetNodeValueFromTextBox(moduleItemBaseEditor.tbTag, cmi.Path + ".Tag");
          GITfile.SetCExoLocStringNodeValueFromTextBox(moduleItemBaseEditor.tbWpLocalizedName, cmi.Path + ".LocalizedName", moduleItemBaseEditor.NameLang);
          GITfile.SetNodeValueFromTextBox(moduleItemBaseEditor.tbWPLinkedTo, cmi.Path + ".LinkedTo");
          GITfile.SetCExoLocStringNodeValueFromTextBox(moduleItemBaseEditor.tbWpDescription, cmi.Path + ".Description", moduleItemBaseEditor.NameLang);
          if (GITfile.VerifyNodeExists(cmi.Path + ".MapNote"))
            GITfile.SetCExoLocStringNodeValueFromTextBox(moduleItemBaseEditor.tbWpMapNote, cmi.Path + ".MapNote", moduleItemBaseEditor.NameLang);
          GITfile.SetNodeValue(cmi.Path + ".HasMapNote", moduleItemBaseEditor.chkbHasMapNote.Checked);
          GITfile.SetNodeValue(cmi.Path + ".MapNoteEnabled", moduleItemBaseEditor.chkbMapNoteEnabled.Checked);
          break;
      }
    }

  private ModItem GetTreeNodesModItem(ModItemTvNode node)
  {
      switch (node.ItemType)
      {
        case 6:
          return CameraArr[node.ArrayIndex];
        case 2027:
          return CreatureArr[node.ArrayIndex];
        case 2032:
          return TriggerArr[node.ArrayIndex];
        case 2035:
          return SoundArr[node.ArrayIndex];
        case 2040:
          return EncounterArr[node.ArrayIndex];
        case 2042:
          return DoorArr[node.ArrayIndex];
        case 2044:
          return PlaceableArr[node.ArrayIndex];
        case 2051:
          return MerchantArr[node.ArrayIndex];
        case 2058:
          return WaypointArr[node.ArrayIndex];
        default:
          ModItem treeNodesModItem = null;
          return treeNodesModItem;
      }
    }

  private bool FileExistsInProject(string FileName) => File.Exists(g_ProjectPath + "\\" + FileName);

  private bool FileExistsInUserPalette(string FileName) => File.Exists(g_UserPalettePath + "\\" + FileName);

  private bool FileExistsInGlobalTemplates(string FileName) => File.Exists(g_GlobalTemplatesPath + "\\" + FileName);

  private bool FileExistsInTemplatesBif(string FileName) => htTemplateBifFiles.ContainsKey(FileName);

  private void EditItem(ModItem cmi)
  {
      if (!FileExistsInProject(cmi.FileName))
      {
        bool flag1 = FileExistsInUserPalette(cmi.FileName);
        bool flag2 = FileExistsInGlobalTemplates(cmi.FileName);
        bool flag3 = FileExistsInTemplatesBif(cmi.FileName);
        if (!flag1 && !flag2 && !flag3)
        {
          int num = (int) Interaction.MsgBox("This item cannot be edited, as the file for the it exists in the neither the project, user palette, or Global Templates directories, nor in the templates.bif file.\nThe file was most likely accidently moved or deleted from the project.", MsgBoxStyle.Critical, "Item file missing");
          return;
        }
        frmModuleEditor_MissingItemSelector missingItemSelector = new frmModuleEditor_MissingItemSelector();
        missingItemSelector.UserPaletteAvailable = flag1;
        missingItemSelector.TemplatesBifAvailable = flag3;
        missingItemSelector.GlobalTemplatesAvailable = flag2;
        if (flag1 ^ flag2 ^ flag3)
        {
          missingItemSelector.UserPaletteChecked = flag1;
          missingItemSelector.TemplatesBifChecked = flag3;
          missingItemSelector.GlobalTemplatesChecked = flag2;
        }
        if (missingItemSelector.ShowDialog(this) == DialogResult.Cancel)
          return;
        frmPromptForString frmPromptForString = new frmPromptForString("Create new instance", "Enter name for new instance (16 character max, no extension)", cmi.ResRef);
        frmPromptForString.tbValue.MaxLength = 16;
        string str;
        do
        {
          int num1 = (int) frmPromptForString.ShowDialog(this);
          str = !FileExistsInProject(frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension) ? (!FileExistsInUserPalette(frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension) ? (!FileExistsInGlobalTemplates(frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension) ? (!FileExistsInTemplatesBif(frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension) ? "" : "You cannot use the name of the template from Templates.bif. Please choose another.") : "You cannot use the name of the template from the Global Templates. Please choose another.") : "You cannot use the name of the template from the User Palette. Please choose another.") : "A file with that name already exists. Please choose another.";
          if (StringType.StrCmp(str, "", false) != 0)
          {
            int num2 = (int) Interaction.MsgBox(str, MsgBoxStyle.Exclamation, "Name error");
          }
        }
        while (StringType.StrCmp(str, "", false) != 0 || frmPromptForString.DialogResult == DialogResult.Cancel);
        if (frmPromptForString.DialogResult == DialogResult.Cancel)
          return;
        if (missingItemSelector.TemplatesBifChecked)
        {
          try
          {
            FrmMain.ExportBiffResource(KotorVersionIndex, cmi.ResRef, cmi.ItemType, g_ProjectPath + "\\" + frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension);
          }
          catch (NotSupportedException ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
        else if (missingItemSelector.GlobalTemplatesChecked)
          File.Copy(g_GlobalTemplatesPath + "\\" + cmi.FileName, g_ProjectPath + "\\" + frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension);
        else
          File.Copy(g_UserPalettePath + "\\" + cmi.FileName, g_ProjectPath + "\\" + frmPromptForString.tbValue.Text.Trim() + cmi.FileExtension);
        cmi.ResRef = frmPromptForString.tbValue.Text.Trim();
        GITfile.SetNodeValue(cmi.Path + ".TemplateResRef", cmi.ResRef);
        Draw();
        BuildModuleTreeView();
      }
      switch (cmi.ItemType)
      {
        case 2025:
        case 2027:
        case 2032:
        case 2035:
        case 2042:
        case 2044:
        case 2051:
        case 2058:
          FileStream fs = new FileStream(g_ProjectPath + "\\" + cmi.FileName, FileMode.Open, FileAccess.Read);
          Exception exception = null;
          switch (cmi.ItemType)
          {
            case 2025:
              try
              {
                frmUTI_Editor frmUtiEditor = new frmUTI_Editor(new clsUTI(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtiEditor.SetFormName(cmi.FileName);
                frmUtiEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2027:
              try
              {
                frmUTC_Editor frmUtcEditor = new frmUTC_Editor(new clsUTC(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtcEditor.SetFormName(cmi.FileName);
                frmUtcEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2032:
              try
              {
                frmUTT_Editor frmUttEditor = new frmUTT_Editor(new clsUTT(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUttEditor.SetFormName(cmi.FileName);
                frmUttEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2035:
              try
              {
                frmUTS_Editor frmUtsEditor = new frmUTS_Editor(new clsUTS(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtsEditor.g_ProjectPath = g_ProjectPath;
                frmUtsEditor.SetFormName(cmi.FileName);
                frmUtsEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2042:
              try
              {
                frmUTD_Editor frmUtdEditor = new frmUTD_Editor(new clsUTD(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtdEditor.SetFormName(cmi.FileName);
                frmUtdEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2044:
              try
              {
                frmUTP_Editor frmUtpEditor = new frmUTP_Editor(new clsUTP(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtpEditor.SetFormName(cmi.FileName);
                frmUtpEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2051:
              try
              {
                frmUTM_Editor frmUtmEditor = new frmUTM_Editor(new clsUTM(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtmEditor.SetFormName(cmi.FileName);
                frmUtmEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
            case 2058:
              try
              {
                frmUTW_Editor frmUtwEditor = new frmUTW_Editor(new clsUTW(fs, KotorVersionIndex), KotorVersionIndex, true, g_ProjectPath + "\\" + cmi.FileName);
                frmUtwEditor.SetFormName(cmi.FileName);
                frmUtwEditor.Show();
                break;
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                exception = ex;
                ProjectData.ClearProjectError();
                break;
              }
          }
          if (exception == null)
            break;
          int num3 = (int) Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Module Editing Error");
          break;
        default:
          int num4 = (int) Interaction.MsgBox("No editor is available for that kind of item", MsgBoxStyle.Exclamation);
          break;
      }
    }

  private Rectangle NormalizeRectangle(Rectangle selectionRect)
  {
      Rectangle rectangle = default;
      rectangle.Size = selectionRect.Size;
      if (selectionRect.Width < 0)
      {
        checked { rectangle.Width *= -1; }
        rectangle.X = checked (selectionRect.X - rectangle.Width);
      }
      else
        rectangle.X = selectionRect.X;
      if (selectionRect.Height < 0)
      {
        checked { rectangle.Height *= -1; }
        rectangle.Y = checked (selectionRect.Y - rectangle.Height);
      }
      else
        rectangle.Y = selectionRect.Y;
      return rectangle;
    }

  private void CreateTrap(string TemplateResRef, Point Center)
  {
      GffStruct struct1 = new GffStruct(8, 1);
      GFFList gffList = new GFFList(8);
      int listItemCount = GITfile.GetListItemCount("TriggerList");
      struct1.fields[0] = new GFF_Field(GFFField.GFF_CResRef, nameof (TemplateResRef), TemplateResRef);
      struct1.fields[1] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(Center.X), nudXoff.Value), nudXmul.Value)));
      struct1.fields[2] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(Center.Y)), nudYoff.Value), nudYmul.Value)));
      struct1.fields[3] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
      struct1.fields[4] = new GFF_Field(GFFField.GFF_float, "XOrientation", 0.0f);
      struct1.fields[5] = new GFF_Field(GFFField.GFF_float, "YOrientation", 0.0f);
      struct1.fields[6] = new GFF_Field(GFFField.GFF_float, "ZOrientation", 0.0f);
      struct1.fields[7] = new GFF_Field(GFFField.GFF_List, "Geometry", new GFFList(0));
      GITfile.AddListElement("TriggerList", struct1);
      GffStruct struct2 = new GffStruct(3, 3);
      struct2.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", -1.5f);
      struct2.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", 0.0f);
      struct2.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct2);
      GffStruct struct3 = new GffStruct(3, 3);
      struct3.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", -1.06066f);
      struct3.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", -1.06066f);
      struct3.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct3);
      GffStruct struct4 = new GffStruct(3, 3);
      struct4.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", 0.0f);
      struct4.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", -1.5f);
      struct4.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct4);
      GffStruct struct5 = new GffStruct(3, 3);
      struct5.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", 1.06066f);
      struct5.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", -1.06066f);
      struct5.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct5);
      GffStruct struct6 = new GffStruct(3, 3);
      struct6.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", 1.5f);
      struct6.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", 0.0f);
      struct6.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct6);
      GffStruct struct7 = new GffStruct(3, 3);
      struct7.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", 1.06066f);
      struct7.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", 1.06066f);
      struct7.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct7);
      GffStruct struct8 = new GffStruct(3, 3);
      struct8.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", 0.0f);
      struct8.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", 1.5f);
      struct8.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct8);
      GffStruct struct9 = new GffStruct(3, 3);
      struct9.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", -1.06066f);
      struct9.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", 1.06066f);
      struct9.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(listItemCount) + ").Geometry", struct9);
    }

  private void CreateTrigger(string TemplateResRef, ArrayList PointList)
  {
      GffStruct struct1 = new GffStruct(8, 1);
      GFFList gffList = new GFFList(checked (PointList.Count - 1));
      Point point = (Point) (PointList[0] ?? Activator.CreateInstance(typeof (Point)));
      int x = point.X;
      point = (Point) (PointList[0] ?? Activator.CreateInstance(typeof (Point)));
      int num1 = invy(point.Y);
      struct1.fields[0] = new GFF_Field(GFFField.GFF_CResRef, nameof (TemplateResRef), TemplateResRef);
      struct1.fields[1] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
      struct1.fields[2] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(num1), nudYoff.Value), nudYmul.Value)));
      struct1.fields[3] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
      struct1.fields[4] = new GFF_Field(GFFField.GFF_float, "XOrientation", 0.0f);
      struct1.fields[5] = new GFF_Field(GFFField.GFF_float, "YOrientation", 0.0f);
      struct1.fields[6] = new GFF_Field(GFFField.GFF_float, "ZOrientation", 0.0f);
      struct1.fields[7] = new GFF_Field(GFFField.GFF_List, "Geometry", new GFFList(0));
      GITfile.AddListElement("TriggerList", struct1);
      GffStruct struct2 = new GffStruct(3, 3);
      struct2.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", 0.0f);
      struct2.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", 0.0f);
      struct2.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
      GITfile.AddListElement("TriggerList(" + StringType.FromInteger(checked (GITfile.GetListItemCount("TriggerList") - 1)) + ").Geometry", struct2);
      int num2 = checked (PointList.Count - 1);
      int index = 1;
      while (index <= num2)
      {
        GffStruct struct3 = new GffStruct(3, 3);
        struct3.fields[0] = new GFF_Field(GFFField.GFF_float, "PointX", SingleType.FromObject(ObjectType.DivObj(ObjectType.SubObj(LateBinding.LateGet(PointList[index], null, "X", new object[0], null, null), x), nudXmul.Value)));
        struct3.fields[1] = new GFF_Field(GFFField.GFF_float, "PointY", Convert.ToSingle(Decimal.Divide(new Decimal(checked (invy(IntegerType.FromObject(LateBinding.LateGet(PointList[index], null, "Y", new object[0], null, null))) - num1)), nudYmul.Value)));
        struct3.fields[2] = new GFF_Field(GFFField.GFF_float, "PointZ", 0.0f);
        GITfile.AddListElement("TriggerList(" + StringType.FromInteger(checked (GITfile.GetListItemCount("TriggerList") - 1)) + ").Geometry", struct3);
        checked { ++index; }
      }
    }

  private void CreateEncounter(string TemplateResRef, ArrayList PointList)
  {
      GffStruct struct1 = new GffStruct(6, 7);
      GFFList gffList = new GFFList(checked (PointList.Count - 1));
      Point point = (Point) (PointList[0] ?? Activator.CreateInstance(typeof (Point)));
      int x = point.X;
      point = (Point) (PointList[0] ?? Activator.CreateInstance(typeof (Point)));
      int num1 = invy(point.Y);
      struct1.fields[0] = new GFF_Field(GFFField.GFF_CResRef, nameof (TemplateResRef), TemplateResRef);
      struct1.fields[1] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
      struct1.fields[2] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(num1), nudYoff.Value), nudYmul.Value)));
      struct1.fields[3] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
      struct1.fields[4] = new GFF_Field(GFFField.GFF_List, "Geometry", new GFFList(0));
      struct1.fields[5] = new GFF_Field(GFFField.GFF_List, "SpawnPointList", new GFFList(0));
      GITfile.AddListElement("Encounter List", struct1);
      GffStruct struct2 = new GffStruct(3, 3);
      struct2.fields[0] = new GFF_Field(GFFField.GFF_float, "X", 0.0f);
      struct2.fields[1] = new GFF_Field(GFFField.GFF_float, "Y", 0.0f);
      struct2.fields[2] = new GFF_Field(GFFField.GFF_float, "Z", 0.0f);
      GITfile.AddListElement("Encounter List(" + StringType.FromInteger(checked (GITfile.GetListItemCount("Encounter List") - 1)) + ").Geometry", struct2);
      int num2 = checked (PointList.Count - 1);
      int index = 1;
      while (index <= num2)
      {
        GffStruct struct3 = new GffStruct(3, 3);
        struct3.fields[0] = new GFF_Field(GFFField.GFF_float, "X", SingleType.FromObject(ObjectType.DivObj(ObjectType.SubObj(LateBinding.LateGet(PointList[index], null, "X", new object[0], null, null), x), nudXmul.Value)));
        struct3.fields[1] = new GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(new Decimal(checked (invy(IntegerType.FromObject(LateBinding.LateGet(PointList[index], null, "Y", new object[0], null, null))) - num1)), nudYmul.Value)));
        struct3.fields[2] = new GFF_Field(GFFField.GFF_float, "Z", 0.0f);
        GITfile.AddListElement("Encounter List(" + StringType.FromInteger(checked (GITfile.GetListItemCount("Encounter List") - 1)) + ").Geometry", struct3);
        checked { ++index; }
      }
    }

  private void BuildModFile()
  {
      ArrayList list = new ArrayList();
      FrmProgressMeter childForm = new FrmProgressMeter();
      childForm.Maxvalue = 6;
      childForm.Message = "Building Module";
      childForm.Status = "Add definition files";
      childForm.StepAmount = 1;
      ((Control) childForm).Location = new utilWindowRelativePositioner(this, childForm).GetConcentric();
      childForm.Show();
      tbHelp.Text = "Starting module build";
      miSave_Click(null, null);
      list.Add(g_ProjectPath + "\\" + g_MapName + ".git");
      list.Add(g_ProjectPath + "\\" + g_MapName + ".are");
      list.Add(g_ProjectPath + "\\" + g_MapName + ".pth");
      list.Add(g_ProjectPath + "\\module.ifo");
      childForm.StepUp();
      childForm.Status = "Add instance files";
      childForm.StepUp();
      int refcount = 0;
      int instcount = 0;
      BuildModuleFileList(CreatureArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(ItemArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(DoorArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(MerchantArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(PlaceableArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(TriggerArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(SoundArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(WaypointArr, ref list, ref refcount, ref instcount);
      BuildModuleFileList(EncounterArr, ref list, ref refcount, ref instcount);
      Console.WriteLine("Template Refs: " + StringType.FromInteger(refcount) + "  Instances: " + StringType.FromInteger(instcount));
      childForm.Status = "Add support files";
      childForm.StepUp();
      AddModuleFileNamesToList(g_ProjectPath, ref list, "*.ncs");
      AddModuleFileNamesToList(g_ProjectPath, ref list, "*.dlg");
      childForm.Status = "Add extras files";
      childForm.StepUp();
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.utc");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.utd");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.uti");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.utm");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.utp");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.utt");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.uts");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.utw");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.ute");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.tga");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.mdl");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.mdx");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.pwk");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.lyt");
      AddModuleFileNamesToList(g_ProjectPath + "\\extras", ref list, "*.2da");
      string[] inputFileList = new string[checked (list.Count - 1 + 1)];
      int num = checked (list.Count - 1);
      int index = 0;
      while (index <= num)
      {
        inputFileList[index] = StringType.FromObject(list[index]);
        checked { ++index; }
      }
      childForm.Status = "Create Mod file";
      childForm.StepUp();
      gModuleEditorSettings = ModuleEditorProjectSettings.GetSettings(g_ProjectPath);
      if (!gModuleEditorSettings.ModuleEditorModOutputPath.ToLower().EndsWith(".mod"))
      {
        string str = StringType.FromObject(FrmMain.GetFilePath("save", gModuleEditorSettings.ModuleEditorModOutputPath, "", "Select the destination and name for your Mod file", "mod"));
        if (!str.ToLower().EndsWith(".mod"))
          return;
        gModuleEditorSettings.ModuleEditorModOutputPath = str;
        ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
      }
      ClsErf clsErf = new ClsErf(gModuleEditorSettings.ModuleEditorModOutputPath, "MOD", Convert.ToUInt32(0), null, inputFileList);
      tbHelp.Text = "Module build complete";
      childForm.Close();
    }

  private void frmModule_Editor_Load(object sender, EventArgs e)
  {
      Options settings = UserSettings.GetSettings();
      PositionWindow(GetType().Name);
      dModuleElementIndicatorSize = settings.ModuleEditorModuleElementIndicatorSize;
      bConfirmDeletes = settings.bModuleEditorConfirmDeletes;
      bShowLocatorRay = settings.bModuleEditorShowLocatorRay;
      tbHelp.Text = "";
    }

  private void frmModule_Editor_Closing(object sender, CancelEventArgs e)
  {
      if (!bModuleLoadedOK)
        return;
      SaveSettings(GetType().Name);
      UserSettings.SaveSettings(CurrentSettings);
      if (StringType.StrCmp(g_ProjectPath, "", false) == 0)
        return;
      ModuleEditorProjectOptions moduleEditorSettings1 = gModuleEditorSettings;
      Point autoScrollPosition = Panel1.AutoScrollPosition;
      int num1 = checked (0 - autoScrollPosition.X);
      moduleEditorSettings1.LastScrollPosX = num1;
      ModuleEditorProjectOptions moduleEditorSettings2 = gModuleEditorSettings;
      autoScrollPosition = Panel1.AutoScrollPosition;
      int num2 = checked (0 - autoScrollPosition.Y);
      moduleEditorSettings2.LastScrollPosY = num2;
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
    }

  private void pbox_MouseDown(object sender, MouseEventArgs e)
  {
      if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
      {
        object obj = (PictureBox) sender;
        ModItem modItem = FindModItem((PictureBox) sender);
        object o1 = obj;
        object[] objArray1 = new object[1];
        object[] objArray2 = objArray1;
        object o2 = obj;
        object objectValue = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(o2, null, "MousePosition", new object[0], null, null));
        objArray2[0] = objectValue;
        object[] objArray3 = objArray1;
        object[] args = objArray3;
        bool[] flagArray = new bool[1]{ true };
        bool[] CopyBack = flagArray;
        object instance = LateBinding.LateGet(o1, null, "PointToClient", args, null, CopyBack);
        if (flagArray[0])
          LateBinding.LateSetComplex(o2, null, "MousePosition", new object[1]
          {
            RuntimeHelpers.GetObjectValue(objArray3[0])
          }, null, true, false);
        if (instance == null)
          instance = Activator.CreateInstance(typeof (Point));
        Point point1 = (Point) instance;
        int x = point1.X;
        int y = point1.Y;
        tbMouseX.Text = StringType.FromInteger(x);
        tbMouseY.Text = StringType.FromInteger(y);
        Point point2 = new Point(x, y);
        gLastMousePos = point2;
        point2 = new Point(x, y);
        g_LastMouseDownPos = point2;
        if (modItem != null)
        {
          CurrentModItem = modItem;
          IndicatedModItem = modItem;
          if (e.Button == MouseButtons.Left)
          {
            tbHelp.Text = modItem.ItemType != 2032 ? "Move the mouse to reposition this item. Right-click for the pop-up menu." : (!modItem.FileName.StartsWith("g_t_") ? "Move the mouse to reposition this node of the trigger. Hold down the shift key to move the whole trigger region. The trigger is not redrawn while dragging. Right-click for the pop-up menu." : "Move the mouse to reposition this trap. The trap is not redrawn while dragging. Right-click for the pop-up menu.");
            sbarpnlDesc.Text = modItem.ResRef;
            CurrentModItemBmp = new Bitmap(3, 3);
            Graphics graphics = Graphics.FromImage(CurrentModItemBmp);
            Rectangle srcRect = new Rectangle(checked (modItem.ScreenX - 1), checked (modItem.ScreenY - 1), 3, 3);
            Rectangle destRect = new Rectangle(0, 0, 3, 3);
            graphics.DrawImage(bmp, destRect, srcRect, GraphicsUnit.Pixel);
          }
          if (e.Button == MouseButtons.Right && modItem.ItemType != 5000)
          {
            this.cmMapSurfaceItems.ToolStripMenuItems[this.cmMapSurfaceItems.ToolStripMenuItems.IndexOf(cmiEditGFFFile)].Visible = modItem.ItemType != 6 && modItem.ItemType != 12040;
            this.cmMapSurfaceItems.ToolStripMenuItems[this.cmMapSurfaceItems.ToolStripMenuItems.IndexOf(cmiProperties)].Visible = modItem.ItemType != 12040;
            this.cmMapSurfaceItems.ToolStripMenuItems[this.cmMapSurfaceItems.ToolStripMenuItems.IndexOf(cmiAddNewSpawnPoint)].Visible = modItem.ItemType == 2040;
            IndicatedModItem = null;
            ContextMenu cmMapSurfaceItems = this.cmMapSurfaceItems;
            Control control = (Control) obj;
            point2 = new Point(x, y);
            Point pos = point2;
            cmMapSurfaceItems.Show(control, pos);
            LeftMouseClickActive = false;
          }
          else
            LeftMouseClickActive = true;
        }
        else
        {
          if (!g_IsDrawingRegion && e.Button == MouseButtons.Right)
          {
            ContextMenu cmPbox = this.cmPbox;
            Control control = (Control) obj;
            point2 = new Point(x, y);
            Point pos = point2;
            cmPbox.Show(control, pos);
            LeftMouseClickActive = false;
          }
          tbHelp.Text = "Left-click to select, right-click for pop-up menu, middle-click to pan";
        }
        LoadBackground();
        Draw();
      }
      else
      {
        if (e.Button != MouseButtons.Middle)
          return;
        tbHelp.Text = "Press Shift key for 2x pan, Control for 10x pan";
        Point client = Panel1.PointToClient(MousePosition);
        gLastMousePos = new Point(client.X, client.Y);
      }
    }

  private void pbox_MouseMove(object sender, MouseEventArgs e)
  {
      PictureBox pictureBox = (PictureBox) sender;
      int x1 = pictureBox.PointToClient(MousePosition).X;
      Point point1 = pictureBox.PointToClient(MousePosition);
      int y1 = point1.Y;
      sbarpnlLocX.Text = "X: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x1), nudXoff.Value), nudXmul.Value)));
      sbarpnlLocY.Text = "Y: " + StringType.FromSingle(Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y1)), nudYoff.Value), nudYmul.Value)));
      if (e.Button == MouseButtons.None)
      {
        if (!g_IsDrawingRegion)
          return;
        tbHelp.Text = "Left click to set next point or Right click to auto-close region";
        Rectangle selectionRect;
        if (backbuffer != null)
        {
          Graphics graphics = Graphics.FromImage(bmp);
          selectionRect = new Rectangle(0, 0, backbuffer.Width, backbuffer.Height);
          Rectangle srcRect = selectionRect;
          selectionRect = new Rectangle(gLastBackBufferOrigin.X, gLastBackBufferOrigin.Y, backbuffer.Width, backbuffer.Height);
          Rectangle destRect = NormalizeRectangle(selectionRect);
          graphics.DrawImage(backbuffer, destRect, srcRect, GraphicsUnit.Pixel);
        }
        if (g_RegionPointList.Count > 1)
          DrawRegionPoints(Graphics.FromImage(bmp), g_RegionPointList, gCurrentRegionDrawingColor, false);
        selectionRect = new Rectangle(gCurrentRegionSegmentOrigin.X, gCurrentRegionSegmentOrigin.Y, checked (x1 - gCurrentRegionSegmentOrigin.X), checked (y1 - gCurrentRegionSegmentOrigin.Y));
        Rectangle srcRect1 = NormalizeRectangle(selectionRect);
        checked { ++srcRect1.Width; }
        checked { ++srcRect1.Height; }
        backbuffer = new Bitmap(srcRect1.Width, srcRect1.Height);
        Graphics graphics1 = Graphics.FromImage(backbuffer);
        selectionRect = new Rectangle(0, 0, srcRect1.Width, srcRect1.Height);
        Rectangle destRect1 = selectionRect;
        graphics1.DrawImage(bmp, destRect1, srcRect1, GraphicsUnit.Pixel);
        Graphics graphics2 = Graphics.FromImage(bmp);
        graphics2.DrawLine(new Pen(gCurrentRegionDrawingColor, 1f), gCurrentRegionSegmentOrigin.X, gCurrentRegionSegmentOrigin.Y, x1, y1);
        Graphics graphics3 = graphics2;
        Pen pen = new Pen(gCurrentRegionDrawingColor, 1f);
        selectionRect = new Rectangle(checked (gCurrentRegionSegmentOrigin.X - 1), checked (gCurrentRegionSegmentOrigin.Y - 1), 2, 2);
        Rectangle rect = selectionRect;
        graphics3.DrawRectangle(pen, rect);
        pbox.Refresh();
        gLastBackBufferOrigin = srcRect1.Location;
        point1 = new Point(x1, y1);
        gLastMousePos = point1;
      }
      else if (e.Button == MouseButtons.Left)
      {
        if (!(CurrentModItem != null & LeftMouseClickActive))
          return;
        long ticks1 = DateAndTime.Now.Ticks;
        Cursor.Current = Cursors.Cross;
        Rectangle rectangle;
        if (backbuffer != null)
        {
          Graphics graphics = Graphics.FromImage(bmp);
          rectangle = new Rectangle(0, 0, 3, 3);
          Rectangle srcRect = rectangle;
          rectangle = new Rectangle(checked (gLastMousePos.X - 1), checked (gLastMousePos.Y - 1), 3, 3);
          Rectangle destRect = rectangle;
          graphics.DrawImage(backbuffer, destRect, srcRect, GraphicsUnit.Pixel);
        }
        TimeSpan timeSpan1 = new TimeSpan(checked (DateAndTime.Now.Ticks - ticks1));
        TimeSpan timeSpan2 = timeSpan1;
        long ticks2 = DateAndTime.Now.Ticks;
        Console.WriteLine("Move Drawing Time 1: " + StringType.FromInteger(timeSpan2.Milliseconds));
        point1 = new Point(x1, y1);
        gLastMousePos = point1;
        backbuffer = new Bitmap(3, 3);
        Graphics graphics4 = Graphics.FromImage(backbuffer);
        rectangle = new Rectangle(checked (x1 - 1), checked (y1 - 1), 3, 3);
        Rectangle srcRect2 = rectangle;
        rectangle = new Rectangle(0, 0, 3, 3);
        Rectangle destRect2 = rectangle;
        long ticks3 = DateAndTime.Now.Ticks;
        graphics4.DrawImage(bmp, destRect2, srcRect2, GraphicsUnit.Pixel);
        ref TimeSpan local1 = ref timeSpan1;
        DateTime now = DateAndTime.Now;
        long ticks4 = checked (now.Ticks - ticks3);
        local1 = new TimeSpan(ticks4);
        Console.WriteLine("Move Drawing Time 2e: " + StringType.FromInteger(timeSpan1.Milliseconds));
        now = DateAndTime.Now;
        long ticks5 = now.Ticks;
        Graphics graphics5 = Graphics.FromImage(bmp);
        rectangle = new Rectangle(0, 0, 3, 3);
        Rectangle srcRect3 = rectangle;
        rectangle = new Rectangle(checked (x1 - 1), checked (y1 - 1), 3, 3);
        Rectangle destRect3 = rectangle;
        graphics5.DrawImage(CurrentModItemBmp, destRect3, srcRect3, GraphicsUnit.Pixel);
        ref TimeSpan local2 = ref timeSpan1;
        now = DateAndTime.Now;
        long ticks6 = checked (now.Ticks - ticks5);
        local2 = new TimeSpan(ticks6);
        Console.WriteLine("Move Drawing Time 3: " + StringType.FromInteger(timeSpan1.Milliseconds) + " T: " + StringType.FromLong(ticks5) + " x: " + StringType.FromInteger(x1) + " Y: " + StringType.FromInteger(y1));
        pbox.Refresh();
      }
      else
      {
        if (e.Button != MouseButtons.Middle)
          return;
        Panel panel1_1 = Panel1;
        int x2 = panel1_1.PointToClient(MousePosition).X;
        int y2 = panel1_1.PointToClient(MousePosition).Y;
        int num1 = checked (x2 - gLastMousePos.X);
        int num2 = checked (y2 - gLastMousePos.Y);
        if (ModifierKeys == Keys.Shift)
        {
          checked { num1 *= 2; }
          checked { num2 *= 2; }
        }
        if (ModifierKeys == Keys.Control)
        {
          checked { num1 *= 10; }
          checked { num2 *= 10; }
        }
        Point point2 = default;
        if (num1 != 0 || num2 != 0)
        {
          Point autoScrollPosition1 = Panel1.AutoScrollPosition;
          ref Point local3 = ref point2;
          Point autoScrollPosition2 = Panel1.AutoScrollPosition;
          int x3 = checked (0 - 0 - autoScrollPosition2.X - num1);
          Point autoScrollPosition3 = Panel1.AutoScrollPosition;
          int y3 = checked (0 - 0 - autoScrollPosition3.Y - num2);
          local3 = new Point(x3, y3);
          Point point3 = point2;
          if (autoScrollPosition1 != point3)
          {
            Panel panel1_2 = Panel1;
            ref Point local4 = ref autoScrollPosition2;
            point2 = Panel1.AutoScrollPosition;
            int x4 = checked (0 - point2.X - num1);
            autoScrollPosition3 = Panel1.AutoScrollPosition;
            int y4 = checked (0 - autoScrollPosition3.Y - num2);
            local4 = new Point(x4, y4);
            Point point4 = autoScrollPosition2;
            panel1_2.AutoScrollPosition = point4;
          }
        }
        point2 = new Point(x2, y2);
        gLastMousePos = point2;
      }
    }

  private void pbox_MouseUp(object sender, MouseEventArgs e)
  {
      if (CurrentModItem != null & !gLastMousePos.IsEmpty)
      {
        if (e.Button != MouseButtons.Left)
          return;
        Point client = pbox.PointToClient(MousePosition);
        int x = client.X;
        client = pbox.PointToClient(MousePosition);
        int y = client.Y;
        if (x == g_LastMouseDownPos.X && y == g_LastMouseDownPos.Y)
          return;
        if (CurrentModItem.ItemType != 2032 && CurrentModItem.ItemType != 2040 && CurrentModItem.ItemType != 6 && CurrentModItem.ItemType != 5000)
        {
          GITfile.SetNodeValue(CurrentModItem.Path + "." + CurrentModItem.XPosAccessor, Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          GITfile.SetNodeValue(CurrentModItem.Path + "." + CurrentModItem.YPosAccessor, Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
        }
        else if (CurrentModItem.ItemType == 2032 || CurrentModItem.ItemType == 2040)
        {
          int num1 = checked (x - CurrentModItem.ScreenX);
          int num2 = checked (invy(y) - CurrentModItem.ScreenY);
          if ((ModifierKeys & Keys.Shift) != 0 || CurrentModItem.FileName.StartsWith("g_t_"))
          {
            float num3 = SingleType.FromObject(GITfile.GetNodeValue(CurrentModItem.Path + ".XPosition"));
            float num4 = SingleType.FromObject(GITfile.GetNodeValue(CurrentModItem.Path + ".YPosition"));
            if ((~ModifierKeys & Keys.Alt) != 0)
              GITfile.SetNodeValue(CurrentModItem.Path + ".XPosition", (float) (num3 + (double) Convert.ToSingle(Decimal.Divide(new Decimal(checked (pbox.PointToClient(MousePosition).X - g_LastMouseDownPos.X)), nudXmul.Value))));
            if ((~ModifierKeys & Keys.Control) != 0)
              GITfile.SetNodeValue(CurrentModItem.Path + ".YPosition", (float) (num4 - (double) Convert.ToSingle(Decimal.Divide(new Decimal(checked (pbox.PointToClient(MousePosition).Y - g_LastMouseDownPos.Y)), nudYmul.Value))));
          }
          else
          {
            tbHelp.Text = "";
            float single1 = Convert.ToSingle(Decimal.Divide(new Decimal(num1), nudXmul.Value));
            float single2 = Convert.ToSingle(Decimal.Divide(new Decimal(num2), nudYmul.Value));
            SingleType.FromObject(GITfile.GetNodeValue(CurrentModItem.Path + "." + CurrentModItem.XPosAccessor));
            SingleType.FromObject(GITfile.GetNodeValue(CurrentModItem.Path + "." + CurrentModItem.YPosAccessor));
            GITfile.SetNodeValue(CurrentModItem.Path + "." + CurrentModItem.XPosAccessor, single1);
            GITfile.SetNodeValue(CurrentModItem.Path + "." + CurrentModItem.YPosAccessor, single2);
          }
        }
        else if (CurrentModItem.ItemType == 6)
          GITfile.SetNodeValue(CurrentModItem.Path + ".Position", new GFFType17()
          {
            f1 = Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)),
            f2 = Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value))
          });
        else if (CurrentModItem.ItemType == 5000)
        {
          IFOfile.SetNodeValue("Mod_Entry_X", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          IFOfile.SetNodeValue("Mod_Entry_Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
        }
        LoadBackground();
        Draw();
        CurrentModItem = null;
        CurrentModItemBmp = null;
        backbuffer = null;
        Cursor.Current = Cursors.Default;
        LeftMouseClickActive = false;
        gLastMousePos = (Point) ((object) null ?? Activator.CreateInstance(typeof (Point)));
      }
      else
      {
        if (g_IsDrawingRegion)
        {
          if (e.Button == MouseButtons.Left)
          {
            Point point = pbox.PointToClient(MousePosition);
            int x = point.X;
            point = pbox.PointToClient(MousePosition);
            int y = point.Y;
            point = new Point(x, y);
            gLastMousePos = point;
            gCurrentRegionSegmentOrigin = gLastMousePos;
            if (Near(x, y, RuntimeHelpers.GetObjectValue(LateBinding.LateGet(g_RegionPointList[0], null, "X", new object[0], null, null)), RuntimeHelpers.GetObjectValue(LateBinding.LateGet(g_RegionPointList[0], null, "Y", new object[0], null, null))))
            {
              g_IsDrawingRegion = false;
              if (gCurrentModItemType == 2032)
                CreateTrigger(g_RegionResRef, g_RegionPointList);
              else if (gCurrentModItemType == 2040)
                CreateEncounter(g_RegionResRef, g_RegionPointList);
              LoadBackground();
              Draw();
              BuildModuleTreeView();
            }
            else
            {
              ArrayList gRegionPointList = g_RegionPointList;
              point = new Point(x, y);
              // ISSUE: variable of a boxed type
              //__Boxed<Point> local = (ValueType) point;
              //gRegionPointList.Add((object) local);
            }
          }
          else if (e.Button == MouseButtons.Right)
          {
            tbHelp.Text = "";
            g_IsDrawingRegion = false;
            if (gCurrentModItemType == 2032)
              CreateTrigger(g_RegionResRef, g_RegionPointList);
            else if (gCurrentModItemType == 2040)
              CreateEncounter(g_RegionResRef, g_RegionPointList);
            gCurrentModItemType = -1;
            LoadBackground();
            Draw();
            BuildModuleTreeView();
          }
        }
        tbHelp.Text = "";
        sbarpnlDesc.Text = "";
        sbarpnlAddlInfo.Text = "";
      }
    }

  private void pbox_MouseLeave(object sender, EventArgs e)
  {
      sbarpnlLocX.Text = "";
      sbarpnlLocY.Text = "";
    }

  private void nudMulOff_ValueChanged(object sender, EventArgs e)
  {
      if (!(CanFocus & chkbUseFactors.Checked))
        return;
      LoadBackground();
      Draw();
    }

  private void tvPalette_ItemDrag(object sender, ItemDragEventArgs e)
  {
      TreeNode treeNode = (TreeNode) e.Item;
      string text = treeNode.Text;
      if (treeNode.Tag == null || ObjectType.ObjTst(treeNode.Tag, "", false) == 0)
        return;
      int num = (int) DoDragDrop(RuntimeHelpers.GetObjectValue(treeNode.Tag), DragDropEffects.Copy | DragDropEffects.Move);
    }

  private void tvUserPalette_ItemDrag(object sender, ItemDragEventArgs e)
  {
      TreeNode treeNode = (TreeNode) e.Item;
      string text = treeNode.Text;
      if (treeNode.Tag == null || ObjectType.ObjTst(treeNode.Tag, "", false) == 0)
        return;
      int num = (int) DoDragDrop(RuntimeHelpers.GetObjectValue(treeNode.Tag), DragDropEffects.Copy | DragDropEffects.Move);
    }

  private void tvModule_MouseDown(object sender, MouseEventArgs e) => LastClickedTvModuleNode = (ModItemTvNode) tvModule.GetNodeAt(new Point(e.X, e.Y));

  private void tvModule_MouseUp(object sender, MouseEventArgs e)
  {
      Point pos = new Point(e.X, e.Y);
      ModItemTvNode clickedTvModuleNode = LastClickedTvModuleNode;
      if (clickedTvModuleNode != null)
        CurrentContextMenuTvModuleNode = clickedTvModuleNode;
      if (e.Button == MouseButtons.Right)
      {
        if (clickedTvModuleNode == null)
          return;
        object tag = clickedTvModuleNode.Tag;
        if (ObjectType.ObjTst(tag, "ItemParent", false) != 0 && ObjectType.ObjTst(tag, "Item", false) == 0)
        {
          tvModuleContextToolStripMenuItem.ToolStripMenuItems[tvModuleContextToolStripMenuItem.ToolStripMenuItems.IndexOf(cmiTvModuleItemEdit)].Visible = clickedTvModuleNode.ItemType != 6;
          tvModuleContextToolStripMenuItem.Show(tvModule, pos);
        }
        tvModule.SelectedNode = CurrentContextMenuTvModuleNode;
      }
      else
      {
        if (e.Button != MouseButtons.Left)
          return;
        tbHelp.Text = "Click an item to see it's location in the module, or right-click it to access the pop-up menu.";
        if (clickedTvModuleNode == null || e.X < clickedTvModuleNode.Bounds.Left)
          return;
        LeftMouseClickActive = false;
        if (ObjectType.ObjTst(clickedTvModuleNode.Tag, "Item", false) != 0)
          return;
        IndicatedModItem = GetTreeNodesModItem(clickedTvModuleNode);
        LoadBackground();
        Draw();
      }
    }

  private void tvModule_KeyUp(object sender, KeyEventArgs e)
  {
      if (tvModule.SelectedNode == null || ObjectType.ObjTst(tvModule.SelectedNode.Tag, "Item", false) != 0)
        return;
      IndicatedModItem = GetTreeNodesModItem((ModItemTvNode) tvModule.SelectedNode);
      LoadBackground();
      Draw();
    }

  private void tvModule_BeforeExpand(object sender, TreeViewCancelEventArgs e)
  {
      ModItemTvNode node = (ModItemTvNode) e.Node;
      if (!g_tvModule_TreeOpenPaths.Contains(node.FullPath))
        g_tvModule_TreeOpenPaths.Add(node.FullPath);
      AddNodeChildrenToTreePaths(node, g_tvModule_TreeOpenPaths);
    }

  private void tvModule_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
  {
      ModItemTvNode node = (ModItemTvNode) e.Node;
      int index = checked (g_tvModule_TreeOpenPaths.Count - 1);
      while (index >= 0)
      {
        if (BooleanType.FromObject(BooleanType.FromObject(LateBinding.LateGet(g_tvModule_TreeOpenPaths[index], null, "StartsWith", new object[1]
        {
          node.FullPath + "\\"
        }, null, null)) || BooleanType.FromObject(ObjectType.ObjTst(g_tvModule_TreeOpenPaths[index], node.FullPath, false) == 0) ? true : (object) false))
          g_tvModule_TreeOpenPaths.RemoveAt(index);
        checked { index += -1; }
      }
    }

  private void cmiProperties_Click(object sender, EventArgs e)
  {
      EditItemProperties(CurrentModItem);
      CurrentModItem = null;
      LoadBackground();
      Draw();
    }

  private void cmiEdit_Click(object sender, EventArgs e)
  {
      EditItem(CurrentModItem);
      CurrentModItem = null;
    }

  private void cmiDelete_Click(object sender, EventArgs e)
  {
      if (bConfirmDeletes && Interaction.MsgBox("Are you sure you want to delete this?", MsgBoxStyle.OkCancel, "Delete Item") != MsgBoxResult.Ok)
        return;
      DeleteModuleItem(CurrentModItem);
      CurrentModItem = null;
    }

  private void cmiAddNewSpawnPoint_Click(object sender, EventArgs e)
  {
      ModItem currentModItem = CurrentModItem;
      if (!GITfile.VerifyNodeExists(currentModItem.Path + ".SpawnPointList"))
        GITfile.CreateList(currentModItem.Path, "SpawnPointList");
      int listItemCount = GITfile.GetListItemCount(currentModItem.Path + ".SpawnPointList");
      GffStruct @struct = new GffStruct(4, 2);
      @struct.fields[0] = new GFF_Field(GFFField.GFF_float, "X", (float) (currentModItem.Parent.X + 2.0 + listItemCount));
      @struct.fields[1] = new GFF_Field(GFFField.GFF_float, "Y", (float) (currentModItem.Parent.Y + 2.0));
      @struct.fields[2] = new GFF_Field(GFFField.GFF_float, "Z", 0.0);
      @struct.fields[3] = new GFF_Field(GFFField.GFF_float, "Orientation", 0.0);
      GITfile.AddListElement(currentModItem.Path + ".SpawnPointList", @struct);
      LoadBackground();
      Draw();
      BuildModuleTreeView();
    }

  private void cmiTvModuleItemProperties_Click(object sender, EventArgs e)
  {
      ModItemTvNode menuTvModuleNode = CurrentContextMenuTvModuleNode;
      Pen pen = new Pen(Color.Orange, 1f);
      pen.EndCap = LineCap.ArrowAnchor;
      ModItem treeNodesModItem = GetTreeNodesModItem(menuTvModuleNode);
      Panel1.AutoScrollPosition = new Point(checked ((int) Math.Round(treeNodesModItem.ScreenX - Panel1.Size.Width / 2.0)), checked ((int) Math.Round(treeNodesModItem.ScreenY - Panel1.Size.Height / 2.0)));
      if (bShowLocatorRay)
        Graphics.FromImage(pbox.Image).DrawLine(pen, 0, 0, checked (treeNodesModItem.ScreenX - 3), checked (treeNodesModItem.ScreenY - 3));
      pbox.Update();
      EditItemProperties(treeNodesModItem);
      LoadBackground();
      Draw();
    }

  private void cmiTvModuleItemEdit_Click(object sender, EventArgs e)
  {
      ModItemTvNode menuTvModuleNode = CurrentContextMenuTvModuleNode;
      Pen pen = new Pen(Color.Orange, 1f);
      pen.EndCap = LineCap.ArrowAnchor;
      ModItem treeNodesModItem = GetTreeNodesModItem(menuTvModuleNode);
      Panel1.AutoScrollPosition = new Point(checked ((int) Math.Round(treeNodesModItem.ScreenX - Panel1.Size.Width / 2.0)), checked ((int) Math.Round(treeNodesModItem.ScreenY - Panel1.Size.Height / 2.0)));
      if (bShowLocatorRay)
        Graphics.FromImage(pbox.Image).DrawLine(pen, 0, 0, checked (treeNodesModItem.ScreenX - 3), checked (treeNodesModItem.ScreenY - 3));
      pbox.Update();
      EditItem(treeNodesModItem);
      LoadBackground();
      Draw();
    }

  private void cmiTvModuleItemDelete_Click(object sender, EventArgs e)
  {
      if (bConfirmDeletes && Interaction.MsgBox("Are you sure you want to delete this?", MsgBoxStyle.OkCancel, "Delete Item") != MsgBoxResult.Ok)
        return;
      ModItemTvNode menuTvModuleNode = CurrentContextMenuTvModuleNode;
      string fullPath = menuTvModuleNode.Parent.FullPath;
      DeleteModuleItem(GetTreeNodesModItem(menuTvModuleNode));
      CurrentModItem = null;
      FrmMain.OpenTreeViewToPath(fullPath, tvModule.Nodes[0], 0);
    }

  private void cmiCreateCameraHere_Click(object sender, EventArgs e)
  {
      float single1 = Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(g_LastMouseDownPos.X), nudXoff.Value), nudXmul.Value));
      float single2 = Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(g_LastMouseDownPos.Y)), nudYoff.Value), nudYmul.Value));
      if (!GITfile.VerifyNodeExists("CameraList"))
        GITfile.CreateList("", "CameraList");
      int listItemCount = GITfile.GetListItemCount("CameraList");
      int num1 = -1;
      int FieldValue;
      if (listItemCount == 0)
      {
        FieldValue = 1;
      }
      else
      {
        int num2 = checked (listItemCount - 1);
        int num3 = 0;
        while (num3 <= num2)
        {
          int num4 = IntegerType.FromObject(GITfile.GetNodeValue("CameraList(" + StringType.FromInteger(num3) + ").CameraID"));
          if (num4 > num1)
            num1 = num4;
          checked { ++num3; }
        }
        FieldValue = checked (num1 + 1);
      }
      GffStruct @struct = new GffStruct();
      @struct.type = 14;
      @struct.fieldCount = 8;
      @struct.fields = new GFF_Field[8];
      @struct.fields[0] = new GFF_Field(GFFField.GFF_int, "CameraID", FieldValue);
      @struct.fields[1] = new GFF_Field(GFFField.GFF_Type17, "Position", new GFFType17(single1, single2, 0.0f));
      @struct.fields[2] = new GFF_Field(GFFField.GFF_float, "Pitch", 0);
      @struct.fields[3] = new GFF_Field(GFFField.GFF_float, "MicRange", 0);
      @struct.fields[4] = new GFF_Field(GFFField.GFF_Type16, "Orientation", new GFFType16(1f, 0.0f, 0.0f, 0.0f));
      @struct.fields[5] = new GFF_Field(GFFField.GFF_float, "Height", 2);
      @struct.fields[6] = new GFF_Field(GFFField.GFF_float, "FieldOfView", 55);
      @struct.fields[7] = new GFF_Field(GFFField.GFF_Type17, "EAOrientation", new GFFType17(0.0f, 0.0f, 0.0f));
      GITfile.AddListElement("CameraList", @struct);
      LoadBackground();
      Draw();
      BuildModuleTreeView();
    }

  private void cmiSetModuleStartPoint_Click(object sender, EventArgs e)
  {
      float single1 = Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(g_LastMouseDownPos.X), nudXoff.Value), nudXmul.Value));
      float single2 = Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(g_LastMouseDownPos.Y)), nudYoff.Value), nudYmul.Value));
      IFOfile.SetNodeValue("Mod_Entry_X", single1);
      IFOfile.SetNodeValue("Mod_Entry_Y", single2);
      LoadBackground();
      Draw();
    }

  private void cmiModuleProperties_Click(object sender, EventArgs e) => miModuleProperties_Click(null, null);

  private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (((TabControl) sender).SelectedTab == tabpagUserPalette)
        tbHelp.Text = "Place files in your project's UserPalette folder to make them available here.";
      else
        tbHelp.Text = "Click an item type button on the palette above to see the available standard items you can place in the module.";
    }

  private void btnSave_Click(object sender, EventArgs e)
  {
    }

  private void btnTest_Click(object sender, EventArgs e)
  {
    }

  private void btnClean_Click(object sender, EventArgs e)
  {
      GITfile.ClearListElements("Creature List");
      GITfile.ClearListElements("Placeable List");
      GITfile.ClearListElements("Door List");
      GITfile.ClearListElements("SoundList");
      GITfile.ClearListElements("WaypointList");
      GITfile.ClearListElements("TriggerList");
      int index = 8;
      do
      {
        GITfile.DeleteListElement("CameraList", index);
        checked { index += -1; }
      }
      while (index >= 1);
    }

  private void btnPalCreature_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2027;
      BuildPaletteTreeView("creaturepalstd");
      tbHelp.Text = "Drag the desired creature onto the map";
    }

  private void btnPalDoor_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2042;
      BuildPaletteTreeView("doorpalstd");
      tbHelp.Text = "Drag the desired door onto the map";
    }

  private void btnPalEncounter_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2040;
      BuildPaletteTreeView("encounterpalstd");
      tbHelp.Text = "Encounters are not yet supported";
    }

  private void btnPalItem_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2025;
      BuildPaletteTreeView("itempalstd");
    }

  private void btnPalMerchant_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2051;
      tbHelp.Text = "Drag the desired merchant onto the map";
      BuildPaletteTreeView("storepal");
    }

  private void btnPalPlaceable_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2044;
      BuildPaletteTreeView("placeablepalstd");
      tbHelp.Text = "Drag the desired placeable onto the map";
    }

  private void btnPalSound_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2035;
      BuildPaletteTreeView("soundpal");
      tbHelp.Text = "Drag the desired sound onto the map";
    }

  private void btnPalTrigger_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2032;
      BuildPaletteTreeView("triggerpalstd");
      tbHelp.Text = "Drag the desired trigger type onto the map";
    }

  private void btnPalWaypoint_Click(object sender, EventArgs e)
  {
      g_CurrentPaletteModItemType = 2058;
      BuildPaletteTreeView("waypointpalstd");
      tbHelp.Text = "Drag the desired waypoint onto the map";
    }

  private void btnLogFactors_Click(object sender, EventArgs e)
  {
      StringWriter stringWriter = new StringWriter(new StringBuilder());
      frmErrorMessageWithCopyableText withCopyableText = new frmErrorMessageWithCopyableText();
      stringWriter.WriteLine("mie = New MapInfo.Map");
      stringWriter.WriteLine("mie.MapName = \"" + g_MapName + "\"");
      stringWriter.WriteLine("mie.MapAssembler = \"Fred Tetra\"");
      stringWriter.WriteLine("mie.MapCalibrator = \"Fred Tetra\"");
      stringWriter.WriteLine("mie.ModuleName = \"Harbinger\"");
      if (miUseSmallMap.Checked)
      {
        stringWriter.WriteLine("mie.S = True");
        stringWriter.WriteLine("mie.SXMul = " + StringType.FromDecimal(nudXmul.Value));
        stringWriter.WriteLine("mie.SYMul = " + StringType.FromDecimal(nudYmul.Value));
        stringWriter.WriteLine("mie.SXOff = " + StringType.FromDecimal(nudXoff.Value));
        stringWriter.WriteLine("mie.SYOff = " + StringType.FromDecimal(nudYoff.Value));
      }
      else
      {
        stringWriter.WriteLine("mie.L = True");
        stringWriter.WriteLine("mie.LXMul = " + StringType.FromDecimal(nudXmul.Value));
        stringWriter.WriteLine("mie.LYMul = " + StringType.FromDecimal(nudYmul.Value));
        stringWriter.WriteLine("mie.LXOff = " + StringType.FromDecimal(nudXoff.Value));
        stringWriter.WriteLine("mie.LYOff = " + StringType.FromDecimal(nudYoff.Value));
      }
      stringWriter.WriteLine("mi.MapList.Add(mie)");
      withCopyableText.tbMsg.Text = stringWriter.ToString();
      int num = (int) withCopyableText.ShowDialog(this);
    }

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = g_MapName + ".git";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = GITfile.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void btnTweakUp_Click(object sender, EventArgs e)
  {
      if (IndicatedModItem == null)
        return;
      GITfile.SetNodeValue(IndicatedModItem.YPosPath, ObjectType.AddObj(GITfile.GetNodeValue(IndicatedModItem.YPosPath), 0.01));
      UpdateAfterTweakBtn();
    }

  private void btnTweakDown_Click(object sender, EventArgs e)
  {
      if (IndicatedModItem == null)
        return;
      GITfile.SetNodeValue(IndicatedModItem.YPosPath, ObjectType.SubObj(GITfile.GetNodeValue(IndicatedModItem.YPosPath), 0.01));
      UpdateAfterTweakBtn();
    }

  private void btnTweakLeft_Click(object sender, EventArgs e)
  {
      if (IndicatedModItem == null)
        return;
      GITfile.SetNodeValue(IndicatedModItem.XPosPath, ObjectType.SubObj(GITfile.GetNodeValue(IndicatedModItem.XPosPath), 0.01));
      UpdateAfterTweakBtn();
    }

  private void btnTweakRight_Click(object sender, EventArgs e)
  {
      if (IndicatedModItem == null)
        return;
      GITfile.SetNodeValue(IndicatedModItem.XPosPath, ObjectType.AddObj(GITfile.GetNodeValue(IndicatedModItem.XPosPath), 0.01));
      UpdateAfterTweakBtn();
    }

  private void Panel1_DragDrop(object sender, DragEventArgs e)
  {
      object[] objArray1 = new object[4];
      Point p = new Point(e.X, e.Y);
      int x = pbox.PointToClient(p).X;
      Point point = pbox.PointToClient(p);
      int y = point.Y;
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      object[] objArray2 = Strings.Split(StringType.FromObject(e.Data.GetData(typeof (string))), "|");
      int int32 = Convert.ToInt32(Strings.Replace(StringType.FromObject(objArray2[0]), "itemtype=", ""));
      gCurrentModItemType = int32;
      GffStruct struct1 = new GffStruct();
      string str1 = null;
      if (int32 != 6)
      {
        str1 = Strings.Replace(StringType.FromObject(objArray2[2]), "resref=", "");
        string str2 = str1 + "." + ResourceIdentification.FindResourceTypeForId(int32);
        if (objArray2.Length == 4 && (ObjectType.ObjTst(objArray2[3], "up", false) == 0 || ObjectType.ObjTst(objArray2[3], "gt", false) == 0))
        {
          frmInstanceOrRefPrompt instanceOrRefPrompt = new frmInstanceOrRefPrompt();
          int num1 = (int) instanceOrRefPrompt.ShowDialog(this);
          if (instanceOrRefPrompt.DialogResult == DialogResult.Cancel)
            return;
          frmPromptForString frmPromptForString = new frmPromptForString("Create new instance", "Enter name for new instance (16 character max)", str1);
          if (StringType.StrCmp(instanceOrRefPrompt.ItemClass, "instance", false) == 0)
          {
            frmPromptForString.tbValue.MaxLength = 16;
            string str3;
            do
            {
              int num2 = (int) frmPromptForString.ShowDialog(this);
              str3 = !FileExistsInProject(frmPromptForString.tbValue.Text.Trim() + "." + ResourceIdentification.FindResourceTypeForId(int32)) ? (StringType.StrCmp(str1, frmPromptForString.tbValue.Text.Trim(), false) != 0 ? "" : "You cannot use the name of the template. Please choose another.") : "A file with that name already exists. Please choose another.";
              if (StringType.StrCmp(str3, "", false) != 0)
              {
                int num3 = (int) Interaction.MsgBox(str3, MsgBoxStyle.Exclamation, "Name error");
              }
            }
            while (StringType.StrCmp(str3, "", false) != 0 || frmPromptForString.DialogResult == DialogResult.Cancel);
            if (frmPromptForString.DialogResult == DialogResult.Cancel)
              return;
            string sourceFileName = null;
            if (ObjectType.ObjTst(objArray2[3], "up", false) == 0)
              sourceFileName = g_ProjectPath + "\\userpalette\\" + str2;
            else if (ObjectType.ObjTst(objArray2[3], "gt", false) == 0)
              sourceFileName = FrmMain.GRootPath + "\\Global Templates\\k" + StringType.FromInteger(checked (KotorVersionIndex + 1)) + "\\" + str2;
            File.Copy(sourceFileName, g_ProjectPath + "\\" + frmPromptForString.tbValue.Text.Trim() + "." + ResourceIdentification.FindResourceTypeForId(int32));
            str1 = frmPromptForString.tbValue.Text.Trim();
          }
        }
      }
      string str4 = null;
      switch (int32 - 2027)
      {
        case 0:
          struct1.type = 4;
          struct1.fieldCount = 6;
          struct1.fields = new GFF_Field[6];
          struct1.fields[0] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          struct1.fields[1] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
          struct1.fields[2] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
          struct1.fields[3] = new GFF_Field(GFFField.GFF_float, "XOrientation", 1f);
          struct1.fields[4] = new GFF_Field(GFFField.GFF_float, "YOrientation", 0.0f);
          struct1.fields[5] = new GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", str1 + str4);
          GITfile.AddListElement("Creature List", struct1);
          gModuleEditorSettings.FilterShowCreatures = true;
          break;
        case 5:
          if (str1.StartsWith("g_t_"))
          {
            string TemplateResRef = str1;
            point = new Point(x, y);
            Point Center = point;
            CreateTrap(TemplateResRef, Center);
            break;
          }
          gCurrentRegionDrawingColor = Color.Orange;
          point = new Point(x, y);
          gLastMousePos = point;
          gCurrentRegionSegmentOrigin = gLastMousePos;
          if (!g_IsDrawingRegion)
          {
            g_RegionResRef = str1 + str4;
            g_IsDrawingRegion = true;
            backbuffer = null;
            g_RegionPointList = new ArrayList();
            ArrayList gRegionPointList = g_RegionPointList;
            point = new Point(x, y);
            // ISSUE: variable of a boxed type
            //__Boxed<Point> local = (ValueType) point;
            //gRegionPointList.Add((object) local);
          }
          else
          {
            int num4 = (int) Interaction.MsgBox("Currently Drawing a Region", MsgBoxStyle.Exclamation);
          }
          gModuleEditorSettings.FilterShowTriggers = true;
          break;
        case 8:
          GffStruct struct2 = new GffStruct(5, 6);
          struct2.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", str1);
          struct2.fields[1] = new GFF_Field(GFFField.GFF_dword, "GeneratedType", 0);
          struct2.fields[2] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          struct2.fields[3] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
          struct2.fields[4] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
          GITfile.AddListElement("SoundList", struct2);
          gModuleEditorSettings.FilterShowSounds = true;
          break;
        case 13:
          gCurrentRegionDrawingColor = Color.Green;
          point = new Point(x, y);
          gLastMousePos = point;
          gCurrentRegionSegmentOrigin = gLastMousePos;
          if (!g_IsDrawingRegion)
          {
            g_RegionResRef = str1 + str4;
            g_IsDrawingRegion = true;
            backbuffer = null;
            g_RegionPointList = new ArrayList();
            ArrayList gRegionPointList = g_RegionPointList;
            point = new Point(x, y);
            // ISSUE: variable of a boxed type
            //__Boxed<Point> local = (ValueType) point;
            //gRegionPointList.Add((object) local);
          }
          else
          {
            int num5 = (int) Interaction.MsgBox("Currently Drawing a Region", MsgBoxStyle.Exclamation);
          }
          gModuleEditorSettings.FilterShowEncounters = true;
          break;
        case 15:
          struct1.type = 8;
          struct1.fieldCount = 12;
          struct1.fields = new GFF_Field[12];
          struct1.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", str1 + str4);
          struct1.fields[1] = new GFF_Field(GFFField.GFF_CExoString, "Tag", "empty");
          struct1.fields[2] = new GFF_Field(GFFField.GFF_CResRef, "LinkedToModule", "empty");
          struct1.fields[3] = new GFF_Field(GFFField.GFF_CExoString, "LinkedTo", "empty");
          struct1.fields[4] = new GFF_Field(GFFField.GFF_byte, "LinkedToFlags", 0);
          GFFExoLocString FieldValue = new GFFExoLocString("none");
          struct1.fields[5] = new GFF_Field(GFFField.GFF_CExoLocString, "TransitionDestin", FieldValue);
          struct1.fields[6] = new GFF_Field(GFFField.GFF_float, "X", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          struct1.fields[7] = new GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
          struct1.fields[8] = new GFF_Field(GFFField.GFF_float, "Z", 0.0f);
          struct1.fields[9] = new GFF_Field(GFFField.GFF_float, "Bearing", 0.0f);
          struct1.fields[10] = new GFF_Field(GFFField.GFF_byte, "UseTweakColor", 0);
          struct1.fields[11] = new GFF_Field(GFFField.GFF_dword, "TweakColor", 16777215);
          GITfile.AddListElement("Door List", struct1);
          gModuleEditorSettings.FilterShowDoors = true;
          break;
        case 17:
          GffStruct struct3 = new GffStruct(5, 9);
          struct3.fields[0] = new GFF_Field(GFFField.GFF_float, "X", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          struct3.fields[1] = new GFF_Field(GFFField.GFF_float, "Y", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
          struct3.fields[2] = new GFF_Field(GFFField.GFF_float, "Z", 0.0f);
          struct3.fields[3] = new GFF_Field(GFFField.GFF_float, "Bearing", 0.0f);
          struct3.fields[4] = new GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", str1 + str4);
          GITfile.AddListElement("Placeable List", struct3);
          gModuleEditorSettings.FilterShowPlaceables = true;
          break;
        case 24:
          GffStruct struct4 = new GffStruct(6, 11);
          struct4.fields[0] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          struct4.fields[1] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
          struct4.fields[2] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
          struct4.fields[3] = new GFF_Field(GFFField.GFF_float, "XOrientation", 1f);
          struct4.fields[4] = new GFF_Field(GFFField.GFF_float, "YOrientation", 0.0f);
          struct4.fields[5] = new GFF_Field(GFFField.GFF_CResRef, "ResRef", str1);
          GITfile.AddListElement("StoreList", struct4);
          gModuleEditorSettings.FilterShowMerchants = true;
          break;
        case 31:
          ClsGff clsGff = new ClsGff(FrmMain.GetTemplateBifResourceData(KotorVersionIndex, str1, int32), KotorVersionIndex, false);
          clsGff.GetCExoLocStringNodeValue("LocalizedName");
          GffStruct struct5 = new GffStruct(14, 5);
          struct5.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "TemplateResRef", RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("TemplateResRef")));
          struct5.fields[1] = new GFF_Field(GFFField.GFF_CExoString, "LinkedTo", RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("LinkedTo")));
          struct5.fields[2] = new GFF_Field(GFFField.GFF_CExoString, "Tag", RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("Tag")));
          struct5.fields[3] = new GFF_Field(GFFField.GFF_byte, "HasMapNote", RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("HasMapNote")));
          struct5.fields[4] = new GFF_Field(GFFField.GFF_byte, "MapNoteEnabled", RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("MapNoteEnabled")));
          struct5.fields[5] = new GFF_Field(GFFField.GFF_CExoLocString, "LocalizedName", new GFFExoLocString(clsGff.GetCExoLocStringNodeValue("LocalizedName")));
          struct5.fields[6] = new GFF_Field(GFFField.GFF_CExoLocString, "Description", new GFFExoLocString(clsGff.GetCExoLocStringNodeValue("Description")));
          struct5.fields[7] = new GFF_Field(GFFField.GFF_CExoLocString, "MapNote", new GFFExoLocString(clsGff.GetCExoLocStringNodeValue("MapNote")));
          struct5.fields[8] = new GFF_Field(GFFField.GFF_CExoString, "Comment", RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("Comment")));
          struct5.fields[9] = new GFF_Field(GFFField.GFF_float, "XPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(x), nudXoff.Value), nudXmul.Value)));
          struct5.fields[10] = new GFF_Field(GFFField.GFF_float, "YPosition", Convert.ToSingle(Decimal.Divide(Decimal.Add(new Decimal(invy(y)), nudYoff.Value), nudYmul.Value)));
          struct5.fields[11] = new GFF_Field(GFFField.GFF_float, "ZPosition", 0.0f);
          struct5.fields[12] = new GFF_Field(GFFField.GFF_float, "XOrientation", 1f);
          struct5.fields[13] = new GFF_Field(GFFField.GFF_float, "YOrientation", 0.0f);
          GITfile.AddListElement("WaypointList", struct5);
          gModuleEditorSettings.FilterShowWaypoints = true;
          break;
      }
      LoadBackground();
      Draw();
      BuildModuleTreeView();
      UpdateVisibilityBtnsWithSettings();
    }

  private void Panel1_DragEnter(object sender, DragEventArgs e)
  {
      if (!e.Data.GetDataPresent(DataFormats.Text))
        return;
      e.Effect = DragDropEffects.Copy;
    }

  private void chkbShowResRefs_CheckedChanged(object sender, EventArgs e)
  {
      g_ShowPaletteResRefs = ((CheckBox) sender).Checked;
      if (StringType.StrCmp(g_CurrentPaletteName, "", false) == 0)
        return;
      BuildPaletteTreeView(g_CurrentPaletteName);
    }

  private void chkbShowNames_CheckedChanged(object sender, EventArgs e)
  {
      g_ShowPaletteNames = ((CheckBox) sender).Checked;
      if (StringType.StrCmp(g_CurrentPaletteName, "", false) == 0)
        return;
      BuildPaletteTreeView(g_CurrentPaletteName);
    }

  private void chkbShowTags_CheckedChanged(object sender, EventArgs e)
  {
      gModuleEditorSettings.ShowTagsOnModulePalette = chkbShowTags.Checked;
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
      LoadBackground();
      Draw();
      BuildModuleTreeView();
    }

  private void miOpenProject_Click(object sender, EventArgs e)
  {
      string str = BrowseForModuleEditorProjectFolder();
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      bModuleLoadedOK = Setup(str);
      if (!bModuleLoadedOK)
      {
        EnableControls(false);
        lbScripts.Items.Clear();
        Text = "Module Editor";
      }
      else
      {
        Draw();
        BuildModuleTreeView();
      }
    }

  private void miShowHideModuleElements_Click(object sender, EventArgs e)
  {
      if (bModElementsVisible)
      {
        pnlModElements.Visible = false;
        checked { Panel1.Width += 194; }
        checked { Panel1.Left -= 194; }
        bModElementsVisible = false;
        miShowHideModuleElements.Checked = false;
      }
      else
      {
        pnlModElements.Visible = true;
        checked { Panel1.Width -= 194; }
        checked { Panel1.Left += 194; }
        bModElementsVisible = true;
        miShowHideModuleElements.Checked = true;
      }
    }

  private void miShowHidePalette_Click(object sender, EventArgs e)
  {
      if (bPaletteVisible)
      {
        pnlPalette.Visible = false;
        checked { Panel1.Width += 240; }
        bPaletteVisible = false;
        miShowHidePalette.Checked = false;
      }
      else
      {
        pnlPalette.Visible = true;
        checked { Panel1.Width -= 240; }
        bPaletteVisible = true;
        miShowHidePalette.Checked = true;
      }
    }

  private void miSave_Click(object sender, EventArgs e)
  {
      GITfile.WriteFile(Path.Combine(g_ProjectPath, g_MapName + ".git"), "GIT");
      AREfile.WriteFile(Path.Combine(g_ProjectPath, g_MapName + ".are"), "ARE");
      IFOfile.WriteFile(Path.Combine(g_ProjectPath, "Module.ifo"), "IFO");
    }

  private void miClose_Click(object sender, EventArgs e) => Close();

  private void miShowModulePaths_Click(object sender, EventArgs e)
  {
      ClsGff clsGff = new ClsGff(new FileStream(g_ProjectPath + "\\" + g_MapName + ".pth", FileMode.Open), KotorVersionIndex);
      int num1 = checked (clsGff.GetListItemCount("Path_Points") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        int int32_1 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("Path_Points(" + StringType.FromInteger(num2) + ").First_Conection")));
        double num3 = DoubleType.FromObject(clsGff.GetNodeValue("Path_Points(" + StringType.FromInteger(num2) + ").X"));
        double num4 = DoubleType.FromObject(clsGff.GetNodeValue("Path_Points(" + StringType.FromInteger(num2) + ").Y"));
        int int32_2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("Path_Points(" + StringType.FromInteger(num2) + ").Conections")));
        int num5 = 1;
        while (num5 <= int32_2)
        {
          int int32_3 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("Path_Conections(" + StringType.FromInteger(int32_1) + ").Destination")));
          double num6 = DoubleType.FromObject(clsGff.GetNodeValue("Path_Points(" + StringType.FromInteger(int32_3) + ").X"));
          double num7 = DoubleType.FromObject(clsGff.GetNodeValue("Path_Points(" + StringType.FromInteger(int32_3) + ").Y"));
          int int32_4 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToDouble(nudXmul.Value) * num3))), nudXoff.Value));
          int num8 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToDouble(nudYmul.Value) * num4))), nudYoff.Value)));
          Draw3x3Box(bmp, int32_4, num8, Color.Fuchsia);
          int int32_5 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToDouble(nudXmul.Value) * num6))), nudXoff.Value));
          int num9 = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToDouble(nudYmul.Value) * num7))), nudYoff.Value)));
          Draw3x3Box(bmp, int32_5, num9, Color.Fuchsia);
          Graphics.FromImage(bmp).DrawLine(new Pen(Color.Orange, 1f), int32_4, num8, int32_5, num9);
          num3 = num6;
          num4 = num7;
          checked { ++int32_1; }
          checked { ++num5; }
        }
        checked { ++num2; }
      }
      Draw();
    }

  private void miOptions_Click(object sender, EventArgs e)
  {
      frmModuleEditorOptions moduleEditorOptions = new frmModuleEditorOptions();
      Options settings = UserSettings.GetSettings();
      moduleEditorOptions.ModuleElementIndicatorSize = dModuleElementIndicatorSize;
      moduleEditorOptions.ConfirmDeletes = bConfirmDeletes;
      moduleEditorOptions.ShowLocatorRay = bShowLocatorRay;
      moduleEditorOptions.ModuleExportPath = gModuleEditorSettings.ModuleEditorModOutputPath;
      int num = (int) moduleEditorOptions.ShowDialog(this);
      if (moduleEditorOptions.DialogResult != DialogResult.OK)
        return;
      dModuleElementIndicatorSize = moduleEditorOptions.ModuleElementIndicatorSize;
      bConfirmDeletes = moduleEditorOptions.ConfirmDeletes;
      bShowLocatorRay = moduleEditorOptions.ShowLocatorRay;
      settings.bModuleEditorShowLocatorRay = bShowLocatorRay;
      settings.bModuleEditorConfirmDeletes = bConfirmDeletes;
      settings.ModuleEditorModuleElementIndicatorSize = dModuleElementIndicatorSize;
      gModuleEditorSettings.ModuleEditorModOutputPath = moduleEditorOptions.ModuleExportPath;
      UserSettings.SaveSettings(settings);
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
    }

  private void miExploreModuleFolder_Click(object sender, EventArgs e) => new Process()
  {
    StartInfo = {
      FileName = "explorer.exe ",
      Arguments = g_ProjectPath
    }
  }.Start();

  private void miBuildModFile_Click(object sender, EventArgs e) => BuildModFile();

  private void miShowGffDump_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = g_MapName;
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      if (sender == miShowAreDump)
      {
        frmTextEditor.tbGeneric.Rtf = new ClsGff(g_ProjectPath + "\\" + g_MapName + ".are", KotorVersionIndex).ToString();
        frmTextEditor.Text += ".are";
      }
      else if (sender == miShowGitDump)
      {
        frmTextEditor.tbGeneric.Rtf = new ClsGff(g_ProjectPath + "\\" + g_MapName + ".git", KotorVersionIndex).ToString();
        frmTextEditor.Text += ".git";
      }
      else
      {
        frmTextEditor.tbGeneric.Rtf = new ClsGff(g_ProjectPath + "\\module.ifo", KotorVersionIndex).ToString();
        frmTextEditor.Text += ".ifo";
      }
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void miModuleProperties_Click(object sender, EventArgs e)
  {
      frmModuleIfo_AreaEditor moduleIfoAreaEditor = new frmModuleIfo_AreaEditor(ref AREfile, ref IFOfile, ref GITfile, KotorVersionIndex);
      if (moduleIfoAreaEditor.ShowDialog(this) != DialogResult.OK)
        return;
      moduleIfoAreaEditor.UpdateFiles();
      if (!moduleIfoAreaEditor.ModEntryChanged)
        return;
      LoadBackground();
      Draw();
    }

  private void miUseSmallMap_Click(object sender, EventArgs e)
  {
      gModuleEditorSettings.MapSize = "small";
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
      miSave_Click(null, null);
      Setup(g_ProjectPath);
      Draw();
      BuildModuleTreeView();
    }

  private void miUseLargeMap_Click(object sender, EventArgs e)
  {
      gModuleEditorSettings.MapSize = "large";
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
      miSave_Click(null, null);
      Setup(g_ProjectPath);
      Draw();
      BuildModuleTreeView();
    }

  private void miUseAltSmallMap_Click(object sender, EventArgs e)
  {
      gModuleEditorSettings.MapSize = "altsmall";
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
      miSave_Click(null, null);
      Setup(g_ProjectPath);
      Draw();
      BuildModuleTreeView();
    }

  private void miShowItemLabels_Click(object sender, EventArgs e)
  {
      gModuleEditorSettings.ShowItemLabels = !gModuleEditorSettings.ShowItemLabels;
      miShowItemLabels.Checked = gModuleEditorSettings.ShowItemLabels;
      LoadBackground();
      Draw();
    }

  private void miShowModuleEntryPoint_Click(object sender, EventArgs e)
  {
      float num1 = SingleType.FromObject(IFOfile.GetNodeValue("Mod_Entry_X"));
      float num2 = SingleType.FromObject(IFOfile.GetNodeValue("Mod_Entry_Y"));
      int int32 = Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudXmul.Value) * num1))), nudXoff.Value));
      int y = invy(Convert.ToInt32(Decimal.Subtract(new Decimal(checked ((int) Math.Round(Convert.ToSingle(nudYmul.Value) * num2))), nudYoff.Value)));
      IndicateModItem(Graphics.FromImage(bmp), int32, y);
    }

  private void ToolBarModElementsFilter_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
  {
      gModuleEditorSettings.FilterShowCreatures = tbarbtnCreature.Pushed;
      gModuleEditorSettings.FilterShowDoors = tbarbtnDoor.Pushed;
      gModuleEditorSettings.FilterShowEncounters = tbarbtnEncounter.Pushed;
      gModuleEditorSettings.FilterShowMerchants = tbarbtnMerchant.Pushed;
      gModuleEditorSettings.FilterShowPlaceables = tbarbtnPlaceable.Pushed;
      gModuleEditorSettings.FilterShowSounds = tbarbtnSound.Pushed;
      gModuleEditorSettings.FilterShowTriggers = tbarbtnTrigger.Pushed;
      gModuleEditorSettings.FilterShowWaypoints = tbarbtnWaypoint.Pushed;
      ModuleEditorProjectSettings.SaveSettings(gModuleEditorSettings, g_ProjectPath);
      LoadBackground();
      Draw();
      BuildModuleTreeView();
    }

  public void BuildModuleTreeView()
  {
      tvModule.Nodes.Clear();
      long ticks = DateAndTime.Now.Ticks;
      AddTvModuleNodes("Creatures", CreatureArr, 8, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Doors", DoorArr, 3, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Encounters", EncounterArr, 10, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Items", ItemArr);
      AddTvModuleNodes("Merchants", MerchantArr, 7, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Placeables", PlaceableArr, 4, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Sounds", SoundArr, 6, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Triggers", TriggerArr, 5, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Waypoints", WaypointArr, 11, gModuleEditorSettings.ShowTagsOnModulePalette);
      AddTvModuleNodes("Cameras", CameraArr, 9);
      Console.WriteLine("BuildModuleTreeView Time: " + StringType.FromDouble(new TimeSpan(checked (DateAndTime.Now.Ticks - ticks)).TotalMilliseconds));
      Console.WriteLine(StringType.FromInteger(tb) + " " + StringType.FromInteger(lcl));
      tb = 0;
      lcl = 0;
      try
      {
        foreach (object moduleTreeOpenPath in g_tvModule_TreeOpenPaths)
          FrmMain.OpenTreeViewToPath(StringType.FromObject(moduleTreeOpenPath), tvModule.Nodes[0], 0, false);
      }
      finally
      {
        
      }
    }

  private void AddTvModuleNodes(
    string parentLabel,
    ModItem[] ModItemArr,
    int imageIndex = -1,
    bool ShowTags = false)
  {
      ModItemTvNode node1 = new ModItemTvNode(parentLabel);
      node1.ImageIndex = imageIndex;
      node1.SelectedImageIndex = imageIndex;
      tvModule.Nodes.Add(node1);
      if (ModItemArr == null)
        return;
      ModItem[] modItemArray = ModItemArr;
      int index = 0;
      ModItem modItem = null;
      while (index < modItemArray.Length)
      {
        modItem = modItemArray[index];
        int num = 0;
        if (modItem != null)
        {
          ModItemTvNode node2;
          if (ShowTags)
          {
            if (StringType.StrCmp(modItem.Tag, "", false) != 0)
            {
              node2 = new ModItemTvNode(modItem.Tag);
            }
            else
            {
              string modItemTag = GetModItemTag(modItem.FileName);
              node2 = modItemTag != null ? (StringType.StrCmp(modItemTag, "", false) != 0 ? new ModItemTvNode(modItemTag) : new ModItemTvNode(modItem.ResRef + " (missing tag)")) : new ModItemTvNode(modItem.ResRef + " (missing file)");
            }
          }
          else
            node2 = new ModItemTvNode(modItem.ResRef);
          node2.ArrayIndex = num;
          node2.ItemType = modItem.ItemType;
          node2.Tag = "Item";
          node1.Nodes.Add(node2);
        }
        checked { ++num; }
        checked { ++index; }
      }
      if (modItem == null)
        return;
      node1.ItemType = modItem.ItemType;
      node1.Tag = "ItemParent";
    }

  private string GetModItemTag(string FileName)
  {
      if (File.Exists(g_ProjectPath + "\\" + FileName))
      {
        checked { ++lcl; }
        FileStream input = File.OpenRead(g_ProjectPath + "\\" + FileName);
        BinaryReader binaryReader = new BinaryReader(input, Encoding.ASCII);
        byte[] data = binaryReader.ReadBytes(checked ((int) input.Length));
        binaryReader.Close();
        return FrmMain.GetGffTag(data);
      }
      if (KotorVersionIndex == 0)
      {
        if (htK1Tags.ContainsKey(FileName))
        {
          checked { ++tb; }
          return StringType.FromObject(htK1Tags[FileName]);
        }
      }
      else if (KotorVersionIndex == 1 && htK2Tags.ContainsKey(FileName))
      {
        checked { ++tb; }
        return StringType.FromObject(htK2Tags[FileName]);
      }
      string modItemTag = null;
      return modItemTag;
    }

  public void BuildPaletteTreeView(string paletteName)
  {
      if (!(g_ShowPaletteNames | g_ShowPaletteResRefs))
        return;
      FrmMain frmMain = new FrmMain();
      int resIdForResRef = FrmMain.KxChitinKey(KotorVersionIndex).FindResIdForResRef(paletteName, 2030);
      string biffPath = CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + FrmMain.KxChitinKey(KotorVersionIndex).BiffList[resIdForResRef >> 20].Filename;
      ClsGff clsGff = new ClsGff(frmMain.GetBiffResource(biffPath, checked (resIdForResRef - resIdForResRef >> 20 << 20)).Data, KotorVersionIndex);
      g_CurrentPaletteName = paletteName;
      tvPalette.Nodes.Clear();
      int num1 = checked (clsGff.GetListItemCount("MAIN") - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        tvPalette.Nodes.Add(StringType.FromObject(clsGff.GetNodeValue("MAIN(" + StringType.FromInteger(index1) + ").DELETE_ME")));
        int num2 = checked (clsGff.GetListItemCount("MAIN(" + StringType.FromInteger(index1) + ").LIST") - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          object objectValue1 = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("MAIN(" + StringType.FromInteger(index1) + ").LIST(" + StringType.FromInteger(index2) + ").DELETE_ME"));
          if (objectValue1 != null)
          {
            TreeNodeCollection nodes = tvPalette.Nodes[index1].Nodes;
            object[] objArray = new object[1]
            {
              RuntimeHelpers.GetObjectValue(objectValue1)
            };
            object[] args = objArray;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            LateBinding.LateCall(nodes, null, "Add", args, null, CopyBack);
            if (flagArray[0])
              objectValue1 = RuntimeHelpers.GetObjectValue(objArray[0]);
            int num3 = checked (clsGff.GetListItemCount("MAIN(" + StringType.FromInteger(index1) + ").LIST(" + StringType.FromInteger(index2) + ").LIST") - 1);
            int num4 = 0;
            while (num4 <= num3)
            {
              string str = "";
              if (g_ShowPaletteNames)
              {
                objectValue1 = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("MAIN(" + StringType.FromInteger(index1) + ").LIST(" + StringType.FromInteger(index2) + ").LIST(" + StringType.FromInteger(num4) + ").NAME"));
                str = StringType.FromObject(objectValue1);
              }
              object objectValue2 = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("MAIN(" + StringType.FromInteger(index1) + ").LIST(" + StringType.FromInteger(index2) + ").LIST(" + StringType.FromInteger(num4) + ").RESREF"));
              if (g_ShowPaletteResRefs)
              {
                if (g_ShowPaletteNames)
                  str += " (";
                str = StringType.FromObject(ObjectType.StrCatObj(str, objectValue2));
                if (g_ShowPaletteNames)
                  str += ")";
              }
              tvPalette.Nodes[index1].Nodes[index2].Nodes.Add(new TreeNode(str)
              {
                Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("itemtype=" + StringType.FromInteger(g_CurrentPaletteModItemType) + "|name=", objectValue1), "|resref="), objectValue2)
              });
              checked { ++num4; }
            }
          }
          else
          {
            string str = "";
            if (g_ShowPaletteNames)
            {
              objectValue1 = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("MAIN(" + StringType.FromInteger(index1) + ").LIST(" + StringType.FromInteger(index2) + ").NAME"));
              str = StringType.FromObject(objectValue1);
            }
            object objectValue3 = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("MAIN(" + StringType.FromInteger(index1) + ").LIST(" + StringType.FromInteger(index2) + ").RESREF"));
            if (g_ShowPaletteResRefs)
            {
              if (g_ShowPaletteNames)
                str += " (";
              str = StringType.FromObject(ObjectType.StrCatObj(str, objectValue3));
              if (g_ShowPaletteNames)
                str += ")";
            }
            tvPalette.Nodes[index1].Nodes.Add(new TreeNode(str)
            {
              Tag = ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("itemtype=" + StringType.FromInteger(g_CurrentPaletteModItemType) + "|name=", objectValue1), "|resref="), objectValue3)
            });
          }
          checked { ++index2; }
        }
        checked { ++index1; }
      }
      int num5 = checked (tvPalette.Nodes.Count - 1);
      int index3 = 0;
      while (index3 <= num5)
      {
        if (StringType.StrCmp(Strings.Mid(tvPalette.Nodes[index3].Text, 1, 6), "ASSIGN", false) == 0)
        {
          tvPalette.Nodes.RemoveAt(index3);
          break;
        }
        checked { ++index3; }
      }
    }

  private void BuildUserPaletteTreeView()
  {
      if (!Directory.Exists(g_ProjectPath + "\\userpalette"))
      {
        Directory.CreateDirectory(g_ProjectPath + "\\userpalette");
      }
      else
      {
        DirectoryInfo dir1 = new DirectoryInfo(g_ProjectPath + "\\userpalette");
        DirectoryInfo dir2 = new DirectoryInfo(FrmMain.GRootPath + "\\Global Templates\\k" + StringType.FromInteger(checked (KotorVersionIndex + 1)));
        tvUserPalette.Nodes[0].Nodes.Clear();
        tvUserPalette.Nodes[1].Nodes.Clear();
        tvUserPalette.Nodes[2].Nodes.Clear();
        tvUserPalette.Nodes[3].Nodes.Clear();
        tvUserPalette.Nodes[4].Nodes.Clear();
        tvUserPalette.Nodes[5].Nodes.Clear();
        tvUserPalette.Nodes[6].Nodes.Clear();
        BuildUserPaletteTreeNodes(dir2, "utc", tvUserPalette.Nodes[0], "gt");
        BuildUserPaletteTreeNodes(dir1, "utc", tvUserPalette.Nodes[0], "up");
        BuildUserPaletteTreeNodes(dir2, "utd", tvUserPalette.Nodes[1], "gt");
        BuildUserPaletteTreeNodes(dir1, "utd", tvUserPalette.Nodes[1], "up");
        BuildUserPaletteTreeNodes(dir2, "ute", tvUserPalette.Nodes[2], "gt");
        BuildUserPaletteTreeNodes(dir1, "ute", tvUserPalette.Nodes[2], "up");
        BuildUserPaletteTreeNodes(dir2, "utm", tvUserPalette.Nodes[3], "gt");
        BuildUserPaletteTreeNodes(dir1, "utm", tvUserPalette.Nodes[3], "up");
        BuildUserPaletteTreeNodes(dir2, "utp", tvUserPalette.Nodes[4], "gt");
        BuildUserPaletteTreeNodes(dir1, "utp", tvUserPalette.Nodes[4], "up");
        BuildUserPaletteTreeNodes(dir2, "uts", tvUserPalette.Nodes[5], "gt");
        BuildUserPaletteTreeNodes(dir1, "uts", tvUserPalette.Nodes[5], "up");
        BuildUserPaletteTreeNodes(dir2, "utt", tvUserPalette.Nodes[6], "gt");
        BuildUserPaletteTreeNodes(dir1, "utt", tvUserPalette.Nodes[6], "up");
      }
    }

  private void BuildUserPaletteTreeNodes(
    DirectoryInfo dir,
    string fileext,
    TreeNode nodeparent,
    string source)
  {
      FileInfo[] files = dir.GetFiles("*." + fileext);
      int index = 0;
      while (index < files.Length)
      {
        FileInfo fileInfo = files[index];
        TreeNode node = new TreeNode()
        {
          Text = fileInfo.Name.Replace(fileInfo.Extension, "")
        };
        node.Tag = "itemtype=" + StringType.FromInteger(FrmMain.GetIdForRsrcType(fileext.ToLower())) + "|name=" + node.Text + "|resref=" + node.Text + "|" + source;
        nodeparent.Nodes.Add(node);
        checked { ++index; }
      }
    }

  private void DeleteModuleItem(ModItem ModuleItem)
  {
      if (ModuleItem.ItemType != 12040)
      {
        string[] strArray = Strings.Split(Strings.Replace(ModuleItem.Path, ")", ""), "(");
        GITfile.DeleteListElement(strArray[0], IntegerType.FromString(strArray[1]));
      }
      else
      {
        string[] strArray = Strings.Split(Strings.Replace(Strings.Replace(ModuleItem.Path, "(", "."), ")", ""), ".");
        GITfile.DeleteListElement(strArray[0] + "." + strArray[1] + "." + strArray[2], IntegerType.FromString(strArray[3]));
      }
      LoadBackground();
      Draw();
      BuildModuleTreeView();
      if (ModuleItem.ItemType == 12040)
        return;
      string fileName = ModuleItem.FileName;
      if (!Directory.Exists(g_ProjectPath + "\\recycle"))
        Directory.CreateDirectory(g_ProjectPath + "\\recycle");
      if (!File.Exists(g_ProjectPath + "\\" + fileName))
        return;
      bool flag = false;
      string extension = Path.GetExtension(fileName);
      ModItem[] modItemArray = new ModItem[] { };
      if (StringType.StrCmp(extension, ".utc", false) == 0)
        modItemArray = CreatureArr;
      else if (StringType.StrCmp(extension, ".utd", false) == 0)
        modItemArray = DoorArr;
      else if (StringType.StrCmp(extension, ".uti", false) == 0)
        modItemArray = ItemArr;
      else if (StringType.StrCmp(extension, ".utm", false) == 0)
        modItemArray = MerchantArr;
      else if (StringType.StrCmp(extension, ".utp", false) == 0)
        modItemArray = PlaceableArr;
      else if (StringType.StrCmp(extension, ".utt", false) == 0)
        modItemArray = TriggerArr;
      else if (StringType.StrCmp(extension, ".uts", false) == 0)
        modItemArray = SoundArr;
      else if (StringType.StrCmp(extension, ".utw", false) == 0)
        modItemArray = WaypointArr;
      else if (StringType.StrCmp(extension, ".ute", false) == 0)
        modItemArray = EncounterArr;
      if (modItemArray != null)
      {
        int upperBound = modItemArray.GetUpperBound(0);
        int index = 0;
        while (index <= upperBound)
        {
          if (StringType.StrCmp(modItemArray[index].FileName.ToLower(), fileName.ToLower(), false) == 0)
          {
            flag = true;
            break;
          }
          checked { ++index; }
        }
      }
      if (flag)
        return;
      File.Move(g_ProjectPath + "\\" + fileName, g_ProjectPath + "\\recycle\\" + StringType.FromInteger(DateAndTime.Now.Minute) + StringType.FromInteger(DateAndTime.Now.Second) + fileName);
    }

  private void EnableControls(bool state)
  {
      Panel1.Enabled = state;
      pbox.Visible = state;
      tabctrlModule.Enabled = state;
      tabctrlPalette.Enabled = state;
      miSave.Enabled = state;
      miBuildModFile.Enabled = state;
      miExploreModuleFolder.Enabled = state;
      miModuleProperties.Enabled = state;
      miShowHideModuleElements.Enabled = state;
      miShowHidePalette.Enabled = state;
      miShowItemLabels.Enabled = state;
      miUseSmallMap.Enabled = state & g_SmallMapAvailable;
      miUseLargeMap.Enabled = state & g_LargeMapAvailable;
      miShowModuleEntryPoint.Enabled = state;
      miShowModulePaths.Enabled = state;
      miShowAreDump.Enabled = state;
      miShowGitDump.Enabled = state;
      miShowIfoDump.Enabled = state;
      miOptions.Enabled = state;
      ToolBarModElementsFilter.Enabled = state;
      chkbShowTags.Enabled = state;
    }

  private void BuildModuleFileList(
    ModItem[] items,
    ref ArrayList list,
    ref int refcount,
    ref int instcount)
  {
      if (items == null)
        return;
      ModItem[] modItemArray = items;
      int index = 0;
      while (index < modItemArray.Length)
      {
        ModItem modItem = modItemArray[index];
        string str = modItem.ResRef + "." + ResourceIdentification.FindResourceTypeForId(modItem.ItemType);
        string path1 = g_ProjectPath + "\\" + str;
        if (File.Exists(path1))
        {
          if (!list.Contains(path1))
          {
            list.Add(path1);
            checked { ++instcount; }
          }
        }
        else
        {
          string path2 = g_UserPalettePath + "\\" + str;
          if (File.Exists(path2))
          {
            if (!list.Contains(path2))
            {
              list.Add(path2);
              checked { ++instcount; }
            }
          }
          else
          {
            string path3 = g_GlobalTemplatesPath + "\\" + str;
            if (File.Exists(path3))
            {
              if (!list.Contains(path3))
              {
                list.Add(path3);
                checked { ++instcount; }
              }
            }
            else
              checked { ++refcount; }
          }
        }
        checked { ++index; }
      }
    }

  private void AddModuleFileNamesToList(string path, ref ArrayList list, string wildcard)
  {
      string[] files = Directory.GetFiles(path, wildcard);
      if (files.Length <= 0)
        return;
      string[] strArray = files;
      int index = 0;
      while (index < strArray.Length)
      {
        string str = strArray[index];
        list.Add(str);
        checked { ++index; }
      }
    }

  private string BrowseForModuleEditorProjectFolder()
  {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Select a Module Project folder:";
      CurrentSettings = UserSettings.GetSettings();
      if (CurrentSettings.LastModuleEditedPath != null)
        folderBrowserDialog.SelectedPath = CurrentSettings.LastModuleEditedPath;
      folderBrowserDialog.ShowNewFolderButton = false;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
      {
        string str = null;
        return str;
      }
      CurrentSettings.LastModuleEditedPath = folderBrowserDialog.SelectedPath;
      UserSettings.SaveSettings(CurrentSettings);
      return folderBrowserDialog.SelectedPath;
    }

  private void AddNodeChildrenToTreePaths(ModItemTvNode node, ArrayList arTreeOpenPaths)
  {
      try
      {
        foreach (ModItemTvNode node1 in node.Nodes)
        {
          if (node1.IsExpanded)
          {
            if (!arTreeOpenPaths.Contains(node1.FullPath))
              arTreeOpenPaths.Add(node1.FullPath);
            AddNodeChildrenToTreePaths(node1, arTreeOpenPaths);
          }
        }
      }
      finally
      {
        
      }
    }

  private void UpdateAfterTweakBtn()
  {
      IndicatedModItem.X = SingleType.FromObject(GITfile.GetNodeValue(IndicatedModItem.XPosPath));
      IndicatedModItem.Y = SingleType.FromObject(GITfile.GetNodeValue(IndicatedModItem.YPosPath));
      sbarpnlLocX.Text = StringType.FromSingle(Convert.ToSingle(IndicatedModItem.X));
      sbarpnlLocY.Text = StringType.FromSingle(Convert.ToSingle(IndicatedModItem.Y));
      LoadBackground();
      Draw();
    }

  private void lbScripts_DoubleClick(object sender, EventArgs e)
  {
      if (lbScripts.SelectedIndex == -1)
        return;
      new frmTextEditor(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(g_ProjectPath + "\\", lbScripts.SelectedItem), ".nss")), KotorVersionIndex, true)
      {
        Filename = StringType.FromObject(ObjectType.StrCatObj(lbScripts.SelectedItem, ".nss")),
        DirectEdit = true
      }.Show();
    }

  private void SetEditorCaption()
  {
      Text = "Module Editor - " + g_MapName + " (K" + StringType.FromInteger(checked (KotorVersionIndex + 1)) + ") - ";
      if (StringType.StrCmp(gModuleEditorSettings.ModuleEditorModOutputPath, "", false) == 0)
        Text += "(No module output path set)";
      else
        Text += gModuleEditorSettings.ModuleEditorModOutputPath;
    }

  private void lbDialogs_DoubleClick(object sender, EventArgs e)
  {
      Cursor current = Cursor.Current;
      Cursor.Current = Cursors.WaitCursor;
      new frmDialogEditor(g_ProjectPath + "\\" + lbDialogs.SelectedItem.ToString() + ".dlg", KotorVersionIndex).Show();
      Cursor.Current = current;
    }

  private void chkbFine_CheckedChanged(object sender, EventArgs e)
  {
      if (chkbFine.Checked)
      {
        nudXmul.DecimalPlaces = 4;
        nudYmul.DecimalPlaces = 4;
      }
      else
      {
        nudXmul.DecimalPlaces = 2;
        nudYmul.DecimalPlaces = 2;
      }
    }

  private void btnAssignPt1_Click(object sender, EventArgs e)
  {
      MapCalibratePt1 = new Point(Convert.ToInt32(tbMouseX.Text), Convert.ToInt32(tbMouseY.Text));
      if (MapCalibratePt2.IsEmpty)
        return;
      btnCalcCalibrationVals.Enabled = true;
    }

  private void btnAssignPt2_Click(object sender, EventArgs e)
  {
      MapCalibratePt2 = new Point(Convert.ToInt32(tbMouseX.Text), Convert.ToInt32(tbMouseY.Text));
      if (MapCalibratePt1.IsEmpty)
        return;
      btnCalcCalibrationVals.Enabled = true;
    }

  private void btnCalcCalibrationVals_Click(object sender, EventArgs e)
  {
      chkbUseFactors.Checked = false;
      nudXmul.Value = new Decimal(checked (MapCalibratePt2.X - MapCalibratePt1.X) / (Convert.ToSingle(tb3dsMaxPt2X.Text) - Convert.ToSingle(tb3dsMaxPt1X.Text)));
      nudXoff.Value = new Decimal((float) -(MapCalibratePt1.X - Convert.ToSingle(nudXmul.Value) * (double) Convert.ToSingle(tb3dsMaxPt1X.Text)));
      nudYmul.Value = new Decimal(checked (-MapCalibratePt2.Y - MapCalibratePt1.Y) / (Convert.ToSingle(tb3dsMaxPt2Y.Text) - Convert.ToSingle(tb3dsMaxPt1Y.Text)));
      nudYoff.Value = new Decimal((float) -(g_imageYsize - (MapCalibratePt1.Y + Convert.ToSingle(nudYmul.Value) * (double) Convert.ToSingle(tb3dsMaxPt1Y.Text))));
      chkbUseFactors.Checked = true;
      LoadBackground();
      Draw();
    }

  private void btnCalToolsToggle_MouseDown(object sender, MouseEventArgs e)
  {
      if ((ModifierKeys & (Keys.Shift | Keys.Control | Keys.Alt)) == 0 || (MouseButtons & MouseButtons.XButton2) == 0)
        return;
      CalibrationToolsVis = !CalibrationToolsVis;
      nudXmul.Visible = CalibrationToolsVis;
      nudYmul.Visible = CalibrationToolsVis;
      nudXoff.Visible = CalibrationToolsVis;
      nudYoff.Visible = CalibrationToolsVis;
      chkbUseFactors.Visible = CalibrationToolsVis;
      btnLogFactors.Visible = CalibrationToolsVis;
      btnAssignPt1.Visible = CalibrationToolsVis;
      btnAssignPt2.Visible = CalibrationToolsVis;
      btnAssignPt2.Visible = CalibrationToolsVis;
      btnCalcCalibrationVals.Visible = CalibrationToolsVis;
      tbMouseX.Visible = CalibrationToolsVis;
      tbMouseY.Visible = CalibrationToolsVis;
      tb3dsMaxPt1X.Visible = CalibrationToolsVis;
      tb3dsMaxPt2X.Visible = CalibrationToolsVis;
      tb3dsMaxPt1Y.Visible = CalibrationToolsVis;
      tb3dsMaxPt2Y.Visible = CalibrationToolsVis;
    }

  private void miFont_Click(object sender, EventArgs e)
  {
      FontDialog fontDialog = new FontDialog();
      fontDialog.ShowColor = true;
      fontDialog.Font = labelFont;
      fontDialog.Color = labelBrush.Color;
      fontDialog.ShowApply = false;
      if (fontDialog.ShowDialog() != DialogResult.OK)
        return;
      labelFont = fontDialog.Font;
      labelBrush.Color = fontDialog.Color;
      LoadBackground();
      Draw();
    }

  private bool IsFileInTrash(string filename)
  {
      bool flag = false;
      return flag;
    }
}