using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using Kotortool_Legacy.API;
using Kotortool_Legacy.Application;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Kotortool_Legacy;

public class frmUTC_Editor : frmParent
{
  [AccessedThroughProperty("tbOnEndRound")]
  private TextBox _tbOnEndRound;
  [AccessedThroughProperty("tbOnDisturbed")]
  private TextBox _tbOnDisturbed;
  [AccessedThroughProperty("tbOnDamaged")]
  private TextBox _tbOnDamaged;
  [AccessedThroughProperty("tbComments")]
  private TextBox _tbComments;
  [AccessedThroughProperty("tbOnAttacked")]
  private TextBox _tbOnAttacked;
  [AccessedThroughProperty("tbOnSpellAt")]
  private TextBox _tbOnSpellAt;
  [AccessedThroughProperty("tbOnNotice")]
  private TextBox _tbOnNotice;
  [AccessedThroughProperty("tbOnHeartbeat")]
  private TextBox _tbOnHeartbeat;
  [AccessedThroughProperty("nudTreatInjury")]
  private NumericUpDown _nudTreatInjury;
  [AccessedThroughProperty("nudSecurity")]
  private NumericUpDown _nudSecurity;
  [AccessedThroughProperty("nudRepair")]
  private NumericUpDown _nudRepair;
  [AccessedThroughProperty("nudPersuade")]
  private NumericUpDown _nudPersuade;
  [AccessedThroughProperty("nudAwareness")]
  private NumericUpDown _nudAwareness;
  [AccessedThroughProperty("nudStealth")]
  private NumericUpDown _nudStealth;
  [AccessedThroughProperty("nudDemolitions")]
  private NumericUpDown _nudDemolitions;
  [AccessedThroughProperty("nudComputerUse")]
  private NumericUpDown _nudComputerUse;
  [AccessedThroughProperty("cmbxClass")]
  private ComboBox _cmbxClass;
  [AccessedThroughProperty("nudRefBonus")]
  private NumericUpDown _nudRefBonus;
  [AccessedThroughProperty("nudFortBonus")]
  private NumericUpDown _nudFortBonus;
  [AccessedThroughProperty("nudWillBonus")]
  private NumericUpDown _nudWillBonus;
  [AccessedThroughProperty("nudNaturalAC")]
  private NumericUpDown _nudNaturalAC;
  [AccessedThroughProperty("GroupBox7")]
  private GroupBox _GroupBox7;
  [AccessedThroughProperty("nudBaseHP")]
  private NumericUpDown _nudBaseHP;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("gb2")]
  private GroupBox _gb2;
  [AccessedThroughProperty("nudCharisma")]
  private NumericUpDown _nudCharisma;
  [AccessedThroughProperty("Label46")]
  private Label _Label46;
  [AccessedThroughProperty("nudWisdom")]
  private NumericUpDown _nudWisdom;
  [AccessedThroughProperty("Label44")]
  private Label _Label44;
  [AccessedThroughProperty("tbOnEndDialogu")]
  private TextBox _tbOnEndDialogu;
  [AccessedThroughProperty("tbOnDialogue")]
  private TextBox _tbOnDialogue;
  [AccessedThroughProperty("Label45")]
  private Label _Label45;
  [AccessedThroughProperty("tbOnSpawn")]
  private TextBox _tbOnSpawn;
  [AccessedThroughProperty("nudIntelligence")]
  private NumericUpDown _nudIntelligence;
  [AccessedThroughProperty("Label43")]
  private Label _Label43;
  [AccessedThroughProperty("Label47")]
  private Label _Label47;
  [AccessedThroughProperty("tbOnRested")]
  private TextBox _tbOnRested;
  [AccessedThroughProperty("Label49")]
  private Label _Label49;
  [AccessedThroughProperty("tbOnDeath")]
  private TextBox _tbOnDeath;
  [AccessedThroughProperty("nudConstitution")]
  private NumericUpDown _nudConstitution;
  [AccessedThroughProperty("Label42")]
  private Label _Label42;
  [AccessedThroughProperty("nudDexterity")]
  private NumericUpDown _nudDexterity;
  [AccessedThroughProperty("Label41")]
  private Label _Label41;
  [AccessedThroughProperty("nudStrength")]
  private NumericUpDown _nudStrength;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("Label50")]
  private Label _Label50;
  [AccessedThroughProperty("tbOnBlocked")]
  private TextBox _tbOnBlocked;
  [AccessedThroughProperty("cmbxPhenotype")]
  private ComboBox _cmbxPhenotype;
  [AccessedThroughProperty("tabCtrl1")]
  private TabControl _tabCtrl1;
  [AccessedThroughProperty("cmbxAppearance")]
  private ComboBox _cmbxAppearance;
  [AccessedThroughProperty("tbDescription")]
  private TextBox _tbDescription;
  [AccessedThroughProperty("tbLastName")]
  private TextBox _tbLastName;
  [AccessedThroughProperty("tbFirstName")]
  private TextBox _tbFirstName;
  [AccessedThroughProperty("Label51")]
  private Label _Label51;
  [AccessedThroughProperty("tbOnUserDefine")]
  private TextBox _tbOnUserDefine;
  [AccessedThroughProperty("chkbNotInterruptable")]
  private CheckBox _chkbNotInterruptable;
  [AccessedThroughProperty("Label52")]
  private Label _Label52;
  [AccessedThroughProperty("nudClassLevel")]
  private NumericUpDown _nudClassLevel;
  [AccessedThroughProperty("cmbxRace")]
  private ComboBox _cmbxRace;
  [AccessedThroughProperty("Label53")]
  private Label _Label53;
  [AccessedThroughProperty("GroupBox8")]
  private GroupBox _GroupBox8;
  [AccessedThroughProperty("Label54")]
  private Label _Label54;
  [AccessedThroughProperty("GroupBox9")]
  private GroupBox _GroupBox9;
  [AccessedThroughProperty("Label55")]
  private Label _Label55;
  [AccessedThroughProperty("trkbarAlignment")]
  private TrackBar _trkbarAlignment;
  [AccessedThroughProperty("tbConversation")]
  private TextBox _tbConversation;
  [AccessedThroughProperty("Label56")]
  private Label _Label56;
  [AccessedThroughProperty("nudAlignment")]
  private NumericUpDown _nudAlignment;
  [AccessedThroughProperty("Label57")]
  private Label _Label57;
  [AccessedThroughProperty("chklbFeats")]
  private CheckedListBox _chklbFeats;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("tbFeatSummary")]
  private TextBox _tbFeatSummary;
  [AccessedThroughProperty("GroupBox10")]
  private GroupBox _GroupBox10;
  [AccessedThroughProperty("nudCurrentHP")]
  private NumericUpDown _nudCurrentHP;
  [AccessedThroughProperty("btnWriteFile")]
  private Button _btnWriteFile;
  [AccessedThroughProperty("tpComments")]
  private TabPage _tpComments;
  [AccessedThroughProperty("tpSpecialAbilities")]
  private TabPage _tpSpecialAbilities;
  [AccessedThroughProperty("toForcePowers")]
  private TabPage _toForcePowers;
  [AccessedThroughProperty("tpFeats")]
  private TabPage _tpFeats;
  [AccessedThroughProperty("tpAdvanced")]
  private TabPage _tpAdvanced;
  [AccessedThroughProperty("nudMaxHP")]
  private NumericUpDown _nudMaxHP;
  [AccessedThroughProperty("GroupBox11")]
  private GroupBox _GroupBox11;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("chkbDisarmable")]
  private CheckBox _chkbDisarmable;
  [AccessedThroughProperty("tpScripts")]
  private TabPage _tpScripts;
  [AccessedThroughProperty("tpSkills")]
  private TabPage _tpSkills;
  [AccessedThroughProperty("chkbPlot")]
  private CheckBox _chkbPlot;
  [AccessedThroughProperty("chkbNoPermDeath")]
  private CheckBox _chkbNoPermDeath;
  [AccessedThroughProperty("GroupBox12")]
  private GroupBox _GroupBox12;
  [AccessedThroughProperty("GroupBox13")]
  private GroupBox _GroupBox13;
  [AccessedThroughProperty("GroupBox14")]
  private GroupBox _GroupBox14;
  [AccessedThroughProperty("tbChallengeRating")]
  private TextBox _tbChallengeRating;
  [AccessedThroughProperty("GroupBox15")]
  private GroupBox _GroupBox15;
  [AccessedThroughProperty("cmbxPerceptionRange")]
  private ComboBox _cmbxPerceptionRange;
  [AccessedThroughProperty("tpClasses")]
  private TabPage _tpClasses;
  [AccessedThroughProperty("tpStatistics")]
  private TabPage _tpStatistics;
  [AccessedThroughProperty("tbDeity")]
  private TextBox _tbDeity;
  [AccessedThroughProperty("GroupBox16")]
  private GroupBox _GroupBox16;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("GroupBox17")]
  private GroupBox _GroupBox17;
  [AccessedThroughProperty("chklbForcePowers")]
  private CheckedListBox _chklbForcePowers;
  [AccessedThroughProperty("nudForcePoints")]
  private NumericUpDown _nudForcePoints;
  [AccessedThroughProperty("Label27")]
  private Label _Label27;
  [AccessedThroughProperty("nudCurrentForce")]
  private NumericUpDown _nudCurrentForce;
  [AccessedThroughProperty("tpBasic")]
  private TabPage _tpBasic;
  [AccessedThroughProperty("chklbSpecialAbilities")]
  private CheckedListBox _chklbSpecialAbilities;
  [AccessedThroughProperty("GroupBox18")]
  private GroupBox _GroupBox18;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("tbTemplateResRef")]
  private TextBox _tbTemplateResRef;
  [AccessedThroughProperty("cmbxTreasureModel")]
  private ComboBox _cmbxTreasureModel;
  [AccessedThroughProperty("Label29")]
  private Label _Label29;
  [AccessedThroughProperty("cmbxSoundSet")]
  private ComboBox _cmbxSoundSet;
  [AccessedThroughProperty("cmbxPortrait")]
  private ComboBox _cmbxPortrait;
  [AccessedThroughProperty("cmbxSubrace")]
  private ComboBox _cmbxSubrace;
  [AccessedThroughProperty("btnClearAllPowers")]
  private Button _btnClearAllPowers;
  [AccessedThroughProperty("btnSelectAllPowers")]
  private Button _btnSelectAllPowers;
  [AccessedThroughProperty("btnInventory")]
  private Button _btnInventory;
  [AccessedThroughProperty("GroupBox19")]
  private GroupBox _GroupBox19;
  [AccessedThroughProperty("tbForcePowerSummary")]
  private TextBox _tbForcePowerSummary;
  [AccessedThroughProperty("GroupBox20")]
  private GroupBox _GroupBox20;
  [AccessedThroughProperty("cmbxBodyBag")]
  private ComboBox _cmbxBodyBag;
  [AccessedThroughProperty("chkbIsHologram")]
  private CheckBox _chkbIsHologram;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("chkbNotReorienting")]
  private CheckBox _chkbNotReorienting;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("chkbIgnoreCrePath")]
  private CheckBox _chkbIgnoreCrePath;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("nudMultiplierSet")]
  private NumericUpDown _nudMultiplierSet;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("lblMultiplierSet")]
  private Label _lblMultiplierSet;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("lblBlindSpot")]
  private Label _lblBlindSpot;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("nudBlindSpot")]
  private NumericUpDown _nudBlindSpot;
  [AccessedThroughProperty("chkbMin1HP")]
  private CheckBox _chkbMin1HP;
  [AccessedThroughProperty("cmbxGender")]
  private ComboBox _cmbxGender;
  [AccessedThroughProperty("cmbxFaction")]
  private ComboBox _cmbxFaction;
  [AccessedThroughProperty("chkbIsPC")]
  private CheckBox _chkbIsPC;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("btnEditOnEndDialogu")]
  private Button _btnEditOnEndDialogu;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("cmbxMovementRate")]
  private ComboBox _cmbxMovementRate;
  [AccessedThroughProperty("btnEditOnDialogue")]
  private Button _btnEditOnDialogue;
  [AccessedThroughProperty("Label33")]
  private Label _Label33;
  [AccessedThroughProperty("btnEditOnUserDefine")]
  private Button _btnEditOnUserDefine;
  [AccessedThroughProperty("Label48")]
  private Label _Label48;
  [AccessedThroughProperty("btnEditOnHeartbeat")]
  private Button _btnEditOnHeartbeat;
  [AccessedThroughProperty("btnEditOnDisturbed")]
  private Button _btnEditOnDisturbed;
  [AccessedThroughProperty("btnEditOnDamaged")]
  private Button _btnEditOnDamaged;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("btnEditOnAttacked")]
  private Button _btnEditOnAttacked;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("btnEditOnNotice")]
  private Button _btnEditOnNotice;
  [AccessedThroughProperty("btnEditOnSpellAt")]
  private Button _btnEditOnSpellAt;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnEditOnSpawn")]
  private Button _btnEditOnSpawn;
  [AccessedThroughProperty("Label35")]
  private Label _Label35;
  [AccessedThroughProperty("btnEditOnDeath")]
  private Button _btnEditOnDeath;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("btnEditOnBlocked")]
  private Button _btnEditOnBlocked;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("btnEditOnRested")]
  private Button _btnEditOnRested;
  [AccessedThroughProperty("btnEditOnEndRound")]
  private Button _btnEditOnEndRound;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label31")]
  private Label _Label31;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label37")]
  private Label _Label37;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("Label39")]
  private Label _Label39;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  private IContainer components;
  public clsUTC UTC;
  public clsDialogTlk g_clsDialogTlk;
  private bool ComboBoxSettingError;
  private bool m_bSaveGameMode;
  private ArrayList g_ForcePowerList;

  public frmUTC_Editor()
  {
      Load += new EventHandler(frmUTC_Editor_Load);
      Closing += new CancelEventHandler(frmUTC_Editor_Closing);
      ComboBoxSettingError = false;
      m_bSaveGameMode = false;
      g_ForcePowerList = new ArrayList();
      InitializeComponent();
    }

  protected override void Dispose(bool disposing)
  {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

  internal virtual TabPage tpBasic
  {
    get => _tpBasic;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpBasic == null)
          ;
        _tpBasic = value;
        if (_tpBasic == null)
          ;
      }
  }

  internal virtual TabPage tpStatistics
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpStatistics == null)
          ;
        _tpStatistics = value;
        if (_tpStatistics == null)
          ;
      }
    get => _tpStatistics;
  }

  internal virtual TabPage tpClasses
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpClasses == null)
          ;
        _tpClasses = value;
        if (_tpClasses == null)
          ;
      }
    get => _tpClasses;
  }

  internal virtual TabPage tpSkills
  {
    get => _tpSkills;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpSkills == null)
          ;
        _tpSkills = value;
        if (_tpSkills == null)
          ;
      }
  }

  internal virtual TabPage tpScripts
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpScripts == null)
          ;
        _tpScripts = value;
        if (_tpScripts == null)
          ;
      }
    get => _tpScripts;
  }

  internal virtual TabPage tpAdvanced
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpAdvanced == null)
          ;
        _tpAdvanced = value;
        if (_tpAdvanced == null)
          ;
      }
    get => _tpAdvanced;
  }

  internal virtual TabPage tpFeats
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpFeats == null)
          ;
        _tpFeats = value;
        if (_tpFeats == null)
          ;
      }
    get => _tpFeats;
  }

  internal virtual TabPage toForcePowers
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_toForcePowers == null)
          ;
        _toForcePowers = value;
        if (_toForcePowers == null)
          ;
      }
    get => _toForcePowers;
  }

  internal virtual TabPage tpSpecialAbilities
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpSpecialAbilities == null)
          ;
        _tpSpecialAbilities = value;
        if (_tpSpecialAbilities == null)
          ;
      }
    get => _tpSpecialAbilities;
  }

  internal virtual TabPage tpComments
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tpComments == null)
          ;
        _tpComments = value;
        if (_tpComments == null)
          ;
      }
    get => _tpComments;
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox2 == null)
          ;
        _GroupBox2 = value;
        if (_GroupBox2 == null)
          ;
      }
    get => _GroupBox2;
  }

  internal virtual GroupBox GroupBox3
  {
    get => _GroupBox3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox3 == null)
          ;
        _GroupBox3 = value;
        if (_GroupBox3 == null)
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

  internal virtual ComboBox cmbxRace
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxRace == null)
          ;
        _cmbxRace = value;
        if (_cmbxRace == null)
          ;
      }
    get => _cmbxRace;
  }

  internal virtual TextBox tbFirstName
  {
    get => _tbFirstName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFirstName == null)
          ;
        _tbFirstName = value;
        if (_tbFirstName == null)
          ;
      }
  }

  internal virtual TextBox tbLastName
  {
    get => _tbLastName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbLastName == null)
          ;
        _tbLastName = value;
        if (_tbLastName == null)
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

  internal virtual TextBox tbDescription
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDescription == null)
          ;
        _tbDescription = value;
        if (_tbDescription == null)
          ;
      }
    get => _tbDescription;
  }

  internal virtual ComboBox cmbxAppearance
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxAppearance == null)
          ;
        _cmbxAppearance = value;
        if (_cmbxAppearance == null)
          ;
      }
    get => _cmbxAppearance;
  }

  internal virtual ComboBox cmbxGender
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxGender == null)
          ;
        _cmbxGender = value;
        if (_cmbxGender == null)
          ;
      }
    get => _cmbxGender;
  }

  internal virtual TabControl tabCtrl1
  {
    get => _tabCtrl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabCtrl1 == null)
          ;
        _tabCtrl1 = value;
        if (_tabCtrl1 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxPhenotype
  {
    get => _cmbxPhenotype;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxPhenotype == null)
          ;
        _cmbxPhenotype = value;
        if (_cmbxPhenotype == null)
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

  internal virtual Label Label13
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label13 == null)
          ;
        _Label13 = value;
        if (_Label13 == null)
          ;
      }
    get => _Label13;
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

  internal virtual GroupBox GroupBox4
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox4 == null)
          ;
        _GroupBox4 = value;
        if (_GroupBox4 == null)
          ;
      }
    get => _GroupBox4;
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

  internal virtual NumericUpDown nudStrength
  {
    get => _nudStrength;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudStrength == null)
          ;
        _nudStrength = value;
        if (_nudStrength == null)
          ;
      }
  }

  internal virtual NumericUpDown nudDexterity
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudDexterity == null)
          ;
        _nudDexterity = value;
        if (_nudDexterity == null)
          ;
      }
    get => _nudDexterity;
  }

  internal virtual NumericUpDown nudConstitution
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudConstitution == null)
          ;
        _nudConstitution = value;
        if (_nudConstitution == null)
          ;
      }
    get => _nudConstitution;
  }

  internal virtual NumericUpDown nudIntelligence
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudIntelligence == null)
          ;
        _nudIntelligence = value;
        if (_nudIntelligence == null)
          ;
      }
    get => _nudIntelligence;
  }

  internal virtual NumericUpDown nudWisdom
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudWisdom == null)
          ;
        _nudWisdom = value;
        if (_nudWisdom == null)
          ;
      }
    get => _nudWisdom;
  }

  internal virtual NumericUpDown nudCharisma
  {
    get => _nudCharisma;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCharisma == null)
          ;
        _nudCharisma = value;
        if (_nudCharisma == null)
          ;
      }
  }

  internal virtual GroupBox gb2
  {
    get => _gb2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gb2 == null)
          ;
        _gb2 = value;
        if (_gb2 == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox6
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox6 == null)
          ;
        _GroupBox6 = value;
        if (_GroupBox6 == null)
          ;
      }
    get => _GroupBox6;
  }

  internal virtual GroupBox GroupBox5
  {
    get => _GroupBox5;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox5 == null)
          ;
        _GroupBox5 = value;
        if (_GroupBox5 == null)
          ;
      }
  }

  internal virtual Label Label16
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label16 == null)
          ;
        _Label16 = value;
        if (_Label16 == null)
          ;
      }
    get => _Label16;
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

  internal virtual NumericUpDown nudBaseHP
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudBaseHP == null)
          ;
        _nudBaseHP = value;
        if (_nudBaseHP == null)
          ;
      }
    get => _nudBaseHP;
  }

  internal virtual GroupBox GroupBox7
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox7 == null)
          ;
        _GroupBox7 = value;
        if (_GroupBox7 == null)
          ;
      }
    get => _GroupBox7;
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

  internal virtual NumericUpDown nudNaturalAC
  {
    get => _nudNaturalAC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudNaturalAC == null)
          ;
        _nudNaturalAC = value;
        if (_nudNaturalAC == null)
          ;
      }
  }

  internal virtual Label Label19
  {
    get => _Label19;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label19 == null)
          ;
        _Label19 = value;
        if (_Label19 == null)
          ;
      }
  }

  internal virtual Label Label20
  {
    get => _Label20;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label20 == null)
          ;
        _Label20 = value;
        if (_Label20 == null)
          ;
      }
  }

  internal virtual Label Label21
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label21 == null)
          ;
        _Label21 = value;
        if (_Label21 == null)
          ;
      }
    get => _Label21;
  }

  internal virtual NumericUpDown nudWillBonus
  {
    get => _nudWillBonus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudWillBonus == null)
          ;
        _nudWillBonus = value;
        if (_nudWillBonus == null)
          ;
      }
  }

  internal virtual NumericUpDown nudFortBonus
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudFortBonus == null)
          ;
        _nudFortBonus = value;
        if (_nudFortBonus == null)
          ;
      }
    get => _nudFortBonus;
  }

  internal virtual NumericUpDown nudRefBonus
  {
    get => _nudRefBonus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudRefBonus == null)
          ;
        _nudRefBonus = value;
        if (_nudRefBonus == null)
          ;
      }
  }

  internal virtual Label Label22
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label22 == null)
          ;
        _Label22 = value;
        if (_Label22 == null)
          ;
      }
    get => _Label22;
  }

  internal virtual ComboBox cmbxMovementRate
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxMovementRate == null)
          ;
        _cmbxMovementRate = value;
        if (_cmbxMovementRate == null)
          ;
      }
    get => _cmbxMovementRate;
  }

  internal virtual Label Label23
  {
    get => _Label23;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label23 == null)
          ;
        _Label23 = value;
        if (_Label23 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxClass
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxClass == null)
          ;
        _cmbxClass = value;
        if (_cmbxClass == null)
          ;
      }
    get => _cmbxClass;
  }

  internal virtual NumericUpDown nudComputerUse
  {
    get => _nudComputerUse;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudComputerUse == null)
          ;
        _nudComputerUse = value;
        if (_nudComputerUse == null)
          ;
      }
  }

  internal virtual Label Label24
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label24 == null)
          ;
        _Label24 = value;
        if (_Label24 == null)
          ;
      }
    get => _Label24;
  }

  internal virtual Label Label25
  {
    get => _Label25;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label25 == null)
          ;
        _Label25 = value;
        if (_Label25 == null)
          ;
      }
  }

  internal virtual Label Label26
  {
    get => _Label26;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label26 == null)
          ;
        _Label26 = value;
        if (_Label26 == null)
          ;
      }
  }

  internal virtual Label Label27
  {
    get => _Label27;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label27 == null)
          ;
        _Label27 = value;
        if (_Label27 == null)
          ;
      }
  }

  internal virtual Label Label28
  {
    get => _Label28;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label28 == null)
          ;
        _Label28 = value;
        if (_Label28 == null)
          ;
      }
  }

  internal virtual Label Label29
  {
    get => _Label29;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label29 == null)
          ;
        _Label29 = value;
        if (_Label29 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudDemolitions
  {
    get => _nudDemolitions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudDemolitions == null)
          ;
        _nudDemolitions = value;
        if (_nudDemolitions == null)
          ;
      }
  }

  internal virtual NumericUpDown nudStealth
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudStealth == null)
          ;
        _nudStealth = value;
        if (_nudStealth == null)
          ;
      }
    get => _nudStealth;
  }

  internal virtual NumericUpDown nudAwareness
  {
    get => _nudAwareness;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudAwareness == null)
          ;
        _nudAwareness = value;
        if (_nudAwareness == null)
          ;
      }
  }

  internal virtual NumericUpDown nudPersuade
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudPersuade == null)
          ;
        _nudPersuade = value;
        if (_nudPersuade == null)
          ;
      }
    get => _nudPersuade;
  }

  internal virtual NumericUpDown nudRepair
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudRepair == null)
          ;
        _nudRepair = value;
        if (_nudRepair == null)
          ;
      }
    get => _nudRepair;
  }

  internal virtual Label Label30
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label30 == null)
          ;
        _Label30 = value;
        if (_Label30 == null)
          ;
      }
    get => _Label30;
  }

  internal virtual NumericUpDown nudSecurity
  {
    get => _nudSecurity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudSecurity == null)
          ;
        _nudSecurity = value;
        if (_nudSecurity == null)
          ;
      }
  }

  internal virtual NumericUpDown nudTreatInjury
  {
    get => _nudTreatInjury;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudTreatInjury == null)
          ;
        _nudTreatInjury = value;
        if (_nudTreatInjury == null)
          ;
      }
  }

  internal virtual Label Label31
  {
    get => _Label31;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label31 == null)
          ;
        _Label31 = value;
        if (_Label31 == null)
          ;
      }
  }

  internal virtual Label Label32
  {
    get => _Label32;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label32 == null)
          ;
        _Label32 = value;
        if (_Label32 == null)
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

  internal virtual Label Label44
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label44 == null)
          ;
        _Label44 = value;
        if (_Label44 == null)
          ;
      }
    get => _Label44;
  }

  internal virtual TextBox tbOnHeartbeat
  {
    get => _tbOnHeartbeat;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnHeartbeat == null)
          ;
        _tbOnHeartbeat = value;
        if (_tbOnHeartbeat == null)
          ;
      }
  }

  internal virtual TextBox tbOnNotice
  {
    get => _tbOnNotice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnNotice == null)
          ;
        _tbOnNotice = value;
        if (_tbOnNotice == null)
          ;
      }
  }

  internal virtual TextBox tbOnSpellAt
  {
    get => _tbOnSpellAt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnSpellAt == null)
          ;
        _tbOnSpellAt = value;
        if (_tbOnSpellAt == null)
          ;
      }
  }

  internal virtual TextBox tbOnAttacked
  {
    get => _tbOnAttacked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnAttacked == null)
          ;
        _tbOnAttacked = value;
        if (_tbOnAttacked == null)
          ;
      }
  }

  internal virtual TextBox tbOnDamaged
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDamaged == null)
          ;
        _tbOnDamaged = value;
        if (_tbOnDamaged == null)
          ;
      }
    get => _tbOnDamaged;
  }

  internal virtual TextBox tbOnDisturbed
  {
    get => _tbOnDisturbed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDisturbed == null)
          ;
        _tbOnDisturbed = value;
        if (_tbOnDisturbed == null)
          ;
      }
  }

  internal virtual TextBox tbOnEndRound
  {
    get => _tbOnEndRound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnEndRound == null)
          ;
        _tbOnEndRound = value;
        if (_tbOnEndRound == null)
          ;
      }
  }

  internal virtual TextBox tbOnEndDialogu
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnEndDialogu == null)
          ;
        _tbOnEndDialogu = value;
        if (_tbOnEndDialogu == null)
          ;
      }
    get => _tbOnEndDialogu;
  }

  internal virtual TextBox tbOnDialogue
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnDialogue == null)
          ;
        _tbOnDialogue = value;
        if (_tbOnDialogue == null)
          ;
      }
    get => _tbOnDialogue;
  }

  internal virtual TextBox tbOnSpawn
  {
    get => _tbOnSpawn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnSpawn == null)
          ;
        _tbOnSpawn = value;
        if (_tbOnSpawn == null)
          ;
      }
  }

  internal virtual TextBox tbOnRested
  {
    get => _tbOnRested;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnRested == null)
          ;
        _tbOnRested = value;
        if (_tbOnRested == null)
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

  internal virtual TextBox tbOnBlocked
  {
    get => _tbOnBlocked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnBlocked == null)
          ;
        _tbOnBlocked = value;
        if (_tbOnBlocked == null)
          ;
      }
  }

  internal virtual TextBox tbOnUserDefine
  {
    get => _tbOnUserDefine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbOnUserDefine == null)
          ;
        _tbOnUserDefine = value;
        if (_tbOnUserDefine == null)
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

  internal virtual CheckBox chkbNotInterruptable
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbNotInterruptable == null)
          ;
        _chkbNotInterruptable = value;
        if (_chkbNotInterruptable == null)
          ;
      }
    get => _chkbNotInterruptable;
  }

  internal virtual Label Label46
  {
    get => _Label46;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label46 == null)
          ;
        _Label46 = value;
        if (_Label46 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudClassLevel
  {
    get => _nudClassLevel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudClassLevel == null)
          ;
        _nudClassLevel = value;
        if (_nudClassLevel == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox8
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox8 == null)
          ;
        _GroupBox8 = value;
        if (_GroupBox8 == null)
          ;
      }
    get => _GroupBox8;
  }

  internal virtual GroupBox GroupBox9
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox9 == null)
          ;
        _GroupBox9 = value;
        if (_GroupBox9 == null)
          ;
      }
    get => _GroupBox9;
  }

  internal virtual TrackBar trkbarAlignment
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_trkbarAlignment != null)
          _trkbarAlignment.Scroll -= new EventHandler(trkbarAlignment_Scroll);
        _trkbarAlignment = value;
        if (_trkbarAlignment == null)
          return;
        _trkbarAlignment.Scroll += new EventHandler(trkbarAlignment_Scroll);
      }
    get => _trkbarAlignment;
  }

  internal virtual Label Label47
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label47 == null)
          ;
        _Label47 = value;
        if (_Label47 == null)
          ;
      }
    get => _Label47;
  }

  internal virtual Label Label48
  {
    get => _Label48;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label48 == null)
          ;
        _Label48 = value;
        if (_Label48 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudAlignment
  {
    get => _nudAlignment;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudAlignment != null)
          _nudAlignment.ValueChanged -= new EventHandler(nudAlignment_ValueChanged);
        _nudAlignment = value;
        if (_nudAlignment == null)
          return;
        _nudAlignment.ValueChanged += new EventHandler(nudAlignment_ValueChanged);
      }
  }

  internal virtual CheckedListBox chklbFeats
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chklbFeats != null)
          _chklbFeats.MouseMove -= new MouseEventHandler(chklbFeats_MouseMove);
        _chklbFeats = value;
        if (_chklbFeats == null)
          return;
        _chklbFeats.MouseMove += new MouseEventHandler(chklbFeats_MouseMove);
      }
    get => _chklbFeats;
  }

  internal virtual TextBox tbFeatSummary
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbFeatSummary == null)
          ;
        _tbFeatSummary = value;
        if (_tbFeatSummary == null)
          ;
      }
    get => _tbFeatSummary;
  }

  internal virtual GroupBox GroupBox10
  {
    get => _GroupBox10;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox10 == null)
          ;
        _GroupBox10 = value;
        if (_GroupBox10 == null)
          ;
      }
  }

  internal virtual Label Label49
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label49 == null)
          ;
        _Label49 = value;
        if (_Label49 == null)
          ;
      }
    get => _Label49;
  }

  internal virtual NumericUpDown nudCurrentHP
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCurrentHP == null)
          ;
        _nudCurrentHP = value;
        if (_nudCurrentHP == null)
          ;
      }
    get => _nudCurrentHP;
  }

  internal virtual NumericUpDown nudMaxHP
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudMaxHP == null)
          ;
        _nudMaxHP = value;
        if (_nudMaxHP == null)
          ;
      }
    get => _nudMaxHP;
  }

  internal virtual Label Label50
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label50 == null)
          ;
        _Label50 = value;
        if (_Label50 == null)
          ;
      }
    get => _Label50;
  }

  internal virtual TextBox tbComments
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbComments == null)
          ;
        _tbComments = value;
        if (_tbComments == null)
          ;
      }
    get => _tbComments;
  }

  internal virtual GroupBox GroupBox11
  {
    get => _GroupBox11;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox11 == null)
          ;
        _GroupBox11 = value;
        if (_GroupBox11 == null)
          ;
      }
  }

  internal virtual Label Label51
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label51 == null)
          ;
        _Label51 = value;
        if (_Label51 == null)
          ;
      }
    get => _Label51;
  }

  internal virtual Label Label52
  {
    get => _Label52;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label52 == null)
          ;
        _Label52 = value;
        if (_Label52 == null)
          ;
      }
  }

  internal virtual CheckBox chkbDisarmable
  {
    get => _chkbDisarmable;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbDisarmable == null)
          ;
        _chkbDisarmable = value;
        if (_chkbDisarmable == null)
          ;
      }
  }

  internal virtual CheckBox chkbPlot
  {
    get => _chkbPlot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbPlot == null)
          ;
        _chkbPlot = value;
        if (_chkbPlot == null)
          ;
      }
  }

  internal virtual CheckBox chkbNoPermDeath
  {
    get => _chkbNoPermDeath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbNoPermDeath == null)
          ;
        _chkbNoPermDeath = value;
        if (_chkbNoPermDeath == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox12
  {
    get => _GroupBox12;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox12 == null)
          ;
        _GroupBox12 = value;
        if (_GroupBox12 == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox13
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox13 == null)
          ;
        _GroupBox13 = value;
        if (_GroupBox13 == null)
          ;
      }
    get => _GroupBox13;
  }

  internal virtual GroupBox GroupBox14
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox14 == null)
          ;
        _GroupBox14 = value;
        if (_GroupBox14 == null)
          ;
      }
    get => _GroupBox14;
  }

  internal virtual TextBox tbChallengeRating
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbChallengeRating == null)
          ;
        _tbChallengeRating = value;
        if (_tbChallengeRating == null)
          ;
      }
    get => _tbChallengeRating;
  }

  internal virtual GroupBox GroupBox15
  {
    get => _GroupBox15;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox15 == null)
          ;
        _GroupBox15 = value;
        if (_GroupBox15 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxPerceptionRange
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxPerceptionRange == null)
          ;
        _cmbxPerceptionRange = value;
        if (_cmbxPerceptionRange == null)
          ;
      }
    get => _cmbxPerceptionRange;
  }

  internal virtual TextBox tbDeity
  {
    get => _tbDeity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbDeity == null)
          ;
        _tbDeity = value;
        if (_tbDeity == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox16
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox16 == null)
          ;
        _GroupBox16 = value;
        if (_GroupBox16 == null)
          ;
      }
    get => _GroupBox16;
  }

  internal virtual GroupBox GroupBox17
  {
    get => _GroupBox17;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox17 == null)
          ;
        _GroupBox17 = value;
        if (_GroupBox17 == null)
          ;
      }
  }

  internal virtual CheckedListBox chklbForcePowers
  {
    get => _chklbForcePowers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chklbForcePowers != null)
          _chklbForcePowers.MouseMove -= new MouseEventHandler(chklbForcePowers_MouseMove);
        _chklbForcePowers = value;
        if (_chklbForcePowers == null)
          return;
        _chklbForcePowers.MouseMove += new MouseEventHandler(chklbForcePowers_MouseMove);
      }
  }

  internal virtual Label Label54
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label54 == null)
          ;
        _Label54 = value;
        if (_Label54 == null)
          ;
      }
    get => _Label54;
  }

  internal virtual Label Label55
  {
    get => _Label55;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label55 == null)
          ;
        _Label55 = value;
        if (_Label55 == null)
          ;
      }
  }

  internal virtual NumericUpDown nudForcePoints
  {
    get => _nudForcePoints;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudForcePoints == null)
          ;
        _nudForcePoints = value;
        if (_nudForcePoints == null)
          ;
      }
  }

  internal virtual NumericUpDown nudCurrentForce
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudCurrentForce == null)
          ;
        _nudCurrentForce = value;
        if (_nudCurrentForce == null)
          ;
      }
    get => _nudCurrentForce;
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

  internal virtual CheckedListBox chklbSpecialAbilities
  {
    get => _chklbSpecialAbilities;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chklbSpecialAbilities == null)
          ;
        _chklbSpecialAbilities = value;
        if (_chklbSpecialAbilities == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox18
  {
    get => _GroupBox18;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox18 == null)
          ;
        _GroupBox18 = value;
        if (_GroupBox18 == null)
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

  internal virtual Label Label56
  {
    get => _Label56;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label56 == null)
          ;
        _Label56 = value;
        if (_Label56 == null)
          ;
      }
  }

  internal virtual Label Label57
  {
    get => _Label57;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label57 == null)
          ;
        _Label57 = value;
        if (_Label57 == null)
          ;
      }
  }

  internal virtual ComboBox cmbxTreasureModel
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxTreasureModel == null)
          ;
        _cmbxTreasureModel = value;
        if (_cmbxTreasureModel == null)
          ;
      }
    get => _cmbxTreasureModel;
  }

  internal virtual Button btnWriteFile
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnWriteFile != null)
          _btnWriteFile.Click -= new EventHandler(btnWriteFile_Click);
        _btnWriteFile = value;
        if (_btnWriteFile == null)
          return;
        _btnWriteFile.Click += new EventHandler(btnWriteFile_Click);
      }
    get => _btnWriteFile;
  }

  internal virtual ComboBox cmbxSoundSet
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxSoundSet == null)
          ;
        _cmbxSoundSet = value;
        if (_cmbxSoundSet == null)
          ;
      }
    get => _cmbxSoundSet;
  }

  internal virtual ComboBox cmbxPortrait
  {
    get => _cmbxPortrait;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxPortrait == null)
          ;
        _cmbxPortrait = value;
        if (_cmbxPortrait == null)
          ;
      }
  }

  internal virtual ComboBox cmbxSubrace
  {
    get => _cmbxSubrace;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxSubrace == null)
          ;
        _cmbxSubrace = value;
        if (_cmbxSubrace == null)
          ;
      }
  }

  internal virtual Button btnClearAllPowers
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnClearAllPowers != null)
          _btnClearAllPowers.Click -= new EventHandler(btnClearAllPowers_Click);
        _btnClearAllPowers = value;
        if (_btnClearAllPowers == null)
          return;
        _btnClearAllPowers.Click += new EventHandler(btnClearAllPowers_Click);
      }
    get => _btnClearAllPowers;
  }

  internal virtual Button btnSelectAllPowers
  {
    get => _btnSelectAllPowers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnSelectAllPowers != null)
          _btnSelectAllPowers.Click -= new EventHandler(btnSelectAllPowers_Click);
        _btnSelectAllPowers = value;
        if (_btnSelectAllPowers == null)
          return;
        _btnSelectAllPowers.Click += new EventHandler(btnSelectAllPowers_Click);
      }
  }

  internal virtual Button btnInventory
  {
    get => _btnInventory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnInventory != null)
          _btnInventory.Click -= new EventHandler(btnInventory_Click);
        _btnInventory = value;
        if (_btnInventory == null)
          return;
        _btnInventory.Click += new EventHandler(btnInventory_Click);
      }
  }

  internal virtual GroupBox GroupBox19
  {
    get => _GroupBox19;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox19 == null)
          ;
        _GroupBox19 = value;
        if (_GroupBox19 == null)
          ;
      }
  }

  internal virtual TextBox tbForcePowerSummary
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbForcePowerSummary == null)
          ;
        _tbForcePowerSummary = value;
        if (_tbForcePowerSummary == null)
          ;
      }
    get => _tbForcePowerSummary;
  }

  internal virtual GroupBox GroupBox20
  {
    get => _GroupBox20;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox20 == null)
          ;
        _GroupBox20 = value;
        if (_GroupBox20 == null)
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

  internal virtual ComboBox cmbxBodyBag
  {
    get => _cmbxBodyBag;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxBodyBag == null)
          ;
        _cmbxBodyBag = value;
        if (_cmbxBodyBag == null)
          ;
      }
  }

  internal virtual Label Label53
  {
    get => _Label53;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label53 == null)
          ;
        _Label53 = value;
        if (_Label53 == null)
          ;
      }
  }

  internal virtual CheckBox chkbIsHologram
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbIsHologram == null)
          ;
        _chkbIsHologram = value;
        if (_chkbIsHologram == null)
          ;
      }
    get => _chkbIsHologram;
  }

  internal virtual CheckBox chkbNotReorienting
  {
    get => _chkbNotReorienting;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbNotReorienting == null)
          ;
        _chkbNotReorienting = value;
        if (_chkbNotReorienting == null)
          ;
      }
  }

  internal virtual CheckBox chkbIgnoreCrePath
  {
    get => _chkbIgnoreCrePath;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbIgnoreCrePath == null)
          ;
        _chkbIgnoreCrePath = value;
        if (_chkbIgnoreCrePath == null)
          ;
      }
  }

  internal virtual NumericUpDown nudMultiplierSet
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudMultiplierSet == null)
          ;
        _nudMultiplierSet = value;
        if (_nudMultiplierSet == null)
          ;
      }
    get => _nudMultiplierSet;
  }

  internal virtual Label lblMultiplierSet
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblMultiplierSet == null)
          ;
        _lblMultiplierSet = value;
        if (_lblMultiplierSet == null)
          ;
      }
    get => _lblMultiplierSet;
  }

  internal virtual Label lblBlindSpot
  {
    get => _lblBlindSpot;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblBlindSpot == null)
          ;
        _lblBlindSpot = value;
        if (_lblBlindSpot == null)
          ;
      }
  }

  internal virtual NumericUpDown nudBlindSpot
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudBlindSpot == null)
          ;
        _nudBlindSpot = value;
        if (_nudBlindSpot == null)
          ;
      }
    get => _nudBlindSpot;
  }

  internal virtual CheckBox chkbMin1HP
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbMin1HP == null)
          ;
        _chkbMin1HP = value;
        if (_chkbMin1HP == null)
          ;
      }
    get => _chkbMin1HP;
  }

  internal virtual ComboBox cmbxFaction
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_cmbxFaction == null)
          ;
        _cmbxFaction = value;
        if (_cmbxFaction == null)
          ;
      }
    get => _cmbxFaction;
  }

  internal virtual CheckBox chkbIsPC
  {
    get => _chkbIsPC;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbIsPC == null)
          ;
        _chkbIsPC = value;
        if (_chkbIsPC == null)
          ;
      }
  }

  internal virtual Button btnEditOnEndDialogu
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnEndDialogu != null)
          _btnEditOnEndDialogu.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnEndDialogu = value;
        if (_btnEditOnEndDialogu == null)
          return;
        _btnEditOnEndDialogu.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnEndDialogu;
  }

  internal virtual Button btnEditOnDialogue
  {
    get => _btnEditOnDialogue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDialogue != null)
          _btnEditOnDialogue.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDialogue = value;
        if (_btnEditOnDialogue == null)
          return;
        _btnEditOnDialogue.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnUserDefine
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnUserDefine != null)
          _btnEditOnUserDefine.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnUserDefine = value;
        if (_btnEditOnUserDefine == null)
          return;
        _btnEditOnUserDefine.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnUserDefine;
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

  internal virtual Button btnEditOnDisturbed
  {
    get => _btnEditOnDisturbed;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnDisturbed != null)
          _btnEditOnDisturbed.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnDisturbed = value;
        if (_btnEditOnDisturbed == null)
          return;
        _btnEditOnDisturbed.Click += new EventHandler(btnEditScript_Click);
      }
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

  internal virtual Button btnEditOnAttacked
  {
    get => _btnEditOnAttacked;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnAttacked != null)
          _btnEditOnAttacked.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnAttacked = value;
        if (_btnEditOnAttacked == null)
          return;
        _btnEditOnAttacked.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnNotice
  {
    get => _btnEditOnNotice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnNotice != null)
          _btnEditOnNotice.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnNotice = value;
        if (_btnEditOnNotice == null)
          return;
        _btnEditOnNotice.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnSpellAt
  {
    get => _btnEditOnSpellAt;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnSpellAt != null)
          _btnEditOnSpellAt.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnSpellAt = value;
        if (_btnEditOnSpellAt == null)
          return;
        _btnEditOnSpellAt.Click += new EventHandler(btnEditScript_Click);
      }
  }

  internal virtual Button btnEditOnSpawn
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnSpawn != null)
          _btnEditOnSpawn.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnSpawn = value;
        if (_btnEditOnSpawn == null)
          return;
        _btnEditOnSpawn.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnSpawn;
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

  internal virtual Button btnEditOnBlocked
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnBlocked != null)
          _btnEditOnBlocked.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnBlocked = value;
        if (_btnEditOnBlocked == null)
          return;
        _btnEditOnBlocked.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnBlocked;
  }

  internal virtual Button btnEditOnRested
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnRested != null)
          _btnEditOnRested.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnRested = value;
        if (_btnEditOnRested == null)
          return;
        _btnEditOnRested.Click += new EventHandler(btnEditScript_Click);
      }
    get => _btnEditOnRested;
  }

  internal virtual Button btnEditOnEndRound
  {
    get => _btnEditOnEndRound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnEditOnEndRound != null)
          _btnEditOnEndRound.Click -= new EventHandler(btnEditScript_Click);
        _btnEditOnEndRound = value;
        if (_btnEditOnEndRound == null)
          return;
        _btnEditOnEndRound.Click += new EventHandler(btnEditScript_Click);
      }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      ResourceManager resourceManager = new ResourceManager(typeof (frmUTC_Editor));
      tabCtrl1 = new TabControl();
      tpBasic = new TabPage();
      GroupBox3 = new GroupBox();
      chkbNotInterruptable = new CheckBox();
      tbConversation = new TextBox();
      GroupBox2 = new GroupBox();
      cmbxPortrait = new ComboBox();
      GroupBox1 = new GroupBox();
      cmbxRace = new ComboBox();
      tbFirstName = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      Label5 = new Label();
      Label6 = new Label();
      Label7 = new Label();
      Label9 = new Label();
      tbLastName = new TextBox();
      tbTag = new TextBox();
      tbDescription = new TextBox();
      cmbxAppearance = new ComboBox();
      cmbxPhenotype = new ComboBox();
      cmbxGender = new ComboBox();
      cmbxBodyBag = new ComboBox();
      Label53 = new Label();
      tpStatistics = new TabPage();
      GroupBox7 = new GroupBox();
      cmbxMovementRate = new ComboBox();
      Label18 = new Label();
      gb2 = new GroupBox();
      Label19 = new Label();
      Label20 = new Label();
      Label21 = new Label();
      nudWillBonus = new NumericUpDown();
      nudFortBonus = new NumericUpDown();
      nudRefBonus = new NumericUpDown();
      Label22 = new Label();
      GroupBox4 = new GroupBox();
      nudStrength = new NumericUpDown();
      Label14 = new Label();
      Label10 = new Label();
      Label11 = new Label();
      Label13 = new Label();
      Label8 = new Label();
      Label12 = new Label();
      Label15 = new Label();
      nudDexterity = new NumericUpDown();
      nudConstitution = new NumericUpDown();
      nudIntelligence = new NumericUpDown();
      nudWisdom = new NumericUpDown();
      nudCharisma = new NumericUpDown();
      GroupBox6 = new GroupBox();
      Label16 = new Label();
      nudNaturalAC = new NumericUpDown();
      GroupBox5 = new GroupBox();
      Label17 = new Label();
      nudBaseHP = new NumericUpDown();
      Label49 = new Label();
      nudCurrentHP = new NumericUpDown();
      nudMaxHP = new NumericUpDown();
      Label50 = new Label();
      tpSkills = new TabPage();
      nudComputerUse = new NumericUpDown();
      Label24 = new Label();
      Label25 = new Label();
      Label26 = new Label();
      Label27 = new Label();
      Label28 = new Label();
      Label29 = new Label();
      nudDemolitions = new NumericUpDown();
      nudStealth = new NumericUpDown();
      nudAwareness = new NumericUpDown();
      nudPersuade = new NumericUpDown();
      nudRepair = new NumericUpDown();
      Label30 = new Label();
      nudSecurity = new NumericUpDown();
      nudTreatInjury = new NumericUpDown();
      Label31 = new Label();
      tpAdvanced = new TabPage();
      GroupBox12 = new GroupBox();
      tbChallengeRating = new TextBox();
      GroupBox11 = new GroupBox();
      nudMultiplierSet = new NumericUpDown();
      Label51 = new Label();
      chkbDisarmable = new CheckBox();
      chkbPlot = new CheckBox();
      chkbNoPermDeath = new CheckBox();
      Label52 = new Label();
      tbDeity = new TextBox();
      chkbIsPC = new CheckBox();
      cmbxSubrace = new ComboBox();
      chkbIsHologram = new CheckBox();
      chkbNotReorienting = new CheckBox();
      chkbIgnoreCrePath = new CheckBox();
      lblMultiplierSet = new Label();
      lblBlindSpot = new Label();
      nudBlindSpot = new NumericUpDown();
      chkbMin1HP = new CheckBox();
      GroupBox13 = new GroupBox();
      cmbxSoundSet = new ComboBox();
      GroupBox14 = new GroupBox();
      cmbxPerceptionRange = new ComboBox();
      GroupBox15 = new GroupBox();
      cmbxFaction = new ComboBox();
      GroupBox18 = new GroupBox();
      tbTemplateResRef = new TextBox();
      Label56 = new Label();
      Label57 = new Label();
      cmbxTreasureModel = new ComboBox();
      tpFeats = new TabPage();
      GroupBox10 = new GroupBox();
      tbFeatSummary = new TextBox();
      chklbFeats = new CheckedListBox();
      toForcePowers = new TabPage();
      GroupBox19 = new GroupBox();
      tbForcePowerSummary = new TextBox();
      GroupBox17 = new GroupBox();
      chklbForcePowers = new CheckedListBox();
      btnSelectAllPowers = new Button();
      btnClearAllPowers = new Button();
      GroupBox16 = new GroupBox();
      nudForcePoints = new NumericUpDown();
      Label54 = new Label();
      Label55 = new Label();
      nudCurrentForce = new NumericUpDown();
      tpClasses = new TabPage();
      GroupBox9 = new GroupBox();
      Label46 = new Label();
      nudClassLevel = new NumericUpDown();
      cmbxClass = new ComboBox();
      Label23 = new Label();
      GroupBox8 = new GroupBox();
      nudAlignment = new NumericUpDown();
      Label47 = new Label();
      trkbarAlignment = new TrackBar();
      Label48 = new Label();
      tpSpecialAbilities = new TabPage();
      GroupBox20 = new GroupBox();
      chklbSpecialAbilities = new CheckedListBox();
      tpScripts = new TabPage();
      btnEditOnEndDialogu = new Button();
      btnEditOnDialogue = new Button();
      btnEditOnUserDefine = new Button();
      btnEditOnHeartbeat = new Button();
      btnEditOnDisturbed = new Button();
      btnEditOnDamaged = new Button();
      btnEditOnAttacked = new Button();
      Label34 = new Label();
      tbOnSpellAt = new TextBox();
      Label33 = new Label();
      tbOnNotice = new TextBox();
      Label32 = new Label();
      tbOnHeartbeat = new TextBox();
      Label35 = new Label();
      tbOnAttacked = new TextBox();
      tbOnDamaged = new TextBox();
      Label36 = new Label();
      Label37 = new Label();
      tbOnDisturbed = new TextBox();
      tbOnEndRound = new TextBox();
      Label38 = new Label();
      tbOnEndDialogu = new TextBox();
      Label39 = new Label();
      Label40 = new Label();
      tbOnDialogue = new TextBox();
      Label41 = new Label();
      tbOnSpawn = new TextBox();
      tbOnRested = new TextBox();
      Label42 = new Label();
      tbOnDeath = new TextBox();
      Label43 = new Label();
      Label44 = new Label();
      tbOnBlocked = new TextBox();
      tbOnUserDefine = new TextBox();
      Label45 = new Label();
      btnEditOnNotice = new Button();
      btnEditOnSpellAt = new Button();
      btnEditOnSpawn = new Button();
      btnEditOnDeath = new Button();
      btnEditOnBlocked = new Button();
      btnEditOnRested = new Button();
      btnEditOnEndRound = new Button();
      tpComments = new TabPage();
      tbComments = new TextBox();
      btnCancel = new Button();
      btnWriteFile = new Button();
      btnInventory = new Button();
      btnDebug = new Button();
      tabCtrl1.SuspendLayout();
      tpBasic.SuspendLayout();
      GroupBox3.SuspendLayout();
      GroupBox2.SuspendLayout();
      GroupBox1.SuspendLayout();
      tpStatistics.SuspendLayout();
      GroupBox7.SuspendLayout();
      gb2.SuspendLayout();
      nudWillBonus.BeginInit();
      nudFortBonus.BeginInit();
      nudRefBonus.BeginInit();
      GroupBox4.SuspendLayout();
      nudStrength.BeginInit();
      nudDexterity.BeginInit();
      nudConstitution.BeginInit();
      nudIntelligence.BeginInit();
      nudWisdom.BeginInit();
      nudCharisma.BeginInit();
      GroupBox6.SuspendLayout();
      nudNaturalAC.BeginInit();
      GroupBox5.SuspendLayout();
      nudBaseHP.BeginInit();
      nudCurrentHP.BeginInit();
      nudMaxHP.BeginInit();
      tpSkills.SuspendLayout();
      nudComputerUse.BeginInit();
      nudDemolitions.BeginInit();
      nudStealth.BeginInit();
      nudAwareness.BeginInit();
      nudPersuade.BeginInit();
      nudRepair.BeginInit();
      nudSecurity.BeginInit();
      nudTreatInjury.BeginInit();
      tpAdvanced.SuspendLayout();
      GroupBox12.SuspendLayout();
      GroupBox11.SuspendLayout();
      nudMultiplierSet.BeginInit();
      nudBlindSpot.BeginInit();
      GroupBox13.SuspendLayout();
      GroupBox14.SuspendLayout();
      GroupBox15.SuspendLayout();
      GroupBox18.SuspendLayout();
      tpFeats.SuspendLayout();
      GroupBox10.SuspendLayout();
      toForcePowers.SuspendLayout();
      GroupBox19.SuspendLayout();
      GroupBox17.SuspendLayout();
      GroupBox16.SuspendLayout();
      nudForcePoints.BeginInit();
      nudCurrentForce.BeginInit();
      tpClasses.SuspendLayout();
      GroupBox9.SuspendLayout();
      nudClassLevel.BeginInit();
      GroupBox8.SuspendLayout();
      nudAlignment.BeginInit();
      trkbarAlignment.BeginInit();
      tpSpecialAbilities.SuspendLayout();
      GroupBox20.SuspendLayout();
      tpScripts.SuspendLayout();
      tpComments.SuspendLayout();
      SuspendLayout();
      tabCtrl1.Controls.Add(tpBasic);
      tabCtrl1.Controls.Add(tpStatistics);
      tabCtrl1.Controls.Add(tpSkills);
      tabCtrl1.Controls.Add(tpAdvanced);
      tabCtrl1.Controls.Add(tpFeats);
      tabCtrl1.Controls.Add(toForcePowers);
      tabCtrl1.Controls.Add(tpClasses);
      tabCtrl1.Controls.Add(tpSpecialAbilities);
      tabCtrl1.Controls.Add(tpScripts);
      tabCtrl1.Controls.Add(tpComments);
      TabControl tabCtrl1_1 = tabCtrl1;
      Point point1 = new Point(8, 32);
      Point point2 = point1;
      tabCtrl1_1.Location = point2;
      tabCtrl1.Multiline = true;
      tabCtrl1.Name = "tabCtrl1";
      TabControl tabCtrl1_2 = tabCtrl1;
      point1 = new Point(14, 3);
      Point point3 = point1;
      tabCtrl1_2.Padding = point3;
      tabCtrl1.SelectedIndex = 0;
      TabControl tabCtrl1_3 = tabCtrl1;
      Size size1 = new Size(416, 536);
      Size size2 = size1;
      tabCtrl1_3.Size = size2;
      tabCtrl1.SizeMode = TabSizeMode.FillToRight;
      tabCtrl1.TabIndex = 0;
      tpBasic.Controls.Add(GroupBox3);
      tpBasic.Controls.Add(GroupBox2);
      tpBasic.Controls.Add(GroupBox1);
      TabPage tpBasic1 = tpBasic;
      point1 = new Point(4, 40);
      Point point4 = point1;
      ((Control) tpBasic1).Location = point4;
      tpBasic.Name = "tpBasic";
      TabPage tpBasic2 = tpBasic;
      size1 = new Size(408, 492);
      Size size3 = size1;
      tpBasic2.Size = size3;
      tpBasic.TabIndex = 0;
      tpBasic.Text = "Basic";
      GroupBox3.Controls.Add(chkbNotInterruptable);
      GroupBox3.Controls.Add(tbConversation);
      GroupBox groupBox3_1 = GroupBox3;
      point1 = new Point(8, 432);
      Point point5 = point1;
      groupBox3_1.Location = point5;
      GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = GroupBox3;
      size1 = new Size(392, 56);
      Size size4 = size1;
      groupBox3_2.Size = size4;
      GroupBox3.TabIndex = 2;
      GroupBox3.TabStop = false;
      GroupBox3.Text = "Conversation";
      CheckBox notInterruptable1 = chkbNotInterruptable;
      point1 = new Point(300, 24);
      Point point6 = point1;
      notInterruptable1.Location = point6;
      chkbNotInterruptable.Name = "chkbNotInterruptable";
      CheckBox notInterruptable2 = chkbNotInterruptable;
      size1 = new Size(84, 24);
      Size size5 = size1;
      notInterruptable2.Size = size5;
      chkbNotInterruptable.TabIndex = 1;
      chkbNotInterruptable.Text = "No Interrupt";
      TextBox tbConversation1 = tbConversation;
      point1 = new Point(24, 24);
      Point point7 = point1;
      tbConversation1.Location = point7;
      tbConversation.Name = "tbConversation";
      TextBox tbConversation2 = tbConversation;
      size1 = new Size(168, 20);
      Size size6 = size1;
      tbConversation2.Size = size6;
      tbConversation.TabIndex = 0;
      tbConversation.Text = "";
      GroupBox2.Controls.Add(cmbxPortrait);
      GroupBox groupBox2_1 = GroupBox2;
      point1 = new Point(8, 312);
      Point point8 = point1;
      groupBox2_1.Location = point8;
      GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = GroupBox2;
      size1 = new Size(392, 120);
      Size size7 = size1;
      groupBox2_2.Size = size7;
      GroupBox2.TabIndex = 1;
      GroupBox2.TabStop = false;
      GroupBox2.Text = "Portrait";
      cmbxPortrait.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxPortrait1 = cmbxPortrait;
      point1 = new Point(174, 54);
      Point point9 = point1;
      cmbxPortrait1.Location = point9;
      cmbxPortrait.Name = "cmbxPortrait";
      ComboBox cmbxPortrait2 = cmbxPortrait;
      size1 = new Size(184, 21);
      Size size8 = size1;
      cmbxPortrait2.Size = size8;
      cmbxPortrait.TabIndex = 0;
      GroupBox1.Controls.Add(cmbxRace);
      GroupBox1.Controls.Add(tbFirstName);
      GroupBox1.Controls.Add(Label1);
      GroupBox1.Controls.Add(Label2);
      GroupBox1.Controls.Add(Label3);
      GroupBox1.Controls.Add(Label4);
      GroupBox1.Controls.Add(Label5);
      GroupBox1.Controls.Add(Label6);
      GroupBox1.Controls.Add(Label7);
      GroupBox1.Controls.Add(Label9);
      GroupBox1.Controls.Add(tbLastName);
      GroupBox1.Controls.Add(tbTag);
      GroupBox1.Controls.Add(tbDescription);
      GroupBox1.Controls.Add(cmbxAppearance);
      GroupBox1.Controls.Add(cmbxPhenotype);
      GroupBox1.Controls.Add(cmbxGender);
      GroupBox1.Controls.Add(cmbxBodyBag);
      GroupBox1.Controls.Add(Label53);
      GroupBox groupBox1_1 = GroupBox1;
      point1 = new Point(8, 8);
      Point point10 = point1;
      groupBox1_1.Location = point10;
      GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = GroupBox1;
      size1 = new Size(392, 304);
      Size size9 = size1;
      groupBox1_2.Size = size9;
      GroupBox1.TabIndex = 0;
      GroupBox1.TabStop = false;
      GroupBox1.Text = "Profile";
      cmbxRace.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxRace1 = cmbxRace;
      point1 = new Point(104, 104);
      Point point11 = point1;
      cmbxRace1.Location = point11;
      cmbxRace.Name = "cmbxRace";
      ComboBox cmbxRace2 = cmbxRace;
      size1 = new Size(184, 21);
      Size size10 = size1;
      cmbxRace2.Size = size10;
      cmbxRace.TabIndex = 3;
      TextBox tbFirstName1 = tbFirstName;
      point1 = new Point(104, 20);
      Point point12 = point1;
      tbFirstName1.Location = point12;
      tbFirstName.Name = "tbFirstName";
      TextBox tbFirstName2 = tbFirstName;
      size1 = new Size(184, 20);
      Size size11 = size1;
      tbFirstName2.Size = size11;
      tbFirstName.TabIndex = 0;
      tbFirstName.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(16, 22);
      Point point13 = point1;
      label1_1.Location = point13;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(80, 16);
      Size size12 = size1;
      label1_2.Size = size12;
      Label1.TabIndex = 0;
      Label1.Text = "First Name:";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      Label label2_1 = Label2;
      point1 = new Point(16, 50);
      Point point14 = point1;
      label2_1.Location = point14;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(80, 16);
      Size size13 = size1;
      label2_2.Size = size13;
      Label2.TabIndex = 0;
      Label2.Text = "Last Name:";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      Label label3_1 = Label3;
      point1 = new Point(16, 78);
      Point point15 = point1;
      label3_1.Location = point15;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(80, 16);
      Size size14 = size1;
      label3_2.Size = size14;
      Label3.TabIndex = 0;
      Label3.Text = "Tag";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      Label label4_1 = Label4;
      point1 = new Point(16, 106);
      Point point16 = point1;
      label4_1.Location = point16;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(80, 16);
      Size size15 = size1;
      label4_2.Size = size15;
      Label4.TabIndex = 0;
      Label4.Text = "Race";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      Label label5_1 = Label5;
      point1 = new Point(16, 138);
      Point point17 = point1;
      label5_1.Location = point17;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(80, 16);
      Size size16 = size1;
      label5_2.Size = size16;
      Label5.TabIndex = 0;
      Label5.Text = "Appearance";
      Label5.TextAlign = ContentAlignment.MiddleLeft;
      Label label6_1 = Label6;
      point1 = new Point(16, 170);
      Point point18 = point1;
      label6_1.Location = point18;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(80, 16);
      Size size17 = size1;
      label6_2.Size = size17;
      Label6.TabIndex = 0;
      Label6.Text = "Phenotype";
      Label6.TextAlign = ContentAlignment.MiddleLeft;
      Label label7_1 = Label7;
      point1 = new Point(16, 234);
      Point point19 = point1;
      label7_1.Location = point19;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(80, 16);
      Size size18 = size1;
      label7_2.Size = size18;
      Label7.TabIndex = 0;
      Label7.Text = "Description";
      Label7.TextAlign = ContentAlignment.MiddleLeft;
      Label label9_1 = Label9;
      point1 = new Point(16, 202);
      Point point20 = point1;
      label9_1.Location = point20;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(80, 16);
      Size size19 = size1;
      label9_2.Size = size19;
      Label9.TabIndex = 0;
      Label9.Text = "Gender";
      Label9.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbLastName1 = tbLastName;
      point1 = new Point(104, 48);
      Point point21 = point1;
      tbLastName1.Location = point21;
      tbLastName.Name = "tbLastName";
      tbLastName.ReadOnly = true;
      TextBox tbLastName2 = tbLastName;
      size1 = new Size(184, 20);
      Size size20 = size1;
      tbLastName2.Size = size20;
      tbLastName.TabIndex = 1;
      tbLastName.Text = "";
      TextBox tbTag1 = tbTag;
      point1 = new Point(104, 76);
      Point point22 = point1;
      tbTag1.Location = point22;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(184, 20);
      Size size21 = size1;
      tbTag2.Size = size21;
      tbTag.TabIndex = 2;
      tbTag.Text = "";
      TextBox tbDescription1 = tbDescription;
      point1 = new Point(104, 232);
      Point point23 = point1;
      tbDescription1.Location = point23;
      tbDescription.Name = "tbDescription";
      TextBox tbDescription2 = tbDescription;
      size1 = new Size(184, 20);
      Size size22 = size1;
      tbDescription2.Size = size22;
      tbDescription.TabIndex = 7;
      tbDescription.Text = "";
      cmbxAppearance.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxAppearance1 = cmbxAppearance;
      point1 = new Point(104, 136);
      Point point24 = point1;
      cmbxAppearance1.Location = point24;
      cmbxAppearance.Name = "cmbxAppearance";
      ComboBox cmbxAppearance2 = cmbxAppearance;
      size1 = new Size(184, 21);
      Size size23 = size1;
      cmbxAppearance2.Size = size23;
      cmbxAppearance.TabIndex = 4;
      cmbxPhenotype.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxPhenotype1 = cmbxPhenotype;
      point1 = new Point(104, 168);
      Point point25 = point1;
      cmbxPhenotype1.Location = point25;
      cmbxPhenotype.Name = "cmbxPhenotype";
      ComboBox cmbxPhenotype2 = cmbxPhenotype;
      size1 = new Size(184, 21);
      Size size24 = size1;
      cmbxPhenotype2.Size = size24;
      cmbxPhenotype.TabIndex = 5;
      cmbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxGender1 = cmbxGender;
      point1 = new Point(104, 200);
      Point point26 = point1;
      cmbxGender1.Location = point26;
      cmbxGender.Name = "cmbxGender";
      ComboBox cmbxGender2 = cmbxGender;
      size1 = new Size(184, 21);
      Size size25 = size1;
      cmbxGender2.Size = size25;
      cmbxGender.TabIndex = 6;
      cmbxBodyBag.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxBodyBag1 = cmbxBodyBag;
      point1 = new Point(104, 268);
      Point point27 = point1;
      cmbxBodyBag1.Location = point27;
      cmbxBodyBag.Name = "cmbxBodyBag";
      ComboBox cmbxBodyBag2 = cmbxBodyBag;
      size1 = new Size(184, 21);
      Size size26 = size1;
      cmbxBodyBag2.Size = size26;
      cmbxBodyBag.TabIndex = 4;
      Label label53_1 = Label53;
      point1 = new Point(16, 270);
      Point point28 = point1;
      label53_1.Location = point28;
      Label53.Name = "Label53";
      Label label53_2 = Label53;
      size1 = new Size(80, 16);
      Size size27 = size1;
      label53_2.Size = size27;
      Label53.TabIndex = 0;
      Label53.Text = "BodyBag";
      Label53.TextAlign = ContentAlignment.MiddleLeft;
      tpStatistics.Controls.Add(GroupBox7);
      tpStatistics.Controls.Add(gb2);
      tpStatistics.Controls.Add(GroupBox4);
      tpStatistics.Controls.Add(GroupBox6);
      tpStatistics.Controls.Add(GroupBox5);
      TabPage tpStatistics1 = tpStatistics;
      point1 = new Point(4, 40);
      Point point29 = point1;
      ((Control) tpStatistics1).Location = point29;
      tpStatistics.Name = "tpStatistics";
      TabPage tpStatistics2 = tpStatistics;
      size1 = new Size(408, 492);
      Size size28 = size1;
      tpStatistics2.Size = size28;
      tpStatistics.TabIndex = 1;
      tpStatistics.Text = "Statistics";
      GroupBox7.Controls.Add(cmbxMovementRate);
      GroupBox7.Controls.Add(Label18);
      GroupBox groupBox7_1 = GroupBox7;
      point1 = new Point(210, 432);
      Point point30 = point1;
      groupBox7_1.Location = point30;
      GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = GroupBox7;
      size1 = new Size(192, 48);
      Size size29 = size1;
      groupBox7_2.Size = size29;
      GroupBox7.TabIndex = 3;
      GroupBox7.TabStop = false;
      GroupBox7.Text = "Speed";
      cmbxMovementRate.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxMovementRate1 = cmbxMovementRate;
      point1 = new Point(102, 18);
      Point point31 = point1;
      cmbxMovementRate1.Location = point31;
      cmbxMovementRate.Name = "cmbxMovementRate";
      ComboBox cmbxMovementRate2 = cmbxMovementRate;
      size1 = new Size(72, 21);
      Size size30 = size1;
      cmbxMovementRate2.Size = size30;
      cmbxMovementRate.TabIndex = 0;
      Label label18_1 = Label18;
      point1 = new Point(12, 20);
      Point point32 = point1;
      label18_1.Location = point32;
      Label18.Name = "Label18";
      Label label18_2 = Label18;
      size1 = new Size(84, 18);
      Size size31 = size1;
      label18_2.Size = size31;
      Label18.TabIndex = 1;
      Label18.Text = "Movement Rate";
      Label18.TextAlign = ContentAlignment.MiddleLeft;
      gb2.Controls.Add(Label19);
      gb2.Controls.Add(Label20);
      gb2.Controls.Add(Label21);
      gb2.Controls.Add(nudWillBonus);
      gb2.Controls.Add(nudFortBonus);
      gb2.Controls.Add(nudRefBonus);
      gb2.Controls.Add(Label22);
      GroupBox gb2_1 = gb2;
      point1 = new Point(6, 210);
      Point point33 = point1;
      gb2_1.Location = point33;
      gb2.Name = "gb2";
      GroupBox gb2_2 = gb2;
      size1 = new Size(396, 108);
      Size size32 = size1;
      gb2_2.Size = size32;
      gb2.TabIndex = 2;
      gb2.TabStop = false;
      gb2.Text = "Saves";
      Label label19_1 = Label19;
      point1 = new Point(32, 59);
      Point point34 = point1;
      label19_1.Location = point34;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(66, 18);
      Size size33 = size1;
      label19_2.Size = size33;
      Label19.TabIndex = 0;
      Label19.Text = "Reflex";
      Label19.TextAlign = ContentAlignment.MiddleLeft;
      Label label20_1 = Label20;
      point1 = new Point(32, 83);
      Point point35 = point1;
      label20_1.Location = point35;
      Label20.Name = "Label20";
      Label label20_2 = Label20;
      size1 = new Size(66, 18);
      Size size34 = size1;
      label20_2.Size = size34;
      Label20.TabIndex = 0;
      Label20.Text = "Will";
      Label20.TextAlign = ContentAlignment.MiddleLeft;
      Label label21_1 = Label21;
      point1 = new Point(32, 35);
      Point point36 = point1;
      label21_1.Location = point36;
      Label21.Name = "Label21";
      Label label21_2 = Label21;
      size1 = new Size(66, 18);
      Size size35 = size1;
      label21_2.Size = size35;
      Label21.TabIndex = 0;
      Label21.Text = "Fortitude";
      Label21.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudWillBonus1 = nudWillBonus;
      point1 = new Point(126, 83);
      Point point37 = point1;
      nudWillBonus1.Location = point37;
      NumericUpDown nudWillBonus2 = nudWillBonus;
      Decimal num1 = new Decimal(new int[4]
      {
        250,
        0,
        0,
        0
      });
      Decimal num2 = num1;
      nudWillBonus2.Maximum = num2;
      nudWillBonus.Name = "nudWillBonus";
      NumericUpDown nudWillBonus3 = nudWillBonus;
      size1 = new Size(42, 20);
      Size size36 = size1;
      nudWillBonus3.Size = size36;
      nudWillBonus.TabIndex = 2;
      nudWillBonus.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudFortBonus1 = nudFortBonus;
      point1 = new Point(126, 35);
      Point point38 = point1;
      nudFortBonus1.Location = point38;
      NumericUpDown nudFortBonus2 = nudFortBonus;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num3 = num1;
      nudFortBonus2.Maximum = num3;
      nudFortBonus.Name = "nudFortBonus";
      NumericUpDown nudFortBonus3 = nudFortBonus;
      size1 = new Size(42, 20);
      Size size37 = size1;
      nudFortBonus3.Size = size37;
      nudFortBonus.TabIndex = 0;
      nudFortBonus.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudRefBonus1 = nudRefBonus;
      point1 = new Point(126, 59);
      Point point39 = point1;
      nudRefBonus1.Location = point39;
      NumericUpDown nudRefBonus2 = nudRefBonus;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num4 = num1;
      nudRefBonus2.Maximum = num4;
      nudRefBonus.Name = "nudRefBonus";
      NumericUpDown nudRefBonus3 = nudRefBonus;
      size1 = new Size(42, 20);
      Size size38 = size1;
      nudRefBonus3.Size = size38;
      nudRefBonus.TabIndex = 1;
      nudRefBonus.TextAlign = HorizontalAlignment.Right;
      Label label22_1 = Label22;
      point1 = new Point(126, 16);
      Point point40 = point1;
      label22_1.Location = point40;
      Label22.Name = "Label22";
      Label label22_2 = Label22;
      size1 = new Size(66, 18);
      Size size39 = size1;
      label22_2.Size = size39;
      Label22.TabIndex = 0;
      Label22.Text = "Bonus";
      Label22.TextAlign = ContentAlignment.MiddleLeft;
      GroupBox4.Controls.Add(nudStrength);
      GroupBox4.Controls.Add(Label14);
      GroupBox4.Controls.Add(Label10);
      GroupBox4.Controls.Add(Label11);
      GroupBox4.Controls.Add(Label13);
      GroupBox4.Controls.Add(Label8);
      GroupBox4.Controls.Add(Label12);
      GroupBox4.Controls.Add(Label15);
      GroupBox4.Controls.Add(nudDexterity);
      GroupBox4.Controls.Add(nudConstitution);
      GroupBox4.Controls.Add(nudIntelligence);
      GroupBox4.Controls.Add(nudWisdom);
      GroupBox4.Controls.Add(nudCharisma);
      GroupBox groupBox4_1 = GroupBox4;
      point1 = new Point(6, 12);
      Point point41 = point1;
      groupBox4_1.Location = point41;
      GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = GroupBox4;
      size1 = new Size(396, 186);
      Size size40 = size1;
      groupBox4_2.Size = size40;
      GroupBox4.TabIndex = 1;
      GroupBox4.TabStop = false;
      GroupBox4.Text = "Ability Score";
      NumericUpDown nudStrength1 = nudStrength;
      point1 = new Point(126, 30);
      Point point42 = point1;
      nudStrength1.Location = point42;
      NumericUpDown nudStrength2 = nudStrength;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num5 = num1;
      nudStrength2.Minimum = num5;
      nudStrength.Name = "nudStrength";
      NumericUpDown nudStrength3 = nudStrength;
      size1 = new Size(42, 20);
      Size size41 = size1;
      nudStrength3.Size = size41;
      nudStrength.TabIndex = 0;
      nudStrength.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudStrength4 = nudStrength;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num6 = num1;
      nudStrength4.Value = num6;
      Label label14_1 = Label14;
      point1 = new Point(30, 151);
      Point point43 = point1;
      label14_1.Location = point43;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(66, 18);
      Size size42 = size1;
      label14_2.Size = size42;
      Label14.TabIndex = 0;
      Label14.Text = "Charisma";
      Label14.TextAlign = ContentAlignment.MiddleLeft;
      Label label10_1 = Label10;
      point1 = new Point(30, 55);
      Point point44 = point1;
      label10_1.Location = point44;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(66, 18);
      Size size43 = size1;
      label10_2.Size = size43;
      Label10.TabIndex = 0;
      Label10.Text = "Dexterity";
      Label10.TextAlign = ContentAlignment.MiddleLeft;
      Label label11_1 = Label11;
      point1 = new Point(30, 79);
      Point point45 = point1;
      label11_1.Location = point45;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(66, 18);
      Size size44 = size1;
      label11_2.Size = size44;
      Label11.TabIndex = 0;
      Label11.Text = "Constitution";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      Label label13_1 = Label13;
      point1 = new Point(30, sbyte.MaxValue);
      Point point46 = point1;
      label13_1.Location = point46;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(66, 18);
      Size size45 = size1;
      label13_2.Size = size45;
      Label13.TabIndex = 0;
      Label13.Text = "Wisdom";
      Label13.TextAlign = ContentAlignment.MiddleLeft;
      Label label8_1 = Label8;
      point1 = new Point(30, 31);
      Point point47 = point1;
      label8_1.Location = point47;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(66, 18);
      Size size46 = size1;
      label8_2.Size = size46;
      Label8.TabIndex = 0;
      Label8.Text = "Strength";
      Label8.TextAlign = ContentAlignment.MiddleLeft;
      Label label12_1 = Label12;
      point1 = new Point(30, 103);
      Point point48 = point1;
      label12_1.Location = point48;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(66, 18);
      Size size47 = size1;
      label12_2.Size = size47;
      Label12.TabIndex = 0;
      Label12.Text = "Intelligence";
      Label12.TextAlign = ContentAlignment.MiddleLeft;
      Label label15_1 = Label15;
      point1 = new Point(126, 12);
      Point point49 = point1;
      label15_1.Location = point49;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(42, 18);
      Size size48 = size1;
      label15_2.Size = size48;
      Label15.TabIndex = 0;
      Label15.Text = "Score";
      NumericUpDown nudDexterity1 = nudDexterity;
      point1 = new Point(126, 54);
      Point point50 = point1;
      nudDexterity1.Location = point50;
      NumericUpDown nudDexterity2 = nudDexterity;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num7 = num1;
      nudDexterity2.Minimum = num7;
      nudDexterity.Name = "nudDexterity";
      NumericUpDown nudDexterity3 = nudDexterity;
      size1 = new Size(42, 20);
      Size size49 = size1;
      nudDexterity3.Size = size49;
      nudDexterity.TabIndex = 1;
      nudDexterity.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudDexterity4 = nudDexterity;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num8 = num1;
      nudDexterity4.Value = num8;
      NumericUpDown nudConstitution1 = nudConstitution;
      point1 = new Point(126, 78);
      Point point51 = point1;
      nudConstitution1.Location = point51;
      NumericUpDown nudConstitution2 = nudConstitution;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num9 = num1;
      nudConstitution2.Minimum = num9;
      nudConstitution.Name = "nudConstitution";
      NumericUpDown nudConstitution3 = nudConstitution;
      size1 = new Size(42, 20);
      Size size50 = size1;
      nudConstitution3.Size = size50;
      nudConstitution.TabIndex = 2;
      nudConstitution.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudConstitution4 = nudConstitution;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num10 = num1;
      nudConstitution4.Value = num10;
      NumericUpDown nudIntelligence1 = nudIntelligence;
      point1 = new Point(126, 102);
      Point point52 = point1;
      nudIntelligence1.Location = point52;
      NumericUpDown nudIntelligence2 = nudIntelligence;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num11 = num1;
      nudIntelligence2.Minimum = num11;
      nudIntelligence.Name = "nudIntelligence";
      NumericUpDown nudIntelligence3 = nudIntelligence;
      size1 = new Size(42, 20);
      Size size51 = size1;
      nudIntelligence3.Size = size51;
      nudIntelligence.TabIndex = 3;
      nudIntelligence.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudIntelligence4 = nudIntelligence;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num12 = num1;
      nudIntelligence4.Value = num12;
      NumericUpDown nudWisdom1 = nudWisdom;
      point1 = new Point(126, 126);
      Point point53 = point1;
      nudWisdom1.Location = point53;
      NumericUpDown nudWisdom2 = nudWisdom;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num13 = num1;
      nudWisdom2.Minimum = num13;
      nudWisdom.Name = "nudWisdom";
      NumericUpDown nudWisdom3 = nudWisdom;
      size1 = new Size(42, 20);
      Size size52 = size1;
      nudWisdom3.Size = size52;
      nudWisdom.TabIndex = 4;
      nudWisdom.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudWisdom4 = nudWisdom;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num14 = num1;
      nudWisdom4.Value = num14;
      NumericUpDown nudCharisma1 = nudCharisma;
      point1 = new Point(126, 150);
      Point point54 = point1;
      nudCharisma1.Location = point54;
      NumericUpDown nudCharisma2 = nudCharisma;
      num1 = new Decimal(new int[4]{ 3, 0, 0, 0 });
      Decimal num15 = num1;
      nudCharisma2.Minimum = num15;
      nudCharisma.Name = "nudCharisma";
      NumericUpDown nudCharisma3 = nudCharisma;
      size1 = new Size(42, 20);
      Size size53 = size1;
      nudCharisma3.Size = size53;
      nudCharisma.TabIndex = 5;
      nudCharisma.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudCharisma4 = nudCharisma;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num16 = num1;
      nudCharisma4.Value = num16;
      GroupBox6.Controls.Add(Label16);
      GroupBox6.Controls.Add(nudNaturalAC);
      GroupBox groupBox6_1 = GroupBox6;
      point1 = new Point(6, 324);
      Point point55 = point1;
      groupBox6_1.Location = point55;
      GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = GroupBox6;
      size1 = new Size(198, 156);
      Size size54 = size1;
      groupBox6_2.Size = size54;
      GroupBox6.TabIndex = 2;
      GroupBox6.TabStop = false;
      GroupBox6.Text = "Armor Class";
      Label label16_1 = Label16;
      point1 = new Point(8, 25);
      Point point56 = point1;
      label16_1.Location = point56;
      Label16.Name = "Label16";
      Label label16_2 = Label16;
      size1 = new Size(66, 18);
      Size size55 = size1;
      label16_2.Size = size55;
      Label16.TabIndex = 1;
      Label16.Text = "Natural AC";
      Label16.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudNaturalAc1 = nudNaturalAC;
      point1 = new Point(114, 24);
      Point point57 = point1;
      nudNaturalAc1.Location = point57;
      NumericUpDown nudNaturalAc2 = nudNaturalAC;
      num1 = new Decimal(new int[4]{ 1000, 0, 0, 0 });
      Decimal num17 = num1;
      nudNaturalAc2.Maximum = num17;
      nudNaturalAC.Name = "nudNaturalAC";
      NumericUpDown nudNaturalAc3 = nudNaturalAC;
      size1 = new Size(48, 20);
      Size size56 = size1;
      nudNaturalAc3.Size = size56;
      nudNaturalAC.TabIndex = 0;
      nudNaturalAC.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudNaturalAc4 = nudNaturalAC;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num18 = num1;
      nudNaturalAc4.Value = num18;
      GroupBox5.Controls.Add(Label17);
      GroupBox5.Controls.Add(nudBaseHP);
      GroupBox5.Controls.Add(Label49);
      GroupBox5.Controls.Add(nudCurrentHP);
      GroupBox5.Controls.Add(nudMaxHP);
      GroupBox5.Controls.Add(Label50);
      GroupBox groupBox5_1 = GroupBox5;
      point1 = new Point(210, 324);
      Point point58 = point1;
      groupBox5_1.Location = point58;
      GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = GroupBox5;
      size1 = new Size(192, 108);
      Size size57 = size1;
      groupBox5_2.Size = size57;
      GroupBox5.TabIndex = 2;
      GroupBox5.TabStop = false;
      GroupBox5.Text = "Hit Points";
      Label label17_1 = Label17;
      point1 = new Point(19, 24);
      Point point59 = point1;
      label17_1.Location = point59;
      Label17.Name = "Label17";
      Label label17_2 = Label17;
      size1 = new Size(85, 18);
      Size size58 = size1;
      label17_2.Size = size58;
      Label17.TabIndex = 3;
      Label17.Text = "Base Hit Points";
      Label17.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudBaseHp1 = nudBaseHP;
      point1 = new Point(125, 24);
      Point point60 = point1;
      nudBaseHp1.Location = point60;
      NumericUpDown nudBaseHp2 = nudBaseHP;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num19 = num1;
      nudBaseHp2.Maximum = num19;
      NumericUpDown nudBaseHp3 = nudBaseHP;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num20 = num1;
      nudBaseHp3.Minimum = num20;
      nudBaseHP.Name = "nudBaseHP";
      NumericUpDown nudBaseHp4 = nudBaseHP;
      size1 = new Size(48, 20);
      Size size59 = size1;
      nudBaseHp4.Size = size59;
      nudBaseHP.TabIndex = 0;
      nudBaseHP.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudBaseHp5 = nudBaseHP;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num21 = num1;
      nudBaseHp5.Value = num21;
      Label label49_1 = Label49;
      point1 = new Point(19, 49);
      Point point61 = point1;
      label49_1.Location = point61;
      Label49.Name = "Label49";
      Label label49_2 = Label49;
      size1 = new Size(96, 18);
      Size size60 = size1;
      label49_2.Size = size60;
      Label49.TabIndex = 3;
      Label49.Text = "Current Hit Points";
      Label49.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudCurrentHp1 = nudCurrentHP;
      point1 = new Point(125, 48);
      Point point62 = point1;
      nudCurrentHp1.Location = point62;
      NumericUpDown nudCurrentHp2 = nudCurrentHP;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num22 = num1;
      nudCurrentHp2.Maximum = num22;
      NumericUpDown nudCurrentHp3 = nudCurrentHP;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num23 = num1;
      nudCurrentHp3.Minimum = num23;
      nudCurrentHP.Name = "nudCurrentHP";
      NumericUpDown nudCurrentHp4 = nudCurrentHP;
      size1 = new Size(48, 20);
      Size size61 = size1;
      nudCurrentHp4.Size = size61;
      nudCurrentHP.TabIndex = 1;
      nudCurrentHP.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudCurrentHp5 = nudCurrentHP;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num24 = num1;
      nudCurrentHp5.Value = num24;
      NumericUpDown nudMaxHp1 = nudMaxHP;
      point1 = new Point(125, 72);
      Point point63 = point1;
      nudMaxHp1.Location = point63;
      NumericUpDown nudMaxHp2 = nudMaxHP;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num25 = num1;
      nudMaxHp2.Maximum = num25;
      NumericUpDown nudMaxHp3 = nudMaxHP;
      num1 = new Decimal(new int[4]{ 1, 0, 0, 0 });
      Decimal num26 = num1;
      nudMaxHp3.Minimum = num26;
      nudMaxHP.Name = "nudMaxHP";
      NumericUpDown nudMaxHp4 = nudMaxHP;
      size1 = new Size(48, 20);
      Size size62 = size1;
      nudMaxHp4.Size = size62;
      nudMaxHP.TabIndex = 2;
      nudMaxHP.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudMaxHp5 = nudMaxHP;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num27 = num1;
      nudMaxHp5.Value = num27;
      Label label50_1 = Label50;
      point1 = new Point(19, 73);
      Point point64 = point1;
      label50_1.Location = point64;
      Label50.Name = "Label50";
      Label label50_2 = Label50;
      size1 = new Size(85, 18);
      Size size63 = size1;
      label50_2.Size = size63;
      Label50.TabIndex = 3;
      Label50.Text = "Max Hit Points";
      Label50.TextAlign = ContentAlignment.MiddleLeft;
      tpSkills.Controls.Add(nudComputerUse);
      tpSkills.Controls.Add(Label24);
      tpSkills.Controls.Add(Label25);
      tpSkills.Controls.Add(Label26);
      tpSkills.Controls.Add(Label27);
      tpSkills.Controls.Add(Label28);
      tpSkills.Controls.Add(Label29);
      tpSkills.Controls.Add(nudDemolitions);
      tpSkills.Controls.Add(nudStealth);
      tpSkills.Controls.Add(nudAwareness);
      tpSkills.Controls.Add(nudPersuade);
      tpSkills.Controls.Add(nudRepair);
      tpSkills.Controls.Add(Label30);
      tpSkills.Controls.Add(nudSecurity);
      tpSkills.Controls.Add(nudTreatInjury);
      tpSkills.Controls.Add(Label31);
      TabPage tpSkills1 = tpSkills;
      point1 = new Point(4, 40);
      Point point65 = point1;
      ((Control) tpSkills1).Location = point65;
      tpSkills.Name = "tpSkills";
      TabPage tpSkills2 = tpSkills;
      size1 = new Size(408, 492);
      Size size64 = size1;
      tpSkills2.Size = size64;
      tpSkills.TabIndex = 4;
      tpSkills.Text = "Skills";
      NumericUpDown nudComputerUse1 = nudComputerUse;
      point1 = new Point(186, 60);
      Point point66 = point1;
      nudComputerUse1.Location = point66;
      nudComputerUse.Name = "nudComputerUse";
      NumericUpDown nudComputerUse2 = nudComputerUse;
      size1 = new Size(42, 20);
      Size size65 = size1;
      nudComputerUse2.Size = size65;
      nudComputerUse.TabIndex = 0;
      nudComputerUse.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudComputerUse3 = nudComputerUse;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num28 = num1;
      nudComputerUse3.Value = num28;
      Label label24_1 = Label24;
      point1 = new Point(96, 180);
      Point point67 = point1;
      label24_1.Location = point67;
      Label24.Name = "Label24";
      Label label24_2 = Label24;
      size1 = new Size(84, 18);
      Size size66 = size1;
      label24_2.Size = size66;
      Label24.TabIndex = 6;
      Label24.Text = "Repair";
      Label24.TextAlign = ContentAlignment.MiddleLeft;
      Label label25_1 = Label25;
      point1 = new Point(96, 84);
      Point point68 = point1;
      label25_1.Location = point68;
      Label25.Name = "Label25";
      Label label25_2 = Label25;
      size1 = new Size(84, 18);
      Size size67 = size1;
      label25_2.Size = size67;
      Label25.TabIndex = 7;
      Label25.Text = "Demolitions";
      Label25.TextAlign = ContentAlignment.MiddleLeft;
      Label label26_1 = Label26;
      point1 = new Point(96, 108);
      Point point69 = point1;
      label26_1.Location = point69;
      Label26.Name = "Label26";
      Label label26_2 = Label26;
      size1 = new Size(84, 18);
      Size size68 = size1;
      label26_2.Size = size68;
      Label26.TabIndex = 5;
      Label26.Text = "Stealth";
      Label26.TextAlign = ContentAlignment.MiddleLeft;
      Label label27_1 = Label27;
      point1 = new Point(96, 156);
      Point point70 = point1;
      label27_1.Location = point70;
      Label27.Name = "Label27";
      Label label27_2 = Label27;
      size1 = new Size(84, 18);
      Size size69 = size1;
      label27_2.Size = size69;
      Label27.TabIndex = 2;
      Label27.Text = "Persuade";
      Label27.TextAlign = ContentAlignment.MiddleLeft;
      Label label28_1 = Label28;
      point1 = new Point(96, 60);
      Point point71 = point1;
      label28_1.Location = point71;
      Label28.Name = "Label28";
      Label label28_2 = Label28;
      size1 = new Size(84, 18);
      Size size70 = size1;
      label28_2.Size = size70;
      Label28.TabIndex = 3;
      Label28.Text = "Computer Use";
      Label28.TextAlign = ContentAlignment.MiddleLeft;
      Label label29_1 = Label29;
      point1 = new Point(96, 132);
      Point point72 = point1;
      label29_1.Location = point72;
      Label29.Name = "Label29";
      Label label29_2 = Label29;
      size1 = new Size(84, 18);
      Size size71 = size1;
      label29_2.Size = size71;
      Label29.TabIndex = 4;
      Label29.Text = "Awareness";
      Label29.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudDemolitions1 = nudDemolitions;
      point1 = new Point(186, 84);
      Point point73 = point1;
      nudDemolitions1.Location = point73;
      nudDemolitions.Name = "nudDemolitions";
      NumericUpDown nudDemolitions2 = nudDemolitions;
      size1 = new Size(42, 20);
      Size size72 = size1;
      nudDemolitions2.Size = size72;
      nudDemolitions.TabIndex = 1;
      nudDemolitions.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudDemolitions3 = nudDemolitions;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num29 = num1;
      nudDemolitions3.Value = num29;
      NumericUpDown nudStealth1 = nudStealth;
      point1 = new Point(186, 108);
      Point point74 = point1;
      nudStealth1.Location = point74;
      nudStealth.Name = "nudStealth";
      NumericUpDown nudStealth2 = nudStealth;
      size1 = new Size(42, 20);
      Size size73 = size1;
      nudStealth2.Size = size73;
      nudStealth.TabIndex = 2;
      nudStealth.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudStealth3 = nudStealth;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num30 = num1;
      nudStealth3.Value = num30;
      NumericUpDown nudAwareness1 = nudAwareness;
      point1 = new Point(186, 132);
      Point point75 = point1;
      nudAwareness1.Location = point75;
      nudAwareness.Name = "nudAwareness";
      NumericUpDown nudAwareness2 = nudAwareness;
      size1 = new Size(42, 20);
      Size size74 = size1;
      nudAwareness2.Size = size74;
      nudAwareness.TabIndex = 3;
      nudAwareness.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudAwareness3 = nudAwareness;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num31 = num1;
      nudAwareness3.Value = num31;
      NumericUpDown nudPersuade1 = nudPersuade;
      point1 = new Point(186, 156);
      Point point76 = point1;
      nudPersuade1.Location = point76;
      nudPersuade.Name = "nudPersuade";
      NumericUpDown nudPersuade2 = nudPersuade;
      size1 = new Size(42, 20);
      Size size75 = size1;
      nudPersuade2.Size = size75;
      nudPersuade.TabIndex = 4;
      nudPersuade.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudPersuade3 = nudPersuade;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num32 = num1;
      nudPersuade3.Value = num32;
      NumericUpDown nudRepair1 = nudRepair;
      point1 = new Point(186, 180);
      Point point77 = point1;
      nudRepair1.Location = point77;
      nudRepair.Name = "nudRepair";
      NumericUpDown nudRepair2 = nudRepair;
      size1 = new Size(42, 20);
      Size size76 = size1;
      nudRepair2.Size = size76;
      nudRepair.TabIndex = 5;
      nudRepair.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudRepair3 = nudRepair;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num33 = num1;
      nudRepair3.Value = num33;
      Label label30_1 = Label30;
      point1 = new Point(96, 204);
      Point point78 = point1;
      label30_1.Location = point78;
      Label30.Name = "Label30";
      Label label30_2 = Label30;
      size1 = new Size(84, 18);
      Size size77 = size1;
      label30_2.Size = size77;
      Label30.TabIndex = 2;
      Label30.Text = "Security";
      Label30.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudSecurity1 = nudSecurity;
      point1 = new Point(186, 204);
      Point point79 = point1;
      nudSecurity1.Location = point79;
      nudSecurity.Name = "nudSecurity";
      NumericUpDown nudSecurity2 = nudSecurity;
      size1 = new Size(42, 20);
      Size size78 = size1;
      nudSecurity2.Size = size78;
      nudSecurity.TabIndex = 6;
      nudSecurity.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudSecurity3 = nudSecurity;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num34 = num1;
      nudSecurity3.Value = num34;
      NumericUpDown nudTreatInjury1 = nudTreatInjury;
      point1 = new Point(186, 228);
      Point point80 = point1;
      nudTreatInjury1.Location = point80;
      nudTreatInjury.Name = "nudTreatInjury";
      NumericUpDown nudTreatInjury2 = nudTreatInjury;
      size1 = new Size(42, 20);
      Size size79 = size1;
      nudTreatInjury2.Size = size79;
      nudTreatInjury.TabIndex = 7;
      nudTreatInjury.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudTreatInjury3 = nudTreatInjury;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num35 = num1;
      nudTreatInjury3.Value = num35;
      Label label31_1 = Label31;
      point1 = new Point(96, 228);
      Point point81 = point1;
      label31_1.Location = point81;
      Label31.Name = "Label31";
      Label label31_2 = Label31;
      size1 = new Size(84, 18);
      Size size80 = size1;
      label31_2.Size = size80;
      Label31.TabIndex = 6;
      Label31.Text = "Treat Injury";
      Label31.TextAlign = ContentAlignment.MiddleLeft;
      tpAdvanced.Controls.Add(GroupBox12);
      tpAdvanced.Controls.Add(GroupBox11);
      tpAdvanced.Controls.Add(GroupBox13);
      tpAdvanced.Controls.Add(GroupBox14);
      tpAdvanced.Controls.Add(GroupBox15);
      tpAdvanced.Controls.Add(GroupBox18);
      TabPage tpAdvanced1 = tpAdvanced;
      point1 = new Point(4, 40);
      Point point82 = point1;
      ((Control) tpAdvanced1).Location = point82;
      tpAdvanced.Name = "tpAdvanced";
      TabPage tpAdvanced2 = tpAdvanced;
      size1 = new Size(408, 492);
      Size size81 = size1;
      tpAdvanced2.Size = size81;
      tpAdvanced.TabIndex = 6;
      tpAdvanced.Text = "Advanced";
      GroupBox12.Controls.Add(tbChallengeRating);
      GroupBox groupBox12_1 = GroupBox12;
      point1 = new Point(12, 384);
      Point point83 = point1;
      groupBox12_1.Location = point83;
      GroupBox12.Name = "GroupBox12";
      GroupBox groupBox12_2 = GroupBox12;
      size1 = new Size(186, 48);
      Size size82 = size1;
      groupBox12_2.Size = size82;
      GroupBox12.TabIndex = 3;
      GroupBox12.TabStop = false;
      GroupBox12.Text = "Challenge Rating";
      TextBox tbChallengeRating1 = tbChallengeRating;
      point1 = new Point(36, 15);
      Point point84 = point1;
      tbChallengeRating1.Location = point84;
      tbChallengeRating.Name = "tbChallengeRating";
      TextBox tbChallengeRating2 = tbChallengeRating;
      size1 = new Size(42, 20);
      Size size83 = size1;
      tbChallengeRating2.Size = size83;
      tbChallengeRating.TabIndex = 0;
      tbChallengeRating.Text = "";
      GroupBox11.Controls.Add(nudMultiplierSet);
      GroupBox11.Controls.Add(Label51);
      GroupBox11.Controls.Add(chkbDisarmable);
      GroupBox11.Controls.Add(chkbPlot);
      GroupBox11.Controls.Add(chkbNoPermDeath);
      GroupBox11.Controls.Add(Label52);
      GroupBox11.Controls.Add(tbDeity);
      GroupBox11.Controls.Add(chkbIsPC);
      GroupBox11.Controls.Add(cmbxSubrace);
      GroupBox11.Controls.Add(chkbIsHologram);
      GroupBox11.Controls.Add(chkbNotReorienting);
      GroupBox11.Controls.Add(chkbIgnoreCrePath);
      GroupBox11.Controls.Add(lblMultiplierSet);
      GroupBox11.Controls.Add(lblBlindSpot);
      GroupBox11.Controls.Add(nudBlindSpot);
      GroupBox11.Controls.Add(chkbMin1HP);
      GroupBox groupBox11_1 = GroupBox11;
      point1 = new Point(12, 114);
      Point point85 = point1;
      groupBox11_1.Location = point85;
      GroupBox11.Name = "GroupBox11";
      GroupBox groupBox11_2 = GroupBox11;
      size1 = new Size(384, 246);
      Size size84 = size1;
      groupBox11_2.Size = size84;
      GroupBox11.TabIndex = 2;
      GroupBox11.TabStop = false;
      GroupBox11.Text = "Special";
      NumericUpDown nudMultiplierSet1 = nudMultiplierSet;
      point1 = new Point(318, 156);
      Point point86 = point1;
      nudMultiplierSet1.Location = point86;
      nudMultiplierSet.Name = "nudMultiplierSet";
      NumericUpDown nudMultiplierSet2 = nudMultiplierSet;
      size1 = new Size(48, 20);
      Size size85 = size1;
      nudMultiplierSet2.Size = size85;
      nudMultiplierSet.TabIndex = 7;
      nudMultiplierSet.TextAlign = HorizontalAlignment.Right;
      nudMultiplierSet.Visible = false;
      Label label51_1 = Label51;
      point1 = new Point(30, 192);
      Point point87 = point1;
      label51_1.Location = point87;
      Label51.Name = "Label51";
      Label label51_2 = Label51;
      size1 = new Size(100, 18);
      Size size86 = size1;
      label51_2.Size = size86;
      Label51.TabIndex = 1;
      Label51.Text = "Subrace";
      CheckBox chkbDisarmable1 = chkbDisarmable;
      point1 = new Point(30, 30);
      Point point88 = point1;
      chkbDisarmable1.Location = point88;
      chkbDisarmable.Name = "chkbDisarmable";
      CheckBox chkbDisarmable2 = chkbDisarmable;
      size1 = new Size(104, 18);
      Size size87 = size1;
      chkbDisarmable2.Size = size87;
      chkbDisarmable.TabIndex = 0;
      chkbDisarmable.Text = "Disarmable";
      CheckBox chkbPlot1 = chkbPlot;
      point1 = new Point(30, 78);
      Point point89 = point1;
      chkbPlot1.Location = point89;
      chkbPlot.Name = "chkbPlot";
      CheckBox chkbPlot2 = chkbPlot;
      size1 = new Size(66, 18);
      Size size88 = size1;
      chkbPlot2.Size = size88;
      chkbPlot.TabIndex = 2;
      chkbPlot.Text = "Plot";
      CheckBox chkbNoPermDeath1 = chkbNoPermDeath;
      point1 = new Point(30, 54);
      Point point90 = point1;
      chkbNoPermDeath1.Location = point90;
      chkbNoPermDeath.Name = "chkbNoPermDeath";
      CheckBox chkbNoPermDeath2 = chkbNoPermDeath;
      size1 = new Size(132, 18);
      Size size89 = size1;
      chkbNoPermDeath2.Size = size89;
      chkbNoPermDeath.TabIndex = 1;
      chkbNoPermDeath.Text = "No Permanent Death";
      Label label52_1 = Label52;
      point1 = new Point(30, 210);
      Point point91 = point1;
      label52_1.Location = point91;
      Label52.Name = "Label52";
      Label label52_2 = Label52;
      size1 = new Size(100, 18);
      Size size90 = size1;
      label52_2.Size = size90;
      Label52.TabIndex = 1;
      Label52.Text = "Deity";
      Label52.Visible = false;
      TextBox tbDeity1 = tbDeity;
      point1 = new Point(144, 210);
      Point point92 = point1;
      tbDeity1.Location = point92;
      tbDeity.Name = "tbDeity";
      TextBox tbDeity2 = tbDeity;
      size1 = new Size(144, 20);
      Size size91 = size1;
      tbDeity2.Size = size91;
      tbDeity.TabIndex = 9;
      tbDeity.Text = "";
      tbDeity.Visible = false;
      CheckBox chkbIsPc1 = chkbIsPC;
      point1 = new Point(30, 102);
      Point point93 = point1;
      chkbIsPc1.Location = point93;
      chkbIsPC.Name = "chkbIsPC";
      CheckBox chkbIsPc2 = chkbIsPC;
      size1 = new Size(60, 18);
      Size size92 = size1;
      chkbIsPc2.Size = size92;
      chkbIsPC.TabIndex = 3;
      chkbIsPC.Text = "Is PC";
      cmbxSubrace.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxSubrace1 = cmbxSubrace;
      point1 = new Point(144, 192);
      Point point94 = point1;
      cmbxSubrace1.Location = point94;
      cmbxSubrace.Name = "cmbxSubrace";
      ComboBox cmbxSubrace2 = cmbxSubrace;
      size1 = new Size(144, 21);
      Size size93 = size1;
      cmbxSubrace2.Size = size93;
      cmbxSubrace.TabIndex = 8;
      CheckBox chkbIsHologram1 = chkbIsHologram;
      point1 = new Point(174, 78);
      Point point95 = point1;
      chkbIsHologram1.Location = point95;
      chkbIsHologram.Name = "chkbIsHologram";
      CheckBox chkbIsHologram2 = chkbIsHologram;
      size1 = new Size(104, 18);
      Size size94 = size1;
      chkbIsHologram2.Size = size94;
      chkbIsHologram.TabIndex = 5;
      chkbIsHologram.Text = "Is Hologram";
      chkbIsHologram.Visible = false;
      CheckBox chkbNotReorienting1 = chkbNotReorienting;
      point1 = new Point(174, 30);
      Point point96 = point1;
      chkbNotReorienting1.Location = point96;
      chkbNotReorienting.Name = "chkbNotReorienting";
      CheckBox chkbNotReorienting2 = chkbNotReorienting;
      size1 = new Size(144, 18);
      Size size95 = size1;
      chkbNotReorienting2.Size = size95;
      chkbNotReorienting.TabIndex = 3;
      chkbNotReorienting.Text = "Doesn't Reorient on PC";
      chkbNotReorienting.Visible = false;
      CheckBox chkbIgnoreCrePath1 = chkbIgnoreCrePath;
      point1 = new Point(174, 54);
      Point point97 = point1;
      chkbIgnoreCrePath1.Location = point97;
      chkbIgnoreCrePath.Name = "chkbIgnoreCrePath";
      CheckBox chkbIgnoreCrePath2 = chkbIgnoreCrePath;
      size1 = new Size(114, 18);
      Size size96 = size1;
      chkbIgnoreCrePath2.Size = size96;
      chkbIgnoreCrePath.TabIndex = 4;
      chkbIgnoreCrePath.Text = "Doesn't Block PC";
      chkbIgnoreCrePath.Visible = false;
      Label lblMultiplierSet1 = lblMultiplierSet;
      point1 = new Point(204, 156);
      Point point98 = point1;
      lblMultiplierSet1.Location = point98;
      lblMultiplierSet.Name = "lblMultiplierSet";
      Label lblMultiplierSet2 = lblMultiplierSet;
      size1 = new Size(100, 18);
      Size size97 = size1;
      lblMultiplierSet2.Size = size97;
      lblMultiplierSet.TabIndex = 1;
      lblMultiplierSet.Text = "Multiplier Set";
      lblMultiplierSet.TextAlign = ContentAlignment.MiddleLeft;
      lblMultiplierSet.Visible = false;
      Label lblBlindSpot1 = lblBlindSpot;
      point1 = new Point(30, 156);
      Point point99 = point1;
      lblBlindSpot1.Location = point99;
      lblBlindSpot.Name = "lblBlindSpot";
      Label lblBlindSpot2 = lblBlindSpot;
      size1 = new Size(100, 18);
      Size size98 = size1;
      lblBlindSpot2.Size = size98;
      lblBlindSpot.TabIndex = 1;
      lblBlindSpot.Text = "Blind Spot";
      lblBlindSpot.TextAlign = ContentAlignment.MiddleLeft;
      lblBlindSpot.Visible = false;
      nudBlindSpot.DecimalPlaces = 1;
      NumericUpDown nudBlindSpot1 = nudBlindSpot;
      point1 = new Point(144, 156);
      Point point100 = point1;
      nudBlindSpot1.Location = point100;
      NumericUpDown nudBlindSpot2 = nudBlindSpot;
      num1 = new Decimal(new int[4]{ 3599, 0, 0, 65536 });
      Decimal num36 = num1;
      nudBlindSpot2.Maximum = num36;
      nudBlindSpot.Name = "nudBlindSpot";
      NumericUpDown nudBlindSpot3 = nudBlindSpot;
      size1 = new Size(48, 20);
      Size size99 = size1;
      nudBlindSpot3.Size = size99;
      nudBlindSpot.TabIndex = 6;
      nudBlindSpot.TextAlign = HorizontalAlignment.Right;
      nudBlindSpot.Visible = false;
      CheckBox chkbMin1Hp1 = chkbMin1HP;
      point1 = new Point(30, 126);
      Point point101 = point1;
      chkbMin1Hp1.Location = point101;
      chkbMin1HP.Name = "chkbMin1HP";
      CheckBox chkbMin1Hp2 = chkbMin1HP;
      size1 = new Size(108, 18);
      Size size100 = size1;
      chkbMin1Hp2.Size = size100;
      chkbMin1HP.TabIndex = 3;
      chkbMin1HP.Text = "Minimum 1 HP";
      GroupBox13.Controls.Add(cmbxSoundSet);
      GroupBox groupBox13_1 = GroupBox13;
      point1 = new Point(210, 384);
      Point point102 = point1;
      groupBox13_1.Location = point102;
      GroupBox13.Name = "GroupBox13";
      GroupBox groupBox13_2 = GroupBox13;
      size1 = new Size(186, 48);
      Size size101 = size1;
      groupBox13_2.Size = size101;
      GroupBox13.TabIndex = 4;
      GroupBox13.TabStop = false;
      GroupBox13.Text = "Sound Set";
      cmbxSoundSet.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxSoundSet1 = cmbxSoundSet;
      point1 = new Point(24, 16);
      Point point103 = point1;
      cmbxSoundSet1.Location = point103;
      cmbxSoundSet.Name = "cmbxSoundSet";
      ComboBox cmbxSoundSet2 = cmbxSoundSet;
      size1 = new Size(144, 21);
      Size size102 = size1;
      cmbxSoundSet2.Size = size102;
      cmbxSoundSet.TabIndex = 0;
      GroupBox14.Controls.Add(cmbxPerceptionRange);
      GroupBox groupBox14_1 = GroupBox14;
      point1 = new Point(210, 438);
      Point point104 = point1;
      groupBox14_1.Location = point104;
      GroupBox14.Name = "GroupBox14";
      GroupBox groupBox14_2 = GroupBox14;
      size1 = new Size(186, 48);
      Size size103 = size1;
      groupBox14_2.Size = size103;
      GroupBox14.TabIndex = 5;
      GroupBox14.TabStop = false;
      GroupBox14.Text = "Perception Range";
      cmbxPerceptionRange.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxPerceptionRange.Items.AddRange(new object[6]
      {
        "Short",
        "Medium",
        "Long",
        "Default",
        "Player",
        "Monster"
      });
      ComboBox cmbxPerceptionRange1 = cmbxPerceptionRange;
      point1 = new Point(24, 16);
      Point point105 = point1;
      cmbxPerceptionRange1.Location = point105;
      cmbxPerceptionRange.Name = "cmbxPerceptionRange";
      ComboBox cmbxPerceptionRange2 = cmbxPerceptionRange;
      size1 = new Size(144, 21);
      Size size104 = size1;
      cmbxPerceptionRange2.Size = size104;
      cmbxPerceptionRange.TabIndex = 0;
      GroupBox15.Controls.Add(cmbxFaction);
      GroupBox groupBox15_1 = GroupBox15;
      point1 = new Point(12, 438);
      Point point106 = point1;
      groupBox15_1.Location = point106;
      GroupBox15.Name = "GroupBox15";
      GroupBox groupBox15_2 = GroupBox15;
      size1 = new Size(186, 48);
      Size size105 = size1;
      groupBox15_2.Size = size105;
      GroupBox15.TabIndex = 1;
      GroupBox15.TabStop = false;
      GroupBox15.Text = "Faction";
      cmbxFaction.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxFaction1 = cmbxFaction;
      point1 = new Point(24, 16);
      Point point107 = point1;
      cmbxFaction1.Location = point107;
      cmbxFaction.Name = "cmbxFaction";
      ComboBox cmbxFaction2 = cmbxFaction;
      size1 = new Size(144, 21);
      Size size106 = size1;
      cmbxFaction2.Size = size106;
      cmbxFaction.TabIndex = 1;
      GroupBox18.Controls.Add(tbTemplateResRef);
      GroupBox18.Controls.Add(Label56);
      GroupBox18.Controls.Add(Label57);
      GroupBox18.Controls.Add(cmbxTreasureModel);
      GroupBox groupBox18_1 = GroupBox18;
      point1 = new Point(12, 12);
      Point point108 = point1;
      groupBox18_1.Location = point108;
      GroupBox18.Name = "GroupBox18";
      GroupBox groupBox18_2 = GroupBox18;
      size1 = new Size(384, 90);
      Size size107 = size1;
      groupBox18_2.Size = size107;
      GroupBox18.TabIndex = 0;
      GroupBox18.TabStop = false;
      GroupBox18.Text = "Info";
      tbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbTemplateResRef1 = tbTemplateResRef;
      point1 = new Point(144, 24);
      Point point109 = point1;
      tbTemplateResRef1.Location = point109;
      tbTemplateResRef.MaxLength = 16;
      tbTemplateResRef.Name = "tbTemplateResRef";
      TextBox tbTemplateResRef2 = tbTemplateResRef;
      size1 = new Size(176, 20);
      Size size108 = size1;
      tbTemplateResRef2.Size = size108;
      tbTemplateResRef.TabIndex = 2;
      tbTemplateResRef.Text = "";
      Label label56_1 = Label56;
      point1 = new Point(24, 57);
      Point point110 = point1;
      label56_1.Location = point110;
      Label56.Name = "Label56";
      Label label56_2 = Label56;
      size1 = new Size(100, 18);
      Size size109 = size1;
      label56_2.Size = size109;
      Label56.TabIndex = 1;
      Label56.Text = "Treasure Model";
      Label56.TextAlign = ContentAlignment.MiddleLeft;
      Label56.Visible = false;
      Label label57_1 = Label57;
      point1 = new Point(24, 25);
      Point point111 = point1;
      label57_1.Location = point111;
      Label57.Name = "Label57";
      Label label57_2 = Label57;
      size1 = new Size(100, 18);
      Size size110 = size1;
      label57_2.Size = size110;
      Label57.TabIndex = 1;
      Label57.Text = "Template ResRef";
      Label57.TextAlign = ContentAlignment.MiddleLeft;
      cmbxTreasureModel.DropDownStyle = ComboBoxStyle.DropDownList;
      cmbxTreasureModel.Items.AddRange(new object[6]
      {
        "Short",
        "Medium",
        "Long",
        "Default",
        "Player",
        "Monster"
      });
      ComboBox cmbxTreasureModel1 = cmbxTreasureModel;
      point1 = new Point(144, 56);
      Point point112 = point1;
      cmbxTreasureModel1.Location = point112;
      cmbxTreasureModel.Name = "cmbxTreasureModel";
      ComboBox cmbxTreasureModel2 = cmbxTreasureModel;
      size1 = new Size(176, 21);
      Size size111 = size1;
      cmbxTreasureModel2.Size = size111;
      cmbxTreasureModel.TabIndex = 0;
      cmbxTreasureModel.Visible = false;
      tpFeats.Controls.Add(GroupBox10);
      tpFeats.Controls.Add(chklbFeats);
      TabPage tpFeats1 = tpFeats;
      point1 = new Point(4, 40);
      Point point113 = point1;
      ((Control) tpFeats1).Location = point113;
      tpFeats.Name = "tpFeats";
      TabPage tpFeats2 = tpFeats;
      size1 = new Size(408, 492);
      Size size112 = size1;
      tpFeats2.Size = size112;
      tpFeats.TabIndex = 7;
      tpFeats.Text = "Feats";
      GroupBox10.Controls.Add(tbFeatSummary);
      GroupBox groupBox10_1 = GroupBox10;
      point1 = new Point(6, 354);
      Point point114 = point1;
      groupBox10_1.Location = point114;
      GroupBox10.Name = "GroupBox10";
      GroupBox groupBox10_2 = GroupBox10;
      size1 = new Size(396, 132);
      Size size113 = size1;
      groupBox10_2.Size = size113;
      GroupBox10.TabIndex = 2;
      GroupBox10.TabStop = false;
      GroupBox10.Text = "Feats Selection Summary";
      TextBox tbFeatSummary1 = tbFeatSummary;
      point1 = new Point(18, 24);
      Point point115 = point1;
      tbFeatSummary1.Location = point115;
      tbFeatSummary.Multiline = true;
      tbFeatSummary.Name = "tbFeatSummary";
      tbFeatSummary.ScrollBars = ScrollBars.Vertical;
      TextBox tbFeatSummary2 = tbFeatSummary;
      size1 = new Size(360, 96);
      Size size114 = size1;
      tbFeatSummary2.Size = size114;
      tbFeatSummary.TabIndex = 1;
      tbFeatSummary.Text = "";
      tbFeatSummary.WordWrap = false;
      CheckedListBox chklbFeats1 = chklbFeats;
      point1 = new Point(72, 36);
      Point point116 = point1;
      chklbFeats1.Location = point116;
      chklbFeats.Name = "chklbFeats";
      CheckedListBox chklbFeats2 = chklbFeats;
      size1 = new Size(264, 289);
      Size size115 = size1;
      chklbFeats2.Size = size115;
      chklbFeats.TabIndex = 0;
      chklbFeats.ThreeDCheckBoxes = true;
      toForcePowers.Controls.Add(GroupBox19);
      toForcePowers.Controls.Add(GroupBox17);
      toForcePowers.Controls.Add(GroupBox16);
      TabPage toForcePowers1 = toForcePowers;
      point1 = new Point(4, 40);
      Point point117 = point1;
      ((Control) toForcePowers1).Location = point117;
      toForcePowers.Name = "toForcePowers";
      TabPage toForcePowers2 = toForcePowers;
      size1 = new Size(408, 492);
      Size size116 = size1;
      toForcePowers2.Size = size116;
      toForcePowers.TabIndex = 8;
      toForcePowers.Text = "Force Powers";
      GroupBox19.Controls.Add(tbForcePowerSummary);
      GroupBox groupBox19_1 = GroupBox19;
      point1 = new Point(6, 366);
      Point point118 = point1;
      groupBox19_1.Location = point118;
      GroupBox19.Name = "GroupBox19";
      GroupBox groupBox19_2 = GroupBox19;
      size1 = new Size(396, 120);
      Size size117 = size1;
      groupBox19_2.Size = size117;
      GroupBox19.TabIndex = 3;
      GroupBox19.TabStop = false;
      GroupBox19.Text = "Force Power Selection Summary";
      TextBox forcePowerSummary1 = tbForcePowerSummary;
      point1 = new Point(18, 16);
      Point point119 = point1;
      forcePowerSummary1.Location = point119;
      tbForcePowerSummary.Multiline = true;
      tbForcePowerSummary.Name = "tbForcePowerSummary";
      tbForcePowerSummary.ScrollBars = ScrollBars.Vertical;
      TextBox forcePowerSummary2 = tbForcePowerSummary;
      size1 = new Size(360, 96);
      Size size118 = size1;
      forcePowerSummary2.Size = size118;
      tbForcePowerSummary.TabIndex = 1;
      tbForcePowerSummary.Text = "";
      tbForcePowerSummary.WordWrap = false;
      GroupBox17.Controls.Add(chklbForcePowers);
      GroupBox17.Controls.Add(btnSelectAllPowers);
      GroupBox17.Controls.Add(btnClearAllPowers);
      GroupBox groupBox17_1 = GroupBox17;
      point1 = new Point(6, 72);
      Point point120 = point1;
      groupBox17_1.Location = point120;
      GroupBox17.Name = "GroupBox17";
      GroupBox groupBox17_2 = GroupBox17;
      size1 = new Size(396, 288);
      Size size119 = size1;
      groupBox17_2.Size = size119;
      GroupBox17.TabIndex = 1;
      GroupBox17.TabStop = false;
      GroupBox17.Text = "Force Powers";
      CheckedListBox chklbForcePowers1 = chklbForcePowers;
      point1 = new Point(66, 18);
      Point point121 = point1;
      chklbForcePowers1.Location = point121;
      chklbForcePowers.Name = "chklbForcePowers";
      CheckedListBox chklbForcePowers2 = chklbForcePowers;
      size1 = new Size(264, 229);
      Size size120 = size1;
      chklbForcePowers2.Size = size120;
      chklbForcePowers.TabIndex = 0;
      chklbForcePowers.ThreeDCheckBoxes = true;
      Button btnSelectAllPowers1 = btnSelectAllPowers;
      point1 = new Point(84, 258);
      Point point122 = point1;
      btnSelectAllPowers1.Location = point122;
      btnSelectAllPowers.Name = "btnSelectAllPowers";
      Button btnSelectAllPowers2 = btnSelectAllPowers;
      size1 = new Size(102, 24);
      Size size121 = size1;
      btnSelectAllPowers2.Size = size121;
      btnSelectAllPowers.TabIndex = 1;
      btnSelectAllPowers.Text = "Select All Powers";
      btnClearAllPowers.DialogResult = DialogResult.Cancel;
      Button btnClearAllPowers1 = btnClearAllPowers;
      point1 = new Point(216, 258);
      Point point123 = point1;
      btnClearAllPowers1.Location = point123;
      btnClearAllPowers.Name = "btnClearAllPowers";
      Button btnClearAllPowers2 = btnClearAllPowers;
      size1 = new Size(96, 24);
      Size size122 = size1;
      btnClearAllPowers2.Size = size122;
      btnClearAllPowers.TabIndex = 2;
      btnClearAllPowers.Text = "Clear All Powers";
      GroupBox16.Controls.Add(nudForcePoints);
      GroupBox16.Controls.Add(Label54);
      GroupBox16.Controls.Add(Label55);
      GroupBox16.Controls.Add(nudCurrentForce);
      GroupBox groupBox16_1 = GroupBox16;
      point1 = new Point(6, 6);
      Point point124 = point1;
      groupBox16_1.Location = point124;
      GroupBox16.Name = "GroupBox16";
      GroupBox groupBox16_2 = GroupBox16;
      size1 = new Size(396, 60);
      Size size123 = size1;
      groupBox16_2.Size = size123;
      GroupBox16.TabIndex = 0;
      GroupBox16.TabStop = false;
      GroupBox16.Text = "Force Points";
      NumericUpDown nudForcePoints1 = nudForcePoints;
      point1 = new Point(120, 25);
      Point point125 = point1;
      nudForcePoints1.Location = point125;
      NumericUpDown nudForcePoints2 = nudForcePoints;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num37 = num1;
      nudForcePoints2.Maximum = num37;
      nudForcePoints.Name = "nudForcePoints";
      NumericUpDown nudForcePoints3 = nudForcePoints;
      size1 = new Size(48, 20);
      Size size124 = size1;
      nudForcePoints3.Size = size124;
      nudForcePoints.TabIndex = 0;
      NumericUpDown nudForcePoints4 = nudForcePoints;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num38 = num1;
      nudForcePoints4.Value = num38;
      Label label54_1 = Label54;
      point1 = new Point(18, 26);
      Point point126 = point1;
      label54_1.Location = point126;
      Label54.Name = "Label54";
      Label label54_2 = Label54;
      size1 = new Size(96, 18);
      Size size125 = size1;
      label54_2.Size = size125;
      Label54.TabIndex = 0;
      Label54.Text = "Max Force Points";
      Label54.TextAlign = ContentAlignment.MiddleLeft;
      Label label55_1 = Label55;
      point1 = new Point(204, 26);
      Point point127 = point1;
      label55_1.Location = point127;
      Label55.Name = "Label55";
      Label label55_2 = Label55;
      size1 = new Size(108, 18);
      Size size126 = size1;
      label55_2.Size = size126;
      Label55.TabIndex = 0;
      Label55.Text = "Current Force Points";
      Label55.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudCurrentForce1 = nudCurrentForce;
      point1 = new Point(312, 25);
      Point point128 = point1;
      nudCurrentForce1.Location = point128;
      NumericUpDown nudCurrentForce2 = nudCurrentForce;
      num1 = new Decimal(new int[4]{ 9999, 0, 0, 0 });
      Decimal num39 = num1;
      nudCurrentForce2.Maximum = num39;
      nudCurrentForce.Name = "nudCurrentForce";
      NumericUpDown nudCurrentForce3 = nudCurrentForce;
      size1 = new Size(48, 20);
      Size size127 = size1;
      nudCurrentForce3.Size = size127;
      nudCurrentForce.TabIndex = 1;
      NumericUpDown nudCurrentForce4 = nudCurrentForce;
      num1 = new Decimal(new int[4]{ 100, 0, 0, 0 });
      Decimal num40 = num1;
      nudCurrentForce4.Value = num40;
      tpClasses.Controls.Add(GroupBox9);
      tpClasses.Controls.Add(GroupBox8);
      TabPage tpClasses1 = tpClasses;
      point1 = new Point(4, 40);
      Point point129 = point1;
      ((Control) tpClasses1).Location = point129;
      tpClasses.Name = "tpClasses";
      TabPage tpClasses2 = tpClasses;
      size1 = new Size(408, 492);
      Size size128 = size1;
      tpClasses2.Size = size128;
      tpClasses.TabIndex = 3;
      tpClasses.Text = "Class";
      GroupBox9.Controls.Add(Label46);
      GroupBox9.Controls.Add(nudClassLevel);
      GroupBox9.Controls.Add(cmbxClass);
      GroupBox9.Controls.Add(Label23);
      GroupBox groupBox9_1 = GroupBox9;
      point1 = new Point(6, 114);
      Point point130 = point1;
      groupBox9_1.Location = point130;
      GroupBox9.Name = "GroupBox9";
      GroupBox groupBox9_2 = GroupBox9;
      size1 = new Size(396, 108);
      Size size129 = size1;
      groupBox9_2.Size = size129;
      GroupBox9.TabIndex = 7;
      GroupBox9.TabStop = false;
      GroupBox9.Text = "Classes";
      Label label46_1 = Label46;
      point1 = new Point(18, 66);
      Point point131 = point1;
      label46_1.Location = point131;
      Label46.Name = "Label46";
      Label label46_2 = Label46;
      size1 = new Size(42, 16);
      Size size130 = size1;
      label46_2.Size = size130;
      Label46.TabIndex = 3;
      Label46.Text = "Level";
      Label46.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudClassLevel1 = nudClassLevel;
      point1 = new Point(78, 66);
      Point point132 = point1;
      nudClassLevel1.Location = point132;
      NumericUpDown nudClassLevel2 = nudClassLevel;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num41 = num1;
      nudClassLevel2.Maximum = num41;
      nudClassLevel.Name = "nudClassLevel";
      NumericUpDown nudClassLevel3 = nudClassLevel;
      size1 = new Size(42, 20);
      Size size131 = size1;
      nudClassLevel3.Size = size131;
      nudClassLevel.TabIndex = 1;
      cmbxClass.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxClass1 = cmbxClass;
      point1 = new Point(60, 30);
      Point point133 = point1;
      cmbxClass1.Location = point133;
      cmbxClass.Name = "cmbxClass";
      ComboBox cmbxClass2 = cmbxClass;
      size1 = new Size(184, 21);
      Size size132 = size1;
      cmbxClass2.Size = size132;
      cmbxClass.TabIndex = 0;
      Label label23_1 = Label23;
      point1 = new Point(18, 30);
      Point point134 = point1;
      label23_1.Location = point134;
      Label23.Name = "Label23";
      Label label23_2 = Label23;
      size1 = new Size(42, 16);
      Size size133 = size1;
      label23_2.Size = size133;
      Label23.TabIndex = 3;
      Label23.Text = "Class";
      Label23.TextAlign = ContentAlignment.MiddleLeft;
      GroupBox8.Controls.Add(nudAlignment);
      GroupBox8.Controls.Add(Label47);
      GroupBox8.Controls.Add(trkbarAlignment);
      GroupBox8.Controls.Add(Label48);
      GroupBox groupBox8_1 = GroupBox8;
      point1 = new Point(6, 6);
      Point point135 = point1;
      groupBox8_1.Location = point135;
      GroupBox8.Name = "GroupBox8";
      GroupBox groupBox8_2 = GroupBox8;
      size1 = new Size(396, 102);
      Size size134 = size1;
      groupBox8_2.Size = size134;
      GroupBox8.TabIndex = 6;
      GroupBox8.TabStop = false;
      GroupBox8.Text = "Alignment";
      NumericUpDown nudAlignment1 = nudAlignment;
      point1 = new Point(186, 72);
      Point point136 = point1;
      nudAlignment1.Location = point136;
      nudAlignment.Name = "nudAlignment";
      nudAlignment.RightToLeft = RightToLeft.No;
      NumericUpDown nudAlignment2 = nudAlignment;
      size1 = new Size(42, 20);
      Size size135 = size1;
      nudAlignment2.Size = size135;
      nudAlignment.TabIndex = 1;
      nudAlignment.TextAlign = HorizontalAlignment.Right;
      Label label47_1 = Label47;
      point1 = new Point(12, 36);
      Point point137 = point1;
      label47_1.Location = point137;
      Label47.Name = "Label47";
      Label label47_2 = Label47;
      size1 = new Size(36, 18);
      Size size136 = size1;
      label47_2.Size = size136;
      Label47.TabIndex = 1;
      Label47.Text = "Evil";
      TrackBar trkbarAlignment1 = trkbarAlignment;
      point1 = new Point(66, 24);
      Point point138 = point1;
      trkbarAlignment1.Location = point138;
      trkbarAlignment.Maximum = 100;
      trkbarAlignment.Name = "trkbarAlignment";
      TrackBar trkbarAlignment2 = trkbarAlignment;
      size1 = new Size(276, 42);
      Size size137 = size1;
      trkbarAlignment2.Size = size137;
      trkbarAlignment.TabIndex = 0;
      trkbarAlignment.TickFrequency = 5;
      Label label48_1 = Label48;
      point1 = new Point(348, 36);
      Point point139 = point1;
      label48_1.Location = point139;
      Label48.Name = "Label48";
      Label label48_2 = Label48;
      size1 = new Size(36, 18);
      Size size138 = size1;
      label48_2.Size = size138;
      Label48.TabIndex = 1;
      Label48.Text = "Good";
      tpSpecialAbilities.Controls.Add(GroupBox20);
      TabPage specialAbilities1 = tpSpecialAbilities;
      point1 = new Point(4, 40);
      Point point140 = point1;
      ((Control) specialAbilities1).Location = point140;
      tpSpecialAbilities.Name = "tpSpecialAbilities";
      TabPage specialAbilities2 = tpSpecialAbilities;
      size1 = new Size(408, 492);
      Size size139 = size1;
      specialAbilities2.Size = size139;
      tpSpecialAbilities.TabIndex = 9;
      tpSpecialAbilities.Text = "Special Abilities";
      GroupBox20.Controls.Add(chklbSpecialAbilities);
      GroupBox groupBox20_1 = GroupBox20;
      point1 = new Point(6, 6);
      Point point141 = point1;
      groupBox20_1.Location = point141;
      GroupBox20.Name = "GroupBox20";
      GroupBox groupBox20_2 = GroupBox20;
      size1 = new Size(396, 306);
      Size size140 = size1;
      groupBox20_2.Size = size140;
      GroupBox20.TabIndex = 3;
      GroupBox20.TabStop = false;
      GroupBox20.Text = "Special Abilities";
      CheckedListBox specialAbilities3 = chklbSpecialAbilities;
      point1 = new Point(66, 12);
      Point point142 = point1;
      specialAbilities3.Location = point142;
      chklbSpecialAbilities.Name = "chklbSpecialAbilities";
      CheckedListBox specialAbilities4 = chklbSpecialAbilities;
      size1 = new Size(264, 274);
      Size size141 = size1;
      specialAbilities4.Size = size141;
      chklbSpecialAbilities.TabIndex = 2;
      chklbSpecialAbilities.ThreeDCheckBoxes = true;
      tpScripts.Controls.Add(btnEditOnEndDialogu);
      tpScripts.Controls.Add(btnEditOnDialogue);
      tpScripts.Controls.Add(btnEditOnUserDefine);
      tpScripts.Controls.Add(btnEditOnHeartbeat);
      tpScripts.Controls.Add(btnEditOnDisturbed);
      tpScripts.Controls.Add(btnEditOnDamaged);
      tpScripts.Controls.Add(btnEditOnAttacked);
      tpScripts.Controls.Add(Label34);
      tpScripts.Controls.Add(tbOnSpellAt);
      tpScripts.Controls.Add(Label33);
      tpScripts.Controls.Add(tbOnNotice);
      tpScripts.Controls.Add(Label32);
      tpScripts.Controls.Add(tbOnHeartbeat);
      tpScripts.Controls.Add(Label35);
      tpScripts.Controls.Add(tbOnAttacked);
      tpScripts.Controls.Add(tbOnDamaged);
      tpScripts.Controls.Add(Label36);
      tpScripts.Controls.Add(Label37);
      tpScripts.Controls.Add(tbOnDisturbed);
      tpScripts.Controls.Add(tbOnEndRound);
      tpScripts.Controls.Add(Label38);
      tpScripts.Controls.Add(tbOnEndDialogu);
      tpScripts.Controls.Add(Label39);
      tpScripts.Controls.Add(Label40);
      tpScripts.Controls.Add(tbOnDialogue);
      tpScripts.Controls.Add(Label41);
      tpScripts.Controls.Add(tbOnSpawn);
      tpScripts.Controls.Add(tbOnRested);
      tpScripts.Controls.Add(Label42);
      tpScripts.Controls.Add(tbOnDeath);
      tpScripts.Controls.Add(Label43);
      tpScripts.Controls.Add(Label44);
      tpScripts.Controls.Add(tbOnBlocked);
      tpScripts.Controls.Add(tbOnUserDefine);
      tpScripts.Controls.Add(Label45);
      tpScripts.Controls.Add(btnEditOnNotice);
      tpScripts.Controls.Add(btnEditOnSpellAt);
      tpScripts.Controls.Add(btnEditOnSpawn);
      tpScripts.Controls.Add(btnEditOnDeath);
      tpScripts.Controls.Add(btnEditOnBlocked);
      tpScripts.Controls.Add(btnEditOnRested);
      tpScripts.Controls.Add(btnEditOnEndRound);
      TabPage tpScripts1 = tpScripts;
      point1 = new Point(4, 40);
      Point point143 = point1;
      ((Control) tpScripts1).Location = point143;
      tpScripts.Name = "tpScripts";
      TabPage tpScripts2 = tpScripts;
      size1 = new Size(408, 492);
      Size size142 = size1;
      tpScripts2.Size = size142;
      tpScripts.TabIndex = 5;
      tpScripts.Text = "Scripts";
      Button editOnEndDialogu1 = btnEditOnEndDialogu;
      point1 = new Point(342, 252);
      Point point144 = point1;
      editOnEndDialogu1.Location = point144;
      btnEditOnEndDialogu.Name = "btnEditOnEndDialogu";
      Button editOnEndDialogu2 = btnEditOnEndDialogu;
      size1 = new Size(32, 23);
      Size size143 = size1;
      editOnEndDialogu2.Size = size143;
      btnEditOnEndDialogu.TabIndex = 15;
      btnEditOnEndDialogu.Text = "Edit";
      btnEditOnEndDialogu.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDialogue1 = btnEditOnDialogue;
      point1 = new Point(342, 282);
      Point point145 = point1;
      btnEditOnDialogue1.Location = point145;
      btnEditOnDialogue.Name = "btnEditOnDialogue";
      Button btnEditOnDialogue2 = btnEditOnDialogue;
      size1 = new Size(32, 23);
      Size size144 = size1;
      btnEditOnDialogue2.Size = size144;
      btnEditOnDialogue.TabIndex = 17;
      btnEditOnDialogue.Text = "Edit";
      btnEditOnDialogue.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnUserDefine1 = btnEditOnUserDefine;
      point1 = new Point(342, 432);
      Point point146 = point1;
      editOnUserDefine1.Location = point146;
      btnEditOnUserDefine.Name = "btnEditOnUserDefine";
      Button editOnUserDefine2 = btnEditOnUserDefine;
      size1 = new Size(32, 23);
      Size size145 = size1;
      editOnUserDefine2.Size = size145;
      btnEditOnUserDefine.TabIndex = 27;
      btnEditOnUserDefine.Text = "Edit";
      btnEditOnUserDefine.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnHeartbeat1 = btnEditOnHeartbeat;
      point1 = new Point(342, 42);
      Point point147 = point1;
      btnEditOnHeartbeat1.Location = point147;
      btnEditOnHeartbeat.Name = "btnEditOnHeartbeat";
      Button btnEditOnHeartbeat2 = btnEditOnHeartbeat;
      size1 = new Size(32, 23);
      Size size146 = size1;
      btnEditOnHeartbeat2.Size = size146;
      btnEditOnHeartbeat.TabIndex = 1;
      btnEditOnHeartbeat.Text = "Edit";
      btnEditOnHeartbeat.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDisturbed1 = btnEditOnDisturbed;
      point1 = new Point(342, 192);
      Point point148 = point1;
      btnEditOnDisturbed1.Location = point148;
      btnEditOnDisturbed.Name = "btnEditOnDisturbed";
      Button btnEditOnDisturbed2 = btnEditOnDisturbed;
      size1 = new Size(32, 23);
      Size size147 = size1;
      btnEditOnDisturbed2.Size = size147;
      btnEditOnDisturbed.TabIndex = 11;
      btnEditOnDisturbed.Text = "Edit";
      btnEditOnDisturbed.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDamaged1 = btnEditOnDamaged;
      point1 = new Point(342, 162);
      Point point149 = point1;
      btnEditOnDamaged1.Location = point149;
      btnEditOnDamaged.Name = "btnEditOnDamaged";
      Button btnEditOnDamaged2 = btnEditOnDamaged;
      size1 = new Size(32, 23);
      Size size148 = size1;
      btnEditOnDamaged2.Size = size148;
      btnEditOnDamaged.TabIndex = 9;
      btnEditOnDamaged.Text = "Edit";
      btnEditOnDamaged.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnAttacked1 = btnEditOnAttacked;
      point1 = new Point(342, 132);
      Point point150 = point1;
      btnEditOnAttacked1.Location = point150;
      btnEditOnAttacked.Name = "btnEditOnAttacked";
      Button btnEditOnAttacked2 = btnEditOnAttacked;
      size1 = new Size(32, 23);
      Size size149 = size1;
      btnEditOnAttacked2.Size = size149;
      btnEditOnAttacked.TabIndex = 7;
      btnEditOnAttacked.Text = "Edit";
      btnEditOnAttacked.TextAlign = ContentAlignment.MiddleLeft;
      Label label34_1 = Label34;
      point1 = new Point(30, 102);
      Point point151 = point1;
      label34_1.Location = point151;
      Label34.Name = "Label34";
      Label label34_2 = Label34;
      size1 = new Size(84, 18);
      Size size150 = size1;
      label34_2.Size = size150;
      Label34.TabIndex = 5;
      Label34.Text = "OnSpellAt";
      Label34.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnSpellAt1 = tbOnSpellAt;
      point1 = new Point(114, 102);
      Point point152 = point1;
      tbOnSpellAt1.Location = point152;
      tbOnSpellAt.Name = "tbOnSpellAt";
      TextBox tbOnSpellAt2 = tbOnSpellAt;
      size1 = new Size(204, 20);
      Size size151 = size1;
      tbOnSpellAt2.Size = size151;
      tbOnSpellAt.TabIndex = 4;
      tbOnSpellAt.Text = "";
      Label label33_1 = Label33;
      point1 = new Point(30, 72);
      Point point153 = point1;
      label33_1.Location = point153;
      Label33.Name = "Label33";
      Label label33_2 = Label33;
      size1 = new Size(84, 18);
      Size size152 = size1;
      label33_2.Size = size152;
      Label33.TabIndex = 3;
      Label33.Text = "OnNotice";
      Label33.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnNotice1 = tbOnNotice;
      point1 = new Point(114, 72);
      Point point154 = point1;
      tbOnNotice1.Location = point154;
      tbOnNotice.Name = "tbOnNotice";
      TextBox tbOnNotice2 = tbOnNotice;
      size1 = new Size(204, 20);
      Size size153 = size1;
      tbOnNotice2.Size = size153;
      tbOnNotice.TabIndex = 2;
      tbOnNotice.Text = "";
      Label label32_1 = Label32;
      point1 = new Point(30, 42);
      Point point155 = point1;
      label32_1.Location = point155;
      Label32.Name = "Label32";
      Label label32_2 = Label32;
      size1 = new Size(84, 18);
      Size size154 = size1;
      label32_2.Size = size154;
      Label32.TabIndex = 1;
      Label32.Text = "OnHeartbeat";
      Label32.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnHeartbeat1 = tbOnHeartbeat;
      point1 = new Point(114, 42);
      Point point156 = point1;
      tbOnHeartbeat1.Location = point156;
      tbOnHeartbeat.Name = "tbOnHeartbeat";
      TextBox tbOnHeartbeat2 = tbOnHeartbeat;
      size1 = new Size(204, 20);
      Size size155 = size1;
      tbOnHeartbeat2.Size = size155;
      tbOnHeartbeat.TabIndex = 0;
      tbOnHeartbeat.Text = "";
      Label label35_1 = Label35;
      point1 = new Point(30, 132);
      Point point157 = point1;
      label35_1.Location = point157;
      Label35.Name = "Label35";
      Label label35_2 = Label35;
      size1 = new Size(84, 18);
      Size size156 = size1;
      label35_2.Size = size156;
      Label35.TabIndex = 5;
      Label35.Text = "OnAttacked";
      Label35.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnAttacked1 = tbOnAttacked;
      point1 = new Point(114, 132);
      Point point158 = point1;
      tbOnAttacked1.Location = point158;
      tbOnAttacked.Name = "tbOnAttacked";
      TextBox tbOnAttacked2 = tbOnAttacked;
      size1 = new Size(204, 20);
      Size size157 = size1;
      tbOnAttacked2.Size = size157;
      tbOnAttacked.TabIndex = 6;
      tbOnAttacked.Text = "";
      TextBox tbOnDamaged1 = tbOnDamaged;
      point1 = new Point(114, 162);
      Point point159 = point1;
      tbOnDamaged1.Location = point159;
      tbOnDamaged.Name = "tbOnDamaged";
      TextBox tbOnDamaged2 = tbOnDamaged;
      size1 = new Size(204, 20);
      Size size158 = size1;
      tbOnDamaged2.Size = size158;
      tbOnDamaged.TabIndex = 8;
      tbOnDamaged.Text = "";
      Label label36_1 = Label36;
      point1 = new Point(30, 162);
      Point point160 = point1;
      label36_1.Location = point160;
      Label36.Name = "Label36";
      Label label36_2 = Label36;
      size1 = new Size(84, 18);
      Size size159 = size1;
      label36_2.Size = size159;
      Label36.TabIndex = 5;
      Label36.Text = "OnDamaged";
      Label36.TextAlign = ContentAlignment.MiddleLeft;
      Label label37_1 = Label37;
      point1 = new Point(30, 192);
      Point point161 = point1;
      label37_1.Location = point161;
      Label37.Name = "Label37";
      Label label37_2 = Label37;
      size1 = new Size(84, 18);
      Size size160 = size1;
      label37_2.Size = size160;
      Label37.TabIndex = 5;
      Label37.Text = "OnDisturbed";
      Label37.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDisturbed1 = tbOnDisturbed;
      point1 = new Point(114, 192);
      Point point162 = point1;
      tbOnDisturbed1.Location = point162;
      tbOnDisturbed.Name = "tbOnDisturbed";
      TextBox tbOnDisturbed2 = tbOnDisturbed;
      size1 = new Size(204, 20);
      Size size161 = size1;
      tbOnDisturbed2.Size = size161;
      tbOnDisturbed.TabIndex = 10;
      tbOnDisturbed.Text = "";
      TextBox tbOnEndRound1 = tbOnEndRound;
      point1 = new Point(114, 222);
      Point point163 = point1;
      tbOnEndRound1.Location = point163;
      tbOnEndRound.Name = "tbOnEndRound";
      TextBox tbOnEndRound2 = tbOnEndRound;
      size1 = new Size(204, 20);
      Size size162 = size1;
      tbOnEndRound2.Size = size162;
      tbOnEndRound.TabIndex = 12;
      tbOnEndRound.Text = "";
      Label label38_1 = Label38;
      point1 = new Point(30, 222);
      Point point164 = point1;
      label38_1.Location = point164;
      Label38.Name = "Label38";
      Label label38_2 = Label38;
      size1 = new Size(84, 18);
      Size size163 = size1;
      label38_2.Size = size163;
      Label38.TabIndex = 5;
      Label38.Text = "OnEndRound";
      Label38.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnEndDialogu1 = tbOnEndDialogu;
      point1 = new Point(114, 252);
      Point point165 = point1;
      tbOnEndDialogu1.Location = point165;
      tbOnEndDialogu.Name = "tbOnEndDialogu";
      TextBox tbOnEndDialogu2 = tbOnEndDialogu;
      size1 = new Size(204, 20);
      Size size164 = size1;
      tbOnEndDialogu2.Size = size164;
      tbOnEndDialogu.TabIndex = 14;
      tbOnEndDialogu.Text = "";
      Label label39_1 = Label39;
      point1 = new Point(30, 252);
      Point point166 = point1;
      label39_1.Location = point166;
      Label39.Name = "Label39";
      Label label39_2 = Label39;
      size1 = new Size(84, 18);
      Size size165 = size1;
      label39_2.Size = size165;
      Label39.TabIndex = 5;
      Label39.Text = "OnEndDialogu";
      Label39.TextAlign = ContentAlignment.MiddleLeft;
      Label label40_1 = Label40;
      point1 = new Point(30, 282);
      Point point167 = point1;
      label40_1.Location = point167;
      Label40.Name = "Label40";
      Label label40_2 = Label40;
      size1 = new Size(84, 18);
      Size size166 = size1;
      label40_2.Size = size166;
      Label40.TabIndex = 5;
      Label40.Text = "OnDialogue";
      Label40.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDialogue1 = tbOnDialogue;
      point1 = new Point(114, 282);
      Point point168 = point1;
      tbOnDialogue1.Location = point168;
      tbOnDialogue.Name = "tbOnDialogue";
      TextBox tbOnDialogue2 = tbOnDialogue;
      size1 = new Size(204, 20);
      Size size167 = size1;
      tbOnDialogue2.Size = size167;
      tbOnDialogue.TabIndex = 16;
      tbOnDialogue.Text = "";
      Label label41_1 = Label41;
      point1 = new Point(30, 312);
      Point point169 = point1;
      label41_1.Location = point169;
      Label41.Name = "Label41";
      Label label41_2 = Label41;
      size1 = new Size(84, 18);
      Size size168 = size1;
      label41_2.Size = size168;
      Label41.TabIndex = 5;
      Label41.Text = "OnSpawn";
      Label41.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnSpawn1 = tbOnSpawn;
      point1 = new Point(114, 312);
      Point point170 = point1;
      tbOnSpawn1.Location = point170;
      tbOnSpawn.Name = "tbOnSpawn";
      TextBox tbOnSpawn2 = tbOnSpawn;
      size1 = new Size(204, 20);
      Size size169 = size1;
      tbOnSpawn2.Size = size169;
      tbOnSpawn.TabIndex = 18;
      tbOnSpawn.Text = "";
      TextBox tbOnRested1 = tbOnRested;
      point1 = new Point(114, 342);
      Point point171 = point1;
      tbOnRested1.Location = point171;
      tbOnRested.Name = "tbOnRested";
      TextBox tbOnRested2 = tbOnRested;
      size1 = new Size(204, 20);
      Size size170 = size1;
      tbOnRested2.Size = size170;
      tbOnRested.TabIndex = 20;
      tbOnRested.Text = "";
      Label label42_1 = Label42;
      point1 = new Point(30, 342);
      Point point172 = point1;
      label42_1.Location = point172;
      Label42.Name = "Label42";
      Label label42_2 = Label42;
      size1 = new Size(84, 18);
      Size size171 = size1;
      label42_2.Size = size171;
      Label42.TabIndex = 5;
      Label42.Text = "OnRested";
      Label42.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDeath1 = tbOnDeath;
      point1 = new Point(114, 372);
      Point point173 = point1;
      tbOnDeath1.Location = point173;
      tbOnDeath.Name = "tbOnDeath";
      TextBox tbOnDeath2 = tbOnDeath;
      size1 = new Size(204, 20);
      Size size172 = size1;
      tbOnDeath2.Size = size172;
      tbOnDeath.TabIndex = 22;
      tbOnDeath.Text = "";
      Label label43_1 = Label43;
      point1 = new Point(30, 372);
      Point point174 = point1;
      label43_1.Location = point174;
      Label43.Name = "Label43";
      Label label43_2 = Label43;
      size1 = new Size(84, 18);
      Size size173 = size1;
      label43_2.Size = size173;
      Label43.TabIndex = 5;
      Label43.Text = "OnDeath";
      Label43.TextAlign = ContentAlignment.MiddleLeft;
      Label label44_1 = Label44;
      point1 = new Point(30, 402);
      Point point175 = point1;
      label44_1.Location = point175;
      Label44.Name = "Label44";
      Label label44_2 = Label44;
      size1 = new Size(84, 18);
      Size size174 = size1;
      label44_2.Size = size174;
      Label44.TabIndex = 5;
      Label44.Text = "OnBlocked";
      Label44.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnBlocked1 = tbOnBlocked;
      point1 = new Point(114, 402);
      Point point176 = point1;
      tbOnBlocked1.Location = point176;
      tbOnBlocked.Name = "tbOnBlocked";
      TextBox tbOnBlocked2 = tbOnBlocked;
      size1 = new Size(204, 20);
      Size size175 = size1;
      tbOnBlocked2.Size = size175;
      tbOnBlocked.TabIndex = 24;
      tbOnBlocked.Text = "";
      TextBox tbOnUserDefine1 = tbOnUserDefine;
      point1 = new Point(114, 432);
      Point point177 = point1;
      tbOnUserDefine1.Location = point177;
      tbOnUserDefine.Name = "tbOnUserDefine";
      TextBox tbOnUserDefine2 = tbOnUserDefine;
      size1 = new Size(204, 20);
      Size size176 = size1;
      tbOnUserDefine2.Size = size176;
      tbOnUserDefine.TabIndex = 26;
      tbOnUserDefine.Text = "";
      Label label45_1 = Label45;
      point1 = new Point(30, 432);
      Point point178 = point1;
      label45_1.Location = point178;
      Label45.Name = "Label45";
      Label label45_2 = Label45;
      size1 = new Size(84, 18);
      Size size177 = size1;
      label45_2.Size = size177;
      Label45.TabIndex = 5;
      Label45.Text = "OnUserDefine";
      Label45.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnNotice1 = btnEditOnNotice;
      point1 = new Point(342, 72);
      Point point179 = point1;
      btnEditOnNotice1.Location = point179;
      btnEditOnNotice.Name = "btnEditOnNotice";
      Button btnEditOnNotice2 = btnEditOnNotice;
      size1 = new Size(32, 23);
      Size size178 = size1;
      btnEditOnNotice2.Size = size178;
      btnEditOnNotice.TabIndex = 3;
      btnEditOnNotice.Text = "Edit";
      btnEditOnNotice.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnSpellAt1 = btnEditOnSpellAt;
      point1 = new Point(342, 102);
      Point point180 = point1;
      btnEditOnSpellAt1.Location = point180;
      btnEditOnSpellAt.Name = "btnEditOnSpellAt";
      Button btnEditOnSpellAt2 = btnEditOnSpellAt;
      size1 = new Size(32, 23);
      Size size179 = size1;
      btnEditOnSpellAt2.Size = size179;
      btnEditOnSpellAt.TabIndex = 5;
      btnEditOnSpellAt.Text = "Edit";
      btnEditOnSpellAt.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnSpawn1 = btnEditOnSpawn;
      point1 = new Point(342, 312);
      Point point181 = point1;
      btnEditOnSpawn1.Location = point181;
      btnEditOnSpawn.Name = "btnEditOnSpawn";
      Button btnEditOnSpawn2 = btnEditOnSpawn;
      size1 = new Size(32, 23);
      Size size180 = size1;
      btnEditOnSpawn2.Size = size180;
      btnEditOnSpawn.TabIndex = 19;
      btnEditOnSpawn.Text = "Edit";
      btnEditOnSpawn.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDeath1 = btnEditOnDeath;
      point1 = new Point(342, 372);
      Point point182 = point1;
      btnEditOnDeath1.Location = point182;
      btnEditOnDeath.Name = "btnEditOnDeath";
      Button btnEditOnDeath2 = btnEditOnDeath;
      size1 = new Size(32, 23);
      Size size181 = size1;
      btnEditOnDeath2.Size = size181;
      btnEditOnDeath.TabIndex = 23;
      btnEditOnDeath.Text = "Edit";
      btnEditOnDeath.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnBlocked1 = btnEditOnBlocked;
      point1 = new Point(342, 402);
      Point point183 = point1;
      btnEditOnBlocked1.Location = point183;
      btnEditOnBlocked.Name = "btnEditOnBlocked";
      Button btnEditOnBlocked2 = btnEditOnBlocked;
      size1 = new Size(32, 23);
      Size size182 = size1;
      btnEditOnBlocked2.Size = size182;
      btnEditOnBlocked.TabIndex = 25;
      btnEditOnBlocked.Text = "Edit";
      btnEditOnBlocked.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnRested1 = btnEditOnRested;
      point1 = new Point(342, 342);
      Point point184 = point1;
      btnEditOnRested1.Location = point184;
      btnEditOnRested.Name = "btnEditOnRested";
      Button btnEditOnRested2 = btnEditOnRested;
      size1 = new Size(32, 23);
      Size size183 = size1;
      btnEditOnRested2.Size = size183;
      btnEditOnRested.TabIndex = 21;
      btnEditOnRested.Text = "Edit";
      btnEditOnRested.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnEndRound1 = btnEditOnEndRound;
      point1 = new Point(342, 222);
      Point point185 = point1;
      btnEditOnEndRound1.Location = point185;
      btnEditOnEndRound.Name = "btnEditOnEndRound";
      Button btnEditOnEndRound2 = btnEditOnEndRound;
      size1 = new Size(32, 23);
      Size size184 = size1;
      btnEditOnEndRound2.Size = size184;
      btnEditOnEndRound.TabIndex = 13;
      btnEditOnEndRound.Text = "Edit";
      btnEditOnEndRound.TextAlign = ContentAlignment.MiddleLeft;
      tpComments.Controls.Add(tbComments);
      TabPage tpComments1 = tpComments;
      point1 = new Point(4, 40);
      Point point186 = point1;
      ((Control) tpComments1).Location = point186;
      tpComments.Name = "tpComments";
      TabPage tpComments2 = tpComments;
      size1 = new Size(408, 492);
      Size size185 = size1;
      tpComments2.Size = size185;
      tpComments.TabIndex = 10;
      tpComments.Text = "Comments";
      TextBox tbComments1 = tbComments;
      point1 = new Point(24, 18);
      Point point187 = point1;
      tbComments1.Location = point187;
      tbComments.Multiline = true;
      tbComments.Name = "tbComments";
      TextBox tbComments2 = tbComments;
      size1 = new Size(354, 456);
      Size size186 = size1;
      tbComments2.Size = size186;
      tbComments.TabIndex = 0;
      tbComments.Text = "";
      btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel1 = btnCancel;
      point1 = new Point(328, 579);
      Point point188 = point1;
      btnCancel1.Location = point188;
      btnCancel.Name = "btnCancel";
      Button btnCancel2 = btnCancel;
      size1 = new Size(72, 24);
      Size size187 = size1;
      btnCancel2.Size = size187;
      btnCancel.TabIndex = 1;
      btnCancel.Text = "&Cancel";
      Button btnWriteFile1 = btnWriteFile;
      point1 = new Point(240, 579);
      Point point189 = point1;
      btnWriteFile1.Location = point189;
      btnWriteFile.Name = "btnWriteFile";
      Button btnWriteFile2 = btnWriteFile;
      size1 = new Size(72, 24);
      Size size188 = size1;
      btnWriteFile2.Size = size188;
      btnWriteFile.TabIndex = 1;
      btnWriteFile.Text = "&Save";
      Button btnInventory1 = btnInventory;
      point1 = new Point(64, 579);
      Point point190 = point1;
      btnInventory1.Location = point190;
      btnInventory.Name = "btnInventory";
      Button btnInventory2 = btnInventory;
      size1 = new Size(72, 24);
      Size size189 = size1;
      btnInventory2.Size = size189;
      btnInventory.TabIndex = 1;
      btnInventory.Text = "&Inventory";
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point191 = point1;
      btnDebug1.Location = point191;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size190 = size1;
      btnDebug2.Size = size190;
      btnDebug.TabIndex = 2;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      CancelButton = btnCancel;
      size1 = new Size(432, 613);
      ClientSize = size1;
      Controls.Add(btnDebug);
      Controls.Add(btnCancel);
      Controls.Add(tabCtrl1);
      Controls.Add(btnWriteFile);
      Controls.Add(btnInventory);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(440, 640);
      MaximumSize = size1;
      size1 = new Size(440, 640);
      MinimumSize = size1;
      Name = nameof (frmUTC_Editor);
      Text = "Creature Editor - KotOR ";
      tabCtrl1.ResumeLayout(false);
      tpBasic.ResumeLayout(false);
      GroupBox3.ResumeLayout(false);
      GroupBox2.ResumeLayout(false);
      GroupBox1.ResumeLayout(false);
      tpStatistics.ResumeLayout(false);
      GroupBox7.ResumeLayout(false);
      gb2.ResumeLayout(false);
      nudWillBonus.EndInit();
      nudFortBonus.EndInit();
      nudRefBonus.EndInit();
      GroupBox4.ResumeLayout(false);
      nudStrength.EndInit();
      nudDexterity.EndInit();
      nudConstitution.EndInit();
      nudIntelligence.EndInit();
      nudWisdom.EndInit();
      nudCharisma.EndInit();
      GroupBox6.ResumeLayout(false);
      nudNaturalAC.EndInit();
      GroupBox5.ResumeLayout(false);
      nudBaseHP.EndInit();
      nudCurrentHP.EndInit();
      nudMaxHP.EndInit();
      tpSkills.ResumeLayout(false);
      nudComputerUse.EndInit();
      nudDemolitions.EndInit();
      nudStealth.EndInit();
      nudAwareness.EndInit();
      nudPersuade.EndInit();
      nudRepair.EndInit();
      nudSecurity.EndInit();
      nudTreatInjury.EndInit();
      tpAdvanced.ResumeLayout(false);
      GroupBox12.ResumeLayout(false);
      GroupBox11.ResumeLayout(false);
      nudMultiplierSet.EndInit();
      nudBlindSpot.EndInit();
      GroupBox13.ResumeLayout(false);
      GroupBox14.ResumeLayout(false);
      GroupBox15.ResumeLayout(false);
      GroupBox18.ResumeLayout(false);
      tpFeats.ResumeLayout(false);
      GroupBox10.ResumeLayout(false);
      toForcePowers.ResumeLayout(false);
      GroupBox19.ResumeLayout(false);
      GroupBox17.ResumeLayout(false);
      GroupBox16.ResumeLayout(false);
      nudForcePoints.EndInit();
      nudCurrentForce.EndInit();
      tpClasses.ResumeLayout(false);
      GroupBox9.ResumeLayout(false);
      nudClassLevel.EndInit();
      GroupBox8.ResumeLayout(false);
      nudAlignment.EndInit();
      trkbarAlignment.EndInit();
      tpSpecialAbilities.ResumeLayout(false);
      GroupBox20.ResumeLayout(false);
      tpScripts.ResumeLayout(false);
      tpComments.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmUTC_Editor(
    clsUTC UTCClass,
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
      MDefaultTitleText = "Creature Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      g_clsDialogTlk = new clsDialogTlk(CurrentSettings.KotorLocation(KotorVerIndex) + "\\dialog.tlk");
      UTC = UTCClass;
      KotorVersionIndex = KotorVerIndex;
      IntegerType.FromObject(UTC.GetNodeValue("Color_Skin"));
      Setup();
    }

  public bool IsSaveGameMode
  {
    get => m_bSaveGameMode;
    set => m_bSaveGameMode = value;
  }

  public void Setup()
  {
      ChitinKey chitinKey = new ChitinKey(CurrentSettings.KeyFileLocation(KotorVersionIndex));
      BuildComboBoxes(chitinKey);
      UTC.SetTextBoxFromCExoLocStringNodeValue(tbFirstName, "FirstName");
      UTC.SetTextBoxFromCExoLocStringNodeValue(tbLastName, "LastName");
      UTC.SetTextBoxToNodeValue(tbTag, "Tag");
      UTC.SetTextBoxToNodeValue(tbConversation, "Conversation");
      chkbNotInterruptable.Checked = BooleanType.FromObject(ObjectType.NotObj(ObjectType.ObjTst(UTC.GetNodeValue("Interruptable"), 1, false) == 0));
      UTC.SetTextBoxFromCExoLocStringNodeValue(tbDescription, "Description");
      UTC.SetNumericUpDownToNodeValue(nudStrength, "Str");
      UTC.SetNumericUpDownToNodeValue(nudIntelligence, "Int");
      UTC.SetNumericUpDownToNodeValue(nudWisdom, "Wis");
      UTC.SetNumericUpDownToNodeValue(nudDexterity, "Dex");
      UTC.SetNumericUpDownToNodeValue(nudConstitution, "Con");
      UTC.SetNumericUpDownToNodeValue(nudCharisma, "Cha");
      UTC.SetNumericUpDownToNodeValue(nudFortBonus, "fortbonus");
      UTC.SetNumericUpDownToNodeValue(nudRefBonus, "refbonus");
      UTC.SetNumericUpDownToNodeValue(nudWillBonus, "willbonus");
      UTC.SetNumericUpDownToNodeValue(nudNaturalAC, "NaturalAC");
      UTC.SetNumericUpDownToNodeValue(nudBaseHP, "HitPoints");
      UTC.SetNumericUpDownToNodeValue(nudMaxHP, "MaxHitPoints");
      UTC.SetNumericUpDownToNodeValue(nudCurrentHP, "CurrentHitPoints");
      UTC.SetNumericUpDownToNodeValue(nudAlignment, "GoodEvil");
      trkbarAlignment.Value = IntegerType.FromObject(UTC.GetNodeValue("GoodEvil"));
      UTC.SetNumericUpDownToNodeValue(nudClassLevel, "ClassList(0).ClassLevel");
      UTC.SetNumericUpDownToNodeValue(nudComputerUse, "SkillList(0).Rank");
      UTC.SetNumericUpDownToNodeValue(nudDemolitions, "SkillList(1).Rank");
      UTC.SetNumericUpDownToNodeValue(nudStealth, "SkillList(2).Rank");
      UTC.SetNumericUpDownToNodeValue(nudAwareness, "SkillList(3).Rank");
      UTC.SetNumericUpDownToNodeValue(nudPersuade, "SkillList(4).Rank");
      UTC.SetNumericUpDownToNodeValue(nudRepair, "SkillList(5).Rank");
      UTC.SetNumericUpDownToNodeValue(nudSecurity, "SkillList(6).Rank");
      UTC.SetNumericUpDownToNodeValue(nudTreatInjury, "SkillList(7).Rank");
      UTC.SetTextBoxToNodeValue(tbOnAttacked, "ScriptAttacked");
      UTC.SetTextBoxToNodeValue(tbOnBlocked, "ScriptOnBlocked");
      UTC.SetTextBoxToNodeValue(tbOnDamaged, "ScriptDamaged");
      UTC.SetTextBoxToNodeValue(tbOnDeath, "ScriptDeath");
      UTC.SetTextBoxToNodeValue(tbOnDialogue, "ScriptDialogue");
      UTC.SetTextBoxToNodeValue(tbOnDisturbed, "ScriptDisturbed");
      UTC.SetTextBoxToNodeValue(tbOnEndDialogu, "ScriptEndDialogu");
      UTC.SetTextBoxToNodeValue(tbOnEndRound, "ScriptEndRound");
      UTC.SetTextBoxToNodeValue(tbOnHeartbeat, "ScriptHeartbeat");
      UTC.SetTextBoxToNodeValue(tbOnNotice, "ScriptOnNotice");
      UTC.SetTextBoxToNodeValue(tbOnRested, "ScriptRested");
      UTC.SetTextBoxToNodeValue(tbOnSpawn, "ScriptSpawn");
      UTC.SetTextBoxToNodeValue(tbOnSpellAt, "ScriptSpellAt");
      UTC.SetTextBoxToNodeValue(tbOnUserDefine, "ScriptUserDefine");
      FillChkListBoxFrom2DA(chklbFeats, "name", "feat", chitinKey, g_clsDialogTlk);
      int num1 = checked (UTC.GetListItemCount("FeatList") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        chklbFeats.SetItemChecked(Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTC.GetNodeValue("FeatList(" + StringType.FromInteger(num2) + ").Feat"))), true);
        checked { ++num2; }
      }
      FillSpecialAbilitiesChkListBoxFrom2DA(chklbSpecialAbilities, chitinKey, g_clsDialogTlk);
      UTC.SetNumericUpDownToNodeValue(nudForcePoints, "ForcePoints");
      UTC.SetNumericUpDownToNodeValue(nudCurrentForce, "CurrentForce");
      FillSpellsChkListBoxFrom2DA(chklbForcePowers, chitinKey, g_clsDialogTlk);
      Cls2Da cls2Da = ReadCls2DA("spells", chitinKey);
      int num3 = checked (UTC.GetListItemCount("ClassList(0).KnownList0") - 1);
      int num4 = 0;
      while (num4 <= num3)
      {
        int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTC.GetNodeValue("ClassList(0).KnownList0(" + StringType.FromInteger(num4) + ").Spell")));
        object indiceData = cls2Da.GetIndiceData(int32, "usertype");
        if (BooleanType.FromObject(!BooleanType.FromObject(Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData))) || !BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(indiceData, 1, false) == 0, ObjectType.ObjTst(indiceData, -2, false) == 0), ObjectType.ObjTst(indiceData, 6, false) == 0)) ? false : (object) true))
          chklbForcePowers.SetItemChecked(g_ForcePowerList.IndexOf(int32), true);
        checked { ++num4; }
      }
      UTC.SetTextBoxToNodeValue(tbChallengeRating, "ChallengeRating");
      chkbDisarmable.Checked = BooleanType.FromObject(UTC.GetNodeValue("Disarmable"));
      chkbPlot.Checked = BooleanType.FromObject(UTC.GetNodeValue("Plot"));
      chkbNoPermDeath.Checked = BooleanType.FromObject(UTC.GetNodeValue("NoPermDeath"));
      chkbMin1HP.Checked = BooleanType.FromObject(UTC.GetNodeValue("Min1HP"));
      chkbIsPC.Checked = BooleanType.FromObject(UTC.GetNodeValue("IsPC"));
      UTC.SetTextBoxToNodeValue(tbDeity, "Deity");
      if (UTC.VerifyNodeExists("TemplateResRef"))
      {
        UTC.SetTextBoxToNodeValue(tbTemplateResRef, "TemplateResRef");
        SyncPerceptionRangeComboBox();
      }
      if (KotorVersionIndex == 1)
      {
        lblBlindSpot.Visible = true;
        lblMultiplierSet.Visible = true;
        nudBlindSpot.Visible = true;
        nudMultiplierSet.Visible = true;
        chkbIsHologram.Visible = true;
        chkbNotReorienting.Visible = true;
        chkbIgnoreCrePath.Visible = true;
        UTC.SetNumericUpDownToNodeValue(nudBlindSpot, "BlindSpot");
        UTC.SetNumericUpDownToNodeValue(nudMultiplierSet, "MultiplierSet");
        chkbIgnoreCrePath.Checked = BooleanType.FromObject(UTC.GetNodeValue("IgnoreCrePath"));
        chkbIsHologram.Checked = BooleanType.FromObject(UTC.GetNodeValue("Hologram"));
        chkbNotReorienting.Checked = BooleanType.FromObject(UTC.GetNodeValue("NotReorienting"));
      }
      UTC.SetTextBoxToNodeValue(tbComments, "Comment");
      if (!ComboBoxSettingError)
        return;
      int num5 = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
    }

  private object BuildComboBoxes(ChitinKey chitin)
  {
      FillComboBoxFrom2DA(cmbxAppearance, "label", "appearance", chitin, null);
      if (!UTC.SyncComboBox(cmbxAppearance, "Appearance_Type"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxFaction, "label", "repute", chitin, null);
      if (!UTC.SyncComboBox(cmbxFaction, "FactionID"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxBodyBag, "label", "bodybag", chitin, null);
      if (!UTC.SyncComboBox(cmbxBodyBag, "BodyBag"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxGender, "name", "gender", chitin, g_clsDialogTlk);
      if (!UTC.SyncComboBox(cmbxGender, "Gender"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxRace, "name", "racialtypes", chitin, g_clsDialogTlk);
      if (!UTC.SyncComboBox(cmbxRace, "Race"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxPhenotype, "label", "phenotype", chitin, null);
      if (!UTC.SyncComboBox(cmbxPhenotype, "Phenotype"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxMovementRate, "label", "creaturespeed", chitin, null);
      if (UTC.VerifyNodeExists("WalkRate") && !UTC.SyncComboBox(cmbxMovementRate, "WalkRate"))
        ComboBoxSettingError = true;
      if (UTC.VerifyNodeExists("MovementRate") && !UTC.SyncComboBox(cmbxMovementRate, "MovementRate"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxClass, "name", "classes", chitin, g_clsDialogTlk);
      if (!UTC.SyncComboBox(cmbxClass, "ClassList(0).Class"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxSubrace, "label", "subrace", chitin, null);
      if (!UTC.SyncComboBox(cmbxSubrace, "SubraceIndex"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxSoundSet, "label", "soundset", chitin, g_clsDialogTlk);
      if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTC.GetNodeValue("SoundSetFile"))) == ushort.MaxValue)
        cmbxSoundSet.SelectedIndex = 0;
      else if (!UTC.SyncComboBox(cmbxSoundSet, "SoundSetFile"))
        ComboBoxSettingError = true;
      FillComboBoxFrom2DA(cmbxPortrait, "baseresref", "portraits", chitin, null);
      if (!UTC.SyncComboBox(cmbxPortrait, "PortraitId"))
        ComboBoxSettingError = true;
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

  private void SyncPerceptionRangeComboBox()
  {
      object objectValue = RuntimeHelpers.GetObjectValue(UTC.GetNodeValue("PerceptionRange"));
      if (objectValue == null)
        return;
      cmbxPerceptionRange.SelectedIndex = checked (Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) - 9);
    }

  private void FillChkListBoxFrom2DA(
    CheckedListBox lbx,
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
            lbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData)));
          else
            lbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData));
          checked { ++rowNumber; }
        }
      }
      else
      {
        int rowsUpperBound = cls2Da.RowsUpperBound;
        int rowNumber = 0;
        while (rowNumber <= rowsUpperBound)
        {
          lbx.Items.Add(cls2Da.GetIndiceData(rowNumber, colName));
          checked { ++rowNumber; }
        }
      }
    }

  private void FillSpellsChkListBoxFrom2DA(
    CheckedListBox lbx,
    ChitinKey ChitinKey,
    clsDialogTlk DialogTlk)
  {
      Cls2Da cls2Da = ReadCls2DA("spells", ChitinKey);
      int rowsUpperBound = cls2Da.RowsUpperBound;
      int rowNumber = 0;
      while (rowNumber <= rowsUpperBound)
      {
        object indiceData1 = cls2Da.GetIndiceData(rowNumber, "usertype");
        if (BooleanType.FromObject(!BooleanType.FromObject(Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData1))) || !BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(indiceData1, 1, false) == 0, ObjectType.ObjTst(indiceData1, -2, false) == 0), ObjectType.ObjTst(indiceData1, 6, false) == 0)) ? false : (object) true))
        {
          object indiceData2 = cls2Da.GetIndiceData(rowNumber, "name");
          if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData2)))
          {
            lbx.Items.Add(DialogTlk.GetString(IntegerType.FromObject(indiceData2)));
            g_ForcePowerList.Add(rowNumber);
          }
        }
        checked { ++rowNumber; }
      }
    }

  private void FillSpecialAbilitiesChkListBoxFrom2DA(
    CheckedListBox lbx,
    ChitinKey ChitinKey,
    clsDialogTlk DialogTlk)
  {
      ArrayList arrayList = new ArrayList();
      Cls2Da cls2Da = ReadCls2DA("spells", ChitinKey);
      int rowsUpperBound = cls2Da.RowsUpperBound;
      int num = 0;
      while (num <= rowsUpperBound)
      {
        object indiceData1 = cls2Da.GetIndiceData(num, "usertype");
        if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData1)) && ObjectType.ObjTst(indiceData1, 2, false) == 0)
        {
          object indiceData2 = cls2Da.GetIndiceData(num, "name");
          string str = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData2)) ? StringType.FromObject(indiceData2) : DialogTlk.GetString(IntegerType.FromObject(indiceData2));
          if (StringType.StrCmp(str, "****", false) != 0)
            arrayList.Add(new ComboBoxListItem(num, str));
        }
        checked { ++num; }
      }
      lbx.DataSource = arrayList;
      lbx.DisplayMember = "Text";
      lbx.ValueMember = "TwoDAIndex";
    }

  private void trkbarAlignment_Scroll(object sender, EventArgs e) => nudAlignment.Value = new Decimal(((TrackBar) sender).Value);

  private void nudAlignment_ValueChanged(object sender, EventArgs e) => trkbarAlignment.Value = Convert.ToInt32(((NumericUpDown) sender).Value);

  private void chklbForcePowers_MouseMove(object sender, MouseEventArgs e)
  {
      tbForcePowerSummary.Clear();
      try
      {
        foreach (object checkedItem in chklbForcePowers.CheckedItems)
        {
          string str = StringType.FromObject(checkedItem);
          TextBox forcePowerSummary = tbForcePowerSummary;
          forcePowerSummary.Text = forcePowerSummary.Text + str + "\r\n";
        }
      }
      finally
      {
       
      }
    }

  private void chklbFeats_MouseMove(object sender, MouseEventArgs e)
  {
      this.tbFeatSummary.Clear();
      try
      {
        foreach (object checkedItem in chklbFeats.CheckedItems)
        {
          string str = StringType.FromObject(checkedItem);
          TextBox tbFeatSummary = this.tbFeatSummary;
          tbFeatSummary.Text = tbFeatSummary.Text + str + "\r\n";
        }
      }
      finally
      {
      
      }
    }

  public object UTCFileData
  {
    set => UTC = (clsUTC) value;
  }

  private void SetGFFNodeValues()
  {
      UTC.SetCExoLocStringNodeValueFromTextBox(tbFirstName, "FirstName");
      SetNodeValueFromTextBox(tbTag, "Tag");
      SetNodeValueFromTextBox(tbConversation, "Conversation");
      UTC.SetNodeValue("Interruptable", (byte) (!chkbNotInterruptable.Checked ? 1 : 0));
      UTC.SetCExoLocStringNodeValueFromTextBox(tbDescription, "Description");
      SetNodeValueFromComboBox(cmbxRace, "Race");
      SetNodeValueFromComboBox(cmbxAppearance, "Appearance_Type");
      SetNodeValueFromComboBox(cmbxGender, "Gender");
      SetNodeValueFromComboBox(cmbxPhenotype, "Phenotype");
      SetNodeValueFromComboBox(cmbxBodyBag, "BodyBag");
      SetNodeValueFromNumericUpDown(nudStrength, "Str");
      SetNodeValueFromNumericUpDown(nudIntelligence, "Int");
      SetNodeValueFromNumericUpDown(nudWisdom, "Wis");
      SetNodeValueFromNumericUpDown(nudDexterity, "Dex");
      SetNodeValueFromNumericUpDown(nudConstitution, "Con");
      SetNodeValueFromNumericUpDown(nudCharisma, "Cha");
      SetNodeValueFromNumericUpDown(nudFortBonus, "fortbonus");
      SetNodeValueFromNumericUpDown(nudRefBonus, "refbonus");
      SetNodeValueFromNumericUpDown(nudWillBonus, "willbonus");
      SetNodeValueFromNumericUpDown(nudNaturalAC, "NaturalAC");
      SetNodeValueFromNumericUpDown(nudBaseHP, "HitPoints");
      SetNodeValueFromNumericUpDown(nudMaxHP, "MaxHitPoints");
      SetNodeValueFromNumericUpDown(nudCurrentHP, "CurrentHitPoints");
      if (UTC.VerifyNodeExists("WalkRate"))
        SetNodeValueFromComboBox(cmbxMovementRate, "WalkRate");
      if (UTC.VerifyNodeExists("MovementRate"))
        SetNodeValueFromComboBox(cmbxMovementRate, "MovementRate");
      SetNodeValueFromNumericUpDown(nudAlignment, "GoodEvil");
      SetNodeValueFromNumericUpDown(nudClassLevel, "ClassList(0).ClassLevel");
      SetNodeValueFromComboBox(cmbxClass, "ClassList(0).Class");
      SetNodeValueFromNumericUpDown(nudComputerUse, "SkillList(0).Rank");
      SetNodeValueFromNumericUpDown(nudDemolitions, "SkillList(1).Rank");
      SetNodeValueFromNumericUpDown(nudStealth, "SkillList(2).Rank");
      SetNodeValueFromNumericUpDown(nudAwareness, "SkillList(3).Rank");
      SetNodeValueFromNumericUpDown(nudPersuade, "SkillList(4).Rank");
      SetNodeValueFromNumericUpDown(nudRepair, "SkillList(5).Rank");
      SetNodeValueFromNumericUpDown(nudSecurity, "SkillList(6).Rank");
      SetNodeValueFromNumericUpDown(nudTreatInjury, "SkillList(7).Rank");
      SetNodeValueFromTextBox(tbOnAttacked, "ScriptAttacked");
      SetNodeValueFromTextBox(tbOnBlocked, "ScriptOnBlocked");
      SetNodeValueFromTextBox(tbOnDamaged, "ScriptDamaged");
      SetNodeValueFromTextBox(tbOnDeath, "ScriptDeath");
      SetNodeValueFromTextBox(tbOnDialogue, "ScriptDialogue");
      SetNodeValueFromTextBox(tbOnDisturbed, "ScriptDisturbed");
      SetNodeValueFromTextBox(tbOnEndDialogu, "ScriptEndDialogu");
      SetNodeValueFromTextBox(tbOnEndRound, "ScriptEndRound");
      SetNodeValueFromTextBox(tbOnHeartbeat, "ScriptHeartbeat");
      SetNodeValueFromTextBox(tbOnNotice, "ScriptOnNotice");
      SetNodeValueFromTextBox(tbOnRested, "ScriptRested");
      SetNodeValueFromTextBox(tbOnSpawn, "ScriptSpawn");
      SetNodeValueFromTextBox(tbOnSpellAt, "ScriptSpellAt");
      SetNodeValueFromTextBox(tbOnUserDefine, "ScriptUserDefine");
      UTC.ClearListElements("FeatList");
      try
      {
        foreach (object checkedIndex in chklbFeats.CheckedIndices)
        {
          int FieldValue = IntegerType.FromObject(checkedIndex);
          GffStruct @struct = new GffStruct();
          @struct.type = 1;
          @struct.fieldCount = 1;
          @struct.fields = new GFF_Field[1];
          @struct.fields[0] = new GFF_Field(GFFField.GFF_word, "Feat", FieldValue);
          UTC.AddListElement("FeatList", @struct);
        }
      }
      finally
      {
       
      }
      SetNodeValueFromNumericUpDown(nudForcePoints, "ForcePoints");
      SetNodeValueFromNumericUpDown(nudCurrentForce, "CurrentForce");
      UTC.ClearListElements("ClassList(0).KnownList0");
      try
      {
        foreach (object checkedIndex in chklbForcePowers.CheckedIndices)
        {
          int index = IntegerType.FromObject(checkedIndex);
          GffStruct @struct = new GffStruct();
          @struct.type = 3;
          @struct.fieldCount = 3;
          @struct.fields = new GFF_Field[3];
          int FieldValue = IntegerType.FromObject(g_ForcePowerList[index]);
          @struct.fields[0] = new GFF_Field(GFFField.GFF_word, "Spell", FieldValue);
          @struct.fields[1] = new GFF_Field(GFFField.GFF_byte, "SpellMetaMagic", 0);
          @struct.fields[2] = new GFF_Field(GFFField.GFF_byte, "SpellFlags", 1);
          UTC.AddListElement("ClassList(0).KnownList0", @struct);
        }
      }
      finally
      {
      
      }
      if (UTC.VerifyNodeExists("TemplateResRef"))
        SetNodeValueFromTextBox(tbTemplateResRef, "TemplateResRef");
      SetNodeValueFromComboBox(cmbxSubrace, "Subrace");
      if (cmbxSoundSet.SelectedIndex == 0)
        UTC.SetNodeValue("SoundSetFile", (int) ushort.MaxValue);
      else
        SetNodeValueFromComboBox(cmbxSoundSet, "SoundSetFile");
      SetNodeValueFromTextBox(tbDeity, "Deity");
      SetNodeValueFromComboBox(cmbxFaction, "FactionID");
      UTC.SetNodeValue("Disarmable", chkbDisarmable.Checked);
      UTC.SetNodeValue("Plot", chkbPlot.Checked);
      UTC.SetNodeValue("Min1HP", chkbMin1HP.Checked);
      UTC.SetNodeValue("IsPC", chkbIsPC.Checked);
      if (UTC.VerifyNodeExists("NoPermDeath"))
        UTC.SetNodeValue("NoPermDeath", chkbNoPermDeath.Checked);
      UTC.SetNodeValue("ChallengeRating", SingleType.FromString(tbChallengeRating.Text));
      if (UTC.VerifyNodeExists("PerceptionRange"))
        SetPerceptionRangeNodeValueFromComboBox();
      if (KotorVersionIndex == 1)
      {
        if (!UTC.VerifyNodeExists("BlindSpot"))
          UTC.AddSimpleField("BlindSpot", GFFField.GFF_float, nudBlindSpot.Value);
        else
          UTC.SetNodeValueFromNumericUpDown(nudBlindSpot, "BlindSpot");
        if (!UTC.VerifyNodeExists("MultiplierSet"))
          UTC.AddSimpleField("MultiplierSet", GFFField.GFF_byte, nudMultiplierSet.Value);
        else
          UTC.SetNodeValueFromNumericUpDown(nudMultiplierSet, "MultiplierSet");
        if (!UTC.VerifyNodeExists("IgnoreCrePath"))
          UTC.AddSimpleField("IgnoreCrePath", GFFField.GFF_byte, chkbIgnoreCrePath.Checked);
        else
          UTC.SetNodeValue("IgnoreCrePath", chkbIgnoreCrePath.Checked);
        if (!UTC.VerifyNodeExists("Hologram"))
          UTC.AddSimpleField("Hologram", GFFField.GFF_byte, chkbIsHologram.Checked);
        else
          UTC.SetNodeValue("Hologram", chkbIsHologram.Checked);
        if (!UTC.VerifyNodeExists("NotReorienting"))
          UTC.AddSimpleField("NotReorienting", GFFField.GFF_byte, chkbNotReorienting.Checked);
        else
          UTC.SetNodeValue("NotReorienting", chkbNotReorienting.Checked);
      }
      if (!UTC.VerifyNodeExists("Comment"))
        return;
      SetNodeValueFromTextBox(tbComments, "Comment");
    }

  private void SetNodeValueFromNumericUpDown(NumericUpDown NUD, string NodePath) => UTC.SetNodeValue(NodePath, NUD.Value);

  private void SetNodeValueFromTextBox(TextBox TB, string NodePath) => UTC.SetNodeValue(NodePath, TB.Text);

  private void SetNodeValueFromComboBox(ComboBox cmbx, string NodePath) => UTC.SetNodeValue(NodePath, cmbx.SelectedIndex);

  private void SetPerceptionRangeNodeValueFromComboBox() => UTC.SetNodeValue("PerceptionRange", checked (cmbxPerceptionRange.SelectedIndex + 9));

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  private void btnWriteFile_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".utc", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTC.WriteFile(MEditingFilePath, "UTC");
      if (!m_bSaveGameMode)
        return;
      Close();
    }

  private void Button2_Click(object sender, EventArgs e)
  {
      GffStruct @struct = new GffStruct();
      @struct.type = 3;
      @struct.fieldCount = 3;
      @struct.fields = new GFF_Field[3];
      @struct.fields[0] = new GFF_Field(GFFField.GFF_word, "Spell", 99);
      @struct.fields[1] = new GFF_Field(GFFField.GFF_byte, "SpellMetaMagic", 1);
      @struct.fields[2] = new GFF_Field(GFFField.GFF_byte, "SpellFlags", 2);
      UTC.AddListElement("ClassList(0).KnownList0", @struct);
    }

  private void btnInventory_Click(object sender, EventArgs e)
  {
      frmInventoryEditor frmInventoryEditor = new frmInventoryEditor(KotorVersionIndex);
      int num1 = checked (UTC.GetListItemCount("ItemList") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        string ResRef = StringType.FromObject(UTC.GetNodeValue("ItemList(" + StringType.FromInteger(num2) + ").InventoryRes"));
        bool Dropable = !UTC.VerifyNodeExists("ItemList(" + StringType.FromInteger(num2) + ").Dropable") || ObjectType.ObjTst(UTC.GetNodeValue("ItemList(" + StringType.FromInteger(num2) + ").Dropable"), 1, false) == 0;
        frmInventoryEditor.AddPackItem(ResRef, Dropable);
        checked { ++num2; }
      }
      int num3 = checked (UTC.GetListItemCount("Equip_ItemList") - 1);
      int num4 = 0;
      while (num4 <= num3)
      {
        string ResRef = StringType.FromObject(UTC.GetNodeValue("Equip_ItemList(" + StringType.FromInteger(num4) + ").EquippedRes"));
        int structFieldType = UTC.GetStructFieldType("Equip_ItemList(" + StringType.FromInteger(num4) + ")");
        bool Dropable = !UTC.VerifyNodeExists("Equip_ItemList(" + StringType.FromInteger(num4) + ").Dropable") || ObjectType.ObjTst(UTC.GetNodeValue("Equip_ItemList(" + StringType.FromInteger(num4) + ").Dropable"), 1, false) == 0;
        frmInventoryEditor.AddEquippedItem(ResRef, structFieldType, Dropable);
        checked { ++num4; }
      }
      frmInventoryEditor.SetFormName(tbTemplateResRef.Text + ".utc");
      if (frmInventoryEditor.ShowDialog() != DialogResult.OK)
        return;
      int FieldValue1 = 0;
      UTC.ClearListElements("ItemList");
      try
      {
        foreach (InventoryItem packItems in frmInventoryEditor.GetPackItemsList())
        {
          int quantity = packItems._Quantity;
          int num5 = 1;
          while (num5 <= quantity)
          {
            GffStruct @struct = new GffStruct();
            @struct.type = FieldValue1;
            @struct.fieldCount = 4;
            @struct.fields = new GFF_Field[4];
            @struct.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "InventoryRes", packItems._ResRef);
            @struct.fields[1] = new GFF_Field(GFFField.GFF_word, "Repos_PosX", FieldValue1);
            @struct.fields[2] = new GFF_Field(GFFField.GFF_word, "Repos_PosY", 0);
            byte FieldValue2 = !packItems._Dropable ? (byte) 0 : (byte) 1;
            @struct.fields[3] = new GFF_Field(GFFField.GFF_byte, "Dropable", FieldValue2);
            if (!UTC.VerifyNodeExists("ItemList"))
              UTC.CreateList("", "ItemList");
            UTC.AddListElement("ItemList", @struct);
            checked { ++FieldValue1; }
            checked { ++num5; }
          }
        }
      }
      finally
      {
       
      }
      UTC.ClearListElements("Equip_ItemList");
      try
      {
        foreach (InventoryItem equippedItems in frmInventoryEditor.GetEquippedItemsList())
        {
          if (equippedItems._ResRef != null)
          {
            GffStruct @struct = new GffStruct();
            @struct.type = IntegerType.FromString(equippedItems._EquipableSlots);
            @struct.fieldCount = 2;
            @struct.fields = new GFF_Field[2];
            @struct.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "EquippedRes", equippedItems._ResRef);
            byte FieldValue3 = !equippedItems._Dropable ? (byte) 0 : (byte) 1;
            @struct.fields[1] = new GFF_Field(GFFField.GFF_byte, "Dropable", FieldValue3);
            if (!UTC.VerifyNodeExists("Equip_ItemList"))
              UTC.CreateList("", "Equip_ItemList");
            UTC.AddListElement("Equip_ItemList", @struct);
          }
        }
      }
      finally
      {
      
      }
    }

  private void btnSelectAllPowers_Click(object sender, EventArgs e)
  {
      int num = checked (chklbForcePowers.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        chklbForcePowers.SetItemChecked(index, true);
        checked { ++index; }
      }
    }

  private void btnClearAllPowers_Click(object sender, EventArgs e)
  {
      int num = checked (chklbForcePowers.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        chklbForcePowers.SetItemChecked(index, false);
        checked { ++index; }
      }
    }

  private void frmUTC_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmUTC_Editor_Closing(object sender, CancelEventArgs e) => SaveSettings(GetType().Name);

  public void SetFormName(string Name) => Text = "Creature Editor - " + Name;

  private void btnDebug_Click(object sender, EventArgs e)
  {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = tbTag.Text;
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTC.ToString();
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

  private void btnEditScript_Click(object sender, EventArgs e) => Utils.EditScriptForTextBox((Button) sender, MEditingFilePath, KotorVersionIndex);
}