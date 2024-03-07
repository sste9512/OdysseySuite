// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmUTT_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTT_Editor : frmParent
{
  [AccessedThroughProperty("nudTrapDetectDC")]
  private NumericUpDown _nudTrapDetectDC;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("nudDisarmDC")]
  private NumericUpDown _nudDisarmDC;
  [AccessedThroughProperty("btnEditScriptHeartbeat")]
  private Button _btnEditScriptHeartbeat;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("btnEditScriptUserDefine")]
  private Button _btnEditScriptUserDefine;
  [AccessedThroughProperty("chkbTrapDetectable")]
  private CheckBox _chkbTrapDetectable;
  [AccessedThroughProperty("chkbTrapDisarmable")]
  private CheckBox _chkbTrapDisarmable;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("TabPageTrap")]
  private TabPage _TabPageTrap;
  [AccessedThroughProperty("TabPageComments")]
  private TabPage _TabPageComments;
  [AccessedThroughProperty("lblTrapDetectable")]
  private Label _lblTrapDetectable;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("nudTrapType")]
  private NumericUpDown _nudTrapType;
  [AccessedThroughProperty("btnEditScriptOnExit")]
  private Button _btnEditScriptOnExit;
  [AccessedThroughProperty("tbOnTrapTriggered")]
  private TextBox _tbOnTrapTriggered;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("btnEditScriptOnEnter")]
  private Button _btnEditScriptOnEnter;
  [AccessedThroughProperty("cmbxType")]
  private ComboBox _cmbxType;
  [AccessedThroughProperty("TabPageScripts")]
  private TabPage _TabPageScripts;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label41")]
  private Label _Label41;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("chkbTrapFlag")]
  private CheckBox _chkbTrapFlag;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("tbComment")]
  private TextBox _tbComment;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("tbName")]
  private TextBox _tbName;
  [AccessedThroughProperty("tbKeyName")]
  private TextBox _tbKeyName;
  [AccessedThroughProperty("cmbxFaction")]
  private ComboBox _cmbxFaction;
  [AccessedThroughProperty("tbCursor")]
  private TextBox _tbCursor;
  [AccessedThroughProperty("TabPageBasic")]
  private TabPage _TabPageBasic;
  [AccessedThroughProperty("tbScriptOnExit")]
  private TextBox _tbScriptOnExit;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("tbScriptOnEnter")]
  private TextBox _tbScriptOnEnter;
  [AccessedThroughProperty("tbScriptHeartbeat")]
  private TextBox _tbScriptHeartbeat;
  [AccessedThroughProperty("tbScriptUserDefine")]
  private TextBox _tbScriptUserDefine;
  [AccessedThroughProperty("chkbTrapOneShot")]
  private CheckBox _chkbTrapOneShot;
  [AccessedThroughProperty("chkbAutoRemoveKey")]
  private CheckBox _chkbAutoRemoveKey;
  [AccessedThroughProperty("btnEditOnClick")]
  private Button _btnEditOnClick;
  [AccessedThroughProperty("tbTemplateResRef")]
  private TextBox _tbTemplateResRef;
  [AccessedThroughProperty("tbOnDisarm")]
  private TextBox _tbOnDisarm;
  [AccessedThroughProperty("Label45")]
  private Label _Label45;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("btnSetNameLang")]
  private Button _btnSetNameLang;
  [AccessedThroughProperty("tbOnClick")]
  private TextBox _tbOnClick;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnEditOnDisarm")]
  private Button _btnEditOnDisarm;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("btnEditOnTrapTriggered")]
  private Button _btnEditOnTrapTriggered;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label57")]
  private Label _Label57;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblCloseLockDC")]
  private Label _lblCloseLockDC;
  private IContainer components;
  public clsUTT UTT;
  public clsDialogTlk g_clsDialogTlk;
  private int NameLang;
  private bool ComboBoxSettingError;
  private bool m_bSaveGameMode;

  public frmUTT_Editor()
  {
      Load += new EventHandler(frmUTT_Editor_Load);
      Closing += new CancelEventHandler(frmUTT_Editor_Closing);
      ComboBoxSettingError = false;
      m_bSaveGameMode = false;
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TabControl TabControl1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabControl1 == null)
          ;
        _TabControl1 = value;
        if (_TabControl1 == null)
          ;
      }
    get => _TabControl1;
  }

  internal virtual TextBox tbTag
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTag == null)
          ;
        _tbTag = value;
        if (_tbTag == null)
          ;
      }
    get => _tbTag;
  }

  internal virtual Label Label2
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label2 == null)
          ;
        _Label2 = value;
        if (_Label2 == null)
          ;
      }
    get => _Label2;
  }

  internal virtual TextBox tbTemplateResRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTemplateResRef == null)
          ;
        _tbTemplateResRef = value;
        if (_tbTemplateResRef == null)
          ;
      }
    get => _tbTemplateResRef;
  }

  internal virtual Label Label57
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label57 == null)
          ;
        _Label57 = value;
        if (_Label57 == null)
          ;
      }
    get => _Label57;
  }

  internal virtual Label Label1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 == null)
          ;
      }
    get => _Label1;
  }

  internal virtual Label Label35
  {
    get => _Label35;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label35 == null)
          ;
        _Label35 = value;
        if (_Label35 == null)
          ;
      }
  }

  internal virtual TextBox tbOnDisarm
  {
    get => _tbOnDisarm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDisarm == null)
          ;
        _tbOnDisarm = value;
        if (_tbOnDisarm == null)
          ;
      }
  }

  internal virtual Label Label41
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label41 == null)
          ;
        _Label41 = value;
        if (_Label41 == null)
          ;
      }
    get => _Label41;
  }

  internal virtual TextBox tbOnTrapTriggered
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnTrapTriggered == null)
          ;
        _tbOnTrapTriggered = value;
        if (_tbOnTrapTriggered == null)
          ;
      }
    get => _tbOnTrapTriggered;
  }

  internal virtual TextBox tbOnClick
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnClick == null)
          ;
        _tbOnClick = value;
        if (_tbOnClick == null)
          ;
      }
    get => _tbOnClick;
  }

  internal virtual Label Label9
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label9 == null)
          ;
        _Label9 = value;
        if (_Label9 == null)
          ;
      }
    get => _Label9;
  }

  internal virtual TextBox tbScriptUserDefine
  {
    get => _tbScriptUserDefine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbScriptUserDefine == null)
          ;
        _tbScriptUserDefine = value;
        if (_tbScriptUserDefine == null)
          ;
      }
  }

  internal virtual Label Label45
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label45 == null)
          ;
        _Label45 = value;
        if (_Label45 == null)
          ;
      }
    get => _Label45;
  }

  internal virtual TabPage TabPageComments
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageComments == null)
          ;
        _TabPageComments = value;
        if (_TabPageComments == null)
          ;
      }
    get => _TabPageComments;
  }

  internal virtual TextBox tbComment
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbComment == null)
          ;
        _tbComment = value;
        if (_tbComment == null)
          ;
      }
    get => _tbComment;
  }

  internal virtual TextBox tbScriptHeartbeat
  {
    get => _tbScriptHeartbeat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbScriptHeartbeat == null)
          ;
        _tbScriptHeartbeat = value;
        if (_tbScriptHeartbeat == null)
          ;
      }
  }

  internal virtual Label Label39
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label39 == null)
          ;
        _Label39 = value;
        if (_Label39 == null)
          ;
      }
    get => _Label39;
  }

  internal virtual Label Label40
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label40 == null)
          ;
        _Label40 = value;
        if (_Label40 == null)
          ;
      }
    get => _Label40;
  }

  internal virtual TextBox tbScriptOnEnter
  {
    get => _tbScriptOnEnter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbScriptOnEnter == null)
          ;
        _tbScriptOnEnter = value;
        if (_tbScriptOnEnter == null)
          ;
      }
  }

  internal virtual Label Label3
  {
    get => _Label3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 == null)
          ;
      }
  }

  internal virtual TextBox tbScriptOnExit
  {
    get => _tbScriptOnExit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbScriptOnExit == null)
          ;
        _tbScriptOnExit = value;
        if (_tbScriptOnExit == null)
          ;
      }
  }

  internal virtual Label lblCloseLockDC
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblCloseLockDC == null)
          ;
        _lblCloseLockDC = value;
        if (_lblCloseLockDC == null)
          ;
      }
    get => _lblCloseLockDC;
  }

  internal virtual Label Label4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label4 == null)
          ;
        _Label4 = value;
        if (_Label4 == null)
          ;
      }
    get => _Label4;
  }

  internal virtual Label Label5
  {
    get => _Label5;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 == null)
          ;
      }
  }

  internal virtual Label Label6
  {
    get => _Label6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 == null)
          ;
      }
  }

  internal virtual Label Label7
  {
    get => _Label7;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label7 == null)
          ;
        _Label7 = value;
        if (_Label7 == null)
          ;
      }
  }

  internal virtual Label Label8
  {
    get => _Label8;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label8 == null)
          ;
        _Label8 = value;
        if (_Label8 == null)
          ;
      }
  }

  internal virtual Button btnSave
  {
    get => _btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSave != null)
          _btnSave.Click -= new EventHandler(btnSave_Click);
        _btnSave = value;
        if (_btnSave == null)
          return;
        _btnSave.Click += new EventHandler(btnSave_Click);
      }
  }

  internal virtual Button btnCancel
  {
    get => _btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel != null)
          _btnCancel.Click -= new EventHandler(btnCancel_Click);
        _btnCancel = value;
        if (_btnCancel == null)
          return;
        _btnCancel.Click += new EventHandler(btnCancel_Click);
      }
  }

  internal virtual TabPage TabPageBasic
  {
    get => _TabPageBasic;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageBasic == null)
          ;
        _TabPageBasic = value;
        if (_TabPageBasic == null)
          ;
      }
  }

  internal virtual TabPage TabPageScripts
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageScripts == null)
          ;
        _TabPageScripts = value;
        if (_TabPageScripts == null)
          ;
      }
    get => _TabPageScripts;
  }

  internal virtual TabPage TabPageTrap
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageTrap == null)
          ;
        _TabPageTrap = value;
        if (_TabPageTrap == null)
          ;
      }
    get => _TabPageTrap;
  }

  internal virtual Label Label10
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label10 == null)
          ;
        _Label10 = value;
        if (_Label10 == null)
          ;
      }
    get => _Label10;
  }

  internal virtual TextBox tbName
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbName == null)
          ;
        _tbName = value;
        if (_tbName == null)
          ;
      }
    get => _tbName;
  }

  internal virtual Label Label11
  {
    get => _Label11;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label11 == null)
          ;
        _Label11 = value;
        if (_Label11 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudDisarmDC
  {
    get => _nudDisarmDC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudDisarmDC == null)
          ;
        _nudDisarmDC = value;
        if (_nudDisarmDC == null)
          ;
      }
  }

  internal virtual NumericUpDown nudTrapDetectDC
  {
    get => _nudTrapDetectDC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTrapDetectDC == null)
          ;
        _nudTrapDetectDC = value;
        if (_nudTrapDetectDC == null)
          ;
      }
  }

  internal virtual Label lblTrapDetectable
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblTrapDetectable == null)
          ;
        _lblTrapDetectable = value;
        if (_lblTrapDetectable == null)
          ;
      }
    get => _lblTrapDetectable;
  }

  internal virtual NumericUpDown nudTrapType
  {
    get => _nudTrapType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTrapType == null)
          ;
        _nudTrapType = value;
        if (_nudTrapType == null)
          ;
      }
  }

  internal virtual CheckBox chkbTrapDetectable
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTrapDetectable == null)
          ;
        _chkbTrapDetectable = value;
        if (_chkbTrapDetectable == null)
          ;
      }
    get => _chkbTrapDetectable;
  }

  internal virtual CheckBox chkbTrapDisarmable
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTrapDisarmable == null)
          ;
        _chkbTrapDisarmable = value;
        if (_chkbTrapDisarmable == null)
          ;
      }
    get => _chkbTrapDisarmable;
  }

  internal virtual TextBox tbKeyName
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbKeyName == null)
          ;
        _tbKeyName = value;
        if (_tbKeyName == null)
          ;
      }
    get => _tbKeyName;
  }

  internal virtual Label Label12
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label12 == null)
          ;
        _Label12 = value;
        if (_Label12 == null)
          ;
      }
    get => _Label12;
  }

  internal virtual Button btnSetNameLang
  {
    get => _btnSetNameLang;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetNameLang != null)
          _btnSetNameLang.Click -= new EventHandler(btnSetNameLang_Click);
        _btnSetNameLang = value;
        if (_btnSetNameLang == null)
          return;
        _btnSetNameLang.Click += new EventHandler(btnSetNameLang_Click);
      }
  }

  internal virtual CheckBox chkbAutoRemoveKey
  {
    get => _chkbAutoRemoveKey;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbAutoRemoveKey == null)
          ;
        _chkbAutoRemoveKey = value;
        if (_chkbAutoRemoveKey == null)
          ;
      }
  }

  internal virtual Label Label13
  {
    get => _Label13;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label13 == null)
          ;
        _Label13 = value;
        if (_Label13 == null)
          ;
      }
  }

  internal virtual Button btnDebug
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnDebug != null)
          _btnDebug.Click -= new EventHandler(btnDebug_Click);
        _btnDebug = value;
        if (_btnDebug == null)
          return;
        _btnDebug.Click += new EventHandler(btnDebug_Click);
      }
    get => _btnDebug;
  }

  internal virtual Label Label14
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label14 == null)
          ;
        _Label14 = value;
        if (_Label14 == null)
          ;
      }
    get => _Label14;
  }

  internal virtual TextBox tbCursor
  {
    get => _tbCursor;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbCursor == null)
          ;
        _tbCursor = value;
        if (_tbCursor == null)
          ;
      }
  }

  internal virtual CheckBox chkbTrapFlag
  {
    get => _chkbTrapFlag;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTrapFlag == null)
          ;
        _chkbTrapFlag = value;
        if (_chkbTrapFlag == null)
          ;
      }
  }

  internal virtual CheckBox chkbTrapOneShot
  {
    get => _chkbTrapOneShot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTrapOneShot == null)
          ;
        _chkbTrapOneShot = value;
        if (_chkbTrapOneShot == null)
          ;
      }
  }

  internal virtual Label Label15
  {
    get => _Label15;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label15 == null)
          ;
        _Label15 = value;
        if (_Label15 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxFaction
  {
    get => _cmbxFaction;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxFaction == null)
          ;
        _cmbxFaction = value;
        if (_cmbxFaction == null)
          ;
      }
  }

  internal virtual ComboBox cmbxType
  {
    get => _cmbxType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxType != null)
          _cmbxType.SelectedIndexChanged -= new EventHandler(cmbxType_SelectedIndexChanged);
        _cmbxType = value;
        if (_cmbxType == null)
          return;
        _cmbxType.SelectedIndexChanged += new EventHandler(cmbxType_SelectedIndexChanged);
      }
  }

  internal virtual Button btnEditScriptOnEnter
  {
    get => _btnEditScriptOnEnter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditScriptOnEnter != null)
          _btnEditScriptOnEnter.Click -= new EventHandler(btnEditScript_Click);
        _btnEditScriptOnEnter = value;
        if (_btnEditScriptOnEnter == null)
          return;
        _btnEditScriptOnEnter.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditScriptOnExit
  {
    get => _btnEditScriptOnExit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditScriptOnExit != null)
          _btnEditScriptOnExit.Click -= new EventHandler(btnEditScript_Click);
        _btnEditScriptOnExit = value;
        if (_btnEditScriptOnExit == null)
          return;
        _btnEditScriptOnExit.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditScriptUserDefine
  {
    get => _btnEditScriptUserDefine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditScriptUserDefine != null)
          _btnEditScriptUserDefine.Click -= new EventHandler(btnEditScript_Click);
        _btnEditScriptUserDefine = value;
        if (_btnEditScriptUserDefine == null)
          return;
        _btnEditScriptUserDefine.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditScriptHeartbeat
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditScriptHeartbeat != null)
          _btnEditScriptHeartbeat.Click -= new EventHandler(btnEditScript_Click);
        _btnEditScriptHeartbeat = value;
        if (_btnEditScriptHeartbeat == null)
          return;
        _btnEditScriptHeartbeat.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditScriptHeartbeat;
  }

  internal virtual Button btnEditOnTrapTriggered
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnTrapTriggered != null)
          _btnEditOnTrapTriggered.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnTrapTriggered = value;
        if (_btnEditOnTrapTriggered == null)
          return;
        _btnEditOnTrapTriggered.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnTrapTriggered;
  }

  internal virtual Button btnEditOnDisarm
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDisarm != null)
          _btnEditOnDisarm.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDisarm = value;
        if (_btnEditOnDisarm == null)
          return;
        _btnEditOnDisarm.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnDisarm;
  }

  internal virtual Button btnEditOnClick
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnClick != null)
          _btnEditOnClick.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnClick = value;
        if (_btnEditOnClick == null)
          return;
        _btnEditOnClick.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnClick;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      TabControl1 = new TabControl();
      TabPageBasic = new TabPage();
      cmbxType = new ComboBox();
      cmbxFaction = new ComboBox();
      btnSetNameLang = new Button();
      tbName = new TextBox();
      Label11 = new Label();
      tbTemplateResRef = new TextBox();
      Label57 = new Label();
      tbTag = new TextBox();
      Label2 = new Label();
      Label1 = new Label();
      Label10 = new Label();
      Label14 = new Label();
      tbCursor = new TextBox();
      TabPageScripts = new TabPage();
      btnEditScriptOnEnter = new Button();
      tbScriptHeartbeat = new TextBox();
      Label39 = new Label();
      Label40 = new Label();
      tbScriptOnEnter = new TextBox();
      Label3 = new Label();
      tbScriptOnExit = new TextBox();
      tbScriptUserDefine = new TextBox();
      Label45 = new Label();
      Label35 = new Label();
      tbOnDisarm = new TextBox();
      Label41 = new Label();
      tbOnTrapTriggered = new TextBox();
      tbOnClick = new TextBox();
      Label9 = new Label();
      btnEditScriptOnExit = new Button();
      btnEditScriptUserDefine = new Button();
      btnEditScriptHeartbeat = new Button();
      btnEditOnTrapTriggered = new Button();
      btnEditOnDisarm = new Button();
      btnEditOnClick = new Button();
      TabPageTrap = new TabPage();
      Label15 = new Label();
      chkbAutoRemoveKey = new CheckBox();
      tbKeyName = new TextBox();
      chkbTrapDisarmable = new CheckBox();
      chkbTrapDetectable = new CheckBox();
      Label6 = new Label();
      Label7 = new Label();
      nudDisarmDC = new NumericUpDown();
      Label4 = new Label();
      Label5 = new Label();
      nudTrapDetectDC = new NumericUpDown();
      lblCloseLockDC = new Label();
      lblTrapDetectable = new Label();
      nudTrapType = new NumericUpDown();
      Label8 = new Label();
      Label12 = new Label();
      Label13 = new Label();
      chkbTrapFlag = new CheckBox();
      chkbTrapOneShot = new CheckBox();
      TabPageComments = new TabPage();
      tbComment = new TextBox();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      btnDebug = new Button();
      TabControl1.SuspendLayout();
      TabPageBasic.SuspendLayout();
      TabPageScripts.SuspendLayout();
      TabPageTrap.SuspendLayout();
      nudDisarmDC.BeginInit();
      nudTrapDetectDC.BeginInit();
      nudTrapType.BeginInit();
      TabPageComments.SuspendLayout();
      SuspendLayout();
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(TabPageBasic);
      TabControl1.Controls.Add(TabPageScripts);
      TabControl1.Controls.Add(TabPageTrap);
      TabControl1.Controls.Add(TabPageComments);
      TabControl tabControl1_1 = TabControl1;
      Point point1 = new Point(16, 8);
      Point point2 = point1;
      tabControl1_1.Location = point2;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = TabControl1;
      Size size1 = new Size(448, 344);
      Size size2 = size1;
      tabControl1_2.Size = size2;
      TabControl1.SizeMode = TabSizeMode.FillToRight;
      TabControl1.TabIndex = 0;
      TabPageBasic.Controls.Add(cmbxType);
      TabPageBasic.Controls.Add(cmbxFaction);
      TabPageBasic.Controls.Add(btnSetNameLang);
      TabPageBasic.Controls.Add(tbName);
      TabPageBasic.Controls.Add(Label11);
      TabPageBasic.Controls.Add(tbTemplateResRef);
      TabPageBasic.Controls.Add(Label57);
      TabPageBasic.Controls.Add(tbTag);
      TabPageBasic.Controls.Add(Label2);
      TabPageBasic.Controls.Add(Label1);
      TabPageBasic.Controls.Add(Label10);
      TabPageBasic.Controls.Add(Label14);
      TabPageBasic.Controls.Add(tbCursor);
      TabPage tabPageBasic1 = TabPageBasic;
      point1 = new Point(4, 22);
      Point point3 = point1;
      ((Control) tabPageBasic1).Location = point3;
      TabPageBasic.Name = "TabPageBasic";
      TabPage tabPageBasic2 = TabPageBasic;
      size1 = new Size(440, 318);
      Size size3 = size1;
      tabPageBasic2.Size = size3;
      TabPageBasic.TabIndex = 0;
      TabPageBasic.Text = "Basic";
      cmbxType.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxType.Items.AddRange(new object[3]
      {
        "Generic",
        "Transition",
        "Trap"
      });
      ComboBox cmbxType1 = cmbxType;
      point1 = new Point(160, 152);
      Point point4 = point1;
      cmbxType1.Location = point4;
      cmbxType.Name = "cmbxType";
      ComboBox cmbxType2 = cmbxType;
      size1 = new Size(121, 21);
      Size size4 = size1;
      cmbxType2.Size = size4;
      cmbxType.TabIndex = 10;
      cmbxFaction.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxFaction1 = cmbxFaction;
      point1 = new Point(160, 120);
      Point point5 = point1;
      cmbxFaction1.Location = point5;
      cmbxFaction.Name = "cmbxFaction";
      ComboBox cmbxFaction2 = cmbxFaction;
      size1 = new Size(120, 21);
      Size size5 = size1;
      cmbxFaction2.Size = size5;
      cmbxFaction.TabIndex = 9;
      Button btnSetNameLang1 = btnSetNameLang;
      point1 = new Point(344, 56);
      Point point6 = point1;
      btnSetNameLang1.Location = point6;
      btnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = btnSetNameLang;
      size1 = new Size(88, 23);
      Size size6 = size1;
      btnSetNameLang2.Size = size6;
      btnSetNameLang.TabIndex = 1;
      btnSetNameLang.Text = "Set Language";
      TextBox tbName1 = tbName;
      point1 = new Point(160, 56);
      Point point7 = point1;
      tbName1.Location = point7;
      tbName.Name = "tbName";
      TextBox tbName2 = tbName;
      size1 = new Size(176, 20);
      Size size7 = size1;
      tbName2.Size = size7;
      tbName.TabIndex = 0;
      tbName.Text = "";
      Label label11_1 = Label11;
      point1 = new Point(48, 56);
      Point point8 = point1;
      label11_1.Location = point8;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(100, 16);
      Size size8 = size1;
      label11_2.Size = size8;
      Label11.TabIndex = 8;
      Label11.Text = "Name";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      tbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbTemplateResRef1 = tbTemplateResRef;
      point1 = new Point(160, 24);
      Point point9 = point1;
      tbTemplateResRef1.Location = point9;
      tbTemplateResRef.MaxLength = 16;
      tbTemplateResRef.Name = "tbTemplateResRef";
      TextBox tbTemplateResRef2 = tbTemplateResRef;
      size1 = new Size(176, 20);
      Size size9 = size1;
      tbTemplateResRef2.Size = size9;
      tbTemplateResRef.TabIndex = 6;
      tbTemplateResRef.Text = "";
      Label label57_1 = Label57;
      point1 = new Point(48, 24);
      Point point10 = point1;
      label57_1.Location = point10;
      Label57.Name = "Label57";
      Label label57_2 = Label57;
      size1 = new Size(100, 18);
      Size size10 = size1;
      label57_2.Size = size10;
      Label57.TabIndex = 5;
      Label57.Text = "Template ResRef";
      Label57.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbTag1 = tbTag;
      point1 = new Point(160, 88);
      Point point11 = point1;
      tbTag1.Location = point11;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(176, 20);
      Size size11 = size1;
      tbTag2.Size = size11;
      tbTag.TabIndex = 2;
      tbTag.Text = "";
      Label label2_1 = Label2;
      point1 = new Point(48, 88);
      Point point12 = point1;
      label2_1.Location = point12;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size12 = size1;
      label2_2.Size = size12;
      Label2.TabIndex = 2;
      Label2.Text = "Tag";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      Label label1_1 = Label1;
      point1 = new Point(48, 120);
      Point point13 = point1;
      label1_1.Location = point13;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(48, 16);
      Size size13 = size1;
      label1_2.Size = size13;
      Label1.TabIndex = 2;
      Label1.Text = "Faction";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      Label label10_1 = Label10;
      point1 = new Point(48, 152);
      Point point14 = point1;
      label10_1.Location = point14;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(48, 16);
      Size size14 = size1;
      label10_2.Size = size14;
      Label10.TabIndex = 2;
      Label10.Text = "Type";
      Label10.TextAlign = ContentAlignment.MiddleLeft;
      Label label14_1 = Label14;
      point1 = new Point(48, 184);
      Point point15 = point1;
      label14_1.Location = point15;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(48, 16);
      Size size15 = size1;
      label14_2.Size = size15;
      Label14.TabIndex = 2;
      Label14.Text = "Cursor";
      Label14.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbCursor1 = tbCursor;
      point1 = new Point(160, 184);
      Point point16 = point1;
      tbCursor1.Location = point16;
      tbCursor.Name = "tbCursor";
      TextBox tbCursor2 = tbCursor;
      size1 = new Size(30, 20);
      Size size16 = size1;
      tbCursor2.Size = size16;
      tbCursor.TabIndex = 4;
      tbCursor.Text = "";
      TabPageScripts.Controls.Add(btnEditScriptOnEnter);
      TabPageScripts.Controls.Add(tbScriptHeartbeat);
      TabPageScripts.Controls.Add(Label39);
      TabPageScripts.Controls.Add(Label40);
      TabPageScripts.Controls.Add(tbScriptOnEnter);
      TabPageScripts.Controls.Add(Label3);
      TabPageScripts.Controls.Add(tbScriptOnExit);
      TabPageScripts.Controls.Add(tbScriptUserDefine);
      TabPageScripts.Controls.Add(Label45);
      TabPageScripts.Controls.Add(Label35);
      TabPageScripts.Controls.Add(tbOnDisarm);
      TabPageScripts.Controls.Add(Label41);
      TabPageScripts.Controls.Add(tbOnTrapTriggered);
      TabPageScripts.Controls.Add(tbOnClick);
      TabPageScripts.Controls.Add(Label9);
      TabPageScripts.Controls.Add(btnEditScriptOnExit);
      TabPageScripts.Controls.Add(btnEditScriptUserDefine);
      TabPageScripts.Controls.Add(btnEditScriptHeartbeat);
      TabPageScripts.Controls.Add(btnEditOnTrapTriggered);
      TabPageScripts.Controls.Add(btnEditOnDisarm);
      TabPageScripts.Controls.Add(btnEditOnClick);
      TabPage tabPageScripts1 = TabPageScripts;
      point1 = new Point(4, 22);
      Point point17 = point1;
      ((Control) tabPageScripts1).Location = point17;
      TabPageScripts.Name = "TabPageScripts";
      TabPage tabPageScripts2 = TabPageScripts;
      size1 = new Size(440, 318);
      Size size17 = size1;
      tabPageScripts2.Size = size17;
      TabPageScripts.TabIndex = 1;
      TabPageScripts.Text = "Scripts";
      Button editScriptOnEnter1 = btnEditScriptOnEnter;
      point1 = new Point(392, 152);
      Point point18 = point1;
      editScriptOnEnter1.Location = point18;
      btnEditScriptOnEnter.Name = "btnEditScriptOnEnter";
      Button editScriptOnEnter2 = btnEditScriptOnEnter;
      size1 = new Size(32, 23);
      Size size18 = size1;
      editScriptOnEnter2.Size = size18;
      btnEditScriptOnEnter.TabIndex = 9;
      btnEditScriptOnEnter.Text = "Edit";
      btnEditScriptOnEnter.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbScriptHeartbeat1 = tbScriptHeartbeat;
      point1 = new Point(168, 120);
      Point point19 = point1;
      tbScriptHeartbeat1.Location = point19;
      tbScriptHeartbeat.Name = "tbScriptHeartbeat";
      TextBox tbScriptHeartbeat2 = tbScriptHeartbeat;
      size1 = new Size(204, 20);
      Size size19 = size1;
      tbScriptHeartbeat2.Size = size19;
      tbScriptHeartbeat.TabIndex = 6;
      tbScriptHeartbeat.Text = "";
      Label label39_1 = Label39;
      point1 = new Point(48, 120);
      Point point20 = point1;
      label39_1.Location = point20;
      Label39.Name = "Label39";
      Label label39_2 = Label39;
      size1 = new Size(112, 18);
      Size size20 = size1;
      label39_2.Size = size20;
      Label39.TabIndex = 39;
      Label39.Text = "ScriptHeartbeat";
      Label39.TextAlign = ContentAlignment.MiddleLeft;
      Label label40_1 = Label40;
      point1 = new Point(48, 152);
      Point point21 = point1;
      label40_1.Location = point21;
      Label40.Name = "Label40";
      Label label40_2 = Label40;
      size1 = new Size(112, 18);
      Size size21 = size1;
      label40_2.Size = size21;
      Label40.TabIndex = 38;
      Label40.Text = "ScriptOnEnter";
      Label40.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbScriptOnEnter1 = tbScriptOnEnter;
      point1 = new Point(168, 152);
      Point point22 = point1;
      tbScriptOnEnter1.Location = point22;
      tbScriptOnEnter.Name = "tbScriptOnEnter";
      TextBox tbScriptOnEnter2 = tbScriptOnEnter;
      size1 = new Size(204, 20);
      Size size22 = size1;
      tbScriptOnEnter2.Size = size22;
      tbScriptOnEnter.TabIndex = 8;
      tbScriptOnEnter.Text = "";
      Label label3_1 = Label3;
      point1 = new Point(48, 184);
      Point point23 = point1;
      label3_1.Location = point23;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(112, 18);
      Size size23 = size1;
      label3_2.Size = size23;
      Label3.TabIndex = 40;
      Label3.Text = "ScriptOnExit";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbScriptOnExit1 = tbScriptOnExit;
      point1 = new Point(168, 184);
      Point point24 = point1;
      tbScriptOnExit1.Location = point24;
      tbScriptOnExit.Name = "tbScriptOnExit";
      TextBox tbScriptOnExit2 = tbScriptOnExit;
      size1 = new Size(204, 20);
      Size size24 = size1;
      tbScriptOnExit2.Size = size24;
      tbScriptOnExit.TabIndex = 10;
      tbScriptOnExit.Text = "";
      TextBox scriptUserDefine1 = tbScriptUserDefine;
      point1 = new Point(168, 216);
      Point point25 = point1;
      scriptUserDefine1.Location = point25;
      tbScriptUserDefine.Name = "tbScriptUserDefine";
      TextBox scriptUserDefine2 = tbScriptUserDefine;
      size1 = new Size(204, 20);
      Size size25 = size1;
      scriptUserDefine2.Size = size25;
      tbScriptUserDefine.TabIndex = 12;
      tbScriptUserDefine.Text = "";
      Label label45_1 = Label45;
      point1 = new Point(48, 216);
      Point point26 = point1;
      label45_1.Location = point26;
      Label45.Name = "Label45";
      Label label45_2 = Label45;
      size1 = new Size(96, 18);
      Size size26 = size1;
      label45_2.Size = size26;
      Label45.TabIndex = 33;
      Label45.Text = "ScriptUserDefine";
      Label45.TextAlign = ContentAlignment.MiddleLeft;
      Label label35_1 = Label35;
      point1 = new Point(48, 56);
      Point point27 = point1;
      label35_1.Location = point27;
      Label35.Name = "Label35";
      Label label35_2 = Label35;
      size1 = new Size(112, 18);
      Size size27 = size1;
      label35_2.Size = size27;
      Label35.TabIndex = 32;
      Label35.Text = "OnDisarm";
      Label35.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDisarm1 = tbOnDisarm;
      point1 = new Point(168, 56);
      Point point28 = point1;
      tbOnDisarm1.Location = point28;
      tbOnDisarm.Name = "tbOnDisarm";
      TextBox tbOnDisarm2 = tbOnDisarm;
      size1 = new Size(204, 20);
      Size size28 = size1;
      tbOnDisarm2.Size = size28;
      tbOnDisarm.TabIndex = 2;
      tbOnDisarm.Text = "";
      Label label41_1 = Label41;
      point1 = new Point(48, 88);
      Point point29 = point1;
      label41_1.Location = point29;
      Label41.Name = "Label41";
      Label label41_2 = Label41;
      size1 = new Size(112, 18);
      Size size29 = size1;
      label41_2.Size = size29;
      Label41.TabIndex = 31;
      Label41.Text = "OnTrapTriggered";
      Label41.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnTrapTriggered1 = tbOnTrapTriggered;
      point1 = new Point(168, 88);
      Point point30 = point1;
      tbOnTrapTriggered1.Location = point30;
      tbOnTrapTriggered.Name = "tbOnTrapTriggered";
      TextBox tbOnTrapTriggered2 = tbOnTrapTriggered;
      size1 = new Size(204, 20);
      Size size30 = size1;
      tbOnTrapTriggered2.Size = size30;
      tbOnTrapTriggered.TabIndex = 4;
      tbOnTrapTriggered.Text = "";
      TextBox tbOnClick1 = tbOnClick;
      point1 = new Point(168, 24);
      Point point31 = point1;
      tbOnClick1.Location = point31;
      tbOnClick.Name = "tbOnClick";
      TextBox tbOnClick2 = tbOnClick;
      size1 = new Size(204, 20);
      Size size31 = size1;
      tbOnClick2.Size = size31;
      tbOnClick.TabIndex = 0;
      tbOnClick.Text = "";
      Label label9_1 = Label9;
      point1 = new Point(48, 24);
      Point point32 = point1;
      label9_1.Location = point32;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(112, 18);
      Size size32 = size1;
      label9_2.Size = size32;
      Label9.TabIndex = 30;
      Label9.Text = "OnClick";
      Label9.TextAlign = ContentAlignment.MiddleLeft;
      Button editScriptOnExit1 = btnEditScriptOnExit;
      point1 = new Point(392, 184);
      Point point33 = point1;
      editScriptOnExit1.Location = point33;
      btnEditScriptOnExit.Name = "btnEditScriptOnExit";
      Button editScriptOnExit2 = btnEditScriptOnExit;
      size1 = new Size(32, 23);
      Size size33 = size1;
      editScriptOnExit2.Size = size33;
      btnEditScriptOnExit.TabIndex = 11;
      btnEditScriptOnExit.Text = "Edit";
      btnEditScriptOnExit.TextAlign = ContentAlignment.MiddleLeft;
      Button scriptUserDefine3 = btnEditScriptUserDefine;
      point1 = new Point(392, 216);
      Point point34 = point1;
      scriptUserDefine3.Location = point34;
      btnEditScriptUserDefine.Name = "btnEditScriptUserDefine";
      Button scriptUserDefine4 = btnEditScriptUserDefine;
      size1 = new Size(32, 23);
      Size size34 = size1;
      scriptUserDefine4.Size = size34;
      btnEditScriptUserDefine.TabIndex = 13;
      btnEditScriptUserDefine.Text = "Edit";
      btnEditScriptUserDefine.TextAlign = ContentAlignment.MiddleLeft;
      Button editScriptHeartbeat1 = btnEditScriptHeartbeat;
      point1 = new Point(392, 120);
      Point point35 = point1;
      editScriptHeartbeat1.Location = point35;
      btnEditScriptHeartbeat.Name = "btnEditScriptHeartbeat";
      Button editScriptHeartbeat2 = btnEditScriptHeartbeat;
      size1 = new Size(32, 23);
      Size size35 = size1;
      editScriptHeartbeat2.Size = size35;
      btnEditScriptHeartbeat.TabIndex = 7;
      btnEditScriptHeartbeat.Text = "Edit";
      btnEditScriptHeartbeat.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnTrapTriggered1 = btnEditOnTrapTriggered;
      point1 = new Point(392, 88);
      Point point36 = point1;
      editOnTrapTriggered1.Location = point36;
      btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered";
      Button editOnTrapTriggered2 = btnEditOnTrapTriggered;
      size1 = new Size(32, 23);
      Size size36 = size1;
      editOnTrapTriggered2.Size = size36;
      btnEditOnTrapTriggered.TabIndex = 5;
      btnEditOnTrapTriggered.Text = "Edit";
      btnEditOnTrapTriggered.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDisarm1 = btnEditOnDisarm;
      point1 = new Point(392, 56);
      Point point37 = point1;
      btnEditOnDisarm1.Location = point37;
      btnEditOnDisarm.Name = "btnEditOnDisarm";
      Button btnEditOnDisarm2 = btnEditOnDisarm;
      size1 = new Size(32, 23);
      Size size37 = size1;
      btnEditOnDisarm2.Size = size37;
      btnEditOnDisarm.TabIndex = 3;
      btnEditOnDisarm.Text = "Edit";
      btnEditOnDisarm.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnClick1 = btnEditOnClick;
      point1 = new Point(392, 24);
      Point point38 = point1;
      btnEditOnClick1.Location = point38;
      btnEditOnClick.Name = "btnEditOnClick";
      Button btnEditOnClick2 = btnEditOnClick;
      size1 = new Size(32, 23);
      Size size38 = size1;
      btnEditOnClick2.Size = size38;
      btnEditOnClick.TabIndex = 1;
      btnEditOnClick.Text = "Edit";
      btnEditOnClick.TextAlign = ContentAlignment.MiddleLeft;
      TabPageTrap.Controls.Add(Label15);
      TabPageTrap.Controls.Add(chkbAutoRemoveKey);
      TabPageTrap.Controls.Add(tbKeyName);
      TabPageTrap.Controls.Add(chkbTrapDisarmable);
      TabPageTrap.Controls.Add(chkbTrapDetectable);
      TabPageTrap.Controls.Add(Label6);
      TabPageTrap.Controls.Add(Label7);
      TabPageTrap.Controls.Add(nudDisarmDC);
      TabPageTrap.Controls.Add(Label4);
      TabPageTrap.Controls.Add(Label5);
      TabPageTrap.Controls.Add(nudTrapDetectDC);
      TabPageTrap.Controls.Add(lblCloseLockDC);
      TabPageTrap.Controls.Add(lblTrapDetectable);
      TabPageTrap.Controls.Add(nudTrapType);
      TabPageTrap.Controls.Add(Label8);
      TabPageTrap.Controls.Add(Label12);
      TabPageTrap.Controls.Add(Label13);
      TabPageTrap.Controls.Add(chkbTrapFlag);
      TabPageTrap.Controls.Add(chkbTrapOneShot);
      TabPage tabPageTrap1 = TabPageTrap;
      point1 = new Point(4, 22);
      Point point39 = point1;
      ((Control) tabPageTrap1).Location = point39;
      TabPageTrap.Name = "TabPageTrap";
      TabPage tabPageTrap2 = TabPageTrap;
      size1 = new Size(440, 318);
      Size size39 = size1;
      tabPageTrap2.Size = size39;
      TabPageTrap.TabIndex = 9;
      TabPageTrap.Text = "Trap";
      Label label15_1 = Label15;
      point1 = new Point(249, 220);
      Point point40 = point1;
      label15_1.Location = point40;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(168, 20);
      Size size40 = size1;
      label15_2.Size = size40;
      Label15.TabIndex = 28;
      Label15.Text = "This is an index into traps.2da";
      Label15.Visible = false;
      CheckBox chkbAutoRemoveKey1 = chkbAutoRemoveKey;
      point1 = new Point(232, 277);
      Point point41 = point1;
      chkbAutoRemoveKey1.Location = point41;
      chkbAutoRemoveKey.Name = "chkbAutoRemoveKey";
      CheckBox chkbAutoRemoveKey2 = chkbAutoRemoveKey;
      size1 = new Size(24, 24);
      Size size41 = size1;
      chkbAutoRemoveKey2.Size = size41;
      chkbAutoRemoveKey.TabIndex = 8;
      TextBox tbKeyName1 = tbKeyName;
      point1 = new Point(176, 248);
      Point point42 = point1;
      tbKeyName1.Location = point42;
      tbKeyName.Name = "tbKeyName";
      TextBox tbKeyName2 = tbKeyName;
      size1 = new Size(136, 20);
      Size size42 = size1;
      tbKeyName2.Size = size42;
      tbKeyName.TabIndex = 7;
      tbKeyName.Text = "";
      CheckBox chkbTrapDisarmable1 = chkbTrapDisarmable;
      point1 = new Point(192, 85);
      Point point43 = point1;
      chkbTrapDisarmable1.Location = point43;
      chkbTrapDisarmable.Name = "chkbTrapDisarmable";
      CheckBox chkbTrapDisarmable2 = chkbTrapDisarmable;
      size1 = new Size(24, 24);
      Size size43 = size1;
      chkbTrapDisarmable2.Size = size43;
      chkbTrapDisarmable.TabIndex = 2;
      CheckBox chkbTrapDetectable1 = chkbTrapDetectable;
      point1 = new Point(192, 21);
      Point point44 = point1;
      chkbTrapDetectable1.Location = point44;
      chkbTrapDetectable.Name = "chkbTrapDetectable";
      CheckBox chkbTrapDetectable2 = chkbTrapDetectable;
      size1 = new Size(24, 24);
      Size size44 = size1;
      chkbTrapDetectable2.Size = size44;
      chkbTrapDetectable.TabIndex = 0;
      Label label6_1 = Label6;
      point1 = new Point(48, 184);
      Point point45 = point1;
      label6_1.Location = point45;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(88, 16);
      Size size45 = size1;
      label6_2.Size = size45;
      Label6.TabIndex = 26;
      Label6.Text = "TrapOneShot";
      Label6.TextAlign = ContentAlignment.MiddleLeft;
      Label label7_1 = Label7;
      point1 = new Point(48, 152);
      Point point46 = point1;
      label7_1.Location = point46;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(88, 16);
      Size size46 = size1;
      label7_2.Size = size46;
      Label7.TabIndex = 27;
      Label7.Text = "TrapFlag";
      Label7.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudDisarmDc1 = nudDisarmDC;
      point1 = new Point(176, 120);
      Point point47 = point1;
      nudDisarmDc1.Location = point47;
      NumericUpDown nudDisarmDc2 = nudDisarmDC;
      Decimal num1 = new Decimal(new int[4]
      {
        250,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudDisarmDc2.Maximum = num2;
      nudDisarmDC.Name = "nudDisarmDC";
      nudDisarmDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudDisarmDc3 = nudDisarmDC;
      size1 = new Size(48, 20);
      Size size47 = size1;
      nudDisarmDc3.Size = size47;
      nudDisarmDC.TabIndex = 3;
      nudDisarmDC.TextAlign = HorizontalAlignment.Right;
      Label label4_1 = Label4;
      point1 = new Point(48, 120);
      Point point48 = point1;
      label4_1.Location = point48;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(88, 16);
      Size size48 = size1;
      label4_2.Size = size48;
      Label4.TabIndex = 22;
      Label4.Text = "DisarmDC";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      Label label5_1 = Label5;
      point1 = new Point(48, 88);
      Point point49 = point1;
      label5_1.Location = point49;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(88, 16);
      Size size49 = size1;
      label5_2.Size = size49;
      Label5.TabIndex = 23;
      Label5.Text = "TrapDisarmable";
      Label5.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudTrapDetectDc1 = nudTrapDetectDC;
      point1 = new Point(176, 56);
      Point point50 = point1;
      nudTrapDetectDc1.Location = point50;
      NumericUpDown nudTrapDetectDc2 = nudTrapDetectDC;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num3 = num1;
      nudTrapDetectDc2.Maximum = num3;
      nudTrapDetectDC.Name = "nudTrapDetectDC";
      nudTrapDetectDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudTrapDetectDc3 = nudTrapDetectDC;
      size1 = new Size(48, 20);
      Size size50 = size1;
      nudTrapDetectDc3.Size = size50;
      nudTrapDetectDC.TabIndex = 1;
      nudTrapDetectDC.TextAlign = HorizontalAlignment.Right;
      Label lblCloseLockDc1 = lblCloseLockDC;
      point1 = new Point(48, 56);
      Point point51 = point1;
      lblCloseLockDc1.Location = point51;
      lblCloseLockDC.Name = "lblCloseLockDC";
      Label lblCloseLockDc2 = lblCloseLockDC;
      size1 = new Size(88, 16);
      Size size51 = size1;
      lblCloseLockDc2.Size = size51;
      lblCloseLockDC.TabIndex = 18;
      lblCloseLockDC.Text = "TrapDetectDC";
      lblCloseLockDC.TextAlign = ContentAlignment.MiddleLeft;
      Label lblTrapDetectable1 = lblTrapDetectable;
      point1 = new Point(48, 24);
      Point point52 = point1;
      lblTrapDetectable1.Location = point52;
      lblTrapDetectable.Name = "lblTrapDetectable";
      Label lblTrapDetectable2 = lblTrapDetectable;
      size1 = new Size(88, 16);
      Size size52 = size1;
      lblTrapDetectable2.Size = size52;
      lblTrapDetectable.TabIndex = 19;
      lblTrapDetectable.Text = "TrapDetectable";
      lblTrapDetectable.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudTrapType1 = nudTrapType;
      point1 = new Point(176, 216);
      Point point53 = point1;
      nudTrapType1.Location = point53;
      NumericUpDown nudTrapType2 = nudTrapType;
      num1 = new Decimal(new int[4]{ 13, 0, 0, 0 });
      Decimal num4 = num1;
      nudTrapType2.Maximum = num4;
      nudTrapType.Name = "nudTrapType";
      nudTrapType.RightToLeft = RightToLeft.No;
      NumericUpDown nudTrapType3 = nudTrapType;
      size1 = new Size(48, 20);
      Size size53 = size1;
      nudTrapType3.Size = size53;
      nudTrapType.TabIndex = 6;
      nudTrapType.TextAlign = HorizontalAlignment.Right;
      Label label8_1 = Label8;
      point1 = new Point(48, 216);
      Point point54 = point1;
      label8_1.Location = point54;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(88, 16);
      Size size54 = size1;
      label8_2.Size = size54;
      Label8.TabIndex = 26;
      Label8.Text = "TrapType";
      Label8.TextAlign = ContentAlignment.MiddleLeft;
      Label label12_1 = Label12;
      point1 = new Point(48, 248);
      Point point55 = point1;
      label12_1.Location = point55;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(88, 16);
      Size size55 = size1;
      label12_2.Size = size55;
      Label12.TabIndex = 26;
      Label12.Text = "KeyName";
      Label12.TextAlign = ContentAlignment.MiddleLeft;
      Label label13_1 = Label13;
      point1 = new Point(48, 280);
      Point point56 = point1;
      label13_1.Location = point56;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(184, 16);
      Size size56 = size1;
      label13_2.Size = size56;
      Label13.TabIndex = 26;
      Label13.Text = "Automatically remove key after use";
      Label13.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbTrapFlag1 = chkbTrapFlag;
      point1 = new Point(192, 152);
      Point point57 = point1;
      chkbTrapFlag1.Location = point57;
      chkbTrapFlag.Name = "chkbTrapFlag";
      CheckBox chkbTrapFlag2 = chkbTrapFlag;
      size1 = new Size(24, 24);
      Size size57 = size1;
      chkbTrapFlag2.Size = size57;
      chkbTrapFlag.TabIndex = 2;
      CheckBox chkbTrapOneShot1 = chkbTrapOneShot;
      point1 = new Point(192, 184);
      Point point58 = point1;
      chkbTrapOneShot1.Location = point58;
      chkbTrapOneShot.Name = "chkbTrapOneShot";
      CheckBox chkbTrapOneShot2 = chkbTrapOneShot;
      size1 = new Size(24, 24);
      Size size58 = size1;
      chkbTrapOneShot2.Size = size58;
      chkbTrapOneShot.TabIndex = 2;
      TabPageComments.Controls.Add(tbComment);
      TabPage tabPageComments1 = TabPageComments;
      point1 = new Point(4, 22);
      Point point59 = point1;
      ((Control) tabPageComments1).Location = point59;
      TabPageComments.Name = "TabPageComments";
      TabPage tabPageComments2 = TabPageComments;
      size1 = new Size(440, 318);
      Size size59 = size1;
      tabPageComments2.Size = size59;
      TabPageComments.TabIndex = 8;
      TabPageComments.Text = "Comments";
      tbComment.Dock = DockStyle.Fill;
      TextBox tbComment1 = tbComment;
      point1 = new Point(0, 0);
      Point point60 = point1;
      tbComment1.Location = point60;
      tbComment.Multiline = true;
      tbComment.Name = "tbComment";
      TextBox tbComment2 = tbComment;
      size1 = new Size(440, 318);
      Size size60 = size1;
      tbComment2.Size = size60;
      tbComment.TabIndex = 0;
      tbComment.Text = "";
      Button btnSave = this.btnSave;
      point1 = new Point(288, 368);
      Point point61 = point1;
      btnSave.Location = point61;
      this.btnSave.Name = "btnSave";
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "&Save";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(384, 368);
      Point point62 = point1;
      btnCancel.Location = point62;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "&Cancel";
      btnDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point63 = point1;
      btnDebug1.Location = point63;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size61 = size1;
      btnDebug2.Size = size61;
      btnDebug.TabIndex = 17;
      btnDebug.TabStop = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(480, 405);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(this.btnSave);
      Controls.Add(this.btnCancel);
      Controls.Add(TabControl1);
      Name = nameof (frmUTT_Editor);
      Text = "Trigger Editor - KotOR ";
      TabControl1.ResumeLayout(false);
      TabPageBasic.ResumeLayout(false);
      TabPageScripts.ResumeLayout(false);
      TabPageTrap.ResumeLayout(false);
      nudDisarmDC.EndInit();
      nudTrapDetectDC.EndInit();
      nudTrapType.EndInit();
      TabPageComments.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmUTT_Editor(
    clsUTT UTTClass,
    int KotorVerIndex,
    bool IsDirectEdit = false,
    string EditingPath = "")
    : this()
  {
      if (IsDirectEdit)
      {
        m_bSaveGameMode = true;
        MEditingFilePath = EditingPath;
      }
      MDefaultTitleText = "Trigger Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      if (KotorVerIndex == 1)
        CustomizeForKotorII();
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      UTT = UTTClass;
      KotorVersionIndex = KotorVerIndex;
      Setup();
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  public void Setup()
  {
      BuildComboBoxes();
      UTT.SetTextBoxToNodeValue(tbTemplateResRef, "TemplateResRef");
      UTT.SetTextBoxFromCExoLocStringNodeValue(tbName, "LocalizedName");
      UTT.SetTextBoxToNodeValue(tbTag, "Tag");
      UTT.SetTextBoxToNodeValue(tbCursor, "Cursor");
      UTT.SetTextBoxToNodeValue(tbOnClick, "OnClick");
      UTT.SetTextBoxToNodeValue(tbOnDisarm, "OnDisarm");
      UTT.SetTextBoxToNodeValue(tbOnTrapTriggered, "OnTrapTriggered");
      UTT.SetTextBoxToNodeValue(tbScriptHeartbeat, "ScriptHeartbeat");
      UTT.SetTextBoxToNodeValue(tbScriptOnEnter, "ScriptOnEnter");
      UTT.SetTextBoxToNodeValue(tbScriptOnExit, "ScriptOnExit");
      UTT.SetTextBoxToNodeValue(tbScriptUserDefine, "ScriptUserDefine");
      chkbTrapDetectable.Checked = BooleanType.FromObject(UTT.GetNodeValue("TrapDetectable"));
      UTT.SetNumericUpDownToNodeValue(nudTrapDetectDC, "TrapDetectDC");
      chkbTrapDisarmable.Checked = BooleanType.FromObject(UTT.GetNodeValue("TrapDisarmable"));
      UTT.SetNumericUpDownToNodeValue(nudDisarmDC, "DisarmDC");
      chkbTrapFlag.Checked = BooleanType.FromObject(UTT.GetNodeValue("TrapFlag"));
      chkbTrapOneShot.Checked = BooleanType.FromObject(UTT.GetNodeValue("TrapOneShot"));
      UTT.SetNumericUpDownToNodeValue(nudTrapType, "TrapType");
      UTT.SetTextBoxToNodeValue(tbKeyName, "KeyName");
      chkbAutoRemoveKey.Checked = BooleanType.FromObject(UTT.GetNodeValue("AutoRemoveKey"));
      UTT.SetTextBoxToNodeValue(tbComment, "Comment");
      if (ComboBoxSettingError)
      {
        int num = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
      }
      if (KotorVersionIndex != 1)
        return;
      CustomizeForKotorII();
    }

  private void SetGFFNodeValues()
  {
      UTT.SetNodeValueFromTextBox(tbTemplateResRef, "TemplateResRef");
      UTT.SetCExoLocStringNodeValueFromTextBox(tbName, "LocalizedName", NameLang);
      UTT.SetNodeValueFromTextBox(tbTag, "Tag");
      UTT.SetNodeValueFromComboBox(cmbxFaction, "Faction");
      UTT.SetNodeValue("Type", cmbxType.SelectedIndex);
      UTT.SetNodeValueFromTextBox(tbCursor, "Cursor");
      UTT.SetNodeValueFromTextBox(tbOnClick, "OnClick");
      UTT.SetNodeValueFromTextBox(tbOnDisarm, "OnDisarm");
      UTT.SetNodeValueFromTextBox(tbOnTrapTriggered, "OnTrapTriggered");
      UTT.SetNodeValueFromTextBox(tbScriptHeartbeat, "ScriptHeartbeat");
      UTT.SetNodeValueFromTextBox(tbScriptOnEnter, "ScriptOnEnter");
      UTT.SetNodeValueFromTextBox(tbScriptOnExit, "ScriptOnExit");
      UTT.SetNodeValueFromTextBox(tbScriptUserDefine, "ScriptUserDefine");
      if (cmbxType.SelectedIndex == 2)
      {
        if (!UTT.VerifyNodeExists("TrapDetectable"))
          UTT.AddFieldToStruct("", "TrapDetectable", 0, 0);
        UTT.SetNodeValue("TrapDetectable", chkbTrapDetectable.Checked);
        if (!UTT.VerifyNodeExists("TrapDetectDC"))
          UTT.AddFieldToStruct("", "TrapDetectDC", 0, 0);
        UTT.SetNodeValueFromNumericUpDown(nudTrapDetectDC, "TrapDetectDC");
        if (!UTT.VerifyNodeExists("TrapDisarmable"))
          UTT.AddFieldToStruct("", "TrapDisarmable", 0, 0);
        UTT.SetNodeValue("TrapDisarmable", chkbTrapDisarmable.Checked);
        if (!UTT.VerifyNodeExists("DisarmDC"))
          UTT.AddFieldToStruct("", "DisarmDC", 0, 0);
        UTT.SetNodeValueFromNumericUpDown(nudDisarmDC, "DisarmDC");
        if (!UTT.VerifyNodeExists("TrapFlag"))
          UTT.AddFieldToStruct("", "TrapFlag", 0, 0);
        UTT.SetNodeValue("TrapFlag", chkbTrapFlag.Checked);
        if (!UTT.VerifyNodeExists("TrapOneShot"))
          UTT.AddFieldToStruct("", "TrapOneShot", 0, 0);
        UTT.SetNodeValue("TrapOneShot", chkbTrapOneShot.Checked);
        if (!UTT.VerifyNodeExists("TrapType"))
          UTT.AddFieldToStruct("", "TrapType", 0, 0);
        UTT.SetNodeValueFromNumericUpDown(nudTrapType, "TrapType");
        UTT.SetNodeValueFromTextBox(tbKeyName, "KeyName");
        UTT.SetNodeValue("AutoRemoveKey", chkbAutoRemoveKey.Checked);
      }
      UTT.SetNodeValueFromTextBox(tbComment, "Comment");
    }

  public Cls2Da ReadCls2DA(string TwoDAName, ChitinKey ChitinKey)
  {
      bool flag = true;
      byte[] numArray = new byte[] { };
      if (CurrentSettings.bUseOverrideFiles)
      {
        string path = CurrentSettings.KotorLocation(KotorVersionIndex) + "\\override\\" + TwoDAName + ".2da";
        try
        {
          if (File.Exists(path))
          {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            numArray = new byte[checked ((int) fileStream.Length + 1)];
            fileStream.Read(numArray, 0, checked ((int) fileStream.Length));
            fileStream.Close();
            flag = false;
            Console.WriteLine("Read " + TwoDAName + ".2da from override");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.WriteLine("Could not load " + path + " in " + GetType().Name);
          ProjectData.ClearProjectError();
        }
      }
      if (flag)
      {
        int resIdForResRef = ChitinKey.FindResIdForResRef(TwoDAName, 2017);
        numArray = BIFFArchive.GetBIFFResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + ChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
        Console.WriteLine("Read " + TwoDAName + ".2da from 2da.bif");
      }
      return new Cls2Da(numArray);
    }

  private void BuildComboBoxes()
  {
      FillComboBoxFrom2DA(cmbxFaction, "label", "repute", FrmMain.KxChitinKey(KotorVersionIndex), null);
      if (!UTT.SyncComboBox(cmbxFaction, "Faction"))
        ComboBoxSettingError = true;
      cmbxType.SelectedIndex = IntegerType.FromObject(UTT.GetNodeValue("Type"));
    }

  private void FillComboBoxFrom2DA(
    ComboBox cmbx,
    string colName,
    string TwoDAName,
    ChitinKey ChitinKey,
    clsDialogTlk DialogTlk)
  {
      Cls2Da cls2Da = ReadCls2DA(TwoDAName, ChitinKey);
      if (DialogTlk != null)
      {
        int rowsUpperBound = cls2Da.RowsUpperBound;
        int rowNumber = 0;
        while (rowNumber <= rowsUpperBound)
        {
          object indiceData = cls2Da.GetIndiceData(rowNumber, colName);
          if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)))
            cmbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)));
          else
            cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData));
          checked { ++rowNumber; }
        }
      }
      else
      {
        int rowsUpperBound = cls2Da.RowsUpperBound;
        int rowNumber = 0;
        while (rowNumber <= rowsUpperBound)
        {
          cmbx.Items.Add(cls2Da.GetIndiceData(rowNumber, colName));
          checked { ++rowNumber; }
        }
      }
    }

  private void CustomizeForKotorII() => nudTrapType.Maximum = 26M;

  private void btnSave_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".utt", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTT.WriteFile(MEditingFilePath, "UTT");
      if (!m_bSaveGameMode)
        return;
      Close();
    }

  private void btnSetNameLang_Click(object sender, EventArgs e)
  {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(NameLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      NameLang = stringLanguagePicker.LanguageID;
    }

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = tbName.Text + ".utt";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTT.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void frmUTT_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmUTT_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

  public void SetFormName(string Name) => Text = "Trigger Editor - " + Name;

  private void cmbxType_SelectedIndexChanged(object sender, EventArgs e) => TabPageTrap.Enabled = cmbxType.SelectedIndex == 2;

  private void btnEditScript_Click(object sender, EventArgs e) => Utils.EditScriptForTextBox((Button) sender, MEditingFilePath, KotorVersionIndex);
}