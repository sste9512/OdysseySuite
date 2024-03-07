using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTP_Editor : frmParent
{
  [AccessedThroughProperty("Label43")]
  private Label _Label43;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("tbKeyName")]
  private TextBox _tbKeyName;
  [AccessedThroughProperty("Label42")]
  private Label _Label42;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("tbComment")]
  private TextBox _tbComment;
  [AccessedThroughProperty("Label41")]
  private Label _Label41;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("tbOnUserDefined")]
  private TextBox _tbOnUserDefined;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("tbOnUnlock")]
  private TextBox _tbOnUnlock;
  [AccessedThroughProperty("tbOnEndDialogue")]
  private TextBox _tbOnEndDialogue;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("tbOnUsed")]
  private TextBox _tbOnUsed;
  [AccessedThroughProperty("tbType")]
  private TextBox _tbType;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("tbOnTrapTriggered")]
  private TextBox _tbOnTrapTriggered;
  [AccessedThroughProperty("chkbHasInventory")]
  private CheckBox _chkbHasInventory;
  [AccessedThroughProperty("chkbMin1HP")]
  private CheckBox _chkbMin1HP;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("tbOnSpellCastAt")]
  private TextBox _tbOnSpellCastAt;
  [AccessedThroughProperty("chkbTrapOneShot")]
  private CheckBox _chkbTrapOneShot;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("btnEditOnUserDefined")]
  private Button _btnEditOnUserDefined;
  [AccessedThroughProperty("chkbTrapFlag")]
  private CheckBox _chkbTrapFlag;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("tbOnOpen")]
  private TextBox _tbOnOpen;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("tbOnMeleeAttacked")]
  private TextBox _tbOnMeleeAttacked;
  [AccessedThroughProperty("chkbPartyInteract")]
  private CheckBox _chkbPartyInteract;
  [AccessedThroughProperty("tbOnInvDisturbed")]
  private TextBox _tbOnInvDisturbed;
  [AccessedThroughProperty("chkbUsable")]
  private CheckBox _chkbUsable;
  [AccessedThroughProperty("btnEditOnUnlock")]
  private Button _btnEditOnUnlock;
  [AccessedThroughProperty("nudTrapType")]
  private NumericUpDown _nudTrapType;
  [AccessedThroughProperty("btnEditOnOpen")]
  private Button _btnEditOnOpen;
  [AccessedThroughProperty("lblTrapDetectable")]
  private Label _lblTrapDetectable;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("tbOnLock")]
  private TextBox _tbOnLock;
  [AccessedThroughProperty("tbOnDisarm")]
  private TextBox _tbOnDisarm;
  [AccessedThroughProperty("tbOnClosed")]
  private TextBox _tbOnClosed;
  [AccessedThroughProperty("chkbInterruptable")]
  private CheckBox _chkbInterruptable;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("btnEditOnDeath")]
  private Button _btnEditOnDeath;
  [AccessedThroughProperty("btnEditOnHeartbeat")]
  private Button _btnEditOnHeartbeat;
  [AccessedThroughProperty("lblBodyVariation")]
  private Label _lblBodyVariation;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("lblTextureVariation")]
  private Label _lblTextureVariation;
  [AccessedThroughProperty("btnEditOnMeleeAttacked")]
  private Button _btnEditOnMeleeAttacked;
  [AccessedThroughProperty("nudTrapDetectDC")]
  private NumericUpDown _nudTrapDetectDC;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("btnEditOnLock")]
  private Button _btnEditOnLock;
  [AccessedThroughProperty("tbOnDeath")]
  private TextBox _tbOnDeath;
  [AccessedThroughProperty("chkbTrapDisarmable")]
  private CheckBox _chkbTrapDisarmable;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("chkbPlotItem")]
  private CheckBox _chkbPlotItem;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("nudDisarmDC")]
  private NumericUpDown _nudDisarmDC;
  [AccessedThroughProperty("TabPageComments")]
  private TabPage _TabPageComments;
  [AccessedThroughProperty("chkbTrapDetectable")]
  private CheckBox _chkbTrapDetectable;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("btnEditOnClosed")]
  private Button _btnEditOnClosed;
  [AccessedThroughProperty("TabPageDescription")]
  private TabPage _TabPageDescription;
  [AccessedThroughProperty("btnEditOnEndDialogue")]
  private Button _btnEditOnEndDialogue;
  [AccessedThroughProperty("btnEditOnSpellCastAt")]
  private Button _btnEditOnSpellCastAt;
  [AccessedThroughProperty("TabPageTrap")]
  private TabPage _TabPageTrap;
  [AccessedThroughProperty("btnEditOnUsed")]
  private Button _btnEditOnUsed;
  [AccessedThroughProperty("btnEditOnDamaged")]
  private Button _btnEditOnDamaged;
  [AccessedThroughProperty("tbFaction")]
  private TextBox _tbFaction;
  [AccessedThroughProperty("btnEditOnDisarm")]
  private Button _btnEditOnDisarm;
  [AccessedThroughProperty("tbConversation")]
  private TextBox _tbConversation;
  [AccessedThroughProperty("nudCloseLockDC")]
  private NumericUpDown _nudCloseLockDC;
  [AccessedThroughProperty("btnEditOnTrapTriggered")]
  private Button _btnEditOnTrapTriggered;
  [AccessedThroughProperty("tbDescription")]
  private TextBox _tbDescription;
  [AccessedThroughProperty("cmbxAppearance")]
  private ComboBox _cmbxAppearance;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("TabPageAdvanced")]
  private TabPage _TabPageAdvanced;
  [AccessedThroughProperty("TabPageScripts")]
  private TabPage _TabPageScripts;
  [AccessedThroughProperty("tbTemplateResRef")]
  private TextBox _tbTemplateResRef;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("TabPageLock")]
  private TabPage _TabPageLock;
  [AccessedThroughProperty("TabPageBasic")]
  private TabPage _TabPageBasic;
  [AccessedThroughProperty("tbOnDamaged")]
  private TextBox _tbOnDamaged;
  [AccessedThroughProperty("nudOpenLockDC")]
  private NumericUpDown _nudOpenLockDC;
  [AccessedThroughProperty("tbOnHeartbeat")]
  private TextBox _tbOnHeartbeat;
  [AccessedThroughProperty("btnInventory")]
  private Button _btnInventory;
  [AccessedThroughProperty("chkbStatic")]
  private CheckBox _chkbStatic;
  [AccessedThroughProperty("lblOpenLockDC")]
  private Label _lblOpenLockDC;
  [AccessedThroughProperty("lblCloseLockDC")]
  private Label _lblCloseLockDC;
  [AccessedThroughProperty("lblKeyTag")]
  private Label _lblKeyTag;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("tbAnimationState")]
  private TextBox _tbAnimationState;
  [AccessedThroughProperty("nudRef")]
  private NumericUpDown _nudRef;
  [AccessedThroughProperty("chkbLockable")]
  private CheckBox _chkbLockable;
  [AccessedThroughProperty("tbName")]
  private TextBox _tbName;
  [AccessedThroughProperty("chkbLocked")]
  private CheckBox _chkbLocked;
  [AccessedThroughProperty("nudHardness")]
  private NumericUpDown _nudHardness;
  [AccessedThroughProperty("btnEditOnInvDisturbed")]
  private Button _btnEditOnInvDisturbed;
  [AccessedThroughProperty("nudHP")]
  private NumericUpDown _nudHP;
  [AccessedThroughProperty("nudFort")]
  private NumericUpDown _nudFort;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("chkbKeyRequired")]
  private CheckBox _chkbKeyRequired;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnSetNameLang")]
  private Button _btnSetNameLang;
  [AccessedThroughProperty("nudWill")]
  private NumericUpDown _nudWill;
  [AccessedThroughProperty("chkbAutoRemoveKey")]
  private CheckBox _chkbAutoRemoveKey;
  [AccessedThroughProperty("btnSetDescriptionLang")]
  private Button _btnSetDescriptionLang;
  private IContainer components;
  public clsUTP UTP;
  public clsDialogTlk g_clsDialogTlk;
  public ChitinKey GChitinKey;
  private int DescriptionLang;
  private int NameLang;
  private bool m_bSaveGameMode;

  public frmUTP_Editor()
  {
      Load += new EventHandler(frmUTP_Editor_Load);
      Closing += new CancelEventHandler(frmUTP_Editor_Closing);
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
    get => _nudFort;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFort == null)
          ;
        _nudFort = value;
        if (_nudFort == null)
          ;
      }
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

  internal virtual Label lblTextureVariation
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblTextureVariation == null)
          ;
        _lblTextureVariation = value;
        if (_lblTextureVariation == null)
          ;
      }
    get => _lblTextureVariation;
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

  internal virtual NumericUpDown nudHardness
  {
    get => _nudHardness;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudHardness == null)
          ;
        _nudHardness = value;
        if (_nudHardness == null)
          ;
      }
  }

  internal virtual NumericUpDown nudRef
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudRef == null)
          ;
        _nudRef = value;
        if (_nudRef == null)
          ;
      }
    get => _nudRef;
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
    get => _lblBodyVariation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblBodyVariation == null)
          ;
        _lblBodyVariation = value;
        if (_lblBodyVariation == null)
          ;
      }
  }

  internal virtual CheckBox chkbPlotItem
  {
    get => _chkbPlotItem;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbPlotItem == null)
          ;
        _chkbPlotItem = value;
        if (_chkbPlotItem == null)
          ;
      }
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
    get => _Label2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label2 == null)
          ;
        _Label2 = value;
        if (_Label2 == null)
          ;
      }
  }

  internal virtual CheckBox chkbStatic
  {
    get => _chkbStatic;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbStatic == null)
          ;
        _chkbStatic = value;
        if (_chkbStatic == null)
          ;
      }
  }

  internal virtual TabPage TabPageLock
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageLock == null)
          ;
        _TabPageLock = value;
        if (_TabPageLock == null)
          ;
      }
    get => _TabPageLock;
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

  internal virtual NumericUpDown nudCloseLockDC
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCloseLockDC == null)
          ;
        _nudCloseLockDC = value;
        if (_nudCloseLockDC == null)
          ;
      }
    get => _nudCloseLockDC;
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

  internal virtual NumericUpDown nudOpenLockDC
  {
    get => _nudOpenLockDC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudOpenLockDC == null)
          ;
        _nudOpenLockDC = value;
        if (_nudOpenLockDC == null)
          ;
      }
  }

  internal virtual Label lblOpenLockDC
  {
    get => _lblOpenLockDC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblOpenLockDC == null)
          ;
        _lblOpenLockDC = value;
        if (_lblOpenLockDC == null)
          ;
      }
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
    get => _chkbLocked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbLocked != null)
          _chkbLocked.CheckedChanged -= new EventHandler(chkbLocked_CheckedChanged);
        _chkbLocked = value;
        if (_chkbLocked == null)
          return;
        _chkbLocked.CheckedChanged += new EventHandler(chkbLocked_CheckedChanged);
      }
  }

  internal virtual CheckBox chkbKeyRequired
  {
    get => _chkbKeyRequired;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbKeyRequired == null)
          ;
        _chkbKeyRequired = value;
        if (_chkbKeyRequired == null)
          ;
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

  internal virtual Label Label34
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label34 == null)
          ;
        _Label34 = value;
        if (_Label34 == null)
          ;
      }
    get => _Label34;
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

  internal virtual Label Label33
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label33 == null)
          ;
        _Label33 = value;
        if (_Label33 == null)
          ;
      }
    get => _Label33;
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

  internal virtual TextBox tbOnClosed
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnClosed == null)
          ;
        _tbOnClosed = value;
        if (_tbOnClosed == null)
          ;
      }
    get => _tbOnClosed;
  }

  internal virtual Label Label35
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label35 == null)
          ;
        _Label35 = value;
        if (_Label35 == null)
          ;
      }
    get => _Label35;
  }

  internal virtual TextBox tbOnDisarm
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDisarm == null)
          ;
        _tbOnDisarm = value;
        if (_tbOnDisarm == null)
          ;
      }
    get => _tbOnDisarm;
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

  internal virtual Label Label36
  {
    get => _Label36;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label36 == null)
          ;
        _Label36 = value;
        if (_Label36 == null)
          ;
      }
  }

  internal virtual Label Label37
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label37 == null)
          ;
        _Label37 = value;
        if (_Label37 == null)
          ;
      }
    get => _Label37;
  }

  internal virtual TextBox tbOnLock
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnLock == null)
          ;
        _tbOnLock = value;
        if (_tbOnLock == null)
          ;
      }
    get => _tbOnLock;
  }

  internal virtual TextBox tbOnMeleeAttacked
  {
    get => _tbOnMeleeAttacked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnMeleeAttacked == null)
          ;
        _tbOnMeleeAttacked = value;
        if (_tbOnMeleeAttacked == null)
          ;
      }
  }

  internal virtual Label Label38
  {
    get => _Label38;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label38 == null)
          ;
        _Label38 = value;
        if (_Label38 == null)
          ;
      }
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
    get => _Label40;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label40 == null)
          ;
        _Label40 = value;
        if (_Label40 == null)
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

  internal virtual Label Label41
  {
    get => _Label41;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label41 == null)
          ;
        _Label41 = value;
        if (_Label41 == null)
          ;
      }
  }

  internal virtual TextBox tbOnTrapTriggered
  {
    get => _tbOnTrapTriggered;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnTrapTriggered == null)
          ;
        _tbOnTrapTriggered = value;
        if (_tbOnTrapTriggered == null)
          ;
      }
  }

  internal virtual TextBox tbOnUnlock
  {
    get => _tbOnUnlock;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnUnlock == null)
          ;
        _tbOnUnlock = value;
        if (_tbOnUnlock == null)
          ;
      }
  }

  internal virtual Label Label42
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label42 == null)
          ;
        _Label42 = value;
        if (_Label42 == null)
          ;
      }
    get => _Label42;
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

  internal virtual Label Label43
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label43 == null)
          ;
        _Label43 = value;
        if (_Label43 == null)
          ;
      }
    get => _Label43;
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

  internal virtual TextBox tbFaction
  {
    get => _tbFaction;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFaction == null)
          ;
        _tbFaction = value;
        if (_tbFaction == null)
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

  internal virtual Label Label14
  {
    get => _Label14;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label14 == null)
          ;
        _Label14 = value;
        if (_Label14 == null)
          ;
      }
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

  internal virtual TabPage TabPageDescription
  {
    get => _TabPageDescription;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageDescription == null)
          ;
        _TabPageDescription = value;
        if (_TabPageDescription == null)
          ;
      }
  }

  internal virtual Button btnSetDescriptionLang
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSetDescriptionLang != null)
          _btnSetDescriptionLang.Click -= new EventHandler(btnSetDescLang_Click);
        _btnSetDescriptionLang = value;
        if (_btnSetDescriptionLang == null)
          return;
        _btnSetDescriptionLang.Click += new EventHandler(btnSetDescLang_Click);
      }
    get => _btnSetDescriptionLang;
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

  internal virtual TabPage TabPageComments
  {
    get => _TabPageComments;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageComments == null)
          ;
        _TabPageComments = value;
        if (_TabPageComments == null)
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

  internal virtual CheckBox chkbMin1HP
  {
    get => _chkbMin1HP;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbMin1HP == null)
          ;
        _chkbMin1HP = value;
        if (_chkbMin1HP == null)
          ;
      }
  }

  internal virtual TabPage TabPageTrap
  {
    get => _TabPageTrap;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_TabPageTrap == null)
          ;
        _TabPageTrap = value;
        if (_TabPageTrap == null)
          ;
      }
  }

  internal virtual CheckBox chkbTrapDisarmable
  {
    get => _chkbTrapDisarmable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTrapDisarmable == null)
          ;
        _chkbTrapDisarmable = value;
        if (_chkbTrapDisarmable == null)
          ;
      }
  }

  internal virtual CheckBox chkbTrapDetectable
  {
    get => _chkbTrapDetectable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbTrapDetectable == null)
          ;
        _chkbTrapDetectable = value;
        if (_chkbTrapDetectable == null)
          ;
      }
  }

  internal virtual Label Label6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 == null)
          ;
      }
    get => _Label6;
  }

  internal virtual Label Label3
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 == null)
          ;
      }
    get => _Label3;
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

  internal virtual Label Label15
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label15 == null)
          ;
        _Label15 = value;
        if (_Label15 == null)
          ;
      }
    get => _Label15;
  }

  internal virtual NumericUpDown nudTrapDetectDC
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTrapDetectDC == null)
          ;
        _nudTrapDetectDC = value;
        if (_nudTrapDetectDC == null)
          ;
      }
    get => _nudTrapDetectDC;
  }

  internal virtual Label Label16
  {
    get => _Label16;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label16 == null)
          ;
        _Label16 = value;
        if (_Label16 == null)
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTrapType == null)
          ;
        _nudTrapType = value;
        if (_nudTrapType == null)
          ;
      }
    get => _nudTrapType;
  }

  internal virtual Label Label17
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label17 == null)
          ;
        _Label17 = value;
        if (_Label17 == null)
          ;
      }
    get => _Label17;
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

  internal virtual ComboBox cmbxAppearance
  {
    get => _cmbxAppearance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxAppearance == null)
          ;
        _cmbxAppearance = value;
        if (_cmbxAppearance == null)
          ;
      }
  }

  internal virtual Label Label20
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label20 == null)
          ;
        _Label20 = value;
        if (_Label20 == null)
          ;
      }
    get => _Label20;
  }

  internal virtual TextBox tbType
  {
    get => _tbType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbType == null)
          ;
        _tbType = value;
        if (_tbType == null)
          ;
      }
  }

  internal virtual TextBox tbOnUsed
  {
    get => _tbOnUsed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnUsed == null)
          ;
        _tbOnUsed = value;
        if (_tbOnUsed == null)
          ;
      }
  }

  internal virtual Label Label18
  {
    get => _Label18;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label18 == null)
          ;
        _Label18 = value;
        if (_Label18 == null)
          ;
      }
  }

  internal virtual Label Label21
  {
    get => _Label21;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label21 == null)
          ;
        _Label21 = value;
        if (_Label21 == null)
          ;
      }
  }

  internal virtual TextBox tbOnEndDialogue
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnEndDialogue == null)
          ;
        _tbOnEndDialogue = value;
        if (_tbOnEndDialogue == null)
          ;
      }
    get => _tbOnEndDialogue;
  }

  internal virtual TextBox tbOnInvDisturbed
  {
    get => _tbOnInvDisturbed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnInvDisturbed == null)
          ;
        _tbOnInvDisturbed = value;
        if (_tbOnInvDisturbed == null)
          ;
      }
  }

  internal virtual Label Label22
  {
    get => _Label22;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label22 == null)
          ;
        _Label22 = value;
        if (_Label22 == null)
          ;
      }
  }

  internal virtual CheckBox chkbHasInventory
  {
    get => _chkbHasInventory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbHasInventory == null)
          ;
        _chkbHasInventory = value;
        if (_chkbHasInventory == null)
          ;
      }
  }

  internal virtual CheckBox chkbPartyInteract
  {
    get => _chkbPartyInteract;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbPartyInteract == null)
          ;
        _chkbPartyInteract = value;
        if (_chkbPartyInteract == null)
          ;
      }
  }

  internal virtual Button btnInventory
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnInventory != null)
          _btnInventory.Click -= new EventHandler(btnInventory_Click);
        _btnInventory = value;
        if (_btnInventory == null)
          return;
        _btnInventory.Click += new EventHandler(btnInventory_Click);
      }
    get => _btnInventory;
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

  internal virtual CheckBox chkbUsable
  {
    get => _chkbUsable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbUsable == null)
          ;
        _chkbUsable = value;
        if (_chkbUsable == null)
          ;
      }
  }

  internal virtual CheckBox chkbInterruptable
  {
    get => _chkbInterruptable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbInterruptable == null)
          ;
        _chkbInterruptable = value;
        if (_chkbInterruptable == null)
          ;
      }
  }

  internal virtual Button btnEditOnClosed
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnClosed != null)
          _btnEditOnClosed.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnClosed = value;
        if (_btnEditOnClosed == null)
          return;
        _btnEditOnClosed.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnClosed;
  }

  internal virtual Button btnEditOnDamaged
  {
    get => _btnEditOnDamaged;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDamaged != null)
          _btnEditOnDamaged.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDamaged = value;
        if (_btnEditOnDamaged == null)
          return;
        _btnEditOnDamaged.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnDeath
  {
    get => _btnEditOnDeath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDeath != null)
          _btnEditOnDeath.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDeath = value;
        if (_btnEditOnDeath == null)
          return;
        _btnEditOnDeath.Click += new EventHandler(btnEditScript_Click);
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

  internal virtual Button btnEditOnHeartbeat
  {
    get => _btnEditOnHeartbeat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnHeartbeat != null)
          _btnEditOnHeartbeat.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnHeartbeat = value;
        if (_btnEditOnHeartbeat == null)
          return;
        _btnEditOnHeartbeat.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnLock
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnLock != null)
          _btnEditOnLock.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnLock = value;
        if (_btnEditOnLock == null)
          return;
        _btnEditOnLock.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnLock;
  }

  internal virtual Button btnEditOnMeleeAttacked
  {
    get => _btnEditOnMeleeAttacked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnMeleeAttacked != null)
          _btnEditOnMeleeAttacked.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnMeleeAttacked = value;
        if (_btnEditOnMeleeAttacked == null)
          return;
        _btnEditOnMeleeAttacked.Click += new EventHandler(btnEditScript_Click);
      }
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

  internal virtual Button btnEditOnSpellCastAt
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnSpellCastAt != null)
          _btnEditOnSpellCastAt.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnSpellCastAt = value;
        if (_btnEditOnSpellCastAt == null)
          return;
        _btnEditOnSpellCastAt.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnSpellCastAt;
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

  internal virtual Button btnEditOnUsed
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnUsed != null)
          _btnEditOnUsed.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnUsed = value;
        if (_btnEditOnUsed == null)
          return;
        _btnEditOnUsed.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnUsed;
  }

  internal virtual Button btnEditOnInvDisturbed
  {
    get => _btnEditOnInvDisturbed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnInvDisturbed != null)
          _btnEditOnInvDisturbed.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnInvDisturbed = value;
        if (_btnEditOnInvDisturbed == null)
          return;
        _btnEditOnInvDisturbed.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnEndDialogue
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnEndDialogue != null)
          _btnEditOnEndDialogue.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnEndDialogue = value;
        if (_btnEditOnEndDialogue == null)
          return;
        _btnEditOnEndDialogue.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnEndDialogue;
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      TabControl1 = new TabControl();
      TabPageBasic = new TabPage();
      Label19 = new Label();
      cmbxAppearance = new ComboBox();
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
      chkbMin1HP = new CheckBox();
      TabPageLock = new TabPage();
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
      TabPageAdvanced = new TabPage();
      chkbPartyInteract = new CheckBox();
      chkbHasInventory = new CheckBox();
      Label20 = new Label();
      tbType = new TextBox();
      chkbInterruptable = new CheckBox();
      tbConversation = new TextBox();
      tbFaction = new TextBox();
      tbTemplateResRef = new TextBox();
      Label10 = new Label();
      Label11 = new Label();
      Label13 = new Label();
      Label14 = new Label();
      tbAnimationState = new TextBox();
      chkbUsable = new CheckBox();
      TabPageScripts = new TabPage();
      tbOnUsed = new TextBox();
      Label18 = new Label();
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
      Label21 = new Label();
      tbOnEndDialogue = new TextBox();
      tbOnInvDisturbed = new TextBox();
      Label22 = new Label();
      TabPageDescription = new TabPage();
      btnSetDescriptionLang = new Button();
      tbDescription = new TextBox();
      TabPageComments = new TabPage();
      tbComment = new TextBox();
      TabPageTrap = new TabPage();
      chkbTrapDisarmable = new CheckBox();
      chkbTrapDetectable = new CheckBox();
      Label6 = new Label();
      Label3 = new Label();
      nudDisarmDC = new NumericUpDown();
      Label4 = new Label();
      Label15 = new Label();
      nudTrapDetectDC = new NumericUpDown();
      Label16 = new Label();
      lblTrapDetectable = new Label();
      nudTrapType = new NumericUpDown();
      Label17 = new Label();
      chkbTrapFlag = new CheckBox();
      chkbTrapOneShot = new CheckBox();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      btnInventory = new Button();
      btnDebug = new Button();
      btnEditOnClosed = new Button();
      btnEditOnDamaged = new Button();
      btnEditOnDeath = new Button();
      btnEditOnDisarm = new Button();
      btnEditOnHeartbeat = new Button();
      btnEditOnLock = new Button();
      btnEditOnMeleeAttacked = new Button();
      btnEditOnOpen = new Button();
      btnEditOnSpellCastAt = new Button();
      btnEditOnTrapTriggered = new Button();
      btnEditOnUserDefined = new Button();
      btnEditOnUnlock = new Button();
      btnEditOnUsed = new Button();
      btnEditOnInvDisturbed = new Button();
      btnEditOnEndDialogue = new Button();
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
      TabPageAdvanced.SuspendLayout();
      TabPageScripts.SuspendLayout();
      TabPageDescription.SuspendLayout();
      TabPageComments.SuspendLayout();
      TabPageTrap.SuspendLayout();
      nudDisarmDC.BeginInit();
      nudTrapDetectDC.BeginInit();
      nudTrapType.BeginInit();
      SuspendLayout();
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(TabPageBasic);
      TabControl1.Controls.Add(TabPageLock);
      TabControl1.Controls.Add(TabPageAdvanced);
      TabControl1.Controls.Add(TabPageScripts);
      TabControl1.Controls.Add(TabPageDescription);
      TabControl1.Controls.Add(TabPageComments);
      TabControl1.Controls.Add(TabPageTrap);
      TabControl tabControl1_1 = TabControl1;
      Point point1 = new Point(19, 11);
      Point point2 = point1;
      tabControl1_1.Location = point2;
      TabControl1.Multiline = true;
      TabControl1.Name = "TabControl1";
      TabControl tabControl1_2 = TabControl1;
      point1 = new Point(15, 3);
      Point point3 = point1;
      tabControl1_2.Padding = point3;
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_3 = TabControl1;
      Size size1 = new Size(456, 461);
      Size size2 = size1;
      tabControl1_3.Size = size2;
      TabControl1.SizeMode = TabSizeMode.FillToRight;
      TabControl1.TabIndex = 0;
      TabPageBasic.Controls.Add(Label19);
      TabPageBasic.Controls.Add(cmbxAppearance);
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
      TabPageBasic.Controls.Add(chkbMin1HP);
      TabPage tabPageBasic1 = TabPageBasic;
      point1 = new Point(4, 40);
      Point point4 = point1;
      ((Control) tabPageBasic1).Location = point4;
      TabPageBasic.Name = "TabPageBasic";
      TabPage tabPageBasic2 = TabPageBasic;
      size1 = new Size(448, 393);
      Size size3 = size1;
      tabPageBasic2.Size = size3;
      TabPageBasic.TabIndex = 0;
      TabPageBasic.Text = "Basic";
      Label label19_1 = Label19;
      point1 = new Point(48, 80);
      Point point5 = point1;
      label19_1.Location = point5;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(80, 16);
      Size size4 = size1;
      label19_2.Size = size4;
      Label19.TabIndex = 10;
      Label19.Text = "Appearance";
      Label19.TextAlign = ContentAlignment.MiddleLeft;
      cmbxAppearance.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxAppearance1 = cmbxAppearance;
      point1 = new Point(128, 80);
      Point point6 = point1;
      cmbxAppearance1.Location = point6;
      cmbxAppearance.Name = "cmbxAppearance";
      ComboBox cmbxAppearance2 = cmbxAppearance;
      size1 = new Size(184, 21);
      Size size5 = size1;
      cmbxAppearance2.Size = size5;
      cmbxAppearance.TabIndex = 3;
      Button btnSetNameLang1 = btnSetNameLang;
      point1 = new Point(344, 32);
      Point point7 = point1;
      btnSetNameLang1.Location = point7;
      btnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = btnSetNameLang;
      size1 = new Size(88, 23);
      Size size6 = size1;
      btnSetNameLang2.Size = size6;
      btnSetNameLang.TabIndex = 1;
      btnSetNameLang.Text = "Set Language";
      Label label5_1 = Label5;
      point1 = new Point(48, 200);
      Point point8 = point1;
      label5_1.Location = point8;
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
      Point point9 = point1;
      nudWill1.Location = point9;
      nudWill.Name = "nudWill";
      nudWill.RightToLeft = RightToLeft.No;
      NumericUpDown nudWill2 = nudWill;
      size1 = new Size(48, 20);
      Size size8 = size1;
      nudWill2.Size = size8;
      nudWill.TabIndex = 11;
      nudWill.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudFort1 = nudFort;
      point1 = new Point(192, 200);
      Point point10 = point1;
      nudFort1.Location = point10;
      nudFort.Name = "nudFort";
      nudFort.RightToLeft = RightToLeft.No;
      NumericUpDown nudFort2 = nudFort;
      size1 = new Size(48, 20);
      Size size9 = size1;
      nudFort2.Size = size9;
      nudFort.TabIndex = 9;
      nudFort.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudHp1 = nudHP;
      point1 = new Point(192, 176);
      Point point11 = point1;
      nudHp1.Location = point11;
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
      nudHP.TabIndex = 8;
      nudHP.TextAlign = HorizontalAlignment.Right;
      Label textureVariation1 = lblTextureVariation;
      point1 = new Point(48, 248);
      Point point12 = point1;
      textureVariation1.Location = point12;
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
      Point point13 = point1;
      label8_1.Location = point13;
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
      Point point14 = point1;
      nudHardness1.Location = point14;
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
      nudHardness.TabIndex = 7;
      nudHardness.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudRef1 = nudRef;
      point1 = new Point(192, 224);
      Point point15 = point1;
      nudRef1.Location = point15;
      nudRef.Name = "nudRef";
      nudRef.RightToLeft = RightToLeft.No;
      NumericUpDown nudRef2 = nudRef;
      size1 = new Size(48, 20);
      Size size14 = size1;
      nudRef2.Size = size14;
      nudRef.TabIndex = 10;
      nudRef.TextAlign = HorizontalAlignment.Right;
      Label label12_1 = Label12;
      point1 = new Point(48, 152);
      Point point16 = point1;
      label12_1.Location = point16;
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
      Point point17 = point1;
      lblBodyVariation1.Location = point17;
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
      Point point18 = point1;
      chkbPlotItem1.Location = point18;
      chkbPlotItem.Name = "chkbPlotItem";
      CheckBox chkbPlotItem2 = chkbPlotItem;
      size1 = new Size(72, 24);
      Size size17 = size1;
      chkbPlotItem2.Size = size17;
      chkbPlotItem.TabIndex = 4;
      chkbPlotItem.Text = "Plot item";
      TextBox tbTag1 = tbTag;
      point1 = new Point(128, 56);
      Point point19 = point1;
      tbTag1.Location = point19;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(200, 20);
      Size size18 = size1;
      tbTag2.Size = size18;
      tbTag.TabIndex = 2;
      tbTag.Text = "";
      TextBox tbName1 = tbName;
      point1 = new Point(128, 32);
      Point point20 = point1;
      tbName1.Location = point20;
      tbName.Name = "tbName";
      TextBox tbName2 = tbName;
      size1 = new Size(200, 20);
      Size size19 = size1;
      tbName2.Size = size19;
      tbName.TabIndex = 0;
      tbName.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(48, 32);
      Point point21 = point1;
      label1_1.Location = point21;
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
      Point point22 = point1;
      label2_1.Location = point22;
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
      Point point23 = point1;
      chkbStatic1.Location = point23;
      chkbStatic.Name = "chkbStatic";
      CheckBox chkbStatic2 = chkbStatic;
      size1 = new Size(72, 24);
      Size size22 = size1;
      chkbStatic2.Size = size22;
      chkbStatic.TabIndex = 5;
      chkbStatic.Text = "Static";
      CheckBox chkbMin1Hp1 = chkbMin1HP;
      point1 = new Point(296, 112);
      Point point24 = point1;
      chkbMin1Hp1.Location = point24;
      chkbMin1HP.Name = "chkbMin1HP";
      CheckBox chkbMin1Hp2 = chkbMin1HP;
      size1 = new Size(72, 24);
      Size size23 = size1;
      chkbMin1Hp2.Size = size23;
      chkbMin1HP.TabIndex = 6;
      chkbMin1HP.Text = "Min1HP";
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
      TabPage tabPageLock1 = TabPageLock;
      point1 = new Point(4, 40);
      Point point25 = point1;
      ((Control) tabPageLock1).Location = point25;
      TabPageLock.Name = "TabPageLock";
      TabPage tabPageLock2 = TabPageLock;
      size1 = new Size(448, 393);
      Size size24 = size1;
      tabPageLock2.Size = size24;
      TabPageLock.TabIndex = 1;
      TabPageLock.Text = "Lock";
      TabPageLock.Visible = false;
      tbKeyName.Enabled = false;
      TextBox tbKeyName1 = tbKeyName;
      point1 = new Point(176, 256);
      Point point26 = point1;
      tbKeyName1.Location = point26;
      tbKeyName.Name = "tbKeyName";
      TextBox tbKeyName2 = tbKeyName;
      size1 = new Size(200, 20);
      Size size25 = size1;
      tbKeyName2.Size = size25;
      tbKeyName.TabIndex = 6;
      tbKeyName.Text = "";
      lblKeyTag.Enabled = false;
      Label lblKeyTag1 = lblKeyTag;
      point1 = new Point(52, 256);
      Point point27 = point1;
      lblKeyTag1.Location = point27;
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
      point1 = new Point(176, 216);
      Point point28 = point1;
      nudCloseLockDc1.Location = point28;
      nudCloseLockDC.Name = "nudCloseLockDC";
      nudCloseLockDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudCloseLockDc2 = nudCloseLockDC;
      size1 = new Size(48, 20);
      Size size27 = size1;
      nudCloseLockDc2.Size = size27;
      nudCloseLockDC.TabIndex = 5;
      nudCloseLockDC.TextAlign = HorizontalAlignment.Right;
      lblCloseLockDC.Enabled = false;
      Label lblCloseLockDc1 = lblCloseLockDC;
      point1 = new Point(48, 216);
      Point point29 = point1;
      lblCloseLockDc1.Location = point29;
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
      point1 = new Point(176, 176);
      Point point30 = point1;
      nudOpenLockDc1.Location = point30;
      nudOpenLockDC.Name = "nudOpenLockDC";
      nudOpenLockDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudOpenLockDc2 = nudOpenLockDC;
      size1 = new Size(48, 20);
      Size size29 = size1;
      nudOpenLockDc2.Size = size29;
      nudOpenLockDC.TabIndex = 4;
      nudOpenLockDC.TextAlign = HorizontalAlignment.Right;
      lblOpenLockDC.Enabled = false;
      Label lblOpenLockDc1 = lblOpenLockDC;
      point1 = new Point(48, 176);
      Point point31 = point1;
      lblOpenLockDc1.Location = point31;
      lblOpenLockDC.Name = "lblOpenLockDC";
      Label lblOpenLockDc2 = lblOpenLockDC;
      size1 = new Size(88, 16);
      Size size30 = size1;
      lblOpenLockDc2.Size = size30;
      lblOpenLockDC.TabIndex = 15;
      lblOpenLockDC.Text = "Open Lock DC";
      lblOpenLockDC.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbLockable1 = chkbLockable;
      point1 = new Point(48, 66);
      Point point32 = point1;
      chkbLockable1.Location = point32;
      chkbLockable.Name = "chkbLockable";
      CheckBox chkbLockable2 = chkbLockable;
      size1 = new Size(112, 24);
      Size size31 = size1;
      chkbLockable2.Size = size31;
      chkbLockable.TabIndex = 1;
      chkbLockable.Text = "Can be relocked";
      CheckBox chkbLocked1 = chkbLocked;
      point1 = new Point(48, 32);
      Point point33 = point1;
      chkbLocked1.Location = point33;
      chkbLocked.Name = "chkbLocked";
      CheckBox chkbLocked2 = chkbLocked;
      size1 = new Size(72, 24);
      Size size32 = size1;
      chkbLocked2.Size = size32;
      chkbLocked.TabIndex = 0;
      chkbLocked.Text = "Locked";
      chkbKeyRequired.Enabled = false;
      CheckBox chkbKeyRequired1 = chkbKeyRequired;
      point1 = new Point(48, 134);
      Point point34 = point1;
      chkbKeyRequired1.Location = point34;
      chkbKeyRequired.Name = "chkbKeyRequired";
      CheckBox chkbKeyRequired2 = chkbKeyRequired;
      size1 = new Size(184, 24);
      Size size33 = size1;
      chkbKeyRequired2.Size = size33;
      chkbKeyRequired.TabIndex = 3;
      chkbKeyRequired.Text = "Key required to unlock or lock";
      chkbAutoRemoveKey.Enabled = false;
      CheckBox chkbAutoRemoveKey1 = chkbAutoRemoveKey;
      point1 = new Point(48, 100);
      Point point35 = point1;
      chkbAutoRemoveKey1.Location = point35;
      chkbAutoRemoveKey.Name = "chkbAutoRemoveKey";
      CheckBox chkbAutoRemoveKey2 = chkbAutoRemoveKey;
      size1 = new Size(200, 24);
      Size size34 = size1;
      chkbAutoRemoveKey2.Size = size34;
      chkbAutoRemoveKey.TabIndex = 2;
      chkbAutoRemoveKey.Text = "Automatically remove key after use";
      TabPageAdvanced.Controls.Add(chkbPartyInteract);
      TabPageAdvanced.Controls.Add(chkbHasInventory);
      TabPageAdvanced.Controls.Add(Label20);
      TabPageAdvanced.Controls.Add(tbType);
      TabPageAdvanced.Controls.Add(chkbInterruptable);
      TabPageAdvanced.Controls.Add(tbConversation);
      TabPageAdvanced.Controls.Add(tbFaction);
      TabPageAdvanced.Controls.Add(tbTemplateResRef);
      TabPageAdvanced.Controls.Add(Label10);
      TabPageAdvanced.Controls.Add(Label11);
      TabPageAdvanced.Controls.Add(Label13);
      TabPageAdvanced.Controls.Add(Label14);
      TabPageAdvanced.Controls.Add(tbAnimationState);
      TabPageAdvanced.Controls.Add(chkbUsable);
      TabPage tabPageAdvanced1 = TabPageAdvanced;
      point1 = new Point(4, 40);
      Point point36 = point1;
      ((Control) tabPageAdvanced1).Location = point36;
      TabPageAdvanced.Name = "TabPageAdvanced";
      TabPage tabPageAdvanced2 = TabPageAdvanced;
      size1 = new Size(448, 393);
      Size size35 = size1;
      tabPageAdvanced2.Size = size35;
      TabPageAdvanced.TabIndex = 5;
      TabPageAdvanced.Text = "Advanced";
      TabPageAdvanced.Visible = false;
      CheckBox chkbPartyInteract1 = chkbPartyInteract;
      point1 = new Point(168, 240);
      Point point37 = point1;
      chkbPartyInteract1.Location = point37;
      chkbPartyInteract.Name = "chkbPartyInteract";
      CheckBox chkbPartyInteract2 = chkbPartyInteract;
      size1 = new Size(184, 24);
      Size size36 = size1;
      chkbPartyInteract2.Size = size36;
      chkbPartyInteract.TabIndex = 6;
      chkbPartyInteract.Text = "Party Interact";
      CheckBox chkbHasInventory1 = chkbHasInventory;
      point1 = new Point(168, 208);
      Point point38 = point1;
      chkbHasInventory1.Location = point38;
      chkbHasInventory.Name = "chkbHasInventory";
      CheckBox chkbHasInventory2 = chkbHasInventory;
      size1 = new Size(184, 24);
      Size size37 = size1;
      chkbHasInventory2.Size = size37;
      chkbHasInventory.TabIndex = 5;
      chkbHasInventory.Text = "Has Inventory";
      Label label20_1 = Label20;
      point1 = new Point(56, 176);
      Point point39 = point1;
      label20_1.Location = point39;
      Label20.Name = "Label20";
      Label label20_2 = Label20;
      size1 = new Size(48, 16);
      Size size38 = size1;
      label20_2.Size = size38;
      Label20.TabIndex = 5;
      Label20.Text = "Type";
      Label20.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbType1 = tbType;
      point1 = new Point(168, 176);
      Point point40 = point1;
      tbType1.Location = point40;
      tbType.Name = "tbType";
      TextBox tbType2 = tbType;
      size1 = new Size(72, 20);
      Size size39 = size1;
      tbType2.Size = size39;
      tbType.TabIndex = 4;
      tbType.Text = "";
      CheckBox chkbInterruptable1 = chkbInterruptable;
      point1 = new Point(352, 112);
      Point point41 = point1;
      chkbInterruptable1.Location = point41;
      chkbInterruptable.Name = "chkbInterruptable";
      CheckBox chkbInterruptable2 = chkbInterruptable;
      size1 = new Size(88, 24);
      Size size40 = size1;
      chkbInterruptable2.Size = size40;
      chkbInterruptable.TabIndex = 2;
      chkbInterruptable.Text = "Interruptable";
      TextBox tbConversation1 = tbConversation;
      point1 = new Point(168, 112);
      Point point42 = point1;
      tbConversation1.Location = point42;
      tbConversation.Name = "tbConversation";
      TextBox tbConversation2 = tbConversation;
      size1 = new Size(168, 20);
      Size size41 = size1;
      tbConversation2.Size = size41;
      tbConversation.TabIndex = 1;
      tbConversation.Text = "";
      TextBox tbFaction1 = tbFaction;
      point1 = new Point(168, 80);
      Point point43 = point1;
      tbFaction1.Location = point43;
      tbFaction.Name = "tbFaction";
      TextBox tbFaction2 = tbFaction;
      size1 = new Size(30, 20);
      Size size42 = size1;
      tbFaction2.Size = size42;
      tbFaction.TabIndex = 0;
      tbFaction.Text = "";
      tbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbTemplateResRef1 = tbTemplateResRef;
      point1 = new Point(168, 32);
      Point point44 = point1;
      tbTemplateResRef1.Location = point44;
      tbTemplateResRef.MaxLength = 16;
      tbTemplateResRef.Name = "tbTemplateResRef";
      TextBox tbTemplateResRef2 = tbTemplateResRef;
      size1 = new Size(200, 20);
      Size size43 = size1;
      tbTemplateResRef2.Size = size43;
      tbTemplateResRef.TabIndex = 3;
      tbTemplateResRef.Text = "";
      Label label10_1 = Label10;
      point1 = new Point(52, 32);
      Point point45 = point1;
      label10_1.Location = point45;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(100, 16);
      Size size44 = size1;
      label10_2.Size = size44;
      Label10.TabIndex = 2;
      Label10.Text = "Template ResRef";
      Label10.TextAlign = ContentAlignment.MiddleLeft;
      Label label11_1 = Label11;
      point1 = new Point(56, 80);
      Point point46 = point1;
      label11_1.Location = point46;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(100, 16);
      Size size45 = size1;
      label11_2.Size = size45;
      Label11.TabIndex = 2;
      Label11.Text = "Faction";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      Label label13_1 = Label13;
      point1 = new Point(56, 112);
      Point point47 = point1;
      label13_1.Location = point47;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(100, 16);
      Size size46 = size1;
      label13_2.Size = size46;
      Label13.TabIndex = 2;
      Label13.Text = "Conversation";
      Label13.TextAlign = ContentAlignment.MiddleLeft;
      Label label14_1 = Label14;
      point1 = new Point(56, 144);
      Point point48 = point1;
      label14_1.Location = point48;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(100, 16);
      Size size47 = size1;
      label14_2.Size = size47;
      Label14.TabIndex = 2;
      Label14.Text = "Animation State";
      Label14.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbAnimationState1 = tbAnimationState;
      point1 = new Point(168, 144);
      Point point49 = point1;
      tbAnimationState1.Location = point49;
      tbAnimationState.Name = "tbAnimationState";
      TextBox tbAnimationState2 = tbAnimationState;
      size1 = new Size(32, 20);
      Size size48 = size1;
      tbAnimationState2.Size = size48;
      tbAnimationState.TabIndex = 3;
      tbAnimationState.Text = "";
      CheckBox chkbUsable1 = chkbUsable;
      point1 = new Point(168, 272);
      Point point50 = point1;
      chkbUsable1.Location = point50;
      chkbUsable.Name = "chkbUsable";
      CheckBox chkbUsable2 = chkbUsable;
      size1 = new Size(184, 24);
      Size size49 = size1;
      chkbUsable2.Size = size49;
      chkbUsable.TabIndex = 6;
      chkbUsable.Text = "Usable";
      TabPageScripts.Controls.Add(btnEditOnUserDefined);
      TabPageScripts.Controls.Add(btnEditOnUnlock);
      TabPageScripts.Controls.Add(btnEditOnSpellCastAt);
      TabPageScripts.Controls.Add(btnEditOnTrapTriggered);
      TabPageScripts.Controls.Add(btnEditOnMeleeAttacked);
      TabPageScripts.Controls.Add(btnEditOnOpen);
      TabPageScripts.Controls.Add(btnEditOnLock);
      TabPageScripts.Controls.Add(btnEditOnHeartbeat);
      TabPageScripts.Controls.Add(btnEditOnDeath);
      TabPageScripts.Controls.Add(btnEditOnDisarm);
      TabPageScripts.Controls.Add(btnEditOnDamaged);
      TabPageScripts.Controls.Add(btnEditOnClosed);
      TabPageScripts.Controls.Add(tbOnUsed);
      TabPageScripts.Controls.Add(Label18);
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
      TabPageScripts.Controls.Add(Label21);
      TabPageScripts.Controls.Add(tbOnEndDialogue);
      TabPageScripts.Controls.Add(tbOnInvDisturbed);
      TabPageScripts.Controls.Add(Label22);
      TabPageScripts.Controls.Add(btnEditOnUsed);
      TabPageScripts.Controls.Add(btnEditOnInvDisturbed);
      TabPageScripts.Controls.Add(btnEditOnEndDialogue);
      TabPage tabPageScripts1 = TabPageScripts;
      point1 = new Point(4, 40);
      Point point51 = point1;
      ((Control) tabPageScripts1).Location = point51;
      TabPageScripts.Name = "TabPageScripts";
      TabPage tabPageScripts2 = TabPageScripts;
      size1 = new Size(448, 417);
      Size size50 = size1;
      tabPageScripts2.Size = size50;
      TabPageScripts.TabIndex = 4;
      TabPageScripts.Text = "Scripts";
      TabPageScripts.Visible = false;
      TextBox tbOnUsed1 = tbOnUsed;
      point1 = new Point(160, 354);
      Point point52 = point1;
      tbOnUsed1.Location = point52;
      tbOnUsed.Name = "tbOnUsed";
      TextBox tbOnUsed2 = tbOnUsed;
      size1 = new Size(204, 20);
      Size size51 = size1;
      tbOnUsed2.Size = size51;
      tbOnUsed.TabIndex = 26;
      tbOnUsed.Text = "";
      Label label18_1 = Label18;
      point1 = new Point(40, 354);
      Point point53 = point1;
      label18_1.Location = point53;
      Label18.Name = "Label18";
      Label label18_2 = Label18;
      size1 = new Size(112, 18);
      Size size52 = size1;
      label18_2.Size = size52;
      Label18.TabIndex = 30;
      Label18.Text = "OnUsed";
      Label18.TextAlign = ContentAlignment.MiddleLeft;
      Label label34_1 = Label34;
      point1 = new Point(40, 68);
      Point point54 = point1;
      label34_1.Location = point54;
      Label34.Name = "Label34";
      Label label34_2 = Label34;
      size1 = new Size(112, 18);
      Size size53 = size1;
      label34_2.Size = size53;
      Label34.TabIndex = 27;
      Label34.Text = "OnDeath";
      Label34.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDeath1 = tbOnDeath;
      point1 = new Point(160, 68);
      Point point55 = point1;
      tbOnDeath1.Location = point55;
      tbOnDeath.Name = "tbOnDeath";
      TextBox tbOnDeath2 = tbOnDeath;
      size1 = new Size(204, 20);
      Size size54 = size1;
      tbOnDeath2.Size = size54;
      tbOnDeath.TabIndex = 4;
      tbOnDeath.Text = "";
      Label label33_1 = Label33;
      point1 = new Point(40, 42);
      Point point56 = point1;
      label33_1.Location = point56;
      Label33.Name = "Label33";
      Label label33_2 = Label33;
      size1 = new Size(112, 18);
      Size size55 = size1;
      label33_2.Size = size55;
      Label33.TabIndex = 17;
      Label33.Text = "OnDamaged";
      Label33.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDamaged1 = tbOnDamaged;
      point1 = new Point(160, 42);
      Point point57 = point1;
      tbOnDamaged1.Location = point57;
      tbOnDamaged.Name = "tbOnDamaged";
      TextBox tbOnDamaged2 = tbOnDamaged;
      size1 = new Size(204, 20);
      Size size56 = size1;
      tbOnDamaged2.Size = size56;
      tbOnDamaged.TabIndex = 2;
      tbOnDamaged.Text = "";
      Label label32_1 = Label32;
      point1 = new Point(40, 16);
      Point point58 = point1;
      label32_1.Location = point58;
      Label32.Name = "Label32";
      Label label32_2 = Label32;
      size1 = new Size(112, 18);
      Size size57 = size1;
      label32_2.Size = size57;
      Label32.TabIndex = 14;
      Label32.Text = "OnClosed";
      Label32.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnClosed1 = tbOnClosed;
      point1 = new Point(160, 16);
      Point point59 = point1;
      tbOnClosed1.Location = point59;
      tbOnClosed.Name = "tbOnClosed";
      TextBox tbOnClosed2 = tbOnClosed;
      size1 = new Size(204, 20);
      Size size58 = size1;
      tbOnClosed2.Size = size58;
      tbOnClosed.TabIndex = 0;
      tbOnClosed.Text = "";
      Label label35_1 = Label35;
      point1 = new Point(40, 94);
      Point point60 = point1;
      label35_1.Location = point60;
      Label35.Name = "Label35";
      Label label35_2 = Label35;
      size1 = new Size(112, 18);
      Size size59 = size1;
      label35_2.Size = size59;
      Label35.TabIndex = 26;
      Label35.Text = "OnDisarm";
      Label35.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDisarm1 = tbOnDisarm;
      point1 = new Point(160, 94);
      Point point61 = point1;
      tbOnDisarm1.Location = point61;
      tbOnDisarm.Name = "tbOnDisarm";
      TextBox tbOnDisarm2 = tbOnDisarm;
      size1 = new Size(204, 20);
      Size size60 = size1;
      tbOnDisarm2.Size = size60;
      tbOnDisarm.TabIndex = 6;
      tbOnDisarm.Text = "";
      TextBox tbOnHeartbeat1 = tbOnHeartbeat;
      point1 = new Point(160, 146);
      Point point62 = point1;
      tbOnHeartbeat1.Location = point62;
      tbOnHeartbeat.Name = "tbOnHeartbeat";
      TextBox tbOnHeartbeat2 = tbOnHeartbeat;
      size1 = new Size(204, 20);
      Size size61 = size1;
      tbOnHeartbeat2.Size = size61;
      tbOnHeartbeat.TabIndex = 10;
      tbOnHeartbeat.Text = "";
      Label label36_1 = Label36;
      point1 = new Point(40, 146);
      Point point63 = point1;
      label36_1.Location = point63;
      Label36.Name = "Label36";
      Label label36_2 = Label36;
      size1 = new Size(112, 18);
      Size size62 = size1;
      label36_2.Size = size62;
      Label36.TabIndex = 25;
      Label36.Text = "OnHeartbeat";
      Label36.TextAlign = ContentAlignment.MiddleLeft;
      Label label37_1 = Label37;
      point1 = new Point(40, 198);
      Point point64 = point1;
      label37_1.Location = point64;
      Label37.Name = "Label37";
      Label label37_2 = Label37;
      size1 = new Size(112, 18);
      Size size63 = size1;
      label37_2.Size = size63;
      Label37.TabIndex = 28;
      Label37.Text = "OnLock";
      Label37.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnLock1 = tbOnLock;
      point1 = new Point(160, 198);
      Point point65 = point1;
      tbOnLock1.Location = point65;
      tbOnLock.Name = "tbOnLock";
      TextBox tbOnLock2 = tbOnLock;
      size1 = new Size(204, 20);
      Size size64 = size1;
      tbOnLock2.Size = size64;
      tbOnLock.TabIndex = 14;
      tbOnLock.Text = "";
      TextBox tbOnMeleeAttacked1 = tbOnMeleeAttacked;
      point1 = new Point(160, 224);
      Point point66 = point1;
      tbOnMeleeAttacked1.Location = point66;
      tbOnMeleeAttacked.Name = "tbOnMeleeAttacked";
      TextBox tbOnMeleeAttacked2 = tbOnMeleeAttacked;
      size1 = new Size(204, 20);
      Size size65 = size1;
      tbOnMeleeAttacked2.Size = size65;
      tbOnMeleeAttacked.TabIndex = 16;
      tbOnMeleeAttacked.Text = "";
      Label label38_1 = Label38;
      point1 = new Point(40, 224);
      Point point67 = point1;
      label38_1.Location = point67;
      Label38.Name = "Label38";
      Label label38_2 = Label38;
      size1 = new Size(112, 18);
      Size size66 = size1;
      label38_2.Size = size66;
      Label38.TabIndex = 20;
      Label38.Text = "OnMeleeAttacked";
      Label38.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnOpen1 = tbOnOpen;
      point1 = new Point(160, 250);
      Point point68 = point1;
      tbOnOpen1.Location = point68;
      tbOnOpen.Name = "tbOnOpen";
      TextBox tbOnOpen2 = tbOnOpen;
      size1 = new Size(204, 20);
      Size size67 = size1;
      tbOnOpen2.Size = size67;
      tbOnOpen.TabIndex = 18;
      tbOnOpen.Text = "";
      Label label39_1 = Label39;
      point1 = new Point(40, 250);
      Point point69 = point1;
      label39_1.Location = point69;
      Label39.Name = "Label39";
      Label label39_2 = Label39;
      size1 = new Size(112, 18);
      Size size68 = size1;
      label39_2.Size = size68;
      Label39.TabIndex = 21;
      Label39.Text = "OnOpen";
      Label39.TextAlign = ContentAlignment.MiddleLeft;
      Label label40_1 = Label40;
      point1 = new Point(40, 276);
      Point point70 = point1;
      label40_1.Location = point70;
      Label40.Name = "Label40";
      Label label40_2 = Label40;
      size1 = new Size(112, 18);
      Size size69 = size1;
      label40_2.Size = size69;
      Label40.TabIndex = 19;
      Label40.Text = "OnSpellCastAt";
      Label40.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnSpellCastAt1 = tbOnSpellCastAt;
      point1 = new Point(160, 276);
      Point point71 = point1;
      tbOnSpellCastAt1.Location = point71;
      tbOnSpellCastAt.Name = "tbOnSpellCastAt";
      TextBox tbOnSpellCastAt2 = tbOnSpellCastAt;
      size1 = new Size(204, 20);
      Size size70 = size1;
      tbOnSpellCastAt2.Size = size70;
      tbOnSpellCastAt.TabIndex = 20;
      tbOnSpellCastAt.Text = "";
      Label label41_1 = Label41;
      point1 = new Point(40, 302);
      Point point72 = point1;
      label41_1.Location = point72;
      Label41.Name = "Label41";
      Label label41_2 = Label41;
      size1 = new Size(112, 18);
      Size size71 = size1;
      label41_2.Size = size71;
      Label41.TabIndex = 24;
      Label41.Text = "OnTrapTriggered";
      Label41.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnTrapTriggered1 = tbOnTrapTriggered;
      point1 = new Point(160, 302);
      Point point73 = point1;
      tbOnTrapTriggered1.Location = point73;
      tbOnTrapTriggered.Name = "tbOnTrapTriggered";
      TextBox tbOnTrapTriggered2 = tbOnTrapTriggered;
      size1 = new Size(204, 20);
      Size size72 = size1;
      tbOnTrapTriggered2.Size = size72;
      tbOnTrapTriggered.TabIndex = 22;
      tbOnTrapTriggered.Text = "";
      TextBox tbOnUnlock1 = tbOnUnlock;
      point1 = new Point(160, 328);
      Point point74 = point1;
      tbOnUnlock1.Location = point74;
      tbOnUnlock.Name = "tbOnUnlock";
      TextBox tbOnUnlock2 = tbOnUnlock;
      size1 = new Size(204, 20);
      Size size73 = size1;
      tbOnUnlock2.Size = size73;
      tbOnUnlock.TabIndex = 24;
      tbOnUnlock.Text = "";
      Label label42_1 = Label42;
      point1 = new Point(40, 328);
      Point point75 = point1;
      label42_1.Location = point75;
      Label42.Name = "Label42";
      Label label42_2 = Label42;
      size1 = new Size(112, 18);
      Size size74 = size1;
      label42_2.Size = size74;
      Label42.TabIndex = 23;
      Label42.Text = "OnUnlock";
      Label42.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnUserDefined1 = tbOnUserDefined;
      point1 = new Point(160, 380);
      Point point76 = point1;
      tbOnUserDefined1.Location = point76;
      tbOnUserDefined.Name = "tbOnUserDefined";
      TextBox tbOnUserDefined2 = tbOnUserDefined;
      size1 = new Size(204, 20);
      Size size75 = size1;
      tbOnUserDefined2.Size = size75;
      tbOnUserDefined.TabIndex = 28;
      tbOnUserDefined.Text = "";
      Label label43_1 = Label43;
      point1 = new Point(40, 380);
      Point point77 = point1;
      label43_1.Location = point77;
      Label43.Name = "Label43";
      Label label43_2 = Label43;
      size1 = new Size(112, 18);
      Size size76 = size1;
      label43_2.Size = size76;
      Label43.TabIndex = 22;
      Label43.Text = "OnUserDefined";
      Label43.TextAlign = ContentAlignment.MiddleLeft;
      Label label21_1 = Label21;
      point1 = new Point(40, 120);
      Point point78 = point1;
      label21_1.Location = point78;
      Label21.Name = "Label21";
      Label label21_2 = Label21;
      size1 = new Size(112, 18);
      Size size77 = size1;
      label21_2.Size = size77;
      Label21.TabIndex = 30;
      Label21.Text = "OnEndDialogue";
      Label21.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnEndDialogue1 = tbOnEndDialogue;
      point1 = new Point(160, 120);
      Point point79 = point1;
      tbOnEndDialogue1.Location = point79;
      tbOnEndDialogue.Name = "tbOnEndDialogue";
      TextBox tbOnEndDialogue2 = tbOnEndDialogue;
      size1 = new Size(204, 20);
      Size size78 = size1;
      tbOnEndDialogue2.Size = size78;
      tbOnEndDialogue.TabIndex = 8;
      tbOnEndDialogue.Text = "";
      TextBox tbOnInvDisturbed1 = tbOnInvDisturbed;
      point1 = new Point(160, 172);
      Point point80 = point1;
      tbOnInvDisturbed1.Location = point80;
      tbOnInvDisturbed.Name = "tbOnInvDisturbed";
      TextBox tbOnInvDisturbed2 = tbOnInvDisturbed;
      size1 = new Size(204, 20);
      Size size79 = size1;
      tbOnInvDisturbed2.Size = size79;
      tbOnInvDisturbed.TabIndex = 12;
      tbOnInvDisturbed.Text = "";
      Label label22_1 = Label22;
      point1 = new Point(40, 172);
      Point point81 = point1;
      label22_1.Location = point81;
      Label22.Name = "Label22";
      Label label22_2 = Label22;
      size1 = new Size(112, 18);
      Size size80 = size1;
      label22_2.Size = size80;
      Label22.TabIndex = 30;
      Label22.Text = "OnInvDisturbed";
      Label22.TextAlign = ContentAlignment.MiddleLeft;
      TabPageDescription.Controls.Add(btnSetDescriptionLang);
      TabPageDescription.Controls.Add(tbDescription);
      TabPage tabPageDescription1 = TabPageDescription;
      point1 = new Point(4, 40);
      Point point82 = point1;
      ((Control) tabPageDescription1).Location = point82;
      TabPageDescription.Name = "TabPageDescription";
      TabPage tabPageDescription2 = TabPageDescription;
      size1 = new Size(448, 393);
      Size size81 = size1;
      tabPageDescription2.Size = size81;
      TabPageDescription.TabIndex = 6;
      TabPageDescription.Text = "Description";
      TabPageDescription.Visible = false;
      Button setDescriptionLang1 = btnSetDescriptionLang;
      point1 = new Point(40, 320);
      Point point83 = point1;
      setDescriptionLang1.Location = point83;
      btnSetDescriptionLang.Name = "btnSetDescriptionLang";
      Button setDescriptionLang2 = btnSetDescriptionLang;
      size1 = new Size(88, 23);
      Size size82 = size1;
      setDescriptionLang2.Size = size82;
      btnSetDescriptionLang.TabIndex = 1;
      btnSetDescriptionLang.Text = "Set Language";
      TextBox tbDescription1 = tbDescription;
      point1 = new Point(12, 7);
      Point point84 = point1;
      tbDescription1.Location = point84;
      tbDescription.Multiline = true;
      tbDescription.Name = "tbDescription";
      TextBox tbDescription2 = tbDescription;
      size1 = new Size(424, 305);
      Size size83 = size1;
      tbDescription2.Size = size83;
      tbDescription.TabIndex = 0;
      tbDescription.Text = "";
      TabPageComments.Controls.Add(tbComment);
      TabPage tabPageComments1 = TabPageComments;
      point1 = new Point(4, 40);
      Point point85 = point1;
      ((Control) tabPageComments1).Location = point85;
      TabPageComments.Name = "TabPageComments";
      TabPage tabPageComments2 = TabPageComments;
      size1 = new Size(448, 393);
      Size size84 = size1;
      tabPageComments2.Size = size84;
      TabPageComments.TabIndex = 7;
      TabPageComments.Text = "Comments";
      TabPageComments.Visible = false;
      TextBox tbComment1 = tbComment;
      point1 = new Point(12, 7);
      Point point86 = point1;
      tbComment1.Location = point86;
      tbComment.Multiline = true;
      tbComment.Name = "tbComment";
      TextBox tbComment2 = tbComment;
      size1 = new Size(424, 336);
      Size size85 = size1;
      tbComment2.Size = size85;
      tbComment.TabIndex = 0;
      tbComment.Text = "";
      TabPageTrap.Controls.Add(chkbTrapDisarmable);
      TabPageTrap.Controls.Add(chkbTrapDetectable);
      TabPageTrap.Controls.Add(Label6);
      TabPageTrap.Controls.Add(Label3);
      TabPageTrap.Controls.Add(nudDisarmDC);
      TabPageTrap.Controls.Add(Label4);
      TabPageTrap.Controls.Add(Label15);
      TabPageTrap.Controls.Add(nudTrapDetectDC);
      TabPageTrap.Controls.Add(Label16);
      TabPageTrap.Controls.Add(lblTrapDetectable);
      TabPageTrap.Controls.Add(nudTrapType);
      TabPageTrap.Controls.Add(Label17);
      TabPageTrap.Controls.Add(chkbTrapFlag);
      TabPageTrap.Controls.Add(chkbTrapOneShot);
      TabPage tabPageTrap1 = TabPageTrap;
      point1 = new Point(4, 40);
      Point point87 = point1;
      ((Control) tabPageTrap1).Location = point87;
      TabPageTrap.Name = "TabPageTrap";
      TabPage tabPageTrap2 = TabPageTrap;
      size1 = new Size(448, 393);
      Size size86 = size1;
      tabPageTrap2.Size = size86;
      TabPageTrap.TabIndex = 10;
      TabPageTrap.Text = "Trap";
      CheckBox chkbTrapDisarmable1 = chkbTrapDisarmable;
      point1 = new Point(192, 85);
      Point point88 = point1;
      chkbTrapDisarmable1.Location = point88;
      chkbTrapDisarmable.Name = "chkbTrapDisarmable";
      CheckBox chkbTrapDisarmable2 = chkbTrapDisarmable;
      size1 = new Size(24, 24);
      Size size87 = size1;
      chkbTrapDisarmable2.Size = size87;
      chkbTrapDisarmable.TabIndex = 2;
      CheckBox chkbTrapDetectable1 = chkbTrapDetectable;
      point1 = new Point(192, 21);
      Point point89 = point1;
      chkbTrapDetectable1.Location = point89;
      chkbTrapDetectable.Name = "chkbTrapDetectable";
      CheckBox chkbTrapDetectable2 = chkbTrapDetectable;
      size1 = new Size(24, 24);
      Size size88 = size1;
      chkbTrapDetectable2.Size = size88;
      chkbTrapDetectable.TabIndex = 0;
      Label label6_1 = Label6;
      point1 = new Point(48, 184);
      Point point90 = point1;
      label6_1.Location = point90;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(88, 16);
      Size size89 = size1;
      label6_2.Size = size89;
      Label6.TabIndex = 26;
      Label6.Text = "TrapOneShot";
      Label6.TextAlign = ContentAlignment.MiddleLeft;
      Label label3_1 = Label3;
      point1 = new Point(48, 152);
      Point point91 = point1;
      label3_1.Location = point91;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(88, 16);
      Size size90 = size1;
      label3_2.Size = size90;
      Label3.TabIndex = 27;
      Label3.Text = "TrapFlag";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudDisarmDc1 = nudDisarmDC;
      point1 = new Point(176, 120);
      Point point92 = point1;
      nudDisarmDc1.Location = point92;
      NumericUpDown nudDisarmDc2 = nudDisarmDC;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num4 = num1;
      nudDisarmDc2.Maximum = num4;
      nudDisarmDC.Name = "nudDisarmDC";
      nudDisarmDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudDisarmDc3 = nudDisarmDC;
      size1 = new Size(48, 20);
      Size size91 = size1;
      nudDisarmDc3.Size = size91;
      nudDisarmDC.TabIndex = 3;
      nudDisarmDC.TextAlign = HorizontalAlignment.Right;
      Label label4_1 = Label4;
      point1 = new Point(48, 120);
      Point point93 = point1;
      label4_1.Location = point93;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(88, 16);
      Size size92 = size1;
      label4_2.Size = size92;
      Label4.TabIndex = 22;
      Label4.Text = "DisarmDC";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      Label label15_1 = Label15;
      point1 = new Point(48, 88);
      Point point94 = point1;
      label15_1.Location = point94;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(88, 16);
      Size size93 = size1;
      label15_2.Size = size93;
      Label15.TabIndex = 23;
      Label15.Text = "TrapDisarmable";
      Label15.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudTrapDetectDc1 = nudTrapDetectDC;
      point1 = new Point(176, 56);
      Point point95 = point1;
      nudTrapDetectDc1.Location = point95;
      NumericUpDown nudTrapDetectDc2 = nudTrapDetectDC;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num5 = num1;
      nudTrapDetectDc2.Maximum = num5;
      nudTrapDetectDC.Name = "nudTrapDetectDC";
      nudTrapDetectDC.RightToLeft = RightToLeft.No;
      NumericUpDown nudTrapDetectDc3 = nudTrapDetectDC;
      size1 = new Size(48, 20);
      Size size94 = size1;
      nudTrapDetectDc3.Size = size94;
      nudTrapDetectDC.TabIndex = 1;
      nudTrapDetectDC.TextAlign = HorizontalAlignment.Right;
      Label label16_1 = Label16;
      point1 = new Point(48, 56);
      Point point96 = point1;
      label16_1.Location = point96;
      Label16.Name = "Label16";
      Label label16_2 = Label16;
      size1 = new Size(88, 16);
      Size size95 = size1;
      label16_2.Size = size95;
      Label16.TabIndex = 18;
      Label16.Text = "TrapDetectDC";
      Label16.TextAlign = ContentAlignment.MiddleLeft;
      Label lblTrapDetectable1 = lblTrapDetectable;
      point1 = new Point(48, 24);
      Point point97 = point1;
      lblTrapDetectable1.Location = point97;
      lblTrapDetectable.Name = "lblTrapDetectable";
      Label lblTrapDetectable2 = lblTrapDetectable;
      size1 = new Size(88, 16);
      Size size96 = size1;
      lblTrapDetectable2.Size = size96;
      lblTrapDetectable.TabIndex = 19;
      lblTrapDetectable.Text = "TrapDetectable";
      lblTrapDetectable.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudTrapType1 = nudTrapType;
      point1 = new Point(176, 216);
      Point point98 = point1;
      nudTrapType1.Location = point98;
      NumericUpDown nudTrapType2 = nudTrapType;
      num1 = new Decimal(new int[4]{ 2, 0, 0, 0 });
      Decimal num6 = num1;
      nudTrapType2.Maximum = num6;
      nudTrapType.Name = "nudTrapType";
      nudTrapType.RightToLeft = RightToLeft.No;
      NumericUpDown nudTrapType3 = nudTrapType;
      size1 = new Size(48, 20);
      Size size97 = size1;
      nudTrapType3.Size = size97;
      nudTrapType.TabIndex = 6;
      nudTrapType.TextAlign = HorizontalAlignment.Right;
      Label label17_1 = Label17;
      point1 = new Point(48, 216);
      Point point99 = point1;
      label17_1.Location = point99;
      Label17.Name = "Label17";
      Label label17_2 = Label17;
      size1 = new Size(88, 16);
      Size size98 = size1;
      label17_2.Size = size98;
      Label17.TabIndex = 26;
      Label17.Text = "TrapType";
      Label17.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbTrapFlag1 = chkbTrapFlag;
      point1 = new Point(192, 152);
      Point point100 = point1;
      chkbTrapFlag1.Location = point100;
      chkbTrapFlag.Name = "chkbTrapFlag";
      CheckBox chkbTrapFlag2 = chkbTrapFlag;
      size1 = new Size(24, 24);
      Size size99 = size1;
      chkbTrapFlag2.Size = size99;
      chkbTrapFlag.TabIndex = 4;
      CheckBox chkbTrapOneShot1 = chkbTrapOneShot;
      point1 = new Point(192, 184);
      Point point101 = point1;
      chkbTrapOneShot1.Location = point101;
      chkbTrapOneShot.Name = "chkbTrapOneShot";
      CheckBox chkbTrapOneShot2 = chkbTrapOneShot;
      size1 = new Size(24, 24);
      Size size100 = size1;
      chkbTrapOneShot2.Size = size100;
      chkbTrapOneShot.TabIndex = 5;
      this.btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSave = this.btnSave;
      point1 = new Point(312, 480);
      Point point102 = point1;
      btnSave.Location = point102;
      this.btnSave.Name = "btnSave";
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "&Save";
      this.btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnCancel = this.btnCancel;
      point1 = new Point(408, 480);
      Point point103 = point1;
      btnCancel.Location = point103;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "&Cancel";
      btnInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnInventory1 = btnInventory;
      point1 = new Point(64, 480);
      Point point104 = point1;
      btnInventory1.Location = point104;
      btnInventory.Name = "btnInventory";
      Button btnInventory2 = btnInventory;
      size1 = new Size(72, 24);
      Size size101 = size1;
      btnInventory2.Size = size101;
      btnInventory.TabIndex = 9;
      btnInventory.Text = "&Inventory";
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point105 = point1;
      btnDebug1.Location = point105;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 9);
      Size size102 = size1;
      btnDebug2.Size = size102;
      btnDebug.TabIndex = 19;
      btnDebug.TabStop = false;
      Button btnEditOnClosed1 = btnEditOnClosed;
      point1 = new Point(384, 16);
      Point point106 = point1;
      btnEditOnClosed1.Location = point106;
      btnEditOnClosed.Name = "btnEditOnClosed";
      Button btnEditOnClosed2 = btnEditOnClosed;
      size1 = new Size(32, 23);
      Size size103 = size1;
      btnEditOnClosed2.Size = size103;
      btnEditOnClosed.TabIndex = 1;
      btnEditOnClosed.Text = "Edit";
      btnEditOnClosed.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDamaged1 = btnEditOnDamaged;
      point1 = new Point(384, 42);
      Point point107 = point1;
      btnEditOnDamaged1.Location = point107;
      btnEditOnDamaged.Name = "btnEditOnDamaged";
      Button btnEditOnDamaged2 = btnEditOnDamaged;
      size1 = new Size(32, 23);
      Size size104 = size1;
      btnEditOnDamaged2.Size = size104;
      btnEditOnDamaged.TabIndex = 3;
      btnEditOnDamaged.Text = "Edit";
      btnEditOnDamaged.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDeath1 = btnEditOnDeath;
      point1 = new Point(384, 68);
      Point point108 = point1;
      btnEditOnDeath1.Location = point108;
      btnEditOnDeath.Name = "btnEditOnDeath";
      Button btnEditOnDeath2 = btnEditOnDeath;
      size1 = new Size(32, 23);
      Size size105 = size1;
      btnEditOnDeath2.Size = size105;
      btnEditOnDeath.TabIndex = 5;
      btnEditOnDeath.Text = "Edit";
      btnEditOnDeath.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDisarm1 = btnEditOnDisarm;
      point1 = new Point(384, 94);
      Point point109 = point1;
      btnEditOnDisarm1.Location = point109;
      btnEditOnDisarm.Name = "btnEditOnDisarm";
      Button btnEditOnDisarm2 = btnEditOnDisarm;
      size1 = new Size(32, 23);
      Size size106 = size1;
      btnEditOnDisarm2.Size = size106;
      btnEditOnDisarm.TabIndex = 7;
      btnEditOnDisarm.Text = "Edit";
      btnEditOnDisarm.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnHeartbeat1 = btnEditOnHeartbeat;
      point1 = new Point(384, 146);
      Point point110 = point1;
      btnEditOnHeartbeat1.Location = point110;
      btnEditOnHeartbeat.Name = "btnEditOnHeartbeat";
      Button btnEditOnHeartbeat2 = btnEditOnHeartbeat;
      size1 = new Size(32, 23);
      Size size107 = size1;
      btnEditOnHeartbeat2.Size = size107;
      btnEditOnHeartbeat.TabIndex = 11;
      btnEditOnHeartbeat.Text = "Edit";
      btnEditOnHeartbeat.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnLock1 = btnEditOnLock;
      point1 = new Point(384, 198);
      Point point111 = point1;
      btnEditOnLock1.Location = point111;
      btnEditOnLock.Name = "btnEditOnLock";
      Button btnEditOnLock2 = btnEditOnLock;
      size1 = new Size(32, 23);
      Size size108 = size1;
      btnEditOnLock2.Size = size108;
      btnEditOnLock.TabIndex = 15;
      btnEditOnLock.Text = "Edit";
      btnEditOnLock.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnMeleeAttacked1 = btnEditOnMeleeAttacked;
      point1 = new Point(384, 224);
      Point point112 = point1;
      editOnMeleeAttacked1.Location = point112;
      btnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked";
      Button editOnMeleeAttacked2 = btnEditOnMeleeAttacked;
      size1 = new Size(32, 23);
      Size size109 = size1;
      editOnMeleeAttacked2.Size = size109;
      btnEditOnMeleeAttacked.TabIndex = 17;
      btnEditOnMeleeAttacked.Text = "Edit";
      btnEditOnMeleeAttacked.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnOpen1 = btnEditOnOpen;
      point1 = new Point(384, 250);
      Point point113 = point1;
      btnEditOnOpen1.Location = point113;
      btnEditOnOpen.Name = "btnEditOnOpen";
      Button btnEditOnOpen2 = btnEditOnOpen;
      size1 = new Size(32, 23);
      Size size110 = size1;
      btnEditOnOpen2.Size = size110;
      btnEditOnOpen.TabIndex = 19;
      btnEditOnOpen.Text = "Edit";
      btnEditOnOpen.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnSpellCastAt1 = btnEditOnSpellCastAt;
      point1 = new Point(384, 276);
      Point point114 = point1;
      editOnSpellCastAt1.Location = point114;
      btnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt";
      Button editOnSpellCastAt2 = btnEditOnSpellCastAt;
      size1 = new Size(32, 23);
      Size size111 = size1;
      editOnSpellCastAt2.Size = size111;
      btnEditOnSpellCastAt.TabIndex = 21;
      btnEditOnSpellCastAt.Text = "Edit";
      btnEditOnSpellCastAt.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnTrapTriggered1 = btnEditOnTrapTriggered;
      point1 = new Point(384, 302);
      Point point115 = point1;
      editOnTrapTriggered1.Location = point115;
      btnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered";
      Button editOnTrapTriggered2 = btnEditOnTrapTriggered;
      size1 = new Size(32, 23);
      Size size112 = size1;
      editOnTrapTriggered2.Size = size112;
      btnEditOnTrapTriggered.TabIndex = 23;
      btnEditOnTrapTriggered.Text = "Edit";
      btnEditOnTrapTriggered.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnUserDefined1 = btnEditOnUserDefined;
      point1 = new Point(384, 380);
      Point point116 = point1;
      editOnUserDefined1.Location = point116;
      btnEditOnUserDefined.Name = "btnEditOnUserDefined";
      Button editOnUserDefined2 = btnEditOnUserDefined;
      size1 = new Size(32, 23);
      Size size113 = size1;
      editOnUserDefined2.Size = size113;
      btnEditOnUserDefined.TabIndex = 29;
      btnEditOnUserDefined.Text = "Edit";
      btnEditOnUserDefined.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnUnlock1 = btnEditOnUnlock;
      point1 = new Point(384, 328);
      Point point117 = point1;
      btnEditOnUnlock1.Location = point117;
      btnEditOnUnlock.Name = "btnEditOnUnlock";
      Button btnEditOnUnlock2 = btnEditOnUnlock;
      size1 = new Size(32, 23);
      Size size114 = size1;
      btnEditOnUnlock2.Size = size114;
      btnEditOnUnlock.TabIndex = 25;
      btnEditOnUnlock.Text = "Edit";
      btnEditOnUnlock.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnUsed1 = btnEditOnUsed;
      point1 = new Point(384, 354);
      Point point118 = point1;
      btnEditOnUsed1.Location = point118;
      btnEditOnUsed.Name = "btnEditOnUsed";
      Button btnEditOnUsed2 = btnEditOnUsed;
      size1 = new Size(32, 23);
      Size size115 = size1;
      btnEditOnUsed2.Size = size115;
      btnEditOnUsed.TabIndex = 27;
      btnEditOnUsed.Text = "Edit";
      btnEditOnUsed.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnInvDisturbed1 = btnEditOnInvDisturbed;
      point1 = new Point(384, 172);
      Point point119 = point1;
      editOnInvDisturbed1.Location = point119;
      btnEditOnInvDisturbed.Name = "btnEditOnInvDisturbed";
      Button editOnInvDisturbed2 = btnEditOnInvDisturbed;
      size1 = new Size(32, 23);
      Size size116 = size1;
      editOnInvDisturbed2.Size = size116;
      btnEditOnInvDisturbed.TabIndex = 13;
      btnEditOnInvDisturbed.Text = "Edit";
      btnEditOnInvDisturbed.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnEndDialogue1 = btnEditOnEndDialogue;
      point1 = new Point(384, 120);
      Point point120 = point1;
      editOnEndDialogue1.Location = point120;
      btnEditOnEndDialogue.Name = "btnEditOnEndDialogue";
      Button editOnEndDialogue2 = btnEditOnEndDialogue;
      size1 = new Size(32, 23);
      Size size117 = size1;
      editOnEndDialogue2.Size = size117;
      btnEditOnEndDialogue.TabIndex = 9;
      btnEditOnEndDialogue.Text = "Edit";
      btnEditOnEndDialogue.TextAlign = ContentAlignment.MiddleLeft;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(496, 517);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(TabControl1);
      Controls.Add(this.btnSave);
      Controls.Add(this.btnCancel);
      Controls.Add(btnInventory);
      Name = nameof (frmUTP_Editor);
      Text = "Placeable Editor - KotOR ";
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
      TabPageAdvanced.ResumeLayout(false);
      TabPageScripts.ResumeLayout(false);
      TabPageDescription.ResumeLayout(false);
      TabPageComments.ResumeLayout(false);
      TabPageTrap.ResumeLayout(false);
      nudDisarmDC.EndInit();
      nudTrapDetectDC.EndInit();
      nudTrapType.EndInit();
      ResumeLayout(false);
    }

  public frmUTP_Editor(
    clsUTP UTPClass,
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
      MDefaultTitleText = "Placeable Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      UTP = UTPClass;
      KotorVersionIndex = KotorVerIndex;
      Setup();
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  public void Setup()
  {
      BuildComboBoxes();
      UTP.SetTextBoxFromCExoLocStringNodeValue(tbName, "LocName");
      UTP.SetTextBoxToNodeValue(tbTag, "Tag");
      chkbPlotItem.Checked = BooleanType.FromObject(UTP.GetNodeValue("Plot"));
      chkbStatic.Checked = BooleanType.FromObject(UTP.GetNodeValue("Static"));
      chkbMin1HP.Checked = BooleanType.FromObject(UTP.GetNodeValue("Min1HP"));
      UTP.SetNumericUpDownToNodeValue(nudHardness, "Hardness");
      UTP.SetNumericUpDownToNodeValue(nudHP, "HP");
      UTP.SetNumericUpDownToNodeValue(nudFort, "Fort");
      UTP.SetNumericUpDownToNodeValue(nudRef, "Ref");
      UTP.SetNumericUpDownToNodeValue(nudWill, "Will");
      chkbLocked.Checked = BooleanType.FromObject(UTP.GetNodeValue("Locked"));
      chkbLockable.Checked = BooleanType.FromObject(UTP.GetNodeValue("Lockable"));
      chkbAutoRemoveKey.Checked = BooleanType.FromObject(UTP.GetNodeValue("AutoRemoveKey"));
      chkbKeyRequired.Checked = BooleanType.FromObject(UTP.GetNodeValue("KeyRequired"));
      UTP.SetNumericUpDownToNodeValue(nudOpenLockDC, "OpenLockDC");
      UTP.SetNumericUpDownToNodeValue(nudCloseLockDC, "CloseLockDC");
      UTP.SetTextBoxToNodeValue(tbKeyName, "KeyName");
      UTP.SetTextBoxToNodeValue(tbOnClosed, "OnClosed");
      UTP.SetTextBoxToNodeValue(tbOnDamaged, "OnDamaged");
      UTP.SetTextBoxToNodeValue(tbOnDeath, "OnDeath");
      UTP.SetTextBoxToNodeValue(tbOnDisarm, "OnDisarm");
      UTP.SetTextBoxToNodeValue(tbOnEndDialogue, "OnEndDialogue");
      UTP.SetTextBoxToNodeValue(tbOnHeartbeat, "OnHeartbeat");
      UTP.SetTextBoxToNodeValue(tbOnInvDisturbed, "OnInvDisturbed");
      UTP.SetTextBoxToNodeValue(tbOnLock, "OnLock");
      UTP.SetTextBoxToNodeValue(tbOnMeleeAttacked, "OnMeleeAttacked");
      UTP.SetTextBoxToNodeValue(tbOnOpen, "OnOpen");
      UTP.SetTextBoxToNodeValue(tbOnSpellCastAt, "OnSpellCastAt");
      UTP.SetTextBoxToNodeValue(tbOnTrapTriggered, "OnTrapTriggered");
      UTP.SetTextBoxToNodeValue(tbOnUnlock, "OnUnlock");
      UTP.SetTextBoxToNodeValue(tbOnUsed, "OnUsed");
      UTP.SetTextBoxToNodeValue(tbOnUserDefined, "OnUserDefined");
      UTP.SetTextBoxToNodeValue(tbTemplateResRef, "TemplateResRef");
      UTP.SetTextBoxToNodeValue(tbFaction, "Faction");
      UTP.SetTextBoxToNodeValue(tbConversation, "Conversation");
      chkbInterruptable.Checked = BooleanType.FromObject(UTP.GetNodeValue("Interruptable"));
      UTP.SetTextBoxToNodeValue(tbAnimationState, "AnimationState");
      UTP.SetTextBoxToNodeValue(tbType, "Type");
      chkbHasInventory.Checked = BooleanType.FromObject(UTP.GetNodeValue("HasInventory"));
      chkbPartyInteract.Checked = BooleanType.FromObject(UTP.GetNodeValue("PartyInteract"));
      chkbUsable.Checked = BooleanType.FromObject(UTP.GetNodeValue("Useable"));
      chkbTrapDetectable.Checked = BooleanType.FromObject(UTP.GetNodeValue("TrapDetectable"));
      UTP.SetNumericUpDownToNodeValue(nudTrapDetectDC, "TrapDetectDC");
      chkbTrapDisarmable.Checked = BooleanType.FromObject(UTP.GetNodeValue("TrapDisarmable"));
      UTP.SetNumericUpDownToNodeValue(nudDisarmDC, "DisarmDC");
      chkbTrapFlag.Checked = BooleanType.FromObject(UTP.GetNodeValue("TrapFlag"));
      chkbTrapOneShot.Checked = BooleanType.FromObject(UTP.GetNodeValue("TrapOneShot"));
      UTP.SetNumericUpDownToNodeValue(nudTrapType, "TrapType");
      UTP.SetTextBoxToNodeValue(tbKeyName, "KeyName");
      UTP.SetTextBoxFromCExoLocStringNodeValue(tbDescription, "Description");
      DescriptionLang = IntegerType.FromObject(UTP.GetCExoLocStringLanguage("Description"));
      tbDescription.Text = Strings.Replace(tbDescription.Text, "\n", "\r\n");
      UTP.SetTextBoxToNodeValue(tbComment, "Comment");
    }

  private void SetGFFNodeValues()
  {
      UTP.SetNodeValueFromComboBox(cmbxAppearance, "Appearance");
      UTP.SetCExoLocStringNodeValueFromTextBox(tbName, "LocName", NameLang);
      UTP.SetNodeValueFromTextBox(tbTag, "Tag");
      UTP.SetNodeValue("Plot", chkbPlotItem.Checked);
      if (UTP.VerifyNodeExists("Static"))
        UTP.SetNodeValue("Static", chkbStatic.Checked);
      if (UTP.VerifyNodeExists("Min1HP"))
        UTP.SetNodeValue("Min1HP", chkbMin1HP.Checked);
      UTP.SetNodeValueFromNumericUpDown(nudHardness, "Hardness");
      UTP.SetNodeValueFromNumericUpDown(nudHP, "HP");
      UTP.SetNodeValueFromNumericUpDown(nudFort, "Fort");
      UTP.SetNodeValueFromNumericUpDown(nudRef, "Ref");
      UTP.SetNodeValueFromNumericUpDown(nudWill, "Will");
      UTP.SetNodeValue("Locked", chkbLocked.Checked);
      UTP.SetNodeValue("Lockable", chkbLockable.Checked);
      UTP.SetNodeValue("AutoRemoveKey", chkbAutoRemoveKey.Checked);
      UTP.SetNodeValue("KeyRequired", chkbKeyRequired.Checked);
      UTP.SetNodeValueFromNumericUpDown(nudOpenLockDC, "OpenLockDC");
      UTP.SetNodeValueFromNumericUpDown(nudCloseLockDC, "CloseLockDC");
      UTP.SetNodeValueFromTextBox(tbKeyName, "KeyName");
      UTP.SetNodeValueFromTextBox(tbOnClosed, "OnClosed");
      UTP.SetNodeValueFromTextBox(tbOnDamaged, "OnDamaged");
      UTP.SetNodeValueFromTextBox(tbOnDeath, "OnDeath");
      UTP.SetNodeValueFromTextBox(tbOnDisarm, "OnDisarm");
      UTP.SetNodeValueFromTextBox(tbOnEndDialogue, "OnEndDialogue");
      UTP.SetNodeValueFromTextBox(tbOnHeartbeat, "OnHeartbeat");
      UTP.SetNodeValueFromTextBox(tbOnInvDisturbed, "OnInvDisturbed");
      UTP.SetNodeValueFromTextBox(tbOnLock, "OnLock");
      UTP.SetNodeValueFromTextBox(tbOnMeleeAttacked, "OnMeleeAttacked");
      UTP.SetNodeValueFromTextBox(tbOnOpen, "OnOpen");
      UTP.SetNodeValueFromTextBox(tbOnSpellCastAt, "OnSpellCastAt");
      UTP.SetNodeValueFromTextBox(tbOnTrapTriggered, "OnTrapTriggered");
      UTP.SetNodeValueFromTextBox(tbOnUnlock, "OnUnlock");
      UTP.SetNodeValueFromTextBox(tbOnUsed, "OnUsed");
      UTP.SetNodeValueFromTextBox(tbOnUserDefined, "OnUserDefined");
      UTP.SetNodeValueFromTextBox(tbTemplateResRef, "TemplateResRef");
      UTP.SetNodeValueFromTextBox(tbFaction, "Faction");
      UTP.SetNodeValueFromTextBox(tbConversation, "Conversation");
      UTP.SetNodeValue("Interruptable", chkbInterruptable.Checked);
      UTP.SetNodeValueFromTextBox(tbAnimationState, "AnimationState");
      UTP.SetNodeValueFromTextBox(tbType, "Type");
      UTP.SetNodeValue("HasInventory", chkbHasInventory.Checked);
      UTP.SetNodeValue("PartyInteract", chkbPartyInteract.Checked);
      UTP.SetNodeValue("Useable", chkbUsable.Checked);
      UTP.SetNodeValue("TrapDetectable", chkbTrapDetectable.Checked);
      UTP.SetNodeValueFromNumericUpDown(nudTrapDetectDC, "TrapDetectDC");
      UTP.SetNodeValue("TrapDisarmable", chkbTrapDisarmable.Checked);
      UTP.SetNodeValueFromNumericUpDown(nudDisarmDC, "DisarmDC");
      UTP.SetNodeValue("TrapFlag", chkbTrapFlag.Checked);
      UTP.SetNodeValue("TrapOneShot", chkbTrapOneShot.Checked);
      UTP.SetNodeValueFromNumericUpDown(nudTrapType, "TrapType");
      UTP.SetNodeValueFromTextBox(tbKeyName, "KeyName");
      UTP.SetCExoLocStringNodeValueFromTextBox(tbDescription, "Description");
      UTP.SetCExoLocStringNodeValueFromTextBox(new TextBox()
      {
        Text = Strings.Replace(tbDescription.Text, "\r\n", "\n")
      }, "Description", DescriptionLang);
      UTP.SetNodeValueFromTextBox(tbComment, "Comment");
    }

  private object BuildComboBoxes()
  {
      GChitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVersionIndex));
      FillComboBoxFrom2DA(cmbxAppearance, "label", "placeables", GChitinKey, null);
      if (!UTP.SyncComboBox(cmbxAppearance, "Appearance"))
      {
        int num = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
      }
      GChitinKey = null;
      object obj = null;
      return obj;
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
      }
      lblCloseLockDC.Enabled = flag;
      nudCloseLockDC.Enabled = flag;
    }

  private void btnSave_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".utp", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTP.WriteFile(MEditingFilePath, "UTP");
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

  private void btnInventory_Click(object sender, EventArgs e)
  {
      frmInventoryEditor frmInventoryEditor = new frmInventoryEditor(KotorVersionIndex);
      int num1 = checked (UTP.GetListItemCount("ItemList") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        string ResRef = StringType.FromObject(UTP.GetNodeValue("ItemList(" + StringType.FromInteger(num2) + ").InventoryRes"));
        bool Dropable = !UTP.VerifyNodeExists("ItemList(" + StringType.FromInteger(num2) + ").Dropable") || ObjectType.ObjTst(UTP.GetNodeValue("ItemList(" + StringType.FromInteger(num2) + ").Dropable"), 1, false) == 0;
        frmInventoryEditor.AddPackItem(ResRef, Dropable);
        checked { ++num2; }
      }
      frmInventoryEditor.SetFormName(tbTemplateResRef.Text + ".utp");
      frmInventoryEditor.ConfigureForPlaceableEditorUse();
      if (frmInventoryEditor.ShowDialog() != DialogResult.OK)
        return;
      int FieldValue = 0;
      UTP.ClearListElements("ItemList");
      try
      {
        foreach (InventoryItem packItems in frmInventoryEditor.GetPackItemsList())
        {
          int quantity = packItems._Quantity;
          int num3 = 1;
          while (num3 <= quantity)
          {
            GffStruct @struct = new GffStruct();
            @struct.type = FieldValue;
            @struct.fieldCount = 4;
            @struct.fields = new GFF_Field[4];
            @struct.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "InventoryRes", packItems._ResRef);
            @struct.fields[1] = new GFF_Field(GFFField.GFF_word, "Repos_PosX", FieldValue);
            @struct.fields[2] = new GFF_Field(GFFField.GFF_word, "Repos_PosY", 0);
            @struct.fields[3] = new GFF_Field(GFFField.GFF_byte, "Dropable", 1);
            if (!UTP.VerifyNodeExists("ItemList"))
              UTP.CreateList("", "ItemList");
            UTP.AddListElement("ItemList", @struct);
            checked { ++FieldValue; }
            checked { ++num3; }
          }
        }
      }
      finally
      {
       
      }
    }

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = tbName.Text + ".utp";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTP.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
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

  private void frmUTP_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmUTP_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

  public void SetFormName(string Name) => Text = "Placeable Editor - " + Name;

  private void btnEditScript_Click(object sender, EventArgs e) => Utils.EditScriptForTextBox((Button) sender, MEditingFilePath, KotorVersionIndex);
}