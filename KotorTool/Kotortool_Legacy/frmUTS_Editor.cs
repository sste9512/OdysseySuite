// Decompiled with JetBrains decompiler
// Type: kotor_tool.frmUTS_Editor
// Assembly: kotor_tool, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\kotor_tool.exe

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using Kotortool_Legacy.API;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Timer = System.Timers.Timer;

namespace Kotortool_Legacy;

public class frmUTS_Editor : frmParent
{
  [AccessedThroughProperty("chkb7a")]
  private CheckBox _chkb7a;
  [AccessedThroughProperty("chkb2p")]
  private CheckBox _chkb2p;
  [AccessedThroughProperty("GroupBox5")]
  private GroupBox _GroupBox5;
  [AccessedThroughProperty("chkb5a")]
  private CheckBox _chkb5a;
  [AccessedThroughProperty("GroupBox6")]
  private GroupBox _GroupBox6;
  [AccessedThroughProperty("chkb6a")]
  private CheckBox _chkb6a;
  [AccessedThroughProperty("chkb4a")]
  private CheckBox _chkb4a;
  [AccessedThroughProperty("chkb10p")]
  private CheckBox _chkb10p;
  [AccessedThroughProperty("btnSetNameLang")]
  private Button _btnSetNameLang;
  [AccessedThroughProperty("chkb3p")]
  private CheckBox _chkb3p;
  [AccessedThroughProperty("chkb3a")]
  private CheckBox _chkb3a;
  [AccessedThroughProperty("tbVolume")]
  private TextBox _tbVolume;
  [AccessedThroughProperty("tbName")]
  private TextBox _tbName;
  [AccessedThroughProperty("nudMinDistance")]
  private NumericUpDown _nudMinDistance;
  [AccessedThroughProperty("btnDebug")]
  private Button _btnDebug;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("tbVolumeVrtn")]
  private TextBox _tbVolumeVrtn;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("nudMaxDistance")]
  private NumericUpDown _nudMaxDistance;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("trkbarVolume")]
  private TrackBar _trkbarVolume;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("btnRemoveSound")]
  private Button _btnRemoveSound;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("btnAddSound")]
  private Button _btnAddSound;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("chkb9p")]
  private CheckBox _chkb9p;
  [AccessedThroughProperty("pnlVolPitch")]
  private Panel _pnlVolPitch;
  [AccessedThroughProperty("chkb11p")]
  private CheckBox _chkb11p;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("chkb11a")]
  private CheckBox _chkb11a;
  [AccessedThroughProperty("chkb9a")]
  private CheckBox _chkb9a;
  [AccessedThroughProperty("rbLooping")]
  private RadioButton _rbLooping;
  [AccessedThroughProperty("chkb10a")]
  private CheckBox _chkb10a;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("pnlHours")]
  private Panel _pnlHours;
  [AccessedThroughProperty("chkb8a")]
  private CheckBox _chkb8a;
  [AccessedThroughProperty("nudRandomRangeX")]
  private NumericUpDown _nudRandomRangeX;
  [AccessedThroughProperty("nudRandomRangeY")]
  private NumericUpDown _nudRandomRangeY;
  [AccessedThroughProperty("Timer1")]
  private Timer _Timer1;
  [AccessedThroughProperty("nudElevation")]
  private NumericUpDown _nudElevation;
  [AccessedThroughProperty("chkb7p")]
  private CheckBox _chkb7p;
  [AccessedThroughProperty("tbPitchVrtn")]
  private TextBox _tbPitchVrtn;
  [AccessedThroughProperty("TabControl1")]
  private TabControl _TabControl1;
  [AccessedThroughProperty("lblAM")]
  private Label _lblAM;
  [AccessedThroughProperty("lblPM")]
  private Label _lblPM;
  [AccessedThroughProperty("lbl12")]
  private Label _lbl12;
  [AccessedThroughProperty("trkbarPitchVrtn")]
  private TrackBar _trkbarPitchVrtn;
  [AccessedThroughProperty("nudIntervalVrtn")]
  private NumericUpDown _nudIntervalVrtn;
  [AccessedThroughProperty("nudInterval")]
  private NumericUpDown _nudInterval;
  [AccessedThroughProperty("gbInterval")]
  private GroupBox _gbInterval;
  [AccessedThroughProperty("rbRandom")]
  private RadioButton _rbRandom;
  [AccessedThroughProperty("rbSequential")]
  private RadioButton _rbSequential;
  [AccessedThroughProperty("rbRepeating")]
  private RadioButton _rbRepeating;
  [AccessedThroughProperty("chkb5p")]
  private CheckBox _chkb5p;
  [AccessedThroughProperty("rbOnce")]
  private RadioButton _rbOnce;
  [AccessedThroughProperty("trkbarVolumeVrtn")]
  private TrackBar _trkbarVolumeVrtn;
  [AccessedThroughProperty("rbPlaySpecificHours")]
  private RadioButton _rbPlaySpecificHours;
  [AccessedThroughProperty("rbPlayAllTimes")]
  private RadioButton _rbPlayAllTimes;
  [AccessedThroughProperty("rbPlayNight")]
  private RadioButton _rbPlayNight;
  [AccessedThroughProperty("rbPlayDay")]
  private RadioButton _rbPlayDay;
  [AccessedThroughProperty("btnPlaySound")]
  private Button _btnPlaySound;
  [AccessedThroughProperty("chkb6p")]
  private CheckBox _chkb6p;
  [AccessedThroughProperty("btnStopSound")]
  private Button _btnStopSound;
  [AccessedThroughProperty("chkb4p")]
  private CheckBox _chkb4p;
  [AccessedThroughProperty("PictureBox3")]
  private PictureBox _PictureBox3;
  [AccessedThroughProperty("PictureBox2")]
  private PictureBox _PictureBox2;
  [AccessedThroughProperty("lbSounds")]
  private ListBox _lbSounds;
  [AccessedThroughProperty("gbRandomRange")]
  private GroupBox _gbRandomRange;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("chkb1a")]
  private CheckBox _chkb1a;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("chkb2a")]
  private CheckBox _chkb2a;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("chkb12a")]
  private CheckBox _chkb12a;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("chkb12p")]
  private CheckBox _chkb12p;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("chkb1p")]
  private CheckBox _chkb1p;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("gbVolumeDistances")]
  private GroupBox _gbVolumeDistances;
  [AccessedThroughProperty("tbSoundStatus")]
  private TextBox _tbSoundStatus;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("gbHeight")]
  private GroupBox _gbHeight;
  [AccessedThroughProperty("chkbActive")]
  private CheckBox _chkbActive;
  [AccessedThroughProperty("tabpagAdvanced")]
  private TabPage _tabpagAdvanced;
  [AccessedThroughProperty("tbapagPositioning")]
  private TabPage _tbapagPositioning;
  [AccessedThroughProperty("tabpagBasic")]
  private TabPage _tabpagBasic;
  [AccessedThroughProperty("rbSpecificPosition")]
  private RadioButton _rbSpecificPosition;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("rbRandomPosition")]
  private RadioButton _rbRandomPosition;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("rbPlaysEverywhere")]
  private RadioButton _rbPlaysEverywhere;
  [AccessedThroughProperty("PictureBox1")]
  private PictureBox _PictureBox1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("btnMoveUp")]
  private Button _btnMoveUp;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnMoveDown")]
  private Button _btnMoveDown;
  [AccessedThroughProperty("tbComment")]
  private TextBox _tbComment;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;
  [AccessedThroughProperty("chkb8p")]
  private CheckBox _chkb8p;
  [AccessedThroughProperty("tbTag")]
  private TextBox _tbTag;
  private IContainer components;
  public clsUTS UTS;
  private int NameLang;
  private bool m_bSaveGameMode;
  public string g_ProjectPath;
  private FMOD.System fmSystem;
  private RESULT result;
  private uint FMODversion;
  private Sound sound1;
  private Channel channel;
  private string SoundsBifPath;
  private bool IsItemSelected;
  private Hashtable htBIFSounds;
  private Hashtable htStreamSounds;
  private BiffVarRsrcEntryInfo[] SoundsResInfo;

  public event StoppedPlayingEventHandler StoppedPlaying;

  public frmUTS_Editor()
  {
      Load += new EventHandler(frmUTS_Editor_Load);
      Closing += new CancelEventHandler(frmUTS_Editor_Closing);
      m_bSaveGameMode = false;
      fmSystem = null;
      sound1 = null;
      channel = null;
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

  internal virtual Button btnMoveUp
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnMoveUp != null)
          _btnMoveUp.Click -= new EventHandler(btnMoveUp_Click);
        _btnMoveUp = value;
        if (_btnMoveUp == null)
          return;
        _btnMoveUp.Click += new EventHandler(btnMoveUp_Click);
      }
    get => _btnMoveUp;
  }

  internal virtual Button btnMoveDown
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnMoveDown != null)
          _btnMoveDown.Click -= new EventHandler(btnMoveDown_Click);
        _btnMoveDown = value;
        if (_btnMoveDown == null)
          return;
        _btnMoveDown.Click += new EventHandler(btnMoveDown_Click);
      }
    get => _btnMoveDown;
  }

  internal virtual Label Label4
  {
    get => _Label4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label4 == null)
          ;
        _Label4 = value;
        if (_Label4 == null)
          ;
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

  internal virtual ListBox lbSounds
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbSounds != null)
        {
          _lbSounds.SelectedIndexChanged -= new EventHandler(lbSounds_SelectedIndexChanged);
          _lbSounds.DoubleClick -= new EventHandler(lbSounds_DoubleClick);
        }
        _lbSounds = value;
        if (_lbSounds == null)
          return;
        _lbSounds.SelectedIndexChanged += new EventHandler(lbSounds_SelectedIndexChanged);
        _lbSounds.DoubleClick += new EventHandler(lbSounds_DoubleClick);
      }
    get => _lbSounds;
  }

  internal virtual RadioButton rbPlaysEverywhere
  {
    get => _rbPlaysEverywhere;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbPlaysEverywhere != null)
          _rbPlaysEverywhere.CheckedChanged -= new EventHandler(rbPlaysWhere_CheckedChanged);
        _rbPlaysEverywhere = value;
        if (_rbPlaysEverywhere == null)
          return;
        _rbPlaysEverywhere.CheckedChanged += new EventHandler(rbPlaysWhere_CheckedChanged);
      }
  }

  internal virtual RadioButton rbRandomPosition
  {
    get => _rbRandomPosition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbRandomPosition != null)
          _rbRandomPosition.CheckedChanged -= new EventHandler(rbPlaysWhere_CheckedChanged);
        _rbRandomPosition = value;
        if (_rbRandomPosition == null)
          return;
        _rbRandomPosition.CheckedChanged += new EventHandler(rbPlaysWhere_CheckedChanged);
      }
  }

  internal virtual RadioButton rbSpecificPosition
  {
    get => _rbSpecificPosition;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbSpecificPosition != null)
          _rbSpecificPosition.CheckedChanged -= new EventHandler(rbPlaysWhere_CheckedChanged);
        _rbSpecificPosition = value;
        if (_rbSpecificPosition == null)
          return;
        _rbSpecificPosition.CheckedChanged += new EventHandler(rbPlaysWhere_CheckedChanged);
      }
  }

  internal virtual TabPage tabpagBasic
  {
    get => _tabpagBasic;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagBasic == null)
          ;
        _tabpagBasic = value;
        if (_tabpagBasic == null)
          ;
      }
  }

  internal virtual TabPage tbapagPositioning
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbapagPositioning == null)
          ;
        _tbapagPositioning = value;
        if (_tbapagPositioning == null)
          ;
      }
    get => _tbapagPositioning;
  }

  internal virtual TabPage tabpagAdvanced
  {
    get => _tabpagAdvanced;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tabpagAdvanced == null)
          ;
        _tabpagAdvanced = value;
        if (_tabpagAdvanced == null)
          ;
      }
  }

  internal virtual GroupBox GroupBox4
  {
    get => _GroupBox4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox4 == null)
          ;
        _GroupBox4 = value;
        if (_GroupBox4 == null)
          ;
      }
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

  internal virtual GroupBox GroupBox6
  {
    get => _GroupBox6;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_GroupBox6 == null)
          ;
        _GroupBox6 = value;
        if (_GroupBox6 == null)
          ;
      }
  }

  internal virtual CheckBox chkbActive
  {
    get => _chkbActive;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkbActive == null)
          ;
        _chkbActive = value;
        if (_chkbActive == null)
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label7 == null)
          ;
        _Label7 = value;
        if (_Label7 == null)
          ;
      }
    get => _Label7;
  }

  internal virtual GroupBox gbHeight
  {
    get => _gbHeight;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gbHeight == null)
          ;
        _gbHeight = value;
        if (_gbHeight == null)
          ;
      }
  }

  internal virtual GroupBox gbVolumeDistances
  {
    get => _gbVolumeDistances;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gbVolumeDistances == null)
          ;
        _gbVolumeDistances = value;
        if (_gbVolumeDistances == null)
          ;
      }
  }

  internal virtual GroupBox gbRandomRange
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gbRandomRange == null)
          ;
        _gbRandomRange = value;
        if (_gbRandomRange == null)
          ;
      }
    get => _gbRandomRange;
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

  internal virtual PictureBox PictureBox1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_PictureBox1 == null)
          ;
        _PictureBox1 = value;
        if (_PictureBox1 == null)
          ;
      }
    get => _PictureBox1;
  }

  internal virtual PictureBox PictureBox2
  {
    get => _PictureBox2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_PictureBox2 == null)
          ;
        _PictureBox2 = value;
        if (_PictureBox2 == null)
          ;
      }
  }

  internal virtual PictureBox PictureBox3
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_PictureBox3 == null)
          ;
        _PictureBox3 = value;
        if (_PictureBox3 == null)
          ;
      }
    get => _PictureBox3;
  }

  internal virtual RadioButton rbPlayDay
  {
    get => _rbPlayDay;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbPlayDay != null)
          _rbPlayDay.CheckedChanged -= new EventHandler(rbPlayDay_CheckedChanged);
        _rbPlayDay = value;
        if (_rbPlayDay == null)
          return;
        _rbPlayDay.CheckedChanged += new EventHandler(rbPlayDay_CheckedChanged);
      }
  }

  internal virtual RadioButton rbPlayNight
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbPlayNight != null)
          _rbPlayNight.CheckedChanged -= new EventHandler(rbPlayDay_CheckedChanged);
        _rbPlayNight = value;
        if (_rbPlayNight == null)
          return;
        _rbPlayNight.CheckedChanged += new EventHandler(rbPlayDay_CheckedChanged);
      }
    get => _rbPlayNight;
  }

  internal virtual RadioButton rbPlayAllTimes
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbPlayAllTimes != null)
          _rbPlayAllTimes.CheckedChanged -= new EventHandler(rbPlayDay_CheckedChanged);
        _rbPlayAllTimes = value;
        if (_rbPlayAllTimes == null)
          return;
        _rbPlayAllTimes.CheckedChanged += new EventHandler(rbPlayDay_CheckedChanged);
      }
    get => _rbPlayAllTimes;
  }

  internal virtual RadioButton rbPlaySpecificHours
  {
    get => _rbPlaySpecificHours;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbPlaySpecificHours != null)
          _rbPlaySpecificHours.CheckedChanged -= new EventHandler(rbPlayDay_CheckedChanged);
        _rbPlaySpecificHours = value;
        if (_rbPlaySpecificHours == null)
          return;
        _rbPlaySpecificHours.CheckedChanged += new EventHandler(rbPlayDay_CheckedChanged);
      }
  }

  internal virtual TrackBar trkbarVolumeVrtn
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_trkbarVolumeVrtn != null)
          _trkbarVolumeVrtn.ValueChanged -= new EventHandler(trkbarVolumeVrtn_ValueChanged);
        _trkbarVolumeVrtn = value;
        if (_trkbarVolumeVrtn == null)
          return;
        _trkbarVolumeVrtn.ValueChanged += new EventHandler(trkbarVolumeVrtn_ValueChanged);
      }
    get => _trkbarVolumeVrtn;
  }

  internal virtual RadioButton rbOnce
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbOnce != null)
          _rbOnce.CheckedChanged -= new EventHandler(rbLooping_CheckedChanged);
        _rbOnce = value;
        if (_rbOnce == null)
          return;
        _rbOnce.CheckedChanged += new EventHandler(rbLooping_CheckedChanged);
      }
    get => _rbOnce;
  }

  internal virtual RadioButton rbRepeating
  {
    get => _rbRepeating;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbRepeating != null)
          _rbRepeating.CheckedChanged -= new EventHandler(rbLooping_CheckedChanged);
        _rbRepeating = value;
        if (_rbRepeating == null)
          return;
        _rbRepeating.CheckedChanged += new EventHandler(rbLooping_CheckedChanged);
      }
  }

  internal virtual RadioButton rbSequential
  {
    get => _rbSequential;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbSequential == null)
          ;
        _rbSequential = value;
        if (_rbSequential == null)
          ;
      }
  }

  internal virtual RadioButton rbRandom
  {
    get => _rbRandom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbRandom == null)
          ;
        _rbRandom = value;
        if (_rbRandom == null)
          ;
      }
  }

  internal virtual GroupBox gbInterval
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_gbInterval == null)
          ;
        _gbInterval = value;
        if (_gbInterval == null)
          ;
      }
    get => _gbInterval;
  }

  internal virtual NumericUpDown nudInterval
  {
    get => _nudInterval;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudInterval == null)
          ;
        _nudInterval = value;
        if (_nudInterval == null)
          ;
      }
  }

  internal virtual NumericUpDown nudIntervalVrtn
  {
    get => _nudIntervalVrtn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudIntervalVrtn == null)
          ;
        _nudIntervalVrtn = value;
        if (_nudIntervalVrtn == null)
          ;
      }
  }

  internal virtual TrackBar trkbarPitchVrtn
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_trkbarPitchVrtn != null)
          _trkbarPitchVrtn.ValueChanged -= new EventHandler(trkbarPitchVrtn_ValueChanged);
        _trkbarPitchVrtn = value;
        if (_trkbarPitchVrtn == null)
          return;
        _trkbarPitchVrtn.ValueChanged += new EventHandler(trkbarPitchVrtn_ValueChanged);
      }
    get => _trkbarPitchVrtn;
  }

  internal virtual Label lbl12
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lbl12 == null)
          ;
        _lbl12 = value;
        if (_lbl12 == null)
          ;
      }
    get => _lbl12;
  }

  internal virtual Label lblPM
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblPM == null)
          ;
        _lblPM = value;
        if (_lblPM == null)
          ;
      }
    get => _lblPM;
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

  internal virtual Label Label17
  {
    get => _Label17;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label17 == null)
          ;
        _Label17 = value;
        if (_Label17 == null)
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

  internal virtual Label Label24
  {
    get => _Label24;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Label24 == null)
          ;
        _Label24 = value;
        if (_Label24 == null)
          ;
      }
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

  internal virtual Label lblAM
  {
    get => _lblAM;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_lblAM == null)
          ;
        _lblAM = value;
        if (_lblAM == null)
          ;
      }
  }

  internal virtual TextBox tbPitchVrtn
  {
    get => _tbPitchVrtn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbPitchVrtn == null)
          ;
        _tbPitchVrtn = value;
        if (_tbPitchVrtn == null)
          ;
      }
  }

  internal virtual NumericUpDown nudElevation
  {
    get => _nudElevation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudElevation == null)
          ;
        _nudElevation = value;
        if (_nudElevation == null)
          ;
      }
  }

  internal virtual NumericUpDown nudRandomRangeY
  {
    get => _nudRandomRangeY;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudRandomRangeY == null)
          ;
        _nudRandomRangeY = value;
        if (_nudRandomRangeY == null)
          ;
      }
  }

  internal virtual NumericUpDown nudRandomRangeX
  {
    get => _nudRandomRangeX;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudRandomRangeX == null)
          ;
        _nudRandomRangeX = value;
        if (_nudRandomRangeX == null)
          ;
      }
  }

  internal virtual Panel pnlHours
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlHours == null)
          ;
        _pnlHours = value;
        if (_pnlHours == null)
          ;
      }
    get => _pnlHours;
  }

  internal virtual RadioButton rbLooping
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_rbLooping != null)
          _rbLooping.CheckedChanged -= new EventHandler(rbLooping_CheckedChanged);
        _rbLooping = value;
        if (_rbLooping == null)
          return;
        _rbLooping.CheckedChanged += new EventHandler(rbLooping_CheckedChanged);
      }
    get => _rbLooping;
  }

  internal virtual Panel pnlVolPitch
  {
    get => _pnlVolPitch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_pnlVolPitch == null)
          ;
        _pnlVolPitch = value;
        if (_pnlVolPitch == null)
          ;
      }
  }

  internal virtual Button btnAddSound
  {
    get => _btnAddSound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnAddSound != null)
          _btnAddSound.Click -= new EventHandler(btnAddSound_Click);
        _btnAddSound = value;
        if (_btnAddSound == null)
          return;
        _btnAddSound.Click += new EventHandler(btnAddSound_Click);
      }
  }

  internal virtual Button btnRemoveSound
  {
    get => _btnRemoveSound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnRemoveSound != null)
          _btnRemoveSound.Click -= new EventHandler(btnRemoveSound_Click);
        _btnRemoveSound = value;
        if (_btnRemoveSound == null)
          return;
        _btnRemoveSound.Click += new EventHandler(btnRemoveSound_Click);
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
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnCancel != null)
          _btnCancel.Click -= new EventHandler(btnCancel_Click);
        _btnCancel = value;
        if (_btnCancel == null)
          return;
        _btnCancel.Click += new EventHandler(btnCancel_Click);
      }
    get => _btnCancel;
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

  internal virtual TrackBar trkbarVolume
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_trkbarVolume != null)
          _trkbarVolume.ValueChanged -= new EventHandler(trkbarVolume_ValueChanged);
        _trkbarVolume = value;
        if (_trkbarVolume == null)
          return;
        _trkbarVolume.ValueChanged += new EventHandler(trkbarVolume_ValueChanged);
      }
    get => _trkbarVolume;
  }

  internal virtual NumericUpDown nudMaxDistance
  {
    get => _nudMaxDistance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudMaxDistance == null)
          ;
        _nudMaxDistance = value;
        if (_nudMaxDistance == null)
          ;
      }
  }

  internal virtual TextBox tbVolumeVrtn
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbVolumeVrtn == null)
          ;
        _tbVolumeVrtn = value;
        if (_tbVolumeVrtn == null)
          ;
      }
    get => _tbVolumeVrtn;
  }

  internal virtual NumericUpDown nudMinDistance
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_nudMinDistance == null)
          ;
        _nudMinDistance = value;
        if (_nudMinDistance == null)
          ;
      }
    get => _nudMinDistance;
  }

  internal virtual TextBox tbVolume
  {
    get => _tbVolume;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbVolume == null)
          ;
        _tbVolume = value;
        if (_tbVolume == null)
          ;
      }
  }

  internal virtual CheckBox chkb3a
  {
    get => _chkb3a;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb3a == null)
          ;
        _chkb3a = value;
        if (_chkb3a == null)
          ;
      }
  }

  internal virtual CheckBox chkb3p
  {
    get => _chkb3p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb3p == null)
          ;
        _chkb3p = value;
        if (_chkb3p == null)
          ;
      }
  }

  internal virtual CheckBox chkb10p
  {
    get => _chkb10p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb10p == null)
          ;
        _chkb10p = value;
        if (_chkb10p == null)
          ;
      }
  }

  internal virtual CheckBox chkb4a
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb4a == null)
          ;
        _chkb4a = value;
        if (_chkb4a == null)
          ;
      }
    get => _chkb4a;
  }

  internal virtual CheckBox chkb6a
  {
    get => _chkb6a;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb6a == null)
          ;
        _chkb6a = value;
        if (_chkb6a == null)
          ;
      }
  }

  internal virtual CheckBox chkb5a
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb5a == null)
          ;
        _chkb5a = value;
        if (_chkb5a == null)
          ;
      }
    get => _chkb5a;
  }

  internal virtual CheckBox chkb7a
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb7a == null)
          ;
        _chkb7a = value;
        if (_chkb7a == null)
          ;
      }
    get => _chkb7a;
  }

  internal virtual CheckBox chkb8p
  {
    get => _chkb8p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb8p == null)
          ;
        _chkb8p = value;
        if (_chkb8p == null)
          ;
      }
  }

  internal virtual CheckBox chkb2p
  {
    get => _chkb2p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb2p == null)
          ;
        _chkb2p = value;
        if (_chkb2p == null)
          ;
      }
  }

  internal virtual CheckBox chkb9p
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb9p == null)
          ;
        _chkb9p = value;
        if (_chkb9p == null)
          ;
      }
    get => _chkb9p;
  }

  internal virtual CheckBox chkb11p
  {
    get => _chkb11p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb11p == null)
          ;
        _chkb11p = value;
        if (_chkb11p == null)
          ;
      }
  }

  internal virtual CheckBox chkb11a
  {
    get => _chkb11a;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb11a == null)
          ;
        _chkb11a = value;
        if (_chkb11a == null)
          ;
      }
  }

  internal virtual CheckBox chkb9a
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb9a == null)
          ;
        _chkb9a = value;
        if (_chkb9a == null)
          ;
      }
    get => _chkb9a;
  }

  internal virtual CheckBox chkb10a
  {
    get => _chkb10a;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb10a == null)
          ;
        _chkb10a = value;
        if (_chkb10a == null)
          ;
      }
  }

  internal virtual CheckBox chkb8a
  {
    get => _chkb8a;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb8a == null)
          ;
        _chkb8a = value;
        if (_chkb8a == null)
          ;
      }
  }

  internal virtual CheckBox chkb7p
  {
    get => _chkb7p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb7p == null)
          ;
        _chkb7p = value;
        if (_chkb7p == null)
          ;
      }
  }

  internal virtual CheckBox chkb5p
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb5p == null)
          ;
        _chkb5p = value;
        if (_chkb5p == null)
          ;
      }
    get => _chkb5p;
  }

  internal virtual CheckBox chkb6p
  {
    get => _chkb6p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb6p == null)
          ;
        _chkb6p = value;
        if (_chkb6p == null)
          ;
      }
  }

  internal virtual CheckBox chkb4p
  {
    get => _chkb4p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb4p == null)
          ;
        _chkb4p = value;
        if (_chkb4p == null)
          ;
      }
  }

  internal virtual CheckBox chkb1a
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb1a == null)
          ;
        _chkb1a = value;
        if (_chkb1a == null)
          ;
      }
    get => _chkb1a;
  }

  internal virtual CheckBox chkb2a
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb2a == null)
          ;
        _chkb2a = value;
        if (_chkb2a == null)
          ;
      }
    get => _chkb2a;
  }

  internal virtual CheckBox chkb12a
  {
    get => _chkb12a;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb12a == null)
          ;
        _chkb12a = value;
        if (_chkb12a == null)
          ;
      }
  }

  internal virtual CheckBox chkb12p
  {
    get => _chkb12p;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb12p == null)
          ;
        _chkb12p = value;
        if (_chkb12p == null)
          ;
      }
  }

  internal virtual CheckBox chkb1p
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_chkb1p == null)
          ;
        _chkb1p = value;
        if (_chkb1p == null)
          ;
      }
    get => _chkb1p;
  }

  internal virtual Button btnPlaySound
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnPlaySound != null)
          _btnPlaySound.Click -= new EventHandler(btnPlaySound_Click);
        _btnPlaySound = value;
        if (_btnPlaySound == null)
          return;
        _btnPlaySound.Click += new EventHandler(btnPlaySound_Click);
      }
    get => _btnPlaySound;
  }

  internal virtual Timer Timer1
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_Timer1 != null)
          _Timer1.Tick -= new EventHandler(Timer1_Tick);
        _Timer1 = value;
        if (_Timer1 == null)
          return;
        _Timer1.Tick += new EventHandler(Timer1_Tick);
      }
    get => _Timer1;
  }

  internal virtual Button btnStopSound
  {
    get => _btnStopSound;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_btnStopSound != null)
          _btnStopSound.Click -= new EventHandler(btnStopSound_Click);
        _btnStopSound = value;
        if (_btnStopSound == null)
          return;
        _btnStopSound.Click += new EventHandler(btnStopSound_Click);
      }
  }

  internal virtual TextBox tbSoundStatus
  {
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
        if (_tbSoundStatus == null)
          ;
        _tbSoundStatus = value;
        if (_tbSoundStatus == null)
          ;
      }
    get => _tbSoundStatus;
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

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (frmUTS_Editor));
      TabControl1 = new TabControl();
      tabpagBasic = new TabPage();
      tbVolume = new TextBox();
      trkbarVolume = new TrackBar();
      btnAddSound = new Button();
      btnRemoveSound = new Button();
      btnMoveUp = new Button();
      btnMoveDown = new Button();
      lbSounds = new ListBox();
      tbComment = new TextBox();
      btnSetNameLang = new Button();
      tbTag = new TextBox();
      tbName = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      Label5 = new Label();
      btnPlaySound = new Button();
      btnStopSound = new Button();
      tbSoundStatus = new TextBox();
      Label26 = new Label();
      tbapagPositioning = new TabPage();
      gbHeight = new GroupBox();
      PictureBox2 = new PictureBox();
      nudElevation = new NumericUpDown();
      Label10 = new Label();
      gbVolumeDistances = new GroupBox();
      PictureBox1 = new PictureBox();
      Label8 = new Label();
      nudMaxDistance = new NumericUpDown();
      Label9 = new Label();
      nudMinDistance = new NumericUpDown();
      rbPlaysEverywhere = new RadioButton();
      rbRandomPosition = new RadioButton();
      rbSpecificPosition = new RadioButton();
      gbRandomRange = new GroupBox();
      PictureBox3 = new PictureBox();
      nudRandomRangeY = new NumericUpDown();
      nudRandomRangeX = new NumericUpDown();
      Label11 = new Label();
      Label12 = new Label();
      tabpagAdvanced = new TabPage();
      pnlVolPitch = new Panel();
      tbPitchVrtn = new TextBox();
      trkbarVolumeVrtn = new TrackBar();
      Label6 = new Label();
      Label7 = new Label();
      trkbarPitchVrtn = new TrackBar();
      tbVolumeVrtn = new TextBox();
      GroupBox4 = new GroupBox();
      rbPlayDay = new RadioButton();
      rbPlayNight = new RadioButton();
      rbPlayAllTimes = new RadioButton();
      rbPlaySpecificHours = new RadioButton();
      pnlHours = new Panel();
      chkb3a = new CheckBox();
      Label21 = new Label();
      Label20 = new Label();
      Label18 = new Label();
      chkb3p = new CheckBox();
      chkb10p = new CheckBox();
      chkb12p = new CheckBox();
      chkb1p = new CheckBox();
      chkb4a = new CheckBox();
      chkb6a = new CheckBox();
      chkb5a = new CheckBox();
      chkb7a = new CheckBox();
      Label25 = new Label();
      chkb8p = new CheckBox();
      chkb2p = new CheckBox();
      chkb9p = new CheckBox();
      chkb11p = new CheckBox();
      chkb11a = new CheckBox();
      chkb9a = new CheckBox();
      chkb10a = new CheckBox();
      chkb8a = new CheckBox();
      chkb7p = new CheckBox();
      chkb5p = new CheckBox();
      chkb6p = new CheckBox();
      chkb4p = new CheckBox();
      Label13 = new Label();
      chkb1a = new CheckBox();
      lblAM = new Label();
      lblPM = new Label();
      Label23 = new Label();
      Label24 = new Label();
      chkb2a = new CheckBox();
      lbl12 = new Label();
      Label17 = new Label();
      Label22 = new Label();
      Label14 = new Label();
      chkb12a = new CheckBox();
      Label19 = new Label();
      this.chkbActive = new CheckBox();
      GroupBox6 = new GroupBox();
      rbSequential = new RadioButton();
      rbRandom = new RadioButton();
      gbInterval = new GroupBox();
      Label16 = new Label();
      Label15 = new Label();
      nudInterval = new NumericUpDown();
      nudIntervalVrtn = new NumericUpDown();
      GroupBox5 = new GroupBox();
      rbOnce = new RadioButton();
      rbRepeating = new RadioButton();
      rbLooping = new RadioButton();
      this.btnSave = new Button();
      this.btnCancel = new Button();
      btnDebug = new Button();
      Timer1 = new Timer(components);
      TabControl1.SuspendLayout();
      tabpagBasic.SuspendLayout();
      trkbarVolume.BeginInit();
      tbapagPositioning.SuspendLayout();
      gbHeight.SuspendLayout();
      nudElevation.BeginInit();
      gbVolumeDistances.SuspendLayout();
      nudMaxDistance.BeginInit();
      nudMinDistance.BeginInit();
      gbRandomRange.SuspendLayout();
      nudRandomRangeY.BeginInit();
      nudRandomRangeX.BeginInit();
      tabpagAdvanced.SuspendLayout();
      pnlVolPitch.SuspendLayout();
      trkbarVolumeVrtn.BeginInit();
      trkbarPitchVrtn.BeginInit();
      GroupBox4.SuspendLayout();
      pnlHours.SuspendLayout();
      GroupBox6.SuspendLayout();
      gbInterval.SuspendLayout();
      nudInterval.BeginInit();
      nudIntervalVrtn.BeginInit();
      GroupBox5.SuspendLayout();
      SuspendLayout();
      TabControl1.Controls.Add(tabpagBasic);
      TabControl1.Controls.Add(tbapagPositioning);
      TabControl1.Controls.Add(tabpagAdvanced);
      TabControl tabControl1_1 = TabControl1;
      Point point1 = new Point(16, 8);
      Point point2 = point1;
      tabControl1_1.Location = point2;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = TabControl1;
      Size size1 = new Size(504, 504);
      Size size2 = size1;
      tabControl1_2.Size = size2;
      TabControl1.TabIndex = 0;
      tabpagBasic.Controls.Add(tbVolume);
      tabpagBasic.Controls.Add(trkbarVolume);
      tabpagBasic.Controls.Add(btnAddSound);
      tabpagBasic.Controls.Add(btnRemoveSound);
      tabpagBasic.Controls.Add(btnMoveUp);
      tabpagBasic.Controls.Add(btnMoveDown);
      tabpagBasic.Controls.Add(lbSounds);
      tabpagBasic.Controls.Add(tbComment);
      tabpagBasic.Controls.Add(btnSetNameLang);
      tabpagBasic.Controls.Add(tbTag);
      tabpagBasic.Controls.Add(tbName);
      tabpagBasic.Controls.Add(Label1);
      tabpagBasic.Controls.Add(Label2);
      tabpagBasic.Controls.Add(Label3);
      tabpagBasic.Controls.Add(Label4);
      tabpagBasic.Controls.Add(Label5);
      tabpagBasic.Controls.Add(btnPlaySound);
      tabpagBasic.Controls.Add(btnStopSound);
      tabpagBasic.Controls.Add(tbSoundStatus);
      tabpagBasic.Controls.Add(Label26);
      TabPage tabpagBasic1 = tabpagBasic;
      point1 = new Point(4, 22);
      Point point3 = point1;
      ((Control) tabpagBasic1).Location = point3;
      tabpagBasic.Name = "tabpagBasic";
      TabPage tabpagBasic2 = tabpagBasic;
      size1 = new Size(496, 478);
      Size size3 = size1;
      tabpagBasic2.Size = size3;
      tabpagBasic.TabIndex = 0;
      tabpagBasic.Text = "Basic";
      TextBox tbVolume1 = tbVolume;
      point1 = new Point(136, 424);
      Point point4 = point1;
      tbVolume1.Location = point4;
      tbVolume.Name = "tbVolume";
      tbVolume.ReadOnly = true;
      TextBox tbVolume2 = tbVolume;
      size1 = new Size(40, 20);
      Size size4 = size1;
      tbVolume2.Size = size4;
      tbVolume.TabIndex = 25;
      tbVolume.Text = "";
      TrackBar trkbarVolume1 = trkbarVolume;
      point1 = new Point(184, 424);
      Point point5 = point1;
      trkbarVolume1.Location = point5;
      trkbarVolume.Maximum = sbyte.MaxValue;
      trkbarVolume.Name = "trkbarVolume";
      TrackBar trkbarVolume2 = trkbarVolume;
      size1 = new Size(216, 42);
      Size size5 = size1;
      trkbarVolume2.Size = size5;
      trkbarVolume.TabIndex = 21;
      trkbarVolume.TickFrequency = 5;
      btnAddSound.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      Button btnAddSound1 = btnAddSound;
      point1 = new Point(328, 160);
      Point point6 = point1;
      btnAddSound1.Location = point6;
      btnAddSound.Name = "btnAddSound";
      Button btnAddSound2 = btnAddSound;
      size1 = new Size(80, 23);
      Size size6 = size1;
      btnAddSound2.Size = size6;
      btnAddSound.TabIndex = 19;
      btnAddSound.Text = "Add Sound...";
      btnRemoveSound.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnRemoveSound.Enabled = false;
      Button btnRemoveSound1 = btnRemoveSound;
      point1 = new Point(328, 192);
      Point point7 = point1;
      btnRemoveSound1.Location = point7;
      btnRemoveSound.Name = "btnRemoveSound";
      Button btnRemoveSound2 = btnRemoveSound;
      size1 = new Size(80, 23);
      Size size7 = size1;
      btnRemoveSound2.Size = size7;
      btnRemoveSound.TabIndex = 20;
      btnRemoveSound.Text = "Remove";
      btnMoveUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnMoveUp.Enabled = false;
      Button btnMoveUp1 = btnMoveUp;
      point1 = new Point(328, 320);
      Point point8 = point1;
      btnMoveUp1.Location = point8;
      btnMoveUp.Name = "btnMoveUp";
      Button btnMoveUp2 = btnMoveUp;
      size1 = new Size(80, 23);
      Size size8 = size1;
      btnMoveUp2.Size = size8;
      btnMoveUp.TabIndex = 17;
      btnMoveUp.Text = "Move Up";
      btnMoveDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnMoveDown.Enabled = false;
      Button btnMoveDown1 = btnMoveDown;
      point1 = new Point(328, 352);
      Point point9 = point1;
      btnMoveDown1.Location = point9;
      btnMoveDown.Name = "btnMoveDown";
      Button btnMoveDown2 = btnMoveDown;
      size1 = new Size(80, 23);
      Size size9 = size1;
      btnMoveDown2.Size = size9;
      btnMoveDown.TabIndex = 18;
      btnMoveDown.Text = "Move Down";
      ListBox lbSounds1 = lbSounds;
      point1 = new Point(136, 160);
      Point point10 = point1;
      lbSounds1.Location = point10;
      lbSounds.Name = "lbSounds";
      lbSounds.SelectionMode = SelectionMode.MultiExtended;
      ListBox lbSounds2 = lbSounds;
      size1 = new Size(144, 212);
      Size size10 = size1;
      lbSounds2.Size = size10;
      lbSounds.TabIndex = 16;
      TextBox tbComment1 = tbComment;
      point1 = new Point(136, 80);
      Point point11 = point1;
      tbComment1.Location = point11;
      tbComment.Multiline = true;
      tbComment.Name = "tbComment";
      TextBox tbComment2 = tbComment;
      size1 = new Size(272, 64);
      Size size11 = size1;
      tbComment2.Size = size11;
      tbComment.TabIndex = 15;
      tbComment.Text = "";
      Button btnSetNameLang1 = btnSetNameLang;
      point1 = new Point(344, 24);
      Point point12 = point1;
      btnSetNameLang1.Location = point12;
      btnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = btnSetNameLang;
      size1 = new Size(88, 23);
      Size size12 = size1;
      btnSetNameLang2.Size = size12;
      btnSetNameLang.TabIndex = 14;
      btnSetNameLang.Text = "Set Language";
      TextBox tbTag1 = tbTag;
      point1 = new Point(136, 48);
      Point point13 = point1;
      tbTag1.Location = point13;
      tbTag.Name = "tbTag";
      TextBox tbTag2 = tbTag;
      size1 = new Size(200, 20);
      Size size13 = size1;
      tbTag2.Size = size13;
      tbTag.TabIndex = 13;
      tbTag.Text = "";
      TextBox tbName1 = tbName;
      point1 = new Point(136, 24);
      Point point14 = point1;
      tbName1.Location = point14;
      tbName.Name = "tbName";
      TextBox tbName2 = tbName;
      size1 = new Size(200, 20);
      Size size14 = size1;
      tbName2.Size = size14;
      tbName.TabIndex = 12;
      tbName.Text = "";
      Label label1_1 = Label1;
      point1 = new Point(40, 24);
      Point point15 = point1;
      label1_1.Location = point15;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(100, 16);
      Size size15 = size1;
      label1_2.Size = size15;
      Label1.TabIndex = 10;
      Label1.Text = "Name";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      Label label2_1 = Label2;
      point1 = new Point(40, 48);
      Point point16 = point1;
      label2_1.Location = point16;
      Label2.Name = "Label2";
      Label label2_2 = Label2;
      size1 = new Size(100, 16);
      Size size16 = size1;
      label2_2.Size = size16;
      Label2.TabIndex = 11;
      Label2.Text = "Tag";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      Label label3_1 = Label3;
      point1 = new Point(40, 88);
      Point point17 = point1;
      label3_1.Location = point17;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(80, 16);
      Size size17 = size1;
      label3_2.Size = size17;
      Label3.TabIndex = 11;
      Label3.Text = "Comments";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      Label label4_1 = Label4;
      point1 = new Point(40, 160);
      Point point18 = point1;
      label4_1.Location = point18;
      Label4.Name = "Label4";
      Label label4_2 = Label4;
      size1 = new Size(88, 24);
      Size size18 = size1;
      label4_2.Size = size18;
      Label4.TabIndex = 11;
      Label4.Text = "Sounds to Play";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      Label label5_1 = Label5;
      point1 = new Point(40, 424);
      Point point19 = point1;
      label5_1.Location = point19;
      Label5.Name = "Label5";
      Label label5_2 = Label5;
      size1 = new Size(88, 16);
      Size size19 = size1;
      label5_2.Size = size19;
      Label5.TabIndex = 11;
      Label5.Text = "In-game Volume";
      Label5.TextAlign = ContentAlignment.MiddleLeft;
      btnPlaySound.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnPlaySound.Enabled = false;
      Button btnPlaySound1 = btnPlaySound;
      point1 = new Point(328, 240);
      Point point20 = point1;
      btnPlaySound1.Location = point20;
      btnPlaySound.Name = "btnPlaySound";
      Button btnPlaySound2 = btnPlaySound;
      size1 = new Size(80, 23);
      Size size20 = size1;
      btnPlaySound2.Size = size20;
      btnPlaySound.TabIndex = 19;
      btnPlaySound.Text = "Play Sound";
      btnStopSound.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnStopSound.Enabled = false;
      Button btnStopSound1 = btnStopSound;
      point1 = new Point(328, 272);
      Point point21 = point1;
      btnStopSound1.Location = point21;
      btnStopSound.Name = "btnStopSound";
      Button btnStopSound2 = btnStopSound;
      size1 = new Size(80, 23);
      Size size21 = size1;
      btnStopSound2.Size = size21;
      btnStopSound.TabIndex = 19;
      btnStopSound.Text = "Stop";
      tbSoundStatus.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
      TextBox tbSoundStatus1 = tbSoundStatus;
      point1 = new Point(136, 384);
      Point point22 = point1;
      tbSoundStatus1.Location = point22;
      tbSoundStatus.Name = "tbSoundStatus";
      tbSoundStatus.ReadOnly = true;
      TextBox tbSoundStatus2 = tbSoundStatus;
      size1 = new Size(144, 20);
      Size size22 = size1;
      tbSoundStatus2.Size = size22;
      tbSoundStatus.TabIndex = 25;
      tbSoundStatus.Text = "";
      tbSoundStatus.TextAlign = HorizontalAlignment.Right;
      Label label26_1 = Label26;
      point1 = new Point(40, 384);
      Point point23 = point1;
      label26_1.Location = point23;
      Label26.Name = "Label26";
      Label label26_2 = Label26;
      size1 = new Size(80, 16);
      Size size23 = size1;
      label26_2.Size = size23;
      Label26.TabIndex = 11;
      Label26.Text = "Time";
      Label26.TextAlign = ContentAlignment.MiddleLeft;
      tbapagPositioning.Controls.Add(gbHeight);
      tbapagPositioning.Controls.Add(gbVolumeDistances);
      tbapagPositioning.Controls.Add(rbPlaysEverywhere);
      tbapagPositioning.Controls.Add(rbRandomPosition);
      tbapagPositioning.Controls.Add(rbSpecificPosition);
      tbapagPositioning.Controls.Add(gbRandomRange);
      TabPage tbapagPositioning1 = tbapagPositioning;
      point1 = new Point(4, 22);
      Point point24 = point1;
      ((Control) tbapagPositioning1).Location = point24;
      tbapagPositioning.Name = "tbapagPositioning";
      TabPage tbapagPositioning2 = tbapagPositioning;
      size1 = new Size(496, 478);
      Size size24 = size1;
      tbapagPositioning2.Size = size24;
      tbapagPositioning.TabIndex = 1;
      tbapagPositioning.Text = "Positioning";
      gbHeight.Controls.Add(PictureBox2);
      gbHeight.Controls.Add(nudElevation);
      gbHeight.Controls.Add(Label10);
      GroupBox gbHeight1 = gbHeight;
      point1 = new Point(16, 248);
      Point point25 = point1;
      gbHeight1.Location = point25;
      gbHeight.Name = "gbHeight";
      GroupBox gbHeight2 = gbHeight;
      size1 = new Size(184, 176);
      Size size25 = size1;
      gbHeight2.Size = size25;
      gbHeight.TabIndex = 2;
      gbHeight.TabStop = false;
      gbHeight.Text = "Height (m)";
      PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
      PictureBox pictureBox2_1 = PictureBox2;
      point1 = new Point(8, 40);
      Point point26 = point1;
      pictureBox2_1.Location = point26;
      PictureBox2.Name = "PictureBox2";
      PictureBox pictureBox2_2 = PictureBox2;
      size1 = new Size(94, 96);
      Size size26 = size1;
      pictureBox2_2.Size = size26;
      PictureBox2.TabIndex = 3;
      PictureBox2.TabStop = false;
      nudElevation.DecimalPlaces = 1;
      NumericUpDown nudElevation1 = nudElevation;
      point1 = new Point(112, 72);
      Point point27 = point1;
      nudElevation1.Location = point27;
      NumericUpDown nudElevation2 = nudElevation;
      Decimal num1 = new Decimal(new int[4]
      {
        100,
        0,
        0,
        int.MinValue
      });
      Decimal num2 = num1;
      nudElevation2.Minimum = num2;
      nudElevation.Name = "nudElevation";
      NumericUpDown nudElevation3 = nudElevation;
      size1 = new Size(64, 20);
      Size size27 = size1;
      nudElevation3.Size = size27;
      nudElevation.TabIndex = 0;
      Label label10_1 = Label10;
      point1 = new Point(112, 56);
      Point point28 = point1;
      label10_1.Location = point28;
      Label10.Name = "Label10";
      Label label10_2 = Label10;
      size1 = new Size(64, 16);
      Size size28 = size1;
      label10_2.Size = size28;
      Label10.TabIndex = 2;
      Label10.Text = "Height (m)";
      gbVolumeDistances.Controls.Add(PictureBox1);
      gbVolumeDistances.Controls.Add(Label8);
      gbVolumeDistances.Controls.Add(nudMaxDistance);
      gbVolumeDistances.Controls.Add(Label9);
      gbVolumeDistances.Controls.Add(nudMinDistance);
      GroupBox gbVolumeDistances1 = gbVolumeDistances;
      point1 = new Point(16, 104);
      Point point29 = point1;
      gbVolumeDistances1.Location = point29;
      gbVolumeDistances.Name = "gbVolumeDistances";
      GroupBox gbVolumeDistances2 = gbVolumeDistances;
      size1 = new Size(408, 120);
      Size size29 = size1;
      gbVolumeDistances2.Size = size29;
      gbVolumeDistances.TabIndex = 1;
      gbVolumeDistances.TabStop = false;
      gbVolumeDistances.Text = "Volume Distances";
      PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = PictureBox1;
      point1 = new Point(8, 24);
      Point point30 = point1;
      pictureBox1_1.Location = point30;
      PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = PictureBox1;
      size1 = new Size(90, 82);
      Size size30 = size1;
      pictureBox1_2.Size = size30;
      PictureBox1.TabIndex = 3;
      PictureBox1.TabStop = false;
      Label label8_1 = Label8;
      point1 = new Point(128, 16);
      Point point31 = point1;
      label8_1.Location = point31;
      Label8.Name = "Label8";
      Label label8_2 = Label8;
      size1 = new Size(100, 16);
      Size size31 = size1;
      label8_2.Size = size31;
      Label8.TabIndex = 2;
      Label8.Text = "Cutoff distance (m)";
      nudMaxDistance.DecimalPlaces = 1;
      NumericUpDown nudMaxDistance1 = nudMaxDistance;
      point1 = new Point(128, 32);
      Point point32 = point1;
      nudMaxDistance1.Location = point32;
      nudMaxDistance.Name = "nudMaxDistance";
      NumericUpDown nudMaxDistance2 = nudMaxDistance;
      size1 = new Size(64, 20);
      Size size32 = size1;
      nudMaxDistance2.Size = size32;
      nudMaxDistance.TabIndex = 0;
      Label label9_1 = Label9;
      point1 = new Point(128, 64);
      Point point33 = point1;
      label9_1.Location = point33;
      Label9.Name = "Label9";
      Label label9_2 = Label9;
      size1 = new Size(152, 16);
      Size size33 = size1;
      label9_2.Size = size33;
      Label9.TabIndex = 2;
      Label9.Text = "Max Volume distance (m)";
      nudMinDistance.DecimalPlaces = 1;
      NumericUpDown nudMinDistance1 = nudMinDistance;
      point1 = new Point(128, 80);
      Point point34 = point1;
      nudMinDistance1.Location = point34;
      nudMinDistance.Name = "nudMinDistance";
      NumericUpDown nudMinDistance2 = nudMinDistance;
      size1 = new Size(64, 20);
      Size size34 = size1;
      nudMinDistance2.Size = size34;
      nudMinDistance.TabIndex = 0;
      RadioButton rbPlaysEverywhere1 = rbPlaysEverywhere;
      point1 = new Point(24, 16);
      Point point35 = point1;
      rbPlaysEverywhere1.Location = point35;
      rbPlaysEverywhere.Name = "rbPlaysEverywhere";
      RadioButton rbPlaysEverywhere2 = rbPlaysEverywhere;
      size1 = new Size(160, 24);
      Size size35 = size1;
      rbPlaysEverywhere2.Size = size35;
      rbPlaysEverywhere.TabIndex = 0;
      rbPlaysEverywhere.Text = "Plays everywhere in area";
      RadioButton rbRandomPosition1 = rbRandomPosition;
      point1 = new Point(24, 40);
      Point point36 = point1;
      rbRandomPosition1.Location = point36;
      rbRandomPosition.Name = "rbRandomPosition";
      RadioButton rbRandomPosition2 = rbRandomPosition;
      size1 = new Size(288, 24);
      Size size36 = size1;
      rbRandomPosition2.Size = size36;
      rbRandomPosition.TabIndex = 0;
      rbRandomPosition.Text = "Plays from a random position each time it is played";
      rbSpecificPosition.Checked = true;
      RadioButton specificPosition1 = rbSpecificPosition;
      point1 = new Point(24, 64);
      Point point37 = point1;
      specificPosition1.Location = point37;
      rbSpecificPosition.Name = "rbSpecificPosition";
      RadioButton specificPosition2 = rbSpecificPosition;
      size1 = new Size(168, 24);
      Size size37 = size1;
      specificPosition2.Size = size37;
      rbSpecificPosition.TabIndex = 0;
      rbSpecificPosition.TabStop = true;
      rbSpecificPosition.Text = "Plays from a specific position";
      gbRandomRange.Controls.Add(PictureBox3);
      gbRandomRange.Controls.Add(nudRandomRangeY);
      gbRandomRange.Controls.Add(nudRandomRangeX);
      gbRandomRange.Controls.Add(Label11);
      gbRandomRange.Controls.Add(Label12);
      GroupBox gbRandomRange1 = gbRandomRange;
      point1 = new Point(208, 248);
      Point point38 = point1;
      gbRandomRange1.Location = point38;
      gbRandomRange.Name = "gbRandomRange";
      GroupBox gbRandomRange2 = gbRandomRange;
      size1 = new Size(280, 176);
      Size size38 = size1;
      gbRandomRange2.Size = size38;
      gbRandomRange.TabIndex = 2;
      gbRandomRange.TabStop = false;
      gbRandomRange.Text = "Random Range";
      PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
      PictureBox pictureBox3_1 = PictureBox3;
      point1 = new Point(8, 24);
      Point point39 = point1;
      pictureBox3_1.Location = point39;
      PictureBox3.Name = "PictureBox3";
      PictureBox pictureBox3_2 = PictureBox3;
      size1 = new Size(96, 95);
      Size size39 = size1;
      pictureBox3_2.Size = size39;
      PictureBox3.TabIndex = 3;
      PictureBox3.TabStop = false;
      nudRandomRangeY.DecimalPlaces = 1;
      NumericUpDown nudRandomRangeY1 = nudRandomRangeY;
      point1 = new Point(112, 40);
      Point point40 = point1;
      nudRandomRangeY1.Location = point40;
      nudRandomRangeY.Name = "nudRandomRangeY";
      NumericUpDown nudRandomRangeY2 = nudRandomRangeY;
      size1 = new Size(64, 20);
      Size size40 = size1;
      nudRandomRangeY2.Size = size40;
      nudRandomRangeY.TabIndex = 0;
      nudRandomRangeX.DecimalPlaces = 1;
      NumericUpDown nudRandomRangeX1 = nudRandomRangeX;
      point1 = new Point(16, 144);
      Point point41 = point1;
      nudRandomRangeX1.Location = point41;
      nudRandomRangeX.Name = "nudRandomRangeX";
      NumericUpDown nudRandomRangeX2 = nudRandomRangeX;
      size1 = new Size(64, 20);
      Size size41 = size1;
      nudRandomRangeX2.Size = size41;
      nudRandomRangeX.TabIndex = 0;
      Label label11_1 = Label11;
      point1 = new Point(112, 24);
      Point point42 = point1;
      label11_1.Location = point42;
      Label11.Name = "Label11";
      Label label11_2 = Label11;
      size1 = new Size(160, 16);
      Size size42 = size1;
      label11_2.Size = size42;
      Label11.TabIndex = 2;
      Label11.Text = "North-South Random Range (m)";
      Label label12_1 = Label12;
      point1 = new Point(16, 128);
      Point point43 = point1;
      label12_1.Location = point43;
      Label12.Name = "Label12";
      Label label12_2 = Label12;
      size1 = new Size(160, 16);
      Size size43 = size1;
      label12_2.Size = size43;
      Label12.TabIndex = 2;
      Label12.Text = "West-East Random Range (m)";
      tabpagAdvanced.Controls.Add(pnlVolPitch);
      tabpagAdvanced.Controls.Add(GroupBox4);
      tabpagAdvanced.Controls.Add(this.chkbActive);
      tabpagAdvanced.Controls.Add(GroupBox6);
      tabpagAdvanced.Controls.Add(gbInterval);
      tabpagAdvanced.Controls.Add(GroupBox5);
      TabPage tabpagAdvanced1 = tabpagAdvanced;
      point1 = new Point(4, 22);
      Point point44 = point1;
      ((Control) tabpagAdvanced1).Location = point44;
      tabpagAdvanced.Name = "tabpagAdvanced";
      TabPage tabpagAdvanced2 = tabpagAdvanced;
      size1 = new Size(496, 478);
      Size size44 = size1;
      tabpagAdvanced2.Size = size44;
      tabpagAdvanced.TabIndex = 2;
      tabpagAdvanced.Text = "Advanced";
      pnlVolPitch.Controls.Add(tbPitchVrtn);
      pnlVolPitch.Controls.Add(trkbarVolumeVrtn);
      pnlVolPitch.Controls.Add(Label6);
      pnlVolPitch.Controls.Add(Label7);
      pnlVolPitch.Controls.Add(trkbarPitchVrtn);
      pnlVolPitch.Controls.Add(tbVolumeVrtn);
      Panel pnlVolPitch1 = pnlVolPitch;
      point1 = new Point(8, 368);
      Point point45 = point1;
      pnlVolPitch1.Location = point45;
      pnlVolPitch.Name = "pnlVolPitch";
      Panel pnlVolPitch2 = pnlVolPitch;
      size1 = new Size(480, 104);
      Size size45 = size1;
      pnlVolPitch2.Size = size45;
      pnlVolPitch.TabIndex = 25;
      TextBox tbPitchVrtn1 = tbPitchVrtn;
      point1 = new Point(160, 64);
      Point point46 = point1;
      tbPitchVrtn1.Location = point46;
      tbPitchVrtn.Name = "tbPitchVrtn";
      tbPitchVrtn.ReadOnly = true;
      TextBox tbPitchVrtn2 = tbPitchVrtn;
      size1 = new Size(40, 20);
      Size size46 = size1;
      tbPitchVrtn2.Size = size46;
      tbPitchVrtn.TabIndex = 24;
      tbPitchVrtn.Text = "";
      TrackBar trkbarVolumeVrtn1 = trkbarVolumeVrtn;
      point1 = new Point(216, 8);
      Point point47 = point1;
      trkbarVolumeVrtn1.Location = point47;
      trkbarVolumeVrtn.Maximum = 100;
      trkbarVolumeVrtn.Name = "trkbarVolumeVrtn";
      TrackBar trkbarVolumeVrtn2 = trkbarVolumeVrtn;
      size1 = new Size(216, 42);
      Size size47 = size1;
      trkbarVolumeVrtn2.Size = size47;
      trkbarVolumeVrtn.TabIndex = 23;
      trkbarVolumeVrtn.TickFrequency = 5;
      Label label6_1 = Label6;
      point1 = new Point(24, 16);
      Point point48 = point1;
      label6_1.Location = point48;
      Label6.Name = "Label6";
      Label label6_2 = Label6;
      size1 = new Size(96, 16);
      Size size48 = size1;
      label6_2.Size = size48;
      Label6.TabIndex = 22;
      Label6.Text = "Volume Variation";
      Label6.TextAlign = ContentAlignment.MiddleLeft;
      Label label7_1 = Label7;
      point1 = new Point(24, 64);
      Point point49 = point1;
      label7_1.Location = point49;
      Label7.Name = "Label7";
      Label label7_2 = Label7;
      size1 = new Size(160, 24);
      Size size49 = size1;
      label7_2.Size = size49;
      Label7.TabIndex = 22;
      Label7.Text = "Pitch  Variation (octaves)";
      Label7.TextAlign = ContentAlignment.MiddleLeft;
      TrackBar trkbarPitchVrtn1 = trkbarPitchVrtn;
      point1 = new Point(216, 56);
      Point point50 = point1;
      trkbarPitchVrtn1.Location = point50;
      trkbarPitchVrtn.Maximum = 100;
      trkbarPitchVrtn.Name = "trkbarPitchVrtn";
      TrackBar trkbarPitchVrtn2 = trkbarPitchVrtn;
      size1 = new Size(216, 42);
      Size size50 = size1;
      trkbarPitchVrtn2.Size = size50;
      trkbarPitchVrtn.TabIndex = 23;
      trkbarPitchVrtn.TickFrequency = 5;
      TextBox tbVolumeVrtn1 = tbVolumeVrtn;
      point1 = new Point(160, 16);
      Point point51 = point1;
      tbVolumeVrtn1.Location = point51;
      tbVolumeVrtn.Name = "tbVolumeVrtn";
      tbVolumeVrtn.ReadOnly = true;
      TextBox tbVolumeVrtn2 = tbVolumeVrtn;
      size1 = new Size(40, 20);
      Size size51 = size1;
      tbVolumeVrtn2.Size = size51;
      tbVolumeVrtn.TabIndex = 24;
      tbVolumeVrtn.Text = "";
      GroupBox4.Controls.Add(rbPlayDay);
      GroupBox4.Controls.Add(rbPlayNight);
      GroupBox4.Controls.Add(rbPlayAllTimes);
      GroupBox4.Controls.Add(rbPlaySpecificHours);
      GroupBox4.Controls.Add(pnlHours);
      GroupBox groupBox4_1 = GroupBox4;
      point1 = new Point(8, 48);
      Point point52 = point1;
      groupBox4_1.Location = point52;
      GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = GroupBox4;
      size1 = new Size(472, 160);
      Size size52 = size1;
      groupBox4_2.Size = size52;
      GroupBox4.TabIndex = 1;
      GroupBox4.TabStop = false;
      GroupBox4.Text = "When to play";
      RadioButton rbPlayDay1 = rbPlayDay;
      point1 = new Point(40, 16);
      Point point53 = point1;
      rbPlayDay1.Location = point53;
      rbPlayDay.Name = "rbPlayDay";
      RadioButton rbPlayDay2 = rbPlayDay;
      size1 = new Size(128, 16);
      Size size53 = size1;
      rbPlayDay2.Size = size53;
      rbPlayDay.TabIndex = 0;
      rbPlayDay.Text = "Play during the day";
      RadioButton rbPlayNight1 = rbPlayNight;
      point1 = new Point(40, 32);
      Point point54 = point1;
      rbPlayNight1.Location = point54;
      rbPlayNight.Name = "rbPlayNight";
      RadioButton rbPlayNight2 = rbPlayNight;
      size1 = new Size(128, 16);
      Size size54 = size1;
      rbPlayNight2.Size = size54;
      rbPlayNight.TabIndex = 0;
      rbPlayNight.Text = "Play at night";
      rbPlayAllTimes.Checked = true;
      RadioButton rbPlayAllTimes1 = rbPlayAllTimes;
      point1 = new Point(40, 48);
      Point point55 = point1;
      rbPlayAllTimes1.Location = point55;
      rbPlayAllTimes.Name = "rbPlayAllTimes";
      RadioButton rbPlayAllTimes2 = rbPlayAllTimes;
      size1 = new Size(128, 16);
      Size size55 = size1;
      rbPlayAllTimes2.Size = size55;
      rbPlayAllTimes.TabIndex = 0;
      rbPlayAllTimes.TabStop = true;
      rbPlayAllTimes.Text = "Play at all times";
      RadioButton playSpecificHours1 = rbPlaySpecificHours;
      point1 = new Point(40, 64);
      Point point56 = point1;
      playSpecificHours1.Location = point56;
      rbPlaySpecificHours.Name = "rbPlaySpecificHours";
      RadioButton playSpecificHours2 = rbPlaySpecificHours;
      size1 = new Size(128, 16);
      Size size56 = size1;
      playSpecificHours2.Size = size56;
      rbPlaySpecificHours.TabIndex = 0;
      rbPlaySpecificHours.Text = "Specific Hours";
      pnlHours.Controls.Add(chkb3a);
      pnlHours.Controls.Add(Label21);
      pnlHours.Controls.Add(Label20);
      pnlHours.Controls.Add(Label18);
      pnlHours.Controls.Add(chkb3p);
      pnlHours.Controls.Add(chkb10p);
      pnlHours.Controls.Add(chkb12p);
      pnlHours.Controls.Add(chkb1p);
      pnlHours.Controls.Add(chkb4a);
      pnlHours.Controls.Add(chkb6a);
      pnlHours.Controls.Add(chkb5a);
      pnlHours.Controls.Add(chkb7a);
      pnlHours.Controls.Add(Label25);
      pnlHours.Controls.Add(chkb8p);
      pnlHours.Controls.Add(chkb2p);
      pnlHours.Controls.Add(chkb9p);
      pnlHours.Controls.Add(chkb11p);
      pnlHours.Controls.Add(chkb11a);
      pnlHours.Controls.Add(chkb9a);
      pnlHours.Controls.Add(chkb10a);
      pnlHours.Controls.Add(chkb8a);
      pnlHours.Controls.Add(chkb7p);
      pnlHours.Controls.Add(chkb5p);
      pnlHours.Controls.Add(chkb6p);
      pnlHours.Controls.Add(chkb4p);
      pnlHours.Controls.Add(Label13);
      pnlHours.Controls.Add(chkb1a);
      pnlHours.Controls.Add(lblAM);
      pnlHours.Controls.Add(lblPM);
      pnlHours.Controls.Add(Label23);
      pnlHours.Controls.Add(Label24);
      pnlHours.Controls.Add(chkb2a);
      pnlHours.Controls.Add(lbl12);
      pnlHours.Controls.Add(Label17);
      pnlHours.Controls.Add(Label22);
      pnlHours.Controls.Add(Label14);
      pnlHours.Controls.Add(chkb12a);
      pnlHours.Controls.Add(Label19);
      Panel pnlHours1 = pnlHours;
      point1 = new Point(40, 80);
      Point point57 = point1;
      pnlHours1.Location = point57;
      pnlHours.Name = "pnlHours";
      Panel pnlHours2 = pnlHours;
      size1 = new Size(352, 72);
      Size size57 = size1;
      pnlHours2.Size = size57;
      pnlHours.TabIndex = 4;
      CheckBox chkb3a1 = chkb3a;
      point1 = new Point(128, 24);
      Point point58 = point1;
      chkb3a1.Location = point58;
      chkb3a.Name = "chkb3a";
      CheckBox chkb3a2 = chkb3a;
      size1 = new Size(16, 16);
      Size size58 = size1;
      chkb3a2.Size = size58;
      chkb3a.TabIndex = 1;
      chkb3a.Tag = "3";
      chkb3a.TextAlign = ContentAlignment.TopCenter;
      Label label21_1 = Label21;
      point1 = new Point(224, 8);
      Point point59 = point1;
      label21_1.Location = point59;
      Label21.Name = "Label21";
      Label label21_2 = Label21;
      size1 = new Size(16, 16);
      Size size59 = size1;
      label21_2.Size = size59;
      Label21.TabIndex = 3;
      Label21.Text = "7";
      Label label20_1 = Label20;
      point1 = new Point(200, 8);
      Point point60 = point1;
      label20_1.Location = point60;
      Label20.Name = "Label20";
      Label label20_2 = Label20;
      size1 = new Size(16, 16);
      Size size60 = size1;
      label20_2.Size = size60;
      Label20.TabIndex = 3;
      Label20.Text = "6";
      Label label18_1 = Label18;
      point1 = new Point(152, 8);
      Point point61 = point1;
      label18_1.Location = point61;
      Label18.Name = "Label18";
      Label label18_2 = Label18;
      size1 = new Size(16, 16);
      Size size61 = size1;
      label18_2.Size = size61;
      Label18.TabIndex = 3;
      Label18.Text = "4";
      CheckBox chkb3p1 = chkb3p;
      point1 = new Point(128, 48);
      Point point62 = point1;
      chkb3p1.Location = point62;
      chkb3p.Name = "chkb3p";
      CheckBox chkb3p2 = chkb3p;
      size1 = new Size(16, 16);
      Size size62 = size1;
      chkb3p2.Size = size62;
      chkb3p.TabIndex = 1;
      chkb3p.Tag = "15";
      chkb3p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb10p1 = chkb10p;
      point1 = new Point(296, 48);
      Point point63 = point1;
      chkb10p1.Location = point63;
      chkb10p.Name = "chkb10p";
      CheckBox chkb10p2 = chkb10p;
      size1 = new Size(16, 16);
      Size size63 = size1;
      chkb10p2.Size = size63;
      chkb10p.TabIndex = 1;
      chkb10p.Tag = "22";
      chkb10p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb12p1 = chkb12p;
      point1 = new Point(56, 48);
      Point point64 = point1;
      chkb12p1.Location = point64;
      chkb12p.Name = "chkb12p";
      CheckBox chkb12p2 = chkb12p;
      size1 = new Size(16, 16);
      Size size64 = size1;
      chkb12p2.Size = size64;
      chkb12p.TabIndex = 1;
      chkb12p.Tag = "12";
      chkb12p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb1p1 = chkb1p;
      point1 = new Point(80, 48);
      Point point65 = point1;
      chkb1p1.Location = point65;
      chkb1p.Name = "chkb1p";
      CheckBox chkb1p2 = chkb1p;
      size1 = new Size(16, 16);
      Size size65 = size1;
      chkb1p2.Size = size65;
      chkb1p.TabIndex = 1;
      chkb1p.Tag = "13";
      chkb1p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb4a1 = chkb4a;
      point1 = new Point(152, 24);
      Point point66 = point1;
      chkb4a1.Location = point66;
      chkb4a.Name = "chkb4a";
      CheckBox chkb4a2 = chkb4a;
      size1 = new Size(16, 16);
      Size size66 = size1;
      chkb4a2.Size = size66;
      chkb4a.TabIndex = 1;
      chkb4a.Tag = "4";
      chkb4a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb6a1 = chkb6a;
      point1 = new Point(200, 24);
      Point point67 = point1;
      chkb6a1.Location = point67;
      chkb6a.Name = "chkb6a";
      CheckBox chkb6a2 = chkb6a;
      size1 = new Size(16, 16);
      Size size67 = size1;
      chkb6a2.Size = size67;
      chkb6a.TabIndex = 1;
      chkb6a.Tag = "6";
      chkb6a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb5a1 = chkb5a;
      point1 = new Point(176, 24);
      Point point68 = point1;
      chkb5a1.Location = point68;
      chkb5a.Name = "chkb5a";
      CheckBox chkb5a2 = chkb5a;
      size1 = new Size(16, 16);
      Size size68 = size1;
      chkb5a2.Size = size68;
      chkb5a.TabIndex = 1;
      chkb5a.Tag = "5";
      chkb5a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb7a1 = chkb7a;
      point1 = new Point(224, 24);
      Point point69 = point1;
      chkb7a1.Location = point69;
      chkb7a.Name = "chkb7a";
      CheckBox chkb7a2 = chkb7a;
      size1 = new Size(16, 16);
      Size size69 = size1;
      chkb7a2.Size = size69;
      chkb7a.TabIndex = 1;
      chkb7a.Tag = "7";
      chkb7a.TextAlign = ContentAlignment.TopCenter;
      Label label25_1 = Label25;
      point1 = new Point(318, 8);
      Point point70 = point1;
      label25_1.Location = point70;
      Label25.Name = "Label25";
      Label label25_2 = Label25;
      size1 = new Size(24, 16);
      Size size70 = size1;
      label25_2.Size = size70;
      Label25.TabIndex = 3;
      Label25.Text = "11";
      CheckBox chkb8p1 = chkb8p;
      point1 = new Point(248, 48);
      Point point71 = point1;
      chkb8p1.Location = point71;
      chkb8p.Name = "chkb8p";
      CheckBox chkb8p2 = chkb8p;
      size1 = new Size(16, 16);
      Size size71 = size1;
      chkb8p2.Size = size71;
      chkb8p.TabIndex = 1;
      chkb8p.Tag = "20";
      chkb8p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb2p1 = chkb2p;
      point1 = new Point(104, 48);
      Point point72 = point1;
      chkb2p1.Location = point72;
      chkb2p.Name = "chkb2p";
      CheckBox chkb2p2 = chkb2p;
      size1 = new Size(16, 16);
      Size size72 = size1;
      chkb2p2.Size = size72;
      chkb2p.TabIndex = 1;
      chkb2p.Tag = "14";
      chkb2p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb9p1 = chkb9p;
      point1 = new Point(272, 48);
      Point point73 = point1;
      chkb9p1.Location = point73;
      chkb9p.Name = "chkb9p";
      CheckBox chkb9p2 = chkb9p;
      size1 = new Size(16, 16);
      Size size73 = size1;
      chkb9p2.Size = size73;
      chkb9p.TabIndex = 1;
      chkb9p.Tag = "21";
      chkb9p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb11p1 = chkb11p;
      point1 = new Point(320, 48);
      Point point74 = point1;
      chkb11p1.Location = point74;
      chkb11p.Name = "chkb11p";
      CheckBox chkb11p2 = chkb11p;
      size1 = new Size(16, 16);
      Size size74 = size1;
      chkb11p2.Size = size74;
      chkb11p.TabIndex = 1;
      chkb11p.Tag = "23";
      chkb11p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb11a1 = chkb11a;
      point1 = new Point(320, 24);
      Point point75 = point1;
      chkb11a1.Location = point75;
      chkb11a.Name = "chkb11a";
      CheckBox chkb11a2 = chkb11a;
      size1 = new Size(16, 16);
      Size size75 = size1;
      chkb11a2.Size = size75;
      chkb11a.TabIndex = 1;
      chkb11a.Tag = "11";
      chkb11a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb9a1 = chkb9a;
      point1 = new Point(272, 24);
      Point point76 = point1;
      chkb9a1.Location = point76;
      chkb9a.Name = "chkb9a";
      CheckBox chkb9a2 = chkb9a;
      size1 = new Size(16, 16);
      Size size76 = size1;
      chkb9a2.Size = size76;
      chkb9a.TabIndex = 1;
      chkb9a.Tag = "9";
      chkb9a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb10a1 = chkb10a;
      point1 = new Point(296, 24);
      Point point77 = point1;
      chkb10a1.Location = point77;
      chkb10a.Name = "chkb10a";
      CheckBox chkb10a2 = chkb10a;
      size1 = new Size(16, 16);
      Size size77 = size1;
      chkb10a2.Size = size77;
      chkb10a.TabIndex = 1;
      chkb10a.Tag = "10";
      chkb10a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb8a1 = chkb8a;
      point1 = new Point(248, 24);
      Point point78 = point1;
      chkb8a1.Location = point78;
      chkb8a.Name = "chkb8a";
      CheckBox chkb8a2 = chkb8a;
      size1 = new Size(16, 16);
      Size size78 = size1;
      chkb8a2.Size = size78;
      chkb8a.TabIndex = 1;
      chkb8a.Tag = "8";
      chkb8a.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb7p1 = chkb7p;
      point1 = new Point(224, 48);
      Point point79 = point1;
      chkb7p1.Location = point79;
      chkb7p.Name = "chkb7p";
      CheckBox chkb7p2 = chkb7p;
      size1 = new Size(16, 16);
      Size size79 = size1;
      chkb7p2.Size = size79;
      chkb7p.TabIndex = 1;
      chkb7p.Tag = "19";
      chkb7p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb5p1 = chkb5p;
      point1 = new Point(176, 48);
      Point point80 = point1;
      chkb5p1.Location = point80;
      chkb5p.Name = "chkb5p";
      CheckBox chkb5p2 = chkb5p;
      size1 = new Size(16, 16);
      Size size80 = size1;
      chkb5p2.Size = size80;
      chkb5p.TabIndex = 1;
      chkb5p.Tag = "17";
      chkb5p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb6p1 = chkb6p;
      point1 = new Point(200, 48);
      Point point81 = point1;
      chkb6p1.Location = point81;
      chkb6p.Name = "chkb6p";
      CheckBox chkb6p2 = chkb6p;
      size1 = new Size(16, 16);
      Size size81 = size1;
      chkb6p2.Size = size81;
      chkb6p.TabIndex = 1;
      chkb6p.Tag = "18";
      chkb6p.TextAlign = ContentAlignment.TopCenter;
      CheckBox chkb4p1 = chkb4p;
      point1 = new Point(152, 48);
      Point point82 = point1;
      chkb4p1.Location = point82;
      chkb4p.Name = "chkb4p";
      CheckBox chkb4p2 = chkb4p;
      size1 = new Size(16, 16);
      Size size82 = size1;
      chkb4p2.Size = size82;
      chkb4p.TabIndex = 1;
      chkb4p.Tag = "16";
      chkb4p.TextAlign = ContentAlignment.TopCenter;
      Label label13_1 = Label13;
      point1 = new Point(80, 8);
      Point point83 = point1;
      label13_1.Location = point83;
      Label13.Name = "Label13";
      Label label13_2 = Label13;
      size1 = new Size(16, 16);
      Size size83 = size1;
      label13_2.Size = size83;
      Label13.TabIndex = 3;
      Label13.Text = "1";
      CheckBox chkb1a1 = chkb1a;
      point1 = new Point(80, 24);
      Point point84 = point1;
      chkb1a1.Location = point84;
      chkb1a.Name = "chkb1a";
      CheckBox chkb1a2 = chkb1a;
      size1 = new Size(16, 16);
      Size size84 = size1;
      chkb1a2.Size = size84;
      chkb1a.TabIndex = 1;
      chkb1a.Tag = "1";
      chkb1a.TextAlign = ContentAlignment.TopCenter;
      Label lblAm1 = lblAM;
      point1 = new Point(16, 24);
      Point point85 = point1;
      lblAm1.Location = point85;
      lblAM.Name = "lblAM";
      Label lblAm2 = lblAM;
      size1 = new Size(24, 16);
      Size size85 = size1;
      lblAm2.Size = size85;
      lblAM.TabIndex = 3;
      lblAM.Text = "AM";
      Label lblPm1 = lblPM;
      point1 = new Point(16, 48);
      Point point86 = point1;
      lblPm1.Location = point86;
      lblPM.Name = "lblPM";
      Label lblPm2 = lblPM;
      size1 = new Size(24, 16);
      Size size86 = size1;
      lblPm2.Size = size86;
      lblPM.TabIndex = 3;
      lblPM.Text = "PM";
      Label label23_1 = Label23;
      point1 = new Point(272, 8);
      Point point87 = point1;
      label23_1.Location = point87;
      Label23.Name = "Label23";
      Label label23_2 = Label23;
      size1 = new Size(16, 16);
      Size size87 = size1;
      label23_2.Size = size87;
      Label23.TabIndex = 3;
      Label23.Text = "9";
      Label label24_1 = Label24;
      point1 = new Point(294, 8);
      Point point88 = point1;
      label24_1.Location = point88;
      Label24.Name = "Label24";
      Label label24_2 = Label24;
      size1 = new Size(24, 16);
      Size size88 = size1;
      label24_2.Size = size88;
      Label24.TabIndex = 3;
      Label24.Text = "10";
      CheckBox chkb2a1 = chkb2a;
      point1 = new Point(104, 24);
      Point point89 = point1;
      chkb2a1.Location = point89;
      chkb2a.Name = "chkb2a";
      CheckBox chkb2a2 = chkb2a;
      size1 = new Size(16, 16);
      Size size89 = size1;
      chkb2a2.Size = size89;
      chkb2a.TabIndex = 1;
      chkb2a.Tag = "2";
      chkb2a.TextAlign = ContentAlignment.TopCenter;
      Label lbl12_1 = lbl12;
      point1 = new Point(54, 8);
      Point point90 = point1;
      lbl12_1.Location = point90;
      lbl12.Name = "lbl12";
      Label lbl12_2 = lbl12;
      size1 = new Size(24, 16);
      Size size90 = size1;
      lbl12_2.Size = size90;
      lbl12.TabIndex = 3;
      lbl12.Text = "12";
      Label label17_1 = Label17;
      point1 = new Point(128, 8);
      Point point91 = point1;
      label17_1.Location = point91;
      Label17.Name = "Label17";
      Label label17_2 = Label17;
      size1 = new Size(16, 16);
      Size size91 = size1;
      label17_2.Size = size91;
      Label17.TabIndex = 3;
      Label17.Text = "3";
      Label label22_1 = Label22;
      point1 = new Point(248, 8);
      Point point92 = point1;
      label22_1.Location = point92;
      Label22.Name = "Label22";
      Label label22_2 = Label22;
      size1 = new Size(16, 16);
      Size size92 = size1;
      label22_2.Size = size92;
      Label22.TabIndex = 3;
      Label22.Text = "8";
      Label label14_1 = Label14;
      point1 = new Point(104, 8);
      Point point93 = point1;
      label14_1.Location = point93;
      Label14.Name = "Label14";
      Label label14_2 = Label14;
      size1 = new Size(16, 16);
      Size size93 = size1;
      label14_2.Size = size93;
      Label14.TabIndex = 3;
      Label14.Text = "2";
      CheckBox chkb12a1 = chkb12a;
      point1 = new Point(56, 24);
      Point point94 = point1;
      chkb12a1.Location = point94;
      chkb12a.Name = "chkb12a";
      CheckBox chkb12a2 = chkb12a;
      size1 = new Size(16, 16);
      Size size94 = size1;
      chkb12a2.Size = size94;
      chkb12a.TabIndex = 1;
      chkb12a.Tag = "0";
      chkb12a.TextAlign = ContentAlignment.TopCenter;
      Label label19_1 = Label19;
      point1 = new Point(176, 8);
      Point point95 = point1;
      label19_1.Location = point95;
      Label19.Name = "Label19";
      Label label19_2 = Label19;
      size1 = new Size(16, 16);
      Size size95 = size1;
      label19_2.Size = size95;
      Label19.TabIndex = 3;
      Label19.Text = "5";
      this.chkbActive.Checked = true;
      this.chkbActive.CheckState = CheckState.Checked;
      CheckBox chkbActive = this.chkbActive;
      point1 = new Point(32, 16);
      Point point96 = point1;
      chkbActive.Location = point96;
      this.chkbActive.Name = "chkbActive";
      this.chkbActive.TabIndex = 0;
      this.chkbActive.Text = "Active";
      GroupBox6.Controls.Add(rbSequential);
      GroupBox6.Controls.Add(rbRandom);
      GroupBox groupBox6_1 = GroupBox6;
      point1 = new Point(256, 216);
      Point point97 = point1;
      groupBox6_1.Location = point97;
      GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = GroupBox6;
      size1 = new Size(224, 56);
      Size size96 = size1;
      groupBox6_2.Size = size96;
      GroupBox6.TabIndex = 2;
      GroupBox6.TabStop = false;
      GroupBox6.Text = "Play Order";
      rbSequential.Checked = true;
      RadioButton rbSequential1 = rbSequential;
      point1 = new Point(40, 16);
      Point point98 = point1;
      rbSequential1.Location = point98;
      rbSequential.Name = "rbSequential";
      RadioButton rbSequential2 = rbSequential;
      size1 = new Size(104, 16);
      Size size97 = size1;
      rbSequential2.Size = size97;
      rbSequential.TabIndex = 2;
      rbSequential.TabStop = true;
      rbSequential.Text = "Sequential";
      RadioButton rbRandom1 = rbRandom;
      point1 = new Point(40, 32);
      Point point99 = point1;
      rbRandom1.Location = point99;
      rbRandom.Name = "rbRandom";
      RadioButton rbRandom2 = rbRandom;
      size1 = new Size(104, 16);
      Size size98 = size1;
      rbRandom2.Size = size98;
      rbRandom.TabIndex = 1;
      rbRandom.Text = "Random";
      gbInterval.Controls.Add(Label16);
      gbInterval.Controls.Add(Label15);
      gbInterval.Controls.Add(nudInterval);
      gbInterval.Controls.Add(nudIntervalVrtn);
      GroupBox gbInterval1 = gbInterval;
      point1 = new Point(8, 296);
      Point point100 = point1;
      gbInterval1.Location = point100;
      gbInterval.Name = "gbInterval";
      GroupBox gbInterval2 = gbInterval;
      size1 = new Size(472, 72);
      Size size99 = size1;
      gbInterval2.Size = size99;
      gbInterval.TabIndex = 1;
      gbInterval.TabStop = false;
      gbInterval.Text = "Interval";
      Label label16_1 = Label16;
      point1 = new Point(24, 40);
      Point point101 = point1;
      label16_1.Location = point101;
      Label16.Name = "Label16";
      Label label16_2 = Label16;
      size1 = new Size(144, 16);
      Size size100 = size1;
      label16_2.Size = size100;
      Label16.TabIndex = 4;
      Label16.Text = "Interval Variation (seconds)";
      Label label15_1 = Label15;
      point1 = new Point(24, 16);
      Point point102 = point1;
      label15_1.Location = point102;
      Label15.Name = "Label15";
      Label label15_2 = Label15;
      size1 = new Size(232, 16);
      Size size101 = size1;
      label15_2.Size = size101;
      Label15.TabIndex = 3;
      Label15.Text = "Interval between playing sounds (seconds)";
      nudInterval.DecimalPlaces = 2;
      NumericUpDown nudInterval1 = nudInterval;
      point1 = new Point(272, 16);
      Point point103 = point1;
      nudInterval1.Location = point103;
      NumericUpDown nudInterval2 = nudInterval;
      num1 = new Decimal(new int[4]{ 600, 0, 0, 0 });
      Decimal num3 = num1;
      nudInterval2.Maximum = num3;
      nudInterval.Name = "nudInterval";
      NumericUpDown nudInterval3 = nudInterval;
      size1 = new Size(64, 20);
      Size size102 = size1;
      nudInterval3.Size = size102;
      nudInterval.TabIndex = 0;
      nudIntervalVrtn.DecimalPlaces = 2;
      NumericUpDown nudIntervalVrtn1 = nudIntervalVrtn;
      point1 = new Point(272, 40);
      Point point104 = point1;
      nudIntervalVrtn1.Location = point104;
      nudIntervalVrtn.Name = "nudIntervalVrtn";
      NumericUpDown nudIntervalVrtn2 = nudIntervalVrtn;
      size1 = new Size(64, 20);
      Size size103 = size1;
      nudIntervalVrtn2.Size = size103;
      nudIntervalVrtn.TabIndex = 0;
      GroupBox5.Controls.Add(rbOnce);
      GroupBox5.Controls.Add(rbRepeating);
      GroupBox5.Controls.Add(rbLooping);
      GroupBox groupBox5_1 = GroupBox5;
      point1 = new Point(8, 216);
      Point point105 = point1;
      groupBox5_1.Location = point105;
      GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = GroupBox5;
      size1 = new Size(232, 72);
      Size size104 = size1;
      groupBox5_2.Size = size104;
      GroupBox5.TabIndex = 2;
      GroupBox5.TabStop = false;
      GroupBox5.Text = "Play Style";
      rbOnce.Checked = true;
      RadioButton rbOnce1 = rbOnce;
      point1 = new Point(40, 16);
      Point point106 = point1;
      rbOnce1.Location = point106;
      rbOnce.Name = "rbOnce";
      RadioButton rbOnce2 = rbOnce;
      size1 = new Size(104, 16);
      Size size105 = size1;
      rbOnce2.Size = size105;
      rbOnce.TabIndex = 2;
      rbOnce.TabStop = true;
      rbOnce.Text = "Once";
      RadioButton rbRepeating1 = rbRepeating;
      point1 = new Point(40, 32);
      Point point107 = point1;
      rbRepeating1.Location = point107;
      rbRepeating.Name = "rbRepeating";
      RadioButton rbRepeating2 = rbRepeating;
      size1 = new Size(104, 16);
      Size size106 = size1;
      rbRepeating2.Size = size106;
      rbRepeating.TabIndex = 1;
      rbRepeating.Text = "Repeating";
      rbLooping.Enabled = false;
      RadioButton rbLooping1 = rbLooping;
      point1 = new Point(40, 48);
      Point point108 = point1;
      rbLooping1.Location = point108;
      rbLooping.Name = "rbLooping";
      RadioButton rbLooping2 = rbLooping;
      size1 = new Size(136, 16);
      Size size107 = size1;
      rbLooping2.Size = size107;
      rbLooping.TabIndex = 1;
      rbLooping.Text = "Seamlessly looping";
      Button btnSave = this.btnSave;
      point1 = new Point(336, 520);
      Point point109 = point1;
      btnSave.Location = point109;
      this.btnSave.Name = "btnSave";
      this.btnSave.TabIndex = 3;
      this.btnSave.Text = "&Save";
      this.btnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = this.btnCancel;
      point1 = new Point(432, 520);
      Point point110 = point1;
      btnCancel.Location = point110;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.TabIndex = 4;
      this.btnCancel.Text = "&Cancel";
      btnDebug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btnDebug.FlatStyle = FlatStyle.Flat;
      btnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = btnDebug;
      point1 = new Point(0, 0);
      Point point111 = point1;
      btnDebug1.Location = point111;
      btnDebug.Name = "btnDebug";
      Button btnDebug2 = btnDebug;
      size1 = new Size(8, 8);
      Size size108 = size1;
      btnDebug2.Size = size108;
      btnDebug.TabIndex = 19;
      btnDebug.TabStop = false;
      Timer1.Interval = 10;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(536, 549);
      ClientSize = size1;
      Controls.Add(this.btnSave);
      Controls.Add(this.btnCancel);
      Controls.Add(TabControl1);
      Controls.Add(btnDebug);
      Name = nameof (frmUTS_Editor);
      Text = "Sound Editor";
      TabControl1.ResumeLayout(false);
      tabpagBasic.ResumeLayout(false);
      trkbarVolume.EndInit();
      tbapagPositioning.ResumeLayout(false);
      gbHeight.ResumeLayout(false);
      nudElevation.EndInit();
      gbVolumeDistances.ResumeLayout(false);
      nudMaxDistance.EndInit();
      nudMinDistance.EndInit();
      gbRandomRange.ResumeLayout(false);
      nudRandomRangeY.EndInit();
      nudRandomRangeX.EndInit();
      tabpagAdvanced.ResumeLayout(false);
      pnlVolPitch.ResumeLayout(false);
      trkbarVolumeVrtn.EndInit();
      trkbarPitchVrtn.EndInit();
      GroupBox4.ResumeLayout(false);
      pnlHours.ResumeLayout(false);
      GroupBox6.ResumeLayout(false);
      gbInterval.ResumeLayout(false);
      nudInterval.EndInit();
      nudIntervalVrtn.EndInit();
      GroupBox5.ResumeLayout(false);
      ResumeLayout(false);
    }

  public frmUTS_Editor(
    clsUTS UTSClass,
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
      MDefaultTitleText = "Sound Editor - KotOR ";
      Text = MDefaultTitleText;
      if (KotorVerIndex == 0)
        Text += "I";
      else
        Text += "II";
      CurrentSettings = UserSettings.GetSettings();
      UTS = UTSClass;
      KotorVersionIndex = KotorVerIndex;
      Setup();
      result = Factory.System_Create(ref fmSystem);
      result = fmSystem.getVersion(ref FMODversion);
      if (Convert.ToInt32(FMODversion) < Convert.ToInt32(262405))
      {
        int num = (int) MessageBox.Show("Error!  You are using an old version of FMOD " + FMODversion.ToString("X") + ".  This program requires " + 262405.ToString("X") + ".");
      }
      result = fmSystem.init(32, INITFLAG.NORMAL, (IntPtr) ((object) null ?? Activator.CreateInstance(typeof (IntPtr))));
      htBIFSounds = FrmMain.KxChitinKey(KotorVersionIndex).GetBifFileHash("sounds");
      SoundsBifPath = FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\";
      SoundsBifPath += ((BiffEntry) FrmMain.KxChitinKey(KotorVersionIndex).BiffListInfo["sounds"]).Filename;
      SoundsResInfo = BIFFArchive.GetBiffResourceInfoList(SoundsBifPath);
    }

  private void Setup()
  {
      UTS.SetTextBoxFromCExoLocStringNodeValue(tbName, "LocName");
      UTS.SetTextBoxToNodeValue(tbTag, "Tag");
      UTS.SetTextBoxToNodeValue(tbComment, "Comment");
      trkbarVolume.Value = IntegerType.FromObject(UTS.GetNodeValue("Volume"));
      trkbarVolume_ValueChanged(null, null);
      int num1 = checked (UTS.GetListItemCount("Sounds") - 1);
      int num2 = 0;
      while (num2 <= num1)
      {
        lbSounds.Items.Add(RuntimeHelpers.GetObjectValue(UTS.GetNodeValue("Sounds(" + StringType.FromInteger(num2) + ").Sound")));
        checked { ++num2; }
      }
      bool flag1 = BooleanType.FromObject(UTS.GetNodeValue("Positional"));
      bool flag2 = BooleanType.FromObject(UTS.GetNodeValue("RandomPosition"));
      if (!(flag1 | flag2))
        rbPlaysEverywhere.Checked = true;
      else if (flag1 & flag2)
        rbRandomPosition.Checked = true;
      else
        rbSpecificPosition.Checked = true;
      UTS.SetNumericUpDownToNodeValue(nudMaxDistance, "MaxDistance");
      UTS.SetNumericUpDownToNodeValue(nudMinDistance, "MinDistance");
      UTS.SetNumericUpDownToNodeValue(nudElevation, "Elevation");
      UTS.SetNumericUpDownToNodeValue(nudRandomRangeX, "RandomRangeX");
      UTS.SetNumericUpDownToNodeValue(nudRandomRangeY, "RandomRangeY");
      chkbActive.Checked = BooleanType.FromObject(UTS.GetNodeValue("Active"));
      object nodeValue = UTS.GetNodeValue("Times");
      if (ObjectType.ObjTst(nodeValue, 1, false) == 0)
        rbPlayDay.Checked = true;
      else if (ObjectType.ObjTst(nodeValue, 2, false) == 0)
        rbPlayNight.Checked = true;
      else if (ObjectType.ObjTst(nodeValue, 3, false) == 0)
        rbPlayAllTimes.Checked = true;
      else if (ObjectType.ObjTst(nodeValue, 0, false) == 0)
      {
        rbPlaySpecificHours.Checked = true;
        int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(UTS.GetNodeValue("Hours")));
        try
        {
          foreach (Control control in pnlHours.Controls)
          {
            if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0 && ((ulong) int32 & (ulong) checked ((long) Math.Round(Math.Pow(2.0, Convert.ToInt32(RuntimeHelpers.GetObjectValue(control.Tag)))))) > 0UL)
              ((CheckBox) control).Checked = true;
          }
        }
        finally
        {
         
        }
      }
      bool flag3 = BooleanType.FromObject(UTS.GetNodeValue("Continuous"));
      bool flag4 = BooleanType.FromObject(UTS.GetNodeValue("Looping"));
      if (!(flag3 | flag4))
        rbOnce.Checked = true;
      else if (flag3 & !flag4)
        rbRepeating.Checked = true;
      else if (!flag3 & flag4)
        rbLooping.Checked = true;
      if (BooleanType.FromObject(UTS.GetNodeValue("Random")))
        rbRandom.Checked = true;
      else
        rbSequential.Checked = true;
      UTS.SetNumericUpDownToUIntNodeValue(nudInterval, "Interval", 0.01f);
      UTS.SetNumericUpDownToUIntNodeValue(nudIntervalVrtn, "IntervalVrtn", 0.01f);
      trkbarVolumeVrtn.Value = IntegerType.FromObject(UTS.GetNodeValue("VolumeVrtn"));
      trkbarVolumeVrtn_ValueChanged(null, null);
      trkbarPitchVrtn.Value = IntegerType.FromObject(ObjectType.MulObj(UTS.GetNodeValue("PitchVariation"), 100));
      trkbarPitchVrtn_ValueChanged(null, null);
    }

  private void SetGFFNodeValues()
  {
      UTS.SetCExoLocStringNodeValueFromTextBox(tbName, "LocName", NameLang);
      UTS.SetNodeValueFromTextBox(tbTag, "Tag");
      UTS.SetNodeValueFromTextBox(tbComment, "Comment");
      UTS.SetNodeValue("Volume", trkbarVolume.Value);
      UTS.ClearListElements("Sounds");
      int num1 = checked (lbSounds.Items.Count - 1);
      int index = 0;
      while (index <= num1)
      {
        GffStruct @struct = new GffStruct(1, 0);
        @struct.fields[0] = new GFF_Field(GFFField.GFF_CResRef, "Sound", RuntimeHelpers.GetObjectValue(lbSounds.Items[index]));
        UTS.AddListElement("Sounds", @struct);
        checked { ++index; }
      }
      UTS.SetNodeValue("Positional", !rbPlaysEverywhere.Checked);
      UTS.SetNodeValue("RandomPosition", rbRandomPosition.Checked);
      if (rbPlaysEverywhere.Checked)
        UTS.SetNodeValue("Positional", !rbPlaysEverywhere.Checked);
      else
        UTS.SetNodeValue("Positional", !rbPlaysEverywhere.Checked);
      UTS.SetNodeValueFromNumericUpDown(nudMaxDistance, "MaxDistance");
      UTS.SetNodeValueFromNumericUpDown(nudMinDistance, "MinDistance");
      UTS.SetNodeValueFromNumericUpDown(nudElevation, "Elevation");
      UTS.SetNodeValueFromNumericUpDown(nudRandomRangeX, "RandomRangeX");
      UTS.SetNodeValueFromNumericUpDown(nudRandomRangeY, "RandomRangeY");
      UTS.SetNodeValue("Active", chkbActive.Checked);
      if (rbPlayDay.Checked)
        UTS.SetNodeValue("Times", 1);
      else if (rbPlayNight.Checked)
        UTS.SetNodeValue("Times", 2);
      else if (rbPlayAllTimes.Checked)
      {
        UTS.SetNodeValue("Times", 3);
      }
      else
      {
        UTS.SetNodeValue("Times", 0);
        int num2 = 0;
        try
        {
          foreach (Control control in pnlHours.Controls)
          {
            if (StringType.StrCmp(control.GetType().Name, "CheckBox", false) == 0 && ((CheckBox) control).Checked)
              num2 = checked ((int) (num2 | (long) Math.Round(Math.Pow(2.0, Convert.ToInt32(RuntimeHelpers.GetObjectValue(control.Tag))))));
          }
        }
        finally
        {
         
        }
        UTS.SetNodeValue("Hours", num2);
      }
      UTS.SetNodeValue("Continuous", rbRepeating.Checked);
      UTS.SetNodeValue("Looping", rbLooping.Checked);
      UTS.SetNodeValue("Random", rbRandom.Checked);
      UTS.SetUInt32NodeValueFromNumericUpDown(nudInterval, "Interval", 0.01f);
      UTS.SetUInt32NodeValueFromNumericUpDown(nudIntervalVrtn, "IntervalVrtn", 0.01f);
      UTS.SetNodeValue("VolumeVrtn", trkbarVolumeVrtn.Value);
      UTS.SetNodeValue("PitchVariation", trkbarPitchVrtn.Value / 100.0);
    }

  private void btnAddSound_Click(object sender, EventArgs e)
  {
      frmSoundChooser frmSoundChooser = new frmSoundChooser();
      frmSoundChooser.SoundBifFilesHash = htBIFSounds;
      if (htStreamSounds == null)
      {
        htStreamSounds = new Hashtable();
        FileInfo[] files = new DirectoryInfo(FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamSounds").GetFiles();
        int index = 0;
        while (index < files.Length)
        {
          htStreamSounds.Add(files[index].Name, null);
          checked { ++index; }
        }
      }
      frmSoundChooser.StreamSoundsFilesHash = htStreamSounds;
      int num1 = (int) frmSoundChooser.ShowDialog(this);
      if (frmSoundChooser.DialogResult == DialogResult.OK)
      {
        try
        {
          foreach (object selectedSound in frmSoundChooser.SelectedSounds)
          {
            string str = StringType.FromObject(selectedSound);
            if (str.Length > 16)
            {
              int num2 = (int) Interaction.MsgBox("The sound \"" + str + "\"" + " must be renamed to be no more than 16 characters long, not including the extension, to be used." + "\n" + "\n" + "The sound will not be added.", MsgBoxStyle.Critical, "ResRef too long");
            }
            else
              lbSounds.Items.Add(str);
          }
        }
        finally
        {
         
        }
      }
      UpdateUI();
    }

  private void btnRemoveSound_Click(object sender, EventArgs e)
  {
      if (lbSounds.SelectedIndices.Count == 1)
        lbSounds.Items.RemoveAt(lbSounds.SelectedIndex);
      else if (lbSounds.SelectedIndices.Count > 1 && Interaction.MsgBox("Remove all " + StringType.FromInteger(lbSounds.SelectedIndices.Count) + " sounds?", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Confirm removal") == MsgBoxResult.Ok)
      {
        int index = checked (lbSounds.SelectedIndices.Count - 1);
        while (index >= 0)
        {
          lbSounds.Items.RemoveAt(lbSounds.SelectedIndices[index]);
          checked { index += -1; }
        }
      }
      UpdateUI();
    }

  private void btnPlaySound_Click(object sender, EventArgs e)
  {
      if (!PlaySound(StringType.FromObject(ObjectType.StrCatObj(lbSounds.SelectedItem, ".wav"))))
        return;
      btnPlaySound.Enabled = false;
      btnStopSound.Enabled = true;
    }

  private void btnStopSound_Click(object sender, EventArgs e) => StopSound();

  private void btnMoveUp_Click(object sender, EventArgs e)
  {
      int selectedIndex = lbSounds.SelectedIndex;
      if (selectedIndex <= 0)
        return;
      string str = StringType.FromObject(lbSounds.SelectedItem);
      lbSounds.Items[selectedIndex] = RuntimeHelpers.GetObjectValue(lbSounds.Items[checked (selectedIndex - 1)]);
      lbSounds.Items[checked (selectedIndex - 1)] = str;
      checked { --lbSounds.SelectedIndex; }
    }

  private void btnMoveDown_Click(object sender, EventArgs e)
  {
      int selectedIndex = lbSounds.SelectedIndex;
      if (selectedIndex >= checked (lbSounds.Items.Count - 1))
        return;
      string str = StringType.FromObject(lbSounds.SelectedItem);
      lbSounds.Items[selectedIndex] = RuntimeHelpers.GetObjectValue(lbSounds.Items[checked (selectedIndex + 1)]);
      lbSounds.Items[checked (selectedIndex + 1)] = str;
      checked { ++lbSounds.SelectedIndex; }
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
      frmTextEditor.Filename = tbName.Text + ".uts";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = UTS.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

  private void btnSave_Click(object sender, EventArgs e)
  {
      SetGFFNodeValues();
      if (!m_bSaveGameMode)
      {
        MEditingFilePath = StringType.FromObject(FrmMain.GetFilePath("save", CurrentSettings.defaultSaveLocation, Path.GetFileNameWithoutExtension(MEditingFilePath) + ".uts", "", ""));
        if (StringType.StrCmp(MEditingFilePath, "", false) == 0)
          return;
      }
      UTS.WriteFile(MEditingFilePath, "UTS");
      if (!m_bSaveGameMode)
        return;
      Close();
    }

  private void btnCancel_Click(object sender, EventArgs e) => Close();

  private void lbSounds_SelectedIndexChanged(object sender, EventArgs e)
  {
      if (lbSounds.SelectedIndex == -1)
      {
        btnMoveUp.Enabled = false;
        btnMoveDown.Enabled = false;
        btnRemoveSound.Enabled = false;
        btnPlaySound.Enabled = false;
        IsItemSelected = false;
      }
      else
      {
        IsItemSelected = true;
        if (!IsSoundPlaying())
          btnPlaySound.Enabled = true;
        btnRemoveSound.Enabled = true;
        if (lbSounds.Items.Count == 1 | lbSounds.SelectedIndices.Count > 1)
        {
          btnMoveUp.Enabled = false;
          btnMoveDown.Enabled = false;
        }
        else
        {
          if (lbSounds.SelectedIndices.Count != 1)
            return;
          if (lbSounds.SelectedIndex == checked (lbSounds.Items.Count - 1))
          {
            btnMoveUp.Enabled = true;
            btnMoveDown.Enabled = false;
          }
          else if (lbSounds.SelectedIndex == 0)
          {
            btnMoveUp.Enabled = false;
            btnMoveDown.Enabled = true;
          }
          else
          {
            btnMoveUp.Enabled = true;
            btnMoveDown.Enabled = true;
          }
        }
      }
    }

  private void lbSounds_DoubleClick(object sender, EventArgs e)
  {
      if (!(lbSounds.SelectedIndex != -1 & !IsSoundPlaying()))
        return;
      btnPlaySound_Click(null, null);
    }

  private void rbPlaysWhere_CheckedChanged(object sender, EventArgs e)
  {
      gbHeight.Enabled = !rbPlaysEverywhere.Checked;
      gbVolumeDistances.Enabled = !rbPlaysEverywhere.Checked;
      gbRandomRange.Enabled = rbRandomPosition.Checked;
    }

  private void rbPlayDay_CheckedChanged(object sender, EventArgs e) => pnlHours.Enabled = rbPlaySpecificHours.Checked;

  private void rbLooping_CheckedChanged(object sender, EventArgs e)
  {
      rbSequential.Enabled = !rbLooping.Checked;
      rbRandom.Enabled = !rbLooping.Checked;
      pnlVolPitch.Enabled = !rbLooping.Checked;
      gbInterval.Enabled = rbRepeating.Checked;
      if (rbLooping.Checked)
      {
        if (rbRandomPosition.Checked)
          rbPlaysEverywhere.Checked = true;
        rbSequential.Checked = true;
      }
      rbRandomPosition.Enabled = !rbLooping.Checked;
    }

  private void frmUTS_Editor_Load(object sender, EventArgs e) => PositionWindow(GetType().Name);

  private void frmUTS_Editor_Closing(object sender, CancelEventArgs e)
  {
      SaveSettings(GetType().Name);
      ClosedownSound();
    }

  private void trkbarVolumeVrtn_ValueChanged(object sender, EventArgs e) => tbVolumeVrtn.Text = StringType.FromInteger(trkbarVolumeVrtn.Value);

  private void trkbarPitchVrtn_ValueChanged(object sender, EventArgs e) => tbPitchVrtn.Text = StringType.FromDouble(trkbarPitchVrtn.Value / 100.0);

  private void trkbarVolume_ValueChanged(object sender, EventArgs e) => tbVolume.Text = StringType.FromInteger(trkbarVolume.Value);

  private void Timer1_Tick(object sender, EventArgs e)
  {
      if (IsSoundPlaying())
      {
        uint position = 0;
        result = channel.getPosition(ref position, TIMEUNIT.MS);
        Sound sound = null;
        int currentSound = (int) channel.getCurrentSound(ref sound);
        uint length = 0;
        if (sound != null)
        {
          result = sound.getLength(ref length, TIMEUNIT.MS);
          if (result != RESULT.OK && result != RESULT.ERR_INVALID_HANDLE && result != RESULT.ERR_CHANNEL_STOLEN)
            ERRCHECK(result);
        }
        int int32_1 = Convert.ToInt32(length);
        int int32_2 = Convert.ToInt32(position);
        tbSoundStatus.Text = (checked ((long) Math.Round(int32_2 / 1000.0)) / 60L).ToString().PadLeft(2, '0') + ":" + Conversion.Int(int32_2 / 1000.0 % 60.0).ToString().PadLeft(2, '0') + ":" + Conversion.Int(int32_2 / 10.0 % 100.0).ToString().PadLeft(2, '0') + "/" + (checked ((long) Math.Round(int32_1 / 1000.0)) / 60L).ToString().PadLeft(2, '0') + ":" + Conversion.Int(int32_1 / 1000.0 % 60.0).ToString().PadLeft(2, '0') + ":" + Conversion.Int(int32_1 / 10.0 % 100.0).ToString().PadLeft(2, '0');
      }
      else
      {
        btnStopSound.Enabled = false;
        if (IsItemSelected)
          btnPlaySound.Enabled = true;
        Timer1.Enabled = false;
        if (sound1 != null)
        {
          int num = (int) sound1.release();
        }
       /*if (this.StoppedPlayingEvent == null)

          eturn;

        his.StoppedPlayingEvent();*/
      }
    }

  private void ClosedownSound()
  {
      if (channel != null)
      {
        int num1 = (int) channel.stop();
      }
      if (sound1 != null)
      {
        int num2 = (int) sound1.release();
      }
      if (fmSystem == null)
        return;
      result = fmSystem.close();
      result = fmSystem.release();
    }

  private void UpdateUI()
  {
      if (lbSounds.Items.Count > 1)
      {
        rbLooping.Enabled = false;
        if (!rbLooping.Checked)
          return;
        rbOnce.Checked = true;
      }
      else
      {
        rbLooping.Enabled = true;
        rbSequential.Enabled = true;
        rbSequential.Checked = true;
        rbRandom.Enabled = false;
      }
    }

  public void SetFormName(string Name) => Text = "Sound Editor - " + Name;

  public bool PlaySound(string filename)
  {
      BiffVarRsrcEntryInfo varRsrcEntryInfo = null;
      bool flag = false;
      if (htBIFSounds.ContainsKey(filename))
      {
        varRsrcEntryInfo = SoundsResInfo[IntegerType.FromObject(htBIFSounds[filename])];
        filename = SoundsBifPath;
        flag = true;
      }
      else if (File.Exists(g_ProjectPath + "\\extras\\" + filename))
        filename = g_ProjectPath + "\\extras\\" + filename;
      else if (CurrentSettings.bUseOverrideFiles && File.Exists(FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\Override\\" + filename))
        filename = FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\Override\\" + filename;
      else if (File.Exists(FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamSounds\\" + filename))
        filename = FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamSounds\\" + filename;
      else if (File.Exists(FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamVoice\\" + filename))
      {
        filename = FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamVoice\\" + filename;
      }
      else
      {
        if (!File.Exists(FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamMusic\\" + filename))
          return false;
        filename = FrmMain.CurrentSettings.KotorLocation(KotorVersionIndex) + "\\StreamMusic\\" + filename;
      }
      CREATESOUNDEXINFO exinfo = new CREATESOUNDEXINFO();
      exinfo.cbsize = 72;
      if (!flag)
      {
        KtSoundInfo kotorSoundInfo = FrmMain.GetKotorSoundInfo(filename);
        exinfo.length = Convert.ToUInt32(kotorSoundInfo.DataSize);
        exinfo.fileoffset = Convert.ToUInt32(kotorSoundInfo.DataOffset);
      }
      else
      {
        exinfo.length = Convert.ToUInt32(varRsrcEntryInfo.FileSize);
        exinfo.fileoffset = Convert.ToUInt32(varRsrcEntryInfo.Offset);
      }
      result = fmSystem.createSound(filename, MODE._2D | MODE.HARDWARE | MODE.CREATESTREAM | MODE.MPEGSEARCH, ref exinfo, ref sound1);
      result = fmSystem.playSound(CHANNELINDEX.FREE, sound1, false, ref channel);
      Timer1.Enabled = true;
      return true;
    }

  public void StopSound()
  {
      int num1 = (int) channel.stop();
      Timer1.Enabled = false;
      btnStopSound.Enabled = false;
      btnPlaySound.Enabled = true;
      if (sound1 == null)
        return;
      int num2 = (int) sound1.release();
    }

  public bool IsSoundPlaying()
  {
      bool isplaying = false;
      if (channel != null)
        result = channel.isPlaying(ref isplaying);
      return isplaying;
    }

  private void ERRCHECK(RESULT result)
  {
      if (result == RESULT.OK)
        ;
    }

  public delegate void StoppedPlayingEventHandler();
}