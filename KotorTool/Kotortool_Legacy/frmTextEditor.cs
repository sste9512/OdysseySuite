// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmTextEditor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmTextEditor : Form
{
  [AccessedThroughProperty("ToolStripMenuItem3")]
  private ToolStripMenuItem _ToolStripMenuItem3;
  [AccessedThroughProperty("miSelectAll")]
  private ToolStripMenuItem _miSelectAll;
  [AccessedThroughProperty("ToolStripMenuItem6")]
  private ToolStripMenuItem _ToolStripMenuItem6;
  [AccessedThroughProperty("ToolStripMenuItem4")]
  private ToolStripMenuItem _ToolStripMenuItem4;
  [AccessedThroughProperty("ToolStripMenuItem2")]
  private ToolStripMenuItem _ToolStripMenuItem2;
  [AccessedThroughProperty("miQuit")]
  private ToolStripMenuItem _miQuit;
  [AccessedThroughProperty("ToolStripMenuItem5")]
  private ToolStripMenuItem _ToolStripMenuItem5;
  [AccessedThroughProperty("tbGeneric")]
  private LinenumberTextBox _tbGeneric;
  [AccessedThroughProperty("miPlaceablesList")]
  private ToolStripMenuItem _miPlaceablesList;
  [AccessedThroughProperty("ToolStripMenuItem9")]
  private ToolStripMenuItem _ToolStripMenuItem9;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("miEncountersList")]
  private ToolStripMenuItem _miEncountersList;
  [AccessedThroughProperty("ToolStripMenuItem8")]
  private ToolStripMenuItem _ToolStripMenuItem8;
  [AccessedThroughProperty("cmiShowDefinition")]
  private ToolStripMenuItem _cmiShowDefinition;
  [AccessedThroughProperty("miFind")]
  private ToolStripMenuItem _miFind;
  [AccessedThroughProperty("MainMenu1")]
  private MainMenu _MainMenu1;
  [AccessedThroughProperty("miTriggersList")]
  private ToolStripMenuItem _miTriggersList;
  [AccessedThroughProperty("miFont")]
  private ToolStripMenuItem _miFont;
  [AccessedThroughProperty("miFindAgain")]
  private ToolStripMenuItem _miFindAgain;
  [AccessedThroughProperty("cmText")]
  private ContextMenu _cmText;
  [AccessedThroughProperty("miSaveAs")]
  private ToolStripMenuItem _miSaveAs;
  [AccessedThroughProperty("miWordWrap")]
  private ToolStripMenuItem _miWordWrap;
  [AccessedThroughProperty("lblMatches")]
  private Label _lblMatches;
  [AccessedThroughProperty("miUndo")]
  private ToolStripMenuItem _miUndo;
  [AccessedThroughProperty("pnlFunctions")]
  private Panel _pnlFunctions;
  [AccessedThroughProperty("tbFuncDecl")]
  private TextBox _tbFuncDecl;
  [AccessedThroughProperty("tbFuncNameFilter")]
  private TextBox _tbFuncNameFilter;
  [AccessedThroughProperty("lbFunctions")]
  private ListBox _lbFunctions;
  [AccessedThroughProperty("miCompile")]
  private ToolStripMenuItem _miCompile;
  [AccessedThroughProperty("miOpen")]
  private ToolStripMenuItem _miOpen;
  [AccessedThroughProperty("miWaypointsList")]
  private ToolStripMenuItem _miWaypointsList;
  [AccessedThroughProperty("miScriptIsK2")]
  private ToolStripMenuItem _miScriptIsK2;
  [AccessedThroughProperty("miScriptIsK1")]
  private ToolStripMenuItem _miScriptIsK1;
  [AccessedThroughProperty("miRedo")]
  private ToolStripMenuItem _miRedo;
  [AccessedThroughProperty("miPageSetup")]
  private ToolStripMenuItem _miPageSetup;
  [AccessedThroughProperty("miMerchantList")]
  private ToolStripMenuItem _miMerchantList;
  [AccessedThroughProperty("miCut")]
  private ToolStripMenuItem _miCut;
  [AccessedThroughProperty("miDoorsList")]
  private ToolStripMenuItem _miDoorsList;
  [AccessedThroughProperty("miPrint")]
  private ToolStripMenuItem _miPrint;
  [AccessedThroughProperty("ToolStripMenuItem12")]
  private ToolStripMenuItem _ToolStripMenuItem12;
  [AccessedThroughProperty("miCopy")]
  private ToolStripMenuItem _miCopy;
  [AccessedThroughProperty("miSave")]
  private ToolStripMenuItem _miSave;
  [AccessedThroughProperty("miCreatureList")]
  private ToolStripMenuItem _miCreatureList;
  [AccessedThroughProperty("miCameras")]
  private ToolStripMenuItem _miCameras;
  [AccessedThroughProperty("ToolStripMenuItem7")]
  private ToolStripMenuItem _ToolStripMenuItem7;
  [AccessedThroughProperty("miPaste")]
  private ToolStripMenuItem _miPaste;
  [AccessedThroughProperty("miSoundsList")]
  private ToolStripMenuItem _miSoundsList;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  private IContainer components;
  private Options CurrentSettings;
  private string fname;
  private bool m_rtfMode;
  private int g_findPos;
  private string g_findString;
  private bool g_searchup;
  private bool g_matchcase;
  private bool g_matchwholeword;
  private RichTextBoxFinds g_searchoptions;
  private PageSettings storedPageSettings;
  private StringReader streamToPrint;
  private Font printFont;
  private int _KotorVersionIndex;
  private bool _IsDirectEdit;
  private string _EditingFilePath;
  private func[] funcs;

  public frmTextEditor()
  {
      Load += new EventHandler(frmTextEditor_Load);
      Closing += new CancelEventHandler(frmTextEditor_Closing);
      g_findPos = 0;
      storedPageSettings = null;
      funcs = new func[877];
      InitializeComponent();
      miWordWrap.Checked = FrmMain.CurrentSettings.bTextEditorWordWrap;
      tbGeneric.WordWrap = miWordWrap.Checked;
      CurrentSettings = UserSettings.GetSettings();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual LinenumberTextBox tbGeneric
  {
    get => _tbGeneric;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbGeneric != null)
        {
          _tbGeneric.MouseDown -= new MouseEventHandler(tbGeneric_MouseDown);
          _tbGeneric.LostFocus -= new EventHandler(tbGeneric_LostFocus);
          _tbGeneric.GotFocus -= new EventHandler(tbGeneric_GotFocus);
          _tbGeneric.MouseMove -= new MouseEventHandler(tbGeneric_MouseMove);
        }
        _tbGeneric = value;
        if (_tbGeneric == null)
          return;
        _tbGeneric.MouseDown += new MouseEventHandler(tbGeneric_MouseDown);
        _tbGeneric.LostFocus += new EventHandler(tbGeneric_LostFocus);
        _tbGeneric.GotFocus += new EventHandler(tbGeneric_GotFocus);
        _tbGeneric.MouseMove += new MouseEventHandler(tbGeneric_MouseMove);
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem1 == null)
          ;
        _ToolStripMenuItem1 = value;
        if (_ToolStripMenuItem1 == null)
          ;
      }
    get => _ToolStripMenuItem1;
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

  internal virtual ToolStripMenuItem miFind
  {
    get => _miFind;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miFind != null)
          _miFind.Click -= new EventHandler(miFind_Click);
        _miFind = value;
        if (_miFind == null)
          return;
        _miFind.Click += new EventHandler(miFind_Click);
      }
  }

  internal virtual ToolStripMenuItem miFindAgain
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miFindAgain != null)
          _miFindAgain.Click -= new EventHandler(miFindAgain_Click);
        _miFindAgain = value;
        if (_miFindAgain == null)
          return;
        _miFindAgain.Click += new EventHandler(miFindAgain_Click);
      }
    get => _miFindAgain;
  }

  internal virtual ToolStripMenuItem miUndo
  {
    get => _miUndo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miUndo != null)
          _miUndo.Click -= new EventHandler(miUndo_Click);
        _miUndo = value;
        if (_miUndo == null)
          return;
        _miUndo.Click += new EventHandler(miUndo_Click);
      }
  }

  internal virtual ToolStripMenuItem miRedo
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miRedo != null)
          _miRedo.Click -= new EventHandler(miRedo_Click);
        _miRedo = value;
        if (_miRedo == null)
          return;
        _miRedo.Click += new EventHandler(miRedo_Click);
      }
    get => _miRedo;
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

  internal virtual ToolStripMenuItem miCut
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCut != null)
          _miCut.Click -= new EventHandler(miCut_Click);
        _miCut = value;
        if (_miCut == null)
          return;
        _miCut.Click += new EventHandler(miCut_Click);
      }
    get => _miCut;
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

  internal virtual ToolStripMenuItem ToolStripMenuItem9
  {
    get => _ToolStripMenuItem9;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem9 == null)
          ;
        _ToolStripMenuItem9 = value;
        if (_ToolStripMenuItem9 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miCopy
  {
    get => _miCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCopy != null)
          _miCopy.Click -= new EventHandler(miCopy_Click);
        _miCopy = value;
        if (_miCopy == null)
          return;
        _miCopy.Click += new EventHandler(miCopy_Click);
      }
  }

  internal virtual ToolStripMenuItem miPaste
  {
    get => _miPaste;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miPaste != null)
          _miPaste.Click -= new EventHandler(miPaste_Click);
        _miPaste = value;
        if (_miPaste == null)
          return;
        _miPaste.Click += new EventHandler(miPaste_Click);
      }
  }

  internal virtual ToolStripMenuItem miSelectAll
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSelectAll != null)
          _miSelectAll.Click -= new EventHandler(miSelectAll_Click);
        _miSelectAll = value;
        if (_miSelectAll == null)
          return;
        _miSelectAll.Click += new EventHandler(miSelectAll_Click);
      }
    get => _miSelectAll;
  }

  internal virtual ToolStripMenuItem miSaveAs
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSaveAs != null)
          _miSaveAs.Click -= new EventHandler(miSaveAs_Click);
        _miSaveAs = value;
        if (_miSaveAs == null)
          return;
        _miSaveAs.Click += new EventHandler(miSaveAs_Click);
      }
    get => _miSaveAs;
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

  internal virtual ToolStripMenuItem miOpen
  {
    get => _miOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miOpen != null)
          _miOpen.Click -= new EventHandler(miOpen_Click);
        _miOpen = value;
        if (_miOpen == null)
          return;
        _miOpen.Click += new EventHandler(miOpen_Click);
      }
  }

  internal virtual ToolStripMenuItem miPrint
  {
    get => _miPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miPrint != null)
          _miPrint.Click -= new EventHandler(miPrint_Click);
        _miPrint = value;
        if (_miPrint == null)
          return;
        _miPrint.Click += new EventHandler(miPrint_Click);
      }
  }

  internal virtual ToolStripMenuItem miPageSetup
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miPageSetup != null)
          _miPageSetup.Click -= new EventHandler(miPageSetup_Click);
        _miPageSetup = value;
        if (_miPageSetup == null)
          return;
        _miPageSetup.Click += new EventHandler(miPageSetup_Click);
      }
    get => _miPageSetup;
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

  internal virtual ToolStripMenuItem miWordWrap
  {
    get => _miWordWrap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miWordWrap != null)
          _miWordWrap.Click -= new EventHandler(miWordWrap_Click);
        _miWordWrap = value;
        if (_miWordWrap == null)
          return;
        _miWordWrap.Click += new EventHandler(miWordWrap_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem6 == null)
          ;
        _ToolStripMenuItem6 = value;
        if (_ToolStripMenuItem6 == null)
          ;
      }
    get => _ToolStripMenuItem6;
  }

  internal virtual ToolStripMenuItem miPlaceablesList
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miPlaceablesList != null)
          _miPlaceablesList.Click -= new EventHandler(miPlaceablesList_Click);
        _miPlaceablesList = value;
        if (_miPlaceablesList == null)
          return;
        _miPlaceablesList.Click += new EventHandler(miPlaceablesList_Click);
      }
    get => _miPlaceablesList;
  }

  internal virtual ToolStripMenuItem miEncountersList
  {
    get => _miEncountersList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miEncountersList != null)
          _miEncountersList.Click -= new EventHandler(miEncountersList_Click);
        _miEncountersList = value;
        if (_miEncountersList == null)
          return;
        _miEncountersList.Click += new EventHandler(miEncountersList_Click);
      }
  }

  internal virtual ToolStripMenuItem miWaypointsList
  {
    get => _miWaypointsList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miWaypointsList != null)
          _miWaypointsList.Click -= new EventHandler(miWaypointsList_Click);
        _miWaypointsList = value;
        if (_miWaypointsList == null)
          return;
        _miWaypointsList.Click += new EventHandler(miWaypointsList_Click);
      }
  }

  internal virtual ToolStripMenuItem miSoundsList
  {
    get => _miSoundsList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSoundsList != null)
          _miSoundsList.Click -= new EventHandler(miSoundsList_Click);
        _miSoundsList = value;
        if (_miSoundsList == null)
          return;
        _miSoundsList.Click += new EventHandler(miSoundsList_Click);
      }
  }

  internal virtual ToolStripMenuItem miTriggersList
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miTriggersList != null)
          _miTriggersList.Click -= new EventHandler(miTriggersList_Click);
        _miTriggersList = value;
        if (_miTriggersList == null)
          return;
        _miTriggersList.Click += new EventHandler(miTriggersList_Click);
      }
    get => _miTriggersList;
  }

  internal virtual ToolStripMenuItem miDoorsList
  {
    get => _miDoorsList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miDoorsList != null)
          _miDoorsList.Click -= new EventHandler(miDoorsList_Click);
        _miDoorsList = value;
        if (_miDoorsList == null)
          return;
        _miDoorsList.Click += new EventHandler(miDoorsList_Click);
      }
  }

  internal virtual ToolStripMenuItem miCameras
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCameras != null)
          _miCameras.Click -= new EventHandler(miCameras_Click);
        _miCameras = value;
        if (_miCameras == null)
          return;
        _miCameras.Click += new EventHandler(miCameras_Click);
      }
    get => _miCameras;
  }

  internal virtual ToolStripMenuItem miCreatureList
  {
    get => _miCreatureList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCreatureList != null)
          _miCreatureList.Click -= new EventHandler(miCreatureList_Click);
        _miCreatureList = value;
        if (_miCreatureList == null)
          return;
        _miCreatureList.Click += new EventHandler(miCreatureList_Click);
      }
  }

  internal virtual ToolStripMenuItem miMerchantList
  {
    get => _miMerchantList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miMerchantList != null)
          _miMerchantList.Click -= new EventHandler(miMerchantList_Click);
        _miMerchantList = value;
        if (_miMerchantList == null)
          return;
        _miMerchantList.Click += new EventHandler(miMerchantList_Click);
      }
  }

  internal virtual ToolStripMenuItem miSave
  {
    get => _miSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miSave != null)
          _miSave.Click -= new EventHandler(miSave_Click);
        _miSave = value;
        if (_miSave == null)
          return;
        _miSave.Click += new EventHandler(miSave_Click);
      }
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

  internal virtual ToolStripMenuItem miScriptIsK1
  {
    get => _miScriptIsK1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miScriptIsK1 != null)
          _miScriptIsK1.Click -= new EventHandler(miScriptIsK1_Click);
        _miScriptIsK1 = value;
        if (_miScriptIsK1 == null)
          return;
        _miScriptIsK1.Click += new EventHandler(miScriptIsK1_Click);
      }
  }

  internal virtual ToolStripMenuItem miScriptIsK2
  {
    get => _miScriptIsK2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miScriptIsK2 != null)
          _miScriptIsK2.Click -= new EventHandler(miScriptIsK2_Click);
        _miScriptIsK2 = value;
        if (_miScriptIsK2 == null)
          return;
        _miScriptIsK2.Click += new EventHandler(miScriptIsK2_Click);
      }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem12
  {
    get => _ToolStripMenuItem12;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_ToolStripMenuItem12 == null)
          ;
        _ToolStripMenuItem12 = value;
        if (_ToolStripMenuItem12 == null)
          ;
      }
  }

  internal virtual ToolStripMenuItem miCompile
  {
    get => _miCompile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_miCompile != null)
          _miCompile.Click -= new EventHandler(miCompile_Click);
        _miCompile = value;
        if (_miCompile == null)
          return;
        _miCompile.Click += new EventHandler(miCompile_Click);
      }
  }

  internal virtual ListBox lbFunctions
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbFunctions != null)
        {
          _lbFunctions.SelectedIndexChanged -= new EventHandler(lbFunctions_SelectedIndexChanged);
          _lbFunctions.DoubleClick -= new EventHandler(lbFunctions_DoubleClick);
          _lbFunctions.Click -= new EventHandler(lbFunctions_Click);
        }
        _lbFunctions = value;
        if (_lbFunctions == null)
          return;
        _lbFunctions.SelectedIndexChanged += new EventHandler(lbFunctions_SelectedIndexChanged);
        _lbFunctions.DoubleClick += new EventHandler(lbFunctions_DoubleClick);
        _lbFunctions.Click += new EventHandler(lbFunctions_Click);
      }
    get => _lbFunctions;
  }

  internal virtual TextBox tbFuncNameFilter
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFuncNameFilter != null)
          _tbFuncNameFilter.TextChanged -= new EventHandler(tbFuncNameFilter_TextChanged);
        _tbFuncNameFilter = value;
        if (_tbFuncNameFilter == null)
          return;
        _tbFuncNameFilter.TextChanged += new EventHandler(tbFuncNameFilter_TextChanged);
      }
    get => _tbFuncNameFilter;
  }

  internal virtual TextBox tbFuncDecl
  {
    get => _tbFuncDecl;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFuncDecl == null)
          ;
        _tbFuncDecl = value;
        if (_tbFuncDecl == null)
          ;
      }
  }

  internal virtual Label Label1
  {
    get => _Label1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 == null)
          ;
      }
  }

  internal virtual Panel pnlFunctions
  {
    get => _pnlFunctions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlFunctions == null)
          ;
        _pnlFunctions = value;
        if (_pnlFunctions == null)
          ;
      }
  }

  internal virtual Label lblMatches
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblMatches == null)
          ;
        _lblMatches = value;
        if (_lblMatches == null)
          ;
      }
    get => _lblMatches;
  }

  internal virtual ContextMenu cmText
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmText == null)
          ;
        _cmText = value;
        if (_cmText == null)
          ;
      }
    get => _cmText;
  }

  internal virtual ToolStripMenuItem cmiShowDefinition
  {
    get => _cmiShowDefinition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmiShowDefinition != null)
          _cmiShowDefinition.Click -= new EventHandler(cmiShowDefinition_Click);
        _cmiShowDefinition = value;
        if (_cmiShowDefinition == null)
          return;
        _cmiShowDefinition.Click += new EventHandler(cmiShowDefinition_Click);
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmTextEditor));
      tbGeneric = new LinenumberTextBox();
      MainMenu1 = new MainMenu();
      ToolStripMenuItem1 = new ToolStripMenuItem();
      miOpen = new ToolStripMenuItem();
      miSave = new ToolStripMenuItem();
      miSaveAs = new ToolStripMenuItem();
      ToolStripMenuItem4 = new ToolStripMenuItem();
      miPageSetup = new ToolStripMenuItem();
      miPrint = new ToolStripMenuItem();
      miQuit = new ToolStripMenuItem();
      ToolStripMenuItem2 = new ToolStripMenuItem();
      miUndo = new ToolStripMenuItem();
      miRedo = new ToolStripMenuItem();
      ToolStripMenuItem3 = new ToolStripMenuItem();
      miCut = new ToolStripMenuItem();
      miCopy = new ToolStripMenuItem();
      miPaste = new ToolStripMenuItem();
      ToolStripMenuItem9 = new ToolStripMenuItem();
      miSelectAll = new ToolStripMenuItem();
      ToolStripMenuItem7 = new ToolStripMenuItem();
      miFind = new ToolStripMenuItem();
      miFindAgain = new ToolStripMenuItem();
      ToolStripMenuItem5 = new ToolStripMenuItem();
      miWordWrap = new ToolStripMenuItem();
      miFont = new ToolStripMenuItem();
      ToolStripMenuItem6 = new ToolStripMenuItem();
      miCameras = new ToolStripMenuItem();
      miCreatureList = new ToolStripMenuItem();
      miDoorsList = new ToolStripMenuItem();
      miEncountersList = new ToolStripMenuItem();
      miMerchantList = new ToolStripMenuItem();
      miPlaceablesList = new ToolStripMenuItem();
      miSoundsList = new ToolStripMenuItem();
      miTriggersList = new ToolStripMenuItem();
      miWaypointsList = new ToolStripMenuItem();
      ToolStripMenuItem8 = new ToolStripMenuItem();
      miScriptIsK1 = new ToolStripMenuItem();
      miScriptIsK2 = new ToolStripMenuItem();
      ToolStripMenuItem12 = new ToolStripMenuItem();
      miCompile = new ToolStripMenuItem();
      lbFunctions = new ListBox();
      tbFuncNameFilter = new TextBox();
      tbFuncDecl = new TextBox();
      pnlFunctions = new Panel();
      Label1 = new Label();
      lblMatches = new Label();
      cmText = new ContextMenu();
      cmiShowDefinition = new ToolStripMenuItem();
      pnlFunctions.SuspendLayout();
      SuspendLayout();
      tbGeneric.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      tbGeneric.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      LinenumberTextBox tbGeneric1 = tbGeneric;
      Point point1 = new Point(16, 8);
      Point point2 = point1;
      tbGeneric1.Location = point2;
      tbGeneric.Name = "tbGeneric";
      tbGeneric.ShowSelectionMargin = true;
      LinenumberTextBox tbGeneric2 = tbGeneric;
      Size size1 = new Size(904, 584);
      Size size2 = size1;
      tbGeneric2.Size = size2;
      tbGeneric.TabIndex = 5;
      tbGeneric.Text = "";
      MainMenu1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[5]
      {
        ToolStripMenuItem1,
        ToolStripMenuItem2,
        ToolStripMenuItem5,
        ToolStripMenuItem6,
        ToolStripMenuItem8
      });
      ToolStripMenuItem1.Index = 0;
      ToolStripMenuItem1.ToolStripMenuItems.AddRange(new ToolStripMenuItem[7]
      {
        miOpen,
        miSave,
        miSaveAs,
        ToolStripMenuItem4,
        miPageSetup,
        miPrint,
        miQuit
      });
      ToolStripMenuItem1.Text = "&File";
      miOpen.Index = 0;
      miOpen.Shortcut = Shortcut.CtrlO;
      miOpen.Text = "&Open...";
      miSave.Index = 1;
      miSave.Shortcut = Shortcut.CtrlS;
      miSave.Text = "&Save";
      miSaveAs.Index = 2;
      miSaveAs.Shortcut = Shortcut.CtrlShiftS;
      miSaveAs.Text = "Save &As...";
      ToolStripMenuItem4.Index = 3;
      ToolStripMenuItem4.Text = "-";
      miPageSetup.Index = 4;
      miPageSetup.Text = "Page Set&up";
      miPrint.Index = 5;
      miPrint.Shortcut = Shortcut.CtrlP;
      miPrint.Text = "&Print";
      miQuit.Index = 6;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      ToolStripMenuItem2.Index = 1;
      ToolStripMenuItem2.ToolStripMenuItems.AddRange(new ToolStripMenuItem[11]
      {
        miUndo,
        miRedo,
        ToolStripMenuItem3,
        miCut,
        miCopy,
        miPaste,
        ToolStripMenuItem9,
        miSelectAll,
        ToolStripMenuItem7,
        miFind,
        miFindAgain
      });
      ToolStripMenuItem2.Text = "&Edit";
      miUndo.Index = 0;
      miUndo.Shortcut = Shortcut.CtrlZ;
      miUndo.Text = "&Undo";
      miRedo.Index = 1;
      miRedo.Shortcut = Shortcut.CtrlY;
      miRedo.Text = "&Redo";
      ToolStripMenuItem3.Index = 2;
      ToolStripMenuItem3.Text = "-";
      miCut.Index = 3;
      miCut.Shortcut = Shortcut.CtrlX;
      miCut.Text = "Cu&t";
      miCopy.Index = 4;
      miCopy.Shortcut = Shortcut.CtrlC;
      miCopy.Text = "&Copy";
      miPaste.Index = 5;
      miPaste.Shortcut = Shortcut.CtrlV;
      miPaste.Text = "&Paste";
      ToolStripMenuItem9.Index = 6;
      ToolStripMenuItem9.Text = "-";
      miSelectAll.Index = 7;
      miSelectAll.Shortcut = Shortcut.CtrlA;
      miSelectAll.Text = "Select &All";
      ToolStripMenuItem7.Index = 8;
      ToolStripMenuItem7.Text = "-";
      miFind.Index = 9;
      miFind.Shortcut = Shortcut.CtrlF;
      miFind.Text = "&Find...";
      miFindAgain.Index = 10;
      miFindAgain.Shortcut = Shortcut.F3;
      miFindAgain.Text = "Find &Next";
      ToolStripMenuItem5.Index = 2;
      ToolStripMenuItem5.ToolStripMenuItems.AddRange(new ToolStripMenuItem[2]
      {
        miWordWrap,
        miFont
      });
      ToolStripMenuItem5.Text = "F&ormat";
      miWordWrap.Checked = true;
      miWordWrap.Index = 0;
      miWordWrap.Text = "&Word Wrap";
      miFont.Index = 1;
      miFont.Text = "&Font...";
      ToolStripMenuItem6.Index = 3;
      ToolStripMenuItem6.ToolStripMenuItems.AddRange(new ToolStripMenuItem[9]
      {
        miCameras,
        miCreatureList,
        miDoorsList,
        miEncountersList,
        miMerchantList,
        miPlaceablesList,
        miSoundsList,
        miTriggersList,
        miWaypointsList
      });
      ToolStripMenuItem6.Text = "&Quick";
      miCameras.Index = 0;
      miCameras.Text = "C&ameras";
      miCreatureList.Index = 1;
      miCreatureList.Text = "&Creature List";
      miDoorsList.Index = 2;
      miDoorsList.Text = "&Doors List";
      miEncountersList.Index = 3;
      miEncountersList.Text = "&Encounters List";
      miMerchantList.Index = 4;
      miMerchantList.Text = "&Merchant List";
      miPlaceablesList.Index = 5;
      miPlaceablesList.Text = "&Placeables List";
      miSoundsList.Index = 6;
      miSoundsList.Text = "&Sounds List";
      miTriggersList.Index = 7;
      miTriggersList.Text = "&Triggers List";
      miWaypointsList.Index = 8;
      miWaypointsList.Text = "&Waypoints List";
      ToolStripMenuItem8.Index = 4;
      ToolStripMenuItem8.ToolStripMenuItems.AddRange(new ToolStripMenuItem[4]
      {
        miScriptIsK1,
        miScriptIsK2,
        ToolStripMenuItem12,
        miCompile
      });
      ToolStripMenuItem8.Text = "&Script";
      miScriptIsK1.Index = 0;
      miScriptIsK1.Text = "Script is for KotOR I";
      miScriptIsK2.Index = 1;
      miScriptIsK2.Text = "Script is for KotOR II";
      ToolStripMenuItem12.Index = 2;
      ToolStripMenuItem12.Text = "-";
      miCompile.Enabled = false;
      miCompile.Index = 3;
      miCompile.Shortcut = Shortcut.F5;
      miCompile.Text = "&Compile";
      lbFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      ListBox lbFunctions1 = lbFunctions;
      point1 = new Point(700, 40);
      Point point3 = point1;
      lbFunctions1.Location = point3;
      lbFunctions.Name = "lbFunctions";
      ListBox lbFunctions2 = lbFunctions;
      size1 = new Size(208, 82);
      Size size3 = size1;
      lbFunctions2.Size = size3;
      lbFunctions.TabIndex = 6;
      tbFuncNameFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      TextBox tbFuncNameFilter1 = tbFuncNameFilter;
      point1 = new Point(700, 16);
      Point point4 = point1;
      tbFuncNameFilter1.Location = point4;
      tbFuncNameFilter.Name = "tbFuncNameFilter";
      TextBox tbFuncNameFilter2 = tbFuncNameFilter;
      size1 = new Size(208, 20);
      Size size4 = size1;
      tbFuncNameFilter2.Size = size4;
      tbFuncNameFilter.TabIndex = 7;
      tbFuncNameFilter.Text = "";
      tbFuncDecl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TextBox tbFuncDecl1 = tbFuncDecl;
      point1 = new Point(8, 1);
      Point point5 = point1;
      tbFuncDecl1.Location = point5;
      tbFuncDecl.Multiline = true;
      tbFuncDecl.Name = "tbFuncDecl";
      tbFuncDecl.ScrollBars = ScrollBars.Vertical;
      TextBox tbFuncDecl2 = tbFuncDecl;
      size1 = new Size(680, 120);
      Size size5 = size1;
      tbFuncDecl2.Size = size5;
      tbFuncDecl.TabIndex = 8;
      tbFuncDecl.Text = "";
      pnlFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      pnlFunctions.Controls.Add(tbFuncDecl);
      pnlFunctions.Controls.Add(tbFuncNameFilter);
      pnlFunctions.Controls.Add(lbFunctions);
      pnlFunctions.Controls.Add(Label1);
      pnlFunctions.Controls.Add(lblMatches);
      Panel pnlFunctions1 = pnlFunctions;
      point1 = new Point(8, 472);
      Point point6 = point1;
      pnlFunctions1.Location = point6;
      pnlFunctions.Name = "pnlFunctions";
      Panel pnlFunctions2 = pnlFunctions;
      size1 = new Size(912, 136);
      Size size6 = size1;
      pnlFunctions2.Size = size6;
      pnlFunctions.TabIndex = 10;
      pnlFunctions.Visible = false;
      Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Label label1_1 = Label1;
      point1 = new Point(700, 0);
      Point point7 = point1;
      label1_1.Location = point7;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(76, 16);
      Size size7 = size1;
      label1_2.Size = size7;
      Label1.TabIndex = 9;
      Label1.Text = "Function filter";
      lblMatches.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      lblMatches.ForeColor = SystemColors.Highlight;
      Label lblMatches1 = lblMatches;
      point1 = new Point(824, 0);
      Point point8 = point1;
      lblMatches1.Location = point8;
      lblMatches.Name = "lblMatches";
      Label lblMatches2 = lblMatches;
      size1 = new Size(76, 16);
      Size size8 = size1;
      lblMatches2.Size = size8;
      lblMatches.TabIndex = 9;
      lblMatches.Text = "Matches: ";
      cmText.ToolStripMenuItems.AddRange(new ToolStripMenuItem[1]
      {
        cmiShowDefinition
      });
      cmiShowDefinition.Index = 0;
      cmiShowDefinition.Text = "Show Definition...";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(936, 601);
      ClientSize = size1;
      Controls.Add(tbGeneric);
      Controls.Add(pnlFunctions);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Menu = MainMenu1;
      Name = nameof (frmTextEditor);
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.CenterParent;
      Text = "Text Editor";
      pnlFunctions.ResumeLayout(false);
      ResumeLayout(false);
    }

  public string EditingFilePath
  {
    get => _EditingFilePath;
    set => _EditingFilePath = value;
  }

  public bool DirectEdit
  {
    get => _IsDirectEdit;
    set => _IsDirectEdit = value;
  }

  public string Filename
  {
    get => fname;
    set
    {
        fname = value;
        Text = "Text Editor - " + value;
      }
  }

  public bool RTFMode
  {
    get => m_rtfMode;
    set => m_rtfMode = value;
  }

  public int KotorVersionIndex
  {
    set
    {
        _KotorVersionIndex = value;
        miCompile.Enabled = true;
        if (_KotorVersionIndex == 0)
        {
          miScriptIsK1.Checked = true;
        }
        else
        {
          if (_KotorVersionIndex != 1)
            return;
          miScriptIsK2.Checked = true;
        }
      }
    get => _KotorVersionIndex;
  }

  public frmTextEditor(string filename, bool IsDirectEdit = false, string EditingPath = "")
    : this()
  {
      fname = filename;
      Text = "Text Editor - " + fname;
      if (!IsDirectEdit)
        return;
      _IsDirectEdit = true;
      _EditingFilePath = EditingPath;
    }

  public frmTextEditor(string EditingPath, int KotorVerIndex, bool IsDirectEdit = false)
    : this()
  {
      RTFMode = false;
      KotorVersionIndex = KotorVerIndex;
      _IsDirectEdit = IsDirectEdit;
      _EditingFilePath = EditingPath;
      StreamReader streamReader = new StreamReader(_EditingFilePath);
      tbGeneric.Text = streamReader.ReadToEnd();
      tbGeneric.SelectionLength = 0;
      streamReader.Close();
    }

  private void btnCancel_Click(object sender, EventArgs e) => Hide();

  private void tbGeneric_MouseMove(object sender, MouseEventArgs e)
  {
      if (e.X > 0 & e.X < 7)
        Cursor.Current = Cursors.Arrow;
      else
        Cursor.Current = Cursors.IBeam;
    }

  public void PositionWindow()
  {
      UserSettings.GetSettings();
      Point point = FrmMain.CurrentSettings.TextEditorWindowLoc;
      if (!point.IsEmpty)
        ((Control) this).Location = FrmMain.CurrentSettings.TextEditorWindowLoc;
      if (FrmMain.CurrentSettings.TextEditorWindowSize.IsEmpty)
        return;
      Size size1 = FrmMain.CurrentSettings.TextEditorWindowSize;
      int height1 = size1.Height;
      Rectangle workingArea1 = Screen.PrimaryScreen.WorkingArea;
      int height2 = workingArea1.Height;
      Point location = default;
      int height3 = 0;
      if (height1 > height2)
      {
        ref Point local1 = ref location;
        point = ((Control) this).Location;
        int x = point.X;
        int top = Screen.PrimaryScreen.WorkingArea.Top;
        local1 = new Point(x, top);
        ((Control) this).Location = location;
        height3 = Screen.PrimaryScreen.WorkingArea.Height;
        Size size2 = default;
        ref Size local2 = ref size2;
        size1 = Size;
        int width = size1.Width;
        int height4 = height3;
        local2 = new Size(width, height4);
        Size = size2;
      }
      int width1 = FrmMain.CurrentSettings.TextEditorWindowSize.Width;
      Rectangle workingArea2 = Screen.PrimaryScreen.WorkingArea;
      int width2 = workingArea2.Width;
      int width3 = 0;
      if (width1 > width2)
      {
        ref Point local = ref point;
        workingArea1 = Screen.PrimaryScreen.WorkingArea;
        int left = workingArea1.Left;
        location = ((Control) this).Location;
        int y = location.Y;
        local = new Point(left, y);
        ((Control) this).Location = point;
        workingArea2 = Screen.PrimaryScreen.WorkingArea;
        width3 = workingArea2.Width;
        size1 = new Size(width3, Size.Height);
        Size = size1;
      }
      if (!(width3 == 0 & height3 == 0))
        return;
      Size = FrmMain.CurrentSettings.TextEditorWindowSize;
    }

  public void SaveSettings()
  {
      if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Minimized)
        WindowState = FormWindowState.Normal;
      Size size = Size;
      int width1 = size.Width;
      size = Size;
      int height1 = size.Height;
      int num1 = height1;
      Rectangle workingArea1 = Screen.PrimaryScreen.WorkingArea;
      int height2 = workingArea1.Height;
      Rectangle workingArea2;
      if (num1 >= height2)
      {
        workingArea2 = Screen.PrimaryScreen.WorkingArea;
        height1 = checked (workingArea2.Height - 20);
      }
      int num2 = width1;
      workingArea2 = Screen.PrimaryScreen.WorkingArea;
      int width2 = workingArea2.Width;
      if (num2 >= width2)
      {
        workingArea1 = Screen.PrimaryScreen.WorkingArea;
        width1 = checked (workingArea1.Width - 20);
      }
      size = new Size(width1, height1);
      Size = size;
      Point point = default;
      ref Point local1 = ref point;
      int x1 = ((Control) this).Location.X;
      Point location = ((Control) this).Location;
      int y = location.Y;
      local1 = new Point(x1, y);
      location = ((Control) this).Location;
      if (location.X < 0)
        point.X = 0;
      location = ((Control) this).Location;
      int x2 = location.X;
      size = Size;
      int width3 = size.Width;
      int num3 = checked (x2 + width3);
      workingArea2 = Screen.PrimaryScreen.WorkingArea;
      int width4 = workingArea2.Width;
      if (num3 > width4)
      {
        ref Point local2 = ref point;
        workingArea1 = Screen.PrimaryScreen.WorkingArea;
        int num4 = checked (workingArea1.Width - Size.Width - 30);
        local2.X = num4;
      }
      location = ((Control) this).Location;
      if (location.Y < 0)
        point.Y = 0;
      location = ((Control) this).Location;
      int num5 = checked (location.Y + Size.Height);
      workingArea2 = Screen.PrimaryScreen.WorkingArea;
      int height3 = workingArea2.Height;
      if (num5 > height3)
      {
        ref Point local3 = ref point;
        workingArea1 = Screen.PrimaryScreen.WorkingArea;
        int height4 = workingArea1.Height;
        size = Size;
        int height5 = size.Height;
        int num6 = checked (height4 - height5 - 30);
        local3.Y = num6;
      }
      ((Control) this).Location = point;
      CurrentSettings.TextEditorWindowLoc = ((Control) this).Location;
      CurrentSettings.TextEditorWindowSize = Size;
      UserSettings.SaveSettings(CurrentSettings);
    }

  private void frmTextEditor_Load(object sender, EventArgs e) => PositionWindow();

  private void frmTextEditor_Closing(object sender, CancelEventArgs e) => SaveSettings();

  private void miFind_Click(object sender, EventArgs e)
  {
      frmTextEditorFind frmTextEditorFind = new frmTextEditorFind();
      frmTextEditorFind.tbFindText.Text = tbGeneric.SelectionLength <= 0 ? g_findString : tbGeneric.SelectedText;
      frmTextEditorFind.chkbMatchCase.Checked = g_matchcase;
      frmTextEditorFind.chkbMatchWholeWord.Checked = g_matchwholeword;
      frmTextEditorFind.chkbSearchUp.Checked = g_searchup;
      if (frmTextEditorFind.ShowDialog(this) != DialogResult.OK || StringType.StrCmp(frmTextEditorFind.tbFindText.Text, "", false) == 0)
        return;
      g_findString = frmTextEditorFind.tbFindText.Text;
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = frmTextEditorFind.chkbMatchCase.Checked;
      g_matchwholeword = frmTextEditorFind.chkbMatchWholeWord.Checked;
      g_searchup = frmTextEditorFind.chkbSearchUp.Checked;
      if (g_matchcase | g_matchwholeword | g_searchup)
      {
        if (g_matchcase)
          g_searchoptions |= RichTextBoxFinds.MatchCase;
        if (g_matchwholeword)
          g_searchoptions |= RichTextBoxFinds.WholeWord;
        if (g_searchup)
          g_searchoptions |= RichTextBoxFinds.Reverse;
      }
      else
        g_searchoptions = RichTextBoxFinds.None;
      SearchFromStart();
    }

  private void miFindAgain_Click(object sender, EventArgs e)
  {
      int gFindPos = g_findPos;
      if (StringType.StrCmp(g_findString, "", false) == 0)
        return;
      g_findPos = (g_searchoptions & RichTextBoxFinds.Reverse) == 0 ? tbGeneric.Find(g_findString, checked (g_findPos + 1), g_searchoptions) : tbGeneric.Find(g_findString, 0, gFindPos != -1 ? checked (g_findPos - 1) : tbGeneric.TextLength, g_searchoptions);
      if (g_findPos == -1)
      {
        if (Interaction.MsgBox("No more ocurrences found\nStart search from beginning of file?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
        {
          SearchFromStart();
        }
        else
        {
          tbGeneric.SelectionStart = gFindPos;
          tbGeneric.SelectionLength = g_findString.Length;
          tbGeneric.Focus();
          return;
        }
      }
      tbGeneric.SelectionStart = g_findPos;
      tbGeneric.SelectionLength = g_findString.Length;
      tbGeneric.Focus();
    }

  private void SearchFromStart()
  {
      g_findPos = tbGeneric.Find(g_findString, g_searchoptions);
      if (g_findPos == -1)
      {
        int num = (int) Interaction.MsgBox("Text not found", MsgBoxStyle.Information);
        tbGeneric.SelectionStart = 0;
        tbGeneric.SelectionLength = 0;
      }
      else
      {
        tbGeneric.SelectionStart = g_findPos;
        tbGeneric.SelectionLength = g_findString.Length;
        tbGeneric.Focus();
      }
    }

  private void miUndo_Click(object sender, EventArgs e) => tbGeneric.Undo();

  private void miRedo_Click(object sender, EventArgs e) => tbGeneric.Redo();

  private void miCut_Click(object sender, EventArgs e)
  {
      if (tbGeneric.SelectedText.Equals(""))
        return;
      if (RTFMode)
      {
        Clipboard.SetDataObject(tbGeneric.SelectedRtf, true);
        tbGeneric.SelectedRtf = "";
      }
      else
      {
        Clipboard.SetDataObject(tbGeneric.SelectedText, true);
        tbGeneric.SelectedText = "";
      }
    }

  private void miCopy_Click(object sender, EventArgs e)
  {
      Clipboard.SetDataObject(tbGeneric.SelectedRtf, true);
      if (RTFMode)
        Clipboard.SetDataObject(tbGeneric.SelectedRtf, true);
      else
        Clipboard.SetDataObject(tbGeneric.SelectedText, true);
    }

  private void miPaste_Click(object sender, EventArgs e)
  {
      try
      {
        DataObject dataObject = (DataObject) Clipboard.GetDataObject();
        if (dataObject.GetDataPresent(DataFormats.Rtf))
        {
          string str = StringType.FromObject(dataObject.GetData(DataFormats.Rtf));
          if (str.Equals(""))
            return;
          tbGeneric.SelectedRtf = str;
        }
        else if (dataObject.GetDataPresent(DataFormats.Text) & !RTFMode)
        {
          string str = StringType.FromObject(dataObject.GetData(DataFormats.Text));
          if (str.Equals(""))
            return;
          tbGeneric.SelectedText = str;
        }
        else
        {
          if (!dataObject.GetDataPresent(DataFormats.Text))
            return;
          string str = StringType.FromObject(dataObject.GetData(DataFormats.Text));
          if (str.Equals(""))
            return;
          tbGeneric.SelectedRtf = str;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

  private void miSelectAll_Click(object sender, EventArgs e)
  {
      tbGeneric.SelectAll();
      tbGeneric.Focus();
    }

  private void miOpen_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("load", FrmMain.CurrentSettings.defaultSaveLocation, fname, "Load file...", ""));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      RichTextBoxStreamType fileType = StringType.StrCmp(Strings.LCase(Path.GetExtension(str)), ".rtf", false) != 0 ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText;
      try
      {
        tbGeneric.Rtf = "";
        tbGeneric.LoadFile(str, fileType);
      }
      catch (ArgumentException ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

  private void miSave_Click(object sender, EventArgs e)
  {
      if (StringType.StrCmp(_EditingFilePath, "", false) == 0)
      {
        _EditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.TextEditorSavePath, fname, "Save file...", ""));
        if (StringType.StrCmp(_EditingFilePath, "", false) == 0)
          return;
      }
      StreamWriter streamWriter = new StreamWriter(new FileStream(_EditingFilePath, FileMode.Create), Encoding.ASCII);
      streamWriter.Write(Strings.Replace(tbGeneric.Text, "\n", "\r\n"));
      streamWriter.Close();
      CurrentSettings.TextEditorSavePath = Path.GetDirectoryName(_EditingFilePath);
      UserSettings.SaveSettings(CurrentSettings);
      Filename = Path.GetFileName(_EditingFilePath);
    }

  private void miSaveAs_Click(object sender, EventArgs e)
  {
      string str = StringType.FromObject(FrmMain.GetFilePath("save", !_IsDirectEdit ? CurrentSettings.TextEditorSavePath : Path.GetDirectoryName(_EditingFilePath), fname, "Save file...", ""));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      CurrentSettings.TextEditorSavePath = Path.GetDirectoryName(str);
      UserSettings.SaveSettings(CurrentSettings);
      StreamWriter streamWriter = new StreamWriter(new FileStream(str, FileMode.Create), Encoding.ASCII);
      if (m_rtfMode)
        streamWriter.Write(tbGeneric.Rtf);
      else
        streamWriter.Write(Strings.Replace(tbGeneric.Text, "\n", "\r\n"));
      streamWriter.Close();
      _EditingFilePath = str;
      Filename = Path.GetFileName(str);
    }

  private void miQuit_Click(object sender, EventArgs e) => Close();

  private void miPrint_Click(object sender, EventArgs e)
  {
      streamToPrint = new StringReader(tbGeneric.Text);
      try
      {
        try
        {
          printFont = tbGeneric.Font;
          PrintDocument printDocument = new PrintDocument();
          printDocument.PrintPage += new PrintPageEventHandler(pd_PrintPage);
          if (storedPageSettings != null)
            printDocument.DefaultPageSettings = storedPageSettings;
          if (new PrintDialog() { Document = printDocument }.ShowDialog(this) != DialogResult.OK)
            return;
          printDocument.Print();
        }
        finally
        {
          streamToPrint.Close();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show(ex.Message);
        ProjectData.ClearProjectError();
      }
    }

  private void pd_PrintPage(object sender, PrintPageEventArgs ev)
  {
      int num1 = 0;
      float left = ev.MarginBounds.Left;
      float top = ev.MarginBounds.Top;
      string s = null;
      float num2 = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
      while (num1 < (double) num2)
      {
        s = streamToPrint.ReadLine();
        if (s != null)
        {
          float y = top + num1 * printFont.GetHeight(ev.Graphics);
          ev.Graphics.DrawString(s, printFont, Brushes.Black, left, y, new StringFormat());
          checked { ++num1; }
        }
        else
          break;
      }
      if (s != null)
        ev.HasMorePages = true;
      else
        ev.HasMorePages = false;
    }

  private void miPageSetup_Click(object sender, EventArgs e)
  {
      try
      {
        PageSetupDialog pageSetupDialog = new PageSetupDialog();
        if (storedPageSettings == null)
          storedPageSettings = new PageSettings();
        pageSetupDialog.PageSettings = storedPageSettings;
        int num = (int) pageSetupDialog.ShowDialog();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show("An error occurred - " + ex.Message);
        ProjectData.ClearProjectError();
      }
    }

  private void miFont_Click(object sender, EventArgs e)
  {
      FontDialog fontDialog = new FontDialog();
      fontDialog.ShowColor = true;
      fontDialog.Font = tbGeneric.SelectionFont;
      if (fontDialog.ShowDialog() != DialogResult.OK)
        return;
      if (tbGeneric.SelectionLength == 0)
        tbGeneric.Font = fontDialog.Font;
      else
        tbGeneric.SelectionFont = fontDialog.Font;
      tbGeneric.SelectionColor = fontDialog.Color;
    }

  private void miWordWrap_Click(object sender, EventArgs e)
  {
      if (((ToolStripMenuItem) sender).Checked)
      {
        tbGeneric.WordWrap = false;
        ((ToolStripMenuItem) sender).Checked = false;
      }
      else
      {
        tbGeneric.WordWrap = true;
        ((ToolStripMenuItem) sender).Checked = true;
      }
    }

  private void miEncountersList_Click(object sender, EventArgs e)
  {
      g_findString = "Encounter List";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miPlaceablesList_Click(object sender, EventArgs e)
  {
      g_findString = "Placeable List";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miCameras_Click(object sender, EventArgs e)
  {
      g_findString = "CameraList";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miDoorsList_Click(object sender, EventArgs e)
  {
      g_findString = "Door List";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miSoundsList_Click(object sender, EventArgs e)
  {
      g_findString = "SoundList";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miTriggersList_Click(object sender, EventArgs e)
  {
      g_findString = "TriggerList";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miWaypointsList_Click(object sender, EventArgs e)
  {
      g_findString = "WaypointList";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miCreatureList_Click(object sender, EventArgs e)
  {
      g_findString = "Creature List";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private void miMerchantList_Click(object sender, EventArgs e)
  {
      g_findString = "StoreList";
      g_searchoptions = RichTextBoxFinds.None;
      g_matchcase = false;
      g_searchup = false;
      g_matchwholeword = false;
      SearchFromStart();
    }

  private string CompileNSS()
  {
      if (_EditingFilePath != null && StringType.StrCmp(_EditingFilePath, "", false) != 0)
      {
        string str = "-g " + Convert.ToString(checked (_KotorVersionIndex + 1));
        string path = Path.ChangeExtension(_EditingFilePath, ".ncs");
        if (File.Exists(path))
          File.Delete(path);
        Process process = new Process();
        process.StartInfo.FileName = FrmMain.GRootPath + "nwnnsscomp.exe";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.Arguments = "-c " + str + " -o " + "\"" + path + "\"" + " " + "\"" + _EditingFilePath + "\"";
        process.StartInfo.RedirectStandardOutput = true;
        process.Start();
        string end = process.StandardOutput.ReadToEnd();
        process.WaitForExit(4000);
        int num = (int) Interaction.MsgBox(end, MsgBoxStyle.Information, "Compiler output");
      }
      string str1 = null;
      return str1;
    }

  private void miCompile_Click(object sender, EventArgs e)
  {
      miSave_Click(null, null);
      CompileNSS();
    }

  private void miScriptIsK1_Click(object sender, EventArgs e)
  {
      KotorVersionIndex = 0;
      miScriptIsK2.Checked = false;
      miCompile.Enabled = true;
      PrepareForScriptEditing();
    }

  private void miScriptIsK2_Click(object sender, EventArgs e)
  {
      KotorVersionIndex = 1;
      miScriptIsK1.Checked = false;
      miCompile.Enabled = true;
      PrepareForScriptEditing();
    }

  public void PrepareForScriptEditing()
  {
      LoadNWScript(KotorVersionIndex);
      ShowFilterMatches();
      if (pnlFunctions.Visible)
        return;
      pnlFunctions.Visible = true;
      tbGeneric.Size = new Size(tbGeneric.Size.Width, checked (tbGeneric.Size.Height - 128));
    }

  private void LoadNWScript(int index)
  {
      FileStream fileStream = new FileStream(Path.Combine(FrmMain.CurrentSettings.KotorLocation(index), "override\\nwscript.nss"), FileMode.Open);
      StreamReader streamReader = new StreamReader(fileStream);
      int num1 = 0;
      int num2 = 0;
      switch (index)
      {
        case 0:
          num1 = 1666;
          num2 = 3507;
          this.funcs = new func[772];
          break;
        case 1:
          num1 = 2044;
          num2 = 4277;
          this.funcs = new func[877];
          break;
      }
      int num3 = num1;
      int num4 = 1;
      while (num4 <= num3)
      {
        streamReader.ReadLine();
        checked { ++num4; }
      }
      int num5 = num2;
      int num6 = 1;
      while (num6 <= num5)
      {
        string str = streamReader.ReadLine();
        int index1 = 0;
        if (str.StartsWith("//"))
        {
          func[] funcs = this.funcs;
          int index2 = index1;
          int index3 = index2;
          funcs[index3].comment = this.funcs[index2].comment + str + "\r\n";
        }
        else if (str.Length != 0)
        {
          funcs[index1].decl = str;
          string[] strArray = Strings.Split(str.Replace("(", " "));
          int index4 = 1;
          while (StringType.StrCmp(strArray[index4], "", false) == 0)
          {
            checked { ++index4; }
            if (index4 > 10)
              break;
          }
          funcs[index1].name = strArray[index4];
          checked { ++index1; }
        }
        checked { ++num6; }
      }
      fileStream.Close();
    }

  private void ShowFilterMatches()
  {
      lbFunctions.Items.Clear();
      lbFunctions.Sorted = true;
      string[] arySrc = new string[checked (funcs.GetUpperBound(0) + 1)];
      int index1 = 0;
      if (StringType.StrCmp(tbFuncNameFilter.Text.Trim(), "", false) == 0)
      {
        int upperBound = funcs.GetUpperBound(0);
        int index2 = 0;
        while (index2 <= upperBound)
        {
          arySrc[index1] = funcs[index2].name;
          checked { ++index1; }
          checked { ++index2; }
        }
      }
      else
      {
        int upperBound = funcs.GetUpperBound(0);
        int index3 = 0;
        while (index3 <= upperBound)
        {
          if (funcs[index3].name.ToLower().IndexOf(tbFuncNameFilter.Text.Trim().ToLower()) > -1)
          {
            arySrc[index1] = funcs[index3].name;
            checked { ++index1; }
          }
          checked { ++index3; }
        }
      }
      lbFunctions.Items.AddRange((object[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(arySrc, new string[checked (index1 - 1 + 1)]));
      if (index1 == 1)
      {
        lbFunctions.SelectedIndex = 0;
        lbFunctions_Click(null, null);
      }
      lblMatches.Text = "Matches: " + StringType.FromInteger(lbFunctions.Items.Count);
    }

  private void tbFuncNameFilter_TextChanged(object sender, EventArgs e) => ShowFilterMatches();

  private void lbFunctions_Click(object sender, EventArgs e)
  {
      int upperBound = funcs.GetUpperBound(0);
      int index = 0;
      while (index <= upperBound)
      {
        if (ObjectType.ObjTst(funcs[index].name, lbFunctions.SelectedItem, false) == 0)
        {
          tbFuncDecl.Text = funcs[index].comment + "\r\n" + funcs[index].decl;
          break;
        }
        checked { ++index; }
      }
    }

  private void lbFunctions_DoubleClick(object sender, EventArgs e)
  {
      int upperBound = funcs.GetUpperBound(0);
      int index = 0;
      while (index <= upperBound)
      {
        if (ObjectType.ObjTst(funcs[index].name, lbFunctions.SelectedItem, false) == 0)
        {
          if ((ModifierKeys & Keys.Shift) != 0)
            tbGeneric.SelectedText = funcs[index].decl;
          else
            tbGeneric.SelectedText = funcs[index].name + "(";
          tbGeneric.Focus();
          break;
        }
        checked { ++index; }
      }
    }

  private void lbFunctions_SelectedIndexChanged(object sender, EventArgs e) => lbFunctions_Click(null, null);

  private void tbGeneric_GotFocus(object sender, EventArgs e)
  {
      miCut.Enabled = true;
      miCopy.Enabled = true;
      miPaste.Enabled = true;
    }

  private void tbGeneric_LostFocus(object sender, EventArgs e)
  {
      miCut.Enabled = false;
      miCopy.Enabled = false;
      miPaste.Enabled = false;
    }

  private void tbGeneric_MouseDown(object sender, MouseEventArgs e)
  {
      if (e.Button != MouseButtons.Right || tbGeneric.SelectionLength == 0)
        return;
      object o1 = sender;
      object[] objArray1 = new object[1];
      object[] objArray2 = objArray1;
      object o2 = sender;
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
      Point point = (Point) instance;
      cmText.Show((Control) sender, new Point(point.X, point.Y));
    }

  private void cmiShowDefinition_Click(object sender, EventArgs e) => tbFuncNameFilter.Text = tbGeneric.SelectedText;

  public struct func
  {
    public string comment;
    public string decl;
    public string name;
  }
}