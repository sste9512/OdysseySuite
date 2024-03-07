using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTD_Editor : frmParent
{
  [AccessedThroughProperty("lblCloseLockDC")]
  private Label _lblCloseLockDC;
  [AccessedThroughProperty("lblOpenLockDC")]
  private Label _lblOpenLockDC;
  [AccessedThroughProperty("chkbStatic")]
  private CheckBox _chkbStatic;
  [AccessedThroughProperty("cmbxDoorType")]
  private ComboBox _cmbxDoorType;
  [AccessedThroughProperty("lblKeyTag")]
  private Label _lblKeyTag;
  [AccessedThroughProperty("cmbxOpenState")]
  private ComboBox _cmbxOpenState;
  [AccessedThroughProperty("chkbNotBlastable")]
  private CheckBox _chkbNotBlastable;
  [AccessedThroughProperty("lblOpenState")]
  private Label _lblOpenState;
  [AccessedThroughProperty("btnEditOnTrapTriggered")]
  private Button _btnEditOnTrapTriggered;
  [AccessedThroughProperty("tbAnimationState")]
  private TextBox _tbAnimationState;
  [AccessedThroughProperty("tbOnFailToOpen")]
  private TextBox _tbOnFailToOpen;
  [AccessedThroughProperty("chkbNotInterruptable")]
  private CheckBox _chkbNotInterruptable;
  [AccessedThroughProperty("tbOnClick")]
  private TextBox _tbOnClick;
  [AccessedThroughProperty("btnSetNameLang")]
  private Button _btnSetNameLang;
  [AccessedThroughProperty("nudRef")]
  private NumericUpDown _nudRef;
  [AccessedThroughProperty("nudHardness")]
  private NumericUpDown _nudHardness;
  [AccessedThroughProperty("btnEditOnDisarm")]
  private Button _btnEditOnDisarm;
  [AccessedThroughProperty("tbOnDeath")]
  private TextBox _tbOnDeath;
  [AccessedThroughProperty("nudHP")]
  private NumericUpDown _nudHP;
  [AccessedThroughProperty("nudFort")]
  private NumericUpDown _nudFort;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("btnEditOnClick")]
  private Button _btnEditOnClick;
  [AccessedThroughProperty("nudWill")]
  private NumericUpDown _nudWill;
  [AccessedThroughProperty("chkbAutoRemoveKey")]
  private CheckBox _chkbAutoRemoveKey;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("chkbKeyRequired")]
  private CheckBox _chkbKeyRequired;
  [AccessedThroughProperty("btnEditOnSpellCastAt")]
  private Button _btnEditOnSpellCastAt;
  [AccessedThroughProperty("btnEditOnClosed")]
  private Button _btnEditOnClosed;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("btnEditOnFailToOpen")]
  private Button _btnEditOnFailToOpen;
  [AccessedThroughProperty("chkbLocked")]
  private CheckBox _chkbLocked;
  [AccessedThroughProperty("btnEditOnLock")]
  private Button _btnEditOnLock;
  [AccessedThroughProperty("chkbLockable")]
  private CheckBox _chkbLockable;
  [AccessedThroughProperty("tbOnDamaged")]
  private TextBox _tbOnDamaged;
  [AccessedThroughProperty("nudOpenLockDC")]
  private NumericUpDown _nudOpenLockDC;
  [AccessedThroughProperty("nudCloseLockDC")]
  private NumericUpDown _nudCloseLockDC;
  [AccessedThroughProperty("btnEditOnMeleeAttacked")]
  private Button _btnEditOnMeleeAttacked;
  [AccessedThroughProperty("tbKeyName")]
  private TextBox _tbKeyName;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("tbComment")]
  private TextBox _tbComment;
  [AccessedThroughProperty("tbOnHeartbeat")]
  private TextBox _tbOnHeartbeat;
  [AccessedThroughProperty("btnEditOnOpen")]
  private Button _btnEditOnOpen;
  [AccessedThroughProperty("btnEditOnUnlock")]
  private Button _btnEditOnUnlock;
  [AccessedThroughProperty("btnEditOnUserDefined")]
  private Button _btnEditOnUserDefined;
  [AccessedThroughProperty("tbTemplateResRef")]
  private TextBox _tbTemplateResRef;
  [AccessedThroughProperty("tbOnUserDefined")]
  private TextBox _tbOnUserDefined;
  [AccessedThroughProperty("tbOnUnlock")]
  private TextBox _tbOnUnlock;
  [AccessedThroughProperty("tbConversation")]
  private TextBox _tbConversation;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("tbOnTrapTriggered")]
  private TextBox _tbOnTrapTriggered;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("Label41")]
  private Label _Label41;
  [AccessedThroughProperty("Label42")]
  private Label _Label42;
  [AccessedThroughProperty("Label43")]
  private Label _Label43;
  [AccessedThroughProperty("btnEditOnDamaged")]
  private Button _btnEditOnDamaged;
  [AccessedThroughProperty("tbOnSpellCastAt")]
  private TextBox _tbOnSpellCastAt;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnEditOnHeartbeat")]
  private Button _btnEditOnHeartbeat;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("tbOnOpen")]
  private TextBox _tbOnOpen;
  [AccessedThroughProperty("tbOnMeleeAttacked")]
  private TextBox _tbOnMeleeAttacked;
  [AccessedThroughProperty("btnSetDescriptionLang")]
  private Button _btnSetDescriptionLang;
  [AccessedThroughProperty("tbOnLock")]
  private TextBox _tbOnLock;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("btnEditOnDeath")]
  private Button _btnEditOnDeath;
  [AccessedThroughProperty("tbOnDisarm")]
  private TextBox _tbOnDisarm;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("tbName")]
  private TextBox _tbName;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("cmbxFaction")]
  private ComboBox _cmbxFaction;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("tbOnClosed")]
  private TextBox _tbOnClosed;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("lblBodyVariation")]
  private Label _lblBodyVariation;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("lblTextureVariation")]
  private Label _lblTextureVariation;
  [AccessedThroughProperty("chkbPlotItem")]
  private CheckBox _chkbPlotItem;
  [AccessedThroughProperty("tbDescription")]
  private TextBox _tbDescription;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("TabPageComments")]
  private TabPage _TabPageComments;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("TabPageDescription")]
  private TabPage _TabPageDescription;
  [AccessedThroughProperty("TabPageAdvanced")]
  private TabPage _TabPageAdvanced;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("TabPageScripts")]
  private TabPage _TabPageScripts;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("TabPageLock")]
  private TabPage _TabPageLock;
  [AccessedThroughProperty("TabPageBasic")]
  private TabPage _TabPageBasic;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  private IContainer components;
  public clsUTD UTD;
  public clsDialogTlk g_clsDialogTlk;
  private bool ComboBoxSettingError;
  public ChitinKey GChitinKey;
  private int DescriptionLang;
  private int NameLang;
  private bool m_bSaveGameMode;

  public frmUTD_Editor()
  {
      Load += new EventHandler(frmUTD_Editor_Load);
      Closing += new CancelEventHandler(frmUTD_Editor_Closing);
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

  internal virtual TabPage TabPageLock
  {
    get => _TabPageLock;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageLock == null)
          ;
        _TabPageLock = value;
        if (_TabPageLock == null)
          ;
      }
  }

  internal virtual TabPage TabPageScripts
  {
    get => _TabPageScripts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageScripts == null)
          ;
        _TabPageScripts = value;
        if (_TabPageScripts == null)
          ;
      }
  }

  internal virtual TabPage TabPageAdvanced
  {
    get => _TabPageAdvanced;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageAdvanced == null)
          ;
        _TabPageAdvanced = value;
        if (_TabPageAdvanced == null)
          ;
      }
  }

  internal virtual TabPage TabPageDescription
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageDescription == null)
          ;
        _TabPageDescription = value;
        if (_TabPageDescription == null)
          ;
      }
    get => _TabPageDescription;
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

  internal virtual TextBox tbTag
  {
    get => _tbTag;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTag == null)
          ;
        _tbTag = value;
        if (_tbTag == null)
          ;
      }
  }

  internal virtual CheckBox chkbPlotItem
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbPlotItem == null)
          ;
        _chkbPlotItem = value;
        if (_chkbPlotItem == null)
          ;
      }
    get => _chkbPlotItem;
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

  internal virtual Label lblTextureVariation
  {
    get => _lblTextureVariation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblTextureVariation == null)
          ;
        _lblTextureVariation = value;
        if (_lblTextureVariation == null)
          ;
      }
  }

  internal virtual Label Label8
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label8 == null)
          ;
        _Label8 = value;
        if (_Label8 == null)
          ;
      }
    get => _Label8;
  }

  internal virtual Label Label12
  {
    get => _Label12;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label12 == null)
          ;
        _Label12 = value;
        if (_Label12 == null)
          ;
      }
  }

  internal virtual Label lblBodyVariation
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblBodyVariation == null)
          ;
        _lblBodyVariation = value;
        if (_lblBodyVariation == null)
          ;
      }
    get => _lblBodyVariation;
  }

  internal virtual Label Label34
  {
    get => _Label34;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label34 == null)
          ;
        _Label34 = value;
        if (_Label34 == null)
          ;
      }
  }

  internal virtual Label Label33
  {
    get => _Label33;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label33 == null)
          ;
        _Label33 = value;
        if (_Label33 == null)
          ;
      }
  }

  internal virtual Label Label32
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label32 == null)
          ;
        _Label32 = value;
        if (_Label32 == null)
          ;
      }
    get => _Label32;
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

  internal virtual Label Label36
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label36 == null)
          ;
        _Label36 = value;
        if (_Label36 == null)
          ;
      }
    get => _Label36;
  }

  internal virtual Label Label37
  {
    get => _Label37;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label37 == null)
          ;
        _Label37 = value;
        if (_Label37 == null)
          ;
      }
  }

  internal virtual Label Label38
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label38 == null)
          ;
        _Label38 = value;
        if (_Label38 == null)
          ;
      }
    get => _Label38;
  }

  internal virtual Label Label39
  {
    get => _Label39;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label39 == null)
          ;
        _Label39 = value;
        if (_Label39 == null)
          ;
      }
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

  internal virtual Label Label42
  {
    get => _Label42;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label42 == null)
          ;
        _Label42 = value;
        if (_Label42 == null)
          ;
      }
  }

  internal virtual Label Label43
  {
    get => _Label43;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label43 == null)
          ;
        _Label43 = value;
        if (_Label43 == null)
          ;
      }
  }

  internal virtual TextBox tbOnDamaged
  {
    get => _tbOnDamaged;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDamaged == null)
          ;
        _tbOnDamaged = value;
        if (_tbOnDamaged == null)
          ;
      }
  }

  internal virtual TextBox tbOnClosed
  {
    get => _tbOnClosed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnClosed == null)
          ;
        _tbOnClosed = value;
        if (_tbOnClosed == null)
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

  internal virtual TextBox tbOnHeartbeat
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnHeartbeat == null)
          ;
        _tbOnHeartbeat = value;
        if (_tbOnHeartbeat == null)
          ;
      }
    get => _tbOnHeartbeat;
  }

  internal virtual TextBox tbOnLock
  {
    get => _tbOnLock;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnLock == null)
          ;
        _tbOnLock = value;
        if (_tbOnLock == null)
          ;
      }
  }

  internal virtual TextBox tbOnMeleeAttacked
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnMeleeAttacked == null)
          ;
        _tbOnMeleeAttacked = value;
        if (_tbOnMeleeAttacked == null)
          ;
      }
    get => _tbOnMeleeAttacked;
  }

  internal virtual TextBox tbOnOpen
  {
    get => _tbOnOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnOpen == null)
          ;
        _tbOnOpen = value;
        if (_tbOnOpen == null)
          ;
      }
  }

  internal virtual TextBox tbOnSpellCastAt
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnSpellCastAt == null)
          ;
        _tbOnSpellCastAt = value;
        if (_tbOnSpellCastAt == null)
          ;
      }
    get => _tbOnSpellCastAt;
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

  internal virtual TextBox tbOnUnlock
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnUnlock == null)
          ;
        _tbOnUnlock = value;
        if (_tbOnUnlock == null)
          ;
      }
    get => _tbOnUnlock;
  }

  internal virtual TextBox tbOnUserDefined
  {
    get => _tbOnUserDefined;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnUserDefined == null)
          ;
        _tbOnUserDefined = value;
        if (_tbOnUserDefined == null)
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

  internal virtual Label Label9
  {
    get => _Label9;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label9 == null)
          ;
        _Label9 = value;
        if (_Label9 == null)
          ;
      }
  }

  internal virtual TextBox tbComment
  {
    get => _tbComment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbComment == null)
          ;
        _tbComment = value;
        if (_tbComment == null)
          ;
      }
  }

  internal virtual TextBox tbTemplateResRef
  {
    get => _tbTemplateResRef;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbTemplateResRef == null)
          ;
        _tbTemplateResRef = value;
        if (_tbTemplateResRef == null)
          ;
      }
  }

  internal virtual Label Label10
  {
    get => _Label10;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label10 == null)
          ;
        _Label10 = value;
        if (_Label10 == null)
          ;
      }
  }

  internal virtual Label Label11
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label11 == null)
          ;
        _Label11 = value;
        if (_Label11 == null)
          ;
      }
    get => _Label11;
  }

  internal virtual TextBox tbKeyName
  {
    get => _tbKeyName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbKeyName == null)
          ;
        _tbKeyName = value;
        if (_tbKeyName == null)
          ;
      }
  }

  internal virtual NumericUpDown nudCloseLockDC
  {
    get => _nudCloseLockDC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCloseLockDC == null)
          ;
        _nudCloseLockDC = value;
        if (_nudCloseLockDC == null)
          ;
      }
  }

  internal virtual NumericUpDown nudOpenLockDC
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudOpenLockDC == null)
          ;
        _nudOpenLockDC = value;
        if (_nudOpenLockDC == null)
          ;
      }
    get => _nudOpenLockDC;
  }

  internal virtual CheckBox chkbLockable
  {
    get => _chkbLockable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbLockable != null)
          _chkbLockable.CheckedChanged -= new EventHandler(chkbLockable_CheckedChanged);
        _chkbLockable = value;
        if (_chkbLockable == null)
          return;
        _chkbLockable.CheckedChanged += new EventHandler(chkbLockable_CheckedChanged);
      }
  }

  internal virtual CheckBox chkbLocked
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbLocked != null)
          _chkbLocked.CheckedChanged -= new EventHandler(chkbLocked_CheckedChanged);
        _chkbLocked = value;
        if (_chkbLocked == null)
          return;
        _chkbLocked.CheckedChanged += new EventHandler(chkbLocked_CheckedChanged);
      }
    get => _chkbLocked;
  }

  internal virtual CheckBox chkbKeyRequired
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbKeyRequired == null)
          ;
        _chkbKeyRequired = value;
        if (_chkbKeyRequired == null)
          ;
      }
    get => _chkbKeyRequired;
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

  internal virtual CheckBox chkbNotInterruptable
  {
    get => _chkbNotInterruptable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbNotInterruptable == null)
          ;
        _chkbNotInterruptable = value;
        if (_chkbNotInterruptable == null)
          ;
      }
  }

  internal virtual TextBox tbConversation
  {
    get => _tbConversation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbConversation == null)
          ;
        _tbConversation = value;
        if (_tbConversation == null)
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

  internal virtual NumericUpDown nudWill
  {
    get => _nudWill;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudWill == null)
          ;
        _nudWill = value;
        if (_nudWill == null)
          ;
      }
  }

  internal virtual NumericUpDown nudFort
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFort == null)
          ;
        _nudFort = value;
        if (_nudFort == null)
          ;
      }
    get => _nudFort;
  }

  internal virtual NumericUpDown nudHP
  {
    get => _nudHP;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudHP == null)
          ;
        _nudHP = value;
        if (_nudHP == null)
          ;
      }
  }

  internal virtual NumericUpDown nudHardness
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudHardness == null)
          ;
        _nudHardness = value;
        if (_nudHardness == null)
          ;
      }
    get => _nudHardness;
  }

  internal virtual NumericUpDown nudRef
  {
    get => _nudRef;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudRef == null)
          ;
        _nudRef = value;
        if (_nudRef == null)
          ;
      }
  }

  internal virtual TextBox tbName
  {
    get => _tbName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbName == null)
          ;
        _tbName = value;
        if (_tbName == null)
          ;
      }
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

  internal virtual Button btnSave
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSave != null)
          _btnSave.Click -= new EventHandler(btnSave_Click);
        _btnSave = value;
        if (_btnSave == null)
          return;
        _btnSave.Click += new EventHandler(btnSave_Click);
      }
    get => _btnSave;
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

  internal virtual TextBox tbDescription
  {
    get => _tbDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDescription == null)
          ;
        _tbDescription = value;
        if (_tbDescription == null)
          ;
      }
  }

  internal virtual TextBox tbOnClick
  {
    get => _tbOnClick;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnClick == null)
          ;
        _tbOnClick = value;
        if (_tbOnClick == null)
          ;
      }
  }

  internal virtual TextBox tbOnFailToOpen
  {
    get => _tbOnFailToOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnFailToOpen == null)
          ;
        _tbOnFailToOpen = value;
        if (_tbOnFailToOpen == null)
          ;
      }
  }

  internal virtual TextBox tbOnDeath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDeath == null)
          ;
        _tbOnDeath = value;
        if (_tbOnDeath == null)
          ;
      }
    get => _tbOnDeath;
  }

  internal virtual TextBox tbAnimationState
  {
    get => _tbAnimationState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbAnimationState == null)
          ;
        _tbAnimationState = value;
        if (_tbAnimationState == null)
          ;
      }
  }

  internal virtual Label lblKeyTag
  {
    get => _lblKeyTag;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblKeyTag == null)
          ;
        _lblKeyTag = value;
        if (_lblKeyTag == null)
          ;
      }
  }

  internal virtual Label lblCloseLockDC
  {
    get => _lblCloseLockDC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblCloseLockDC == null)
          ;
        _lblCloseLockDC = value;
        if (_lblCloseLockDC == null)
          ;
      }
  }

  internal virtual Label lblOpenLockDC
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblOpenLockDC == null)
          ;
        _lblOpenLockDC = value;
        if (_lblOpenLockDC == null)
          ;
      }
    get => _lblOpenLockDC;
  }

  internal virtual CheckBox chkbStatic
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbStatic == null)
          ;
        _chkbStatic = value;
        if (_chkbStatic == null)
          ;
      }
    get => _chkbStatic;
  }

  internal virtual Button btnSetDescriptionLang
  {
    get => _btnSetDescriptionLang;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetDescriptionLang != null)
          _btnSetDescriptionLang.Click -= new EventHandler(btnSetDescLang_Click);
        _btnSetDescriptionLang = value;
        if (_btnSetDescriptionLang == null)
          return;
        _btnSetDescriptionLang.Click += new EventHandler(btnSetDescLang_Click);
      }
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

  internal virtual Button btnSetNameLang
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetNameLang != null)
          _btnSetNameLang.Click -= new EventHandler(btnSetNameLang_Click);
        _btnSetNameLang = value;
        if (_btnSetNameLang == null)
          return;
        _btnSetNameLang.Click += new EventHandler(btnSetNameLang_Click);
      }
    get => _btnSetNameLang;
  }

  internal virtual Label Label19
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label19 == null)
          ;
        _Label19 = value;
        if (_Label19 == null)
          ;
      }
    get => _Label19;
  }

  internal virtual ComboBox cmbxDoorType
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxDoorType == null)
          ;
        _cmbxDoorType = value;
        if (_cmbxDoorType == null)
          ;
      }
    get => _cmbxDoorType;
  }

  internal virtual ComboBox cmbxOpenState
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxOpenState == null)
          ;
        _cmbxOpenState = value;
        if (_cmbxOpenState == null)
          ;
      }
    get => _cmbxOpenState;
  }

  internal virtual CheckBox chkbNotBlastable
  {
    get => _chkbNotBlastable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbNotBlastable == null)
          ;
        _chkbNotBlastable = value;
        if (_chkbNotBlastable == null)
          ;
      }
  }

  internal virtual Label lblOpenState
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblOpenState == null)
          ;
        _lblOpenState = value;
        if (_lblOpenState == null)
          ;
      }
    get => _lblOpenState;
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

  internal virtual Button btnEditOnTrapTriggered
  {
    get => _btnEditOnTrapTriggered;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnTrapTriggered != null)
          _btnEditOnTrapTriggered.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnTrapTriggered = value;
        if (_btnEditOnTrapTriggered == null)
          return;
        _btnEditOnTrapTriggered.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnDisarm
  {
    get => _btnEditOnDisarm;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDisarm != null)
          _btnEditOnDisarm.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDisarm = value;
        if (_btnEditOnDisarm == null)
          return;
        _btnEditOnDisarm.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnClick
  {
    get => _btnEditOnClick;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnClick != null)
          _btnEditOnClick.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnClick = value;
        if (_btnEditOnClick == null)
          return;
        _btnEditOnClick.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnDamaged
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDamaged != null)
          _btnEditOnDamaged.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDamaged = value;
        if (_btnEditOnDamaged == null)
          return;
        _btnEditOnDamaged.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnDamaged;
  }

  internal virtual Button btnEditOnDeath
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDeath != null)
          _btnEditOnDeath.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDeath = value;
        if (_btnEditOnDeath == null)
          return;
        _btnEditOnDeath.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnDeath;
  }

  internal virtual Button btnEditOnSpellCastAt
  {
    get => _btnEditOnSpellCastAt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnSpellCastAt != null)
          _btnEditOnSpellCastAt.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnSpellCastAt = value;
        if (_btnEditOnSpellCastAt == null)
          return;
        _btnEditOnSpellCastAt.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnHeartbeat
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnHeartbeat != null)
          _btnEditOnHeartbeat.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnHeartbeat = value;
        if (_btnEditOnHeartbeat == null)
          return;
        _btnEditOnHeartbeat.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnHeartbeat;
  }

  internal virtual Button btnEditOnClosed
  {
    get => _btnEditOnClosed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnClosed != null)
          _btnEditOnClosed.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnClosed = value;
        if (_btnEditOnClosed == null)
          return;
        _btnEditOnClosed.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnFailToOpen
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnFailToOpen != null)
          _btnEditOnFailToOpen.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnFailToOpen = value;
        if (_btnEditOnFailToOpen == null)
          return;
        _btnEditOnFailToOpen.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnFailToOpen;
  }

  internal virtual Button btnEditOnLock
  {
    get => _btnEditOnLock;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnLock != null)
          _btnEditOnLock.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnLock = value;
        if (_btnEditOnLock == null)
          return;
        _btnEditOnLock.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnMeleeAttacked
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnMeleeAttacked != null)
          _btnEditOnMeleeAttacked.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnMeleeAttacked = value;
        if (_btnEditOnMeleeAttacked == null)
          return;
        _btnEditOnMeleeAttacked.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnMeleeAttacked;
  }

  internal virtual Button btnEditOnOpen
  {
    get => _btnEditOnOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnOpen != null)
          _btnEditOnOpen.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnOpen = value;
        if (_btnEditOnOpen == null)
          return;
        _btnEditOnOpen.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnUnlock
  {
    get => _btnEditOnUnlock;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnUnlock != null)
          _btnEditOnUnlock.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnUnlock = value;
        if (_btnEditOnUnlock == null)
          return;
        _btnEditOnUnlock.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnUserDefined
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnUserDefined != null)
          _btnEditOnUserDefined.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnUserDefined = value;
        if (_btnEditOnUserDefined == null)
          return;
        _btnEditOnUserDefined.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnUserDefined;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmUTD_Editor));
      this.btnSave = new Button();
      this.btnCancel = new Button();
      TabControl1 = new TabControl();
      TabPageBasic = new TabPage();
      Label19 = new Label();
      cmbxDoorType = new ComboBox();
      btnSetNameLang = new Button();
      Label5 = new Label();
      nudWill = new NumericUpDown();
      nudFort = new NumericUpDown();
      nudHP = new NumericUpDown();
      lblTextureVariation = new Label();
      Label8 = new Label();
      nudHardness = new NumericUpDown();
      nudRef = new NumericUpDown();
      Label12 = new Label();
      lblBodyVariation = new Label();
      chkbPlotItem = new CheckBox();
      tbTag = new TextBox();
      tbName = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      chkbStatic = new CheckBox();
      TabPageLock = new TabPage();
      cmbxOpenState = new ComboBox();
      tbKeyName = new TextBox();
      lblKeyTag = new Label();
      nudCloseLockDC = new NumericUpDown();
      lblCloseLockDC = new Label();
      nudOpenLockDC = new NumericUpDown();
      lblOpenLockDC = new Label();
      chkbLockable = new CheckBox();
      chkbLocked = new CheckBox();
      chkbKeyRequired = new CheckBox();
      chkbAutoRemoveKey = new CheckBox();
      lblOpenState = new Label();
      chkbNotBlastable = new CheckBox();
      TabPageScripts = new TabPage();
      btnEditOnUserDefined = new Button();
      btnEditOnHeartbeat = new Button();
      btnEditOnSpellCastAt = new Button();
      btnEditOnDeath = new Button();
      btnEditOnDamaged = new Button();
      btnEditOnTrapTriggered = new Button();
      btnEditOnDisarm = new Button();
      btnEditOnClick = new Button();
      Label34 = new Label();
      tbOnDeath = new TextBox();
      Label33 = new Label();
      tbOnDamaged = new TextBox();
      Label32 = new Label();
      tbOnClosed = new TextBox();
      Label35 = new Label();
      tbOnDisarm = new TextBox();
      tbOnHeartbeat = new TextBox();
      Label36 = new Label();
      Label37 = new Label();
      tbOnLock = new TextBox();
      tbOnMeleeAttacked = new TextBox();
      Label38 = new Label();
      tbOnOpen = new TextBox();
      Label39 = new Label();
      Label40 = new Label();
      tbOnSpellCastAt = new TextBox();
      Label41 = new Label();
      tbOnTrapTriggered = new TextBox();
      tbOnUnlock = new TextBox();
      Label42 = new Label();
      tbOnUserDefined = new TextBox();
      Label43 = new Label();
      tbOnClick = new TextBox();
      Label9 = new Label();
      Label7 = new Label();
      tbOnFailToOpen = new TextBox();
      btnEditOnClosed = new Button();
      btnEditOnFailToOpen = new Button();
      btnEditOnLock = new Button();
      btnEditOnMeleeAttacked = new Button();
      btnEditOnOpen = new Button();
      btnEditOnUnlock = new Button();
      TabPageAdvanced = new TabPage();
      cmbxFaction = new ComboBox();
      chkbNotInterruptable = new CheckBox();
      tbConversation = new TextBox();
      tbTemplateResRef = new TextBox();
      Label10 = new Label();
      Label11 = new Label();
      Label13 = new Label();
      Label14 = new Label();
      tbAnimationState = new TextBox();
      TabPageDescription = new TabPage();
      btnSetDescriptionLang = new Button();
      tbDescription = new TextBox();
      TabPageComments = new TabPage();
      tbComment = new TextBox();
      btnDebug = new Button();
      TabControl1.SuspendLayout();
      TabPageBasic.SuspendLayout();
      nudWill.BeginInit();
      nudFort.BeginInit();
      nudHP.BeginInit();
      nudHardness.BeginInit();
      nudRef.BeginInit();
      TabPageLock.SuspendLayout();
      nudCloseLockDC.BeginInit();
      nudOpenLockDC.BeginInit();
      TabPageScripts.SuspendLayout();
      TabPageAdvanced.SuspendLayout();
      TabPageDescription.SuspendLayout();
      TabPageComments.SuspendLayout();
      SuspendLayout();
      this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSave = this.btnSave;
      Point point1 = new Point(304, 464);
      Point point2 = point1;
      btnSave.Location = point2;
      this.btnSave.Name = "btnSave";
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "&Save";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(400, 464);
      Point point3 = point1;
      btnCancel.Location = point3;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "&Cancel";
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(TabPageBasic);
      TabControl1.Controls.Add(TabPageLock);
      TabControl1.Controls.Add(TabPageScripts);
      TabControl1.Controls.Add(TabPageAdvanced);
      TabControl1.Controls.Add(TabPageDescription);
      TabControl1.Controls.Add(TabPageComments);
      TabControl tabControl1_1 = TabControl1;
      point1 = new Point(16, 8);
      Point point4 = point1;
      tabControl1_1.Location = point4;
      TabControl1.Multiline = true;
      TabControl1.Name = "TabControl1";
      TabControl tabControl1_2 = TabControl1;
      point1 = new Point(15, 3);
      Point point5 = point1;
      tabControl1_2.Padding = point5;
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = TabControl1;
      Size size1 = new Size(456, 440);
      Size size2 = size1;
      tabControl1_3.Size = size2;
      TabControl1.SizeMode = TabSizeMode.FillToRight;
      TabControl1.TabIndex = 0;
      TabPageBasic.Controls.Add(Label19);
      TabPageBasic.Controls.Add(cmbxDoorType);
      TabPageBasic.Controls.Add(btnSetNameLang);
      TabPageBasic.Controls.Add(Label5);
      TabPageBasic.Controls.Add(nudWill);
      TabPageBasic.Controls.Add(nudFort);
      TabPageBasic.Controls.Add(nudHP);
      TabPageBasic.Controls.Add(lblTextureVariation);
      TabPageBasic.Controls.Add(Label8);
      TabPageBasic.Controls.Add(nudHardness);
      TabPageBasic.Controls.Add(nudRef);
      TabPageBasic.Controls.Add(Label12);
      TabPageBasic.Controls.Add(lblBodyVariation);
      TabPageBasic.Controls.Add(chkbPlotItem);
      TabPageBasic.Controls.Add(tbTag);
      TabPageBasic.Controls.Add(tbName);
      TabPageBasic.Controls.Add(Label1);
      TabPageBasic.Controls.Add(Label2);
      TabPageBasic.Controls.Add(chkbStatic);
      TabPage tabPageBasic1 = TabPageBasic;
      point1 = new Point(4, 22);
      Point point6 = point1;
      ((Control) tabPageBasic1).Location = point6;
      TabPageBasic.Name = "TabPageBasic";
      TabPage tabPageBasic2 = TabPageBasic;
      size1 = new Size(448, 414);
      Size size3 = size1;
      tabPageBasic2.Size = size3;
      TabPageBasic.TabIndex = 0;
      TabPageBasic.Text = "Basic";
      Label label19_1 = Label19;
      point1 = new Point(48, 80);
      Point point7 = point1;
      label19_1.Location = point7;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(80, 16);
      Size size4 = size1;
      label19_2.Size = size4;
      Label19.TabIndex = 12;
      Label19.Text = "Door Type";
      Label19.TextAlign = ContentAlignment.MiddleLeft;
      cmbxDoorType.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxDoorType1 = cmbxDoorType;
      point1 = new Point(128, 80);
      Point point8 = point1;
      cmbxDoorType1.Location = point8;
      cmbxDoorType.Name = "cmbxDoorType";
      ComboBox cmbxDoorType2 = cmbxDoorType;
      size1 = new Size(200, 21);
      Size size5 = size1;
      cmbxDoorType2.Size = size5;
      cmbxDoorType.TabIndex = 11;
      Button btnSetNameLang1 = btnSetNameLang;
      point1 = new Point(344, 32);
      Point point9 = point1;
      btnSetNameLang1.Location = point9;
      btnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = btnSetNameLang;
      size1 = new Size(88, 23);
      Size size6 = size1;
      btnSetNameLang2.Size = size6;
      btnSetNameLang.TabIndex = 9;
      btnSetNameLang.Text = "Set Language";
      Label label5_1 = Label5;
      point1 = new Point(48, 200);
      Point point10 = point1;
      label5_1.Location = point10;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(88, 16);
      Size size7 = size1;
      label5_2.Size = size7;
      Label5.TabIndex = 8;
      Label5.Text = "Fortitude Save";
      Label5.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudWill1 = nudWill;
      point1 = new Point(192, 248);
      Point point11 = point1;
      nudWill1.Location = point11;
      nudWill.Name = "nudWill";
      nudWill.RightToLeft = RightToLeft.No;
      NumericUpDown nudWill2 = nudWill;
      size1 = new Size(48, 20);
      Size size8 = size1;
      nudWill2.Size = size8;
      nudWill.TabIndex = 7;
      nudWill.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudFort1 = nudFort;
      point1 = new Point(192, 200);
      Point point12 = point1;
      nudFort1.Location = point12;
      nudFort.Name = "nudFort";
      nudFort.RightToLeft = RightToLeft.No;
      NumericUpDown nudFort2 = nudFort;
      size1 = new Size(48, 20);
      Size size9 = size1;
      nudFort2.Size = size9;
      nudFort.TabIndex = 5;
      nudFort.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudHp1 = nudHP;
      point1 = new Point(192, 176);
      Point point13 = point1;
      nudHp1.Location = point13;
      NumericUpDown nudHp2 = nudHP;
      Decimal num1 = new Decimal(new int[4]
      {
        99999,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudHp2.Maximum = num2;
      nudHP.Name = "nudHP";
      nudHP.RightToLeft = RightToLeft.No;
      NumericUpDown nudHp3 = nudHP;
      size1 = new Size(48, 20);
      Size size10 = size1;
      nudHp3.Size = size10;
      nudHP.TabIndex = 4;
      nudHP.TextAlign = HorizontalAlignment.Right;
      Label textureVariation1 = lblTextureVariation;
      point1 = new Point(48, 248);
      Point point14 = point1;
      textureVariation1.Location = point14;
      lblTextureVariation.Name = "lblTextureVariation";
      Label textureVariation2 = lblTextureVariation;
      size1 = new Size(96, 16);
      Size size11 = size1;
      textureVariation2.Size = size11;
      lblTextureVariation.TabIndex = 5;
      lblTextureVariation.Text = "Will Save";
      lblTextureVariation.TextAlign = ContentAlignment.MiddleLeft;
      Label label8_1 = Label8;
      point1 = new Point(48, 176);
      Point point15 = point1;
      label8_1.Location = point15;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(88, 16);
      Size size12 = size1;
      label8_2.Size = size12;
      Label8.TabIndex = 4;
      Label8.Text = "Hit Points";
      Label8.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudHardness1 = nudHardness;
      point1 = new Point(192, 152);
      Point point16 = point1;
      nudHardness1.Location = point16;
      NumericUpDown nudHardness2 = nudHardness;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num3 = num1;
      nudHardness2.Maximum = num3;
      nudHardness.Name = "nudHardness";
      nudHardness.RightToLeft = RightToLeft.No;
      NumericUpDown nudHardness3 = nudHardness;
      size1 = new Size(48, 20);
      Size size13 = size1;
      nudHardness3.Size = size13;
      nudHardness.TabIndex = 3;
      nudHardness.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudRef1 = nudRef;
      point1 = new Point(192, 224);
      Point point17 = point1;
      nudRef1.Location = point17;
      nudRef.Name = "nudRef";
      nudRef.RightToLeft = RightToLeft.No;
      NumericUpDown nudRef2 = nudRef;
      size1 = new Size(48, 20);
      Size size14 = size1;
      nudRef2.Size = size14;
      nudRef.TabIndex = 6;
      nudRef.TextAlign = HorizontalAlignment.Right;
      Label label12_1 = Label12;
      point1 = new Point(48, 152);
      Point point18 = point1;
      label12_1.Location = point18;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(88, 16);
      Size size15 = size1;
      label12_2.Size = size15;
      Label12.TabIndex = 7;
      Label12.Text = "Hardness";
      Label12.TextAlign = ContentAlignment.MiddleLeft;
      Label lblBodyVariation1 = lblBodyVariation;
      point1 = new Point(48, 224);
      Point point19 = point1;
      lblBodyVariation1.Location = point19;
      lblBodyVariation.Name = "lblBodyVariation";
      Label lblBodyVariation2 = lblBodyVariation;
      size1 = new Size(88, 16);
      Size size16 = size1;
      lblBodyVariation2.Size = size16;
      lblBodyVariation.TabIndex = 6;
      lblBodyVariation.Text = "Reflex Save";
      lblBodyVariation.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbPlotItem1 = chkbPlotItem;
      point1 = new Point(48, 112);
      Point point20 = point1;
      chkbPlotItem1.Location = point20;
      chkbPlotItem.Name = "chkbPlotItem";
      CheckBox chkbPlotItem2 = chkbPlotItem;
      size1 = new Size(72, 24);
      Size size17 = size1;
      chkbPlotItem2.Size = size17;
      chkbPlotItem.TabIndex = 2;
      chkbPlotItem.Text = "Plot item";
      TextBox tbTag1 = tbTag;
      point1 = new Point(128, 56);
      Point point21 = point1;
      tbTag1.Location = point21;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(200, 20);
      Size size18 = size1;
      tbTag2.Size = size18;
      tbTag.TabIndex = 1;
      tbTag.Text = "";
      TextBox tbName1 = tbName;
      point1 = new Point(128, 32);
      Point point22 = point1;
      tbName1.Location = point22;
      tbName.Name = "tbName";
      TextBox tbName2 = tbName;
      size1 = new Size(200, 20);
      Size size19 = size1;
      tbName2.Size = size19;
      tbName.TabIndex = 0;
      tbName.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(48, 32);
      Point point23 = point1;
      label1_1.Location = point23;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size20 = size1;
      label1_2.Size = size20;
      Label1.TabIndex = 0;
      Label1.Text = "Name";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      Label label2_1 = Label2;
      point1 = new Point(48, 56);
      Point point24 = point1;
      label2_1.Location = point24;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size21 = size1;
      label2_2.Size = size21;
      Label2.TabIndex = 0;
      Label2.Text = "Tag";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbStatic1 = chkbStatic;
      point1 = new Point(192, 112);
      Point point25 = point1;
      chkbStatic1.Location = point25;
      chkbStatic.Name = "chkbStatic";
      CheckBox chkbStatic2 = chkbStatic;
      size1 = new Size(72, 24);
      Size size22 = size1;
      chkbStatic2.Size = size22;
      chkbStatic.TabIndex = 2;
      chkbStatic.Text = "Static";
      TabPageLock.Controls.Add(cmbxOpenState);
      TabPageLock.Controls.Add(tbKeyName);
      TabPageLock.Controls.Add(lblKeyTag);
      TabPageLock.Controls.Add(nudCloseLockDC);
      TabPageLock.Controls.Add(lblCloseLockDC);
      TabPageLock.Controls.Add(nudOpenLockDC);
      TabPageLock.Controls.Add(lblOpenLockDC);
      TabPageLock.Controls.Add(chkbLockable);
      TabPageLock.Controls.Add(chkbLocked);
      TabPageLock.Controls.Add(chkbKeyRequired);
      TabPageLock.Controls.Add(chkbAutoRemoveKey);
      TabPageLock.Controls.Add(lblOpenState);
      TabPageLock.Controls.Add(chkbNotBlastable);
      TabPage tabPageLock1 = TabPageLock;
      point1 = new Point(4, 22);
      Point point26 = point1;
      ((Control) tabPageLock1).Location = point26;
      TabPageLock.Name = "TabPageLock";
      TabPage tabPageLock2 = TabPageLock;
      size1 = new Size(448, 414);
      Size size23 = size1;
      tabPageLock2.Size = size23;
      TabPageLock.TabIndex = 1;
      TabPageLock.Text = "Lock";
      cmbxOpenState.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxOpenState.Items.AddRange(new object[2]
      {
        "Closed",
        "Opened"
      });
      ComboBox cmbxOpenState1 = cmbxOpenState;
      point1 = new Point(176, 125);
      Point point27 = point1;
      cmbxOpenState1.Location = point27;
      cmbxOpenState.Name = "cmbxOpenState";
      ComboBox cmbxOpenState2 = cmbxOpenState;
      size1 = new Size(121, 21);
      Size size24 = size1;
      cmbxOpenState2.Size = size24;
      cmbxOpenState.TabIndex = 3;
      tbKeyName.Enabled = false;
      TextBox tbKeyName1 = tbKeyName;
      point1 = new Point(176, 304);
      Point point28 = point1;
      tbKeyName1.Location = point28;
      tbKeyName.Name = "tbKeyName";
      TextBox tbKeyName2 = tbKeyName;
      size1 = new Size(200, 20);
      Size size25 = size1;
      tbKeyName2.Size = size25;
      tbKeyName.TabIndex = 8;
      tbKeyName.Text = "";
      lblKeyTag.Enabled = false;
      Label lblKeyTag1 = lblKeyTag;
      point1 = new Point(52, 304);
      Point point29 = point1;
      lblKeyTag1.Location = point29;
      lblKeyTag.Name = "lblKeyTag";
      Label lblKeyTag2 = lblKeyTag;
      size1 = new Size(100, 16);
      Size size26 = size1;
      lblKeyTag2.Size = size26;
      lblKeyTag.TabIndex = 18;
      lblKeyTag.Text = "Key Tag";
      lblKeyTag.TextAlign = ContentAlignment.MiddleLeft;
      nudCloseLockDC.Enabled = false;
      NumericUpDown nudCloseLockDc1 = nudCloseLockDC;
      point1 = new Point(176, 208);
      Point point30 = point1;
      nudCloseLockDc1.Location = point30;
      NumericUpDown nudCloseLockDc2 = nudCloseLockDC;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num4 = num1;
      nudCloseLockDc2.Maximum = num4;
      nudCloseLockDC.Name = "nudCloseLockDC";
      nudCloseLockDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudCloseLockDc3 = nudCloseLockDC;
      size1 = new Size(48, 20);
      Size size27 = size1;
      nudCloseLockDc3.Size = size27;
      nudCloseLockDC.TabIndex = 5;
      nudCloseLockDC.TextAlign = HorizontalAlignment.Right;
      lblCloseLockDC.Enabled = false;
      Label lblCloseLockDc1 = lblCloseLockDC;
      point1 = new Point(48, 208);
      Point point31 = point1;
      lblCloseLockDc1.Location = point31;
      lblCloseLockDC.Name = "lblCloseLockDC";
      Label lblCloseLockDc2 = lblCloseLockDC;
      size1 = new Size(88, 16);
      Size size28 = size1;
      lblCloseLockDc2.Size = size28;
      lblCloseLockDC.TabIndex = 14;
      lblCloseLockDC.Text = "Close Lock DC";
      lblCloseLockDC.TextAlign = ContentAlignment.MiddleLeft;
      nudOpenLockDC.Enabled = false;
      NumericUpDown nudOpenLockDc1 = nudOpenLockDC;
      point1 = new Point(176, 168);
      Point point32 = point1;
      nudOpenLockDc1.Location = point32;
      NumericUpDown nudOpenLockDc2 = nudOpenLockDC;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num5 = num1;
      nudOpenLockDc2.Maximum = num5;
      nudOpenLockDC.Name = "nudOpenLockDC";
      nudOpenLockDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudOpenLockDc3 = nudOpenLockDC;
      size1 = new Size(48, 20);
      Size size29 = size1;
      nudOpenLockDc3.Size = size29;
      nudOpenLockDC.TabIndex = 4;
      nudOpenLockDC.TextAlign = HorizontalAlignment.Right;
      lblOpenLockDC.Enabled = false;
      Label lblOpenLockDc1 = lblOpenLockDC;
      point1 = new Point(48, 168);
      Point point33 = point1;
      lblOpenLockDc1.Location = point33;
      lblOpenLockDC.Name = "lblOpenLockDC";
      Label lblOpenLockDc2 = lblOpenLockDC;
      size1 = new Size(88, 16);
      Size size30 = size1;
      lblOpenLockDc2.Size = size30;
      lblOpenLockDC.TabIndex = 15;
      lblOpenLockDC.Text = "Open Lock DC";
      lblOpenLockDC.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbLockable1 = chkbLockable;
      point1 = new Point(48, 56);
      Point point34 = point1;
      chkbLockable1.Location = point34;
      chkbLockable.Name = "chkbLockable";
      CheckBox chkbLockable2 = chkbLockable;
      size1 = new Size(112, 24);
      Size size31 = size1;
      chkbLockable2.Size = size31;
      chkbLockable.TabIndex = 1;
      chkbLockable.Text = "Can be relocked";
      CheckBox chkbLocked1 = chkbLocked;
      point1 = new Point(48, 32);
      Point point35 = point1;
      chkbLocked1.Location = point35;
      chkbLocked.Name = "chkbLocked";
      CheckBox chkbLocked2 = chkbLocked;
      size1 = new Size(72, 24);
      Size size32 = size1;
      chkbLocked2.Size = size32;
      chkbLocked.TabIndex = 0;
      chkbLocked.Text = "Locked";
      chkbKeyRequired.Enabled = false;
      CheckBox chkbKeyRequired1 = chkbKeyRequired;
      point1 = new Point(48, 264);
      Point point36 = point1;
      chkbKeyRequired1.Location = point36;
      chkbKeyRequired.Name = "chkbKeyRequired";
      CheckBox chkbKeyRequired2 = chkbKeyRequired;
      size1 = new Size(184, 24);
      Size size33 = size1;
      chkbKeyRequired2.Size = size33;
      chkbKeyRequired.TabIndex = 7;
      chkbKeyRequired.Text = "Key required to unlock or lock";
      chkbAutoRemoveKey.Enabled = false;
      CheckBox chkbAutoRemoveKey1 = chkbAutoRemoveKey;
      point1 = new Point(48, 240);
      Point point37 = point1;
      chkbAutoRemoveKey1.Location = point37;
      chkbAutoRemoveKey.Name = "chkbAutoRemoveKey";
      CheckBox chkbAutoRemoveKey2 = chkbAutoRemoveKey;
      size1 = new Size(200, 24);
      Size size34 = size1;
      chkbAutoRemoveKey2.Size = size34;
      chkbAutoRemoveKey.TabIndex = 6;
      chkbAutoRemoveKey.Text = "Automatically remove key after use";
      Label lblOpenState1 = lblOpenState;
      point1 = new Point(48, 128);
      Point point38 = point1;
      lblOpenState1.Location = point38;
      lblOpenState.Name = "lblOpenState";
      Label lblOpenState2 = lblOpenState;
      size1 = new Size(88, 16);
      Size size35 = size1;
      lblOpenState2.Size = size35;
      lblOpenState.TabIndex = 15;
      lblOpenState.Text = "Door State";
      lblOpenState.TextAlign = ContentAlignment.MiddleLeft;
      chkbNotBlastable.Enabled = false;
      CheckBox chkbNotBlastable1 = chkbNotBlastable;
      point1 = new Point(48, 80);
      Point point39 = point1;
      chkbNotBlastable1.Location = point39;
      chkbNotBlastable.Name = "chkbNotBlastable";
      CheckBox chkbNotBlastable2 = chkbNotBlastable;
      size1 = new Size(112, 24);
      Size size36 = size1;
      chkbNotBlastable2.Size = size36;
      chkbNotBlastable.TabIndex = 2;
      chkbNotBlastable.Text = "Not Blastable";
      TabPageScripts.Controls.Add(btnEditOnUserDefined);
      TabPageScripts.Controls.Add(btnEditOnHeartbeat);
      TabPageScripts.Controls.Add(btnEditOnSpellCastAt);
      TabPageScripts.Controls.Add(btnEditOnDeath);
      TabPageScripts.Controls.Add(btnEditOnDamaged);
      TabPageScripts.Controls.Add(btnEditOnTrapTriggered);
      TabPageScripts.Controls.Add(btnEditOnDisarm);
      TabPageScripts.Controls.Add(btnEditOnClick);
      TabPageScripts.Controls.Add(Label34);
      TabPageScripts.Controls.Add(tbOnDeath);
      TabPageScripts.Controls.Add(Label33);
      TabPageScripts.Controls.Add(tbOnDamaged);
      TabPageScripts.Controls.Add(Label32);
      TabPageScripts.Controls.Add(tbOnClosed);
      TabPageScripts.Controls.Add(Label35);
      TabPageScripts.Controls.Add(tbOnDisarm);
      TabPageScripts.Controls.Add(tbOnHeartbeat);
      TabPageScripts.Controls.Add(Label36);
      TabPageScripts.Controls.Add(Label37);
      TabPageScripts.Controls.Add(tbOnLock);
      TabPageScripts.Controls.Add(tbOnMeleeAttacked);
      TabPageScripts.Controls.Add(Label38);
      TabPageScripts.Controls.Add(tbOnOpen);
      TabPageScripts.Controls.Add(Label39);
      TabPageScripts.Controls.Add(Label40);
      TabPageScripts.Controls.Add(tbOnSpellCastAt);
      TabPageScripts.Controls.Add(Label41);
      TabPageScripts.Controls.Add(tbOnTrapTriggered);
      TabPageScripts.Controls.Add(tbOnUnlock);
      TabPageScripts.Controls.Add(Label42);
      TabPageScripts.Controls.Add(tbOnUserDefined);
      TabPageScripts.Controls.Add(Label43);
      TabPageScripts.Controls.Add(tbOnClick);
      TabPageScripts.Controls.Add(Label9);
      TabPageScripts.Controls.Add(Label7);
      TabPageScripts.Controls.Add(tbOnFailToOpen);
      TabPageScripts.Controls.Add(btnEditOnClosed);
      TabPageScripts.Controls.Add(btnEditOnFailToOpen);
      TabPageScripts.Controls.Add(btnEditOnLock);
      TabPageScripts.Controls.Add(btnEditOnMeleeAttacked);
      TabPageScripts.Controls.Add(btnEditOnOpen);
      TabPageScripts.Controls.Add(btnEditOnUnlock);
      TabPage tabPageScripts1 = TabPageScripts;
      point1 = new Point(4, 22);
      Point point40 = point1;
      ((Control) tabPageScripts1).Location = point40;
      TabPageScripts.Name = "TabPageScripts";
      TabPage tabPageScripts2 = TabPageScripts;
      size1 = new Size(448, 414);
      Size size37 = size1;
      tabPageScripts2.Size = size37;
      TabPageScripts.TabIndex = 4;
      TabPageScripts.Text = "Scripts";
      Button editOnUserDefined1 = btnEditOnUserDefined;
      point1 = new Point(392, 372);
      Point point41 = point1;
      editOnUserDefined1.Location = point41;
      btnEditOnUserDefined.Name = "btnEditOnUserDefined";
      Button editOnUserDefined2 = btnEditOnUserDefined;
      size1 = new Size(32, 23);
      Size size38 = size1;
      editOnUserDefined2.Size = size38;
      btnEditOnUserDefined.TabIndex = 36;
      btnEditOnUserDefined.Text = "Edit";
      btnEditOnUserDefined.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnHeartbeat1 = btnEditOnHeartbeat;
      point1 = new Point(392, 176);
      Point point42 = point1;
      btnEditOnHeartbeat1.Location = point42;
      btnEditOnHeartbeat.Name = "btnEditOnHeartbeat";
      Button btnEditOnHeartbeat2 = btnEditOnHeartbeat;
      size1 = new Size(32, 23);
      Size size39 = size1;
      btnEditOnHeartbeat2.Size = size39;
      btnEditOnHeartbeat.TabIndex = 35;
      btnEditOnHeartbeat.Text = "Edit";
      btnEditOnHeartbeat.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnSpellCastAt1 = btnEditOnSpellCastAt;
      point1 = new Point(392, 288);
      Point point43 = point1;
      editOnSpellCastAt1.Location = point43;
      btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt";
      Button editOnSpellCastAt2 = btnEditOnSpellCastAt;
      size1 = new Size(32, 23);
      Size size40 = size1;
      editOnSpellCastAt2.Size = size40;
      btnEditOnSpellCastAt.TabIndex = 34;
      btnEditOnSpellCastAt.Text = "Edit";
      btnEditOnSpellCastAt.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDeath1 = btnEditOnDeath;
      point1 = new Point(392, 92);
      Point point44 = point1;
      btnEditOnDeath1.Location = point44;
      btnEditOnDeath.Name = "btnEditOnDeath";
      Button btnEditOnDeath2 = btnEditOnDeath;
      size1 = new Size(32, 23);
      Size size41 = size1;
      btnEditOnDeath2.Size = size41;
      btnEditOnDeath.TabIndex = 33;
      btnEditOnDeath.Text = "Edit";
      btnEditOnDeath.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDamaged1 = btnEditOnDamaged;
      point1 = new Point(392, 64);
      Point point45 = point1;
      btnEditOnDamaged1.Location = point45;
      btnEditOnDamaged.Name = "btnEditOnDamaged";
      Button btnEditOnDamaged2 = btnEditOnDamaged;
      size1 = new Size(32, 23);
      Size size42 = size1;
      btnEditOnDamaged2.Size = size42;
      btnEditOnDamaged.TabIndex = 32;
      btnEditOnDamaged.Text = "Edit";
      btnEditOnDamaged.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnTrapTriggered1 = btnEditOnTrapTriggered;
      point1 = new Point(392, 316);
      Point point46 = point1;
      editOnTrapTriggered1.Location = point46;
      btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered";
      Button editOnTrapTriggered2 = btnEditOnTrapTriggered;
      size1 = new Size(32, 23);
      Size size43 = size1;
      editOnTrapTriggered2.Size = size43;
      btnEditOnTrapTriggered.TabIndex = 31;
      btnEditOnTrapTriggered.Text = "Edit";
      btnEditOnTrapTriggered.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDisarm1 = btnEditOnDisarm;
      point1 = new Point(392, 120);
      Point point47 = point1;
      btnEditOnDisarm1.Location = point47;
      btnEditOnDisarm.Name = "btnEditOnDisarm";
      Button btnEditOnDisarm2 = btnEditOnDisarm;
      size1 = new Size(32, 23);
      Size size44 = size1;
      btnEditOnDisarm2.Size = size44;
      btnEditOnDisarm.TabIndex = 30;
      btnEditOnDisarm.Text = "Edit";
      btnEditOnDisarm.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnClick1 = btnEditOnClick;
      point1 = new Point(392, 8);
      Point point48 = point1;
      btnEditOnClick1.Location = point48;
      btnEditOnClick.Name = "btnEditOnClick";
      Button btnEditOnClick2 = btnEditOnClick;
      size1 = new Size(32, 23);
      Size size45 = size1;
      btnEditOnClick2.Size = size45;
      btnEditOnClick.TabIndex = 29;
      btnEditOnClick.Text = "Edit";
      btnEditOnClick.TextAlign = ContentAlignment.MiddleLeft;
      Label label34_1 = Label34;
      point1 = new Point(40, 92);
      Point point49 = point1;
      label34_1.Location = point49;
      Label34.Name = "Label34";
      Label label34_2 = Label34;
      size1 = new Size(112, 18);
      Size size46 = size1;
      label34_2.Size = size46;
      Label34.TabIndex = 27;
      Label34.Text = "OnDeath";
      Label34.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDeath1 = tbOnDeath;
      point1 = new Point(160, 92);
      Point point50 = point1;
      tbOnDeath1.Location = point50;
      tbOnDeath.Name = "tbOnDeath";
      TextBox tbOnDeath2 = tbOnDeath;
      size1 = new Size(204, 20);
      Size size47 = size1;
      tbOnDeath2.Size = size47;
      tbOnDeath.TabIndex = 3;
      tbOnDeath.Text = "";
      Label label33_1 = Label33;
      point1 = new Point(40, 64);
      Point point51 = point1;
      label33_1.Location = point51;
      Label33.Name = "Label33";
      Label label33_2 = Label33;
      size1 = new Size(112, 18);
      Size size48 = size1;
      label33_2.Size = size48;
      Label33.TabIndex = 17;
      Label33.Text = "OnDamaged";
      Label33.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDamaged1 = tbOnDamaged;
      point1 = new Point(160, 64);
      Point point52 = point1;
      tbOnDamaged1.Location = point52;
      tbOnDamaged.Name = "tbOnDamaged";
      TextBox tbOnDamaged2 = tbOnDamaged;
      size1 = new Size(204, 20);
      Size size49 = size1;
      tbOnDamaged2.Size = size49;
      tbOnDamaged.TabIndex = 2;
      tbOnDamaged.Text = "";
      Label label32_1 = Label32;
      point1 = new Point(40, 36);
      Point point53 = point1;
      label32_1.Location = point53;
      Label32.Name = "Label32";
      Label label32_2 = Label32;
      size1 = new Size(112, 18);
      Size size50 = size1;
      label32_2.Size = size50;
      Label32.TabIndex = 14;
      Label32.Text = "OnClosed";
      Label32.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnClosed1 = tbOnClosed;
      point1 = new Point(160, 36);
      Point point54 = point1;
      tbOnClosed1.Location = point54;
      tbOnClosed.Name = "tbOnClosed";
      TextBox tbOnClosed2 = tbOnClosed;
      size1 = new Size(204, 20);
      Size size51 = size1;
      tbOnClosed2.Size = size51;
      tbOnClosed.TabIndex = 1;
      tbOnClosed.Text = "";
      Label label35_1 = Label35;
      point1 = new Point(40, 120);
      Point point55 = point1;
      label35_1.Location = point55;
      Label35.Name = "Label35";
      Label label35_2 = Label35;
      size1 = new Size(112, 18);
      Size size52 = size1;
      label35_2.Size = size52;
      Label35.TabIndex = 26;
      Label35.Text = "OnDisarm";
      Label35.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDisarm1 = tbOnDisarm;
      point1 = new Point(160, 120);
      Point point56 = point1;
      tbOnDisarm1.Location = point56;
      tbOnDisarm.Name = "tbOnDisarm";
      TextBox tbOnDisarm2 = tbOnDisarm;
      size1 = new Size(204, 20);
      Size size53 = size1;
      tbOnDisarm2.Size = size53;
      tbOnDisarm.TabIndex = 4;
      tbOnDisarm.Text = "";
      TextBox tbOnHeartbeat1 = tbOnHeartbeat;
      point1 = new Point(160, 176);
      Point point57 = point1;
      tbOnHeartbeat1.Location = point57;
      tbOnHeartbeat.Name = "tbOnHeartbeat";
      TextBox tbOnHeartbeat2 = tbOnHeartbeat;
      size1 = new Size(204, 20);
      Size size54 = size1;
      tbOnHeartbeat2.Size = size54;
      tbOnHeartbeat.TabIndex = 6;
      tbOnHeartbeat.Text = "";
      Label label36_1 = Label36;
      point1 = new Point(40, 176);
      Point point58 = point1;
      label36_1.Location = point58;
      Label36.Name = "Label36";
      Label label36_2 = Label36;
      size1 = new Size(112, 18);
      Size size55 = size1;
      label36_2.Size = size55;
      Label36.TabIndex = 25;
      Label36.Text = "OnHeartbeat";
      Label36.TextAlign = ContentAlignment.MiddleLeft;
      Label label37_1 = Label37;
      point1 = new Point(40, 204);
      Point point59 = point1;
      label37_1.Location = point59;
      Label37.Name = "Label37";
      Label label37_2 = Label37;
      size1 = new Size(112, 18);
      Size size56 = size1;
      label37_2.Size = size56;
      Label37.TabIndex = 28;
      Label37.Text = "OnLock";
      Label37.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnLock1 = tbOnLock;
      point1 = new Point(160, 204);
      Point point60 = point1;
      tbOnLock1.Location = point60;
      tbOnLock.Name = "tbOnLock";
      TextBox tbOnLock2 = tbOnLock;
      size1 = new Size(204, 20);
      Size size57 = size1;
      tbOnLock2.Size = size57;
      tbOnLock.TabIndex = 7;
      tbOnLock.Text = "";
      TextBox tbOnMeleeAttacked1 = tbOnMeleeAttacked;
      point1 = new Point(160, 232);
      Point point61 = point1;
      tbOnMeleeAttacked1.Location = point61;
      tbOnMeleeAttacked.Name = "tbOnMeleeAttacked";
      TextBox tbOnMeleeAttacked2 = tbOnMeleeAttacked;
      size1 = new Size(204, 20);
      Size size58 = size1;
      tbOnMeleeAttacked2.Size = size58;
      tbOnMeleeAttacked.TabIndex = 8;
      tbOnMeleeAttacked.Text = "";
      Label label38_1 = Label38;
      point1 = new Point(40, 232);
      Point point62 = point1;
      label38_1.Location = point62;
      Label38.Name = "Label38";
      Label label38_2 = Label38;
      size1 = new Size(112, 18);
      Size size59 = size1;
      label38_2.Size = size59;
      Label38.TabIndex = 20;
      Label38.Text = "OnMeleeAttacked";
      Label38.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnOpen1 = tbOnOpen;
      point1 = new Point(160, 260);
      Point point63 = point1;
      tbOnOpen1.Location = point63;
      tbOnOpen.Name = "tbOnOpen";
      TextBox tbOnOpen2 = tbOnOpen;
      size1 = new Size(204, 20);
      Size size60 = size1;
      tbOnOpen2.Size = size60;
      tbOnOpen.TabIndex = 9;
      tbOnOpen.Text = "";
      Label label39_1 = Label39;
      point1 = new Point(40, 260);
      Point point64 = point1;
      label39_1.Location = point64;
      Label39.Name = "Label39";
      Label label39_2 = Label39;
      size1 = new Size(112, 18);
      Size size61 = size1;
      label39_2.Size = size61;
      Label39.TabIndex = 21;
      Label39.Text = "OnOpen";
      Label39.TextAlign = ContentAlignment.MiddleLeft;
      Label label40_1 = Label40;
      point1 = new Point(40, 288);
      Point point65 = point1;
      label40_1.Location = point65;
      Label40.Name = "Label40";
      Label label40_2 = Label40;
      size1 = new Size(112, 18);
      Size size62 = size1;
      label40_2.Size = size62;
      Label40.TabIndex = 19;
      Label40.Text = "OnSpellCastAt";
      Label40.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnSpellCastAt1 = tbOnSpellCastAt;
      point1 = new Point(160, 288);
      Point point66 = point1;
      tbOnSpellCastAt1.Location = point66;
      tbOnSpellCastAt.Name = "tbOnSpellCastAt";
      TextBox tbOnSpellCastAt2 = tbOnSpellCastAt;
      size1 = new Size(204, 20);
      Size size63 = size1;
      tbOnSpellCastAt2.Size = size63;
      tbOnSpellCastAt.TabIndex = 10;
      tbOnSpellCastAt.Text = "";
      Label label41_1 = Label41;
      point1 = new Point(40, 316);
      Point point67 = point1;
      label41_1.Location = point67;
      Label41.Name = "Label41";
      Label label41_2 = Label41;
      size1 = new Size(112, 18);
      Size size64 = size1;
      label41_2.Size = size64;
      Label41.TabIndex = 24;
      Label41.Text = "OnTrapTriggered";
      Label41.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnTrapTriggered1 = tbOnTrapTriggered;
      point1 = new Point(160, 316);
      Point point68 = point1;
      tbOnTrapTriggered1.Location = point68;
      tbOnTrapTriggered.Name = "tbOnTrapTriggered";
      TextBox tbOnTrapTriggered2 = tbOnTrapTriggered;
      size1 = new Size(204, 20);
      Size size65 = size1;
      tbOnTrapTriggered2.Size = size65;
      tbOnTrapTriggered.TabIndex = 11;
      tbOnTrapTriggered.Text = "";
      TextBox tbOnUnlock1 = tbOnUnlock;
      point1 = new Point(160, 344);
      Point point69 = point1;
      tbOnUnlock1.Location = point69;
      tbOnUnlock.Name = "tbOnUnlock";
      TextBox tbOnUnlock2 = tbOnUnlock;
      size1 = new Size(204, 20);
      Size size66 = size1;
      tbOnUnlock2.Size = size66;
      tbOnUnlock.TabIndex = 12;
      tbOnUnlock.Text = "";
      Label label42_1 = Label42;
      point1 = new Point(40, 344);
      Point point70 = point1;
      label42_1.Location = point70;
      Label42.Name = "Label42";
      Label label42_2 = Label42;
      size1 = new Size(112, 18);
      Size size67 = size1;
      label42_2.Size = size67;
      Label42.TabIndex = 23;
      Label42.Text = "OnUnlock";
      Label42.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnUserDefined1 = tbOnUserDefined;
      point1 = new Point(160, 372);
      Point point71 = point1;
      tbOnUserDefined1.Location = point71;
      tbOnUserDefined.Name = "tbOnUserDefined";
      TextBox tbOnUserDefined2 = tbOnUserDefined;
      size1 = new Size(204, 20);
      Size size68 = size1;
      tbOnUserDefined2.Size = size68;
      tbOnUserDefined.TabIndex = 13;
      tbOnUserDefined.Text = "";
      Label label43_1 = Label43;
      point1 = new Point(40, 372);
      Point point72 = point1;
      label43_1.Location = point72;
      Label43.Name = "Label43";
      Label label43_2 = Label43;
      size1 = new Size(112, 18);
      Size size69 = size1;
      label43_2.Size = size69;
      Label43.TabIndex = 22;
      Label43.Text = "OnUserDefined";
      Label43.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnClick1 = tbOnClick;
      point1 = new Point(160, 8);
      Point point73 = point1;
      tbOnClick1.Location = point73;
      tbOnClick.Name = "tbOnClick";
      TextBox tbOnClick2 = tbOnClick;
      size1 = new Size(204, 20);
      Size size70 = size1;
      tbOnClick2.Size = size70;
      tbOnClick.TabIndex = 0;
      tbOnClick.Text = "";
      Label label9_1 = Label9;
      point1 = new Point(40, 8);
      Point point74 = point1;
      label9_1.Location = point74;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(112, 18);
      Size size71 = size1;
      label9_2.Size = size71;
      Label9.TabIndex = 23;
      Label9.Text = "OnClick";
      Label9.TextAlign = ContentAlignment.MiddleLeft;
      Label label7_1 = Label7;
      point1 = new Point(40, 148);
      Point point75 = point1;
      label7_1.Location = point75;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(112, 18);
      Size size72 = size1;
      label7_2.Size = size72;
      Label7.TabIndex = 22;
      Label7.Text = "OnFailToOpen";
      Label7.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnFailToOpen1 = tbOnFailToOpen;
      point1 = new Point(160, 148);
      Point point76 = point1;
      tbOnFailToOpen1.Location = point76;
      tbOnFailToOpen.Name = "tbOnFailToOpen";
      TextBox tbOnFailToOpen2 = tbOnFailToOpen;
      size1 = new Size(204, 20);
      Size size73 = size1;
      tbOnFailToOpen2.Size = size73;
      tbOnFailToOpen.TabIndex = 5;
      tbOnFailToOpen.Text = "";
      Button btnEditOnClosed1 = btnEditOnClosed;
      point1 = new Point(392, 36);
      Point point77 = point1;
      btnEditOnClosed1.Location = point77;
      btnEditOnClosed.Name = "btnEditOnClosed";
      Button btnEditOnClosed2 = btnEditOnClosed;
      size1 = new Size(32, 23);
      Size size74 = size1;
      btnEditOnClosed2.Size = size74;
      btnEditOnClosed.TabIndex = 29;
      btnEditOnClosed.Text = "Edit";
      btnEditOnClosed.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnFailToOpen1 = btnEditOnFailToOpen;
      point1 = new Point(392, 148);
      Point point78 = point1;
      editOnFailToOpen1.Location = point78;
      btnEditOnFailToOpen.Name = "btnEditOnFailToOpen";
      Button editOnFailToOpen2 = btnEditOnFailToOpen;
      size1 = new Size(32, 23);
      Size size75 = size1;
      editOnFailToOpen2.Size = size75;
      btnEditOnFailToOpen.TabIndex = 30;
      btnEditOnFailToOpen.Text = "Edit";
      btnEditOnFailToOpen.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnLock1 = btnEditOnLock;
      point1 = new Point(392, 204);
      Point point79 = point1;
      btnEditOnLock1.Location = point79;
      btnEditOnLock.Name = "btnEditOnLock";
      Button btnEditOnLock2 = btnEditOnLock;
      size1 = new Size(32, 23);
      Size size76 = size1;
      btnEditOnLock2.Size = size76;
      btnEditOnLock.TabIndex = 35;
      btnEditOnLock.Text = "Edit";
      btnEditOnLock.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnMeleeAttacked1 = btnEditOnMeleeAttacked;
      point1 = new Point(392, 232);
      Point point80 = point1;
      editOnMeleeAttacked1.Location = point80;
      btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked";
      Button editOnMeleeAttacked2 = btnEditOnMeleeAttacked;
      size1 = new Size(32, 23);
      Size size77 = size1;
      editOnMeleeAttacked2.Size = size77;
      btnEditOnMeleeAttacked.TabIndex = 35;
      btnEditOnMeleeAttacked.Text = "Edit";
      btnEditOnMeleeAttacked.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnOpen1 = btnEditOnOpen;
      point1 = new Point(392, 260);
      Point point81 = point1;
      btnEditOnOpen1.Location = point81;
      btnEditOnOpen.Name = "btnEditOnOpen";
      Button btnEditOnOpen2 = btnEditOnOpen;
      size1 = new Size(32, 23);
      Size size78 = size1;
      btnEditOnOpen2.Size = size78;
      btnEditOnOpen.TabIndex = 35;
      btnEditOnOpen.Text = "Edit";
      btnEditOnOpen.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnUnlock1 = btnEditOnUnlock;
      point1 = new Point(392, 344);
      Point point82 = point1;
      btnEditOnUnlock1.Location = point82;
      btnEditOnUnlock.Name = "btnEditOnUnlock";
      Button btnEditOnUnlock2 = btnEditOnUnlock;
      size1 = new Size(32, 23);
      Size size79 = size1;
      btnEditOnUnlock2.Size = size79;
      btnEditOnUnlock.TabIndex = 31;
      btnEditOnUnlock.Text = "Edit";
      btnEditOnUnlock.TextAlign = ContentAlignment.MiddleLeft;
      TabPageAdvanced.Controls.Add(cmbxFaction);
      TabPageAdvanced.Controls.Add(chkbNotInterruptable);
      TabPageAdvanced.Controls.Add(tbConversation);
      TabPageAdvanced.Controls.Add(tbTemplateResRef);
      TabPageAdvanced.Controls.Add(Label10);
      TabPageAdvanced.Controls.Add(Label11);
      TabPageAdvanced.Controls.Add(Label13);
      TabPageAdvanced.Controls.Add(Label14);
      TabPageAdvanced.Controls.Add(tbAnimationState);
      TabPage tabPageAdvanced1 = TabPageAdvanced;
      point1 = new Point(4, 22);
      Point point83 = point1;
      ((Control) tabPageAdvanced1).Location = point83;
      TabPageAdvanced.Name = "TabPageAdvanced";
      TabPage tabPageAdvanced2 = TabPageAdvanced;
      size1 = new Size(448, 414);
      Size size80 = size1;
      tabPageAdvanced2.Size = size80;
      TabPageAdvanced.TabIndex = 5;
      TabPageAdvanced.Text = "Advanced";
      cmbxFaction.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxFaction1 = cmbxFaction;
      point1 = new Point(168, 80);
      Point point84 = point1;
      cmbxFaction1.Location = point84;
      cmbxFaction.Name = "cmbxFaction";
      ComboBox cmbxFaction2 = cmbxFaction;
      size1 = new Size(120, 21);
      Size size81 = size1;
      cmbxFaction2.Size = size81;
      cmbxFaction.TabIndex = 4;
      CheckBox notInterruptable1 = chkbNotInterruptable;
      point1 = new Point(352, 136);
      Point point85 = point1;
      notInterruptable1.Location = point85;
      chkbNotInterruptable.Name = "chkbNotInterruptable";
      CheckBox notInterruptable2 = chkbNotInterruptable;
      size1 = new Size(84, 24);
      Size size82 = size1;
      notInterruptable2.Size = size82;
      chkbNotInterruptable.TabIndex = 2;
      chkbNotInterruptable.Text = "No Interrupt";
      TextBox tbConversation1 = tbConversation;
      point1 = new Point(168, 136);
      Point point86 = point1;
      tbConversation1.Location = point86;
      tbConversation.Name = "tbConversation";
      TextBox tbConversation2 = tbConversation;
      size1 = new Size(168, 20);
      Size size83 = size1;
      tbConversation2.Size = size83;
      tbConversation.TabIndex = 1;
      tbConversation.Text = "";
      tbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbTemplateResRef1 = tbTemplateResRef;
      point1 = new Point(168, 32);
      Point point87 = point1;
      tbTemplateResRef1.Location = point87;
      tbTemplateResRef.MaxLength = 16;
      tbTemplateResRef.Name = "tbTemplateResRef";
      TextBox tbTemplateResRef2 = tbTemplateResRef;
      size1 = new Size(200, 20);
      Size size84 = size1;
      tbTemplateResRef2.Size = size84;
      tbTemplateResRef.TabIndex = 3;
      tbTemplateResRef.Text = "";
      Label label10_1 = Label10;
      point1 = new Point(52, 32);
      Point point88 = point1;
      label10_1.Location = point88;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(100, 16);
      Size size85 = size1;
      label10_2.Size = size85;
      Label10.TabIndex = 2;
      Label10.Text = "Template ResRef";
      Label10.TextAlign = ContentAlignment.MiddleLeft;
      Label label11_1 = Label11;
      point1 = new Point(56, 80);
      Point point89 = point1;
      label11_1.Location = point89;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(100, 16);
      Size size86 = size1;
      label11_2.Size = size86;
      Label11.TabIndex = 2;
      Label11.Text = "Faction";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      Label label13_1 = Label13;
      point1 = new Point(56, 136);
      Point point90 = point1;
      label13_1.Location = point90;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(100, 16);
      Size size87 = size1;
      label13_2.Size = size87;
      Label13.TabIndex = 2;
      Label13.Text = "Conversation";
      Label13.TextAlign = ContentAlignment.MiddleLeft;
      Label label14_1 = Label14;
      point1 = new Point(56, 184);
      Point point91 = point1;
      label14_1.Location = point91;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(100, 16);
      Size size88 = size1;
      label14_2.Size = size88;
      Label14.TabIndex = 2;
      Label14.Text = "Animation State";
      Label14.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbAnimationState1 = tbAnimationState;
      point1 = new Point(168, 184);
      Point point92 = point1;
      tbAnimationState1.Location = point92;
      tbAnimationState.Name = "tbAnimationState";
      TextBox tbAnimationState2 = tbAnimationState;
      size1 = new Size(32, 20);
      Size size89 = size1;
      tbAnimationState2.Size = size89;
      tbAnimationState.TabIndex = 3;
      tbAnimationState.Text = "";
      TabPageDescription.Controls.Add(btnSetDescriptionLang);
      TabPageDescription.Controls.Add(tbDescription);
      TabPage tabPageDescription1 = TabPageDescription;
      point1 = new Point(4, 22);
      Point point93 = point1;
      ((Control) tabPageDescription1).Location = point93;
      TabPageDescription.Name = "TabPageDescription";
      TabPage tabPageDescription2 = TabPageDescription;
      size1 = new Size(448, 414);
      Size size90 = size1;
      tabPageDescription2.Size = size90;
      TabPageDescription.TabIndex = 6;
      TabPageDescription.Text = "Description";
      Button setDescriptionLang1 = btnSetDescriptionLang;
      point1 = new Point(40, 320);
      Point point94 = point1;
      setDescriptionLang1.Location = point94;
      btnSetDescriptionLang.Name = "btnSetDescriptionLang";
      Button setDescriptionLang2 = btnSetDescriptionLang;
      size1 = new Size(88, 23);
      Size size91 = size1;
      setDescriptionLang2.Size = size91;
      btnSetDescriptionLang.TabIndex = 5;
      btnSetDescriptionLang.Text = "Set Language";
      TextBox tbDescription1 = tbDescription;
      point1 = new Point(12, 7);
      Point point95 = point1;
      tbDescription1.Location = point95;
      tbDescription.Multiline = true;
      tbDescription.Name = "tbDescription";
      TextBox tbDescription2 = tbDescription;
      size1 = new Size(424, 305);
      Size size92 = size1;
      tbDescription2.Size = size92;
      tbDescription.TabIndex = 1;
      tbDescription.Text = "";
      TabPageComments.Controls.Add(tbComment);
      TabPage tabPageComments1 = TabPageComments;
      point1 = new Point(4, 22);
      Point point96 = point1;
      ((Control) tabPageComments1).Location = point96;
      TabPageComments.Name = "TabPageComments";
      TabPage tabPageComments2 = TabPageComments;
      size1 = new Size(448, 414);
      Size size93 = size1;
      tabPageComments2.Size = size93;
      TabPageComments.TabIndex = 7;
      TabPageComments.Text = "Comments";
      TextBox tbComment1 = tbComment;
      point1 = new Point(12, 7);
      Point point97 = point1;
      tbComment1.Location = point97;
      tbComment.Multiline = true;
      tbComment.Name = "tbComment";
      TextBox tbComment2 = tbComment;
      size1 = new Size(424, 336);
      Size size94 = size1;
      tbComment2.Size = size94;
      tbComment.TabIndex = 0;
      tbComment.Text = "";
      btnDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 64);
      Point point98 = point1;
      btnDebug1.Location = point98;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size95 = size1;
      btnDebug2.Size = size95;
      btnDebug.TabIndex = 18;
      btnDebug.TabStop = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = this.btnCancel;
      size1 = new Size(496, 501);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(TabControl1);
      Controls.Add(this.btnSave);
      Controls.Add(this.btnCancel);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = nameof (frmUTD_Editor);
      Text = "Door Editor - KotOR ";
      TabControl1.ResumeLayout(false);
      TabPageBasic.ResumeLayout(false);
      nudWill.EndInit();
      nudFort.EndInit();
      nudHP.EndInit();
      nudHardness.EndInit();
      nudRef.EndInit();
      TabPageLock.ResumeLayout(false);
      nudCloseLockDC.EndInit();
      nudOpenLockDC.EndInit();
      TabPageScripts.ResumeLayout(false);
      TabPageAdvanced.ResumeLayout(false);
      TabPageDescription.ResumeLayout(false);
      TabPageComments.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmUTD_Editor(
    clsUTD UTDClass,
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
      MDefaultTitleText = "Door Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      UTD = UTDClass;
      KotorVersionIndex = KotorVerIndex;
      Setup();
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  public void Setup()
  {
      BuildComboBoxes();
      UTD.SetTextBoxFromCExoLocStringNodeValue(tbName, "LocName");
      UTD.SetTextBoxToNodeValue(tbTag, "Tag");
      UTD.SetNumericUpDownToNodeValue(nudHardness, "Hardness");
      UTD.SetNumericUpDownToNodeValue(nudHP, "HP");
      UTD.SetNumericUpDownToNodeValue(nudFort, "Fort");
      UTD.SetNumericUpDownToNodeValue(nudRef, "Ref");
      UTD.SetNumericUpDownToNodeValue(nudWill, "Will");
      chkbStatic.Checked = BooleanType.FromObject(UTD.GetNodeValue("Static"));
      chkbLocked.Checked = BooleanType.FromObject(UTD.GetNodeValue("Locked"));
      chkbLockable.Checked = BooleanType.FromObject(UTD.GetNodeValue("Lockable"));
      chkbAutoRemoveKey.Checked = BooleanType.FromObject(UTD.GetNodeValue("AutoRemoveKey"));
      chkbKeyRequired.Checked = BooleanType.FromObject(UTD.GetNodeValue("KeyRequired"));
      UTD.SetNumericUpDownToNodeValue(nudOpenLockDC, "OpenLockDC");
      UTD.SetNumericUpDownToNodeValue(nudCloseLockDC, "CloseLockDC");
      UTD.SetTextBoxToNodeValue(tbKeyName, "KeyName");
      if (KotorVersionIndex == 1)
      {
        int num1 = IntegerType.FromObject(UTD.GetNodeValue("OpenState"));
        if (num1 > 1)
        {
          cmbxOpenState.BackColor = Color.Tomato;
          int num2 = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
        }
        else
          cmbxOpenState.SelectedIndex = num1;
        chkbNotBlastable.Checked = BooleanType.FromObject(UTD.GetNodeValue("NotBlastable"));
      }
      else
      {
        cmbxOpenState.Visible = false;
        chkbNotBlastable.Visible = false;
        lblOpenState.Visible = false;
      }
      UTD.SetTextBoxToNodeValue(tbOnClick, "OnClick");
      UTD.SetTextBoxToNodeValue(tbOnClosed, "OnClosed");
      UTD.SetTextBoxToNodeValue(tbOnDamaged, "OnDamaged");
      UTD.SetTextBoxToNodeValue(tbOnDeath, "OnDeath");
      UTD.SetTextBoxToNodeValue(tbOnDisarm, "OnDisarm");
      UTD.SetTextBoxToNodeValue(tbOnFailToOpen, "OnFailToOpen");
      UTD.SetTextBoxToNodeValue(tbOnHeartbeat, "OnHeartbeat");
      UTD.SetTextBoxToNodeValue(tbOnLock, "OnLock");
      UTD.SetTextBoxToNodeValue(tbOnMeleeAttacked, "OnMeleeAttacked");
      UTD.SetTextBoxToNodeValue(tbOnOpen, "OnOpen");
      UTD.SetTextBoxToNodeValue(tbOnSpellCastAt, "OnSpellCastAt");
      UTD.SetTextBoxToNodeValue(tbOnTrapTriggered, "OnTrapTriggered");
      UTD.SetTextBoxToNodeValue(tbOnUnlock, "OnUnlock");
      UTD.SetTextBoxToNodeValue(tbOnUserDefined, "OnUserDefined");
      UTD.SetTextBoxToNodeValue(tbTemplateResRef, "TemplateResRef");
      UTD.SetTextBoxToNodeValue(tbConversation, "Conversation");
      chkbNotInterruptable.Checked = BooleanType.FromObject(ObjectType.NotObj(UTD.GetNodeValue("Interruptable")));
      UTD.SetTextBoxToNodeValue(tbAnimationState, "AnimationState");
      UTD.SetTextBoxFromCExoLocStringNodeValue(tbDescription, "Description");
      DescriptionLang = IntegerType.FromObject(UTD.GetCExoLocStringLanguage("Description"));
      tbDescription.Text = Strings.Replace(tbDescription.Text, "\n", "\r\n");
      UTD.SetTextBoxToNodeValue(tbComment, "Comment");
      if (!ComboBoxSettingError)
        return;
      int num = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
    }

  private void SetGFFNodeValues()
  {
      UTD.SetCExoLocStringNodeValueFromTextBox(tbName, "LocName", NameLang);
      UTD.SetNodeValueFromTextBox(tbTag, "Tag");
      UTD.SetNodeValueFromNumericUpDown(nudHardness, "Hardness");
      UTD.SetNodeValueFromNumericUpDown(nudHP, "HP");
      UTD.SetNodeValueFromNumericUpDown(nudFort, "Fort");
      UTD.SetNodeValueFromNumericUpDown(nudRef, "Ref");
      UTD.SetNodeValueFromNumericUpDown(nudWill, "Will");
      if (!UTD.VerifyNodeExists("Static"))
        UTD.AddFieldToStruct("", "Static", 0, chkbStatic.Checked);
      else
        UTD.SetNodeValue("Static", chkbStatic.Checked);
      UTD.SetNodeValueFromComboBox(cmbxDoorType, "GenericType");
      UTD.SetNodeValue("Locked", chkbLocked.Checked);
      UTD.SetNodeValue("Lockable", chkbLockable.Checked);
      UTD.SetNodeValue("AutoRemoveKey", chkbAutoRemoveKey.Checked);
      UTD.SetNodeValue("KeyRequired", chkbKeyRequired.Checked);
      UTD.SetNodeValueFromTextBox(tbKeyName, "KeyName");
      UTD.SetNodeValueFromNumericUpDown(nudOpenLockDC, "OpenLockDC");
      UTD.SetNodeValueFromNumericUpDown(nudCloseLockDC, "CloseLockDC");
      if (KotorVersionIndex == 1)
      {
        UTD.SetNodeValue("NotBlastable", chkbNotBlastable.Checked);
        UTD.SetNodeValue("OpenState", cmbxOpenState.SelectedIndex);
      }
      UTD.SetNodeValueFromTextBox(tbOnClick, "OnClick");
      UTD.SetNodeValueFromTextBox(tbOnClosed, "OnClosed");
      UTD.SetNodeValueFromTextBox(tbOnDamaged, "OnDamaged");
      UTD.SetNodeValueFromTextBox(tbOnDeath, "OnDeath");
      UTD.SetNodeValueFromTextBox(tbOnDisarm, "OnDisarm");
      UTD.SetNodeValueFromTextBox(tbOnFailToOpen, "OnFailToOpen");
      UTD.SetNodeValueFromTextBox(tbOnHeartbeat, "OnHeartbeat");
      UTD.SetNodeValueFromTextBox(tbOnLock, "OnLock");
      UTD.SetNodeValueFromTextBox(tbOnMeleeAttacked, "OnMeleeAttacked");
      UTD.SetNodeValueFromTextBox(tbOnOpen, "OnOpen");
      UTD.SetNodeValueFromTextBox(tbOnSpellCastAt, "OnSpellCastAt");
      UTD.SetNodeValueFromTextBox(tbOnTrapTriggered, "OnTrapTriggered");
      UTD.SetNodeValueFromTextBox(tbOnUnlock, "OnUnlock");
      UTD.SetNodeValueFromTextBox(tbOnUserDefined, "OnUserDefined");
      UTD.SetNodeValueFromTextBox(tbTemplateResRef, "TemplateResRef");
      UTD.SetNodeValueFromComboBox(cmbxFaction, "Faction");
      UTD.SetNodeValueFromTextBox(tbConversation, "Conversation");
      UTD.SetNodeValue("Interruptable", !chkbNotInterruptable.Checked);
      UTD.SetNodeValueFromTextBox(tbAnimationState, "AnimationState");
      UTD.SetCExoLocStringNodeValueFromTextBox(tbDescription, "Description");
      UTD.SetCExoLocStringNodeValueFromTextBox(new TextBox()
      {
        Text = Strings.Replace(tbDescription.Text, "\r\n", "\n")
      }, "Description", DescriptionLang);
      UTD.SetNodeValueFromTextBox(tbComment, "Comment");
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
      GChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVersionIndex));
      FillComboBoxFrom2DA(cmbxDoorType, "label", "genericdoors", GChitinKey, null);
      if (!UTD.SyncComboBox(cmbxDoorType, "GenericType"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxFaction, "label", "repute", GChitinKey, null);
      if (!UTD.SyncComboBox(cmbxFaction, "Faction"))
        ComboBoxSettingError = true;
      GChitinKey = null;
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

  private void chkbLocked_CheckedChanged(object sender, EventArgs e)
  {
      if (chkbLockable.Checked)
        return;
      bool flag = BooleanType.FromObject(LateBinding.LateGet(sender, null, "checked", new object[0], null, null));
      chkbAutoRemoveKey.Enabled = flag;
      chkbKeyRequired.Enabled = flag;
      lblOpenLockDC.Enabled = flag;
      lblKeyTag.Enabled = flag;
      tbKeyName.Enabled = flag;
      nudOpenLockDC.Enabled = flag;
      chkbNotBlastable.Enabled = flag;
    }

  private void chkbLockable_CheckedChanged(object sender, EventArgs e)
  {
      bool flag = BooleanType.FromObject(LateBinding.LateGet(sender, null, "checked", new object[0], null, null));
      if (!chkbLocked.Checked)
      {
        chkbAutoRemoveKey.Enabled = flag;
        chkbKeyRequired.Enabled = flag;
        lblOpenLockDC.Enabled = flag;
        lblKeyTag.Enabled = flag;
        tbKeyName.Enabled = flag;
        nudOpenLockDC.Enabled = flag;
        chkbNotBlastable.Enabled = flag;
      }
      lblCloseLockDC.Enabled = flag;
      nudCloseLockDC.Enabled = flag;
    }

  private void btnSave_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".utd", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTD.WriteFile(MEditingFilePath, "UTD");
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

  private void btnSetDescLang_Click(object sender, EventArgs e)
  {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(DescriptionLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      DescriptionLang = stringLanguagePicker.LanguageID;
    }

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = tbName.Text + ".utd";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTD.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void frmUTD_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmUTD_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

  public void SetFormName(string Name) => Text = "Door Editor - " + Name;

  private void btnEditScript_Click(object sender, EventArgs e) => Utils.EditScriptForTextBox((Button) sender, MEditingFilePath, KotorVersionIndex);
}